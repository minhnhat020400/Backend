﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ChatUmeDTBEntities5 : DbContext
    {
        public ChatUmeDTBEntities5()
            : base("name=ChatUmeDTBEntities5")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Comment> Comments { get; set; }
        public virtual DbSet<Friend> Friends { get; set; }
        public virtual DbSet<GroupChat> GroupChats { get; set; }
        public virtual DbSet<groupChatMessage> groupChatMessages { get; set; }
        public virtual DbSet<InfoGroup> InfoGroups { get; set; }
        public virtual DbSet<Liked> Likeds { get; set; }
        public virtual DbSet<Message> Messages { get; set; }
        public virtual DbSet<Poster> Posters { get; set; }
        public virtual DbSet<UserAccount> UserAccounts { get; set; }
        public virtual DbSet<UserAvarta> UserAvartas { get; set; }
        public virtual DbSet<UserNotification> UserNotifications { get; set; }
    }
}
