using System;
using System.Collections.Generic;
using System.Text;

namespace RubicX_223020new.Core.Models
{
    public class UserInformationDto
    {
        public int Id { get; set; }//столбец
        public string Email { get; set; }
        public bool IsBoy { get; set; }
        public string PhoneNumderPrefix { get; set; }
        public string PhoneNumder { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Patronymic { get; set; }
        public DateTimeOffset Birthday { get; set; }
        public string AvatarUrl { get; set; }
    }
}
