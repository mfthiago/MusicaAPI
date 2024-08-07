﻿using System.ComponentModel.DataAnnotations.Schema;

namespace MusicaAPI.Models
{
    [Table("Agendamentos")]
    public class Agendamento
    {
        public int Id { get; set; }
        public int? SalaId { get; set; }
        public string? AppUserName { get; set; }
        public Sala? Sala { get; set; }
        public DateTime DataInicial { get; set; }
        public DateTime DataFinal { get; set; }

        public Agendamento() { }

    }
}
