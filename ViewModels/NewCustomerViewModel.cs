using MVC_FIRST_PROJECT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_FIRST_PROJECT.ViewModels
{
    public class NewCustomerViewModel
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
        public Customer Customer { get; set; }
    }
}