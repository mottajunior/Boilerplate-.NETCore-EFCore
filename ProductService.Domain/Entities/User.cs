using System;
using System.Collections.Generic;
using System.Text;

namespace ProductService.Domain.Entities
{
    public class User : Entity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }        
        public int IdProfile { get; set; }
        public virtual Profile Profile { get; set; }
        public User(int id, string name, string email, string password, int idProfile) : base(id) {
            this.Name = name;
            this.Password = password;
            this.Email = email;
            this.IdProfile = idProfile;
        }
    }
}
