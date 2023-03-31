using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MVCCRUD.Models;

public partial class Equipo
{
    public int IdMarcas { get; set; }
    [Display(Name = "Nombre de la Marca")]
    public string? NombreMarca { get; set; }
    [Display(Name = "Estado")]

    public string? Estados { get; set; }

}
