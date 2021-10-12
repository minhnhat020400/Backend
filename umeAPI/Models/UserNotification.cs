using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace umeAPI.Models
{
    public class UserNotification
    {
        int idNotification, idUser;
        byte isRead;
        string content;
        DateTime creataOn, readOn;
        public UserNotification()
        {
        }

        public UserNotification(int idNotification, int idUser, byte isRead, string content, DateTime creataOn, DateTime readOn)
        {
            this.idNotification = idNotification;
            this.idUser = idUser;
            this.isRead = isRead;
            this.content = content;
            this.creataOn = creataOn;
            this.readOn = readOn;
        }

        public int IdNotification { get => idNotification; set => idNotification = value; }
        public int IdUser { get => idUser; set => idUser = value; }
        public byte IsRead { get => isRead; set => isRead = value; }
        public string Content { get => content; set => content = value; }
        public DateTime CreataOn { get => creataOn; set => creataOn = value; }
        public DateTime ReadOn { get => readOn; set => readOn = value; }
    }
}