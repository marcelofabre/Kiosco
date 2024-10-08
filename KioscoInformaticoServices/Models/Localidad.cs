using System;
using System.Collections.Generic;

namespace KioscoInformaticoServices.Models;

public partial class Localidad
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;
    public bool Eliminado { get; set; } = false;


    public override string ToString()
    {
        return Nombre; 
    }
}
