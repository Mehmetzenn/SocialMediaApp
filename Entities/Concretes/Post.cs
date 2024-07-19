using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class Post : IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime PostDate { get; set; }
        public string PostTitle { get; set; }
        public string PostDescription { get; set; }        
    }  
}
