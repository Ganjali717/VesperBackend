using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Vesper_Backend.Models
{
    public class Counts
    {
        public int Id { get; set; }

        [StringLength(maximumLength:50)]
        public string Icon { get; set; }

        [StringLength(maximumLength: 50)]
        public string Title { get; set; }

        [StringLength(maximumLength: 150)]
        public string Desc { get; set; }
    }
}
