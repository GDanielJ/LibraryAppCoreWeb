using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace LibraryAppCoreWeb.Models
{
    public class Loan
    {
        [Required]
        public int Id { get; set; }

        public Member Member { get; set; }

        public int MemberId { get; set; }

        public ICollection<LoanBook> LoanBooks { get; set; }

        public DateTime? CheckOutDate { get; set; }

        public DateTime? DueDate { get; set; }
    }
}
