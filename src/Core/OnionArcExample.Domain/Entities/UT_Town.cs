using OnionArcExample.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArcExample.Domain.Entities
{
    public class UT_Town : BaseEntity
    {
        [Column(TypeName = "varchar(100)")]
        public string Name { get; set; }

        [ForeignKey("UT_City")]
        public Guid? CityId { get; set; }
        public virtual UT_City City { get; set; }
    }
}
