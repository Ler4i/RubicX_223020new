using RubicX_223020new.BusinessLogic.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RubicX_223020new.BusinessLogic.Core.Interfaces
{
    public interface IUserService
    {
        Task<UserInformationBlo> RegisterWithPhone(string numberPrefix, string number, string password);//регистрация в ()-запрос
        Task<UserInformationBlo> AuthWithPhone(string numberPrefix, string number, string password);//авторизация через телефон
        Task<UserInformationBlo> AuthWithEmail(string email, string password);//авторизация через мыло
        Task<UserInformationBlo> AuthWithLogin(string login, string password);
        Task<UserInformationBlo> Get(int userId);
        Task<UserInformationBlo> Update(string numberPrefix, string number, string password, UserUpdateBlo userUpdateBlo);//put
        Task<bool> DoesExist(string numberPrefix, string number);
    }
}
