namespace NewApp.Models
 {
    public class Employee {
        public string FullName {get;set;}
        public string Address {get; set;}
        public int EmployeeID {get; set;}
        // lekhanhly-2021050423
        //try...catch-Employee
        public void EnterData(){
                System.Console.Write("Full name = ");
                FullName = Console.ReadLine();
                System.Console.Write("Address = ");
                Address = Console.ReadLine();
                
                System.Console.WriteLine("EmployeeID");
                
                try{
                    EmployeeID = Convert.ToInt16(Console.ReadLine());
                } catch(Exception e)
                {
                    EmployeeID = 0;
                }
        }
        public void HienThi()
         {
             System.Console.WriteLine("{0}-{1}-{2}", FullName, Address, EmployeeID);
         }
    }
 }  