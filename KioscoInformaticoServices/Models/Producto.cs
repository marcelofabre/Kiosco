using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace KioscoInformaticoServices.Models;

public partial class Producto
{
    public int Id { get; set; }
    [Required]
    public string Nombre { get; set; } = null!;

    [Required]
    [DataType(DataType.Currency)]
    [DisplayFormat(DataFormatString = "{0:F2}", ApplyFormatInEditMode = true)]
    public decimal Precio { get; set; }
    public bool Eliminado { get; set; } = false;
    public bool Oferta { get; set; } = false;

    public string? imagen { get; set; }=string.Empty;
    public override string ToString()
    {
        return Nombre;
    }

    //dotnet ef migrations add AgregamosImagenAProductos
    //dotnet ef database update
    //crear la conexion de la base de datos con heidi
    //usuario:smartsof_marcelofabre
    //contraseña:smartsof_marcelofabre
    //dotnet ef migrations add inicio
    //dotnet ef database update

}
