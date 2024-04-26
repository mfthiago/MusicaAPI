﻿
using MusicaAPI.Dtos.Cliente;
using MusicaAPI.Dtos.Estudio;
using MusicaAPI.Models;

namespace MusicaAPI.Mappers
{
    public static class EstudioMapper
    {
        public static EstudioDto ToEstudioDto(this Estudio estudioModel)
        {
            return new EstudioDto
            {
                Id = estudioModel.Id,
                Nome = estudioModel.Nome,
                Endereco = estudioModel.Endereco,
                Telefone = estudioModel.Telefone,
                Salas = estudioModel.Salas.Select(s => s.ToSalaDto()).ToList()

            };
        }
        public static Estudio ToEstudioFromCreateDTO(this CreateEstudioRequestDto estudioDto)
        {
            return new Estudio
            {
                Nome = estudioDto.Nome,
                Endereco = estudioDto.Endereco,
                Telefone = estudioDto.Telefone
            };
        }
    } 
}