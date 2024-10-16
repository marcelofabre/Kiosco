using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace KioscoInformaticoServices.Models;

public partial class Cliente
{
    public int Id { get; set; }

    [Required(ErrorMessage = "El campo Nombre es obligatorio")]
    public string Nombre { get; set; } = null!;

    [Required(ErrorMessage = "El campo Direccion es obligatorio")]
    public string Direccion { get; set; } = null!;

    public string Telefonos { get; set; } = null!;

    public DateTime FechaNacimiento { get; set; }

    
    public int? LocalidadId { get; set; }

    [Required(ErrorMessage = "El campo Localidad es obligatorio")]
    public virtual Localidad? Localidad { get; set; }

    public bool Eliminado { get; set; } = false;

  
}
