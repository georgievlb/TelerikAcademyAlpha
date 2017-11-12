using FirstProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FirstProject.ViewModels
{
    public class NewCustomerViewModel
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; }    //IEnumerable because we only need a way to iterate over the membership types
        //if we use List instead, we can give our view access to the add, remove etc methods and we don't need that

        public Customer Customer { get; set; }
    }
}