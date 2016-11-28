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
    
    public partial class Consumer
    {
        public Consumer()
        {
            this.Tokens = new HashSet<Token>();
        }
    
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public Nullable<decimal> Longitude { get; set; }
        public Nullable<decimal> Latitude { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<bool> IsWebUser { get; set; }
        public Nullable<bool> IsAppUser { get; set; }
        public Nullable<byte> ResetCount { get; set; }
    
        public virtual ICollection<Token> Tokens { get; set; }
    }
}
