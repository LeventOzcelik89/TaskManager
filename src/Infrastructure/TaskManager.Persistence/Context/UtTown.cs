using System;
using System.Collections.Generic;
using NetTopologySuite.Geometries;

namespace TaskManager.Persistence.Context;

public partial class UtTown
{
    public Guid Id { get; set; }

    public DateTime? Created { get; set; }

    public DateTime? Changed { get; set; }

    public Guid? CreatedId { get; set; }

    public Guid? ChangedId { get; set; }

    public string Name { get; set; }

    public Geometry Shape { get; set; }

    public Guid CityId { get; set; }

    public virtual UtTown City { get; set; }

    public virtual ICollection<UtTown> InverseCity { get; } = new List<UtTown>();

    public virtual ICollection<ShUser> ShUserCities { get; } = new List<ShUser>();

    public virtual ICollection<ShUser> ShUserTowns { get; } = new List<ShUser>();
}
