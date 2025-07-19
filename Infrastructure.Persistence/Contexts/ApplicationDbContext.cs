using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Infrastructure.Shared.Services.Interfaces;
using Domain.Common;
using Domain.DbModels.MemberManagement;
using Domain.DbModels.Saving;
using Domain.DbModels.Loan;
using Domain.DbModels.Common;
using Domain.DbModels.Expenditure;

namespace Infrastructure.Persistence.Contexts
{
    public class ApplicationDbContext : DbContext
    {
        private readonly IDateTimeService _dateTime;
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options, IDateTimeService dateTime) : base(options)
        {
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
            _dateTime = dateTime;
        }

        //Declare here the db contexts
        #region Schema: Common
        public DbSet<Country> Countries { get; set; }
        public DbSet<District> Districts { get; set; }
        public DbSet<Division> Divisions { get; set; }
        public DbSet<EducationLevel> EducationLevels { get; set; }
        public DbSet<Gender> AutGenders { get; set; }
        public DbSet<MaritalStatus> MaritalStatuses { get; set; }
        //public DbSet<Member> AutMembers { get; set; }
        public DbSet<MembershipType> MembershipTypes { get; set; }
        public DbSet<MobileBanking> MobileBankings { get; set; }
        public DbSet<Occupation> Occupations { get; set; }
        public DbSet<Designation> Positions { get; set; }
        public DbSet<Religion> Religions { get; set; }
        public DbSet<ServiceDepartment> ServiceDepartments { get; set; }
        public DbSet<ServiceDivision> ServiceDivisions { get; set; }
        
        public DbSet<Union> Unions { get; set; }
        public DbSet<Upazila> Upazilas { get; set; }
        #endregion

        #region Schema: Membership
        public DbSet<Membership> Registrations { get; set; }
        public DbSet<Unregistration> Unregistrations { get; set; }
        #endregion

        #region Schema: Saving
        public DbSet<Deposit> Deposits { get; set; }
        #endregion
        

        #region Schema: Loan
        public DbSet<Application> Applications { get; set; }
        public DbSet<Collection> Collections { get; set; }
        public DbSet<Disbursement> Disbursements { get; set; }
        #endregion

        #region Schema: Expenditure
        public DbSet<Expense> Expenses { get; set; }
        #endregion

        #region Schema: Welfare
        public DbSet<Application> WelfareApplications { get; set; }
        public DbSet<Application> WelfareDisbursements { get; set; }
        #endregion


        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            foreach (var entry in ChangeTracker.Entries<AuditableBaseEntity>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.Created = _dateTime.NowUtc;
                        break;
                    case EntityState.Modified:
                        entry.Entity.LastModified = _dateTime.NowUtc;
                        break;
                }
            }
            return base.SaveChangesAsync(cancellationToken);
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            //Commented on 13072025
            //All Decimals will have 18,6 Range
            //foreach (var property in builder.Model.GetEntityTypes()
            //.SelectMany(t => t.GetProperties())
            //.Where(p => p.ClrType == typeof(decimal) || p.ClrType == typeof(decimal?)))
            //{
            //    property.SetColumnType("decimal(18,6)");
            //}
            base.OnModelCreating(builder);
        }
    }
}
