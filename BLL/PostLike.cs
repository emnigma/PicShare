using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BLL
{
    class PostLike
    {
        public int Id { get; set; }
        public int CommentId { get; set; }
        public DateTime Time { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
    }
}
