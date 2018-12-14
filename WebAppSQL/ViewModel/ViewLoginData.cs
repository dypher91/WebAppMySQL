using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppSQL.Models;

namespace WebAppSQL.ViewModel
{
    public class ViewLoginData
    {
        public IEnumerable<LoginItem> loginItems { get; set; }
        public string CurrentMessage { get; set; }
    }
}
