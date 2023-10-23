using SocialNetwork.BLL.Exceptions;
using SocialNetwork.BLL.Models;
using SocialNetwork.BLL.Services;
using SocialNetwork.PLL.Helpers;

namespace SocialNetwork.PLL.Views
{
    internal class AutenticationView
    {
        private UserService _userService;

        public AutenticationView(UserService userService)
        {
            _userService = userService;
        }

        public void Show()
        {
            var autentificationData = new UserAuthentificationData();

            Console.Write("Введите email: ");
            autentificationData.Email = Console.ReadLine();

            Console.Write("Введите пароль: ");
            autentificationData.Password = Console.ReadLine();

            try
            {
                User user = _userService.Authenticate(autentificationData);

                SuccessMessage.Show($"С возвращением, {user.FirstName}!");

                Program.userMenuView.Show(user);
            }
            catch (WrongPasswordException)
            {
                AlertMessage.Show("Неверный пароль!");
            }
            catch (UserNotFoundException)
            {
                AlertMessage.Show("Пользователь не найден!");
            }
        }
    }
}
