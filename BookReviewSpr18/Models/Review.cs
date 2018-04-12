//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BookReviewSpr18.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Review
    {
        public int ReviewKey { get; set; }
        public int BookKey { get; set; }
        public int ReviewerKey { get; set; }
        public System.DateTime ReviewDate { get; set; }
        public string ReviewTitle { get; set; }
        public int ReviewRating { get; set; }
        public string ReviewText { get; set; }
    
        public virtual Book Book { get; set; }
        public virtual Reviewer Reviewer { get; set; }
    }
}
