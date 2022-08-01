using Gold.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gold.Common.Models
{
    public class User : IEntity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Username { get; set; }
        [Required]
        [MaxLength(50)]
        public string Password { get; set; }

        public int? UserId { get; set; }
        public UserInfo UserInfo { get; set; }

        public DateTime CreateDate { get; set; }
        public DateTime? DeleteDate { get; set; }
    }
}
