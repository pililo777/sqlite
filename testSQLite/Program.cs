using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLiteWithEF
{
    class Program
    {
        static void Main(string[] args)
        {
            DatabaseContext context = new DatabaseContext();
            //Console.WriteLine("Enter Employee name");
            //string name = Console.ReadLine();
            //Console.WriteLine("Enter Salary");
            //double salary = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Enter Designation");
            //string designation = Console.ReadLine();
            //EmployeeMaster employee = new EmployeeMaster()
            //{
            //    EmpName = name,
            //    Designation = designation,
            //    Salary = salary
            //};
            //context.EmployeeMaster.Add(employee);
            //context.SaveChanges();
            DateTime mifecha;

            var data = context.EmployeeMaster.ToList();
            foreach (var item in data)
            {
                Console.Write(string.Format("ID : {0}  Name : {1}  Salary : {2}   Designation : {3}  Fecha : {4}   {5}", item.ID, item.EmpName, item.Salary, item.Designation, item.fecha, Environment.NewLine));
                item.Salary += 100;
                mifecha = Convert.ToDateTime( item.fecha) ;
                Console.WriteLine("Mi fecha: " + mifecha.TimeOfDay);



                //item.fecha =   DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            }

            context.SaveChanges();

            Console.ReadKey();
        }
    }
}

