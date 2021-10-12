using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace umeAPI.Models
{
    public class InfoGroup
    {
        int idUser, idGroup;
        DateTime dateJoin;
        byte isActive;

        public InfoGroup()
        {
        }

        public InfoGroup(int idUser, int idGroup, DateTime dateJoin, byte isActive)
        {
            this.idUser = idUser;
            this.idGroup = idGroup;
            this.dateJoin = dateJoin;
            this.isActive = isActive;
        }

        public int IdUser { get => idUser; set => idUser = value; }
        public int IdGroup { get => idGroup; set => idGroup = value; }
        public DateTime DateJoin { get => dateJoin; set => dateJoin = value; }
        public byte IsActive { get => isActive; set => isActive = value; }

    }
}