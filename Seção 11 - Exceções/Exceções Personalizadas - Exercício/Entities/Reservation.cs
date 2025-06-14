using System;
using Exceções_Personalizadas___Exercício.Entities.Exceptions;

namespace Exceções_Personalizadas___Exercício.Entities
{
    public class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reservation() { }

        public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
        {
            if (checkOut <= checkIn)
            {
                throw new DomainException("The Check-In date cannot be higher then Check-Out");
            }

            

                RoomNumber = roomNumber;
                CheckIn = checkIn;
                CheckOut = checkOut;
            
        }

        public int Duration()
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn);
            return (int)duration.TotalDays;
        }


        public void UptateDates(DateTime checkin, DateTime checkout)
        {
            DateTime now = DateTime.Now;

            if ( checkin <= now || checkout <= now) 
            {
                throw new DomainException("Reservation must be in future dates "); 
            }

            if (checkout <= checkin)
            {
                throw new DomainException("The Check-In date cannot be higher then Check-Out");
            }

            CheckIn = checkin;
            CheckOut = checkout;

        }

        

        public override string ToString()
        {
            return "Room: " + RoomNumber + " ," + "check-In: " + CheckIn.ToString("dd/MM/yyyy") + ", check-out: " +
                CheckOut.ToString("dd/MM/yyyy") + ", duration: " + Duration() + " nights";
        }


    }
}
