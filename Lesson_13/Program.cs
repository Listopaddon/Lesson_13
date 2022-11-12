namespace Lesson_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string login = "Ivan";
            string password = "kakazoid9";
            string confirmPassword = "kakazoid9";


            Console.WriteLine(Authorization.CheckUserData(login, password, confirmPassword));
        }
    }
}