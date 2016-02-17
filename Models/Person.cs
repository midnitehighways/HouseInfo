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
    
    public partial class Person
    {
        public Person()
        {
            this.Announcements = new HashSet<Announcement>();
            this.Issues = new HashSet<Issue>();
            this.Locations = new HashSet<Location>();
        }
    
        public int personId { get; set; }
        public int locationId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string emailAddress { get; set; }
        public bool isAdmin { get; set; }
        public bool isMaintenance { get; set; }
        public string phoneNumber { get; set; }
    
        public virtual ICollection<Announcement> Announcements { get; set; }
        public virtual ICollection<Issue> Issues { get; set; }
        public virtual Location Location { get; set; }
        public virtual ICollection<Location> Locations { get; set; }
    }
}
