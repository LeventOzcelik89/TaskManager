using TaskManager.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TaskManager.Domain.Entities
{
    public class SH_User : BaseEntity
    {
        [Column(TypeName = "varchar(100)")]
        public string FirstName { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string LastName { get; set; }

        [Column(TypeName = "varchar(250)")]
        public string Email { get; set; }

        public DateTime BirthDate { get; set; }

        [Column(TypeName = "varchar(10)")]
        public string CellPhone { get; set; }

        [Column(TypeName = "varchar(11)")]
        public string IdentityNumber { get; set; }

        [Column(TypeName = "varchar(250)")]
        public string Password { get; set; }

        [ForeignKey("UT_Town")]
        public Guid TownId { get; set; }
        public virtual UT_Town Town { get; set; }

        [ForeignKey("UT_City")]
        public Guid CityId { get; set; }
        public virtual UT_City City { get; set; }


        public bool? IsBlocked { get; set; }
    }
}
