using System;
using System.Windows.Forms;

using INVZAV.lib.Classes;

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
		private void InputBox_TextChanged(object sender, EventArgs e) => outputBox.Text = CellsConverter.AutoINVZAV(inputBox.Text);
		private void inclipToolStripMenuItem1_Click(object sender, EventArgs e) => inputBox.Text = Clipboard.GetText();
		private void inclipAndOutclipToolStripMenuItem_Click(object sender, EventArgs e)
		{
			inputBox.Text = Clipboard.GetText();
			string invzav = CellsConverter.AutoINVZAV(inputBox.Text);
			outputBox.Text = invzav;
			Clipboard.SetText(outputBox.Text);
		}
		private void outputBox_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			outputBox.SelectAll();
			Clipboard.SetText(outputBox.SelectedText);
		}
		private void copySelectedButton_Click(object sender, EventArgs e)
		{
			if (outputBox.SelectedText.Length == 0) return;
			Clipboard.SetText(outputBox.SelectedText);
			outputBox.Focus();
		}
		private void button1_Click(object sender, EventArgs e)
		{
			outputBox.SelectAll();
			if (outputBox.SelectedText.Length == 0) return;
			Clipboard.SetText(outputBox.SelectedText);
			outputBox.Focus();
		}
		private void MainForm_Shown(object sender, EventArgs e) => InputBox_TextChanged(sender, e);

		private void ExitToolStripMenuItem_Click(object sender, EventArgs e) => Application.Exit();
		private void MainForm_FormClosed(object sender, FormClosedEventArgs e) => Application.Exit();
	}
}
