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
		private const string topMostSettingName = "topMost";
		public MainForm()
		{
			InitializeComponent();
			this.TopMost = true;
			if (File.Exists(settingsFileName))
			{
				settings = Json.ReadFile<Dictionary<string, string>>(Path.Combine(".", settingsFileName));
				if (settings.TryGetValue(spaceBeforeSettingName, out string? value) && value.ToLower().Equals("true")) addSpaceBeforeToolStripMenuItem.Checked = true;
				else addSpaceBeforeToolStripMenuItem.Checked = false;
				if (settings.TryGetValue(spaceAfterSettingName, out value) && value.ToLower().Equals("true")) addSpaceAfterToolStripMenuItem.Checked = true;
				else addSpaceAfterToolStripMenuItem.Checked = false;
				if (settings.TryGetValue(topMostSettingName, out value) && value.ToLower().Equals("true")) this.TopMost = true;
				else this.TopMost = false;
			}
			TopMostToolStripMenuItem.Checked = this.TopMost;
		}

		private void TopMostToolStripMenuItem_Click(object sender, EventArgs e)
		{
			TopMostToolStripMenuItem.Checked = !TopMostToolStripMenuItem.Checked;
			this.TopMost = TopMostToolStripMenuItem.Checked;
		}
		private void ChooseBackgroundColorToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (colorDialog1.ShowDialog() == DialogResult.OK)
			{
				this.BackColor = colorDialog1.Color;
			}
		}
		private void InputBox_TextChanged(object sender, EventArgs e) => outputBox.Text = CellsConverter.AutoINVZAVWithoutTypeFetching(inputBox.Text);
		private void inclipToolStripMenuItem1_Click(object sender, EventArgs e) => inputBox.Text = Clipboard.GetText();
		private void inclipAndOutclipToolStripMenuItem_Click(object sender, EventArgs e)
		{
			inputBox.Text = Clipboard.GetText();
			outputBox.Text = CellsConverter.AutoINVZAVWithoutTypeFetching(inputBox.Text);
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
				{ spaceAfterSettingName, addSpaceAfterToolStripMenuItem.Checked.ToString() },
				{ topMostSettingName, this.TopMost.ToString() }
			};
			Json.RewriteFile(Path.Combine(".", settingsFileName), settings);
		}
	}
}
