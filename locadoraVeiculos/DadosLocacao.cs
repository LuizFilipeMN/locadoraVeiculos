using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace locadoraVeiculos
{
    public class Veiculo
    {
        [Key]
        public int VeiculoId { get; set; }
        public string? Modelo { get; set; }
        public string? Marca { get; set; }
        public virtual ICollection<Reserva>? Reservas { get; set; }
    }

    public class Cliente
    {
        [Key]
        public int ClienteId { get; set; }
        public string? Nome { get; set; }
        public string? Sobrenome { get; set; }
        public virtual ICollection<Reserva>? Reservas { get; set; }
    }

    public class Reserva
    {
        [Key]
        public int ReservaId { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public int VeiculoId { get; set; }
        public int ClienteId { get; set; }
        [ForeignKey("VeiculoId")]
        public virtual Veiculo? Veiculo { get; set; }
        [ForeignKey("ClienteId")]
        public virtual Cliente? Cliente { get; set; }
    }
}