using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace WebApplication.Models
{
    public class MyIdentityRole
        :IdentityRole<Guid>
    {
        [StringLength(100)]
        public string Description { get; set; }
    }
}
