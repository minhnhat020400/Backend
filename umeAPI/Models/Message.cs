using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace umeAPI.Models
{
    public class Message
    {
        int idMessage, idUser, toUserId, status;
        byte isActive, IisGim;
        DateTime createOn, viewOn;

        public Message()
        {
        }

        public Message(int idMessage, int idUser, int toUserId, int status, byte isActive, byte iisGim, DateTime createOn, DateTime viewOn)
        {
            this.idMessage = idMessage;
            this.idUser = idUser;
            this.toUserId = toUserId;
            this.status = status;
            this.isActive = isActive;
            IisGim = iisGim;
            this.createOn = createOn;
            this.viewOn = viewOn;
        }

        public int IdMessage { get => idMessage; set => idMessage = value; }
        public int IdUser { get => idUser; set => idUser = value; }
        public int ToUserId { get => toUserId; set => toUserId = value; }
        public int Status { get => status; set => status = value; }
        public byte IsActive { get => isActive; set => isActive = value; }
        public byte IisGim1 { get => IisGim; set => IisGim = value; }
        public DateTime CreateOn { get => createOn; set => createOn = value; }
        public DateTime ViewOn { get => viewOn; set => viewOn = value; }
    }
}