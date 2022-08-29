using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
namespace Assignament1
{
    class util
    {
        public static int Getnumber(string question)
        {
            Console.WriteLine(question);
            return int.Parse(Console.ReadLine());
        }
        public static double Getdouble(string question)
        {
            Console.WriteLine(question);
            return int.Parse(Console.ReadLine());
        }
        public static string Getstring(string question)
        {
            Console.WriteLine(question);
            return Console.ReadLine();
        }
    }
    public class q15
    {
        [Serializable]
        public class Employee
        {
            static int empNo = 1000;
            public Employee()
            {
                EmpID = ++empNo;
            }
            public Employee(int id)
            {
                EmpID = id;
            }
            public int EmpID { get; set; }
            public string EmpName { get; set; }
            public string EmpAddress { get; set; }
            public int Empsalary { get; set; }
            public override string ToString()
            {
                return $"{EmpID},{EmpName},{EmpAddress},{Empsalary}";
            }
        }
        static void saveAsXml(List<Employee>empList)
        {
            var fs = new FileStream("Data.xml", FileMode.OpenOrCreate, FileAccess.Write);
            var formatter = new XmlSerializer(typeof(List<Employee>));
            formatter.Serialize(fs, empList);
            fs.Close();
        }
        static List<Employee>loadXmlData()
        {
            var fs = new FileStream("Data.xml", FileMode.Open, FileAccess.Read);
            var formatter = new XmlSerializer(typeof(List<Employee>));
            var list=formatter.Deserialize(fs) as List<Employee>;
            fs.Close();
            return list;
        }
        static Employee createEmployee()
        {
            var id = util.Getnumber("Enter the ID of the Employee");
            var name = util.Getstring("Enter the name of the Employee");
            var address = util.Getstring("Enter the address of the Employee");
            var salary = util.Getnumber("Enter the salary");
            var emp = new Employee(id)
            {
                EmpName = name,
                EmpAddress = address,
                Empsalary = salary
            };
            return emp;
        }
        static void Main(string[] args)
        {
            List<Employee> empList = new List<Employee>();
            var choice = util.Getnumber("Enter the no of Employee that is added");
            for (int i=0; i < choice;i++)
            {
                empList.Add(createEmployee());
            }
            saveAsXml(empList);
            empList = loadXmlData();
            foreach(var emp in empList)
                Console.WriteLine($"The emp has ID {emp.EmpID} Name={emp.EmpName} Address={emp.EmpAddress} Salary={emp.Empsalary}");
        }
    }
}