using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eyAPI.Models
{
    public class Provider
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(255)]
        public string? RazonSocial { get; set; }

        [MaxLength(255)]
        public string? NombreComercial { get; set; }


        [MaxLength(255)]
        public string? IdentificacionTributaria { get; set; }


        [MaxLength(20)]
        public string? NumeroTelefonico { get; set; }

 
        [MaxLength(255)]
        [EmailAddress]
        public string? CorreoElectronico { get; set; }

  
        [MaxLength(255)]
        public string? SitioWeb { get; set; }


        [MaxLength(255)]
        public string? DireccionFisica { get; set; }


        [MaxLength(100)]
        public string? Pais { get; set; }


        [Column(TypeName = "decimal(18,2)")]
        public decimal FacturacionAnual { get; set; }

        public string? FechaUltimaEdicion { get; set; }
    }
}