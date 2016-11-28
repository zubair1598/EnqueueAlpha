﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Enqueue.Data
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class EnqueueEntities : DbContext
    {
        public EnqueueEntities()
            : base("name=EnqueueEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Consumer> Consumers { get; set; }
        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<LocationHistory> LocationHistories { get; set; }
        public virtual DbSet<Organization> Organizations { get; set; }
        public virtual DbSet<Service> Services { get; set; }
        public virtual DbSet<ServiceProvider> ServiceProviders { get; set; }
        public virtual DbSet<ServiceProviderOrganization> ServiceProviderOrganizations { get; set; }
        public virtual DbSet<ServiceProviderService> ServiceProviderServices { get; set; }
        public virtual DbSet<Token> Tokens { get; set; }
        public virtual DbSet<TokenFeedback> TokenFeedbacks { get; set; }
        public virtual DbSet<TokenStatu> TokenStatus { get; set; }
        public virtual DbSet<TokenComment> TokenComments { get; set; }
        public virtual DbSet<TokenPayment> TokenPayments { get; set; }
    
        public virtual int CloseBooking(Nullable<int> locationId, Nullable<int> serviceProviderId, Nullable<int> day, ObjectParameter errorMessage)
        {
            var locationIdParameter = locationId.HasValue ?
                new ObjectParameter("LocationId", locationId) :
                new ObjectParameter("LocationId", typeof(int));
    
            var serviceProviderIdParameter = serviceProviderId.HasValue ?
                new ObjectParameter("ServiceProviderId", serviceProviderId) :
                new ObjectParameter("ServiceProviderId", typeof(int));
    
            var dayParameter = day.HasValue ?
                new ObjectParameter("Day", day) :
                new ObjectParameter("Day", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CloseBooking", locationIdParameter, serviceProviderIdParameter, dayParameter, errorMessage);
        }
    
        public virtual int CloseSession(Nullable<int> locationId, Nullable<int> serviceProviderId, Nullable<int> day, ObjectParameter errorMessage)
        {
            var locationIdParameter = locationId.HasValue ?
                new ObjectParameter("LocationId", locationId) :
                new ObjectParameter("LocationId", typeof(int));
    
            var serviceProviderIdParameter = serviceProviderId.HasValue ?
                new ObjectParameter("ServiceProviderId", serviceProviderId) :
                new ObjectParameter("ServiceProviderId", typeof(int));
    
            var dayParameter = day.HasValue ?
                new ObjectParameter("Day", day) :
                new ObjectParameter("Day", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CloseSession", locationIdParameter, serviceProviderIdParameter, dayParameter, errorMessage);
        }
    
        public virtual int CreateUpdateConsumer(Nullable<int> id, string userName, string password, string fullName, string email, string phone, Nullable<decimal> longitude, Nullable<decimal> latitude, Nullable<bool> isWebUser, Nullable<bool> isAppUser, Nullable<bool> isActive, ObjectParameter errorMessage)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(int));
    
            var userNameParameter = userName != null ?
                new ObjectParameter("UserName", userName) :
                new ObjectParameter("UserName", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("Password", password) :
                new ObjectParameter("Password", typeof(string));
    
            var fullNameParameter = fullName != null ?
                new ObjectParameter("FullName", fullName) :
                new ObjectParameter("FullName", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            var phoneParameter = phone != null ?
                new ObjectParameter("Phone", phone) :
                new ObjectParameter("Phone", typeof(string));
    
            var longitudeParameter = longitude.HasValue ?
                new ObjectParameter("Longitude", longitude) :
                new ObjectParameter("Longitude", typeof(decimal));
    
            var latitudeParameter = latitude.HasValue ?
                new ObjectParameter("Latitude", latitude) :
                new ObjectParameter("Latitude", typeof(decimal));
    
            var isWebUserParameter = isWebUser.HasValue ?
                new ObjectParameter("IsWebUser", isWebUser) :
                new ObjectParameter("IsWebUser", typeof(bool));
    
            var isAppUserParameter = isAppUser.HasValue ?
                new ObjectParameter("IsAppUser", isAppUser) :
                new ObjectParameter("IsAppUser", typeof(bool));
    
            var isActiveParameter = isActive.HasValue ?
                new ObjectParameter("IsActive", isActive) :
                new ObjectParameter("IsActive", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CreateUpdateConsumer", idParameter, userNameParameter, passwordParameter, fullNameParameter, emailParameter, phoneParameter, longitudeParameter, latitudeParameter, isWebUserParameter, isAppUserParameter, isActiveParameter, errorMessage);
        }
    
        public virtual int CreateUpdateServiceProvider(Nullable<int> id, string userName, string password, string code, string name, string qualification, string registrationNo, string email, string contactNo, string website, Nullable<int> organizationId, Nullable<bool> isActive, ObjectParameter errorMessage)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(int));
    
            var userNameParameter = userName != null ?
                new ObjectParameter("UserName", userName) :
                new ObjectParameter("UserName", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("Password", password) :
                new ObjectParameter("Password", typeof(string));
    
            var codeParameter = code != null ?
                new ObjectParameter("Code", code) :
                new ObjectParameter("Code", typeof(string));
    
            var nameParameter = name != null ?
                new ObjectParameter("Name", name) :
                new ObjectParameter("Name", typeof(string));
    
            var qualificationParameter = qualification != null ?
                new ObjectParameter("Qualification", qualification) :
                new ObjectParameter("Qualification", typeof(string));
    
            var registrationNoParameter = registrationNo != null ?
                new ObjectParameter("RegistrationNo", registrationNo) :
                new ObjectParameter("RegistrationNo", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            var contactNoParameter = contactNo != null ?
                new ObjectParameter("ContactNo", contactNo) :
                new ObjectParameter("ContactNo", typeof(string));
    
            var websiteParameter = website != null ?
                new ObjectParameter("Website", website) :
                new ObjectParameter("Website", typeof(string));
    
            var organizationIdParameter = organizationId.HasValue ?
                new ObjectParameter("OrganizationId", organizationId) :
                new ObjectParameter("OrganizationId", typeof(int));
    
            var isActiveParameter = isActive.HasValue ?
                new ObjectParameter("IsActive", isActive) :
                new ObjectParameter("IsActive", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CreateUpdateServiceProvider", idParameter, userNameParameter, passwordParameter, codeParameter, nameParameter, qualificationParameter, registrationNoParameter, emailParameter, contactNoParameter, websiteParameter, organizationIdParameter, isActiveParameter, errorMessage);
        }
    
        public virtual ObjectResult<GetLocationDetails_Result> GetLocationDetails(Nullable<int> id, Nullable<int> serviceProviderId)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(int));
    
            var serviceProviderIdParameter = serviceProviderId.HasValue ?
                new ObjectParameter("ServiceProviderId", serviceProviderId) :
                new ObjectParameter("ServiceProviderId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetLocationDetails_Result>("GetLocationDetails", idParameter, serviceProviderIdParameter);
        }
    
        public virtual ObjectResult<GetLocations_Result> GetLocations(Nullable<int> serviceProviderId, Nullable<bool> isActive)
        {
            var serviceProviderIdParameter = serviceProviderId.HasValue ?
                new ObjectParameter("ServiceProviderId", serviceProviderId) :
                new ObjectParameter("ServiceProviderId", typeof(int));
    
            var isActiveParameter = isActive.HasValue ?
                new ObjectParameter("IsActive", isActive) :
                new ObjectParameter("IsActive", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetLocations_Result>("GetLocations", serviceProviderIdParameter, isActiveParameter);
        }
    
        public virtual int GetOrganizations(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("GetOrganizations", idParameter);
        }
    
        public virtual ObjectResult<GetOrganizationsMembers_Result> GetOrganizationsMembers(Nullable<int> organizationId, Nullable<bool> isActive)
        {
            var organizationIdParameter = organizationId.HasValue ?
                new ObjectParameter("OrganizationId", organizationId) :
                new ObjectParameter("OrganizationId", typeof(int));
    
            var isActiveParameter = isActive.HasValue ?
                new ObjectParameter("IsActive", isActive) :
                new ObjectParameter("IsActive", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetOrganizationsMembers_Result>("GetOrganizationsMembers", organizationIdParameter, isActiveParameter);
        }
    
        public virtual ObjectResult<GetServiceMembers_Result> GetServiceMembers(Nullable<int> serviceId, Nullable<bool> isActive)
        {
            var serviceIdParameter = serviceId.HasValue ?
                new ObjectParameter("ServiceId", serviceId) :
                new ObjectParameter("ServiceId", typeof(int));
    
            var isActiveParameter = isActive.HasValue ?
                new ObjectParameter("IsActive", isActive) :
                new ObjectParameter("IsActive", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetServiceMembers_Result>("GetServiceMembers", serviceIdParameter, isActiveParameter);
        }
    
        public virtual ObjectResult<GetServiceProviderProfile_Result> GetServiceProviderProfile(string code, Nullable<bool> isActive)
        {
            var codeParameter = code != null ?
                new ObjectParameter("code", code) :
                new ObjectParameter("code", typeof(string));
    
            var isActiveParameter = isActive.HasValue ?
                new ObjectParameter("IsActive", isActive) :
                new ObjectParameter("IsActive", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetServiceProviderProfile_Result>("GetServiceProviderProfile", codeParameter, isActiveParameter);
        }
    
        public virtual ObjectResult<GetServices_Result> GetServices()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetServices_Result>("GetServices");
        }
    
        public virtual ObjectResult<Nullable<int>> IsConsumerUserNameExists(string userName)
        {
            var userNameParameter = userName != null ?
                new ObjectParameter("UserName", userName) :
                new ObjectParameter("UserName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("IsConsumerUserNameExists", userNameParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> IsServiceProviderUserNameExists(string userName)
        {
            var userNameParameter = userName != null ?
                new ObjectParameter("UserName", userName) :
                new ObjectParameter("UserName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("IsServiceProviderUserNameExists", userNameParameter);
        }
    
        public virtual ObjectResult<LoginConsumer_Result> LoginConsumer(string userName, string password)
        {
            var userNameParameter = userName != null ?
                new ObjectParameter("UserName", userName) :
                new ObjectParameter("UserName", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("Password", password) :
                new ObjectParameter("Password", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<LoginConsumer_Result>("LoginConsumer", userNameParameter, passwordParameter);
        }
    
        public virtual ObjectResult<LoginServiceProvider_Result> LoginServiceProvider(string userName, string password)
        {
            var userNameParameter = userName != null ?
                new ObjectParameter("UserName", userName) :
                new ObjectParameter("UserName", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("Password", password) :
                new ObjectParameter("Password", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<LoginServiceProvider_Result>("LoginServiceProvider", userNameParameter, passwordParameter);
        }
    
        public virtual int RegisterConsumer(string userName, string password, string fullName, string email, string phone, Nullable<bool> isWebUser, Nullable<bool> isAppUser, ObjectParameter errorMessage)
        {
            var userNameParameter = userName != null ?
                new ObjectParameter("UserName", userName) :
                new ObjectParameter("UserName", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("Password", password) :
                new ObjectParameter("Password", typeof(string));
    
            var fullNameParameter = fullName != null ?
                new ObjectParameter("FullName", fullName) :
                new ObjectParameter("FullName", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            var phoneParameter = phone != null ?
                new ObjectParameter("Phone", phone) :
                new ObjectParameter("Phone", typeof(string));
    
            var isWebUserParameter = isWebUser.HasValue ?
                new ObjectParameter("IsWebUser", isWebUser) :
                new ObjectParameter("IsWebUser", typeof(bool));
    
            var isAppUserParameter = isAppUser.HasValue ?
                new ObjectParameter("IsAppUser", isAppUser) :
                new ObjectParameter("IsAppUser", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("RegisterConsumer", userNameParameter, passwordParameter, fullNameParameter, emailParameter, phoneParameter, isWebUserParameter, isAppUserParameter, errorMessage);
        }
    
        public virtual int StartBooking(Nullable<int> locationId, Nullable<int> serviceProviderId, Nullable<int> day, ObjectParameter errorMessage)
        {
            var locationIdParameter = locationId.HasValue ?
                new ObjectParameter("LocationId", locationId) :
                new ObjectParameter("LocationId", typeof(int));
    
            var serviceProviderIdParameter = serviceProviderId.HasValue ?
                new ObjectParameter("ServiceProviderId", serviceProviderId) :
                new ObjectParameter("ServiceProviderId", typeof(int));
    
            var dayParameter = day.HasValue ?
                new ObjectParameter("Day", day) :
                new ObjectParameter("Day", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("StartBooking", locationIdParameter, serviceProviderIdParameter, dayParameter, errorMessage);
        }
    
        public virtual int StartSession(Nullable<int> locationId, Nullable<int> serviceProviderId, Nullable<int> day, ObjectParameter errorMessage)
        {
            var locationIdParameter = locationId.HasValue ?
                new ObjectParameter("LocationId", locationId) :
                new ObjectParameter("LocationId", typeof(int));
    
            var serviceProviderIdParameter = serviceProviderId.HasValue ?
                new ObjectParameter("ServiceProviderId", serviceProviderId) :
                new ObjectParameter("ServiceProviderId", typeof(int));
    
            var dayParameter = day.HasValue ?
                new ObjectParameter("Day", day) :
                new ObjectParameter("Day", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("StartSession", locationIdParameter, serviceProviderIdParameter, dayParameter, errorMessage);
        }
    
        public virtual int UpdateTokenFeedback(Nullable<int> serviceProviderId, Nullable<int> locationId, Nullable<int> day, Nullable<int> token, string comments, Nullable<byte> rating, Nullable<bool> debug, ObjectParameter errorMessage)
        {
            var serviceProviderIdParameter = serviceProviderId.HasValue ?
                new ObjectParameter("ServiceProviderId", serviceProviderId) :
                new ObjectParameter("ServiceProviderId", typeof(int));
    
            var locationIdParameter = locationId.HasValue ?
                new ObjectParameter("LocationId", locationId) :
                new ObjectParameter("LocationId", typeof(int));
    
            var dayParameter = day.HasValue ?
                new ObjectParameter("Day", day) :
                new ObjectParameter("Day", typeof(int));
    
            var tokenParameter = token.HasValue ?
                new ObjectParameter("Token", token) :
                new ObjectParameter("Token", typeof(int));
    
            var commentsParameter = comments != null ?
                new ObjectParameter("Comments", comments) :
                new ObjectParameter("Comments", typeof(string));
    
            var ratingParameter = rating.HasValue ?
                new ObjectParameter("Rating", rating) :
                new ObjectParameter("Rating", typeof(byte));
    
            var debugParameter = debug.HasValue ?
                new ObjectParameter("Debug", debug) :
                new ObjectParameter("Debug", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdateTokenFeedback", serviceProviderIdParameter, locationIdParameter, dayParameter, tokenParameter, commentsParameter, ratingParameter, debugParameter, errorMessage);
        }
    
        public virtual int UpdateTokenStatus(Nullable<int> id, Nullable<int> status, Nullable<bool> debug, ObjectParameter errorMessage)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(int));
    
            var statusParameter = status.HasValue ?
                new ObjectParameter("Status", status) :
                new ObjectParameter("Status", typeof(int));
    
            var debugParameter = debug.HasValue ?
                new ObjectParameter("Debug", debug) :
                new ObjectParameter("Debug", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdateTokenStatus", idParameter, statusParameter, debugParameter, errorMessage);
        }
    
        public virtual int UpdateTokenStatus_Old(Nullable<int> serviceProviderId, Nullable<int> locationId, Nullable<int> day, Nullable<int> token, Nullable<byte> status, Nullable<bool> debug, ObjectParameter errorMessage)
        {
            var serviceProviderIdParameter = serviceProviderId.HasValue ?
                new ObjectParameter("ServiceProviderId", serviceProviderId) :
                new ObjectParameter("ServiceProviderId", typeof(int));
    
            var locationIdParameter = locationId.HasValue ?
                new ObjectParameter("LocationId", locationId) :
                new ObjectParameter("LocationId", typeof(int));
    
            var dayParameter = day.HasValue ?
                new ObjectParameter("Day", day) :
                new ObjectParameter("Day", typeof(int));
    
            var tokenParameter = token.HasValue ?
                new ObjectParameter("Token", token) :
                new ObjectParameter("Token", typeof(int));
    
            var statusParameter = status.HasValue ?
                new ObjectParameter("Status", status) :
                new ObjectParameter("Status", typeof(byte));
    
            var debugParameter = debug.HasValue ?
                new ObjectParameter("Debug", debug) :
                new ObjectParameter("Debug", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdateTokenStatus_Old", serviceProviderIdParameter, locationIdParameter, dayParameter, tokenParameter, statusParameter, debugParameter, errorMessage);
        }
    
        public virtual ObjectResult<GetCurrentToken_Result> GetCurrentToken(Nullable<int> consumerId, Nullable<int> locationId, Nullable<int> serviceProviderId, Nullable<int> day)
        {
            var consumerIdParameter = consumerId.HasValue ?
                new ObjectParameter("ConsumerId", consumerId) :
                new ObjectParameter("ConsumerId", typeof(int));
    
            var locationIdParameter = locationId.HasValue ?
                new ObjectParameter("LocationId", locationId) :
                new ObjectParameter("LocationId", typeof(int));
    
            var serviceProviderIdParameter = serviceProviderId.HasValue ?
                new ObjectParameter("ServiceProviderId", serviceProviderId) :
                new ObjectParameter("ServiceProviderId", typeof(int));
    
            var dayParameter = day.HasValue ?
                new ObjectParameter("Day", day) :
                new ObjectParameter("Day", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetCurrentToken_Result>("GetCurrentToken", consumerIdParameter, locationIdParameter, serviceProviderIdParameter, dayParameter);
        }
    
        public virtual ObjectResult<GetTodayTokens_Result> GetTodayTokens(Nullable<int> locationId, Nullable<int> serviceProviderId, Nullable<int> day)
        {
            var locationIdParameter = locationId.HasValue ?
                new ObjectParameter("LocationId", locationId) :
                new ObjectParameter("LocationId", typeof(int));
    
            var serviceProviderIdParameter = serviceProviderId.HasValue ?
                new ObjectParameter("ServiceProviderId", serviceProviderId) :
                new ObjectParameter("ServiceProviderId", typeof(int));
    
            var dayParameter = day.HasValue ?
                new ObjectParameter("Day", day) :
                new ObjectParameter("Day", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetTodayTokens_Result>("GetTodayTokens", locationIdParameter, serviceProviderIdParameter, dayParameter);
        }
    
        public virtual ObjectResult<IssueToken_Result> IssueToken(Nullable<bool> isiToken, Nullable<int> serviceProviderId, Nullable<int> locationId, Nullable<int> consumerId, Nullable<int> day, string phone, string name, Nullable<bool> debug, ObjectParameter errorMessage)
        {
            var isiTokenParameter = isiToken.HasValue ?
                new ObjectParameter("IsiToken", isiToken) :
                new ObjectParameter("IsiToken", typeof(bool));
    
            var serviceProviderIdParameter = serviceProviderId.HasValue ?
                new ObjectParameter("ServiceProviderId", serviceProviderId) :
                new ObjectParameter("ServiceProviderId", typeof(int));
    
            var locationIdParameter = locationId.HasValue ?
                new ObjectParameter("LocationId", locationId) :
                new ObjectParameter("LocationId", typeof(int));
    
            var consumerIdParameter = consumerId.HasValue ?
                new ObjectParameter("ConsumerId", consumerId) :
                new ObjectParameter("ConsumerId", typeof(int));
    
            var dayParameter = day.HasValue ?
                new ObjectParameter("Day", day) :
                new ObjectParameter("Day", typeof(int));
    
            var phoneParameter = phone != null ?
                new ObjectParameter("Phone", phone) :
                new ObjectParameter("Phone", typeof(string));
    
            var nameParameter = name != null ?
                new ObjectParameter("Name", name) :
                new ObjectParameter("Name", typeof(string));
    
            var debugParameter = debug.HasValue ?
                new ObjectParameter("Debug", debug) :
                new ObjectParameter("Debug", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<IssueToken_Result>("IssueToken", isiTokenParameter, serviceProviderIdParameter, locationIdParameter, consumerIdParameter, dayParameter, phoneParameter, nameParameter, debugParameter, errorMessage);
        }
    }
}