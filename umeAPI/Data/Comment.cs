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
    
    public partial class Comment
    {
        public int idComment { get; set; }
        public System.DateTime createOn { get; set; }
        public string content { get; set; }
        public int idUser { get; set; }
        public int idPoster { get; set; }
        public Nullable<bool> isActive { get; set; }
    }
}
