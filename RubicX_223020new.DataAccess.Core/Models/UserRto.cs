using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RubicX_223020new.DataAccess.Core.Models
{
    [Table("User")]
    public class UserRto//описание только таблицы
    {
        [Key] public int Id { get; set; }//столбец
        public string Email { get; set; }
        public string Login { get; set; }
        public bool IsBoy { get; set; }
        [Required] public string PhoneNumberPrefix { get; set; }
        [Required] public string PhoneNumber { get; set; }
        [Required, MinLength(7)] public string Password { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Patronymic { get; set; }
        public DateTimeOffset Birthday { get; set; }
        public string AvatarUrl { get; set; }

        [NotMapped]
        public string GetFullName
        {//не колонка
            get => FirstName + " " + LastName + " " + Patronymic;
        }
    }
}
