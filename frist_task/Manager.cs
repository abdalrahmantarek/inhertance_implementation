namespace frist_task
{
    class Manager : Employee  
    {
        protected readonly decimal allowncy = 0.05m;

        public Manager(int id, string? name, decimal loggedHours, decimal wage) : base(id, name, loggedHours, wage)
        {
        }

        private decimal Allowncy()
        {
           return base.MonthlySalary() * allowncy;
        } 
        protected override decimal MonthlySalary()
        {

            return Allowncy() + base.MonthlySalary();
        }
        public override string ToString()
        {
            
            return base.ToString() +
                $"\nAllowncy {Math.Round(this.Allowncy(),2)}"
                +$"\nNet Salary {Math.Round(this.MonthlySalary(),2)}";

        }
    } 
    
   
}

