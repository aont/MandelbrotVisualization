namespace Aont
{
    partial class MandelbrotForm
    {
        /// <summary>
        /// 必要なデザイナ変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナで生成されたコード

        /// <summary>
        /// デザイナ サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディタで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MandelbrotForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.set_button = new System.Windows.Forms.Button();
            this.reset_button1 = new System.Windows.Forms.Button();
            this.epsilon_settingControl7 = new Aont.SettingControl();
            this.infinity_settingControl6 = new Aont.SettingControl();
            this.loop_settingControl5 = new Aont.SettingControl();
            this.height_settingControl10 = new Aont.SettingControl();
            this.width_settingControl9 = new Aont.SettingControl();
            this.topy_settingControl4 = new Aont.SettingControl();
            this.rightx_settingControl3 = new Aont.SettingControl();
            this.bottomy_settingControl2 = new Aont.SettingControl();
            this.leftx_settingControl1 = new Aont.SettingControl();
            this.n_settingControl8 = new Aont.SettingControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.typeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.normalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.convergenceAssumptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rectangleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.initialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 26);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.flowLayoutPanel1);
            this.splitContainer1.Panel1.Controls.Add(this.epsilon_settingControl7);
            this.splitContainer1.Panel1.Controls.Add(this.infinity_settingControl6);
            this.splitContainer1.Panel1.Controls.Add(this.loop_settingControl5);
            this.splitContainer1.Panel1.Controls.Add(this.height_settingControl10);
            this.splitContainer1.Panel1.Controls.Add(this.width_settingControl9);
            this.splitContainer1.Panel1.Controls.Add(this.topy_settingControl4);
            this.splitContainer1.Panel1.Controls.Add(this.rightx_settingControl3);
            this.splitContainer1.Panel1.Controls.Add(this.bottomy_settingControl2);
            this.splitContainer1.Panel1.Controls.Add(this.leftx_settingControl1);
            this.splitContainer1.Panel1.Controls.Add(this.n_settingControl8);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox1);
            this.splitContainer1.Size = new System.Drawing.Size(507, 263);
            this.splitContainer1.SplitterDistance = 150;
            this.splitContainer1.SplitterWidth = 2;
            this.splitContainer1.TabIndex = 3;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.set_button);
            this.flowLayoutPanel1.Controls.Add(this.reset_button1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 190);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(150, 22);
            this.flowLayoutPanel1.TabIndex = 22;
            // 
            // set_button
            // 
            this.set_button.AutoSize = true;
            this.set_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.set_button.Location = new System.Drawing.Point(118, 0);
            this.set_button.Margin = new System.Windows.Forms.Padding(0);
            this.set_button.Name = "set_button";
            this.set_button.Size = new System.Drawing.Size(32, 22);
            this.set_button.TabIndex = 3;
            this.set_button.Text = "Set";
            this.set_button.UseVisualStyleBackColor = true;
            this.set_button.Click += new System.EventHandler(this.set_button_Click);
            // 
            // reset_button1
            // 
            this.reset_button1.AutoSize = true;
            this.reset_button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.reset_button1.Location = new System.Drawing.Point(73, 0);
            this.reset_button1.Margin = new System.Windows.Forms.Padding(0);
            this.reset_button1.Name = "reset_button1";
            this.reset_button1.Size = new System.Drawing.Size(45, 22);
            this.reset_button1.TabIndex = 4;
            this.reset_button1.Text = "Reset";
            this.reset_button1.UseVisualStyleBackColor = true;
            this.reset_button1.Click += new System.EventHandler(this.reset_button1_Click);
            // 
            // epsilon_settingControl7
            // 
            this.epsilon_settingControl7.AutoSize = true;
            this.epsilon_settingControl7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.epsilon_settingControl7.BackColor = System.Drawing.Color.Transparent;
            this.epsilon_settingControl7.Dock = System.Windows.Forms.DockStyle.Top;
            this.epsilon_settingControl7.Location = new System.Drawing.Point(0, 171);
            this.epsilon_settingControl7.Margin = new System.Windows.Forms.Padding(0);
            this.epsilon_settingControl7.Name = "epsilon_settingControl7";
            this.epsilon_settingControl7.Size = new System.Drawing.Size(150, 19);
            this.epsilon_settingControl7.Space = 30;
            this.epsilon_settingControl7.TabIndex = 21;
            this.epsilon_settingControl7.Title = "Epsilon";
            this.epsilon_settingControl7.Value = "";
            this.epsilon_settingControl7.OnKeyEnter += new System.EventHandler(this.set_button_Click);
            // 
            // infinity_settingControl6
            // 
            this.infinity_settingControl6.AutoSize = true;
            this.infinity_settingControl6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.infinity_settingControl6.BackColor = System.Drawing.Color.Transparent;
            this.infinity_settingControl6.Dock = System.Windows.Forms.DockStyle.Top;
            this.infinity_settingControl6.Location = new System.Drawing.Point(0, 152);
            this.infinity_settingControl6.Margin = new System.Windows.Forms.Padding(0);
            this.infinity_settingControl6.Name = "infinity_settingControl6";
            this.infinity_settingControl6.Size = new System.Drawing.Size(150, 19);
            this.infinity_settingControl6.Space = 30;
            this.infinity_settingControl6.TabIndex = 20;
            this.infinity_settingControl6.Title = "Infinity";
            this.infinity_settingControl6.Value = "";
            this.infinity_settingControl6.OnKeyEnter += new System.EventHandler(this.set_button_Click);
            // 
            // loop_settingControl5
            // 
            this.loop_settingControl5.AutoSize = true;
            this.loop_settingControl5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.loop_settingControl5.BackColor = System.Drawing.Color.Transparent;
            this.loop_settingControl5.Dock = System.Windows.Forms.DockStyle.Top;
            this.loop_settingControl5.Location = new System.Drawing.Point(0, 133);
            this.loop_settingControl5.Margin = new System.Windows.Forms.Padding(0);
            this.loop_settingControl5.Name = "loop_settingControl5";
            this.loop_settingControl5.Size = new System.Drawing.Size(150, 19);
            this.loop_settingControl5.Space = 30;
            this.loop_settingControl5.TabIndex = 19;
            this.loop_settingControl5.Title = "Loop";
            this.loop_settingControl5.Value = "";
            this.loop_settingControl5.OnKeyEnter += new System.EventHandler(this.set_button_Click);
            // 
            // height_settingControl10
            // 
            this.height_settingControl10.AutoSize = true;
            this.height_settingControl10.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.height_settingControl10.BackColor = System.Drawing.Color.Transparent;
            this.height_settingControl10.Dock = System.Windows.Forms.DockStyle.Top;
            this.height_settingControl10.Location = new System.Drawing.Point(0, 114);
            this.height_settingControl10.Margin = new System.Windows.Forms.Padding(0);
            this.height_settingControl10.Name = "height_settingControl10";
            this.height_settingControl10.Size = new System.Drawing.Size(150, 19);
            this.height_settingControl10.Space = 30;
            this.height_settingControl10.TabIndex = 24;
            this.height_settingControl10.Title = "Height";
            this.height_settingControl10.Value = "";
            this.height_settingControl10.OnKeyEnter += new System.EventHandler(this.set_button_Click);
            // 
            // width_settingControl9
            // 
            this.width_settingControl9.AutoSize = true;
            this.width_settingControl9.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.width_settingControl9.BackColor = System.Drawing.Color.Transparent;
            this.width_settingControl9.Dock = System.Windows.Forms.DockStyle.Top;
            this.width_settingControl9.Location = new System.Drawing.Point(0, 95);
            this.width_settingControl9.Margin = new System.Windows.Forms.Padding(0);
            this.width_settingControl9.Name = "width_settingControl9";
            this.width_settingControl9.Size = new System.Drawing.Size(150, 19);
            this.width_settingControl9.Space = 30;
            this.width_settingControl9.TabIndex = 23;
            this.width_settingControl9.Title = "Width";
            this.width_settingControl9.Value = "";
            this.width_settingControl9.OnKeyEnter += new System.EventHandler(this.set_button_Click);
            // 
            // topy_settingControl4
            // 
            this.topy_settingControl4.AutoSize = true;
            this.topy_settingControl4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.topy_settingControl4.BackColor = System.Drawing.Color.Transparent;
            this.topy_settingControl4.Dock = System.Windows.Forms.DockStyle.Top;
            this.topy_settingControl4.Location = new System.Drawing.Point(0, 76);
            this.topy_settingControl4.Margin = new System.Windows.Forms.Padding(0);
            this.topy_settingControl4.Name = "topy_settingControl4";
            this.topy_settingControl4.Size = new System.Drawing.Size(150, 19);
            this.topy_settingControl4.Space = 30;
            this.topy_settingControl4.TabIndex = 18;
            this.topy_settingControl4.Title = "Top Y";
            this.topy_settingControl4.Value = "";
            this.topy_settingControl4.OnKeyEnter += new System.EventHandler(this.set_button_Click);
            // 
            // rightx_settingControl3
            // 
            this.rightx_settingControl3.AutoSize = true;
            this.rightx_settingControl3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.rightx_settingControl3.BackColor = System.Drawing.Color.Transparent;
            this.rightx_settingControl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.rightx_settingControl3.Location = new System.Drawing.Point(0, 57);
            this.rightx_settingControl3.Margin = new System.Windows.Forms.Padding(0);
            this.rightx_settingControl3.Name = "rightx_settingControl3";
            this.rightx_settingControl3.Size = new System.Drawing.Size(150, 19);
            this.rightx_settingControl3.Space = 30;
            this.rightx_settingControl3.TabIndex = 17;
            this.rightx_settingControl3.Title = "Right X";
            this.rightx_settingControl3.Value = "";
            this.rightx_settingControl3.OnKeyEnter += new System.EventHandler(this.set_button_Click);
            // 
            // bottomy_settingControl2
            // 
            this.bottomy_settingControl2.AutoSize = true;
            this.bottomy_settingControl2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bottomy_settingControl2.BackColor = System.Drawing.Color.Transparent;
            this.bottomy_settingControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.bottomy_settingControl2.Location = new System.Drawing.Point(0, 38);
            this.bottomy_settingControl2.Margin = new System.Windows.Forms.Padding(0);
            this.bottomy_settingControl2.Name = "bottomy_settingControl2";
            this.bottomy_settingControl2.Size = new System.Drawing.Size(150, 19);
            this.bottomy_settingControl2.Space = 30;
            this.bottomy_settingControl2.TabIndex = 16;
            this.bottomy_settingControl2.Title = "Bottom Y";
            this.bottomy_settingControl2.Value = "";
            this.bottomy_settingControl2.OnKeyEnter += new System.EventHandler(this.set_button_Click);
            // 
            // leftx_settingControl1
            // 
            this.leftx_settingControl1.AutoSize = true;
            this.leftx_settingControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.leftx_settingControl1.BackColor = System.Drawing.Color.Transparent;
            this.leftx_settingControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.leftx_settingControl1.Location = new System.Drawing.Point(0, 19);
            this.leftx_settingControl1.Margin = new System.Windows.Forms.Padding(0);
            this.leftx_settingControl1.Name = "leftx_settingControl1";
            this.leftx_settingControl1.Size = new System.Drawing.Size(150, 19);
            this.leftx_settingControl1.Space = 30;
            this.leftx_settingControl1.TabIndex = 15;
            this.leftx_settingControl1.Title = "Left X";
            this.leftx_settingControl1.Value = "";
            this.leftx_settingControl1.OnKeyEnter += new System.EventHandler(this.set_button_Click);
            // 
            // n_settingControl8
            // 
            this.n_settingControl8.AutoSize = true;
            this.n_settingControl8.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.n_settingControl8.BackColor = System.Drawing.Color.Transparent;
            this.n_settingControl8.Dock = System.Windows.Forms.DockStyle.Top;
            this.n_settingControl8.Location = new System.Drawing.Point(0, 0);
            this.n_settingControl8.Margin = new System.Windows.Forms.Padding(0);
            this.n_settingControl8.Name = "n_settingControl8";
            this.n_settingControl8.Size = new System.Drawing.Size(150, 19);
            this.n_settingControl8.Space = 30;
            this.n_settingControl8.TabIndex = 7;
            this.n_settingControl8.Title = "Exponent n";
            this.n_settingControl8.Value = "";
            this.n_settingControl8.OnKeyEnter += new System.EventHandler(this.set_button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(355, 263);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "bmp";
            this.saveFileDialog1.FileName = ".bmp";
            this.saveFileDialog1.Filter = "Bitmap|*.bmp|PNG|*.png|Jpeg|*.jpg,*.jpeg|GIF|*.gif";
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(507, 26);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(40, 22);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripButton_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.typeToolStripMenuItem,
            this.rectangleToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(68, 22);
            this.settingsToolStripMenuItem.Text = "&Settings";
            // 
            // typeToolStripMenuItem
            // 
            this.typeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.normalToolStripMenuItem,
            this.convergenceAssumptionToolStripMenuItem});
            this.typeToolStripMenuItem.Name = "typeToolStripMenuItem";
            this.typeToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.typeToolStripMenuItem.Text = "&Type";
            // 
            // normalToolStripMenuItem
            // 
            this.normalToolStripMenuItem.Name = "normalToolStripMenuItem";
            this.normalToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.normalToolStripMenuItem.Text = "&Normal";
            this.normalToolStripMenuItem.Click += new System.EventHandler(this.normalToolStripMenuItem_Click);
            // 
            // convergenceAssumptionToolStripMenuItem
            // 
            this.convergenceAssumptionToolStripMenuItem.Name = "convergenceAssumptionToolStripMenuItem";
            this.convergenceAssumptionToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.convergenceAssumptionToolStripMenuItem.Text = "&ConvergenceAssumption";
            this.convergenceAssumptionToolStripMenuItem.Click += new System.EventHandler(this.convergenceAssumptionToolStripMenuItem_Click);
            // 
            // rectangleToolStripMenuItem
            // 
            this.rectangleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.initialToolStripMenuItem});
            this.rectangleToolStripMenuItem.Name = "rectangleToolStripMenuItem";
            this.rectangleToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.rectangleToolStripMenuItem.Text = "&Rectangle";
            // 
            // initialToolStripMenuItem
            // 
            this.initialToolStripMenuItem.Name = "initialToolStripMenuItem";
            this.initialToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.initialToolStripMenuItem.Text = "&Initial";
            this.initialToolStripMenuItem.Click += new System.EventHandler(this.initialToolStripMenuItem_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar1.Location = new System.Drawing.Point(0, 289);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(0);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(507, 16);
            this.progressBar1.TabIndex = 7;
            this.progressBar1.Visible = false;
            // 
            // MandelbrotForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 305);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.progressBar1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MandelbrotForm";
            this.Text = "Mandelbrot Visualization";
            this.Shown += new System.EventHandler(this.MandelbrotForm_Shown);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private SettingControl n_settingControl8;
        private SettingControl epsilon_settingControl7;
        private SettingControl infinity_settingControl6;
        private SettingControl loop_settingControl5;
        private SettingControl topy_settingControl4;
        private SettingControl rightx_settingControl3;
        private SettingControl bottomy_settingControl2;
        private SettingControl leftx_settingControl1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button set_button;
        private SettingControl height_settingControl10;
        private SettingControl width_settingControl9;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem typeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem normalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem convergenceAssumptionToolStripMenuItem;
        private System.Windows.Forms.Button reset_button1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ToolStripMenuItem rectangleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem initialToolStripMenuItem;







    }
}

