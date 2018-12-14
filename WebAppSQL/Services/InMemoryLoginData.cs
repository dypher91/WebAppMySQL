using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppSQL.Models;

namespace WebAppSQL.Services
{
    public class InMemoryRestaurantData : ILoginData
    {
        public InMemoryRestaurantData()
        {
            _items = new List<LoginItem>
            {
                new LoginItem { Id = 1, UserName = "Pablo", AccesToken = "aaa"},
                new LoginItem { Id = 2, UserName = "Aze", AccesToken = "bbb"},
                new LoginItem { Id = 3, UserName = "Kogo", AccesToken = "ccc"}
            };
        }

        public IEnumerable<LoginItem> GetAll()
        {
            return _items.OrderBy(r => r.Id);
        }

        List<LoginItem> _items;
    }
}

