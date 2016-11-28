using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enqueue.Data.Repositories
{
    public class TokenRepo
    {
        public IssueToken_Result GetToken(int providerId, int consumerId, int locationId, string patientName,
            string phone, bool onlineToken)
        {
            using (var db = new EnqueueEntities())
            {
                var error = new ObjectParameter("ErrorMessage", typeof (string));
                var result =
                    db.IssueToken(onlineToken, providerId, locationId, consumerId, null, phone, patientName, true,
                        error).FirstOrDefault();
                if (error.Value != null && !string.IsNullOrEmpty(error.Value.ToString()))
                    throw new Exception(error.Value.ToString());
                return result;
            }
        }

        public GetCurrentToken_Result GetCurrentToken(int consumerId, int locationId, int providerId)
        {
            using (var db = new EnqueueEntities())
            {
                var result = db.GetCurrentToken(consumerId, locationId, providerId, null).FirstOrDefault();
                return result;
            }
        }

        public GetCurrentToken_Result NextToken(int consumerId, int locationId, int providerId)
        {
            using (var db = new EnqueueEntities())
            {
                var result = new GetCurrentToken_Result();
                    // db.up(consumerId, locationId, providerId, null).FirstOrDefault();
                return result;
            }
        }
        public bool UpdateTokenComments(int tokenId, bool isComplete,int rating,string comments)
        {
            try
            {
                using (var db = new EnqueueEntities())
                {
                    var result = db.TokenComments.Add(new TokenComment { TokenId = tokenId, Status = isComplete, Rating = rating, Comments = comments });
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool UpdateTokenPayment(int tokenId, bool followUp, decimal amount)
        {
            try
            {
                using (var db = new EnqueueEntities())
                {
                    var result = db.TokenPayments.Add(new TokenPayment
                    {
                        TokenId = tokenId,
                        IsFollowUp = followUp,
                        PaymentAmount = amount
                    });
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

    }
}
