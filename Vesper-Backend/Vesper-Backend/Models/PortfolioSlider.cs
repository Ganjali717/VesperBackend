using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Vesper_Backend.Models
{
    public class PortfolioSlider
    {
        public int Id { get; set; }
        [StringLength(maximumLength:100)]
        public string Image { get; set; }
        public int PortfolioId { get; set; }
        public Portfolio Portfolio { get; set; }
    }
}
