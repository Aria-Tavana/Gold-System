using System;
using System.ComponentModel.DataAnnotations;

namespace Gold.Common.Interfaces
{
    public interface IEntity
    {
        [Key]
        public int Id { get; set; } 
        public DateTime CreateDate { get; set; }
        public DateTime? DeleteDate { get; set; }
    }
}
