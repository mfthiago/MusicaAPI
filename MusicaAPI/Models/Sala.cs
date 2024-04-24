﻿namespace MusicaAPI.Models
{
    public class Sala
    {
        public int Id { get; set; }
        public int? EstudioId { get; set; }
        public Estudio? Estudio { get; set; }
        public string Nome { get; set; } = string.Empty;
        public double Preco { get; set; }
        public List<Agendamento> Agendamentos { get; set; } = new List<Agendamento>();
        public List<Equipamento> Equipamentos { get; set; } = new List<Equipamento>();


        public Sala() { }
    }
}