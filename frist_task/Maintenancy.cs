namespace frist_task
{
    class Maintenancy :Employee
    {
        protected decimal hardShipAllawancy = 100m;

        public Maintenancy(int id, string? name, decimal loggedHours, decimal wage) : base(id, name, loggedHours, wage)
        {
            
        }

        protected override decimal MonthlySalary()
        {
            return base.MonthlySalary() + hardShipAllawancy;
        }
        public override string ToString()

        {
            return 
                base.ToString() +
                $"\nHard ship: {hardShipAllawancy}"+
                   $"\nNet Salary:{this.MonthlySalary()}"; 
        }
    }

}

