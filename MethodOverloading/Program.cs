namespace MethodOverloading
{
    public class Program
    {
        public static int Add(int a, int b)
        {
            return (a + b);
        }

        public static decimal Add(decimal a, decimal b)
        {
            return (a + b);
        }

        public static void Add(int a, int b, bool isTrue)
        {
            var sum = a + b;
            if (sum == 1 && isTrue == true)
            {
                Console.WriteLine($"That rounds to {sum} dollar!");
            }
            else if (sum != 1 && isTrue == true)
            {
                Console.WriteLine($"That rounds to {sum} dollars!");
            }
            else
            {
                Console.WriteLine($"That rounds to {sum}.");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Console.WriteLine("Let's do a little Math. True or False: You like math.");
            bool mathWiz = bool.Parse(Console.ReadLine());

            if (mathWiz == false)
                {
                    Console.WriteLine("Ok, I understand. Let's try anyway.");
                }
            else
                {
                    Console.WriteLine("That's great! Let's get started!");
                }

            Console.WriteLine("What is your favorite number?");
            var favoriteNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("What is your second favorite number?");
            var secondNumber = int.Parse(Console.ReadLine());

            Console.WriteLine($"Did you know that {favoriteNumber} + {secondNumber} equals {Add(favoriteNumber, secondNumber)}?");

            Console.WriteLine("Time to get a little more personal. How much could you donate to a charity today? (ex. 5.00)");
            var charityDonation = decimal.Parse(Console.ReadLine());
            int charityDonationInt = (int)Math.Round(charityDonation);

            Console.WriteLine("How much have you donated this year? (ex. 5.00)");
            var currentDonationAmount = decimal.Parse(Console.ReadLine());
            int currentDonationAmountInt = (int)Math.Round(currentDonationAmount);

            var donationTotal = Add(charityDonation, currentDonationAmount);

            Console.WriteLine($"Overall, that is ${donationTotal}! Every little bit counts!");

            if (mathWiz == true)
                {
                    Add(charityDonationInt, currentDonationAmountInt, true);
                }

            else
                {
                    Add(charityDonationInt, currentDonationAmountInt, false);
                }

        }
    }
}
