using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainTicketBooking
{
    class Passenger
    {
        string Name; int Age;
        public Passenger(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public static void TicketBooking(int numberOfTickets)
        {
            try
            {
                if (numberOfTickets > 2)
                {
                    throw new Exception("Cannot Book More Than 2 Tickets!");
                }
                Console.WriteLine("Ticket Booked Successfully");
            }
            catch (Exception e)
            {
                Console.WriteLine("Cannot Book More Than 2 Tickets!");
            }
            
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Name: ");
            string Name = Console.ReadLine();
            Console.Write("Enter Age: ");
            int Age = Convert.ToInt32(Console.ReadLine());
            Passenger book = new Passenger(Name, Age);
            Console.Write("Enter Number Of Tickets: ");
            int numberOfTickets = Convert.ToInt32(Console.ReadLine());
            Passenger.TicketBooking(numberOfTickets);
            Console.Read();
        }
    }
}
