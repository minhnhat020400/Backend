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
            else return Json(new { message = "failed" });
        }
    }
}