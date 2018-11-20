using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using CoreMvcFront.Model;
using CoreMvcFront.Utility;

namespace CoreMvcFront.Front{
    public class BaseController:Controller{
        protected IOptions<MySqlConnection> _MySqlConnection;
        protected ConfigHelper ConfigHelper;
    }
}