﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace Parcial1_Ap2_Nuñez.Models
{
    public class Producto
    {
        [Key]
        [Required(ErrorMessage ="Debe de llenar el campo")]
        [Range(0,9999999,ErrorMessage ="El id debe de ser mayor a 0 y menor a 9999999")]
        public int ArticulosId { get; set; }

        [Required(ErrorMessage = "Debe de llenar el campo")]
        [MaxLength(200,ErrorMessage ="La descripcion es muy larga")]
        [MinLength(3,ErrorMessage ="La descripcion es muy corta")]
        public string Descripcion { get; set; }

        [Range(0, 99999999, ErrorMessage = "La existencia debe ser mayor a 0 y menor a 99999999")]
        [Required(ErrorMessage = "Debe de llenar el campo")]
        public int Existencia { get; set; }
        [Required(ErrorMessage = "Debe de llenar el campo")]
        [Range(1,99999999, ErrorMessage = "El costo debe ser mayor a 0 y menor a 99999999")]
        public decimal Costo { get; set; }
        public decimal ValorInventario { get; set; }

        public Producto()
        {
            ArticulosId = 0;
            Descripcion = string.Empty;
            Existencia = 0;
            Costo = 0;
            ValorInventario = 0;
        }
    }
}
