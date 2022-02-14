using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebApplication.Models;

namespace WebApplication.Models
{
    public class MyIdentityUser
        :IdentityUser<Guid>
    {
        [Display(Name ="Display Name")]
        [Required]
        [MinLength(3)]
        [StringLength(60)]
        public string DisplayName { get; set; }

        [Display(Name ="Date Of Birth")]
        [PersonalData]
        [Required]
        [Column(TypeName = "smalldatetime")]
         public DateTime DateofBirth { get; set; }

        [Required]
        [Display (Name ="Is Admin USer")]
         public string IsAdminUser { get; set; }
    }
}
