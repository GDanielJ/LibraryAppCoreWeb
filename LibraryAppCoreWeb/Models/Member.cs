using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace LibraryAppCoreWeb.Models
{
    public class Member
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [MaxLength(255)]
        public string Firstname { get; set; }

        [Required]
        [MaxLength(255)]
        public string Lastname { get; set; }
    }
}
