using System.Drawing;
using System.Windows.Forms;

namespace INVZAV.lib.Forms
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			tableLayoutPanel1 = new TableLayoutPanel();
			InputBox = new TextBox();
			button1 = new Button();
			menuStrip1 = new MenuStrip();
			программаToolStripMenuItem = new ToolStripMenuItem();
			TopMostToolStripMenuItem = new ToolStripMenuItem();
			ExitToolStripMenuItem = new ToolStripMenuItem();
			внешнийВидToolStripMenuItem = new ToolStripMenuItem();
			backGroundColorToolStripMenuItem = new ToolStripMenuItem();
			chooseBackGroundColorToolStripMenuItem = new ToolStripMenuItem();
			colorDialog1 = new ColorDialog();
			tableLayoutPanel1.SuspendLayout();
			menuStrip1.SuspendLayout();
			SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			tableLayoutPanel1.ColumnCount = 3;
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
			tableLayoutPanel1.Controls.Add(InputBox, 0, 0);
			tableLayoutPanel1.Controls.Add(button1, 1, 1);
			tableLayoutPanel1.Dock = DockStyle.Fill;
			tableLayoutPanel1.Location = new Point(0, 24);
			tableLayoutPanel1.Name = "tableLayoutPanel1";
			tableLayoutPanel1.RowCount = 2;
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tableLayoutPanel1.Size = new Size(438, 109);
			tableLayoutPanel1.TabIndex = 0;
			// 
			// InputBox
			// 
			InputBox.AllowDrop = true;
			InputBox.Anchor = AnchorStyles.Right;
			InputBox.Location = new Point(3, 15);
			InputBox.Name = "InputBox";
			InputBox.Size = new Size(139, 23);
			InputBox.TabIndex = 0;
			// 
			// button1
			// 
			button1.Anchor = AnchorStyles.None;
			button1.AutoSize = true;
			button1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			button1.Location = new Point(188, 69);
			button1.Name = "button1";
			button1.Size = new Size(59, 25);
			button1.TabIndex = 1;
			button1.Text = "button1";
			button1.UseVisualStyleBackColor = true;
			// 
			// menuStrip1
			// 
			menuStrip1.BackColor = Color.Transparent;
			menuStrip1.Items.AddRange(new ToolStripItem[] { программаToolStripMenuItem, внешнийВидToolStripMenuItem });
			menuStrip1.Location = new Point(0, 0);
			menuStrip1.Name = "menuStrip1";
			menuStrip1.Size = new Size(438, 24);
			menuStrip1.TabIndex = 1;
			menuStrip1.Text = "menuStrip1";
			// 
			// программаToolStripMenuItem
			// 
			программаToolStripMenuItem.BackColor = Color.Transparent;
			программаToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { TopMostToolStripMenuItem, ExitToolStripMenuItem });
			программаToolStripMenuItem.Name = "программаToolStripMenuItem";
			программаToolStripMenuItem.Size = new Size(84, 20);
			программаToolStripMenuItem.Text = "Программа";
			// 
			// TopMostToolStripMenuItem
			// 
			TopMostToolStripMenuItem.Name = "TopMostToolStripMenuItem";
			TopMostToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.T;
			TopMostToolStripMenuItem.Size = new Size(210, 22);
			TopMostToolStripMenuItem.Text = "поверх всех окон";
			TopMostToolStripMenuItem.Click += TopMostToolStripMenuItem_Click;
			// 
			// ExitToolStripMenuItem
			// 
			ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
			ExitToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Q;
			ExitToolStripMenuItem.Size = new Size(210, 22);
			ExitToolStripMenuItem.Text = "выход";
			ExitToolStripMenuItem.Click += ExitToolStripMenuItem_Click;
			// 
			// внешнийВидToolStripMenuItem
			// 
			внешнийВидToolStripMenuItem.BackColor = Color.Transparent;
			внешнийВидToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { backGroundColorToolStripMenuItem });
			внешнийВидToolStripMenuItem.Enabled = false;
			внешнийВидToolStripMenuItem.Name = "внешнийВидToolStripMenuItem";
			внешнийВидToolStripMenuItem.Size = new Size(92, 20);
			внешнийВидToolStripMenuItem.Text = "внешний вид";
			внешнийВидToolStripMenuItem.Visible = false;
			// 
			// backGroundColorToolStripMenuItem
			// 
			backGroundColorToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { chooseBackGroundColorToolStripMenuItem });
			backGroundColorToolStripMenuItem.Name = "backGroundColorToolStripMenuItem";
			backGroundColorToolStripMenuItem.Size = new Size(180, 22);
			backGroundColorToolStripMenuItem.Text = "цвет фона";
			// 
			// chooseBackGroundColorToolStripMenuItem
			// 
			chooseBackGroundColorToolStripMenuItem.Name = "chooseBackGroundColorToolStripMenuItem";
			chooseBackGroundColorToolStripMenuItem.Size = new Size(158, 22);
			chooseBackGroundColorToolStripMenuItem.Text = "выбрать свой...";
			chooseBackGroundColorToolStripMenuItem.Click += ChooseBackgroundColorToolStripMenuItem_Click;
			// 
			// MainForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(234, 170, 207);
			ClientSize = new Size(438, 133);
			Controls.Add(tableLayoutPanel1);
			Controls.Add(menuStrip1);
			MainMenuStrip = menuStrip1;
			Name = "MainForm";
			Text = "преобразователь клеток с номерами в текст инв. зав.";
			TopMost = true;
			FormClosed += MainForm_FormClosed;
			tableLayoutPanel1.ResumeLayout(false);
			tableLayoutPanel1.PerformLayout();
			menuStrip1.ResumeLayout(false);
			menuStrip1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TableLayoutPanel tableLayoutPanel1;
		private TextBox InputBox;
		private Button button1;
		private MenuStrip menuStrip1;
		private ToolStripMenuItem программаToolStripMenuItem;
		private ToolStripMenuItem TopMostToolStripMenuItem;
		private ToolStripMenuItem ExitToolStripMenuItem;
		private ToolStripMenuItem внешнийВидToolStripMenuItem;
		private ToolStripMenuItem backGroundColorToolStripMenuItem;
		private ToolStripMenuItem chooseBackGroundColorToolStripMenuItem;
		private ColorDialog colorDialog1;
	}
}
