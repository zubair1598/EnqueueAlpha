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
    
    public partial class TokenPayment
    {
        public int Id { get; set; }
        public Nullable<decimal> PaymentAmount { get; set; }
        public Nullable<bool> IsPayment { get; set; }
        public Nullable<bool> IsFollowUp { get; set; }
        public int TokenId { get; set; }
    }
}
