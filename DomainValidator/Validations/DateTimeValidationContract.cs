using System;

namespace DomainValidator.Validations
{
    public partial class Validation
    {
        public Validation IsGreaterThan(DateTime val, DateTime comparer, string property, string message = null)
        {
            if (val <= comparer)
                AddNotification(property, string.IsNullOrEmpty(message) || string.IsNullOrWhiteSpace(message) ? $"O valor de { property } deve ser maior do que { comparer }." : message);

            return this;
        }

        public Validation IsGreaterOrEqualsThan(DateTime val, DateTime comparer, string property, string message = null)
        {
            if (val < comparer)
                AddNotification(property, string.IsNullOrEmpty(message) || string.IsNullOrWhiteSpace(message) ? $"O valor de { property } deve ser maior ou igual à { comparer }." : message);

            return this;
        }

        public Validation IsLowerThan(DateTime val, DateTime comparer, string property, string message = null)
        {
            if (val >= comparer)
                AddNotification(property, string.IsNullOrEmpty(message) || string.IsNullOrWhiteSpace(message) ? $"O valor de { property } deve ser menor do que { comparer }." : message);

            return this;
        }

        public Validation IsLowerOrEqualsThan(DateTime val, DateTime comparer, string property, string message = null)
        {
            if (val > comparer)
                AddNotification(property, string.IsNullOrEmpty(message) || string.IsNullOrWhiteSpace(message) ? $"O valor de { property } deve ser menor ou igual à { comparer }." : message);

            return this;
        }

        public Validation IsBetween(DateTime val, DateTime from, DateTime to, string property, string message = null)
        {
            if (!(val > from && val < to))
                AddNotification(property, string.IsNullOrEmpty(message) || string.IsNullOrWhiteSpace(message) ? $"O valor de { property } deve ser entre { from } e { to }." : message);

            return this;
        }
    }
}
