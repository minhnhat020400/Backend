using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using umeAPI.Data;

namespace umeAPI.Repo
{
    public interface UserRepo
    {
        string InsertNewUser(UserAccount userAccount);
        object getUser(string phoneNumber,string passWord);
        bool onlineUser(string phoneNumber);
        object forgetPassword(string phoneNumber);
        object sendEmail(string email);
        object updateUser(string phoneNumer);
    }
}