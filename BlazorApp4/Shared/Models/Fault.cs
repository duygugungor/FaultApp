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
        public string MakinaGrubu { get; set; }
        public string Makina { get; set; }
        public string Operator { get; set; }
        //public DateTime Tarih { get; set; }
        public string Description { get; set; }
        public DateTime CreatedTime { get; set; } = DateTime.Now;
        public DateTime FixedTime { get; set; } = DateTime.Now;
        public string FixDescription { get; set; }
        public string FixBy { get; set; }

        public FaultStatus Status { get; set; } = FaultStatus.REPORTED;
    }
}
