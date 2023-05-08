using Newtonsoft.Json;
using PartyManagerLib.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartyManagerLib.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [Required]
        public string Surname { get; set; }
        [Required]
        public string Firstname { get; set; }
        [Required]
        public string Middlename { get; set; }
        [Required]
        public int RoleId { get; set; }
        [Required]
        [JsonIgnore]
        public Role Role
        {
            get
            {
                return DBConnection.Roles.FirstOrDefault(r => r.Id == RoleId);
            }

            set
            {
                RoleId = value.Id;
                Role = value;
            }
        }
        [Required]
        public string Login { get; set; }
        [Required]
        public string Password { get; set; }

        [JsonIgnore]
        public byte[] Image { get; set; }

        [JsonIgnore]
        public string FullName
        {
            get
            {
                return $"{Surname} {Firstname} {Middlename}";
            }
        }
    }
}
