using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace umeAPI.Models
{
    public class GroupChat
    {
        int idGroup, numberMember;
        string avartaGroup;
        byte isActive;
        DateTime createOn, updateOn;

        public GroupChat()
        {
        }

        public GroupChat(int idGroup, int numberMember, string avartaGroup, byte isActive, DateTime createOn, DateTime updateOn)
        {
            this.idGroup = idGroup;
            this.numberMember = numberMember;
            this.avartaGroup = avartaGroup;
            this.isActive = isActive;
            this.createOn = createOn;
            this.updateOn = updateOn;
        }

        public int IdGroup { get => idGroup; set => idGroup = value; }
        public int NumberMember { get => numberMember; set => numberMember = value; }
        public string AvartaGroup { get => avartaGroup; set => avartaGroup = value; }
        public byte IsActive { get => isActive; set => isActive = value; }
        public DateTime CreateOn { get => createOn; set => createOn = value; }
        public DateTime UpdateOn { get => updateOn; set => updateOn = value; }
    }
}