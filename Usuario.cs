using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst_Challenge1
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Password { get; set; }
        [Required]
        public string Name { get; set; }

        public string Email { get; set; }

        public ICollection<Post> Posts { get; set; }

    }
}
