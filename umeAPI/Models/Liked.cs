using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace umeAPI.Models
{
    public class Liked
    {
        int idPoster, idUser;
        DateTime dateAction, updateTime;
        byte isLike;

        public Liked()
        {
        }

        public Liked(int idPoster, int idUser, DateTime dateAction, DateTime updateTime, byte liked)
        {
            this.idPoster = idPoster;
            this.idUser = idUser;
            this.dateAction = dateAction;
            this.updateTime = updateTime;
            this.isLike = liked;
        }

        public int IdPoster { get => idPoster; set => idPoster = value; }
        public int IdUser { get => idUser; set => idUser = value; }
        public DateTime DateAction { get => dateAction; set => dateAction = value; }
        public DateTime UpdateTime { get => updateTime; set => updateTime = value; }
        public byte IsLiked { get => isLike; set => isLike = value; }
    }
}