using System;
using System.Collections.Generic;
using System.Text;

namespace UserService.Domain.Entities
{
    public class Usuario : Entity
    {
        public string Nome { get; set; }
        public string Email { get; set; }
            
        public Usuario(int id, string nome, string email) : base(id)
        {
            this.Nome = nome;           
            this.Email = email;           
        }
    }
}
