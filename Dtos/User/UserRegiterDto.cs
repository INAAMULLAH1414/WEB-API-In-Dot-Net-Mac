using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WEB_API_In_Dot_Net_Mac.Dtos.User
{
    public class UserRegisterDto
    {
        public string UserName { get; set; } = String.Empty;
        public string Password { get; set; } =  String.Empty;

    }
}