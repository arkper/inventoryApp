/*
 * Created by SharpDevelop.
 * User: arkady
 * Date: 5/14/2016
 * Time: 12:05 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace InventoryWiz
{
	/// <summary>
	/// Description of NewSetDialog.
	/// </summary>
	public partial class NewSetDialog : Form
	{
		public NewSetDialog()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void NewSetSaveButtonClick(object sender, EventArgs e)
		{
			if (validate())
			{
				InventoryDao.saveNewSet(txtId.Text, txtDesc.Text);
			}
		}
		void ExitButtonClick(object sender, EventArgs e)
		{
			this.Close();
		}
		void SaveNExitButtonClick(object sender, EventArgs e)
		{
			if (validate())
			{
				if (InventoryDao.saveNewSet(txtId.Text, txtDesc.Text))
					this.Close();
			}
	
		}
		
		Boolean validate()
		{
			if (txtId.Text.Trim() == "" || txtDesc.Text.Trim() == "")
			{
				MessageBox.Show("Both id and description values must be given!");
				return false;
			}
			return true;
		}
	}
}
