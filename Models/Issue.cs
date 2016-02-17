//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HouseCase.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Issue
    {
        public Issue()
        {
            this.Solutions = new HashSet<Solution>();
        }
    
        public int issueID { get; set; }
        public string issueName { get; set; }
        public string description { get; set; }
        public System.DateTime reportingTime { get; set; }
        public decimal workloadEstimate { get; set; }
        public decimal costEstimate { get; set; }
        public int informerID { get; set; }
        public int locationID { get; set; }
        public int statusID { get; set; }
        public int announcementID { get; set; }
    
        public virtual Announcement Announcement { get; set; }
        public virtual Location Location { get; set; }
        public virtual Person Person { get; set; }
        public virtual Status Status { get; set; }
        public virtual ICollection<Solution> Solutions { get; set; }
    }
}