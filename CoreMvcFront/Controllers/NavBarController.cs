using Microsoft.AspNetCore.Mvc;

namespace CoreMvcFront.Front{
    public class NavBarController:BaseController{
        public IActionResult css(){
            
            return View();
        }
    }
}