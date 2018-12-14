//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Mvc;
//using WebAppSQL.Services;
//using WebAppSQL.ViewModel;

//namespace WebAppSQL.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class ValuesController : Controller
//    {
//        private ILoginData _loginData;

//        public ValuesController(ILoginData loginData)
//        {
//            _loginData = loginData;

//        }

//        public IActionResult Index()
//        {

//            var model = new ViewLoginData();
//            model.loginItems = _loginData.GetAll();

//            return View(model);
//        }

//    }
//}
