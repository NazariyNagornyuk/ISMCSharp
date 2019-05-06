using System;
using System.Collections.Generic;
using System.Text;

namespace OOPLib2
{
    public class Teacher:Human
    {
        protected string Job;
        protected string Cathedra;
        protected string VNZname;

        public void SetJob(string InputJob)
        {
            Job = InputJob;
        }
        public string GetJob()
        {
            return Job;
        }
        public void SetCathedra(string InputCathedra)
        {
            Cathedra = InputCathedra;
        }
        public string GetCathedra()
        {
            return Cathedra;
        }
        public void SetVNZname(string InputVNZ)
        {
            VNZname = InputVNZ;
        }

        public Teacher()
        {
            name = "Sidor";
            surname = "Sidorov";
            BirthDay=31;
            BirthMonth=12;
            BirthYear=1979;
            Job="laborant";
            Cathedra="IZVP";
            VNZname="Cooperative College";
        }
        public Teacher(string YourName, string YourSurname, int YBirthDay, int YBirthMonth, int YBirthYear):base(YourName,YourSurname,YBirthDay,YBirthMonth,YBirthYear)
        {
            Job = "Practice Supervisor";
            Cathedra = "Pick-Up";
            VNZname = "College of Trade and Economics";
        }
        public Teacher(string YourName, string YourSurname, int YBirthDay, int YBirthMonth, int YBirthYear, string YourJob, string YourKaf, string YourVNZ):base(YourName,YourSurname,YBirthDay,YBirthMonth,YBirthYear)
        {
            Job = YourJob;
            Cathedra = YourKaf;
            VNZname = YourVNZ;
        }
        public Teacher(Teacher YourObject):base(YourObject)
        {
            Job = YourObject.Job;
            Cathedra = YourObject.Cathedra;
            VNZname = YourObject.VNZname;
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Посада: " + Job + " кафедри " + Cathedra + " навчального закладу " + VNZname);
        }

    }
}
