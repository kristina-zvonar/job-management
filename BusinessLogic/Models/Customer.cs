using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BusinessLogic.Models
{
    public class Customer
    {
        [Key]
        public Guid ID { get; set; }
        [Required]
        [MaxLength(200)]
        public string Name { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string Email { get; set; }
        public bool Active { get; set; }

        public ICollection<Job> Jobs { get; set; }
    }
}
