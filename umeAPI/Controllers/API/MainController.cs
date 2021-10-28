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
        UserService Uservice = new UserService();
        friendsService fService = new friendsService();
        // GET: Main
        //api thêm bạn bè
        [System.Web.Mvc.Route("api/Main")]
        [System.Web.Mvc.HttpPost]
        public object PostAddFriends(int idUser, int idFriend)
        {
            var add = fService.addnewFriend(idUser, idFriend);
            if (add != null)
            {
                return Json(new { message = "success",
                    data = add });
            }
            else return Json(new { message = "failed",
                data = add });
        }


        // api gửi email để xác nhận email
        [System.Web.Mvc.Route("api/Main/updateAvertar")]
        [System.Web.Mvc.HttpGet]
        public string GetSendCodeByEmail(string email)
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

                return "failt to send email";
            }
            return  code.ToString() ;

        }


        //api show list bạn bè
        [System.Web.Mvc.Route("api/Main")]
        [System.Web.Mvc.HttpGet]
        public object GetListFriends(int idUser)
        {

            try
            {
                var listfriends = fService.showlistfriends(idUser);
                if (listfriends != null)
                {
                    return Json(new
                    {
                        message = "success",
                        data = listfriends
                    });

                }
                else
                    return Json(new
                    {
                        message = "failt",
                        data = listfriends
                    });
            }
            catch (Exception)
            {
                return Json(new { message = "failt" });
            }
            
        }


        //tìm bb qua tên số điện thoại
        [System.Web.Mvc.Route("api/Main/find")]
        [System.Web.Mvc.HttpGet]
        public object GetUserByPhone(string phoneNumber)
        {
            var listfriends = Uservice.getUserByPhone(phoneNumber);
            try
            {
                if (listfriends != null)
                {
                    return Json(new
                    {
                        message = "success",
                        Data = listfriends
                    });
                }
                else
                    return "failt";
            }
            catch (Exception)
            {

                return "failt";
            }
        }

        // tìm bb qua tên
        [System.Web.Mvc.Route("api/Main/findbyName")]
        [System.Web.Mvc.HttpGet]
        public object GetUserByName(string name)
        {
            var listfriends = Uservice.getUserByPhone(name);
            try
            {
                if (listfriends != null)
                {
                    return Json(new
                    {
                        message = "success",
                        Data = listfriends
                    });
                }
                else
                    return "failt";
            }
            catch (Exception)
            {

                return "failt";
            }
        }
    }
}