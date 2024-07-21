using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string? AuthorizationDenied = "Yetkin Yok";
        public static string UserRegistered = "Kullanıcı kayır oldu";
        public static string UserNotFound = "kullanıcı hatası";
        public static string PasswordError = "Şifre hatası";
        public static string SuccessfulLogin = "Başarılı giriş";
        public static string UserAlreadyExists = "Kullanıcı mevcut ";
        public static string AccessTokenCreated = "Token oluşturulduu";
    }
}
