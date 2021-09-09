using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Vesper_Backend.Models
{
    public class Category
    {
        public int Id { get; set; }
        [StringLength(maximumLength:20)]
        public string Name { get; set; }

        public List<Portfolio> Portfolios { get; set; }
    }
}
