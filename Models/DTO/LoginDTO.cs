using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Strike_Showdown_Back_End.Models.DTO
{
    public class LoginDTO
    {
        public string UsernameOrEmail { get; set; }
        public string Password { get; set; }
    }
}