using System;
using System.Collections.Generic;
using System.Text;

namespace OOPLib1
{
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
            if (inputyear > 0)
            {
                Year = inputyear;
            }

        }
        public int GetYear()
        {
            return Year;
        }
        public void SetMonth(int inputmonth)
        {
            if (inputmonth > 0 && inputmonth <= 12)
            {
                Month = inputmonth;
            }
        }
        public int GetMonth()
        {
            return Month;
        }
        public void SetDay(int inputday)
        {
            if (Month == 2)
            {
                if (inputday > 0 && inputday <= 29)
                {
                    Day = inputday;
                }
            }
            else if (Month == 1 | Month == 3 | Month == 5 | Month == 7 | Month == 8 | Month == 10 | Month == 12)
            {
                if (inputday > 0 && inputday <= 31)
                {
                    Day = inputday;
                }
            }
            else if (Month == 4 | Month == 6 | Month == 9 | Month == 11)
            {
                if (inputday > 0 && inputday <= 30)
                {
                    Day = inputday;
                }
            }
        }
        public int GetDay()
        {
            return Day;
        }
        public void SetHours(int inputhours)
        {
            if (inputhours >= 0 && inputhours < 24)
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
            if (inputminutes >= 0 && inputminutes < 60)
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
        public Date(int myHours, int myMinutes = 00)
        {
            Hours = myHours;
            Minutes = myMinutes;
            Day = 02;
            Month = 05;
            Year = 2019;
        }
        // указываем полную дату
        public Date(int myHours, int myMinutes = 00, int myDay = 02, int myMonth = 05, int myYear = 2019)
        {
            Hours = myHours;
            Minutes = myMinutes;
            Day = myDay;
            Month = myMonth;
            Year = myYear;
        }
        //конструктор копирования даты
        public Date(Date obj)
        {
            Hours = obj.Hours;
            Minutes = obj.Minutes;
            Day = obj.Day;
            Month = obj.Month;
            Year = obj.Year;
        }
    }
}
