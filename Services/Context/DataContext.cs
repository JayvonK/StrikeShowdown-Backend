using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Strike_Showdown_Back_End.Models;
using Strike_Showdown_Back_End.Models.DTO;

namespace Strike_Showdown_Back_End.Services.Context
{
    public class DataContext : DbContext
    {
        public DbSet<UserModel> UserInfo { get; set; }
        public DbSet<MatchItemModel> MatchInfo { get; set; }
        public DbSet<RecentWinnerModel> RecentWinnerInfo { get; set; }
        public DbSet<NotificationModel> NotificationInfo { get; set; }
        public DbSet<MatchScoresModel> MatchScoresModels { get; set; }
        public DbSet<ChatroomModel> Chatrooms { get; set; }
        public DbSet<MessageModel> Messages { get; set; }

        public DataContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}