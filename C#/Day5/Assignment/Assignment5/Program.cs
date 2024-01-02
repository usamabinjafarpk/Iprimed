using System;
using System.Runtime.ConstrainedExecution;

namespace Assignment_5
{

    interface GovtRules
    {

        public double EmployeePF(double basicSalary);
        public string LeaVeDetails();
        public double gratuityAmount(float serviceCompleted, double basicSalary);



    }
    class TCS : GovtRules
    {
        protected int empid;
        protected string name;
        protected string dept;
        protected string desg;
        protected double basicSalary;
        protected double pf, empContriPF, pension;
        public TCS(int empid, string name, string dept, string desg, double basicSalary)
        {
            this.empid = empid;
            this.name = name;
            this.dept = dept;
            this.desg = desg;
            this.basicSalary = basicSalary;
        }

        public double EmployeePF(double basicSalary)
        {
            pf = (basicSalary / 12) * 100;
            empContriPF = (basicSalary / 8.33) * 100;
            pension = (basicSalary / 3.67) * 100;
            return basicSalary;


        }

        public double gratuityAmount(float serviceCompleted, double basicSalary)
        {
            if (serviceCompleted > 10)
            {
                return 2 * basicSalary;
            }
            else if (serviceCompleted > 20)
            {
                return 3 * basicSalary;
            }
            else if (serviceCompleted < 5)
            {
                return 0;

            }
            return 0;

        }

        public string LeaVeDetails()
        {
            return "1 day of Casual Leave per month\n12 days of Sick Leave per year\n" +
                "10 days of Previlage Leave per year";
        }
        public int Empid
        {
            get
            {
                return empid;
            }
        }
        public string Name
        {
            get { return name; }
        }
        public string Dept
        {
            get { return dept; }
        }

        public double Pf
        {
            get { return pf; }
        }
        public double Empontripf
        {
            get { return empContriPF; }
        }
        public double Pension
        {
            get { return pension; }
        }
        public string Desg
        {
            get
            {
                return desg;
            }
        }
        public double Basicsalary
        {
            get { return basicSalary; }
        }




    }

    class Accenture : GovtRules
    {
        protected int empid;
        protected string name;
        protected string dept;
        protected string desg;
        protected double basicSalary;
        protected double pf, empContriPF, pension;


        public Accenture(int empid, string name, string dept, string desg, double basicSalary)
        {
            this.empid = empid;
            this.name = name;
            this.dept = dept;
            this.desg = desg;
            this.basicSalary = basicSalary;
        }
        public double EmployeePF(double basicSalary)
        {
            pf = (basicSalary / 12) * 100;
            empContriPF = (basicSalary / 8.33) * 100;
            pension = (basicSalary / 3.67) * 100;
            return basicSalary;
        }

        public double gratuityAmount(float serviceCompleted, double basicSalary)
        {
            return 0;
        }

        public string LeaVeDetails()
        {
            return "2 day of Casual Leave per month/n5 days of Sick Leave per year/n5 days of Previlage Leave per year";
        }
        public int Empid
        {
            get
            {
                return empid;
            }
        }
        public string Name
        {
            get { return name; }
        }
        public string Dept
        {
            get { return dept; }
        }

        public double Pf
        {
            get { return pf; }
        }



    }

    internal class Program
    {

        static void Main(string[] args)
        {
            TCS obj = new TCS(12, "Usama", "software", "engineer", 360000);
            obj.EmployeePF(obj.Basicsalary);
            Console.WriteLine("TCS Employee Details");
            Console.WriteLine($"NAME:{obj.Name}\nDEPARMENT:{obj.Dept}\nDESIGNATION:{obj.Desg}\nBASIC SALART{obj.Basicsalary}\n" +
                $"PF:{obj.Pf}\nPENSION:{obj.Pension}\nPF as employer contribution:{obj.Empontripf}");
            Console.WriteLine(obj.LeaVeDetails());

            Accenture obj1 = new Accenture(12, "Usama", "software", "engineer", 360000);
            obj.EmployeePF(obj.Basicsalary);
            Console.WriteLine("Accenture Employee Details");
            Console.WriteLine($"NAME:{obj.Name}\nDEPARMENT:{obj.Dept}\nDESIGNATION:{obj.Desg}\nBASIC SALART{obj.Basicsalary}\n" +
                $"PF:{obj.Pf}\nPENSION:{obj.Pension}\nPF as employer contribution:{obj.Empontripf}");
            Console.WriteLine(obj.LeaVeDetails());


        }
    }
}

