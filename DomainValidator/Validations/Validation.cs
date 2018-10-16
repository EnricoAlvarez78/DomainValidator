using DomainValidator.Notifications;

namespace DomainValidator.Validations
{
    public partial class Validation : Notifiable
    {
        public Validation Requires()
        {
            return this;
        }

        public Validation Join(params Notifiable[] items)
        {
            if (items != null)
            {
                foreach (var notifiable in items)
                {
                    if (!notifiable.IsValid)
                        AddNotifications(notifiable.Notifications);
                }
            }

            return this;
        }
    }
}
