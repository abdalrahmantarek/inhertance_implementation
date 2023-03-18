namespace frist_task
{
    class Devoloper : Employee 
    {
        public Devoloper(int id, string? name, decimal loggedHours, decimal wage, decimal bounosPercentage, bool tasksCompeleted) : base(id, name, loggedHours, wage)
        {
            this.BounosPercentage = bounosPercentage;
            this.TasksCompeleted = tasksCompeleted;
        }

        

        protected decimal BounosPercentage { set; get; }
        protected bool TasksCompeleted { set; get; }
        private decimal CalculateBounos() 
        {
            return BasicSalary() * BounosPercentage; 
        }
        protected decimal AddBounos()
        {
            if (TasksCompeleted)
            {
                return ( this.CalculateBounos());
            } 
            else
            {
                return (0);
            }

        }
        protected override decimal MonthlySalary()
        {
            return base.MonthlySalary() + this.AddBounos() ;
        }
        public override string ToString()

        {
            return
                base.ToString() +
                $"\nTask compeleted: {TasksCompeleted} yes:no" +
                   $"\nNet Salary:{Math.Round( this.MonthlySalary(),2)}:N0";
        }
    }

}

