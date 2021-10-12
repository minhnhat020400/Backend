using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace umeAPI.Models
{
    public class Poster
    {
        int idPoster, likeNumber, idUser, commentNumber;
        string imgPoster, content;
        DateTime createOn;
        byte isActive;

        public Poster()
        {
        }

        public Poster(int idPoster, int likeNumber, int idUser, int commentNumber, string imgPoster, string content, DateTime createOn, byte isActive)
        {
            this.idPoster = idPoster;
            this.likeNumber = likeNumber;
            this.idUser = idUser;
            this.commentNumber = commentNumber;
            this.imgPoster = imgPoster;
            this.content = content;
            this.createOn = createOn;
            this.isActive = isActive;
        }

        public int IdPoster { get => idPoster; set => idPoster = value; }
        public int LikeNumber { get => likeNumber; set => likeNumber = value; }
        public int IdUser { get => idUser; set => idUser = value; }
        public int CommentNumber { get => commentNumber; set => commentNumber = value; }
        public string ImgPoster { get => imgPoster; set => imgPoster = value; }
        public string Content { get => content; set => content = value; }
        public DateTime CreateOn { get => createOn; set => createOn = value; }
        public byte IsActive { get => isActive; set => isActive = value; }
    }
}