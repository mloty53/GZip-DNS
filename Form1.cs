using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_5
{
	public partial class Form1 : Form
	{
		public static int Newton(int n, int k)
		{
			int result = 1;
			for (int i = 1; i <= k; ++i)
				result = result * (n - i + 1) / i;
			return result;
		}

		public Task<int> NewtonAwait(int n, int k)
		{
			var task = Task.Factory.StartNew<int>(() =>
			{
				int result = 1;
				for (int i = 1; i <= k; ++i)
					result = result * (n - i + 1) / i;
				return result;
			});
			return task;
		}

		public Form1()
		{
			InitializeComponent();
		}

		#region Buttons_Click
		private void btnNewtonTask_Click(object sender, EventArgs e)
		{
			Task.Factory.StartNew(() =>
			{
				int k = (int) numK.Value;
				int n = (int) numN.Value;

				Task<int> tDiv = Task.Factory.StartNew(() =>
				{
					int resultd = 1;
					for (int i = 1; i <= k; ++i)
						resultd *= i;
					return resultd;
				});

				int result = 1;
				for (int i = 1; i <= k; ++i)
					result *= n - i + 1;

				tDiv.Wait();

				txtFibTask.Invoke(new Action(() => txtFibTask.Text = (result / tDiv.Result).ToString()));
			});
		}

		private void btnNewtonDlg_Click(object sender, EventArgs e)
		{
			Func<int, int, int> op = Newton;
			var result = op.BeginInvoke((int) numN.Value, (int) numK.Value, null, null);
			var newton = op.EndInvoke(result);
			txtFibDlg.Text = newton.ToString();
		}

		private async void btnNewtonAwait_Click(object sender, EventArgs e)
		{
			txtFibAwait.Text = (await NewtonAwait((int) numN.Value, (int) numK.Value)).ToString();
		}

		private void btnFib_Click(object sender, EventArgs e)
		{
			bwFib.RunWorkerAsync((int) numFib.Value);
		}

		private void btnCompress_Click(object sender, EventArgs e)
		{
			if(dlgFolderBrowser.ShowDialog() == DialogResult.OK)
			{
				var dir = new DirectoryInfo(dlgFolderBrowser.SelectedPath);
				var dirComp = dir.CreateSubdirectory("compressed");
				var tasks = new List<Task>();
				foreach(var item in dir.EnumerateFiles())
				{
					tasks.Add(Task.Factory.StartNew(() =>
					{
						using (Stream fileToCompress = item.OpenRead())
						using (Stream compressedFile = File.Create(Path.Combine(dirComp.FullName, item.Name) + ".gz"))
						using (GZipStream gzip = new GZipStream(compressedFile, CompressionMode.Compress))
						{
							fileToCompress.CopyTo(gzip);
						}
					}));
				}

				foreach(var item in tasks)
				{
					item.Wait();
				}

				MessageBox.Show("Compression finished successfully", "Lab 5", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private void btnDecompress_Click(object sender, EventArgs e)
		{
			if(dlgFileBrowser.ShowDialog() == DialogResult.OK)
			{
				var file = new FileInfo(dlgFileBrowser.FileName);
				using (Stream fileToDecompress = file.OpenRead())
				using (GZipStream gzip = new GZipStream(fileToDecompress, CompressionMode.Decompress))
				using (Stream decompressedFile = File.Create(file.FullName.Substring(0, file.FullName.Length - 3)))
				{
					gzip.CopyTo(decompressedFile);
				}

				MessageBox.Show("Decompression finished successfully", "Lab 5", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private void btnResolve_Click(object sender, EventArgs e)
		{
			string[] hostNames = { "www.microsoft.com", "www.apple.com",
				"www.google.com", "www.ibm.com", "cisco.netacad.net",
				"www.oracle.com", "www.nokia.com", "www.hp.com", "www.dell.com",
				"www.samsung.com", "www.toshiba.com", "www.siemens.com",
				"www.amazon.com", "www.sony.com", "www.canon.com",
				"www.alcatel-lucent.com", "www.acer.com", "www.motorola.com" };

			txtDNS.Text = "";
			hostNames
				.AsParallel()
				.ForAll(x =>
				{
					string result = x + " => " + Dns.GetHostAddresses(x).Last().ToString() + "\r\n";
					txtDNS.Invoke(new Action(() => txtDNS.Text += result));
				});
		}
		#endregion

		private void bwFib_DoWork(object sender, DoWorkEventArgs e)
		{
			int f0 = 0;
			int f1 = 1;

			int arg = (int) e.Argument;
			switch (arg)
			{
				case 0:
				case 1:
					e.Result = arg;
					bwFib.ReportProgress(100);
					break;

				default:
				{
					bwFib.ReportProgress(0);
					int result = 0;
					float percent = 100.0F / arg;
					float progress = percent;
					for(int i = 2; i <= arg; ++i)
					{
						result = f1 + f0;
						f0 = f1;
						f1 = result;

						System.Threading.Thread.Sleep(20);
						progress += percent;
						bwFib.ReportProgress((int)(progress));
					}
					e.Result = result;
					break;
				}
			}
		}

		private void bwFib_ProgressChanged(object sender, ProgressChangedEventArgs e)
		{
			pbFib.Value = e.ProgressPercentage;
		}

		private void bwFib_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			txtFibResult.Text = ((int) e.Result).ToString();
		}
	}
}
