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
    
    public partial class Announcement
    {
        public Announcement()
        {
            this.Issues = new HashSet<Issue>();
        }
    
        public int announcementId { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public System.DateTime publishTime { get; set; }
        public System.DateTime solutionTargetSchedule { get; set; }
        public bool flatNotification { get; set; }
        public Nullable<int> announcerID { get; set; }
    
        public virtual Person Person { get; set; }
        public virtual ICollection<Issue> Issues { get; set; }
    }
}
