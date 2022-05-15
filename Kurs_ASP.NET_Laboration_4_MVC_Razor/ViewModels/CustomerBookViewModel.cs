using Kurs_ASP.NET_Laboration_4_MVC_Razor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kurs_ASP.NET_Laboration_4_MVC_Razor.ViewModels
{
    public class CustomerBookViewModel
    {
        public Book Book { get; set; }

        public Customer Customer { get; set; }
    }
}
