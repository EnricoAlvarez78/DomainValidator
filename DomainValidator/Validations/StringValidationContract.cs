using System.Text.RegularExpressions;

namespace DomainValidator.Validations
{
    public partial class Validation
    {
        public Validation IsNotNullOrEmpty(string val, string property, string message = null)
        {
            if (string.IsNullOrEmpty(val) || string.IsNullOrWhiteSpace(val))
                AddNotification(property, !string.IsNullOrEmpty(message) || !string.IsNullOrWhiteSpace(message) ? $"O valor de { property } não pode ser nulo ou vazio." : message);

            return this;
        }

        public Validation IsNullOrEmpty(string val, string property, string message = null)
        {
            if (!string.IsNullOrEmpty(val) || !string.IsNullOrWhiteSpace(val))
                AddNotification(property, !string.IsNullOrEmpty(message) || !string.IsNullOrWhiteSpace(message) ? $"O valor de { property } deve ser nulo ou vazio." : message);

            return this;
        }

        public Validation HasMinLen(string val, int min, string property, string message = null)
        {
            if (string.IsNullOrEmpty(val) || string.IsNullOrWhiteSpace(val) || val.Length < min)
                AddNotification(property, !string.IsNullOrEmpty(message) || !string.IsNullOrWhiteSpace(message) ? $"O valor de { property } deve possuir no mínimo { min } caracteres." : message);

            return this;
        }

        public Validation HasMaxLen(string val, int max, string property, string message = null)
        {
            if (string.IsNullOrEmpty(val) || string.IsNullOrWhiteSpace(val) || val.Length > max)
                AddNotification(property, !string.IsNullOrEmpty(message) || !string.IsNullOrWhiteSpace(message) ? $"O valor de { property } deve possuir no máximo { max } caracteres." : message);

            return this;
        }

        public Validation HasLen(string val, int len, string property, string message = null)
        {
            if (string.IsNullOrEmpty(val) || string.IsNullOrWhiteSpace(val) || val.Length != len)
                AddNotification(property, !string.IsNullOrEmpty(message) || !string.IsNullOrWhiteSpace(message) ? $"O valor de { property } deve possuir { len } caracteres." : message);

            return this;
        }

        public Validation Contains(string val, string text, string property, string message = null)
        {
            // TODO: StringComparison.OrdinalIgnoreCase not suported yet
            if (string.IsNullOrEmpty(val) || string.IsNullOrWhiteSpace(val) || string.IsNullOrEmpty(text) || !val.ToLower().Contains(text.ToLower()))
                AddNotification(property, !string.IsNullOrEmpty(message) || !string.IsNullOrWhiteSpace(message) ? $"O valor de { property } deve conter { text }." : message);

            return this;
        }

        public Validation AreEquals(string val, string text, string property, string message = null)
        {
            // TODO: StringComparison.OrdinalIgnoreCase not suported yet
            if (string.IsNullOrEmpty(val) || string.IsNullOrWhiteSpace(val) || string.IsNullOrEmpty(text) || val.ToLower() != text.ToLower())
                AddNotification(property, !string.IsNullOrEmpty(message) || !string.IsNullOrWhiteSpace(message) ? $"O valor de { property } deve ser igual à { text }." : message);

            return this;
        }

        public Validation AreNotEquals(string val, string text, string property, string message = null)
        {
            // TODO: StringComparison.OrdinalIgnoreCase not suported yet
            if (string.IsNullOrEmpty(val) || string.IsNullOrWhiteSpace(val) || string.IsNullOrEmpty(text) || val == text)
                AddNotification(property, !string.IsNullOrEmpty(message) || !string.IsNullOrWhiteSpace(message) ? $"O valor de { property } não deve ser igual à { text }." : message);

            return this;
        }

        public Validation IsEmail(string email, string property, string message = null)
        {
            const string pattern = @"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$";
            return Matchs(email, pattern, property, !string.IsNullOrEmpty(message) || !string.IsNullOrWhiteSpace(message) ? $"O valor de { property } não é um e-mail válido." : message);
        }

        public Validation IsEmailOrEmpty(string email, string property, string message = null)
        {
            if (string.IsNullOrEmpty(email) || string.IsNullOrWhiteSpace(email))
                return this;

            return IsEmail(email, property, !string.IsNullOrEmpty(message) || !string.IsNullOrWhiteSpace(message) ? $"O valor de { property } não é um e-mail válido e também não é vazio." : message);
        }

        public Validation IsUrl(string url, string property, string message = null)
        {
            const string pattern = @"^(http:\/\/www\.|https:\/\/www\.|http:\/\/|https:\/\/)[a-z0-9]+([\-\.]{1}[a-z0-9]+)*\.[a-z]{2,5}(:[0-9]{1,5})?(\/.*)?$";
            return Matchs(url, pattern, property, !string.IsNullOrEmpty(message) || !string.IsNullOrWhiteSpace(message) ? $"O valor de { property } não é uma Url válida." : message);
        }

        public Validation IsUrlOrEmpty(string url, string property, string message = null)
        {
            if (string.IsNullOrEmpty(url) || string.IsNullOrWhiteSpace(url))
                return this;

            return IsUrl(url, property, !string.IsNullOrEmpty(message) || !string.IsNullOrWhiteSpace(message) ? $"O valor de { property } não é uma Url válida e também não é vazio." : message);
        }

        public Validation Matchs(string text, string pattern, string property, string message = null)
        {
            if (!Regex.IsMatch(text ?? "", pattern))
                AddNotification(property, !string.IsNullOrEmpty(message) || !string.IsNullOrWhiteSpace(message) ? $"O valor de { property } não é válido." : message);

            return this;
        }
    }
}
