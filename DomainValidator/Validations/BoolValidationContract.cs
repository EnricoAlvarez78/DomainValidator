namespace DomainValidator.Validations
{
    public partial class Validation
    {
        public Validation IsTrue(bool val, string property, string message)
        {
            if (!val)
                AddNotification(property, message);

            return this;
        }

        public Validation IsFalse(bool val, string property, string message)
        {
            if (val)
                AddNotification(property, message);

            return this;
        }
    }
}
