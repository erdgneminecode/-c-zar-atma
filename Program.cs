using System;

namespace Odev_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adınızı giriniz:");
            string player1Name = Console.ReadLine();

            Console.WriteLine("Soyadınızı giriniz:");
            string player2Surname = Console.ReadLine();

            Console.WriteLine("Doğum gününüzü giriniz:");
            int birthday = int.Parse(Console.ReadLine());

            Random random = new Random(birthday);

            int player1CardIndex = random.Next(52);
            int player2CardIndex = random.Next(52);

            Console.WriteLine($"{player1Name} {player1CardIndex + 1}. kartı çekti.");
            Console.WriteLine($"{player2Surname} {player2CardIndex + 1}. kartı çekti.");

            int player1CardValue = CalculateCardValue(player1CardIndex, birthday);
            int player2CardValue = CalculateCardValue(player2CardIndex, birthday);

            Console.WriteLine($"{player1Name} {player1CardValue} puan aldı.");
            Console.WriteLine($"{player2Surname} {player2CardValue} puan aldı.");

            if (player1CardValue > player2CardValue)
            {
                Console.WriteLine($"{player1Name} kazandı!");
            }
            else if (player2CardValue > player1CardValue)
            {
                Console.WriteLine($"{player2Surname} kazandı!");
            }
            else
            {
                Console.WriteLine("Berabere!");
            }

            Console.ReadLine();
        }

        static int CalculateCardValue(int cardIndex, int birthday)
        {
            int[] cardValues = { 1, 1, 1, 1, 2, 2, 3, 3, 4, 4, 10, 11, 12 };
            int[] cardSuits = { 1, 2, 3, 4 };

            int suit = cardIndex / 13;
            int value = cardIndex % 13;

            if (value == 10 && suit == (birthday % 4))
            {
                return 20;
            }
            else if (value == 11 && suit == (birthday % 4))
            {
                return 20;
            }
            else if (value == 12 && suit == (birthday % 4))
            {
                return 20;
            }
            else if (value == 7)
            {
                return 10;
            }
            else if (value == 10)
            {
                return 2;
            }
            else if (value == 11)
            {
                return 3;
            }
            else if (value == 12)
            {
                return 4;
            }
            else
            {
                return cardValues[value];
            }
        }
    }
}
