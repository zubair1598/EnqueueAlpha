//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class ServiceProviderOrganization
    {
        public int ServiceProviderId { get; set; }
        public int OrganizationId { get; set; }
        public Nullable<bool> IsActive { get; set; }
    
        public virtual Organization Organization { get; set; }
        public virtual ServiceProvider ServiceProvider { get; set; }
    }
}
