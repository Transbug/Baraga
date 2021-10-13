using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Lab03.Models.BG
{
    public partial class Member
    {
        
        public int MemberId { get; set; }
        
        [Required]
        [Display (Name = "First Name")]
        [MaxLength (15)]

        public string FirstName { get; set; }
        [Required]
        [MaxLength (15)]
        public string LastName { get; set; }
        [Required]
        [MaxLength (50)]
        public string Street { get; set; }
        [Required]
        [MaxLength (15)]
        public string City { get; set; }
        [Required]
        [StringLength (2)]
        public string Province { get; set; }
        [Required]
        [StringLength (6)]
        public string PostalCode { get; set; }
        [Required]
        [MaxLength (10)]
        public string MobilePhone { get; set; }
        [Required]
        public string Email { get; set; }
        public bool IsReceiveEmail { get; set; }
    }
}
