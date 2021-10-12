using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace umeAPI.Models
{
    public class groupChatMessage
    {
        int idUser, idGroup, toUserId;
        string status;
        byte isGim;
        DateTime createOn;

        public groupChatMessage()
        {
        }

        public groupChatMessage(int idUser, int idGroup, int toUserId, string status, byte isGim, DateTime createOn)
        {
            this.idUser = idUser;
            this.idGroup = idGroup;
            this.toUserId = toUserId;
            this.status = status;
            this.isGim = isGim;
            this.createOn = createOn;
        }

        public int IdUser { get => idUser; set => idUser = value; }
        public int IdGroup { get => idGroup; set => idGroup = value; }
        public int ToUserId { get => toUserId; set => toUserId = value; }
        public string Status { get => status; set => status = value; }
        public byte IsGim { get => isGim; set => isGim = value; }
        public DateTime CreateOn { get => createOn; set => createOn = value; }
    }
}