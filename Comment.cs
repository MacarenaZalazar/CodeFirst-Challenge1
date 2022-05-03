using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst_Challenge1
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }
        public DateTime Date { get; set; }

        //relacion de uno  a muchos

        public Usuario Usuario { get; set; }
        public Post Post { get; set; }
    }
}
