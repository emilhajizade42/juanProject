using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Models;

namespace WebApplication.ViewModel.HomeViewModel
{
    public class HomeViewModel
    {
        public List<Sliders> Sliders { get; set; }
        public List<Blogs> Blogs { get; set; } 
        public List<Features> Features { get; set; }
    }

}