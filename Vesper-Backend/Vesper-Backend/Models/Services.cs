using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Vesper_Backend.Models
{
    public class Services
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
