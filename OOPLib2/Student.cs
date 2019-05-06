using System;
using System.Collections.Generic;
using System.Text;

namespace OOPLib2
{
    public class Student:Human
    {
        protected int Course;
        protected string Group;
        protected string Faculty;
        protected string VNZname;

        public void SetCourse(int InputCourse)
        {
            Course = InputCourse;
        }
        public int GetCourse()
        {
            return Course;
        }
        public void SetGroup(string InputGroup)
        {
            Group = InputGroup;
        }
        public string GetGroup()
        {
            return Group;
        }
        public void SetFaculty(string InputFaculty)
        {
            Faculty = InputFaculty;
        }
        public string GetFaculty()
        {
            return Faculty;
        }
        public void SetVNZname(string InputVNZ)
        {
            VNZname = InputVNZ;
        }
        public string GetVNZname()
        {
            return VNZname;
        }
        public Student()
        {
            name = "Nazariy";
            surname = "Nagornyuk";
            BirthDay = 20;
            BirthMonth = 12;
            BirthYear = 2000;
            Course = 4;
            Group = "P-43";
            Faculty = "I don't know what does it mean";
            VNZname = "MOD";
        }
        public Student(string InputName, string InputSurname, int InputDay, int InputMonth, int InputYear):base(InputName,InputSurname,InputDay,InputMonth,InputYear)
        {
            Course = 4;
            Group = "P-43";
            Faculty = "I don't know what does it mean";
            VNZname = "MOD";
        }
        public Student(string InputName, string InputSurname, int InputDay, int InputMonth, int InputYear, int InputCourse, string InputGroup, string InputFaculty, string InputVNZname):base(InputName,InputSurname,InputDay,InputMonth,InputYear)
        {
            Course = InputCourse;
            Group = InputGroup;
            Faculty = InputFaculty;
            VNZname = InputVNZname;
        }
        public Student(Student InputObject):base(InputObject)
        {
            Course = InputObject.Course;
            Group = InputObject.Group;
            Faculty = InputObject.Faculty;
            VNZname = InputObject.VNZname;
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Курс: " + Course + " група: " + Group);
            Console.WriteLine("Факультет: "+Faculty+" назва закладу: "+VNZname);
        }
        }
}
