using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Vesper_Backend.Models
{
    public class About
    {
        public int Id { get; set; }

        [StringLength(maximumLength:500)]
        public string Description { get; set; }

        [StringLength(maximumLength: 50)]
        public string RedirectUrl { get; set; }
    }
}
