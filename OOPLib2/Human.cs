using System;
using System.Collections.Generic;
using System.Text;

namespace OOPLib2
{
    public class Human
    {
        protected string name;
        protected string surname;
        protected int BirthDay;
        protected int BirthMonth;
        protected int BirthYear;
        public void SetName(string InputName)
        {
            name = InputName;
        }
        public string GetName()
        {
            return name;
        }
        public void SetSurname(string InputSurname)
        {
            surname = InputSurname;
        }
        public string GetSurname()
        {
            return surname;
        }
        public void SetBirthDay(int InputDay)
        {
            BirthDay = InputDay;
        }
        public int GetBirthDay()
        {
            return BirthDay;
        }
        public void SetBirthMonth(int InputMonth)
        {
            BirthMonth = InputMonth;
        }
        public int GetBirthMonth()
        {
            return BirthMonth;
        }
        public void SetBirthYear(int InputYear)
        {
            BirthYear = InputYear;
        }
        public int GetBirthYear()
        {
            return BirthYear;
        }
        public Human()
        {
            name = "Nazariy";
            surname = "Nagornyuk";
            BirthDay = 20;
            BirthMonth = 12;
            BirthYear = 2000;
        }
        public Human(string InputName, string InputSurname)
        {
            name = InputName;
            surname = InputSurname;
            BirthDay = 01;
            BirthMonth = 09;
            BirthYear = 2002;
        }
        public Human(string InputName, string InputSurname, int InputDay, int InputMonth, int InputYear)
        {
            name = InputName;
            surname = InputSurname;

            if (InputMonth>0&InputMonth<=12)
            {
                BirthMonth = InputMonth;
            }
            
            if(BirthMonth==1|BirthMonth==3|BirthMonth==5|BirthMonth==7|BirthMonth==8|BirthMonth==10|BirthMonth==12)
            {
                if (InputDay > 0 & InputDay <= 31)
                {
                    BirthDay = InputDay;
                }
            }
            else if (BirthMonth==4|BirthMonth==6|BirthMonth==9|BirthMonth==11)
            {
                if (InputDay>0&InputDay<=30)
                {
                    BirthDay = InputDay;
                }
            }
            else if (BirthMonth==2)
            {
                if(InputDay>0&InputDay<=29)
                {
                    BirthDay = InputDay;
                }
            }
            
            BirthYear = InputYear;
        }
        public Human(Human InputObject)
        {
            name = InputObject.name;
            surname = InputObject.surname;
            BirthDay = InputObject.BirthDay;
            BirthMonth = InputObject.BirthMonth;
            BirthYear = InputObject.BirthYear;
        }
        public virtual void ShowInfo()
        {
            Console.WriteLine("Ім'я: " + name+" Призвіще: "+surname);
            Console.WriteLine("Дата народження: " + BirthDay + "." + BirthMonth + "." + BirthYear);
        }
    }
}
