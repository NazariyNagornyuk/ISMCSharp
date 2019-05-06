using System;
using System.Collections.Generic;
using System.Text;

namespace OOPLib2
{
    public class Abitur : Human
    {
        protected int ZNO_ua;
        protected int ZNO_en;
        protected int ZNO_history;
        protected double SchoolGrade;
        protected string SchoolName;
        public Abitur()
        {
            name = "Nazariy";
            surname = "Nagornyuk";
            BirthDay = 20;
            BirthMonth = 12;
            BirthYear = 2000;
            ZNO_ua = 177;
            ZNO_en = 179;
            ZNO_history = 183;
            SchoolGrade = 10.2;
            SchoolName = "Zamozhne";
        }
        public Abitur(string InputName, string InputSurname):base(InputName,InputSurname)
        {
            ZNO_ua = 124;
            ZNO_en = 124;
            ZNO_history = 124;
            SchoolGrade = 4;
            SchoolName = "School Number 9";
        }
        public Abitur (string InputName, string InputSurname, int InputDay, int InputMonth, int InputYear, int InputUA, int InputEN, int InputHist, double InputSchoolGrade, string InputSchoolName):base(InputName,InputSurname,InputDay,InputMonth,InputYear)
        {
            name = InputName;
            surname = InputSurname;
            BirthDay = InputDay;
            BirthMonth = InputMonth;
            BirthYear = InputYear;
            ZNO_ua = InputUA;
            ZNO_en = InputEN;
            ZNO_history = InputHist;
            SchoolGrade = InputSchoolGrade;
            SchoolName = InputSchoolName;
        }
        public Abitur(Abitur InputObject):base(InputObject)
        {
            ZNO_ua = InputObject.ZNO_ua;
            ZNO_en = InputObject.ZNO_en;
            ZNO_history = InputObject.ZNO_history;
            SchoolGrade = InputObject.SchoolGrade;
            SchoolName = InputObject.SchoolName;
        }
        public void SetZnoUa(int InputUA)
        {
            if (InputUA>=100&InputUA<=200)
            ZNO_ua = InputUA;
        }
        public int GetZnoUa()
        {
            return ZNO_ua;
        }
        public void SetZnoEn(int InputEN)
        {
            if (InputEN >= 100 & InputEN <= 200)
                ZNO_en = InputEN;
        }
        public int GetZnoEn()
        {
            return ZNO_en;
        }
        public void SetZnoHistory(int InputHistory)
        {
            if (InputHistory >= 100 & InputHistory <= 200)
                ZNO_history = InputHistory;
        }
        public int GetZnoHistory()
        {
            return ZNO_history;
        }
        public void SetSchoolGrade(double InputGrade)
        {
            if (InputGrade >= 4 & InputGrade <= 12)
                SchoolGrade = InputGrade;
        }
        public double GetSchoolGrade()
        {
            return SchoolGrade;
        }
        public void SetSchoolName(string InputName)
        {
            SchoolName = InputName;
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Українська мова і література: " + ZNO_ua);
            Console.WriteLine("Іноземна мова: " + ZNO_en);
            Console.WriteLine("Історія України: " + ZNO_history);
            Console.WriteLine("Середній бал документа про освіту: " + SchoolGrade);
            Console.WriteLine("Назва загальноосвітнього закладу: " + SchoolName);
        }
    }
}
