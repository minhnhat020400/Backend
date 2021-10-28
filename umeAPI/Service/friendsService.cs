using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using umeAPI.Data;
using umeAPI.Repo;

namespace umeAPI.Service
{
    public class friendsService : friendsRepo
    {
        ChatUmeDTBEntities5 data = new ChatUmeDTBEntities5();
        UserService service= new UserService();

        public object addnewFriend(int idUser, int idFriend)
        {
            SqlParameter iduser =  new SqlParameter( "@idU",idUser);
            SqlParameter idf = new SqlParameter("@idf", idFriend);
            
            SqlParameter[] sqlParameters = new SqlParameter[] { iduser, idf };
            try
            {
                int add = data.Database.ExecuteSqlCommand
                            ("insert into Friends(idUser,idFriend) values (@idU,@idf)", sqlParameters);
                if (add == 1)// nếu đã thêm thành công thì xuất ra người dùng mới add
                {
                    var account = service.SerchUserByIdUer(idFriend);
                    if (account != null)
                        return account;
                }
                else return null;
            }
            catch (Exception)
            {
                return null;

            }
            return null;
        }

        public bool deteteFriend(int idUser)
        {
            throw new NotImplementedException();
        }

        public object showlistfriends(int idUser)
        {      
            SqlParameter id = new SqlParameter("@id", idUser);
            var result = data.UserAccounts.SqlQuery("select c.* from UserAccount c, Friends f where c.idUser = f.idFriend and f.idUser=@id", id).ToList<UserAccount>();

            return result;
        }

        public object updatefriends(int idUser, string nickname)
        {
            throw new NotImplementedException();
        }
    }
}