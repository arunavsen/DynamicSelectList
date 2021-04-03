using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DynamicSelectList.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DynamicSelectList.ViewModels
{
    public class CustomerViewModel
    {
        public Customer Customer { get; set; }
        public IEnumerable<SelectListItem> Countries { get; set; }
        public IEnumerable<SelectListItem> Cities { get; set; }
    }
}
