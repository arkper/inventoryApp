﻿/*
 * Created by SharpDevelop.
 * User: arkady
 * Date: 5/14/2016
 * Time: 10:08 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Data.SqlClient;
using System.IO;
using System.Data.SqlServerCe;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;


namespace InventoryWiz
{
	/// <summary>
	/// Description of InventoryDao.
	/// </summary>
	public class InventoryDao
	{
		private static String connString = System.Configuration.ConfigurationSettings.AppSettings["dbConnectionString"];
		private static SqlCeConnection conn = null;
		
		public static SqlCeConnection getConnection(){

			if (conn == null)
			{
	        	SqlCeEngine engine = new SqlCeEngine(connString);
	        	conn = new SqlCeConnection(connString);
       			conn.Open();
			}
			
			return conn;
		}
		
		public InventoryDao()
		{
		}
		
		public static void PopulateSets(System.Windows.Forms.DataGridView dataGrid){
			DataTable dt = new DataTable();
			
			using (SqlCeCommand comm = InventoryDao.getConnection().CreateCommand())
			{
				comm.CommandText = "select ID, DESCRIPTION, ONHAND from FURNITURE_SET ORDER BY ID";
				dt.Load(comm.ExecuteReader());
			    dataGrid.DataSource = dt;
			}
			
		}
		

		public static void PopulateItemsForSet(System.Windows.Forms.DataGridView dataGrid, string id){
			
			DataTable dt = new DataTable();
			
			using (SqlCeCommand comm = InventoryDao.getConnection().CreateCommand())
			{
				comm.CommandText = "select i.ID, i.DESCRIPTION from SET_ITEM si join INVENTORY i on i.id=si.item_id where si.set_id=@id";
				comm.Parameters.Add("id", id);
				dt.Load(comm.ExecuteReader());
			    dataGrid.DataSource = dt;
			}
			
		}

		public static void PopulateInventory(System.Windows.Forms.DataGridView dataGrid)
		{
			DataTable dt = new DataTable();
			
			using (SqlCeCommand comm = InventoryDao.getConnection().CreateCommand())
			{
				comm.CommandText = "select ID, DESCRIPTION, ONHAND from INVENTORY ORDER BY [ID]";
				dt.Load(comm.ExecuteReader());
			    dataGrid.DataSource = dt;
			}
			
		}

		public static Boolean saveNewSet(string id, string description)
		{
			using (SqlCeCommand comm = InventoryDao.getConnection().CreateCommand())
			{
				//cehck if it's gonna be unique
				comm.CommandText = "select count(*) from inventory where id=@id";
				comm.Parameters.AddWithValue("id", id);
				
				int count = (int) comm.ExecuteScalar();
				
				if (count > 0)
				{
					MessageBox.Show("Sorry, but this ID is already taken, please choose another one!");
					return false;
				}
				
				comm.CommandText = "insert into furniture_set(id, description) values(@id, @desc)";
				
				comm.Parameters.Add("desc", description);
				
				comm.ExecuteNonQuery();
				
				return true;
			}
			
		}
		
		public static void SaveNewSetItem(string setId, string itemId)
		{
			using (SqlCeCommand comm = InventoryDao.getConnection().CreateCommand())
			{
				comm.CommandText = "insert into set_item(set_id, item_id) values(@setId, @itemId)";
				
				comm.Parameters.Add("setId", setId);
				comm.Parameters.Add("itemId", itemId);
				
				
				try {
					comm.ExecuteNonQuery();
				}
				catch (SqlCeException ex)
				{
					MessageBox.Show("Your selection is causing a duplicated record! Please choose another item.");
				}
			}
			
			
		}

		public static void DeleteSet(string setId)
		{
			using (SqlCeCommand comm = InventoryDao.getConnection().CreateCommand())
			{
				comm.CommandText = "delete from SET_ITEM where SET_ID=@setId";
				
				comm.Parameters.Add("setId", setId);
				
				comm.ExecuteNonQuery();

				comm.CommandText = "delete from FURNITURE_SET where id=@setId";
				
				comm.ExecuteNonQuery();
			}
			
		}
		
		public static void DeleteSetItem(string setId, string itemId)
		{
			using (SqlCeCommand comm = InventoryDao.getConnection().CreateCommand())
			{
				comm.CommandText = "delete from SET_ITEM where SET_ID=@setId and ITEM_ID=@itemId";
				
				comm.Parameters.Add("setId", setId);
				comm.Parameters.Add("itemId", itemId);
				
				comm.ExecuteNonQuery();
			}
			
		}
		
		public static void GenerateInventory(Boolean writeToFile)
		{
			// First Update set onhand quantities
			using (SqlCeCommand comm = InventoryDao.getConnection().CreateCommand())
			{
				comm.CommandText="select fs.id, min(i.ONHAND) from FURNITURE_SET fs join set_item si on si.set_id=fs.id join INVENTORY i on si.item_id=i.id group by fs.id";
				
				SqlCeDataReader reader=comm.ExecuteReader();
				
				while (reader.Read())
				{
					string id = reader.GetString(0);
					int onHand = reader.GetInt32(1);
					
					comm.CommandText = 
						"update FURNITURE_SET set ONHAND=@onHand where id=@id";
					
					comm.Parameters.Clear();
					comm.Parameters.AddWithValue("id", id);
					comm.Parameters.AddWithValue("onHand", onHand);
					
					comm.ExecuteNonQuery();

				}

				if (!writeToFile)
					return;
				
				// Now generate full inventory of items and sets
				
				string templateFile = System.Configuration.ConfigurationSettings.AppSettings["templateFile"];
				string outputFile = System.Configuration.ConfigurationSettings.AppSettings["outputFile"];
				
				File.Copy (templateFile, outputFile, true);
				
				
				OleDbConnection excelConnection = new OleDbConnection();
			
				excelConnection.ConnectionString=System.Configuration.ConfigurationSettings.AppSettings["outputConnectionString"];
			
				excelConnection.Open();
			
				DataTable dt = excelConnection.GetSchema("Tables");
				
				
				string tabName = dt.Rows[0]["TABLE_NAME"].ToString();
			
			 
				using (OleDbCommand excelCmd =	excelConnection.CreateCommand())
				{
					comm.CommandText="select id, description, onhand from INVENTORY union all select id, description, onhand from FURNITURE_SET";
					reader = comm.ExecuteReader();
					while (reader.Read())
					{
						string id = reader.GetString(0);
						string desciption = reader.GetString(1);
						int onHand = reader.GetInt32(2);
					
						excelCmd.CommandText = "insert into [" + tabName + "]([Item ID], [Desc for Sales], [Qty on Hand]) values (@id, @desc, @onhand)";
					
						excelCmd.Parameters.Clear();
						excelCmd.Parameters.AddWithValue("id", id);
						excelCmd.Parameters.AddWithValue("desc", desciption);
						excelCmd.Parameters.AddWithValue("onhand", onHand);
					
						excelCmd.ExecuteNonQuery();
					}
				       	
				}
				
				excelConnection.Close();
				
			}
			
			

		}

		
		public static void CreateDB()
    	{
			if (File.Exists("InventoryDb.sdf"))
    			File.Delete("InventoryDb.sdf");
        	
			SqlCeEngine engine = new SqlCeEngine(connString);
        	
        	engine.CreateDatabase();

        	using (SqlCeCommand comm = getConnection().CreateCommand())
       		{
       			comm.CommandText =    			
       				"CREATE TABLE INVENTORY (ID nvarchar(256) not null primary key, DESCRIPTION nvarchar(1000), ONHAND INTEGER)";
        		
       			comm.ExecuteNonQuery();
       			comm.CommandText =    			
       				"CREATE TABLE FURNITURE_SET (ID nvarchar(256) not null primary key, DESCRIPTION nvarchar(1000), ONHAND INTEGER)";
       			comm.ExecuteNonQuery();
        		comm.CommandText =    			
        			"CREATE TABLE SET_ITEM (SET_ID nvarchar(256) not null, ITEM_ID nvarchar(256) not null)";
        		comm.ExecuteNonQuery();
        		comm.CommandText =    			
        			"ALTER TABLE SET_ITEM ADD CONSTRAINT pk_SET_ITEM PRIMARY KEY (SET_ID, ITEM_ID)";
        		comm.ExecuteNonQuery();
        		
        	}

        	RefreshDb(false);
	    }
		
		public static void RefreshDb(bool truncateOld){
        	 		
        	
        	if (truncateOld) {
				using (SqlCeCommand comm = getConnection().CreateCommand())
        		{
	        			comm.CommandText = "delete from INVENTORY";
	        			comm.ExecuteNonQuery();
        		}
        		
        	}
			
			OleDbConnection excelConnection = new OleDbConnection();
			
			excelConnection.ConnectionString=System.Configuration.ConfigurationSettings.AppSettings["excelConnectionString"];
			
			excelConnection.Open();
			
			DataTable dt = excelConnection.GetSchema("Tables");
				
				
			string tabName = dt.Rows[0]["TABLE_NAME"].ToString();
			
			 
			OleDbCommand excelCmd =	excelConnection.CreateCommand();
				
			excelCmd.CommandText = "select * from [" + tabName + "]";
			
			OleDbDataReader reader = excelCmd.ExecuteReader();

			using (SqlCeCommand comm = getConnection().CreateCommand())
       		{
        			comm.CommandText =    			
        				"insert into INVENTORY (ID, DESCRIPTION, ONHAND) values (@id, @desc, @quantity)";


	        		while (reader.Read())
					{
						string id = reader.GetString(0);
						string description = reader.GetString(1);
						double quantity = reader.GetDouble(2);
					
						comm.Parameters.Clear();
					
						comm.Parameters.Add("id", id);
						comm.Parameters.Add("desc", description);
						comm.Parameters.Add("quantity", quantity);
						
						comm.ExecuteNonQuery();
					}
       		}
			
			GenerateInventory(false);
			
		}

	}
}