namespace frist_task
{
    class Sales : Employee
    {
        public Sales(int id, string? name, decimal loggedHours, decimal wage,decimal commission,decimal salesAmount) : base(id, name, loggedHours, wage)
        {
            this.Commission = commission;
            this.SalesAmout = salesAmount;
        }

        private decimal Commission { get; set;}
        public decimal SalesAmout { get; set; }

       
        protected decimal SalesCommission() 
        {
            return  SalesAmout * Commission;
        } 
        protected override decimal MonthlySalary()
        {
            return base.MonthlySalary() +SalesCommission();
        }
        public override string ToString()
        {
            return
                base.ToString() +
                $"\nsales Commssion {Math.Round(SalesCommission(), 2)}:N0" +
                $"\nTotal Salary {Math.Round(this.MonthlySalary(),2)}:N0";
        }

    }

}

