using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst_Challenge1
{
    public class Post
    {
        [Key]
        public int IPost { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime Date { get; set; }
        public ICollection<Comment> Comments { get; set; }

        //relacion de uno a muchos

        public Usuario Usuario { get; set; }
    }
}
