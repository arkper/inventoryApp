/*
 * Created by SharpDevelop.
 * User: arkady
 * Date: 5/14/2016
 * Time: 12:05 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace InventoryWiz
{
	partial class NewSetDialog
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel NewSetPanel;
		private System.Windows.Forms.TextBox txtDesc;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtId;
		private System.Windows.Forms.Button newSetSaveButton;
		private System.Windows.Forms.Button exitButton;
		private System.Windows.Forms.Button saveNExitButton;
		
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
			this.NewSetPanel = new System.Windows.Forms.Panel();
			this.txtDesc = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtId = new System.Windows.Forms.TextBox();
			this.newSetSaveButton = new System.Windows.Forms.Button();
			this.exitButton = new System.Windows.Forms.Button();
			this.saveNExitButton = new System.Windows.Forms.Button();
			this.NewSetPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// NewSetPanel
			// 
			this.NewSetPanel.Controls.Add(this.txtDesc);
			this.NewSetPanel.Controls.Add(this.label2);
			this.NewSetPanel.Controls.Add(this.label1);
			this.NewSetPanel.Controls.Add(this.txtId);
			this.NewSetPanel.Location = new System.Drawing.Point(12, 57);
			this.NewSetPanel.Name = "NewSetPanel";
			this.NewSetPanel.Size = new System.Drawing.Size(601, 102);
			this.NewSetPanel.TabIndex = 0;
			// 
			// txtDesc
			// 
			this.txtDesc.Location = new System.Drawing.Point(129, 61);
			this.txtDesc.Name = "txtDesc";
			this.txtDesc.Size = new System.Drawing.Size(429, 22);
			this.txtDesc.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(28, 61);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "Description";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(28, 17);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "Set ID";
			// 
			// txtId
			// 
			this.txtId.Location = new System.Drawing.Point(129, 17);
			this.txtId.Name = "txtId";
			this.txtId.Size = new System.Drawing.Size(185, 22);
			this.txtId.TabIndex = 0;
			// 
			// newSetSaveButton
			// 
			this.newSetSaveButton.Location = new System.Drawing.Point(331, 240);
			this.newSetSaveButton.Name = "newSetSaveButton";
			this.newSetSaveButton.Size = new System.Drawing.Size(109, 42);
			this.newSetSaveButton.TabIndex = 1;
			this.newSetSaveButton.Text = "&Save";
			this.newSetSaveButton.UseVisualStyleBackColor = true;
			this.newSetSaveButton.Click += new System.EventHandler(this.NewSetSaveButtonClick);
			// 
			// exitButton
			// 
			this.exitButton.Location = new System.Drawing.Point(469, 240);
			this.exitButton.Name = "exitButton";
			this.exitButton.Size = new System.Drawing.Size(101, 42);
			this.exitButton.TabIndex = 2;
			this.exitButton.Text = "E&xit";
			this.exitButton.UseVisualStyleBackColor = true;
			this.exitButton.Click += new System.EventHandler(this.ExitButtonClick);
			// 
			// saveNExitButton
			// 
			this.saveNExitButton.Location = new System.Drawing.Point(166, 240);
			this.saveNExitButton.Name = "saveNExitButton";
			this.saveNExitButton.Size = new System.Drawing.Size(124, 41);
			this.saveNExitButton.TabIndex = 3;
			this.saveNExitButton.Text = "S&ave And Exit";
			this.saveNExitButton.UseVisualStyleBackColor = true;
			this.saveNExitButton.Click += new System.EventHandler(this.SaveNExitButtonClick);
			// 
			// NewSetDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(789, 305);
			this.Controls.Add(this.saveNExitButton);
			this.Controls.Add(this.exitButton);
			this.Controls.Add(this.newSetSaveButton);
			this.Controls.Add(this.NewSetPanel);
			this.Name = "NewSetDialog";
			this.Text = "NewSetDialog";
			this.NewSetPanel.ResumeLayout(false);
			this.NewSetPanel.PerformLayout();
			this.ResumeLayout(false);

		}
	}
}
