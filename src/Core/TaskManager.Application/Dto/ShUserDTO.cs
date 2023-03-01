using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Application.Interfaces;

namespace TaskManager.Application.Dto
{
    public class ShUserDTO : IDTO
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public DateTime BirthDate { get; set; }

        public string CellPhone { get; set; }

        public string IdentityNumber { get; set; }

        public string Password { get; set; }

        public Guid TownId { get; set; }

        public Guid CityId { get; set; }

        public bool? IsBlocked { get; set; }
    }
}
