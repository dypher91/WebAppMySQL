using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppSQL.Models
{
    public class LoginItem
    {
        public long Id { get; set; }
        public string UserName { get; set; }
        public string AccesToken { get; set; }
    }
}
