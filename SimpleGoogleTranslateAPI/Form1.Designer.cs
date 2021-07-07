
namespace SimpleGoogleTranslateAPI
{
	partial class Form1
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
			this.components = new System.ComponentModel.Container();
			this.tableParent = new System.Windows.Forms.TableLayoutPanel();
			this.label1 = new System.Windows.Forms.Label();
			this.tableColumn = new System.Windows.Forms.TableLayoutPanel();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.tableRight = new System.Windows.Forms.TableLayoutPanel();
			this.tbxDest = new System.Windows.Forms.TextBox();
			this.cbxDestLang = new System.Windows.Forms.ComboBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.tableLeft = new System.Windows.Forms.TableLayoutPanel();
			this.cbxSourceLang = new System.Windows.Forms.ComboBox();
			this.tbxSource = new System.Windows.Forms.TextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnClear = new System.Windows.Forms.Button();
			this.btnSwap = new System.Windows.Forms.Button();
			this.btnTranslate = new System.Windows.Forms.Button();
			this.cbxAutoTranslate = new System.Windows.Forms.CheckBox();
			this.statusStrip = new System.Windows.Forms.StatusStrip();
			this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
			this.timerAutoTranslate = new System.Windows.Forms.Timer(this.components);
			this.tableParent.SuspendLayout();
			this.tableColumn.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.tableRight.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.tableLeft.SuspendLayout();
			this.panel1.SuspendLayout();
			this.statusStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableParent
			// 
			this.tableParent.ColumnCount = 1;
			this.tableParent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableParent.Controls.Add(this.label1, 0, 0);
			this.tableParent.Controls.Add(this.tableColumn, 0, 1);
			this.tableParent.Controls.Add(this.statusStrip, 0, 2);
			this.tableParent.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableParent.Location = new System.Drawing.Point(0, 0);
			this.tableParent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.tableParent.Name = "tableParent";
			this.tableParent.RowCount = 3;
			this.tableParent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.tableParent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableParent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
			this.tableParent.Size = new System.Drawing.Size(894, 491);
			this.tableParent.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label1.ForeColor = System.Drawing.Color.Salmon;
			this.label1.Location = new System.Drawing.Point(3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(888, 40);
			this.label1.TabIndex = 0;
			this.label1.Text = "GOOGLE TRANSLATE API";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tableColumn
			// 
			this.tableColumn.ColumnCount = 3;
			this.tableColumn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
			this.tableColumn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableColumn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
			this.tableColumn.Controls.Add(this.groupBox1, 2, 0);
			this.tableColumn.Controls.Add(this.groupBox2, 0, 0);
			this.tableColumn.Controls.Add(this.panel1, 1, 0);
			this.tableColumn.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableColumn.Location = new System.Drawing.Point(3, 43);
			this.tableColumn.Name = "tableColumn";
			this.tableColumn.RowCount = 1;
			this.tableColumn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableColumn.Size = new System.Drawing.Size(888, 423);
			this.tableColumn.TabIndex = 1;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.tableRight);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox1.Location = new System.Drawing.Point(535, 3);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(350, 417);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Ngôn ngữ đích";
			// 
			// tableRight
			// 
			this.tableRight.ColumnCount = 1;
			this.tableRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableRight.Controls.Add(this.tbxDest, 0, 1);
			this.tableRight.Controls.Add(this.cbxDestLang, 0, 0);
			this.tableRight.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableRight.Location = new System.Drawing.Point(3, 23);
			this.tableRight.Name = "tableRight";
			this.tableRight.RowCount = 2;
			this.tableRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableRight.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableRight.Size = new System.Drawing.Size(344, 391);
			this.tableRight.TabIndex = 1;
			// 
			// tbxDest
			// 
			this.tbxDest.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tbxDest.Location = new System.Drawing.Point(3, 33);
			this.tbxDest.Multiline = true;
			this.tbxDest.Name = "tbxDest";
			this.tbxDest.ReadOnly = true;
			this.tbxDest.Size = new System.Drawing.Size(338, 357);
			this.tbxDest.TabIndex = 8;
			// 
			// cbxDestLang
			// 
			this.cbxDestLang.DisplayMember = "DisplayName";
			this.cbxDestLang.Dock = System.Windows.Forms.DockStyle.Fill;
			this.cbxDestLang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxDestLang.FormattingEnabled = true;
			this.cbxDestLang.Location = new System.Drawing.Point(3, 3);
			this.cbxDestLang.Name = "cbxDestLang";
			this.cbxDestLang.Size = new System.Drawing.Size(338, 28);
			this.cbxDestLang.TabIndex = 7;
			this.cbxDestLang.ValueMember = "ISO639_1Name";
			this.cbxDestLang.SelectedIndexChanged += new System.EventHandler(this.cbxDestLang_SelectedIndexChanged);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.tableLeft);
			this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox2.Location = new System.Drawing.Point(3, 3);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(349, 417);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Ngôn ngữ nguồn";
			// 
			// tableLeft
			// 
			this.tableLeft.ColumnCount = 1;
			this.tableLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLeft.Controls.Add(this.cbxSourceLang, 0, 0);
			this.tableLeft.Controls.Add(this.tbxSource, 0, 1);
			this.tableLeft.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLeft.Location = new System.Drawing.Point(3, 23);
			this.tableLeft.Name = "tableLeft";
			this.tableLeft.RowCount = 2;
			this.tableLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLeft.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLeft.Size = new System.Drawing.Size(343, 391);
			this.tableLeft.TabIndex = 0;
			// 
			// cbxSourceLang
			// 
			this.cbxSourceLang.DisplayMember = "DisplayName";
			this.cbxSourceLang.Dock = System.Windows.Forms.DockStyle.Fill;
			this.cbxSourceLang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxSourceLang.FormattingEnabled = true;
			this.cbxSourceLang.Location = new System.Drawing.Point(3, 3);
			this.cbxSourceLang.Name = "cbxSourceLang";
			this.cbxSourceLang.Size = new System.Drawing.Size(337, 28);
			this.cbxSourceLang.TabIndex = 1;
			this.cbxSourceLang.ValueMember = "ISO639_1Name";
			this.cbxSourceLang.SelectedIndexChanged += new System.EventHandler(this.cbxSourceLang_SelectedIndexChanged);
			// 
			// tbxSource
			// 
			this.tbxSource.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tbxSource.Location = new System.Drawing.Point(3, 33);
			this.tbxSource.Multiline = true;
			this.tbxSource.Name = "tbxSource";
			this.tbxSource.Size = new System.Drawing.Size(337, 357);
			this.tbxSource.TabIndex = 2;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btnClear);
			this.panel1.Controls.Add(this.btnSwap);
			this.panel1.Controls.Add(this.btnTranslate);
			this.panel1.Controls.Add(this.cbxAutoTranslate);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(358, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(171, 417);
			this.panel1.TabIndex = 2;
			// 
			// btnClear
			// 
			this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClear.Location = new System.Drawing.Point(20, 261);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(137, 45);
			this.btnClear.TabIndex = 6;
			this.btnClear.Text = "&Xóa (Esc)";
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// btnSwap
			// 
			this.btnSwap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSwap.Location = new System.Drawing.Point(20, 192);
			this.btnSwap.Name = "btnSwap";
			this.btnSwap.Size = new System.Drawing.Size(137, 45);
			this.btnSwap.TabIndex = 5;
			this.btnSwap.Text = "&Hoán đổi";
			this.btnSwap.UseVisualStyleBackColor = true;
			this.btnSwap.Click += new System.EventHandler(this.btnSwap_Click);
			// 
			// btnTranslate
			// 
			this.btnTranslate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.btnTranslate.Location = new System.Drawing.Point(20, 121);
			this.btnTranslate.Name = "btnTranslate";
			this.btnTranslate.Size = new System.Drawing.Size(137, 45);
			this.btnTranslate.TabIndex = 4;
			this.btnTranslate.Text = "&Dịch";
			this.btnTranslate.UseVisualStyleBackColor = true;
			this.btnTranslate.Click += new System.EventHandler(this.btnTranslate_Click);
			// 
			// cbxAutoTranslate
			// 
			this.cbxAutoTranslate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.cbxAutoTranslate.AutoSize = true;
			this.cbxAutoTranslate.Location = new System.Drawing.Point(20, 91);
			this.cbxAutoTranslate.Name = "cbxAutoTranslate";
			this.cbxAutoTranslate.Size = new System.Drawing.Size(116, 24);
			this.cbxAutoTranslate.TabIndex = 3;
			this.cbxAutoTranslate.Text = "Tự động dịch";
			this.cbxAutoTranslate.UseVisualStyleBackColor = true;
			this.cbxAutoTranslate.CheckedChanged += new System.EventHandler(this.cbxAutoTranslate_CheckedChanged);
			// 
			// statusStrip
			// 
			this.statusStrip.Dock = System.Windows.Forms.DockStyle.Fill;
			this.statusStrip.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
			this.statusStrip.Location = new System.Drawing.Point(0, 469);
			this.statusStrip.Name = "statusStrip";
			this.statusStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.statusStrip.Size = new System.Drawing.Size(894, 22);
			this.statusStrip.TabIndex = 2;
			this.statusStrip.Text = "statusStrip1";
			// 
			// lblStatus
			// 
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new System.Drawing.Size(0, 17);
			// 
			// timerAutoTranslate
			// 
			this.timerAutoTranslate.Interval = 1500;
			this.timerAutoTranslate.Tick += new System.EventHandler(this.timerAutoTranslate_Tick);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnClear;
			this.ClientSize = new System.Drawing.Size(894, 491);
			this.Controls.Add(this.tableParent);
			this.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "Form1";
			this.Text = "Google Translate API";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.tableParent.ResumeLayout(false);
			this.tableParent.PerformLayout();
			this.tableColumn.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.tableRight.ResumeLayout(false);
			this.tableRight.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.tableLeft.ResumeLayout(false);
			this.tableLeft.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.statusStrip.ResumeLayout(false);
			this.statusStrip.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableParent;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TableLayoutPanel tableColumn;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TableLayoutPanel tableRight;
		private System.Windows.Forms.TextBox tbxDest;
		private System.Windows.Forms.ComboBox cbxDestLang;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TableLayoutPanel tableLeft;
		private System.Windows.Forms.ComboBox cbxSourceLang;
		private System.Windows.Forms.TextBox tbxSource;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnSwap;
		private System.Windows.Forms.Button btnTranslate;
		private System.Windows.Forms.CheckBox cbxAutoTranslate;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.StatusStrip statusStrip;
		private System.Windows.Forms.ToolStripStatusLabel lblStatus;
		private System.Windows.Forms.Timer timerAutoTranslate;
	}
}

