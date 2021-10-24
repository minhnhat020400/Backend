using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using umeAPI.Data;
using umeAPI.Service;

namespace umeAPI.Controllers.API
{
    public class MainController : ApiController
    {
        checking checking = new checking();
        UserService userService = new UserService();
        friendsService fService = new friendsService();
        // GET: Main
        [System.Web.Mvc.Route("api/Main")]
        [System.Web.Mvc.HttpPost]
        public object PostAddFriends(int idUser, int idFriend)
        {
            var add = fService.addnewFriend(idUser , idFriend);
            if (add != null)
            {
                return Json(new {message= "success" ,
                                 data= add});
            }
            else return Json(new { message = "failed", 
                                    data = add});
        }
        // api gửi email để xác nhận email
        [System.Web.Mvc.Route("api/Main/updateAvertar")]
        [System.Web.Mvc.HttpGet]
        public object GetSendCodeByEmail( string email)
        {
            int code = checking.RandomNumber();
            string title = "App Ume gửi mã xác nhận";
            string content = "mã xác nhậ của bạn là : " + code;
            try
            {
                // gọi hàm gửi xác nhận mã code
                Authentication.sendCodeByEmail(email, title, content);
            }
            catch (Exception)
            {

                return Json(new {message = "failt to send email"});
            }
            return Json(new { message = code });

        }

    }
}