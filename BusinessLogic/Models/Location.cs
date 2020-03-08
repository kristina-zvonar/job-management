using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BusinessLogic.Models
{
    public class Location
    {
        [Key]
        public Guid ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Address { get; set; }

        public ICollection<Job> SenderJobs { get; set; }
        public ICollection<Job> ReceipientJobs { get; set; }
    }
}
