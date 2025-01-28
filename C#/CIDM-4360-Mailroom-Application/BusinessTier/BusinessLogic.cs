using System.Data;
using MySql.Data.MySqlClient;
class BusinessLogic
{
   
    static void Main(string[] args)
    {
        bool _continue = true;
        User user;
        GuiTier appGUI = new GuiTier();
        DataTier database = new DataTier();
        string email = "";
        // Declare variables
        string full_name;
        int unit_number;
        string postal_service;
        string package_confirm;
        string pickup_confirm;

        // start GUI
        user = appGUI.Login();

       
        if (database.LoginCheck(user)){

            while(_continue){
                int option  = appGUI.Dashboard(user);
                switch(option)
                {
                    // Package Delivery Process
                    case 1:
                        Console.WriteLine("Please input resident name listed on package label");
                        full_name = Console.ReadLine();
                        // Check Resident Exists
                        DataTable tableResidents = database.CheckResident(full_name);
                        if(tableResidents != null){
                            appGUI.DisplayResidents(tableResidents);
                            Console.WriteLine("Please input postal service agency (e.g., FedEx, USPS, UPS)");
                            postal_service = Console.ReadLine();
                            Console.WriteLine("Please input resident unit number");
                            unit_number = Convert.ToInt16(Console.ReadLine());
                            Console.WriteLine("Confirm package information? (y/n)");
                            package_confirm = Console.ReadLine();
                            if(package_confirm.ToLower() == "y"){
                                // Add to Pending Area
                                database.AddRecords(full_name, unit_number, postal_service);
                                database.AddPending(full_name, unit_number, postal_service);
                                Console.WriteLine("Package successfully placed in Pending Area");
                                // Send Email Notification
                                EmailSender.SendEmail(
                                    senderEmail: "noreply@buffteks.org",           // Sender's email address
                                    password: "cidm4360fall2024@*",                // Sender's email password
                                    toEmail: "dloutlaw1@buffs.wtamu.edu",        // Recipient's email address
                                    subject: "Package Pickup Notification"         // Subject of the email
                                );
                            }
                        }
                        else{
                            // Add to UNKNOWN
                            Console.WriteLine("Resident not found. Proceed with placing package information into UNKNOWN");
                            Console.WriteLine("Please input postal service agency (e.g., FedEx, USPS, UPS)");
                            postal_service = Console.ReadLine();
                            Console.WriteLine("Confirm package information? (y/n)");
                            package_confirm = Console.ReadLine();
                            if(package_confirm.ToLower() == "y"){
                                database.AddUnknown(full_name, postal_service);
                                Console.WriteLine("Package successfully placed in UNKNOWN");
                            }
                        }
                        break;
                    // Package Pickup Process
                    case 2:
                        Console.WriteLine("Please input resident name listed on package label");
                        full_name = Console.ReadLine();
                        Console.WriteLine("Please input resident unit number listed on package label");
                        unit_number = Convert.ToInt16(Console. ReadLine());
                        Console.WriteLine("Please input postal service");
                        postal_service = Console. ReadLine();
                        Console.WriteLine("Confirm package pickup? (y/n)");
                        pickup_confirm = Console.ReadLine();
                        if(pickup_confirm.ToLower() == "y"){
                            database.RemovePending(full_name, unit_number, postal_service);
                            Console.WriteLine("Package successfully removed from Pending Area");
                        }
                        break;
                    // Package Record Retrieval
                    case 3:
                        Console.WriteLine("Please input resident name listed on package label");
                        full_name = Console.ReadLine();
                        Console.WriteLine("Please input resident unit number");
                        unit_number = Convert.ToInt16(Console.ReadLine());
                        DataTable tableRecords = database.CheckRecords(full_name, unit_number);
                        if(tableRecords != null){
                            appGUI.DisplayRecords(tableRecords);
                        }
                        break;
                    // Log Out
                    case 4:
                        _continue = false;
                        Console.WriteLine("Log out, Goodbye.");
                        break;
                    // default: wrong input
                    default:
                        Console.WriteLine("Wrong Input");
                        break;
                }

            }
        }
        else{
                Console.WriteLine("Login Failed, Goodbye.");
        }        
    }    
}