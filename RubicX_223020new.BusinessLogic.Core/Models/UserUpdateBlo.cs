using System;
using System.Collections.Generic;
using System.Text;

namespace RubicX_223020new.BusinessLogic.Core.Models
{
    public class UserUpdateBlo
    {
        public int Id { get; set; }//столбец
        public string Email { get; set; }
        public string Login { get; set; }
        public bool IsBoy { get; set; }
        public string Password { get; set; }
        public string PhoneNumderPrefix { get; set; }
        public string PhoneNumder { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Patronymic { get; set; }
        public DateTimeOffset Birthday { get; set; }
        public string AvatarUrl { get; set; }


        public string CurrentPhoneNumber { get; set; }
        public string CurrentPhoneNumderPrefix { get; set; }
        public string CurrentPassword { get; set; }

    }
}
