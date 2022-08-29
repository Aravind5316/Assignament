using System;
using System.IO;
namespace Assignament1
{
    class Patient
    {
        static int patNo = 1000;

        public Patient()
        {
            PatID = ++patNo;
        }

        public Patient(int id)
        {
            PatID = id;
        }
        public int PatID { get; set; }
        public string PatName { get; set; }
        public long PatNum { get; set; }
        public int PatBill { get; set; }
        public override string ToString()
        {
            return $"{PatName} with ID {PatID} has to pay Rs.{PatBill}. His number is {PatNum}";
        }
    }
    class q13
    {
        const string fileName = "PatientDetails.txt";
        static void writeToFile(Patient pat)
        {
            FileStream pt = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter writer = new StreamWriter(pt);
            writer.WriteLine($"{pat.PatID},{pat.PatName},{pat.PatBill},{pat.PatNum}");
            writer.Close();
            pt.Close();
        }

        static Patient readFromFile()
        {
            FileStream pt = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(pt);
            string data = reader.ReadLine();
            string[] details = data.Split(',');
            Patient pat = new Patient(int.Parse(details[0]));
            pat.PatName = details[1];
            pat.PatID = int.Parse(details[2]);
            pat.PatNum = long.Parse(details[3]);
            pt.Close();
            return pat;
        }
        static void Main(string[] args)
        {
            writeToFile(new Patient { PatID = 1100, PatName = "abc", PatNum = 7981234567, PatBill = 1000 });
            Console.WriteLine(readFromFile());
        }
    }
}