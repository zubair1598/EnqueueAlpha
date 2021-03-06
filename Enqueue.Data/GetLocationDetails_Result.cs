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
    
    public partial class GetLocationDetails_Result
    {
        public int Id { get; set; }
        public Nullable<int> ServiceProviderId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public Nullable<decimal> Latitude { get; set; }
        public Nullable<decimal> Longitude { get; set; }
        public string ContactNo { get; set; }
        public Nullable<bool> AllowAdvanceBooking { get; set; }
        public bool TokenBookingOpen { get; set; }
        public string Timing1 { get; set; }
        public string Timing2 { get; set; }
        public string Note { get; set; }
        public Nullable<System.TimeSpan> TokenStartTime { get; set; }
        public Nullable<System.TimeSpan> TokenEndTime { get; set; }
        public Nullable<System.TimeSpan> ServiceStartTime { get; set; }
        public Nullable<System.TimeSpan> ServiceEndTime { get; set; }
        public Nullable<decimal> Fee { get; set; }
        public Nullable<int> TokenLimit { get; set; }
        public Nullable<int> iTokenLimit { get; set; }
        public string OffDays { get; set; }
        public Nullable<bool> Status { get; set; }
        public Nullable<bool> IsActive { get; set; }
    }
}
