﻿using System;
using System.Collections.Generic;

namespace TaskManager.WebAPI.Context;

public partial class UtCity
{
    public Guid Id { get; set; }

    public DateTime? Created { get; set; }

    public DateTime? Changed { get; set; }

    public Guid? CreatedId { get; set; }

    public Guid? ChangedId { get; set; }

    public string Name { get; set; }

    public string PlateNumber { get; set; }
}
