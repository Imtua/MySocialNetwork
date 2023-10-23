using SocialNetwork.BLL.Services;
using SocialNetwork.BLL.Models;
using SocialNetwork.BLL.Exceptions;

internal class Program
{
    public static UserService userService = new UserService();
    public static MessageService messageService = new MessageService();

    public static void Main(string[] args)
    {
        Console.WriteLine("Добро пожаловать в социальную сеть.");
        //while (true)
        //{
        //    Console.WriteLine("Авторизоваться нажмите 1");
        //    Console.WriteLine("Для регистрации пользователя нажмите 2");

        //    switch (Console.ReadLine())
        //    {
        //        case "1":
                    
                     
                        
        //            }
        //            catch (WrongPasswordException)
        //            {
        //                SwitchMessageColor(ConsoleColor.Red, "Неверный пароль!");
        //            }
        //            catch (UserNotFoundException)
        //            {
        //                SwitchMessageColor(ConsoleColor.Red, "Пользователь не найден");
        //            }

        //            break;

        //        case "2":
        //            Console.WriteLine("Регистрация");
        //            Console.Write("Имя: ");
        //            string firstName = Console.ReadLine();

        //            Console.Write("Фамилия: ");
        //            string lastName = Console.ReadLine();

        //            Console.Write("Пароль: ");
        //            string password = Console.ReadLine();

        //            Console.Write("Email: ");
        //            string email = Console.ReadLine();

        //            UserRegistrationData userRegistrationData = new UserRegistrationData()
        //            {
        //                FirstName = firstName,
        //                LastName = lastName,
        //                Password = password,
        //                Email = email
        //            };

        //            try
        //            {
        //                userService.Register(userRegistrationData);
        //                SwitchMessageColor(ConsoleColor.Green, "Регистрация прошла успешно!");
        //            }
        //            catch (ArgumentNullException ex)
        //            {
        //                SwitchMessageColor(ConsoleColor.Red, ex.Message, "Введите корректное значение");
        //            }
        //            catch (Exception ex)
        //            {
        //                SwitchMessageColor(ConsoleColor.Red, ex.Message, "Произошла ошибка при регистрации");
        //            }

        //            break;

        //        default:
        //            Console.WriteLine("Такого пункта нет, попробуйте снова");
        //            break;
        //    }
        //}
    }

   

}