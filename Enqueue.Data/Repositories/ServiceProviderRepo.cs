using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enqueue.Data.Repositories
{
    public class ServiceProviderRepo
    {
        public string RegisterProvider(ServiceProvider provider)
        {
            using (var db = new EnqueueEntities())
            {
                var error = new ObjectParameter("ErrorMessage", typeof(string));
                db.CreateUpdateServiceProvider(provider.Id,provider.UserName, provider.Password,provider.Code, provider.Name,
                    provider.Qualification,provider.RegistrationNo,provider.Email,provider.ContactNo,provider.Website,
                    provider.OrganizationId,provider.IsActive,error);
                if (!string.IsNullOrEmpty(error.Value.ToString()))
                    return
                        error.Value.ToString();
                return "success";
            }
        }

        public LoginServiceProvider_Result LoginProvider(ServiceProvider provider)
        {
            using (var db = new EnqueueEntities())
            {
                var error = new ObjectParameter("ErrorMessage", typeof(string));
                var result = db.LoginServiceProvider(provider.UserName, provider.Password);
                return result.FirstOrDefault();
            }
        }
        public GetServiceProviderProfile_Result SearchServiceProvider(string serviceProviderId)
        {
            using (var db = new EnqueueEntities())
            {
                var result = db.GetServiceProviderProfile(serviceProviderId, true).FirstOrDefault();
                return result;
            }
        }
        public List<GetLocations_Result> GetServiceProviderLocations(int serviceProviderId)
        {
            using (var db = new EnqueueEntities())
            {
                var result = db.GetLocations(serviceProviderId, true).ToList();
                return result;
            }
        }
        public GetLocationDetails_Result GetLocationsDetails(int locationId,int serviceProviderId)
        {
            using (var db = new EnqueueEntities())
            {
                var result = db.GetLocationDetails(locationId, serviceProviderId).FirstOrDefault();
                return result;
            }
        }

        public List<GetTodayTokens_Result> GetTodaysTokens(int locationId, int serviceProviderId)
        {
            using (var db = new EnqueueEntities())
            {
                var result = db.GetTodayTokens(locationId, serviceProviderId,null);
                return result.ToList();
            }
        }
        public int Next(int tokenId, int status)
        {
            using (var db = new EnqueueEntities())
            {
                var error = new ObjectParameter("ErrorMessage", typeof (string));
                var result = db.UpdateTokenStatus(tokenId, status, false, error);
                return result;
            }
        }

        public string StartBooking(int providerId, int locationId)
        {
            using (var db = new EnqueueEntities())
            {
                var error = new ObjectParameter("ErrorMessage", typeof(string));
                var result = db.StartBooking(locationId, providerId, null, error);
                if (error.Value != null && !string.IsNullOrEmpty(error.Value.ToString()))
                    return
                        error.Value.ToString();
                return "Booking Started";
            }
        }
        public string CloseBooking(int providerId, int locationId)
        {
            using (var db = new EnqueueEntities())
            {
                var error = new ObjectParameter("ErrorMessage", typeof(string));
                var result = db.CloseBooking(locationId, providerId, null, error);
                if (error.Value != null && !string.IsNullOrEmpty(error.Value.ToString()))
                    return
                        error.Value.ToString();
                return "Booking Closed";
            }
        }
        public string StartSession(int providerId,int locationId)
        {
            using (var db = new EnqueueEntities())
            {
                var error = new ObjectParameter("ErrorMessage", typeof(string));
                var result = db.StartSession(locationId,providerId,null,error);
                if (error.Value != null && !string.IsNullOrEmpty(error.Value.ToString()))
                    return
                        error.Value.ToString();
                return "started";
            }
        }
        public string CloseSession(int providerId, int locationId)
        {
            using (var db = new EnqueueEntities())
            {
                var error = new ObjectParameter("ErrorMessage", typeof(string));
                var result = db.CloseSession(locationId,providerId, null, error);
                if (error.Value != null && !string.IsNullOrEmpty(error.Value.ToString()))
                    return
                        error.Value.ToString();
                return "closed";
            }
        }
    }
}
