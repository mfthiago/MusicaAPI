﻿using Microsoft.AspNetCore.Mvc;
using MusicaAPI.Data;
using MusicaAPI.Mappers;
using MusicaAPI.Dtos;
using MusicaAPI.Dtos.Cliente;
using Microsoft.EntityFrameworkCore;
using MusicaAPI.Interfaces;

namespace MusicaAPI.Controllers
{
    [Route("MusicaAPI/Cliente")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly IClienteRepository _clienteRepo;
        public ClienteController(ApplicationDbContext context, IClienteRepository clienteRepo)
        {
            _clienteRepo = clienteRepo;
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var clientes = await _clienteRepo.GetAllAsync();
            var clienteDto = clientes.Select(s => s.ToClienteDto());

            return Ok(clienteDto);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
            {
            var cliente = await _clienteRepo.GetByIdAsync(id);

            if(cliente == null)
            {
                return NotFound();
            }
            return Ok(cliente.ToClienteDto());
        }

        [HttpPost]

        public async Task<IActionResult> Create([FromBody] CreateClienteRequestDto clienteDto)
        {
            var clienteModel = clienteDto.ToClienteFromCreateDTO();
            await _clienteRepo.CreateAsync(clienteModel);
            return CreatedAtAction(nameof(GetById), new { id = clienteModel.Id }, clienteModel.ToClienteDto());
        }

        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> Update([FromRoute] int id, [FromBody] UpdateClienteRequestDto updateDto)
        {
            var clienteModel = await _clienteRepo.UpdateAsync(id, updateDto);

            if(clienteModel == null)
            {
                return NotFound();
            }


            return Ok(clienteModel.ToClienteDto());

        }

        [HttpDelete]
        [Route("{id}")]

        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            var clienteModel = await _clienteRepo.DeleteAsync(id);
            if(clienteModel == null)
            {
                return NotFound();
            }

            return NoContent();
        }
    }
}
