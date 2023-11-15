using System;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace PerformingOperation
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 5;
            Console.WriteLine(a == b);

            int c = 5;
            int d = 3;
            Console.WriteLine(c == d);

            int e = 9;
            int f = 8;
            bool result = (e == f);
            Console.WriteLine(result);

            var g = 7;
            var h = 8;
            if (g == 8)
            {
                Console.WriteLine("G equals eight!");
            }
            else if (h == 8)
            {
                Console.WriteLine("H equals eight!");
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

            if(isHungry && isRestaurantOpen)
            {
                Console.WriteLine("Go to the restaurant!");
            }
            else
            {
                Console.WriteLine("Don't go to the restaurant");
            }

            var isSleepy = false;
            var isLibraryClosed = true;

            if(isSleepy || isLibraryClosed )
            {
                Console.WriteLine("You should leave now.");
            }
            else
            {
                Console.WriteLine("Keep on studying!");
            }

            var isDayTime = true;
            Console.WriteLine(!isDayTime);

            var isStillDayTime = false;
            var isStillHungry = false;

            if(!(isStillDayTime && isStillHungry))
            {
                Console.WriteLine("Don't eat.");
            }
            else
            {
                Console.WriteLine("Time to eat!");
            }

            var isSleepy2 = true;
            var isLibraryClosed2 = false;
            var isBatteryDead = false;

            if(isSleepy2 || isLibraryClosed2 || isBatteryDead)
            {
                Console.WriteLine("You should leave now");
            }
            else
            {
                Console.WriteLine("Keep on Studying");
            }

            if(isBatteryDead || isSleepy2 && isLibraryClosed2)
            {
                Console.WriteLine("You should leave now.");
            }
            else
            {
                Console.WriteLine("Keep on Studying");
            }

            var i = 2;
            var j = 4;

            if(i < j)
            {
                Console.WriteLine("i is less than j.");
            }
            else
            {
                Console.WriteLine("i is not less than j.");
            }

            var k = 4;
            var l = 4;

            if(k < l)
            {
                Console.WriteLine("k is less than l");
            }
            else
            {
                Console.WriteLine("k is not less than l.");
            }

            var m = 4;
            var n = 4;

            if(m < n)
            {
                Console.WriteLine("m is less than n");
            }
            else if(m <= n)
            {
                Console.WriteLine("m is the same as n.");
            }
            else
            {
                Console.WriteLine("m is not less than n");
            }

            var userAge = 22;

            if(userAge < 18)
            {
                Console.WriteLine("Sorry, you are too young to purchase tickets for this movie.");
            }
            else if(userAge >= 18)
            {
                Console.WriteLine("Here are tickets. Enjoy the movie!");
            }

            var sum = 2 + 2;
            Console.WriteLine(sum);

            var newSum = 131 - 2 - 3 + 4 + 5;
            Console.WriteLine(newSum);

            var anotherSum = 4;
            
            sum = anotherSum + 1;
            Console.WriteLine(sum);

            var newerSum = 4;
            newerSum++;
            Console.WriteLine(newerSum);

            var newestSum = 4;
            newestSum--;
            Console.WriteLine(newestSum);

            var product = 6 * 3;
            Console.WriteLine(product);

            var quotient = 6 / 3;
            Console.WriteLine(quotient);

            Console.WriteLine(2 * 3 + 4);

            Console.WriteLine(2 + 3 * 4);

            var remainder =  5 % 2;
            Console.WriteLine(remainder);

            var newRemainder =  54321 % 123445;
            Console.WriteLine(newRemainder);

            double cost = 250;
            double deliveryFee = 25;
            double cents = (cost + deliveryFee) * 100;

            Console.WriteLine(cents);

            double o = 25;
            double p = 14;
            double average = (o + p) / 2;

            Console.WriteLine(average);

            var morningGreeting = "Good Morning, ";
            var name = "Alex";

            Console.WriteLine(morningGreeting);
            Console.WriteLine(name);
            Console.WriteLine(morningGreeting + name);

            bool isProgrammer = true;
            Console.WriteLine("Am I a programmer? " + isProgrammer);

            int age = 40;
            Console.WriteLine("My age: " + age);

            Console.WriteLine(morningGreeting.Length);
            
            var greetingLength = morningGreeting.Length;
            Console.WriteLine(greetingLength);

            Console.WriteLine(morningGreeting.ToUpper());
            Console.WriteLine(morningGreeting.ToLower());

            string firstName = "Nathan";
            string lastName = "Ford";
            string fullName = firstName + " " + lastName;

            Console.WriteLine(fullName);

            string source = "four";
            int count = 4;
            bool lengthMatches = (source.Length == count);

            Console.WriteLine(lengthMatches);
        }
    }
}