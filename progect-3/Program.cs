// See https://aka.ms/new-console-template for more information
           Employee e = new Employee("Unknown",30000,"Mukalla");
 class Employee
    {
        private string name;
        private string address;
        private int salary;


        public Employee()
        {
            Console.WriteLine("welcome to our company");
        }
        public Employee(string name):this()
        {
          this.name = name;
            Console.WriteLine("your name is " +this. name);
        }
        public Employee(string name,int salary):this(name)
        {
       this.salary = salary;
            Console.WriteLine(" my salary=  " + this.salary);
        }
            public Employee(string name, int salary, string address):this(name,salary)
        {
            
            
            this.address = address;

            Console.WriteLine( "  my address is  " + this.address);

        }
    }