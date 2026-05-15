using System;
using Hotel.Entities.Exceptions;

namespace Hotel.Entities
{
    internal class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime CheckIn  { get; set; }
        public DateTime CheckOut { get; set; }

        // Contrutor

        public Reservation() { }

        public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
        {
            if (checkOut <= checkIn)
            {
                throw new DomainException("As datas de check-out terão que ser depois da data de check-in");
            }

            RoomNumber = roomNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        // Metodo
        public int Duration()
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn);
            return (int)duration.TotalDays;

        }

        public void UpdateDates(DateTime checkIn, DateTime checkOut)
        {
            DateTime now = DateTime.Now;
            if (checkIn < now || checkOut < now)
            {
                throw new DomainException ("As datas da reserva terão que ser datas futuras");
            }
            if (checkOut <= checkIn)
            {
                throw new DomainException("As datas de check-out terão que ser depois da data de check-in");
            }

            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public override string ToString()
        {
            return "Room: " + RoomNumber +
                    ", check-in: " + CheckIn.ToString("dd/MM/yyyy") +
                    ", check-out: " + CheckOut.ToString("dd/MM/yyyy") +
                    ", " + Duration() +
                    " nights";
        }
    }
}
