﻿using MusicaAPI.Dtos.Agendamento;
using MusicaAPI.Models;

namespace MusicaAPI.Mappers
{
    public static class AgendamentoMapper
    {
        public static AgendamentoDto ToAgendamentoDto(this Agendamento agendamentoModel)
        {
            return new AgendamentoDto
            {
                Id = agendamentoModel.Id,
                SalaId = agendamentoModel.SalaId,
                DataInicial = agendamentoModel.DataInicial,
                DataFinal = agendamentoModel.DataFinal
            };
        }
        public static Agendamento ToAgendamentoFromCreate(this CreateAgendamentoDto agendamentoDto
            ,int salaId)
        {
            return new Agendamento
            {
                SalaId = salaId,
                DataInicial = agendamentoDto.DataInicial,
                DataFinal = agendamentoDto.DataFinal
            };
        }

        public static Agendamento ToAgendamentoFromUpdate(this UpdateAgendamentoRequestDto agendamentoDto)
        {
            return new Agendamento
            {
                DataInicial = agendamentoDto.DataInicial,
                DataFinal = agendamentoDto.DataFinal
            };
        }
    }
}
