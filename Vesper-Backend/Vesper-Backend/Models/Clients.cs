using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Vesper_Backend.Models
{
    public class Clients
    {
        public int Id { get; set; }

        [StringLength(maximumLength:150)]
        public string Image { get; set; }
    }
}
