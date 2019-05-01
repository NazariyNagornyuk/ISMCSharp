using System;
using System.Collections.Generic;
using System.Text;

namespace OOPLib1
{
    public class Airplane
    {
        protected string StartCity;
        protected string FinishCity;
        protected Date StartDate;
        protected Date FinishDate;
        //методы Set и Get
        public void SetStartCity(string InputStartCity)
        {
            StartCity = InputStartCity;
        }
        public string GetStartCity()
        {
            return StartCity;
        }
        public void SetFinishCity(string InputFinishCity)
        {
            FinishCity = InputFinishCity;
        }
        public string GetFinishCity ()
        {
            return FinishCity;
        }
        public void SetStartDate(Date InputDate)
        {
            StartDate = InputDate;
        }
        public Date GetStartDate()
        {
            return StartDate;
        }
        public void SetFinishDate(Date InputFinishDate)
        {
            FinishDate = InputFinishDate;
        }
        public Date GetFinishDate()
        {
            return FinishDate;
        }
        //конструктор по умолчанию
        public Airplane()
        {
            StartCity = "Zhytomyr";
            FinishCity = "Lviv";
            StartDate = new Date();
            FinishDate = new Date();
        }
        //1 конструктор с параметрами
        public Airplane(string InputStartCity, string InputFinishCity)
        {
            StartCity = InputStartCity;
            FinishCity = InputFinishCity;
        }
        //2 конструктор с параметрами
        public Airplane(string InputStartCity, string InputFinishCity, Date InputStartDate, Date InputFinishDate)
        {
            StartCity = InputStartCity;
            FinishCity = InputFinishCity;
            StartDate = InputStartDate;
            FinishDate = InputFinishDate;
        }
        //конструктор копирования
        public Airplane(Airplane obj)
        {
            StartCity = obj.StartCity;
            FinishCity = obj.FinishCity;
            StartDate=new Date(obj.StartDate);
            FinishDate = new Date(obj.FinishDate);
        }
        // метод расчёта времени полёта в минутах
        public int GetTotalTime(Airplane obj)
        {
            int Hours2=obj.FinishDate.GetHours();
            int Hours1=obj.StartDate.GetHours();
            int Min2=obj.FinishDate.GetMinutes();
            int Min1=obj.StartDate.GetMinutes();
            int TimeInMinutes = ((Hours2 - Hours1) * 60) + (Min2 - Min1);
            return TimeInMinutes;
        }
        // метод сравнения дня прибытия
        public bool IsArrivingToday(Airplane obj)
        {
            int Day1 = obj.StartDate.GetDay();
            int Day2 = obj.FinishDate.GetDay();
            if (Day1==Day2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    public class Date 
    {
        protected int Year;
        protected int Month;
        protected int Day;
        protected int Hours;
        protected int Minutes;
        // методы Set и Get
        public void SetYear(int inputyear) 
        {
            if (inputyear>0)
            { 
                Year = inputyear;
            }
            
        }
        public int GetYear()
        {
            return Year;
        }
        public void SetMonth (int inputmonth)
        {
            if(inputmonth>0 && inputmonth<=12)
            {
                Month = inputmonth;
            }
        }
        public int GetMonth ()
        {
            return Month;
        }
        public void SetDay (int inputday)
        {
            if (Month==2)
            {
                if(inputday>0&&inputday<=29)
                {
                    Day = inputday;
                }
            }
            else if (Month==1|Month==3|Month==5|Month==7|Month==8|Month==10|Month==12)
            {
                if(inputday>0&&inputday<=31)
                {
                    Day=inputday;
                }
            }
            else if (Month==4|Month==6|Month==9|Month==11)
            {
                if(inputday>0&&inputday<=30)
                {
                    Day = inputday;
                }
            }
        }
        public int GetDay()
        {
            return Day;
        }
        public void SetHours (int inputhours)
        {
            if(inputhours>=0&&inputhours<24)
            {
                Hours = inputhours;
            }
        }
        public int GetHours()
        {
            return Hours;
        }
        public void SetMinutes(int inputminutes)
        {
            if(inputminutes>=0&&inputminutes<60)
            {
                Minutes = inputminutes;
            }
        }
        public int GetMinutes()
        {
            return Minutes;
        }
        // пустой конструктор - вставляет данные по умолчанию
        public Date()
        {
            Hours = 17;
            Minutes = 15;
            Day = 02;
            Month = 05;
            Year = 2019;
        }
        //если указать только время, если не указаны минуты - по умолчанию 00 минут - дата по умолчанию
        public Date(Date flight, int Hours, int Minutes=00)
        {
            Hours = flight.Hours;
            Minutes = flight.Minutes;
            Day = 02;
            Month = 05;
            Year = 2019;
        }
        // указываем полную дату
        public Date(Date flight, int Hours, int Minutes, int Day, int Month, int Year)
        {
            Hours=flight.Hours;
            Minutes = flight.Minutes;
            Day = flight.Day;
            Month = flight.Month;
            Year = flight.Year;
        }
        //конструктор копирования даты
        public Date (Date obj)
        {
            Hours = obj.Hours;
            Minutes = obj.Minutes;
            Day = obj.Day;
            Month = obj.Month;
            Year = obj.Year;
        }
    }
}
