namespace GeckoFxTabs
{
    partial class FrmMain
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose( bool disposing )
        {
            if ( disposing && ( components != null ) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tcBrowsersTabs = new System.Windows.Forms.TabControl();
            this.lblAddress = new System.Windows.Forms.Label();
            this.tbUrl = new System.Windows.Forms.TextBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.stmiTabs = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAddTab = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCloseActiveTab = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcBrowsersTabs
            // 
            this.tcBrowsersTabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcBrowsersTabs.Location = new System.Drawing.Point(3, 66);
            this.tcBrowsersTabs.Name = "tcBrowsersTabs";
            this.tcBrowsersTabs.SelectedIndex = 0;
            this.tcBrowsersTabs.Size = new System.Drawing.Size(435, 286);
            this.tcBrowsersTabs.TabIndex = 0;
            this.tcBrowsersTabs.SelectedIndexChanged += new System.EventHandler(this.tcBrowsersTabs_SelectedIndexChanged);
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(0, 24);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(41, 13);
            this.lblAddress.TabIndex = 1;
            this.lblAddress.Text = "Адрес:";
            // 
            // tbUrl
            // 
            this.tbUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbUrl.Location = new System.Drawing.Point(3, 40);
            this.tbUrl.Name = "tbUrl";
            this.tbUrl.Size = new System.Drawing.Size(384, 20);
            this.tbUrl.TabIndex = 2;
            // 
            // btnGo
            // 
            this.btnGo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGo.Location = new System.Drawing.Point(393, 38);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(45, 23);
            this.btnGo.TabIndex = 3;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stmiTabs});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(441, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // stmiTabs
            // 
            this.stmiTabs.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAddTab,
            this.tsmiCloseActiveTab});
            this.stmiTabs.Name = "stmiTabs";
            this.stmiTabs.Size = new System.Drawing.Size(65, 20);
            this.stmiTabs.Text = "Вкладки";
            // 
            // tsmiAddTab
            // 
            this.tsmiAddTab.Name = "tsmiAddTab";
            this.tsmiAddTab.Size = new System.Drawing.Size(224, 22);
            this.tsmiAddTab.Text = "Добавить вкладку";
            this.tsmiAddTab.Click += new System.EventHandler(this.tsmiAddTab_Click);
            // 
            // tsmiCloseActiveTab
            // 
            this.tsmiCloseActiveTab.Name = "tsmiCloseActiveTab";
            this.tsmiCloseActiveTab.Size = new System.Drawing.Size(224, 22);
            this.tsmiCloseActiveTab.Text = "Закрыть активную вкладку";
            this.tsmiCloseActiveTab.Click += new System.EventHandler(this.tsmiCloseActiveTab_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 354);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.tbUrl);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.tcBrowsersTabs);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GeckoFx Tabs";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tcBrowsersTabs;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox tbUrl;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem stmiTabs;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddTab;
        private System.Windows.Forms.ToolStripMenuItem tsmiCloseActiveTab;
    }
}

