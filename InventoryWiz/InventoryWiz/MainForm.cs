/*
 * Created by SharpDevelop.
 * User: arkady
 * Date: 5/14/2016
 * Time: 9:57 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlServerCe;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Data;
using System.Configuration;

namespace InventoryWiz
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			
			InitializeComponent();
			
			RefreshAllGrids();
		}
		
		
		public void RefreshAllGrids()
		{
			try {
				InventoryDao.PopulateSets(dgSets);
			
				ResizeSetsGrid();
			
				InventoryDao.PopulateInventory(dgInventory);
			
				ResizeInventoryGrid();
			
				if (dgSets.Rows.Count > 0) {
					dgSets.Rows[0].Selected = true;
					InventoryDao.PopulateItemsForSet(dgItems, dgSets.SelectedRows[0].Cells[0].Value.ToString());
					ResizeItemsGrid();
				}
			}
			catch (Exception e) {
				Console.Write(e.Message);
			}
			
		}
		
		void CreateDbButtonClick(object sender, EventArgs e)
		{
			InventoryDao.CreateDB();
			
			MessageBox.Show("Success!");
			
		}
		void RefreshInventoryButtonClick(object sender, EventArgs e)
		{
			this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
			
			InventoryDao.RefreshDb(true);
			
			MessageBox.Show("Done!");
			
			RefreshAllGrids();
			
			this.Cursor = System.Windows.Forms.Cursors.Default;
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
	
		}
		
		
		void AddNewSetButtonClick(object sender, EventArgs e)
		{
			new NewSetDialog().ShowDialog(this);
			
			InventoryDao.PopulateSets(dgSets);
		}

		void DgSetsSelectionChanged(object sender, EventArgs e)
		{
			int rowIndex = dgSets.CurrentRow.Index;
			
			string id = dgSets.Rows[rowIndex].Cells[0].Value.ToString();
				
			InventoryDao.PopulateItemsForSet(dgItems, id);
			ResizeItemsGrid();
			
		}
		void AddItemButtonClick(object sender, EventArgs e)
		{
			AddInventoryItem();
		}
		
		void RemoveItemButtonClick(object sender, EventArgs e)
		{
			if (dgSets.CurrentRow != null && dgItems.CurrentRow != null)
			{
				string itemId = dgItems.CurrentRow.Cells[0].Value.ToString();
				string setId = dgSets.CurrentRow.Cells[0].Value.ToString();
				
				InventoryDao.DeleteSetItem(setId, itemId);
				
				InventoryDao.PopulateItemsForSet(dgItems, setId);
			}
	
		}
		void DeleteSetButtonClick(object sender, EventArgs e)
		{
			if (dgSets.CurrentRow != null)
			{
				string setId = dgSets.CurrentRow.Cells[0].Value.ToString();
				
				InventoryDao.DeleteSet(setId);
				
				InventoryDao.PopulateSets(dgSets);
				
				if (dgSets.CurrentRow != null)
					InventoryDao.PopulateItemsForSet(dgItems, dgSets.CurrentRow.Cells[0].Value.ToString());
			}
	
		}
		
		
		public void ResizeSetsGrid() {
			dgSets.Columns[0].Width= (int) Math.Floor (dgSets.Width * .2);
			dgSets.Columns[1].Width=(int) Math.Floor (dgSets.Width * .55);
			dgSets.Columns[2].Width=(int) Math.Floor (dgSets.Width * .2);
			dgSets.Columns[3].Width=(int) Math.Floor (dgSets.Width * .2);
			dgSets.Columns[4].Width=(int) Math.Floor (dgSets.Width * .2);
			dgSets.Columns[5].Width=(int) Math.Floor (dgSets.Width * .2);
			
			
		}
		void ResizeItemsGrid() {
			dgItems.Columns[0].Width= (int) Math.Floor (dgItems.Width * .2);
			dgItems.Columns[1].Width=(int) Math.Floor (dgItems.Width * .8);
		}
		
		void ResizeInventoryGrid() {
			dgInventory.Columns[0].Width= (int) Math.Floor (dgInventory.Width * .2);
			dgInventory.Columns[1].Width=(int) Math.Floor (dgInventory.Width * .55);
			dgInventory.Columns[2].Width= (int) Math.Floor (dgInventory.Width * .2);
			dgInventory.Columns[3].Width= (int) Math.Floor (dgInventory.Width * .2);
			dgInventory.Columns[4].Width= (int) Math.Floor (dgInventory.Width * .2);
			dgInventory.Columns[5].Width= (int) Math.Floor (dgInventory.Width * .2);
		}
		void GenerateFullInventoryButtonClick(object sender, EventArgs e)
		{
			this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
			
			InventoryDao.GenerateInventory(true);
			
			MessageBox.Show ("Finished! Please find your full inventory at " + Application.StartupPath + "\\" +
			                 ConfigurationManager.AppSettings["outputFile"]);
			
			RefreshAllGrids();
			
			this.Cursor = System.Windows.Forms.Cursors.Default;
		}
		
		void CreateDBButtonClick(object sender, EventArgs e)
		{
			if (MessageBox.Show(
				"This action will erase ALL existing database records and start everything from scratch! " +
				"Please think carefully and confirm your decision or click Cancel if you are not sure", 
				"WARNING!!!", MessageBoxButtons.OKCancel) == DialogResult.OK)
			{
				this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
				InventoryDao.CreateDB();
				RefreshAllGrids();
				
				dgItems.DataSource = null;
				this.Cursor = System.Windows.Forms.Cursors.Default;
			}
		}
		
		void DgInventoryCellContentClick(object sender, DataGridViewCellEventArgs e)
		{
	
		}
		void DgInventoryCellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			AddInventoryItem();
		}
		void DgInventoryRowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			AddInventoryItem();
		}
		
		void AddInventoryItem()
		{
			if (dgInventory.CurrentRow != null && dgSets.CurrentRow != null)
			{
				string itemId = dgInventory.CurrentRow.Cells[0].Value.ToString();
				string setId = dgSets.CurrentRow.Cells[0].Value.ToString();
				
				InventoryDao.SaveNewSetItem(setId, itemId);
				
				InventoryDao.PopulateItemsForSet(dgItems, setId);
				
				int currentRow = dgInventory.CurrentRow.Index;
				
				if (currentRow < dgInventory.Rows.Count-1)
				{
					dgInventory.CurrentCell = dgInventory.Rows[currentRow+1].Cells[0];
				}
				
			}			
		}
	
	}
	
	


}
