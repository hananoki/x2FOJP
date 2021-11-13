using HananokiLib;

namespace x2FOJP {
	partial class MainForm {
		/// <summary>
		/// 必要なデザイナー変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
		protected override void Dispose( bool disposing ) {
			if( disposing && ( components != null ) ) {
				components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region Windows フォーム デザイナーで生成されたコード

		/// <summary>
		/// デザイナー サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディターで変更しないでください。
		/// </summary>
		private void InitializeComponent() {
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.listView1 = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.tsb_Convert = new System.Windows.Forms.ToolStripButton();
			this.tsb_Return = new System.Windows.Forms.ToolStripButton();
			this.tsb_Settings = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.tsb_xTranslator = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.tsb_Refresh = new System.Windows.Forms.ToolStripButton();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel_Settings = new System.Windows.Forms.Panel();
			this.checkBox2 = new System.Windows.Forms.CheckBox();
			this.lbl_fojp = new System.Windows.Forms.Label();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.lbl_prefix = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.panel_ListView = new System.Windows.Forms.Panel();
			this.textBox_fojp = new HananokiLib.TextBoxGuide();
			this.textBox_convTxtFolder = new HananokiLib.TextBoxGuide();
			this.textBox_xmlFolder = new HananokiLib.TextBoxGuide();
			this.textBox_prefix = new HananokiLib.TextBoxGuide();
			this.textBox_xTranslatorPath = new HananokiLib.TextBoxGuide();
			this.toolStrip1.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel_Settings.SuspendLayout();
			this.panel_ListView.SuspendLayout();
			this.SuspendLayout();
			// 
			// listView1
			// 
			this.listView1.CheckBoxes = true;
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
			this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listView1.FullRowSelect = true;
			this.listView1.GridLines = true;
			this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.listView1.HideSelection = false;
			this.listView1.Location = new System.Drawing.Point(4, 4);
			this.listView1.MultiSelect = false;
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(640, 309);
			this.listView1.SmallImageList = this.imageList1;
			this.listView1.TabIndex = 0;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Details;
			this.listView1.VirtualMode = true;
			this.listView1.RetrieveVirtualItem += new System.Windows.Forms.RetrieveVirtualItemEventHandler(this.onRetrieveVirtualItem);
			this.listView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseClick);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Width = 122;
			// 
			// imageList1
			// 
			this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
			this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_Convert,
            this.tsb_Return,
            this.tsb_Settings,
            this.toolStripSeparator2,
            this.tsb_xTranslator,
            this.toolStripSeparator3,
            this.tsb_Refresh});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(648, 25);
			this.toolStrip1.TabIndex = 1;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// tsb_Convert
			// 
			this.tsb_Convert.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.tsb_Convert.AutoToolTip = false;
			this.tsb_Convert.Image = ((System.Drawing.Image)(resources.GetObject("tsb_Convert.Image")));
			this.tsb_Convert.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsb_Convert.Name = "tsb_Convert";
			this.tsb_Convert.Size = new System.Drawing.Size(51, 22);
			this.tsb_Convert.Text = "変換";
			this.tsb_Convert.Click += new System.EventHandler(this.tsb_Convert_Click);
			// 
			// tsb_Return
			// 
			this.tsb_Return.AutoToolTip = false;
			this.tsb_Return.Image = ((System.Drawing.Image)(resources.GetObject("tsb_Return.Image")));
			this.tsb_Return.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsb_Return.Name = "tsb_Return";
			this.tsb_Return.Size = new System.Drawing.Size(48, 22);
			this.tsb_Return.Text = "戻る";
			this.tsb_Return.Click += new System.EventHandler(this.tsb_return_Click);
			// 
			// tsb_Settings
			// 
			this.tsb_Settings.AutoToolTip = false;
			this.tsb_Settings.Image = ((System.Drawing.Image)(resources.GetObject("tsb_Settings.Image")));
			this.tsb_Settings.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsb_Settings.Name = "tsb_Settings";
			this.tsb_Settings.Size = new System.Drawing.Size(51, 22);
			this.tsb_Settings.Text = "設定";
			this.tsb_Settings.Click += new System.EventHandler(this.tsb_Setting_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
			// 
			// tsb_xTranslator
			// 
			this.tsb_xTranslator.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.tsb_xTranslator.AutoToolTip = false;
			this.tsb_xTranslator.Image = ((System.Drawing.Image)(resources.GetObject("tsb_xTranslator.Image")));
			this.tsb_xTranslator.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsb_xTranslator.Name = "tsb_xTranslator";
			this.tsb_xTranslator.Size = new System.Drawing.Size(117, 22);
			this.tsb_xTranslator.Text = "xTranslatorを起動";
			this.tsb_xTranslator.Click += new System.EventHandler(this.tsb_xTranslator_Click);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
			// 
			// tsb_Refresh
			// 
			this.tsb_Refresh.AutoToolTip = false;
			this.tsb_Refresh.Image = ((System.Drawing.Image)(resources.GetObject("tsb_Refresh.Image")));
			this.tsb_Refresh.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsb_Refresh.Name = "tsb_Refresh";
			this.tsb_Refresh.Size = new System.Drawing.Size(118, 22);
			this.tsb_Refresh.Text = "最新の情報に更新";
			this.tsb_Refresh.Click += new System.EventHandler(this.tsb_Refresh_Click);
			// 
			// statusStrip1
			// 
			this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
			this.statusStrip1.Location = new System.Drawing.Point(0, 342);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(648, 22);
			this.statusStrip1.TabIndex = 2;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
			this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.panel_Settings);
			this.panel1.Controls.Add(this.panel_ListView);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 25);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(648, 317);
			this.panel1.TabIndex = 3;
			// 
			// panel_Settings
			// 
			this.panel_Settings.Controls.Add(this.checkBox2);
			this.panel_Settings.Controls.Add(this.lbl_fojp);
			this.panel_Settings.Controls.Add(this.textBox_fojp);
			this.panel_Settings.Controls.Add(this.checkBox1);
			this.panel_Settings.Controls.Add(this.textBox_convTxtFolder);
			this.panel_Settings.Controls.Add(this.label5);
			this.panel_Settings.Controls.Add(this.textBox_xmlFolder);
			this.panel_Settings.Controls.Add(this.label4);
			this.panel_Settings.Controls.Add(this.textBox_prefix);
			this.panel_Settings.Controls.Add(this.lbl_prefix);
			this.panel_Settings.Controls.Add(this.textBox_xTranslatorPath);
			this.panel_Settings.Controls.Add(this.label1);
			this.panel_Settings.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel_Settings.Location = new System.Drawing.Point(0, 0);
			this.panel_Settings.Name = "panel_Settings";
			this.panel_Settings.Size = new System.Drawing.Size(648, 317);
			this.panel_Settings.TabIndex = 2;
			// 
			// checkBox2
			// 
			this.checkBox2.AutoSize = true;
			this.checkBox2.Location = new System.Drawing.Point(10, 219);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(194, 16);
			this.checkBox2.TabIndex = 11;
			this.checkBox2.Text = "xTranslator起動ボタンを有効にする";
			this.checkBox2.UseVisualStyleBackColor = true;
			this.checkBox2.CheckStateChanged += new System.EventHandler(this.checkBox1_CheckStateChanged);
			// 
			// lbl_fojp
			// 
			this.lbl_fojp.AutoSize = true;
			this.lbl_fojp.Location = new System.Drawing.Point(10, 124);
			this.lbl_fojp.Name = "lbl_fojp";
			this.lbl_fojp.Size = new System.Drawing.Size(44, 12);
			this.lbl_fojp.TabIndex = 4;
			this.lbl_fojp.Text = "fojp.xml";
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Location = new System.Drawing.Point(12, 105);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(226, 16);
			this.checkBox1.TabIndex = 10;
			this.checkBox1.Text = "処理した翻訳テキストをfojp.xmlに反映する";
			this.checkBox1.UseVisualStyleBackColor = true;
			this.checkBox1.CheckStateChanged += new System.EventHandler(this.checkBox1_CheckStateChanged);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(10, 41);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(189, 12);
			this.label5.TabIndex = 8;
			this.label5.Text = "変換先フォルダ (***_en.txt ***_jp.txt)";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 4);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(192, 12);
			this.label4.TabIndex = 6;
			this.label4.Text = "変換元フォルダ (xmlが格納された場所)";
			// 
			// lbl_prefix
			// 
			this.lbl_prefix.AutoSize = true;
			this.lbl_prefix.Location = new System.Drawing.Point(8, 161);
			this.lbl_prefix.Name = "lbl_prefix";
			this.lbl_prefix.Size = new System.Drawing.Size(136, 12);
			this.lbl_prefix.TabIndex = 2;
			this.lbl_prefix.Text = "翻訳テキスト・読み込みパス";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(8, 238);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(63, 12);
			this.label1.TabIndex = 0;
			this.label1.Text = "xTranslator";
			// 
			// panel_ListView
			// 
			this.panel_ListView.Controls.Add(this.listView1);
			this.panel_ListView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel_ListView.Location = new System.Drawing.Point(0, 0);
			this.panel_ListView.Name = "panel_ListView";
			this.panel_ListView.Padding = new System.Windows.Forms.Padding(4);
			this.panel_ListView.Size = new System.Drawing.Size(648, 317);
			this.panel_ListView.TabIndex = 1;
			// 
			// textBox_fojp
			// 
			this.textBox_fojp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox_fojp.Location = new System.Drawing.Point(10, 139);
			this.textBox_fojp.Name = "textBox_fojp";
			this.textBox_fojp.Size = new System.Drawing.Size(631, 19);
			this.textBox_fojp.TabIndex = 5;
			// 
			// textBox_convTxtFolder
			// 
			this.textBox_convTxtFolder.AllowDrop = true;
			this.textBox_convTxtFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox_convTxtFolder.Location = new System.Drawing.Point(12, 56);
			this.textBox_convTxtFolder.Name = "textBox_convTxtFolder";
			this.textBox_convTxtFolder.Size = new System.Drawing.Size(629, 19);
			this.textBox_convTxtFolder.TabIndex = 9;
			// 
			// textBox_xmlFolder
			// 
			this.textBox_xmlFolder.AllowDrop = true;
			this.textBox_xmlFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox_xmlFolder.Location = new System.Drawing.Point(12, 19);
			this.textBox_xmlFolder.Name = "textBox_xmlFolder";
			this.textBox_xmlFolder.Size = new System.Drawing.Size(629, 19);
			this.textBox_xmlFolder.TabIndex = 7;
			// 
			// textBox_prefix
			// 
			this.textBox_prefix.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox_prefix.Location = new System.Drawing.Point(10, 176);
			this.textBox_prefix.Name = "textBox_prefix";
			this.textBox_prefix.Size = new System.Drawing.Size(631, 19);
			this.textBox_prefix.TabIndex = 3;
			// 
			// textBox_xTranslatorPath
			// 
			this.textBox_xTranslatorPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox_xTranslatorPath.Location = new System.Drawing.Point(8, 253);
			this.textBox_xTranslatorPath.Name = "textBox_xTranslatorPath";
			this.textBox_xTranslatorPath.Size = new System.Drawing.Size(631, 19);
			this.textBox_xTranslatorPath.TabIndex = 1;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(648, 364);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.statusStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.Text = "x2FOJP";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel_Settings.ResumeLayout(false);
			this.panel_Settings.PerformLayout();
			this.panel_ListView.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton tsb_Convert;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel_Settings;
		private TextBoxGuide textBox_fojp;
		private System.Windows.Forms.Label lbl_fojp;
		private TextBoxGuide textBox_prefix;
		private System.Windows.Forms.Label lbl_prefix;
		private TextBoxGuide textBox_xTranslatorPath;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel_ListView;
		private System.Windows.Forms.ToolStripButton tsb_Settings;
		private TextBoxGuide textBox_xmlFolder;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private TextBoxGuide textBox_convTxtFolder;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ToolStripButton tsb_xTranslator;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripButton tsb_Refresh;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.ToolStripButton tsb_Return;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.CheckBox checkBox2;
	}
}

