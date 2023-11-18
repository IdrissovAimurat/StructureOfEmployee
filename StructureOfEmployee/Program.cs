using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructureOfEmployee
{
    /// <summary>
    ///1.	Создать структуру «Employee» состоящую из:
    ///     a.поля name строкового типа;
    ///     b.поля vacancy типа Vacancies;
    ///     c.поля дата приема на работу типа int[3].
    ///     d.поля зарплата целого типа;
    /// </summary>
    
    public struct Employee
    {
        public string Name;
        public Vacancies Vacancy;
        public int[] DateOfHire; //int[3]? Типа массив из 3 чисел: День, Месяц и Год? 
        public int Salary;
    }
    
    public enum Vacancies
    {
        Fuhrer,
        Soldier,
        Cancellarius,
        Adviser,
        //ну и другие...
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
