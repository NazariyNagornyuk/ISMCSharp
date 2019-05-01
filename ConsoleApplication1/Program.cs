using System;
using System.Collections.Generic;
using System.Text;
using OOPLib1;

namespace ConsoleApplication1
{
    class Program
    {
        // считывает из клавиатуры массив и возвращает его
        static Airplane ReadAiplaneArray()
        {
            Console.WriteLine("Сколько элементов?");
            int n = Convert.ToInt32(Console.ReadLine());
            Airplane[] array = new Airplane[n];
            for (int i=0; i<n; i++)
            {
                Console.WriteLine("Введите город отправки");
                string myStart=Convert.ToString(Console.ReadLine());
                array[i].SetStartCity(myStart);
                Console.WriteLine("Введите город прибытия");
                string myFinish = Convert.ToString(Console.ReadLine());
                array[i].SetFinishCity(myFinish);

                Console.WriteLine("Введите час отправки");
                int myStartHour = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите минуты отправки");
                int myStartMin = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите число отправки");
                int myStartDay = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите месяц отправки");
                int myStartMonth = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите год отправки");
                int myStartYear = Convert.ToInt32(Console.ReadLine());
                
                Date myStartDate=new Date(myStartHour, myStartMin, myStartDay, myStartMonth, myStartYear);
                array[i].SetStartDate(myStartDate);

                Console.WriteLine("Введите час прибытия");
                int myEndHour = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите минуты прибытия");
                int myEndMin = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите число прибытия");
                int myEndDay = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите месяц прибытия");
                int myEndMonth = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите год прибытия");
                int myEndYear = Convert.ToInt32(Console.ReadLine());

                Date myEndDate = new Date(myEndHour, myEndMin, myEndDay, myEndMonth, myEndYear);
                array[i].SetFinishDate(myEndDate);

            }
            return array[n];
        }
        // принимает объект и выводит его
        static void PrintAirplane(Airplane obj)
        {
            string start=obj.GetStartCity();
            string finish=obj.GetFinishCity();
            Date printdate_start=obj.GetStartDate();
            Date printdate_fin=obj.GetFinishDate();
            int start_h=printdate_start.GetHours();
            int finish_h=printdate_fin.GetHours();
            int start_m=printdate_start.GetMinutes();
            int finish_m=printdate_fin.GetMinutes();
            int start_d=printdate_start.GetDay();
            int finish_d=printdate_fin.GetDay();
            int start_mo=printdate_start.GetMonth();
            int finish_mo=printdate_fin.GetMonth();
            int start_y=printdate_start.GetYear();
            int finish_y=printdate_fin.GetYear();
            Console.WriteLine("Полёт из " +start+" до "+finish );
            Console.WriteLine("Время отправки: " + start_h + " час. " + start_m + " мин. ");
            Console.WriteLine("Дата отправки: " + start_d + "." + start_mo + "." + start_y);
            Console.WriteLine("Время прибытия: " + finish_h + " час. " + finish_m + " мин. ");
            Console.WriteLine("Дата прибытия: "+finish_d+"."+finish_mo+"."+finish_y);

        }
        // принимает массив и выводит его
        static void PrintAirplanes( Airplane[] array )
        {
            for (int i=0; i<array.Length; i++)
            {
                string start = array[i].GetStartCity();
                string finish = array[i].GetFinishCity();
                Date printdate_start = array[i].GetStartDate();
                Date printdate_fin = array[i].GetFinishDate();
                int start_h = printdate_start.GetHours();
                int finish_h = printdate_fin.GetHours();
                int start_m = printdate_start.GetMinutes();
                int finish_m = printdate_fin.GetMinutes();
                int start_d = printdate_start.GetDay();
                int finish_d = printdate_fin.GetDay();
                int start_mo = printdate_start.GetMonth();
                int finish_mo = printdate_fin.GetMonth();
                int start_y = printdate_start.GetYear();
                int finish_y = printdate_fin.GetYear();
                Console.WriteLine("Полёт из " + start + " до " + finish);
                Console.WriteLine("Время отправки: " + start_h + " час. " + start_m + " мин. ");
                Console.WriteLine("Дата отправки: " + start_d + "." + start_mo + "." + start_y);
                Console.WriteLine("Время прибытия: " + finish_h + " час. " + finish_m + " мин. ");
                Console.WriteLine("Дата прибытия: " + finish_d + "." + finish_mo + "." + finish_y);
                Console.WriteLine(" * * * * * ");
            }
        }
        
            static void GetAirplaneInfo(Airplane[] array, out int MinTime, out int MaxTime)
            {
                int[] TimeOfFlights = new int[array.Length];
                for (int i=0; i<array.Length;i++)
                {
                    TimeOfFlights[i] = array[i].GetTotalTime();
                }
                int max_time_of_journey = int.MinValue;
                int min_time_of_journey = int.MaxValue;
                for (int i=0; i<TimeOfFlights.Length; i++)
                {
                    if (TimeOfFlights[i]<min_time_of_journey)
                    {
                        min_time_of_journey = TimeOfFlights[i];
                    }
                }
                for (int i=0; i<TimeOfFlights.Length; i++)
                {
                    if (TimeOfFlights[i]>max_time_of_journey)
                    {
                        max_time_of_journey = TimeOfFlights[i];
                    }
                }
                MinTime = min_time_of_journey;
                MaxTime = max_time_of_journey;
            }
        
        static void SortAirplanesByDate()
            {
                
            }

        static void SortAirplanesByTotalTime(Airplane[] array)
        {
            
        }
        static void Main(string[] args)
        {
        }
    }
}
