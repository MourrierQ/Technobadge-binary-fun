using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BinaryPuzzle.Model
{
    public class Player
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        
        public int Level { get; set; }

        public Player()
        {
            Level = 1;
        }
    }
}
