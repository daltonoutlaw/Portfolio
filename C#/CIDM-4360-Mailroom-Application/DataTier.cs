using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;
class DataTier{
    public string connStr = "server=34.69.59.37;user=dloutlaw1;database=dloutlaw1;port=8080;password=dloutlaw1";

    // perform login check using Stored Procedure "LoginCount" in Database based on given user's staff_username and staff_password
    public bool LoginCheck(User user){

        MySqlConnection conn = new MySqlConnection(connStr);
        try{  
            conn.Open();
            string procedure = "LoginCount";
            MySqlCommand cmd = new MySqlCommand(procedure, conn);
            cmd.CommandType = CommandType.StoredProcedure; // set the commandType as storedProcedure
            cmd.Parameters.AddWithValue("@inputstaff_username", user.staff_username);
            cmd.Parameters.AddWithValue("@inputstaff_password", user.staff_password);
            cmd.Parameters.Add("@userCount", MySqlDbType.Int32).Direction =  ParameterDirection.Output;
            MySqlDataReader rdr = cmd.ExecuteReader();
           
            int returnCount = (int) cmd.Parameters["@userCount"].Value;
            rdr.Close();
            conn.Close();

            if (returnCount ==1){
                return true;
            }
            else{
                return false;
            }
        }
        
        catch (Exception ex){
            Console.WriteLine(ex.ToString());
            conn.Close();
            return false;
        }
       
    }

    // perform resident check using Stored Procedure "CheckResident" based on full_name
    public DataTable CheckResident(string full_name){
        MySqlConnection conn = new MySqlConnection(connStr);
        
        try{  
            conn.Open();
            string procedure = "CheckResident";
            MySqlCommand cmd = new MySqlCommand(procedure, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@inputfull_name", full_name);
            cmd.Parameters["@inputfull_name"].Direction = ParameterDirection.Input;

            MySqlDataReader rdr = cmd.ExecuteReader();

            DataTable tableResidents = new DataTable();
            tableResidents.Load(rdr);
            rdr.Close();
            conn.Close();
            return tableResidents;
        }
        catch (Exception ex){
            Console.WriteLine(ex.ToString());
            conn.Close();
            return null;
        }
    }

    // perform resident check using Stored Procedure "CheckRecords" based on full_name and unit_number
    public DataTable CheckRecords(string full_name, int unit_number){
        MySqlConnection conn = new MySqlConnection(connStr);
        
        try{  
            conn.Open();
            string procedure = "CheckRecords";
            MySqlCommand cmd = new MySqlCommand(procedure, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@inputfull_name", full_name);
            cmd.Parameters["@inputfull_name"].Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("@inputunit_number", unit_number);
            cmd.Parameters["@inputunit_number"].Direction = ParameterDirection.Input;

            MySqlDataReader rdr = cmd.ExecuteReader();

            DataTable tableRecords = new DataTable();
            tableRecords.Load(rdr);
            rdr.Close();
            conn.Close();
            return tableRecords;
        }
        catch (Exception ex){
            Console.WriteLine(ex.ToString());
            conn.Close();
            return null;
        }
    }

    public void AddPending(string full_name, int unit_number, string postal_service){
        MySqlConnection conn = new MySqlConnection(connStr);
        
        try
        {  
            conn.Open();
            string procedure = "AddPending";
            MySqlCommand cmd = new MySqlCommand(procedure, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@inputfull_name", full_name);
            cmd.Parameters["@inputfull_name"].Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("@inputunit_number", unit_number);
            cmd.Parameters["@inputunit_number"].Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("@inputpostal_service", postal_service);
            cmd.Parameters["@inputpostal_service"].Direction = ParameterDirection.Input;
            cmd.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
            conn.Close();
        }
    }

    public void AddRecords(string full_name, int unit_number, string postal_service){
        MySqlConnection conn = new MySqlConnection(connStr);
        
        try
        {  
            conn.Open();
            string procedure = "AddRecords";
            MySqlCommand cmd = new MySqlCommand(procedure, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@inputfull_name", full_name);
            cmd.Parameters["@inputfull_name"].Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("@inputunit_number", unit_number);
            cmd.Parameters["@inputunit_number"].Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("@inputpostal_service", postal_service);
            cmd.Parameters["@inputpostal_service"].Direction = ParameterDirection.Input;
            cmd.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
            conn.Close();
        }
    }

    public void AddUnknown(string full_name, string postal_service){
        MySqlConnection conn = new MySqlConnection(connStr);
        
        try
        {  
            conn.Open();
            string procedure = "AddUnknown";
            MySqlCommand cmd = new MySqlCommand(procedure, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@inputfull_name", full_name);
            cmd.Parameters["@inputfull_name"].Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("@inputpostal_service", postal_service);
            cmd.Parameters["@inputpostal_service"].Direction = ParameterDirection.Input;
            cmd.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
            conn.Close();
        }
    }

    public void RemovePending(string full_name, int unit_number, string postal_service){
        MySqlConnection conn = new MySqlConnection(connStr);
        
        try
        {  
            conn.Open();
            string procedure = "RemovePending";
            MySqlCommand cmd = new MySqlCommand(procedure, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@inputfull_name", full_name);
            cmd.Parameters["@inputfull_name"].Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("@inputunit_number", postal_service);
            cmd.Parameters["@inputunit_number"].Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("@inputpostal_service", postal_service);
            cmd.Parameters["@inputpostal_service"].Direction = ParameterDirection.Input;
            cmd.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
            conn.Close();
        }
    }
}