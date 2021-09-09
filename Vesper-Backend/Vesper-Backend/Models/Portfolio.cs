using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Vesper_Backend.Models
{
    public class Portfolio
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }

        [Required]
        [StringLength(maximumLength: 100)]
        public string Name { get; set; }
    
        [StringLength(maximumLength: 50)]
        public string Client { get; set; }
        public DateTime ProjectDate { get; set; }
        [StringLength(maximumLength:150)]
        public string ProjectUrl { get; set; }
        [StringLength(maximumLength: 1500)]
        public string Desc  { get; set; }
        [Required]
        [StringLength(maximumLength: 250)]
        public string Title { get; set; }

        public List<PortfolioSlider> PortfolioSliders { get; set; }
        public Category Category { get; set; }
    }
}
