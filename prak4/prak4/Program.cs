namespace prak4
{
    internal class Program
    {

        public static void Main(string[] args)
        {
            Console.Write("Введите римское число: ");
            string? roman = Console.ReadLine();
            int result = 0;

            Dictionary<char, int> TranslateRoman = new Dictionary<char, int>
           {
                {'I', 1}, {'V', 5}, {'X', 10}, {'L', 50}, {'C', 100}, {'D', 500}, {'M', 1000}
           };

            for (int i = 0; i < roman.Length; i++)
            {
                if (i != TranslateRoman[] || i + 1 < roman.Length && TranslateRoman[roman[i]] < TranslateRoman[roman[i + 1]])
                {
                    result -= TranslateRoman[roman[i]];
                }
                else
                {
                    result += TranslateRoman[roman[i]];
                }
            }
            Console.WriteLine("Вы ввели: " + result);
        }
    }
}
    
