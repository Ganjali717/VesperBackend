using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Vesper_Backend.Models
{
    public class Features
    {
        public int Id { get; set; }

        [StringLength(maximumLength:100)]
        public string Icon { get; set; }

        [StringLength(maximumLength:50)]
        public string Title { get;  set; }
    }
}
