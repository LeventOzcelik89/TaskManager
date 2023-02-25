using TaskManager.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager.Domain.Entities
{
    public class UT_City : BaseEntity
    {
        [Column(TypeName = "varchar(100)")]
        public string Name { get; set; }

        [Column(TypeName = "varchar(2)")]
        public string PlateNumber { get; set; }

        [Column(TypeName = "varchar(10)")]
        public string PhoneCode { get; set; }
    }
}
