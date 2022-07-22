using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    class ATM
    {
        public List<Card> Cards { get; set; }

        public ATM()
        {
            Cards = new List<Card>();
        }

        public void CreateATMCard()
        {
            var card = new Card();

            Console.WriteLine("Create a new card!");
            Console.WriteLine();
            Console.Write("Enter your name: ");
            card.Name = Console.ReadLine();
            Console.Write("Enter Your Card number: ");
            card.CardNumber = Console.ReadLine();
            Console.Write("Create your Pin: ");
            card.Pin = Convert.ToInt32(Console.ReadLine());

            card.Balance = 20000;
            card.ExpiryDate = DateTime.Now.AddHours(48);

            Cards.Add(card);
        }

        public void WithDraw()
        {
            for (int i = 0; i < 4; i++)
            {
                Console.Write("Enter your Pin: ");
                int secretPin = Convert.ToInt32(Console.ReadLine());

                var code = Cards.FirstOrDefault(a => a.Pin == secretPin);
                if (code != null)
                {
                    Console.Write("Enter amount to withdraw: ");
                    int amount = Convert.ToInt32(Console.ReadLine());
                    if (amount < 20000)
                    {
                        Console.WriteLine("Transaction successful");
                        Console.WriteLine("Press 1 to check current balance");
                        var currentBalance = Convert.ToInt32(Console.ReadLine());
                        switch (currentBalance)
                        {
                            case 1:
                                code.Balance -= amount;
                                Console.Write("Your new balance is {0}", code.Balance);
                                break;
                            default:
                                Console.WriteLine("Thanks for banking with us");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Insufficient funds");
                    }break;
                }
                else
                {
                    Console.WriteLine("wrong pin you have {0} times left", 3-i);
                }
                if (i == 4)
                {
                    Console.WriteLine("Retries exceeded");
                    break;
                }
            }

        }
    }
}
