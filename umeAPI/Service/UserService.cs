using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using umeAPI.Repo;

namespace umeAPI.Data
{
    public class UserService : UserRepo
    {
        ChatUmeDTBEntities3 data = new ChatUmeDTBEntities3();
        public object forgetPassword(string phoneNumber)
        {
            if (IsExistPhoneNumner(phoneNumber))
            {
                SqlParameter phone = new SqlParameter("@phone", phoneNumber);
                string userPass = data.Database.SqlQuery<string>("select UserAccount.password from UserAccount where phoneNumber = @phone",
                    phone).FirstOrDefault();
                return userPass;
            }
            else return "số điện thoại chưa đă ký";

        }
        // =======================
        //hàm này để trả về người dùng khi người dùng truyền vào SĐT và mật khẩu{(đằn nhập)
        //========================
        public object getUser(string phoneNumber, string passWord)
        {
            

            SqlParameter phone = new SqlParameter("@phone", phoneNumber);
            SqlParameter pass = new SqlParameter("@pass", passWord);

            SqlParameter[] sqlParameters = new SqlParameter[] { phone, pass };
            var usersinfo = data.UserAccounts.SqlQuery(" select * from UserAccount where phoneNumber = @phone and password =@pass", sqlParameters).FirstOrDefault();

            if (!IsExistPhoneNumner(phoneNumber))
            {
                return "số điện thoại chưa đă ký";
            }
            else
            {
               
                return usersinfo;
            }
        }
        
        // =======================
        //hàm này để kiểm tra tài khoàn này có tồn tại không
        //========================
        bool IsExistPhoneNumner(string phoneNumber)
        {
            SqlParameter phone = new SqlParameter("@phone", phoneNumber);
            var userPhone = data.UserAccounts.SqlQuery("select * from UserAccount where phoneNumber = @phone", phone).FirstOrDefault();
            if (userPhone == null)
            {
                return false;
            }
            else return true;
        }
        // =======================
        //hàm này để thêm tài khoản
        //========================
        public object InsertNewUser(UserAccount userAccount)
        {
            SqlParameter phoneNumber = new SqlParameter("@phoneNumber", userAccount.phoneNumber);
            SqlParameter createOn = new SqlParameter("@createOn", DateTime.Now);
            SqlParameter updateOn = new SqlParameter("@updateOn", DateTime.Now);
            SqlParameter sex = new SqlParameter("@sex", userAccount.sex);
            SqlParameter password = new SqlParameter("@password", userAccount.password);
            SqlParameter userName = new SqlParameter("@userName", userAccount.userName);

            SqlParameter[] sqlParameters = new SqlParameter[] { phoneNumber, createOn, updateOn, sex, password, userName };
            if (!IsExistPhoneNumner(userAccount.phoneNumber))
            {
                int isInsert = data.Database.
                    ExecuteSqlCommand
                    ("insert into UserAccount (phoneNumber,createOn,updateOn,sex,password,userName) values ( @phoneNumber,@createOn,@updateOn,@sex,@password,@userName)", sqlParameters);
                return isInsert;
            }
            else {
                return "số điện thoại đã có người đăng ký";
            }
        }
        // tìm người dùng qua số điện thoại
        public UserAccount SerchUserByPhoneNumber(string phoneNumber)
        {
            SqlParameter phone = new SqlParameter("@phone", phoneNumber);
            var usersinfo = data.UserAccounts.SqlQuery(" select * from UserAccount where phoneNumber = @phone", phone).FirstOrDefault();
            return usersinfo;
            
        }
        public UserAccount SerchUserByIdUer(int id)
        {
            SqlParameter phone = new SqlParameter("@id", id);
            var usersinfo = data.UserAccounts.SqlQuery(" select * from UserAccount where idUser = @id", phone).FirstOrDefault();
            return usersinfo;
        }
        public bool onlineUser(string phoneNumber)
        {
            throw new NotImplementedException();
        }

        public object sendEmail(string email)
        {
            throw new NotImplementedException();
        }

        public object updateUser(string phoneNumer)
        {
            throw new NotImplementedException();
        }

    }
}