using System;
using System.Collections.Generic;
using System.Text;

namespace ProductService.Domain.Entities
{
    public class Profile : Entity
    {
        public string Name { get; set; }
        public virtual ICollection<User> Users { get; set; }
        public Profile(int id, string name) : base(id) {
            this.Name = name;
        }
    }
}
