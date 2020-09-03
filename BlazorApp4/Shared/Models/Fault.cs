using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Text;


namespace BlazorApp4.Shared.Models
{
    public class Fault 
    {
      
        [Required()]
        public int Id { get; set; }
        [Required()]
        public string MakinaGrubu { get; set; }
        [Required()]
        public string Makina { get; set; }
        public string Operator { get; set; }
        [Required()]
        public DateTime RecordTime { get; set; } = DateTime.Now;
        public string Description { get; set; }
        [Required()]
        public DateTime CreatedTime { get; set; } = DateTime.Now;

        [Required()]
        public DateTime FixedTime { get; set; } 
        public string FixDescription { get; set; }
        public string FixBy { get; set; }

        public FaultStatus Status { get; set; } = FaultStatus.REPORTED;
    }
}
