using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Vesper_Backend.Models
{
    public class Heroes
    {
        public int Id { get; set; }
        [StringLength(100)]
        public string Title { get; set; }
        [StringLength(100)]
        public string SmallTitle { get; set; }
        [StringLength(50)]
        public string Image { get; set; }
        [StringLength(50)]
        public string RedirectUrl { get; set; }
    }
}
