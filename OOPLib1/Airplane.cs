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
        public int GetTotalTime()
        {
            int Hours2=FinishDate.GetHours();
            int Hours1=StartDate.GetHours();
            int Min2=FinishDate.GetMinutes();
            int Min1=StartDate.GetMinutes();
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
    
}
