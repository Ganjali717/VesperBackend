using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Vesper_Backend.Models
{
    public class Faq
    {
        public int Id { get; set; }
        [StringLength(maximumLength: 50)]
        public string Icon { get; set; }
        [StringLength(maximumLength:500)]
        public string Questions { get; set; }
        [StringLength(maximumLength: 500)]
        public string Answers { get; set; }

        public int Delay { get; set; }
    }
}
