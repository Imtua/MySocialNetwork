using SocialNetwork.BLL.Models;
using SocialNetwork.BLL.Services;
using SocialNetwork.PLL.Helpers;

namespace SocialNetwork.PLL.Views
{
    public class UserMenuView
    {
        public void Show(User user)
        {
            while (true)
            {
                Console.WriteLine("Полученые сообщения: {0}", user.IncomingMessages.Count());
                Console.WriteLine("Отправленные сообщения: {0}", user.OutgoingMessages.Count());

                Console.WriteLine("Мой профиль (нажмите 1)");
                Console.WriteLine("Редактировать профиль (нажмите 2)");
                Console.WriteLine("Поиск друзей (нажмите 3)");
                Console.WriteLine("Отправить сообщение (нажмите 4)");
                Console.WriteLine("Входящие сообщения (нажмите 5)");
                Console.WriteLine("Отправленные сообщения (нажмите 6)");
                Console.WriteLine("Выйти (нажмите 7)");

                string keyValue = Console.ReadLine();

                if (keyValue == "7") break;

                switch (Console.ReadLine())
                {
                    case "1":
                        Program.userInfoView.Show(user);
                        break;

                    case "2":

                        Program.userDataUpdateView.Show(user);

                        //Console.WriteLine("Редактировть профиль:");
                        //Console.Write("Новое имя:");
                        //user.FirstName = Console.ReadLine();

                        //Console.Write("Новая фамилия:");
                        //user.LastName = Console.ReadLine();

                        //Console.Write("Новое фото (ссылка):");
                        //user.Photo = Console.ReadLine();

                        //Console.Write("Любимый фильм:");
                        //user.FavoriteMovie = Console.ReadLine();

                        //Console.Write("Любимая книга:");
                        //user.FavoriteBook = Console.ReadLine();

                        //userService.Update(user);

                        //Console.ForegroundColor = ConsoleColor.Green;
                        //Console.WriteLine("Профиль успешно обновлён!");
                        //Console.ForegroundColor = ConsoleColor.White;

                        break;

                    case "4":
                        Program.messageSendingView(user);
                        break;

                    case "5":
                        Program.userIncomingMessagesView.Show(user.IncomingMessages);
                        break;

                    case "6":
                        Program.userOutcomingMessagesView.Show(user.OutcomingMessages);
                        break;

                    default:
                       AlertMessage.Show("Попробуй ещё раз!")
                        break;
                }
            }
        }
    }
}
