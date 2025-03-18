using System;
using System.Windows.Forms;

namespace INVZAV.lib.Forms
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
			TopMostToolStripMenuItem.Checked = true;
			this.TopMost = true;
		}

		private void TopMostToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.TopMost = !this.TopMost;
			TopMostToolStripMenuItem.Checked = !TopMostToolStripMenuItem.Checked;
		}
		private void ChooseBackgroundColorToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (colorDialog1.ShowDialog() == DialogResult.OK)
			{
				this.BackColor = colorDialog1.Color;
			}
		}

		private void ExitToolStripMenuItem_Click(object sender, EventArgs e) => Application.Exit();
		private void MainForm_FormClosed(object sender, FormClosedEventArgs e) => Application.Exit();
	}
}
