using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MovieAPP.Models
    //When creating a buddy class using SEALED when naming the Method.
    //Make sure the Namespace is reading the the name of App. and models but not the folder you created example namespace MovieAPP. Models. BuddyClass remove folder name BuddyClass. 
{
    [MetadataType(typeof(CustomerBuddy))]
    public partial class Customer
    {
     public string FullName
        {
            get
            { return this.FName + "" + this.LName; }
            set { }
        }   
    }
    sealed class CustomerBuddy
    {
        
        [Display(Name ="First Name")]
        public string FName { get; set; }

        [Display(Name = "Last Name")]
        public string LName { get; set; }

        [Display(Name = "Phone Number")]
        public string Phone { get; set; }
    }
}