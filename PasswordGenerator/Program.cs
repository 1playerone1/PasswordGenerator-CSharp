namespace PasswordGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Şifrenin uzunluğunu giriniz:");
            string? input = Console.ReadLine();
            if (input != null)
            {
                int length = int.Parse(input);

                string password = GeneratePassword(length);
                Console.WriteLine($"Şifreniz: {password}");
            }
        }

        static string GeneratePassword(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*()_+";
            var random = new Random();
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}