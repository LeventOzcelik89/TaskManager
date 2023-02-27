using TaskManager.Domain.Common;
using System.ComponentModel.DataAnnotations.Schema;
using NetTopologySuite.Geometries;

namespace TaskManager.Domain.Entities
{
    public class UT_Country : BaseEntity
    {
        [Column(TypeName = "varchar(100)")]
        public string Name { get; set; }

        //[Column(TypeName = "varchar(10)")]
        //public Geometry Shape { get; set; }
    }
}
