using System;

namespace umeAPI.Models
{
    public class UserAccount
    {
        int idUser;
        string phoneNumber, password, email;
        DateTime  createOn, updateOn,birthDay;
        bool sex,isActive;
        string name;


        public UserAccount(int idUser, string phoneNumber, string password, DateTime createOn, DateTime updateOn, string email, bool isat, DateTime birthDay, bool sex,string name)
        {
            this.idUser = idUser;
            this.phoneNumber = phoneNumber;
            this.password = password;
            this.createOn = createOn;
            this.updateOn = updateOn;
            this.email = email;
            this.isActive = isat;
            this.birthDay = birthDay;
            this.sex = sex;
            this.name = name;
        }

        public int IdUser { get => idUser; set => idUser = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string Password { get => password; set => password = value; }
        public DateTime CreateOn { get => createOn; set => createOn = value; }
        public DateTime UpdateOn { get => updateOn; set => updateOn = value; }
        public string Email { get => email; set => email = value; }
        public DateTime BirthDay { get => birthDay; set => birthDay = value; }
        public bool Sex { get => sex; set => sex = value; }
        public bool IsActive { get => isActive; set => isActive = value; }
        public string Name { get => name; set => name = value; }
    }
}