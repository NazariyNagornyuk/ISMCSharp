using System;
using System.Collections.Generic;
using System.Text;

namespace OOPLib2
{
    public class Reader:Human
    {
        protected int ReadersTicketNumber;
        protected int TicketDay;
        protected int TicketMonth;
        protected int TicketYear;
        protected double Payment;

        public Reader()
        {
            name="Nazariy";
            surname="Nagornyuk";
            BirthDay=20;
            BirthMonth=12;
            BirthYear=2000;
            ReadersTicketNumber=1488;
            TicketDay=06;
            TicketMonth=05;
            TicketYear=2019;
            Payment=3.62;
        }
        public Reader(string YourName, string YourSurname, int YourBD, int YourBM, int YourBY):base(YourName,YourSurname,YourBD,YourBM,YourBY)
        {
            ReadersTicketNumber=1337;
            TicketDay=07;
            TicketMonth=05;
            TicketYear=2019;
            Payment=17.15;
        }
        public Reader(string YourName, string YourSurname, int YourBD, int YourBM, int YourBY, int YourNum, int YourTicketD, int YourTicketM, int YourTicketY, double YourMoney):base(YourName,YourSurname,YourBD,YourBM,YourBY)
        {
            ReadersTicketNumber=YourNum;
            TicketDay=YourTicketD;
            TicketMonth=YourTicketM;
            TicketYear=YourTicketY;
            Payment=YourMoney;
        }
        public void SetReadersTicketNumber(int YourNumber)
        {
            ReadersTicketNumber = YourNumber;
        }
        public int GetReadersTicketNumber()
        {
            return ReadersTicketNumber;
        }
        public void SetTicketDate(int YourDay, int YourMonth, int YourYear)
        {
            TicketDay = YourDay;
            TicketMonth = YourMonth;
            TicketYear = YourYear;
        }
        public int GetTicketDay()
        {
            return TicketDay;
        }
        public int GetTicketMonth()
        {
            return TicketMonth;
        }
        public int GetTicketYear()
        {
            return TicketYear;
        }
        public void SetPayment(double YourPayment)
        {
            Payment = YourPayment;
        }
        public double GetPayment()
        {
            return Payment;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Читацький квиток № " + ReadersTicketNumber + " , видано " + TicketDay + "." + TicketMonth + "." + TicketYear + ", сума внеску " + Payment + " грн.");
        }
    }
}
