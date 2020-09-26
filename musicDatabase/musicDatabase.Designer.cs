namespace musicDatabase
{
	partial class musicDatabase
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.lblArtistName = new System.Windows.Forms.Label();
			this.btnTest = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblArtistName
			// 
			this.lblArtistName.AutoSize = true;
			this.lblArtistName.Location = new System.Drawing.Point(234, 143);
			this.lblArtistName.Name = "lblArtistName";
			this.lblArtistName.Size = new System.Drawing.Size(0, 17);
			this.lblArtistName.TabIndex = 0;
			// 
			// btnTest
			// 
			this.btnTest.AutoSize = true;
			this.btnTest.Location = new System.Drawing.Point(689, 27);
			this.btnTest.Name = "btnTest";
			this.btnTest.Size = new System.Drawing.Size(83, 27);
			this.btnTest.TabIndex = 1;
			this.btnTest.Text = "CLICK ME!";
			this.btnTest.UseVisualStyleBackColor = true;
			this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
			// 
			// musicDatabase
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnTest);
			this.Controls.Add(this.lblArtistName);
			this.Name = "musicDatabase";
			this.Text = "Music Database";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblArtistName;
		private System.Windows.Forms.Button btnTest;
	}
}