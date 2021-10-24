﻿using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Identity;
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
                        message = "success",
                        account = c });
                }
                else return Json(new
                {
                    message = "sai mật khẩu",
                    account = c });
            }
            else return Json(new
            {
                message = "số điện thoại sai định dạng",
                account = new UserAccount() });
        }
        // api đăng ký số điện thoại
        [System.Web.Mvc.Route("api/Login/register")]
        [System.Web.Mvc.HttpPost]
        public object PostRegister(UserAccount userAccount)
        {
            if (checking.checkPhone(userAccount.phoneNumber) && checking.checkPass(userAccount.password))
            {
                var result = Uservice.InsertNewUser(userAccount);
                if (result != null) {
                    return Json(new 
                    {
                        message ="success",
                      account = result
                    });
                }
                else
                    return Json(new
                    {
                        message = "failt",
                        account = result
                    });
            }
            else
            {
                return Json(new {
                    message = "số điện thoại sai định dạng",
                    account= new UserAccount()
                });
            }

        }

        //api quên mật khẩu

        [System.Web.Mvc.Route("api/Login/forgetpassword")]
        [System.Web.Mvc.HttpPost]
        public object PostForgetPassword(string phoneNumber)
        {
            return Json(new { password = Uservice.forgetPassword(phoneNumber) });
        }

        // api cập nhật hình ảnh

        [System.Web.Mvc.Route("api/Login/updateAvertar")]
        [System.Web.Mvc.HttpPut]
        public object PutAvarta(int idUser, string urlAvarta)
        {
            try
            {
                return Json(new {
                    message =  Uservice.updateAvatar(idUser, urlAvarta)
                });
            }
            catch (Exception)
            {

                return Json(new {message= "failt" }) ;
            }
        }


    }
}
