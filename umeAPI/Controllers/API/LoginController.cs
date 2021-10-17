using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

using System.Web.Http.Results;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using umeAPI.Data;
using umeAPI.Service;

namespace umeAPI.Controllers.API
{
    public class LoginController : ApiController

    {

        UserService Uservice = new UserService();
        checking checking = new checking();

        // GET: api/Login
        // API khi đăng nhập
        [System.Web.Mvc.Route("api/Login/getuser")]
        [System.Web.Mvc.HttpGet]
        public object GetUser(string phoneNumber, string password)
        {
            if (checking.checkPhone(phoneNumber))
            {
                var c = Uservice.getUser(phoneNumber, password);
                if (c != null)
                {
                    return Json(new {
                        message= "success",
                        account = c });
                }
                else return Json(new
                {
                    message = "sai mật khẩu",
                    account =  c});
            }
            else return Json(new
            {
                message = "số điện thoại sai định dạng",
                account =  new UserAccount()});
        }
        [System.Web.Mvc.Route("api/Login/register")]
        [System.Web.Mvc.HttpPost]
        public object PostRegister(UserAccount userAccount)
        {
            if (checking.checkPhone(userAccount.phoneNumber) && checking.checkPass(userAccount.password))
            {
                return Uservice.InsertNewUser(userAccount);
            }
            else
            {
                return Json(new { account = "số điện thoại sai định dạng" });
            }

        }
        [System.Web.Mvc.Route("api/Login")]
        [System.Web.Mvc.HttpPost]
        public object PostForgetPassword(string phoneNumber)
        {
            return Json(new { password = Uservice.forgetPassword(phoneNumber) });
        }


    }
}
