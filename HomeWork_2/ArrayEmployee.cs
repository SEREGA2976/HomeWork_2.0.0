using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace HomeWork_2
{
    /// <summary>
    ///     <para>Массив сотрудников наследуется от абстрактного базового класса AbstractArrayEmployee</para>
    /// </summary>
    internal class ArrayEmployee : AbstractArrayEmployee, IComparable
    {
        public string strtemp;
        /// <summary>
        ///     1.б) Создать на базе абстрактного класса массив сотрудников и заполнить его
        ///     4. Вызов исключения при отсутствующем файле
        /// </summary>
        /// <param name="pathEmployeeDataBase">Путь к БД сотрудников</param>
        override public void ReadEmployeeDB(string pathEmployeeDataBase)
        {
            try
            {
                if (!File.Exists(pathEmployeeDataBase))
                    throw new FileNotFoundException("\t4. Вызов исключения: Файл не найден " + pathEmployeeDataBase + "\n");

                using (StreamReader str = new StreamReader(pathEmployeeDataBase))
                    while (!str.EndOfStream)
                        strarr.Add(str.ReadLine());

            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        ///     1.г) **Создать класс содержащий массив сотрудников. Вывод на экран.
        ///     <para>Реализовать возможность вывода данных с использованием foreach</para> 
        /// </summary>
        /// 
        public void ToDisplay()
        {
            if (strarr != null)
            {
                foreach (var str in strarr)
                    Console.WriteLine("\t" + str);

                Console.WriteLine("\n");
            }
        }

        //1.c) *Реализовать интерфейсы для возможности сортировки массива используя Array.Sort(). 
      
                      
        public string Tostrtemp
        {
            get { return strtemp; }

            set { strtemp = value; }
        }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            ArrayEmployee strarr = obj as ArrayEmployee;
            if (strarr != null)
                return this.strtemp.CompareTo(strarr.strtemp);
            else
                throw new ArgumentException("Object is not a ArrayEmployee");
        }
        
    }
}