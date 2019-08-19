using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AHGEventReg.Models
{
    public class Session
    {
        public int Id { get; set; }
        [Display(Name="Session Name")]
        public string Name { get; set; }
        [Required]
        [StringLength(255)]
        public string Description { get; set; }
        public string Location { get; set; }
        
    }
}