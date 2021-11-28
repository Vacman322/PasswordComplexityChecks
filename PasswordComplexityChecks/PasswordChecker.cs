using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordComplexityChecks
{
    public class PasswordChecker
    {
        private readonly HashSet<char> specialCharacters = new HashSet<char>
        { '#', '$', '%', '^', '&', '_' };

        /// <summary>
        /// Проверяет соответствует ли пароль нужным требованиям
        /// </summary>
        /// <param name="password">Пароль</param>
        /// <returns></returns>
        public bool Check(string password)
        {
            //Количество символов от 8 до 20 
            if (password.Length < 8 || password.Length > 20)
                return false;

            //Встречаются цифры 
            if (!password.Any(ch => char.IsDigit(ch)))
                return false;

            //Встречается как минимум один из спецсимволов: #$%^&_ 
            if (!password.Any(ch => specialCharacters.Contains(ch)))
                return false;

            //Встречаются прописные буквы
            if (!password.Any(ch => char.IsUpper(ch)))
                return false;

            //Встречаются строчные буквы 
            if (!password.Any(ch => char.IsLower(ch)))
                return false;

            return true;
        }
    }
}
