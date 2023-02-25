using TaskManager.Domain.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskManager.Domain.Entities
{
    public class UT_Country : BaseEntity
    {
        [Column(TypeName = "varchar(2)")]
        public string Code2 { get; set; }

        [Column(TypeName = "varchar(3)")]
        public string Code3 { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string Name { get; set; }

        [Column(TypeName = "varchar(10)")]
        public string PhoneCode { get; set; }
    }
}
