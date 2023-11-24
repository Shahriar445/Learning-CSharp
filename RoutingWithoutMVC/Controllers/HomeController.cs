using Microsoft.AspNetCore.Mvc;

namespace RoutingWithoutMVC.Controllers
{ 
    [Route("[controller]/[action]")]// token that will be controller name as same

   // [Route("Home")] //when click home then go this function
    public class HomeController : Controller
    {


        [Route("~/")] // for empty URL

        //routing 
        [Route("")] // for empty routing go to Index
        [Route("~/Home")] // for empty only type controll url: localhost: Home/
       
       // [Route("Index")] 

      //  [Route("action")] // we can use token that represent the method name

       
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult About()
        {
            return View();
        }

        [Route("{id?}")] // for returning id 
        public int Details(int? id) // for check null id value
        {
            return id ?? 5; // if id value is given print it.. other wise it print '5'
        }

        /*
         * Here function name is different but route function called home index it go to that file 
         * for this function we are write this return and give address of this file .
        
        [Route("Home/Index")] 
        public IActionResult CheckURL()
        {
            return View("~/View/Home/Index.cshtml");
        }
        */
    }
}
