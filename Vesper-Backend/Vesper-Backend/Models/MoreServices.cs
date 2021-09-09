using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Vesper_Backend.Models
{
    public class MoreServices
    {
        public int Id { get; set; }
        [StringLength(maximumLength:500)]
        public string Image { get; set; }
        [StringLength(maximumLength: 50)]
        public string Title { get; set; }
        [StringLength(maximumLength: 200)]
        public string Desc { get; set; }
        [StringLength(maximumLength: 50)]
        public string RedirectUrl { get; set; }
    }
}
