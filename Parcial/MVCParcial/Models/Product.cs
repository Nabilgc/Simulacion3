﻿using System.ComponentModel.DataAnnotations;

namespace MVCParcial.Models
{
    public enum UnityType
    {
        Botella,
        Caja,
        Metro,
        Litro
    }

    public enum StatusType
    {
        Activo,
        Inactivo
    }

    public class Product
    {
        [Key]
        public int ProductID { get; set; }

        [Required]
        public string Name { get; set; }

        public decimal Price { get; set; }

        public int Quantity { get; set; }

        [Required]

        public UnityType Unit { get; set; }

        public StatusType Status { get; set; }

    }
}