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
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.DataGridView dgSets;
		private System.Windows.Forms.Button refreshInventoryButton;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button addNewSetButton;
		private System.Windows.Forms.Button generateFullInventoryButton;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button addItemButton;
		private System.Windows.Forms.Button removeItemButton;
		private System.Windows.Forms.DataGridView dgItems;
		private System.Windows.Forms.DataGridView dgInventory;
		private System.Windows.Forms.Button deleteSetButton;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button createDBButton;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.refreshInventoryButton = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.addNewSetButton = new System.Windows.Forms.Button();
			this.generateFullInventoryButton = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.addItemButton = new System.Windows.Forms.Button();
			this.removeItemButton = new System.Windows.Forms.Button();
			this.dgSets = new System.Windows.Forms.DataGridView();
			this.dgItems = new System.Windows.Forms.DataGridView();
			this.dgInventory = new System.Windows.Forms.DataGridView();
			this.deleteSetButton = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.createDBButton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgSets)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgItems)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgInventory)).BeginInit();
			this.SuspendLayout();
			// 
			// refreshInventoryButton
			// 
			this.refreshInventoryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.refreshInventoryButton.ForeColor = System.Drawing.Color.Black;
			this.refreshInventoryButton.Location = new System.Drawing.Point(805, 769);
			this.refreshInventoryButton.Name = "refreshInventoryButton";
			this.refreshInventoryButton.Size = new System.Drawing.Size(228, 35);
			this.refreshInventoryButton.TabIndex = 4;
			this.refreshInventoryButton.Text = "Refresh Inventory";
			this.refreshInventoryButton.UseVisualStyleBackColor = true;
			this.refreshInventoryButton.Click += new System.EventHandler(this.RefreshInventoryButtonClick);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(49, 23);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(265, 21);
			this.label1.TabIndex = 3;
			this.label1.Text = "Furniture Sets";
			// 
			// addNewSetButton
			// 
			this.addNewSetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.addNewSetButton.ForeColor = System.Drawing.Color.Black;
			this.addNewSetButton.Location = new System.Drawing.Point(192, 707);
			this.addNewSetButton.Name = "addNewSetButton";
			this.addNewSetButton.Size = new System.Drawing.Size(122, 36);
			this.addNewSetButton.TabIndex = 0;
			this.addNewSetButton.Text = "Add New Set";
			this.addNewSetButton.UseVisualStyleBackColor = true;
			this.addNewSetButton.Click += new System.EventHandler(this.AddNewSetButtonClick);
			// 
			// generateFullInventoryButton
			// 
			this.generateFullInventoryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.generateFullInventoryButton.ForeColor = System.Drawing.Color.Black;
			this.generateFullInventoryButton.Location = new System.Drawing.Point(1039, 769);
			this.generateFullInventoryButton.Name = "generateFullInventoryButton";
			this.generateFullInventoryButton.Size = new System.Drawing.Size(226, 35);
			this.generateFullInventoryButton.TabIndex = 5;
			this.generateFullInventoryButton.Text = "Generate Full Inventory";
			this.generateFullInventoryButton.UseVisualStyleBackColor = true;
			this.generateFullInventoryButton.Click += new System.EventHandler(this.GenerateFullInventoryButtonClick);
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Black;
			this.label2.Location = new System.Drawing.Point(1205, 23);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 7;
			this.label2.Text = "Inventory";
			// 
			// addItemButton
			// 
			this.addItemButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.addItemButton.Location = new System.Drawing.Point(1111, 342);
			this.addItemButton.Name = "addItemButton";
			this.addItemButton.Size = new System.Drawing.Size(75, 38);
			this.addItemButton.TabIndex = 2;
			this.addItemButton.Text = "<--";
			this.addItemButton.UseVisualStyleBackColor = true;
			this.addItemButton.Click += new System.EventHandler(this.AddItemButtonClick);
			// 
			// removeItemButton
			// 
			this.removeItemButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.removeItemButton.Location = new System.Drawing.Point(1111, 386);
			this.removeItemButton.Name = "removeItemButton";
			this.removeItemButton.Size = new System.Drawing.Size(75, 38);
			this.removeItemButton.TabIndex = 3;
			this.removeItemButton.Text = "-->";
			this.removeItemButton.UseVisualStyleBackColor = true;
			this.removeItemButton.Click += new System.EventHandler(this.RemoveItemButtonClick);
			// 
			// dgSets
			// 
			this.dgSets.AllowUserToAddRows = false;
			this.dgSets.AllowUserToDeleteRows = false;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgSets.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgSets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgSets.Location = new System.Drawing.Point(49, 49);
			this.dgSets.MultiSelect = false;
			this.dgSets.Name = "dgSets";
			this.dgSets.ReadOnly = true;
			this.dgSets.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.dgSets.RowTemplate.Height = 24;
			this.dgSets.Size = new System.Drawing.Size(604, 635);
			this.dgSets.TabIndex = 11;
			this.dgSets.TabStop = false;
			this.dgSets.Click += new System.EventHandler(this.DgSetsSelectionChanged);
			// 
			// dgItems
			// 
			this.dgItems.AllowUserToAddRows = false;
			this.dgItems.AllowUserToDeleteRows = false;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dgItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgItems.Location = new System.Drawing.Point(682, 294);
			this.dgItems.MultiSelect = false;
			this.dgItems.Name = "dgItems";
			this.dgItems.ReadOnly = true;
			this.dgItems.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.dgItems.RowTemplate.Height = 24;
			this.dgItems.Size = new System.Drawing.Size(404, 217);
			this.dgItems.TabIndex = 12;
			this.dgItems.TabStop = false;
			// 
			// dgInventory
			// 
			this.dgInventory.AllowUserToAddRows = false;
			this.dgInventory.AllowUserToDeleteRows = false;
			this.dgInventory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgInventory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.dgInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgInventory.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.dgInventory.Location = new System.Drawing.Point(1205, 49);
			this.dgInventory.MultiSelect = false;
			this.dgInventory.Name = "dgInventory";
			this.dgInventory.ReadOnly = true;
			this.dgInventory.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
			this.dgInventory.RowTemplate.Height = 24;
			this.dgInventory.Size = new System.Drawing.Size(697, 635);
			this.dgInventory.TabIndex = 13;
			this.dgInventory.TabStop = false;
			this.dgInventory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgInventoryCellContentClick);
			this.dgInventory.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgInventoryCellContentDoubleClick);
			this.dgInventory.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgInventoryRowHeaderMouseDoubleClick);
			// 
			// deleteSetButton
			// 
			this.deleteSetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.deleteSetButton.ForeColor = System.Drawing.Color.Black;
			this.deleteSetButton.Location = new System.Drawing.Point(330, 707);
			this.deleteSetButton.Name = "deleteSetButton";
			this.deleteSetButton.Size = new System.Drawing.Size(139, 36);
			this.deleteSetButton.TabIndex = 1;
			this.deleteSetButton.Text = "DeleteSet";
			this.deleteSetButton.UseVisualStyleBackColor = true;
			this.deleteSetButton.Click += new System.EventHandler(this.DeleteSetButtonClick);
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Black;
			this.label3.Location = new System.Drawing.Point(682, 265);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(235, 23);
			this.label3.TabIndex = 15;
			this.label3.Text = "Set Item Collection";
			// 
			// createDBButton
			// 
			this.createDBButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.createDBButton.ForeColor = System.Drawing.Color.Red;
			this.createDBButton.Location = new System.Drawing.Point(612, 769);
			this.createDBButton.Name = "createDBButton";
			this.createDBButton.Size = new System.Drawing.Size(187, 35);
			this.createDBButton.TabIndex = 16;
			this.createDBButton.Text = "Create Database";
			this.createDBButton.UseVisualStyleBackColor = true;
			this.createDBButton.Click += new System.EventHandler(this.CreateDBButtonClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1914, 830);
			this.Controls.Add(this.createDBButton);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.deleteSetButton);
			this.Controls.Add(this.dgInventory);
			this.Controls.Add(this.dgItems);
			this.Controls.Add(this.dgSets);
			this.Controls.Add(this.removeItemButton);
			this.Controls.Add(this.addItemButton);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.generateFullInventoryButton);
			this.Controls.Add(this.addNewSetButton);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.refreshInventoryButton);
			this.ForeColor = System.Drawing.Color.Black;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "InventoryWiz";
			this.Load += new System.EventHandler(this.MainFormLoad);
			((System.ComponentModel.ISupportInitialize)(this.dgSets)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgItems)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgInventory)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
