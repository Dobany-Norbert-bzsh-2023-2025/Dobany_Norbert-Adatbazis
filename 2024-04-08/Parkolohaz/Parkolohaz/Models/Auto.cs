using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parkolohaz.Models
{
    public class Auto
    {
        [Key]
        public int Id { get; set; }
        [Key]
        public string Name { get; set; }
    }
}
