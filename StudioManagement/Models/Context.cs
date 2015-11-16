using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace StudioManagement.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public string  Name { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        public string Address { get; set; }
        public string Mobile { get; set; }
        public bool Active { get; set; }

    }
    //public class UserSetup_Models
    //{
    //    public int studioId { get; set; }
    //    //[Required]
    //    //[Display(Name = "Branch Name")]
    //    //public int branchId { get; set; }
    //    public int userId { get; set; }
    //    [StringLength(50), Required]
    //    [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Use letters only please")]
    //    [Display(Name = "User Name")]
    //    public string userName { get; set; }
        
    //    [StringLength(50), Required]
    //    [Display(Name = "Password")]
    //    public string password { get; set; }
        
    //    public string Address { get; set; }
        
    //    [Required]
    //    [Display(Name = "Role")]
    //    public string Role { get; set; }

    //    [StringLength(10), Required]
    //    [Display(Name = "mobile")]
    //    public string Mobile { get; set; }

    //    [StringLength(50), Required]
    //    [Display(Name = "First Name")]
    //    public string FirstName { get; set; }
    //    public string LastName { get; set; }
    //    public int Age { get; set; }
    //    public string City { get; set; }
    //    public string PinCode { get; set; }

    //    [StringLength(100), Required]
    //    [Display(Name = "email")]
    //    [EmailAddress(ErrorMessage = "Invalid Email Address")]
    //    public string Email { get; set; }

    //    public string DOB { get; set; }
     
    //    public bool Active { get; set; }
    //}

    public class StudioReg
    {
        [Key]
        public int StudioId { get; set; }
        public string StudioName { get; set; }
        public string StudioAddress { get; set; }
        public string Mobile { get; set; }
        public string Phone { get; set; }
        public string City { get; set; }
        public string PinCode { get; set; }
        public string Email { get; set; }
        public string Poc { get; set; }
        public string LicenseNumber { get; set; }
        public DateTime LicenseUpto { get; set; }
        public bool Active { get; set; } 
    }

        public class Login
        {
            [Required]
            public string Email { get; set; }
            [Required]
            public string Password { get; set; }
        }

    public class StudioMng : DbContext
    {
        public DbSet<User> User { get; set; }
        public DbSet<StudioReg> StudioReg { get; set; }
    }

}