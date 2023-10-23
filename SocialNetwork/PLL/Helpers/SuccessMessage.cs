namespace SocialNetwork.PLL.Helpers
{
    public class SuccessMessage
    {
        public static void Show(string message)
        {
            ConsoleColor currentColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
            Console.ForegroundColor = currentColor;
        }
    }
}
