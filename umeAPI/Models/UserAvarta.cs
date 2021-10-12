using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace umeAPI.Models
{
    public class UserAvarta
    {
        int idAvarta, idUser;
        string url, createOn, updateOn, isActive;

        public UserAvarta()
        {
        }

        public UserAvarta(int idAvarta, int idUser, string url, string createOn, string updateOn, string isActive)
        {
            this.idAvarta = idAvarta;
            this.idUser = idUser;
            this.url = url;
            this.createOn = createOn;
            this.updateOn = updateOn;
            this.isActive = isActive;
        }

        public int IdAvarta { get => idAvarta; set => idAvarta = value; }
        public int IdUser { get => idUser; set => idUser = value; }
        public string Url { get => url; set => url = value; }
        public string CreateOn { get => createOn; set => createOn = value; }
        public string UpdateOn { get => updateOn; set => updateOn = value; }
        public string IsActive { get => isActive; set => isActive = value; }
    }
}