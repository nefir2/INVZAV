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
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			tableLayoutPanel1 = new TableLayoutPanel();
			outputBox = new RichTextBox();
			tableLayoutPanel2 = new TableLayoutPanel();
			convertAndCopy = new Button();
			convert = new Button();
			tableLayoutPanel3 = new TableLayoutPanel();
			label1 = new Label();
			inputBox = new TextBox();
			tableLayoutPanel4 = new TableLayoutPanel();
			button1 = new Button();
			copySelectedButton = new Button();
			menuStrip1 = new MenuStrip();
			программаToolStripMenuItem = new ToolStripMenuItem();
			TopMostToolStripMenuItem = new ToolStripMenuItem();
			ExitToolStripMenuItem = new ToolStripMenuItem();
			вставкаToolStripMenuItem = new ToolStripMenuItem();
			inclipAndOutclipToolStripMenuItem = new ToolStripMenuItem();
			inclipToolStripMenuItem1 = new ToolStripMenuItem();
			внешнийВидToolStripMenuItem = new ToolStripMenuItem();
			backGroundColorToolStripMenuItem = new ToolStripMenuItem();
			chooseBackGroundColorToolStripMenuItem = new ToolStripMenuItem();
			colorDialog1 = new ColorDialog();
			statusStrip1 = new StatusStrip();
			toolStripStatusLabel1 = new ToolStripStatusLabel();
			timer1 = new Timer(components);
			tableLayoutPanel1.SuspendLayout();
			tableLayoutPanel2.SuspendLayout();
			tableLayoutPanel3.SuspendLayout();
			tableLayoutPanel4.SuspendLayout();
			menuStrip1.SuspendLayout();
			statusStrip1.SuspendLayout();
			SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			tableLayoutPanel1.ColumnCount = 4;
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
			tableLayoutPanel1.Controls.Add(outputBox, 2, 0);
			tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 1);
			tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 0);
			tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 3, 1);
			tableLayoutPanel1.Dock = DockStyle.Fill;
			tableLayoutPanel1.Location = new Point(0, 24);
			tableLayoutPanel1.Name = "tableLayoutPanel1";
			tableLayoutPanel1.RowCount = 2;
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tableLayoutPanel1.Size = new Size(665, 157);
			tableLayoutPanel1.TabIndex = 0;
			// 
			// outputBox
			// 
			tableLayoutPanel1.SetColumnSpan(outputBox, 2);
			outputBox.Dock = DockStyle.Fill;
			outputBox.Location = new Point(335, 3);
			outputBox.Multiline = false;
			outputBox.Name = "outputBox";
			outputBox.ReadOnly = true;
			outputBox.Size = new Size(327, 72);
			outputBox.TabIndex = 3;
			outputBox.Text = "";
			outputBox.MouseDoubleClick += outputBox_MouseDoubleClick;
			// 
			// tableLayoutPanel2
			// 
			tableLayoutPanel2.ColumnCount = 1;
			tableLayoutPanel1.SetColumnSpan(tableLayoutPanel2, 2);
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanel2.Controls.Add(convertAndCopy, 0, 0);
			tableLayoutPanel2.Controls.Add(convert, 0, 1);
			tableLayoutPanel2.Dock = DockStyle.Fill;
			tableLayoutPanel2.Location = new Point(169, 81);
			tableLayoutPanel2.Name = "tableLayoutPanel2";
			tableLayoutPanel2.RowCount = 2;
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tableLayoutPanel2.Size = new Size(326, 73);
			tableLayoutPanel2.TabIndex = 3;
			// 
			// convertAndCopy
			// 
			convertAndCopy.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			convertAndCopy.BackColor = Color.FromArgb(64, 0, 64);
			convertAndCopy.Dock = DockStyle.Fill;
			convertAndCopy.FlatStyle = FlatStyle.Popup;
			convertAndCopy.ForeColor = Color.White;
			convertAndCopy.Location = new Point(3, 3);
			convertAndCopy.Name = "convertAndCopy";
			convertAndCopy.Size = new Size(320, 30);
			convertAndCopy.TabIndex = 1;
			convertAndCopy.Text = "преобразовать из буфера обмена и скопировать";
			convertAndCopy.UseVisualStyleBackColor = false;
			convertAndCopy.Click += inclipAndOutclipToolStripMenuItem_Click;
			// 
			// convert
			// 
			convert.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			convert.BackColor = Color.LavenderBlush;
			convert.Dock = DockStyle.Fill;
			convert.FlatStyle = FlatStyle.Popup;
			convert.ForeColor = Color.Black;
			convert.Location = new Point(3, 39);
			convert.Name = "convert";
			convert.Size = new Size(320, 31);
			convert.TabIndex = 2;
			convert.Text = "вставить из буфера обмена";
			convert.UseVisualStyleBackColor = false;
			convert.Click += inclipToolStripMenuItem1_Click;
			// 
			// tableLayoutPanel3
			// 
			tableLayoutPanel3.ColumnCount = 1;
			tableLayoutPanel1.SetColumnSpan(tableLayoutPanel3, 2);
			tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanel3.Controls.Add(label1, 0, 0);
			tableLayoutPanel3.Controls.Add(inputBox, 0, 1);
			tableLayoutPanel3.Dock = DockStyle.Fill;
			tableLayoutPanel3.Location = new Point(3, 3);
			tableLayoutPanel3.Name = "tableLayoutPanel3";
			tableLayoutPanel3.RowCount = 2;
			tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tableLayoutPanel3.Size = new Size(326, 72);
			tableLayoutPanel3.TabIndex = 4;
			// 
			// label1
			// 
			label1.Anchor = AnchorStyles.Bottom;
			label1.AutoSize = true;
			label1.ForeColor = Color.FromArgb(64, 0, 64);
			label1.Location = new Point(3, 6);
			label1.Name = "label1";
			label1.Size = new Size(320, 30);
			label1.TabIndex = 1;
			label1.Text = "воспользуйтесь кнопками ниже, меню-кнопками выше, или вставьте текст сюда:";
			label1.TextAlign = ContentAlignment.BottomCenter;
			// 
			// inputBox
			// 
			inputBox.AllowDrop = true;
			inputBox.Dock = DockStyle.Top;
			inputBox.Location = new Point(3, 39);
			inputBox.Name = "inputBox";
			inputBox.Size = new Size(320, 23);
			inputBox.TabIndex = 0;
			inputBox.WordWrap = false;
			inputBox.TextChanged += InputBox_TextChanged;
			// 
			// tableLayoutPanel4
			// 
			tableLayoutPanel4.ColumnCount = 1;
			tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanel4.Controls.Add(button1, 0, 0);
			tableLayoutPanel4.Controls.Add(copySelectedButton, 0, 1);
			tableLayoutPanel4.Dock = DockStyle.Fill;
			tableLayoutPanel4.Location = new Point(501, 81);
			tableLayoutPanel4.Name = "tableLayoutPanel4";
			tableLayoutPanel4.RowCount = 2;
			tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tableLayoutPanel4.Size = new Size(161, 73);
			tableLayoutPanel4.TabIndex = 6;
			// 
			// button1
			// 
			button1.BackColor = Color.FromArgb(64, 0, 64);
			button1.Dock = DockStyle.Fill;
			button1.FlatStyle = FlatStyle.Popup;
			button1.ForeColor = Color.Transparent;
			button1.Location = new Point(3, 3);
			button1.Name = "button1";
			button1.Size = new Size(155, 30);
			button1.TabIndex = 6;
			button1.Text = "скопировать всё";
			button1.UseVisualStyleBackColor = false;
			button1.Click += button1_Click;
			// 
			// copySelectedButton
			// 
			copySelectedButton.BackColor = Color.FromArgb(222, 184, 228);
			copySelectedButton.Dock = DockStyle.Fill;
			copySelectedButton.FlatStyle = FlatStyle.Popup;
			copySelectedButton.ForeColor = Color.Black;
			copySelectedButton.Location = new Point(3, 39);
			copySelectedButton.Name = "copySelectedButton";
			copySelectedButton.Size = new Size(155, 31);
			copySelectedButton.TabIndex = 5;
			copySelectedButton.Text = "скопировать выделенное";
			copySelectedButton.UseVisualStyleBackColor = false;
			copySelectedButton.Click += copySelectedButton_Click;
			// 
			// menuStrip1
			// 
			menuStrip1.BackColor = Color.FromArgb(250, 218, 235);
			menuStrip1.Items.AddRange(new ToolStripItem[] { программаToolStripMenuItem, вставкаToolStripMenuItem, внешнийВидToolStripMenuItem });
			menuStrip1.Location = new Point(0, 0);
			menuStrip1.Name = "menuStrip1";
			menuStrip1.Size = new Size(665, 24);
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
			// вставкаToolStripMenuItem
			// 
			вставкаToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { inclipAndOutclipToolStripMenuItem, inclipToolStripMenuItem1 });
			вставкаToolStripMenuItem.Name = "вставкаToolStripMenuItem";
			вставкаToolStripMenuItem.Size = new Size(60, 20);
			вставкаToolStripMenuItem.Text = "вставка";
			// 
			// inclipAndOutclipToolStripMenuItem
			// 
			inclipAndOutclipToolStripMenuItem.Name = "inclipAndOutclipToolStripMenuItem";
			inclipAndOutclipToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.V;
			inclipAndOutclipToolStripMenuItem.Size = new Size(277, 22);
			inclipAndOutclipToolStripMenuItem.Text = "вставить и скопировать";
			inclipAndOutclipToolStripMenuItem.Click += inclipAndOutclipToolStripMenuItem_Click;
			// 
			// inclipToolStripMenuItem1
			// 
			inclipToolStripMenuItem1.Name = "inclipToolStripMenuItem1";
			inclipToolStripMenuItem1.ShortcutKeys = Keys.Control | Keys.V;
			inclipToolStripMenuItem1.Size = new Size(277, 22);
			inclipToolStripMenuItem1.Text = "вставить";
			inclipToolStripMenuItem1.Click += inclipToolStripMenuItem1_Click;
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
			backGroundColorToolStripMenuItem.Size = new Size(130, 22);
			backGroundColorToolStripMenuItem.Text = "цвет фона";
			// 
			// chooseBackGroundColorToolStripMenuItem
			// 
			chooseBackGroundColorToolStripMenuItem.Name = "chooseBackGroundColorToolStripMenuItem";
			chooseBackGroundColorToolStripMenuItem.Size = new Size(158, 22);
			chooseBackGroundColorToolStripMenuItem.Text = "выбрать свой...";
			chooseBackGroundColorToolStripMenuItem.Click += ChooseBackgroundColorToolStripMenuItem_Click;
			// 
			// statusStrip1
			// 
			statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
			statusStrip1.Location = new Point(0, 153);
			statusStrip1.Name = "statusStrip1";
			statusStrip1.Size = new Size(620, 22);
			statusStrip1.TabIndex = 2;
			statusStrip1.Text = "statusStrip1";
			statusStrip1.Visible = false;
			// 
			// toolStripStatusLabel1
			// 
			toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			toolStripStatusLabel1.Size = new Size(118, 17);
			toolStripStatusLabel1.Text = "toolStripStatusLabel1";
			// 
			// MainForm
			// 
			AcceptButton = convertAndCopy;
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(234, 170, 207);
			ClientSize = new Size(665, 181);
			Controls.Add(statusStrip1);
			Controls.Add(tableLayoutPanel1);
			Controls.Add(menuStrip1);
			Icon = (Icon)resources.GetObject("$this.Icon");
			MainMenuStrip = menuStrip1;
			MaximizeBox = false;
			Name = "MainForm";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "преобразователь клеток с номерами в текст инв. зав.";
			TopMost = true;
			FormClosed += MainForm_FormClosed;
			Shown += MainForm_Shown;
			tableLayoutPanel1.ResumeLayout(false);
			tableLayoutPanel2.ResumeLayout(false);
			tableLayoutPanel3.ResumeLayout(false);
			tableLayoutPanel3.PerformLayout();
			tableLayoutPanel4.ResumeLayout(false);
			menuStrip1.ResumeLayout(false);
			menuStrip1.PerformLayout();
			statusStrip1.ResumeLayout(false);
			statusStrip1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TableLayoutPanel tableLayoutPanel1;
		private TextBox inputBox;
		private Button convertAndCopy;
		private MenuStrip menuStrip1;
		private ToolStripMenuItem программаToolStripMenuItem;
		private ToolStripMenuItem TopMostToolStripMenuItem;
		private ToolStripMenuItem ExitToolStripMenuItem;
		private ToolStripMenuItem внешнийВидToolStripMenuItem;
		private ToolStripMenuItem backGroundColorToolStripMenuItem;
		private ToolStripMenuItem chooseBackGroundColorToolStripMenuItem;
		private ColorDialog colorDialog1;
		private RichTextBox outputBox;
		private TableLayoutPanel tableLayoutPanel2;
		private Button convert;
		private TableLayoutPanel tableLayoutPanel3;
		private Label label1;
		private ToolStripMenuItem вставкаToolStripMenuItem;
		private ToolStripMenuItem inclipAndOutclipToolStripMenuItem;
		private ToolStripMenuItem inclipToolStripMenuItem1;
		private StatusStrip statusStrip1;
		private ToolStripStatusLabel toolStripStatusLabel1;
		private Timer timer1;
		private Button copySelectedButton;
		private TableLayoutPanel tableLayoutPanel4;
		private Button button1;
	}
}
