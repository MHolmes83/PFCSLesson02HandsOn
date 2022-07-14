using System;

namespace PerformingOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 5;

            Console.WriteLine(a == b);

            int c = 5;
            int d = 6;

            Console.WriteLine(c == d);

            int e = 5;
            int f = 6;

            if (e == 6)
            {
                Console.WriteLine("E equals six!");
            }
            else if (f == 6)
            {
                Console.WriteLine("F equals six!");
            }
            else
            {
                Console.WriteLine("False");
            }

            var rating = 7;

            if (rating == 5)
            {
                Console.WriteLine("This food is the best! I could eat this every day.");
            }
            else if (rating == 4)
            {
                Console.WriteLine("Good meal.");
            }
            else if (rating == 3)
            {
                Console.WriteLine("It was OK.");
            }
            else if (rating == 2)
            {
                Console.WriteLine("I did not like this, but it's cheap.");
            }
            else if (rating == 1)
            {
                Console.WriteLine("I will never eat here again.");
            }
            else
            {
                Console.WriteLine("Please enter a valid rating of 1-5.");
            }

            var frankAge = 30;
            var kevinAge = 40;

            Console.WriteLine(frankAge != kevinAge);

            var isHungry = true;
            var isRestaurantOpen = true;

            if (isHungry && isRestaurantOpen)
            {
                Console.WriteLine("Go to the restaurant");
            }
            else
            {
                Console.WriteLine("Don't go to the restaurant.");
            }

            var isSleepy = false;
            var isLibraryClosed = true;

            if (isSleepy || isLibraryClosed)
            {
                Console.WriteLine("You should leave now.");
            }
            else
            {
                Console.WriteLine("Keep on studying!");
            }

            var isDaytime = false;
            var amHungry = false;

            if (!(isDaytime && amHungry))
            {
                Console.WriteLine("Don't eat.");
            }
            else
            {
                Console.WriteLine("Time to eat!");
            }

            var amSleepy = true;
            var isCafeClosed = false;
            var isBatteryDead = false;

            if (amSleepy || isCafeClosed || isBatteryDead)
            {
                Console.WriteLine("You should leave now.");
            }
            else
            {
                Console.WriteLine("Keep on studying");
            }

            var g = 2;
            var h = 4;

            if (g < h)
            {
                Console.WriteLine("g is less than h");
            }
            else
            {
                Console.WriteLine("g is not less than h");
            }

            var i = 5;
            var j = 5;

            if (i < j)
            {
                Console.WriteLine("i is less than j.");
            }
            else
            {
                Console.WriteLine("i is not less than j.");
            }

            var k = 8;
            var l = 8;

            if (k < l)
            {
                Console.WriteLine("k is less than l.");
            }
            else if (k <= l)
            {
                Console.WriteLine("k is the same as l.");
            }
            else
            {
                Console.WriteLine("k is not less than l.");
            }

            var userAge = 22;
            if (userAge < 18)
            {
                Console.WriteLine("Sorry, you are too young to purchase tickets for this movie.");
            }
            else if (userAge >=18)
            {
                Console.WriteLine("Here are your tickets. Enjoy the movie!");
            }

            var sum = 2 + 2;

            Console.WriteLine(sum);

            var anotherSum = 131 - 2 -3 + 4 + 5;

            Console.WriteLine(anotherSum);

            var yetAnotherSum = 4;

            sum = yetAnotherSum + 1;

            Console.WriteLine(sum);

            var add = 4;

            add++;

            Console.WriteLine(add);

            var difference = 4;

            difference--;

            Console.WriteLine(difference);

            var product = 6 * 3;

            Console.WriteLine(product);

            var quotient = 6 / 3;

            Console.WriteLine(quotient);

            Console.WriteLine(2 * 3 + 4);

            Console.WriteLine(2 + 3 * 4);

            var remainder = 5 % 2;

            Console.WriteLine(remainder);

            var anotherRemainder = 54321 % 12345;

            Console.WriteLine(anotherRemainder);

            var morningGreeting = "Good Morning,";
            var name = "Alex";

            Console.WriteLine(morningGreeting);
            Console.WriteLine(name);

            Console.WriteLine(morningGreeting + name);
            Console.WriteLine(morningGreeting + " " + name);

            bool isProgrammer = true;
            Console.WriteLine("Am I a programmer? " + isProgrammer);

            int age = 38;
            Console.WriteLine("My age: " + age);

            var greetingLength = morningGreeting.Length;

            Console.WriteLine(greetingLength);

            Console.WriteLine(morningGreeting.ToUpper());
            Console.WriteLine(morningGreeting.ToLower());
        }
    }
}