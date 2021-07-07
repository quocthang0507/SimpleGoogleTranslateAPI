
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
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.label1 = new System.Windows.Forms.Label();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
			this.tbxDest = new System.Windows.Forms.TextBox();
			this.cbxDestLang = new System.Windows.Forms.ComboBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.cbxSourceLang = new System.Windows.Forms.ComboBox();
			this.tbxSource = new System.Windows.Forms.TextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnClear = new System.Windows.Forms.Button();
			this.btnSwap = new System.Windows.Forms.Button();
			this.btnTranslate = new System.Windows.Forms.Button();
			this.cbxAutoTranslate = new System.Windows.Forms.CheckBox();
			this.tableLayoutPanel1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.tableLayoutPanel4.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.tableLayoutPanel3.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.Size = new System.Drawing.Size(784, 461);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label1.Location = new System.Drawing.Point(3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(778, 40);
			this.label1.TabIndex = 0;
			this.label1.Text = "GOOGLE TRANSLATE API";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 3;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
			this.tableLayoutPanel2.Controls.Add(this.groupBox1, 2, 0);
			this.tableLayoutPanel2.Controls.Add(this.groupBox2, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.panel1, 1, 0);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 43);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 1;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(778, 415);
			this.tableLayoutPanel2.TabIndex = 1;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.tableLayoutPanel4);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox1.Location = new System.Drawing.Point(469, 3);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(306, 409);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Ngôn ngữ đích";
			// 
			// tableLayoutPanel4
			// 
			this.tableLayoutPanel4.ColumnCount = 1;
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel4.Controls.Add(this.tbxDest, 0, 1);
			this.tableLayoutPanel4.Controls.Add(this.cbxDestLang, 0, 0);
			this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 23);
			this.tableLayoutPanel4.Name = "tableLayoutPanel4";
			this.tableLayoutPanel4.RowCount = 2;
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel4.Size = new System.Drawing.Size(300, 383);
			this.tableLayoutPanel4.TabIndex = 1;
			// 
			// tbxDest
			// 
			this.tbxDest.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tbxDest.Location = new System.Drawing.Point(3, 33);
			this.tbxDest.Multiline = true;
			this.tbxDest.Name = "tbxDest";
			this.tbxDest.ReadOnly = true;
			this.tbxDest.Size = new System.Drawing.Size(294, 347);
			this.tbxDest.TabIndex = 8;
			// 
			// cbxDestLang
			// 
			this.cbxDestLang.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.cbxDestLang.Dock = System.Windows.Forms.DockStyle.Fill;
			this.cbxDestLang.FormattingEnabled = true;
			this.cbxDestLang.Location = new System.Drawing.Point(3, 3);
			this.cbxDestLang.Name = "cbxDestLang";
			this.cbxDestLang.Size = new System.Drawing.Size(294, 28);
			this.cbxDestLang.TabIndex = 7;
			this.cbxDestLang.SelectedIndexChanged += new System.EventHandler(this.cbxDestLang_SelectedIndexChanged);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.tableLayoutPanel3);
			this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox2.Location = new System.Drawing.Point(3, 3);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(305, 409);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Ngôn ngữ nguồn";
			// 
			// tableLayoutPanel3
			// 
			this.tableLayoutPanel3.ColumnCount = 1;
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel3.Controls.Add(this.cbxSourceLang, 0, 0);
			this.tableLayoutPanel3.Controls.Add(this.tbxSource, 0, 1);
			this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 23);
			this.tableLayoutPanel3.Name = "tableLayoutPanel3";
			this.tableLayoutPanel3.RowCount = 2;
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel3.Size = new System.Drawing.Size(299, 383);
			this.tableLayoutPanel3.TabIndex = 0;
			// 
			// cbxSourceLang
			// 
			this.cbxSourceLang.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.cbxSourceLang.Dock = System.Windows.Forms.DockStyle.Fill;
			this.cbxSourceLang.FormattingEnabled = true;
			this.cbxSourceLang.Location = new System.Drawing.Point(3, 3);
			this.cbxSourceLang.Name = "cbxSourceLang";
			this.cbxSourceLang.Size = new System.Drawing.Size(293, 28);
			this.cbxSourceLang.TabIndex = 1;
			this.cbxSourceLang.SelectedIndexChanged += new System.EventHandler(this.cbxSourceLang_SelectedIndexChanged);
			// 
			// tbxSource
			// 
			this.tbxSource.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tbxSource.Location = new System.Drawing.Point(3, 33);
			this.tbxSource.Multiline = true;
			this.tbxSource.Name = "tbxSource";
			this.tbxSource.Size = new System.Drawing.Size(293, 347);
			this.tbxSource.TabIndex = 2;
			this.tbxSource.TextChanged += new System.EventHandler(this.tbxSource_TextChanged);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btnClear);
			this.panel1.Controls.Add(this.btnSwap);
			this.panel1.Controls.Add(this.btnTranslate);
			this.panel1.Controls.Add(this.cbxAutoTranslate);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(314, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(149, 409);
			this.panel1.TabIndex = 2;
			// 
			// btnClear
			// 
			this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClear.Location = new System.Drawing.Point(20, 257);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(115, 45);
			this.btnClear.TabIndex = 6;
			this.btnClear.Text = "Xóa";
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// btnSwap
			// 
			this.btnSwap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSwap.Location = new System.Drawing.Point(20, 188);
			this.btnSwap.Name = "btnSwap";
			this.btnSwap.Size = new System.Drawing.Size(115, 45);
			this.btnSwap.TabIndex = 5;
			this.btnSwap.Text = "Hoán đổi";
			this.btnSwap.UseVisualStyleBackColor = true;
			this.btnSwap.Click += new System.EventHandler(this.btnSwap_Click);
			// 
			// btnTranslate
			// 
			this.btnTranslate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.btnTranslate.Location = new System.Drawing.Point(20, 117);
			this.btnTranslate.Name = "btnTranslate";
			this.btnTranslate.Size = new System.Drawing.Size(115, 45);
			this.btnTranslate.TabIndex = 4;
			this.btnTranslate.Text = "Dịch";
			this.btnTranslate.UseVisualStyleBackColor = true;
			this.btnTranslate.Click += new System.EventHandler(this.btnTranslate_Click);
			// 
			// cbxAutoTranslate
			// 
			this.cbxAutoTranslate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.cbxAutoTranslate.AutoSize = true;
			this.cbxAutoTranslate.Location = new System.Drawing.Point(20, 87);
			this.cbxAutoTranslate.Name = "cbxAutoTranslate";
			this.cbxAutoTranslate.Size = new System.Drawing.Size(116, 24);
			this.cbxAutoTranslate.TabIndex = 3;
			this.cbxAutoTranslate.Text = "Tự động dịch";
			this.cbxAutoTranslate.UseVisualStyleBackColor = true;
			this.cbxAutoTranslate.CheckedChanged += new System.EventHandler(this.cbxAutoTranslate_CheckedChanged);
			// 
			// Form1
			// 
			this.AcceptButton = this.btnTranslate;
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnClear;
			this.ClientSize = new System.Drawing.Size(784, 461);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "Form1";
			this.Text = "Google Translate API";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.tableLayoutPanel2.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.tableLayoutPanel4.ResumeLayout(false);
			this.tableLayoutPanel4.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.tableLayoutPanel3.ResumeLayout(false);
			this.tableLayoutPanel3.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
		private System.Windows.Forms.TextBox tbxDest;
		private System.Windows.Forms.ComboBox cbxDestLang;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
		private System.Windows.Forms.ComboBox cbxSourceLang;
		private System.Windows.Forms.TextBox tbxSource;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnSwap;
		private System.Windows.Forms.Button btnTranslate;
		private System.Windows.Forms.CheckBox cbxAutoTranslate;
		private System.Windows.Forms.Button btnClear;
	}
}

