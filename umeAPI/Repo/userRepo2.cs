using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using umeAPI.Data;

namespace umeAPI.Repo
{
    public interface userRepo2
    {
        int InsertNewUser(UserAccount userAccount);
        UserAccount getUser(string phoneNumber, string passWord);
        bool onlineUser(string phoneNumber);
        string forgetPassword(string phoneNumber);
        string sendEmail(string email);
        string updateUser(string phoneNumer);
    }
}