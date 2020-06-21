using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BackEnd.Models
{
    public class Speaker
    {
        public int Id { get; set; }

        /// <summary>
        /// This is the name of the speaker
        /// </summary>
        [Required]
        [StringLength(200)]
        public string Name { get; set; }

        /// <summary>
        /// This is some bio information
        /// </summary>
        [StringLength(4000)]
        public string Bio { get; set; }

        /// <summary>
        /// Visit website for more!
        /// </summary>
        [StringLength(1000)]
        public virtual string Website { get; set; }
    }
}
