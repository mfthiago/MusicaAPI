﻿using System.ComponentModel.DataAnnotations;

namespace MusicaAPI.Dtos.User
{
    public class RegisterDto
    {
        [Required]
        public string? Username { get; set; }
        [Required]
        public string? Nome { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Telefone { get; set; }
        [Required]
        public string? Password { get; set; }

    }
}
