using System;
using System.Collections.Generic;
using NetTopologySuite.Geometries;

namespace TaskManager.Persistence.Context;

public partial class UtCity
{
    public Guid Id { get; set; }

    public DateTime? Created { get; set; }

    public DateTime? Changed { get; set; }

    public Guid? CreatedId { get; set; }

    public Guid? ChangedId { get; set; }

    public string Name { get; set; }

    public Geometry Shape { get; set; }

    public string PlateNumber { get; set; }
}
