using System;
using Course.Entities;
using Course.Entities.Exceptions;

namespace Course {
    class Program {
        static void Main(string[] args) {

            try {
                Console.Write("Room number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Check-in date (dd/MM/yyyy): ");
                DateTime checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy): ");
                DateTime checkOut = DateTime.Parse(Console.ReadLine());

                Reservation reservation = new Reservation(number, checkIn, checkOut);
                Console.WriteLine("Reservation: " + reservation);

                Console.WriteLine();
                Console.WriteLine("Enter data to update the reservation:");
                Console.Write("Check-in date (dd/MM/yyyy): ");
                checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy): ");
                checkOut = DateTime.Parse(Console.ReadLine());

                reservation.UpdateDates(checkIn, checkOut);
                Console.WriteLine("Reservation: " + reservation);
            }
            catch (FormatException e) { // Se colocar STRING, aparece esta msg.
                Console.WriteLine("Error in format: " + e.Message);
            }
            catch (DomainException e) { // Excepetion personalizada.
                Console.WriteLine("Error in reservation: " + e.Message);
            }
            catch (Exception e) { // Exception mais genérica e casa com qualquer tipo
                Console.WriteLine("Unexpected error: " + e.Message);
            }
        }
    }
}
