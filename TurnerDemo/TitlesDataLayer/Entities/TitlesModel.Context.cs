﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TitlesDataLayer.Entities
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class TitlesEntities : DbContext
    {
        public TitlesEntities()
            : base("name=TitlesEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Title> Titles { get; set; }
        public DbSet<TitleGenre> TitleGenres { get; set; }
        public DbSet<TitleParticipant> TitleParticipants { get; set; }
        public DbSet<Award> Awards { get; set; }
        public DbSet<Participant> Participants { get; set; }
        public DbSet<StoryLine> StoryLines { get; set; }
    }
}
