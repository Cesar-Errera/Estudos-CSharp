using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hotel.Entities;
using Hotel.Entities.Exceptions;

namespace Hotel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Room Number: ");
                int roomNumber = int.Parse(Console.ReadLine());

                Console.Write("Check - in date (dd/MM/yyyy): ");
                DateTime checkIn = DateTime.Parse(Console.ReadLine());

                Console.Write("Check - out date (dd/MM/yyyy): ");
                DateTime checkOut = DateTime.Parse(Console.ReadLine());

                Reservation reservation = new Reservation(roomNumber, checkIn, checkOut);
                Console.WriteLine("Reservation" + reservation);

                Console.WriteLine();
                Console.WriteLine("Entre com os dados para atualizar a reserva: ");

                Console.Write("Check - in date (dd/MM/yyyy): ");
                checkIn = DateTime.Parse(Console.ReadLine());

                Console.Write("Check - out date (dd/MM/yyyy): ");
                checkOut = DateTime.Parse(Console.ReadLine());

                reservation.UpdateDates(checkIn, checkOut);
                Console.WriteLine("Reservation: " + reservation);
            }
            catch (DomainException e)
            {
                Console.WriteLine("Erro na reserva: "+ e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Erro de formato: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro inexperado: " + e.Message);
            }
        }
    }
}
