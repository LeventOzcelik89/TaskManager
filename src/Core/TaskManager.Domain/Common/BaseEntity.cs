using TaskManager.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.ValueGeneration;

namespace TaskManager.Domain.Common
{
    public abstract class BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public virtual Guid Id { get; set; }
        public DateTime CreatedTime { get; set; }
        //  [ForeignKey("SH_User")]
        public Guid? CreatedId { get; set; }
    }
}
