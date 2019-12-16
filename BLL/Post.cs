using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    class Post
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public DateTime Created { get; set; }
        public bool IsCommentsClosed { get; set; }

    }
}
