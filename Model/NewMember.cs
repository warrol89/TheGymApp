using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TheGymApp.Model
{
    public class NewMember
    {
        [Required]
        public string MemberName { get; set; }
        [Phone(ErrorMessage ="Invalid Phone Number")]
        public int PhoneNumber { get; set; }
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string EmailAddress { get; set; }
        [DataType(DataType.DateTime,ErrorMessage = "Date of Appointment Invalid")]
        public DateTime DateOfAppointment { get; set; }
        [DataType(DataType.DateTime, ErrorMessage = "DOB Invalid type")]
        public DateTime DateOfBirth { get; set; }

    }
}
