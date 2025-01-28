using System.Data;
using MySql.Data.MySqlClient;
class GuiTier{
    User user = new User();
    DataTier database = new DataTier();

    // print login page
    public User Login(){
        Console.WriteLine("------Welcome to Mailroom Management System------");
        Console.WriteLine("Please input staff username: ");
        user.staff_username = Console.ReadLine();
        Console.WriteLine("Please input password: ");
        user.staff_password = Console.ReadLine();
        return user;
    }
    // print Dashboard after user logs in successfully
    public int Dashboard(User user){
        DateTime localDate = DateTime.Now;
        Console.WriteLine("---------------Dashboard-------------------");
        Console.WriteLine($"Hello: {user.staff_username}; Date/Time: {localDate.ToString()}");
        Console.WriteLine("Please select an option to continue:");
        Console.WriteLine("1. Package Delivery Process");
        Console.WriteLine("2. Package Pickup Process");
        Console.WriteLine("3. Package Record Retrieval");
        Console.WriteLine("4. Log Out");
        int option = Convert.ToInt16(Console.ReadLine());
        return option;
    }

    // show Residents records returned from database
    public void DisplayResidents(DataTable tableResidents){
        Console.WriteLine("---------------Residents List-------------------");
        foreach(DataRow row in tableResidents.Rows){
           Console.WriteLine($"Name: {row["full_name"]} \t Unit Number: {row["unit_number"]} \t Email:{row["email"]}");
        }
    }

    // show Package records returned from database
    public void DisplayRecords(DataTable tableRecords){
        Console.WriteLine("---------------Package Records-------------------");
        foreach(DataRow row in tableRecords.Rows){
           Console.WriteLine($"Name: {row["full_name"]} \t Unit Number: {row["unit_number"]} \t Postal Service:{row["postal_service"]}");
        }
    }
}