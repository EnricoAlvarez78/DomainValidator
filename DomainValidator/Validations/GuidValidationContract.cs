using System;

namespace DomainValidator.Validations
{
    public partial class Validation
    {
        public Validation AreEquals(Guid val, Guid comparer, string property, string message)
        {
            // TODO: StringComparison.OrdinalIgnoreCase not suported yet
            if (val.ToString() != comparer.ToString())
                AddNotification(property, message);

            return this;
        }

        public Validation AreNotEquals(Guid val, Guid comparer, string property, string message)
        {
            // TODO: StringComparison.OrdinalIgnoreCase not suported yet
            if (val.ToString() == comparer.ToString())
                AddNotification(property, message);

            return this;
        }

        public Validation IsEmpty(Guid val, string property, string message)
        {
            if (val != Guid.Empty)
                AddNotification(property, message);

            return this;
        }

        public Validation IsNotEmpty(Guid val, string property, string message)
        {
            if (val == Guid.Empty)
                AddNotification(property, message);

            return this;
        }
    }
}
