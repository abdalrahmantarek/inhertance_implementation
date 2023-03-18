using System.Security.AccessControl;
using System.Xml.Linq;

namespace frist_task
{
    class Employee
    {

        protected readonly decimal overTimeRate=1.25m;
        protected  decimal overTimeHours;
        protected const decimal minHours = 176m;

        public Employee(int id, string? name, decimal loggedHours, decimal wage)
        {
            this.Id = id;
            this.Name = name;
            this.LoggedHours = loggedHours;
            this.Wage = wage;
        }

        protected int Id { get; set; }
        protected string? Name { get; set; }
        protected decimal LoggedHours { get; set; }
        protected decimal Wage { get; set; }
       
        protected virtual decimal BasicSalary() 
        {

            return minHours * Wage  ;
        }
        protected virtual decimal OverTime()
        {
            overTimeHours = (LoggedHours - minHours);
            var overTimeTotalPrice = overTimeHours *Wage * overTimeRate;
            return overTimeHours > 0 ? overTimeTotalPrice : 0 ;
        }
        protected virtual decimal MonthlySalary() 
        {
            return BasicSalary () +OverTime() ;
        }
        public override string ToString()
        {
            return $"{GetType ().ToString().Replace("frist_task.","")}"+
                   $"\nid:{Id}" +
                   $"\nname:{Name}" +
                   $"\nloged hours:{LoggedHours}" +
                   $"\nWage:{Wage}" +
                   $"\nover Time:{Math.Round( OverTime(),2)}" +
                   $"\nBasic salary:{Math.Round( BasicSalary(),2)}";
        }
        

    }

}

