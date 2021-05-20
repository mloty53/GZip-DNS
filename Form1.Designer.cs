namespace Lab_5
{
	partial class Form1
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
			this.txtFibAwait = new System.Windows.Forms.TextBox();
			this.txtFibDlg = new System.Windows.Forms.TextBox();
			this.txtFibTask = new System.Windows.Forms.TextBox();
			this.btnNewtonAwait = new System.Windows.Forms.Button();
			this.btnNewtonDlg = new System.Windows.Forms.Button();
			this.btnNewtonTask = new System.Windows.Forms.Button();
			this.numN = new System.Windows.Forms.NumericUpDown();
			this.label2 = new System.Windows.Forms.Label();
			this.numK = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.pbFib = new System.Windows.Forms.ProgressBar();
			this.txtFibResult = new System.Windows.Forms.TextBox();
			this.btnFib = new System.Windows.Forms.Button();
			this.numFib = new System.Windows.Forms.NumericUpDown();
			this.label3 = new System.Windows.Forms.Label();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.btnDecompress = new System.Windows.Forms.Button();
			this.btnCompress = new System.Windows.Forms.Button();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.txtDNS = new System.Windows.Forms.TextBox();
			this.btnResolve = new System.Windows.Forms.Button();
			this.bwFib = new System.ComponentModel.BackgroundWorker();
			this.dlgFolderBrowser = new System.Windows.Forms.FolderBrowserDialog();
			this.dlgFileBrowser = new System.Windows.Forms.OpenFileDialog();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numN)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numK)).BeginInit();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numFib)).BeginInit();
			this.groupBox3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtFibAwait);
			this.groupBox1.Controls.Add(this.txtFibDlg);
			this.groupBox1.Controls.Add(this.txtFibTask);
			this.groupBox1.Controls.Add(this.btnNewtonAwait);
			this.groupBox1.Controls.Add(this.btnNewtonDlg);
			this.groupBox1.Controls.Add(this.btnNewtonTask);
			this.groupBox1.Controls.Add(this.numN);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.numK);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(13, 13);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(296, 101);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Symbol Newtona";
			// 
			// txtFibAwait
			// 
			this.txtFibAwait.Location = new System.Drawing.Point(185, 68);
			this.txtFibAwait.Name = "txtFibAwait";
			this.txtFibAwait.Size = new System.Drawing.Size(100, 20);
			this.txtFibAwait.TabIndex = 9;
			// 
			// txtFibDlg
			// 
			this.txtFibDlg.Location = new System.Drawing.Point(185, 44);
			this.txtFibDlg.Name = "txtFibDlg";
			this.txtFibDlg.Size = new System.Drawing.Size(100, 20);
			this.txtFibDlg.TabIndex = 8;
			// 
			// txtFibTask
			// 
			this.txtFibTask.Location = new System.Drawing.Point(185, 20);
			this.txtFibTask.Name = "txtFibTask";
			this.txtFibTask.Size = new System.Drawing.Size(100, 20);
			this.txtFibTask.TabIndex = 7;
			// 
			// btnNewtonAwait
			// 
			this.btnNewtonAwait.Location = new System.Drawing.Point(99, 67);
			this.btnNewtonAwait.Name = "btnNewtonAwait";
			this.btnNewtonAwait.Size = new System.Drawing.Size(80, 23);
			this.btnNewtonAwait.TabIndex = 6;
			this.btnNewtonAwait.Text = "Async/Await";
			this.btnNewtonAwait.UseVisualStyleBackColor = true;
			this.btnNewtonAwait.Click += new System.EventHandler(this.btnNewtonAwait_Click);
			// 
			// btnNewtonDlg
			// 
			this.btnNewtonDlg.Location = new System.Drawing.Point(99, 43);
			this.btnNewtonDlg.Name = "btnNewtonDlg";
			this.btnNewtonDlg.Size = new System.Drawing.Size(80, 23);
			this.btnNewtonDlg.TabIndex = 5;
			this.btnNewtonDlg.Text = "Delegate";
			this.btnNewtonDlg.UseVisualStyleBackColor = true;
			this.btnNewtonDlg.Click += new System.EventHandler(this.btnNewtonDlg_Click);
			// 
			// btnNewtonTask
			// 
			this.btnNewtonTask.Location = new System.Drawing.Point(99, 19);
			this.btnNewtonTask.Name = "btnNewtonTask";
			this.btnNewtonTask.Size = new System.Drawing.Size(80, 23);
			this.btnNewtonTask.TabIndex = 4;
			this.btnNewtonTask.Text = "Task";
			this.btnNewtonTask.UseVisualStyleBackColor = true;
			this.btnNewtonTask.Click += new System.EventHandler(this.btnNewtonTask_Click);
			// 
			// numN
			// 
			this.numN.Location = new System.Drawing.Point(30, 43);
			this.numN.Name = "numN";
			this.numN.Size = new System.Drawing.Size(62, 20);
			this.numN.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(7, 45);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(18, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "N:";
			// 
			// numK
			// 
			this.numK.Location = new System.Drawing.Point(30, 19);
			this.numK.Name = "numK";
			this.numK.Size = new System.Drawing.Size(62, 20);
			this.numK.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(7, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(17, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "K:";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.pbFib);
			this.groupBox2.Controls.Add(this.txtFibResult);
			this.groupBox2.Controls.Add(this.btnFib);
			this.groupBox2.Controls.Add(this.numFib);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Location = new System.Drawing.Point(13, 121);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(188, 97);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Fibonacci";
			// 
			// pbFib
			// 
			this.pbFib.Location = new System.Drawing.Point(9, 72);
			this.pbFib.Name = "pbFib";
			this.pbFib.Size = new System.Drawing.Size(170, 14);
			this.pbFib.TabIndex = 4;
			// 
			// txtFibResult
			// 
			this.txtFibResult.Location = new System.Drawing.Point(9, 46);
			this.txtFibResult.Name = "txtFibResult";
			this.txtFibResult.ReadOnly = true;
			this.txtFibResult.Size = new System.Drawing.Size(170, 20);
			this.txtFibResult.TabIndex = 3;
			// 
			// btnFib
			// 
			this.btnFib.Location = new System.Drawing.Point(133, 18);
			this.btnFib.Name = "btnFib";
			this.btnFib.Size = new System.Drawing.Size(46, 23);
			this.btnFib.TabIndex = 2;
			this.btnFib.Text = "Start";
			this.btnFib.UseVisualStyleBackColor = true;
			this.btnFib.Click += new System.EventHandler(this.btnFib_Click);
			// 
			// numFib
			// 
			this.numFib.Location = new System.Drawing.Point(26, 20);
			this.numFib.Name = "numFib";
			this.numFib.Size = new System.Drawing.Size(100, 20);
			this.numFib.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(11, 23);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(9, 13);
			this.label3.TabIndex = 0;
			this.label3.Text = "i";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.btnDecompress);
			this.groupBox3.Controls.Add(this.btnCompress);
			this.groupBox3.Location = new System.Drawing.Point(208, 121);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(101, 97);
			this.groupBox3.TabIndex = 2;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Kompresja";
			// 
			// btnDecompress
			// 
			this.btnDecompress.Location = new System.Drawing.Point(7, 43);
			this.btnDecompress.Name = "btnDecompress";
			this.btnDecompress.Size = new System.Drawing.Size(83, 23);
			this.btnDecompress.TabIndex = 1;
			this.btnDecompress.Text = "Decompress";
			this.btnDecompress.UseVisualStyleBackColor = true;
			this.btnDecompress.Click += new System.EventHandler(this.btnDecompress_Click);
			// 
			// btnCompress
			// 
			this.btnCompress.Location = new System.Drawing.Point(7, 17);
			this.btnCompress.Name = "btnCompress";
			this.btnCompress.Size = new System.Drawing.Size(83, 23);
			this.btnCompress.TabIndex = 0;
			this.btnCompress.Text = "Compress";
			this.btnCompress.UseVisualStyleBackColor = true;
			this.btnCompress.Click += new System.EventHandler(this.btnCompress_Click);
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.txtDNS);
			this.groupBox4.Controls.Add(this.btnResolve);
			this.groupBox4.Location = new System.Drawing.Point(12, 224);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(297, 160);
			this.groupBox4.TabIndex = 3;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "DNS";
			// 
			// txtDNS
			// 
			this.txtDNS.Location = new System.Drawing.Point(10, 22);
			this.txtDNS.Multiline = true;
			this.txtDNS.Name = "txtDNS";
			this.txtDNS.ReadOnly = true;
			this.txtDNS.Size = new System.Drawing.Size(281, 132);
			this.txtDNS.TabIndex = 5;
			// 
			// btnResolve
			// 
			this.btnResolve.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnResolve.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.btnResolve.Location = new System.Drawing.Point(40, -1);
			this.btnResolve.Name = "btnResolve";
			this.btnResolve.Size = new System.Drawing.Size(53, 17);
			this.btnResolve.TabIndex = 4;
			this.btnResolve.Text = "Resolve";
			this.btnResolve.UseVisualStyleBackColor = true;
			this.btnResolve.Click += new System.EventHandler(this.btnResolve_Click);
			// 
			// bwFib
			// 
			this.bwFib.WorkerReportsProgress = true;
			this.bwFib.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwFib_DoWork);
			this.bwFib.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bwFib_ProgressChanged);
			this.bwFib.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwFib_RunWorkerCompleted);
			// 
			// dlgFileBrowser
			// 
			this.dlgFileBrowser.Filter = "GZ files|*.gz";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(322, 396);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numN)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numK)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numFib)).EndInit();
			this.groupBox3.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnNewtonDlg;
		private System.Windows.Forms.Button btnNewtonTask;
		private System.Windows.Forms.NumericUpDown numN;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.NumericUpDown numK;
		private System.Windows.Forms.TextBox txtFibAwait;
		private System.Windows.Forms.TextBox txtFibDlg;
		private System.Windows.Forms.TextBox txtFibTask;
		private System.Windows.Forms.Button btnNewtonAwait;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox txtFibResult;
		private System.Windows.Forms.Button btnFib;
		private System.Windows.Forms.NumericUpDown numFib;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Button btnDecompress;
		private System.Windows.Forms.Button btnCompress;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.ProgressBar pbFib;
		private System.Windows.Forms.Button btnResolve;
		private System.Windows.Forms.TextBox txtDNS;
		private System.ComponentModel.BackgroundWorker bwFib;
		private System.Windows.Forms.FolderBrowserDialog dlgFolderBrowser;
		private System.Windows.Forms.OpenFileDialog dlgFileBrowser;
	}
}

