using Domain.Common;
using Domain.DbModels.Common;
using Domain.DbModels.Loan;
using Domain.DbModels.Saving;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DbModels.Member
{
    [Table("Memberships", Schema = "Member")]
    public class Membership: BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int64 Id { get; set; }
        [MaxLength(200)]
        public string Name { get; set; }
        [MaxLength(200)]
        public string FatherName { get; set; }
        [MaxLength(200)]
        public string MotherName { get; set; }
        [MaxLength(200)]
        public string? SpouseNameName { get; set; }
        [MaxLength(10)]
        public string MembershipNumber { get; set; }
        public DateTime? DateOfBirth { get; set; }
        [MaxLength(500)]
        public string? Address { get; set; }
        [MaxLength(15)]
        public string? PhoneNumber { get; set; }
        [MaxLength(15)]
        public string? AlternatePhoneNumber { get; set; }
        [MaxLength(50)]
        public string? EmailAddress { get; set; }
        public decimal ShareCapital { get; set; }
        public DateTime? MembershipDate { get; set; }
        public Int16? MembershipStatusId { get; set; }
        [MaxLength(200)]
        public string? PhotoUrl { get; set; }
        [MaxLength(200)]
        public string? NomineeName { get; set; }
        [MaxLength(500)]
        public string? NomineeAddress { get; set; }
        [MaxLength(15)]
        public string? NomineePhoneNumber { get; set; }
        public Int64? IntroducedByMemberId { get; set; }
        public Membership IntroducedByMember { get; set; }
        [MaxLength(50)]
        public string? NID { get; set; }
        public Int16 GenderId { get; set; }
        public Gender Gender { get; set; }
        public Int16 MaritalStatusId { get; set; }
        public MaritalStatus MaritalStatus { get; set; }
        public Int16 MembershipTypeId { get; set; }
        public MembershipType MembershipType { get; set; }
        public Int16 ReligionId { get; set; }
        public Religion Religion { get; set; }

        public Int16? MobileBankingId { get; set; }
        public MobileBanking MobileBanking { get; set; }

        public Int16? CountryId { get; set; }
        public Country Country { get; set; }
        public Int16? DivisionId { get; set; }
        public Division Division { get; set; }
        public Int16? DistrictId { get; set; }
        public District District { get; set; }

        public Int16? UpazilaId { get; set; }
        public Upazila Upazila { get; set; }

        public Int16? UnionId { get; set; }
        public Union Union { get; set; }
        public string? VillageName { get; set; }


        #region Education and Service
        public Int16 EducationLevelId { get; set; }
        public EducationLevel EducationLevel { get; set; }
        public Int16 DesignationId { get; set; }
        public Designation Designation { get; set; }
        public Int16 ServiceDepartmentId { get; set; }
        public ServiceDepartment ServiceDepartment { get; set; }

        public Int16 ServiceDivisionId { get; set; }
        public ServiceDivision ServiceDivision { get; set; }
        public Int16? ServiceLocationCountryId { get; set; }
        public Country ServiceLocationCountry { get; set; }
        public Int16? ServiceLocationDivisionId { get; set; }
        public Division ServiceLocationDivision { get; set; }
        public Int16? ServiceLocationDistrictId { get; set; }
        public District ServiceLocationDistrict { get; set; }

        public Int16? ServiceLocationUpazilaId { get; set; }
        public Upazila ServiceLocationUpazila { get; set; }
        #endregion


        //1 to Many
        public ICollection<Deposit> Deposits { get; set; }
        //1 to Many
        public ICollection<LoanDisbursement> LoanDisbursements { get; set; }
        //1 to Many
        public ICollection<LoanApplication> LoanApplications { get; set; }


    }
}
