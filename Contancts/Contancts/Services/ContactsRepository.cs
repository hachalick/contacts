using Contancts.Repository;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Contancts.Services
{
  internal class ContactsRepository : IContactsRepository
  {
    private string connectionString = "Data Source=.;Initial Catalog=Contacts;Integrated Security=true";
    public bool DeleteContacts(int contact_id)
    {
      SqlConnection connection = new SqlConnection(connectionString);
      try
      {
        string queryString = "Delete From Table_Contacts Where contact_id=@contact_id";
        SqlCommand command = new SqlCommand(queryString, connection);
        command.Parameters.AddWithValue("@contact_id", contact_id);
        connection.Open();
        command.ExecuteNonQuery();
        return true;
      }
      catch
      {
        return false;
      }
      finally
      {
        connection.Close();
      }
    }

    public bool InsertContacts(string name, string family, string mobile, DateTime birth_date)
    {
      SqlConnection connection = new SqlConnection(connectionString);
      try
      {
        string queryString = "Insert Into Table_Contacts (name,family,mobile,birth_date) values (@name,@family,@mobile,@birth_date)";
        SqlCommand command = new SqlCommand(queryString, connection);
        command.Parameters.AddWithValue("@name", name);
        command.Parameters.AddWithValue("@family", family);
        command.Parameters.AddWithValue("@mobile", mobile);
        command.Parameters.AddWithValue("@birth_date", birth_date);
        connection.Open();
        command.ExecuteNonQuery();
        return true;
      }
      catch
      {
        return false;
      }
      finally
      {
        connection.Close();
      }
    }

    public DataTable SelectAll()
    {
      SqlConnection connection = new SqlConnection(connectionString);
      string queryString = "Select * From Table_Contacts";
      SqlDataAdapter adapter = new SqlDataAdapter(queryString, connection);
      DataTable data = new DataTable();
      adapter.Fill(data);
      return data;
    }

    public DataTable SelectById(int contact_id)
    {
      SqlConnection connection = new SqlConnection(connectionString);
      string queryString = $"Select * From Table_Contacts where contact_id={contact_id}";
      SqlDataAdapter adapter = new SqlDataAdapter(queryString, connection);
      DataTable data = new DataTable();
      adapter.Fill(data);
      return data;
    }

    public bool UpdateContacts(int contact_id, string name, string family, string mobile, DateTime birth_date)
    {
      SqlConnection connection = new SqlConnection(connectionString);
      try
      {
        string queryString = "Update Table_Contacts Set name=@name,family=@family,mobile=@mobile,birth_date=@birth_date where contact_id=@contact_id";
        SqlCommand command = new SqlCommand(queryString, connection);
        command.Parameters.AddWithValue("@contact_id", contact_id);
        command.Parameters.AddWithValue("@name", name);
        command.Parameters.AddWithValue("@family", family);
        command.Parameters.AddWithValue("@mobile", mobile);
        command.Parameters.AddWithValue("@birth_date", birth_date);
        connection.Open();
        command.ExecuteNonQuery();
        return true;
      }
      catch
      {
        return false;
      }
      finally
      {
        connection.Close();
      }
    }
  }
}
