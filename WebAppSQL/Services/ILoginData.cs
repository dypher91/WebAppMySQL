using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppSQL.Models;

namespace WebAppSQL.Services
{
    interface ILoginData
    {
        IEnumerable<LoginItem> GetAll();
    }
}
