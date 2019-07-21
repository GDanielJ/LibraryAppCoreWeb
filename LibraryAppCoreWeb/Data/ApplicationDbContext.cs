using System;
using System.Collections.Generic;
using System.Text;
using LibraryAppCoreWeb.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LibraryAppCoreWeb.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<Loan> Loans { get; set; }
        public DbSet<LoanBook> LoanBooks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<LoanBook>()
                .HasKey(lb => new { lb.LoanId, lb.BookId });
            modelBuilder.Entity<LoanBook>()
                .HasOne(lb => lb.Book)
                .WithMany(b => b.LoanBooks)
                .HasForeignKey(lb => lb.BookId);
            modelBuilder.Entity<LoanBook>()
                .HasOne(lb => lb.Loan)
                .WithMany(l => l.LoanBooks)
                .HasForeignKey(lb => lb.LoanId);

        }
    }
}
