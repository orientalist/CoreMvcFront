using Microsoft.AspNetCore.Mvc;
using CoreMvcFront.Model;
using CoreMvcFront.Services;
using System;
using Microsoft.Extensions.Options;
using CoreMvcFront.Utility;
using System.Collections.Generic;

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
                List<NavBarMenuModel> NavBarItems=navBarBL.GetAllNavBar(ConfigHelper.ConnectionString);
                if(NavBarItems.Count>0){
                    Result.HttpStatus="1";
                    Result.Message="OK";
                    Result.Data=NavBarItems;
                }else{
                    Result.HttpStatus="-5";
                    Result.Message="No Data";
                }
            }
            catch(Exception ex){

            }
            return Json(Result);
        }

        [HttpPost]
        public IActionResult GetDailyNews(){
            ResponseModel Result=new ResponseModel();
            DailyNewsBL dailyNewsBL=new DailyNewsBL();
            try{
                List<DailyNews> _DailyNews=dailyNewsBL.GetDailyNews(ConfigHelper.ConnectionString);
                if(_DailyNews.Count>0){
                    Result.HttpStatus="1";
                    Result.Data=_DailyNews;
                }
            }
            catch(Exception ex){

            }
            return Json(Result);
        }
    }
}