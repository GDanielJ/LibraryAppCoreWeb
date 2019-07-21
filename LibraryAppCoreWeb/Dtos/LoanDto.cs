using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryAppCoreWeb.Models;

namespace LibraryAppCoreWeb.Dtos
{
    public class LoanDto
    {
        public int Id { get; set; }
        public int MemberId { get; set; }
        public int BookId { get; set; }
        public DateTime? CheckOutDate { get; set; }
        public DateTime? DueDate { get; set; }
    }
}
