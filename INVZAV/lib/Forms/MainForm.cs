using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

using INVZAV.lib.Classes;

namespace INVZAV.lib.Forms
{
	public partial class MainForm : Form
	{
		private const string settingsFileName = "settings.json";
		private Dictionary<string, string> settings = [];
		private const string spaceBeforeSettingName = "spaceBefore";
		private const string spaceAfterSettingName = "spaceAfter";
		public MainForm()
		{
			InitializeComponent();
			TopMostToolStripMenuItem.Checked = true;
			this.TopMost = true;
			if (File.Exists(settingsFileName))
			{
				settings = Json.ReadFile<Dictionary<string, string>>(Path.Combine(".", settingsFileName));
				if (settings.TryGetValue(spaceBeforeSettingName, out string? value) && value.ToLower().Equals("true")) addSpaceBeforeToolStripMenuItem.Checked = true;
				if (settings.TryGetValue(spaceAfterSettingName, out value) && value.ToLower().Equals("true")) addSpaceAfterToolStripMenuItem.Checked = true;
			}
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
			outputBox.Text = CellsConverter.AutoINVZAV(inputBox.Text);
			outputBox_TextChanged(sender, e);
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
		private void OutputBoxSetSpaces() => outputBox.Text = $"{(addSpaceBeforeToolStripMenuItem.Checked ? " " : "")}{outputBox.Text.Trim()}{(addSpaceAfterToolStripMenuItem.Checked ? " " : "")}";
		private void MainForm_Shown(object sender, EventArgs e) => InputBox_TextChanged(sender, e);

		private void ExitToolStripMenuItem_Click(object sender, EventArgs e) => Application.Exit();
		private void MainForm_FormClosed(object sender, FormClosedEventArgs e) => Application.Exit();

		private void addSpaceBeforeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			addSpaceBeforeToolStripMenuItem.Checked = !addSpaceBeforeToolStripMenuItem.Checked;
			outputBox_TextChanged(sender, e);
		}

		private void addSpaceAfterToolStripMenuItem_Click(object sender, EventArgs e)
		{
			addSpaceAfterToolStripMenuItem.Checked = !addSpaceAfterToolStripMenuItem.Checked;
			outputBox_TextChanged(sender, e);
		}

		private void outputBox_TextChanged(object sender, EventArgs e) => OutputBoxSetSpaces();

		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			settings = new Dictionary<string, string> 
			{
				{ spaceBeforeSettingName, addSpaceBeforeToolStripMenuItem.Checked.ToString() },
				{ spaceAfterSettingName, addSpaceAfterToolStripMenuItem.Checked.ToString() }
			};
			Json.RewriteFile(Path.Combine(".", settingsFileName), settings);
		}
	}
}
