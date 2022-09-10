using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace EindWerk_CinemaTicket.Models
{
    public class User: IdentityUser
    {
        [Display(Name = "Full Name")]
        public string FullName { get; set; }

    }
}
