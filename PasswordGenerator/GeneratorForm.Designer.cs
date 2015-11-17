namespace PasswordGenerator
{
	partial class GeneratorForm
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtPattern = new System.Windows.Forms.TextBox();
			this.txtLength = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.trkLength = new System.Windows.Forms.TrackBar();
			this.cmdGenerate = new System.Windows.Forms.Button();
			this.txtOutput = new System.Windows.Forms.TextBox();
			this.lstHistory = new System.Windows.Forms.ListBox();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.trkLength)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.txtPattern);
			this.groupBox1.Controls.Add(this.txtLength);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.trkLength);
			this.groupBox1.Location = new System.Drawing.Point(12, 5);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(224, 98);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Options";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(9, 74);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(44, 13);
			this.label2.TabIndex = 16;
			this.label2.Text = "Pattern:";
			// 
			// txtPattern
			// 
			this.txtPattern.Location = new System.Drawing.Point(56, 71);
			this.txtPattern.Name = "txtPattern";
			this.txtPattern.Size = new System.Drawing.Size(162, 20);
			this.txtPattern.TabIndex = 15;
			this.txtPattern.Text = "cv(c)\\1$cvcc";
			this.txtPattern.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtLength
			// 
			this.txtLength.Location = new System.Drawing.Point(158, 32);
			this.txtLength.Name = "txtLength";
			this.txtLength.Size = new System.Drawing.Size(60, 20);
			this.txtLength.TabIndex = 10;
			this.txtLength.Text = "10";
			this.txtLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtLength.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLength_KeyDown);
			this.txtLength.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLength_KeyPress);
			this.txtLength.Leave += new System.EventHandler(this.txtLength_Leave);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(40, 13);
			this.label1.TabIndex = 9;
			this.label1.Text = "Length";
			// 
			// trkLength
			// 
			this.trkLength.Location = new System.Drawing.Point(6, 32);
			this.trkLength.Maximum = 36;
			this.trkLength.Minimum = 6;
			this.trkLength.Name = "trkLength";
			this.trkLength.Size = new System.Drawing.Size(146, 45);
			this.trkLength.TabIndex = 8;
			this.trkLength.Value = 10;
			this.trkLength.Scroll += new System.EventHandler(this.trkLength_Scroll);
			// 
			// cmdGenerate
			// 
			this.cmdGenerate.Location = new System.Drawing.Point(12, 109);
			this.cmdGenerate.Name = "cmdGenerate";
			this.cmdGenerate.Size = new System.Drawing.Size(224, 23);
			this.cmdGenerate.TabIndex = 0;
			this.cmdGenerate.Text = "&Generate";
			this.cmdGenerate.UseVisualStyleBackColor = true;
			this.cmdGenerate.Click += new System.EventHandler(this.cmdGenerate_Click);
			// 
			// txtOutput
			// 
			this.txtOutput.BackColor = System.Drawing.SystemColors.Window;
			this.txtOutput.Location = new System.Drawing.Point(12, 138);
			this.txtOutput.Name = "txtOutput";
			this.txtOutput.ReadOnly = true;
			this.txtOutput.Size = new System.Drawing.Size(224, 20);
			this.txtOutput.TabIndex = 2;
			this.txtOutput.Text = "--Select Options--";
			this.txtOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// lstHistory
			// 
			this.lstHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.lstHistory.FormattingEnabled = true;
			this.lstHistory.HorizontalScrollbar = true;
			this.lstHistory.IntegralHeight = false;
			this.lstHistory.Items.AddRange(new object[] {
            "(x) stores character",
            "\\1 uses first bracket",
            "c - lowercase consonant",
            "V - uppercase vowel",
            "$ - number",
            "% - special",
            "r - random",
            "others are literals",
            "to use one of the above as literal,",
            "enclose it in [square brackets]"});
			this.lstHistory.Location = new System.Drawing.Point(12, 164);
			this.lstHistory.MinimumSize = new System.Drawing.Size(224, 95);
			this.lstHistory.Name = "lstHistory";
			this.lstHistory.Size = new System.Drawing.Size(224, 136);
			this.lstHistory.TabIndex = 3;
			this.lstHistory.SelectedValueChanged += new System.EventHandler(this.lstHistory_SelectedValueChanged);
			// 
			// GeneratorForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(248, 314);
			this.Controls.Add(this.lstHistory);
			this.Controls.Add(this.txtOutput);
			this.Controls.Add(this.cmdGenerate);
			this.Controls.Add(this.groupBox1);
			this.MaximumSize = new System.Drawing.Size(264, 10000);
			this.MinimumSize = new System.Drawing.Size(264, 352);
			this.Name = "GeneratorForm";
			this.Text = "Password Generator";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.trkLength)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button cmdGenerate;
		private System.Windows.Forms.TextBox txtOutput;
		private System.Windows.Forms.ListBox lstHistory;
		private System.Windows.Forms.TextBox txtLength;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TrackBar trkLength;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtPattern;
	}
}

