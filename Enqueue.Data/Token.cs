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
    
    public partial class Token
    {
        public Token()
        {
            this.TokenFeedbacks = new HashSet<TokenFeedback>();
        }
    
        public int Id { get; set; }
        public Nullable<int> Token1 { get; set; }
        public Nullable<int> ServiceProviderId { get; set; }
        public Nullable<int> LocationId { get; set; }
        public Nullable<int> ConsumerId { get; set; }
        public Nullable<int> Day { get; set; }
        public string Phone { get; set; }
        public string Name { get; set; }
        public Nullable<byte> Status { get; set; }
        public Nullable<System.TimeSpan> CheckinTime { get; set; }
        public Nullable<System.TimeSpan> CompletionTime { get; set; }
        public bool IsCurrent { get; set; }
        public bool IsiToken { get; set; }
    
        public virtual Consumer Consumer { get; set; }
        public virtual Location Location { get; set; }
        public virtual ServiceProvider ServiceProvider { get; set; }
        public virtual TokenStatu TokenStatu { get; set; }
        public virtual ICollection<TokenFeedback> TokenFeedbacks { get; set; }
    }
}
