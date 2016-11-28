using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enqueue.Data.Repositories
{
    public class ConsumerRepo
    {
        public string RegisterConsumer(Consumer consumer)
        {
            using (var db = new EnqueueEntities())
            {
                var error = new ObjectParameter("ErrorMessage", typeof (string));
                db.RegisterConsumer(consumer.UserName, consumer.Password, consumer.FullName, consumer.Email,
                    consumer.Phone, consumer.IsWebUser, consumer.IsAppUser, error);
                if (!string.IsNullOrEmpty(error.Value.ToString()))
                    return
                        error.Value.ToString();
                return "success";
            }
        }
        public LoginConsumer_Result LoginConsumer(Consumer consumer)
        {
            using (var db = new EnqueueEntities())
            {
                var error = new ObjectParameter("ErrorMessage", typeof(string));
                var result = db.LoginConsumer(consumer.UserName, consumer.Password);
                return result.FirstOrDefault();
            }
        }
    }
}
