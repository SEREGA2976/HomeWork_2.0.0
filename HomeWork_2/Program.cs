using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_2
{
    /// <summary>
    ///    Студент курса Разработчик С#: Мазеев Сергей 30.04.2019
    /// </summary>
    /// 
    class Program
    {
       
        static void Main(string[] args)
        {
            const double fixpayment = 50000;
            const double timepayment = 350;
         
            const string pathFixEmployeeDB = @"EmployeeDataBase\test.txt";
            const string pathTimeEmployeeDB = @"EmployeeDataBase\TimeEmpoyeeDataBase.txt";
            EmployeeFixPayment fixEmloyee = new EmployeeFixPayment();
            EmployeeTimePayment timeEmployee = new EmployeeTimePayment();

            Console.WriteLine($"Среднемесячная фиксированная заработная плата = {fixEmloyee.Pay(fixpayment)}");
            Console.WriteLine($"Среднемесячная повременная заработная плата = {timeEmployee.Pay(timepayment)}\n");

            fixEmloyee.ReadEmployeeDB(pathFixEmployeeDB);
            fixEmloyee.ToDisplay();

            timeEmployee.ReadEmployeeDB(pathTimeEmployeeDB);
            timeEmployee.ToDisplay();

            //1.с *Реализовать интерфейсы для возможности сортировки массива используя Array.Sort(). 
           
            
            {
                ArrayList arrayEmployee = new ArrayList();

                for (int i = 0; i < timeEmployee.strarr.Count; i++)
                {
                    ArrayEmployee ae = new ArrayEmployee();
                    ae.Tostrtemp = timeEmployee.strarr[i].ToString();
                    arrayEmployee.Add(ae);
                }

                Console.WriteLine("1.c) Реализация сортировки");
                arrayEmployee.Sort();

                foreach (ArrayEmployee t in arrayEmployee)
                {
                    Console.WriteLine("\t" + t.Tostrtemp);
                }
            }
            
            Console.ReadKey();
        }
    }
}
