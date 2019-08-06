using System;
using System.Collections.Generic;
using System.Text;

namespace ProductService.Domain.Entities
{
    public class Entity
    {
        public int Id { get; private set; }
        
        public Entity(int id){
            this.Id = id;            
        }
    }
}
