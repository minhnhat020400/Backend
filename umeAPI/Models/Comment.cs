using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace umeAPI.Models
{

    public class Comment
    {
        int idComment, idUser, idPoster;
        string content;
        byte isActive;

        public Comment()
        {
        }

        public Comment(int idComment, int idUser, int idPoster, string content, byte isActive)
        {
            this.idComment = idComment;
            this.idUser = idUser;
            this.idPoster = idPoster;
            this.content = content;
            this.isActive = isActive;
        }

        public int IdComment { get => idComment; set => idComment = value; }
        public int IdUser { get => idUser; set => idUser = value; }
        public int IdPoster { get => idPoster; set => idPoster = value; }
        public string Content { get => content; set => content = value; }
        public byte IsActive { get => isActive; set => isActive = value; }
    }
}