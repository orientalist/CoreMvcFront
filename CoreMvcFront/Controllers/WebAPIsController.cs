using Microsoft.AspNetCore.Mvc;
using CoreMvcFront.Model;
using CoreMvcFront.Services;
using System;
using Microsoft.Extensions.Options;
using CoreMvcFront.Utility;

namespace CoreMvcFront.Front
{
    public class WebAPIsController:BaseController{

        NavBarBL navBarBL;

        public WebAPIsController(IOptions<MySqlConnection> Connection){
            _MySqlConnection=Connection;
            ConfigHelper=new ConfigHelper(_MySqlConnection);
        }

        [HttpGet]
        public IActionResult GetAllNavBar(){
            ResponseModel Result=new ResponseModel();
            navBarBL=new NavBarBL();
            try{
                var NavBarItems=navBarBL.GetAllNavBar();
            }
            catch(Exception ex){

            }
            return Json(Result);
        }
    }
}