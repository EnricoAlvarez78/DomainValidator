namespace DomainValidator.Validations
{
    public partial class Validation
    {
        #region IsGreaterThan
        public Validation IsGreaterThan(decimal val, decimal comparer, string property, string message)
        {
            if (val <= comparer)
                AddNotification(property, message);

            return this;
        }

        public Validation IsGreaterThan(double val, decimal comparer, string property, string message)
        {
            if (val <= (double)comparer)
                AddNotification(property, message);

            return this;
        }

        public Validation IsGreaterThan(float val, decimal comparer, string property, string message)
        {
            if (val <= (float)comparer)
                AddNotification(property, message);

            return this;
        }

        public Validation IsGreaterThan(int val, decimal comparer, string property, string message)
        {
            if (val <= comparer)
                AddNotification(property, message);

            return this;
        }
        #endregion

        #region IsGreaterOrEqualsThan
        public Validation IsGreaterOrEqualsThan(decimal val, decimal comparer, string property, string message)
        {
            if (val < comparer)
                AddNotification(property, message);

            return this;
        }

        public Validation IsGreaterOrEqualsThan(double val, decimal comparer, string property, string message)
        {
            if (val < (double)comparer)
                AddNotification(property, message);

            return this;
        }

        public Validation IsGreaterOrEqualsThan(float val, decimal comparer, string property, string message)
        {
            if (val < (float)comparer)
                AddNotification(property, message);

            return this;
        }

        public Validation IsGreaterOrEqualsThan(int val, decimal comparer, string property, string message)
        {
            if (val < comparer)
                AddNotification(property, message);

            return this;
        }
        #endregion

        #region IsLowerThan
        public Validation IsLowerThan(decimal val, decimal comparer, string property, string message)
        {
            if (val >= comparer)
                AddNotification(property, message);

            return this;
        }

        public Validation IsLowerThan(double val, decimal comparer, string property, string message)
        {
            if (val >= (double)comparer)
                AddNotification(property, message);

            return this;
        }

        public Validation IsLowerThan(float val, decimal comparer, string property, string message)
        {
            if (val >= (float)comparer)
                AddNotification(property, message);

            return this;
        }

        public Validation IsLowerThan(int val, decimal comparer, string property, string message)
        {
            if (val >= comparer)
                AddNotification(property, message);

            return this;
        }
        #endregion

        #region IsLowerOrEqualsThan
        public Validation IsLowerOrEqualsThan(decimal val, decimal comparer, string property, string message)
        {
            if (val > comparer)
                AddNotification(property, message);

            return this;
        }

        public Validation IsLowerOrEqualsThan(double val, decimal comparer, string property, string message)
        {
            if (val > (double)comparer)
                AddNotification(property, message);

            return this;
        }

        public Validation IsLowerOrEqualsThan(float val, decimal comparer, string property, string message)
        {
            if (val > (float)comparer)
                AddNotification(property, message);

            return this;
        }

        public Validation IsLowerOrEqualsThan(int val, decimal comparer, string property, string message)
        {
            if (val > comparer)
                AddNotification(property, message);

            return this;
        }
        #endregion

        #region AreEquals
        public Validation AreEquals(decimal val, decimal comparer, string property, string message)
        {
            if (val != comparer)
                AddNotification(property, message);

            return this;
        }

        public Validation AreEquals(double val, decimal comparer, string property, string message)
        {
            if (val != (double)comparer)
                AddNotification(property, message);

            return this;
        }

        public Validation AreEquals(float val, decimal comparer, string property, string message)
        {
            if (val != (float)comparer)
                AddNotification(property, message);

            return this;
        }

        public Validation AreEquals(int val, decimal comparer, string property, string message)
        {
            if (val != comparer)
                AddNotification(property, message);

            return this;
        }
        #endregion

        #region AreNotEquals
        public Validation AreNotEquals(decimal val, decimal comparer, string property, string message)
        {
            if (val == comparer)
                AddNotification(property, message);

            return this;
        }

        public Validation AreNotEquals(double val, decimal comparer, string property, string message)
        {
            if (val == (double)comparer)
                AddNotification(property, message);

            return this;
        }

        public Validation AreNotEquals(float val, decimal comparer, string property, string message)
        {
            if (val == (float)comparer)
                AddNotification(property, message);

            return this;
        }

        public Validation AreNotEquals(int val, decimal comparer, string property, string message)
        {
            if (val == comparer)
                AddNotification(property, message);

            return this;
        }
        #endregion

        #region Between
        public Validation IsBetween(decimal val, decimal from, decimal to, string property, string message)
        {
            if (!(val > from && val < to))
                AddNotification(property, message);

            return this;
        }
        #endregion
    }
}
