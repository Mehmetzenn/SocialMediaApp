using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class Comment : IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string CommentText { get; set; }
        public int PostId { get; set; }
        public Post Post { get; set; }
        public DateTime PublishedTime { get; set; }
        
    }
}
