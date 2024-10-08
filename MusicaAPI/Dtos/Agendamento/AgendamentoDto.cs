﻿using System.ComponentModel.DataAnnotations;

namespace MusicaAPI.Dtos.Agendamento
{
    public class AgendamentoDto
    {

        public int Id { get; set; }
        public string? EstudioNome { get; set; }
        public string? AppUserId { get; set; }
        public int? EstudioId { get; set; }
        public string? AppUserName { get; set; }
        public double Preco { get; set; }

        public DateTime DataInicial { get; set; }

        public DateTime DataFinal { get; set; }
    }
}
