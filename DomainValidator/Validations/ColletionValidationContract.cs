using System.Collections.Generic;
using System.Linq;

namespace DomainValidator.Validations
{
    public partial class Validation
    {
        public Validation IsNotNullOrEmpty(IEnumerable<object> val, string property, string message = null)
        {
            if (val == null)
                AddNotification(property, !string.IsNullOrEmpty(message) || !string.IsNullOrWhiteSpace(message) ? $"O valor de { property } não pode ser nulo." : message);
            else if (val != null && !val.Any())
                AddNotification(property, !string.IsNullOrEmpty(message) || !string.IsNullOrWhiteSpace(message) ? $"O valor de { property } não pode ser vazio." : message);

            return this;
        }
    }
}
