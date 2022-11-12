using Lesson_13.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_13
{
    public class Authorization
    {
        public static bool CheckUserData(string login, string password, string confirmPassword)
        {
            bool checkLogin = false;
            bool checkPassword = false;
            bool passwordEquals = false;
            try
            {
                checkLogin = CheckLogin(login);
                checkPassword = CheckPassword(password);
                passwordEquals = PasswordEquals(password, confirmPassword);
            }
            catch (WrongLoginException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (WrongPasswordException ex)
            {
                Console.WriteLine(ex.Message);
            }

            if (checkLogin == true && checkPassword == true && passwordEquals == true)
            {
                return true;
            }

            return false;
        }

        private static bool CheckLogin(string login)
        {
            if (login.Length < 20)
            {
                return true;
            }

            throw new WrongLoginException("Quantity symbols in string bigest 20");
        }

        private static bool CheckPassword(string password)
        {
            bool checkSpace = false;
            bool checkNumber = false;

            if (password.Length > 20)
            {
                throw new WrongPasswordException("Password have bigest 20 lenght");
            }

            for (int i = 0; i < password.Length; i++)
            {
                if (password[i] == ' ')
                {
                    checkSpace = true;
                    continue;
                }
                else if (char.IsDigit(password[i]))
                {
                    checkNumber = true;
                }
            }

            if (checkNumber == false || checkSpace == true)
            {
                throw new WrongPasswordException("Password does not contain numbers or contains spaces");
            }

            return true;
        }

        private static bool PasswordEquals(string password, string confirmPassword)
        {

            if (password.Length > 20 || confirmPassword.Length > 20)
            {
                throw new WrongPasswordException("Password have bigest 20 lenght");
            }
            else if (password.Length != confirmPassword.Length)
            {
                throw new WrongPasswordException("Passwords length does not equals");
            }
            else
            {
                for (int i = 0; i < password.Length; i++)
                {
                    if (password[i] != confirmPassword[i])
                    {
                        throw new WrongPasswordException("Passwords length does not equals");
                    }
                }
            }

            return true;
        }
    }
}
