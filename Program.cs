using System;
using System.Collections.Generic;
using System.Globalization;
using Aula152.Entities;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Room number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Check-in date (dd/MM/yyyy):");
            DateTime checkin = DateTime.Parse(Console.ReadLine());
            Console.Write("Check-out date(dd/MM/yyyy):");
            DateTime checkout = DateTime.Parse(Console.ReadLine());

            if (checkout <= checkin)
            {
                Console.WriteLine("Error in reservation: Checkout date must be  after checkin date");
            }
            else
            {
                Reservation reservation = new Reservation(number, checkin, checkout);
                Console.WriteLine("Reservation: " + reservation);

                Console.WriteLine();
                Console.WriteLine("Enter data to update the reservation: ");
                Console.Write("Check-in date (dd/MM/yyyy):");
                checkin = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date(dd/MM/yyyy):");
                checkout = DateTime.Parse(Console.ReadLine());

                string error = reservation.UpdateDates(checkin, checkout);
                if (error != null)
                {
                    Console.WriteLine("Error in reservation: " + error);
                }
                else
                {
                    Console.WriteLine("Reservation: " + reservation);
                }
            }

        }
    }
}
