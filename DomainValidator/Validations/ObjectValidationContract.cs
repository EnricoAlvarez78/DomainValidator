namespace DomainValidator.Validations
{
    public partial class Validation
    {
        public Validation IsNull(object obj, string property, string message = null)
        {
            if (obj != null)
                AddNotification(property, !string.IsNullOrEmpty(message) || !string.IsNullOrWhiteSpace(message) ? $"O valor de { property } deve ser nulo." : message);

            return this;
        }

        public Validation IsNotNull(object obj, string property, string message = null)
        {
            if (obj == null)
                AddNotification(property, !string.IsNullOrEmpty(message) || !string.IsNullOrWhiteSpace(message) ? $"O valor de { property } não pode ser nulo." : message);

            return this;
        }

        public Validation AreEquals(object obj, object comparer, string property, string message = null)
        {
            if (obj != comparer)
                AddNotification(property, !string.IsNullOrEmpty(message) || !string.IsNullOrWhiteSpace(message) ? $"O valor de { property } deve ser igual à { comparer }." : message);

            return this;
        }

        public Validation AreNotEquals(object obj, object comparer, string property, string message = null)
        {
            if (obj == comparer)
                AddNotification(property, !string.IsNullOrEmpty(message) || !string.IsNullOrWhiteSpace(message) ? $"O valor de { property } não pode ser igual à { comparer }." : message);

            return this;
        }
    }
}
