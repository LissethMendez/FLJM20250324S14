﻿using System;
using System.Collections.Generic;

namespace FLJM20250324S14.AppWebMVC.ModelsY;

public partial class Cliente
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Direccion { get; set; }

    public string? Telefono { get; set; }

    public string? Email { get; set; }
}
