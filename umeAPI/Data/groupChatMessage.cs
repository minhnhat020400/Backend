//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace umeAPI.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class groupChatMessage
    {
        public int idUser { get; set; }
        public int idGroup { get; set; }
        public string status { get; set; }
        public int toUserId { get; set; }
        public Nullable<System.DateTime> createOn { get; set; }
        public Nullable<bool> isGim { get; set; }
    }
}
