using System;

namespace HexToASCII
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = {
                "4B", "4F", "4C", "49", "4B", "20", "50", "49",
                "53", "4D", "45", "4E", "45", "4B", "20", "4D",
                "41", "20", "4E", "41", "5A", "45", "56", "20",
                "46", "49", "52", "4D", "59", "20", "41", "4D",
                "49", "20", "50", "52", "41", "48", "41", "3F"
            };
            Console.WriteLine(HexToASCII(input));
        }

        public static string HexToASCII(string[] arr)
        {
            char[] letters = new char[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                int first = GetHexFirst(arr[i].Substring(0, 1));
                int second = GetHexSecond(arr[i].Substring(1, 1));
                letters[i] = Convert.ToChar(first + second);
            }
            return new string(letters);
        }

        public static int GetHexFirst(string str)
        {
            return int.Parse(str) * 16;
        }

        public static int GetHexSecond(string str)
        {
            switch (str)
            {
                case "A": return 10;
                case "B": return 11;
                case "C": return 12;
                case "D": return 13;
                case "E": return 14;
                case "F": return 15;
                default: return int.Parse(str);
            }
        }
    }
}
