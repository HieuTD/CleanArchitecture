using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.DTOs.User
{
    public class UserLoginrequest
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
