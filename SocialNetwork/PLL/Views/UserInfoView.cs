namespace SocialNetwork.PLL.Views
{
    public class UserInfoView
    {
        public void Show(User user)
        {
            SuccessMessage.Show("��� �������:");
            Console.WriteLine("Id: {0}", user.Id);
            Console.WriteLine("�� ���: {0}", user.FirstName);
            Console.WriteLine("��� �������: {0}", user.LastName);
            Console.WriteLine("��� ������: {0}", user.Password);
            Console.WriteLine("��� �������� �����: {0}", user.Email);
            Console.WriteLine("������ �� �� ����: {0}", user.Photo);
            Console.WriteLine("��� ������� �����: {0}", user.FavoriteMovie);
            Console.WriteLine("��� ������� �����: {0}", user.FavoriteBook);
        }
    }
}
