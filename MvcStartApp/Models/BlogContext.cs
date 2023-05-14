﻿using Microsoft.EntityFrameworkCore;
using MvcStartApp.Models;
using System;
using System.Threading.Tasks;

namespace MvcStartApp.Models
{
    public sealed class BlogContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<UserPost> UserPosts { get; set; }
        public DbSet<Request> Requests { get; set; }
        public BlogContext(DbContextOptions<BlogContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
