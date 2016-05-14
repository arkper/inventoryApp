/*
 * Created by SharpDevelop.
 * User: arkady
 * Date: 5/14/2016
 * Time: 9:57 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Forms;

namespace InventoryWiz
{
	/// <summary>
	/// Class with program entry point.
	/// </summary>
	internal sealed class Program
	{
		/// <summary>
		/// Program entry point.
		/// </summary>
		[STAThread]
		private static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			MainForm mf = new MainForm();
			mf.WindowState = FormWindowState.Maximized;
			
			Application.Run(mf);
		}
		
	}
}
