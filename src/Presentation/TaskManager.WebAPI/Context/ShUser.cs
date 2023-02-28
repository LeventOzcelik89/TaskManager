using System;
using System.Collections.Generic;

namespace TaskManager.WebAPI.Context;

public partial class ShUser
{
    public Guid Id { get; set; }

    public DateTime? Created { get; set; }

    public DateTime? Changed { get; set; }

    public Guid? CreatedId { get; set; }

    public Guid? ChangedId { get; set; }

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

    public virtual UtTown City { get; set; }

    public virtual UtTown Town { get; set; }
}
