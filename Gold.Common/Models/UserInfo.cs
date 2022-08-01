using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gold.Common.Models
{
    public class UserInfo
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(14)]
        public string PhoneNumber { get; set; }
        [Required]
        [MaxLength(25)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(25)]
        public string LastName { get; set; }
        [MaxLength(52)]
        [NotMapped]
        public string FullName { get { return FirstName + " " + LastName; } }

        public User User { get; set; }
    }
}
