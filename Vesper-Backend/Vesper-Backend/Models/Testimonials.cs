using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Vesper_Backend.Models
{
    public class Testimonials
    {

        public int Id { get; set; }
        [StringLength(maximumLength:150)]
        public string Image { get; set; }
        [StringLength(maximumLength: 50)]
        public string Fullname { get; set; }
        [StringLength(maximumLength: 100)]
        public string Speciality { get; set; }
        [StringLength(maximumLength: 500)]
        public string Desc { get; set; }
    }
}
