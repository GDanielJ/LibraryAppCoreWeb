using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryAppCoreWeb.Models;

namespace LibraryAppCoreWeb.ViewModels
{
    public class MemberFormViewModel
    {
        public int? Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Title
        {
            get
            {
                return Id != 0 ? "Edit member information" : "New member";
            }
        }

        public MemberFormViewModel()
        {
            Id = 0;
        }

        public MemberFormViewModel(Member member)
        {
            Id = member.Id;
            Firstname = member.Firstname;
            Lastname = member.Lastname;
        }
    }
}
