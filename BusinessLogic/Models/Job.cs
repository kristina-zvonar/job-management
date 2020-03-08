using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BusinessLogic.Models
{
    public class Job
    {
        [Key]
        public Guid ID { get; set; }
        [Required]
        public string JobNumber { get; set; }
        [Required]
        public string Description { get; set; }

        [ForeignKey("Customer")]
        public Guid CustomerID { get; set; }
        public Customer Customer { get; set; }

        
        public Guid SenderID { get; set; }
        [ForeignKey("SenderID")]
        public Location Sender { get; set; }

        
        public Guid RecipientID { get; set; }
        [ForeignKey("RecipientID")]
        public Location Recipient { get; set; }
        
    }
}
