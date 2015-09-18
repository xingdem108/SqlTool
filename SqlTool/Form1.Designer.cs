namespace SqlTool
{
    partial class SqlTool
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SqlTool));
            this.labelServer = new System.Windows.Forms.Label();
            this.texServer = new System.Windows.Forms.TextBox();
            this.labelUser = new System.Windows.Forms.Label();
            this.textUser = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.labelDataBase = new System.Windows.Forms.Label();
            this.comDataBase = new System.Windows.Forms.ComboBox();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panelRight = new System.Windows.Forms.Panel();
            this.buttonConnection = new System.Windows.Forms.Button();
            this.textFind = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.dataGridFind = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSaveDescription = new System.Windows.Forms.Button();
            this.tabDaoShu = new System.Windows.Forms.TabControl();
            this.tabData = new System.Windows.Forms.TabPage();
            this.tabCode = new System.Windows.Forms.TabPage();
            this.tabSql = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.panelLeft.SuspendLayout();
            this.panelRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFind)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabDaoShu.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelServer
            // 
            this.labelServer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelServer.AutoSize = true;
            this.labelServer.Location = new System.Drawing.Point(28, 13);
            this.labelServer.Name = "labelServer";
            this.labelServer.Size = new System.Drawing.Size(41, 12);
            this.labelServer.TabIndex = 0;
            this.labelServer.Text = "Server";
            // 
            // texServer
            // 
            this.texServer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.texServer.Location = new System.Drawing.Point(75, 10);
            this.texServer.Name = "texServer";
            this.texServer.Size = new System.Drawing.Size(137, 21);
            this.texServer.TabIndex = 1;
            // 
            // labelUser
            // 
            this.labelUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelUser.AutoSize = true;
            this.labelUser.Location = new System.Drawing.Point(217, 13);
            this.labelUser.Margin = new System.Windows.Forms.Padding(3);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(29, 12);
            this.labelUser.TabIndex = 2;
            this.labelUser.Text = "User";
            // 
            // textUser
            // 
            this.textUser.Location = new System.Drawing.Point(264, 10);
            this.textUser.Name = "textUser";
            this.textUser.Size = new System.Drawing.Size(100, 21);
            this.textUser.TabIndex = 3;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(383, 13);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(53, 12);
            this.labelPassword.TabIndex = 4;
            this.labelPassword.Text = "Password";
            // 
            // textPassword
            // 
            this.textPassword.Location = new System.Drawing.Point(442, 10);
            this.textPassword.Name = "textPassword";
            this.textPassword.Size = new System.Drawing.Size(100, 21);
            this.textPassword.TabIndex = 5;
            // 
            // labelDataBase
            // 
            this.labelDataBase.AutoSize = true;
            this.labelDataBase.Location = new System.Drawing.Point(574, 13);
            this.labelDataBase.Name = "labelDataBase";
            this.labelDataBase.Size = new System.Drawing.Size(53, 12);
            this.labelDataBase.TabIndex = 6;
            this.labelDataBase.Text = "DataBase";
            // 
            // comDataBase
            // 
            this.comDataBase.FormattingEnabled = true;
            this.comDataBase.Location = new System.Drawing.Point(633, 10);
            this.comDataBase.Name = "comDataBase";
            this.comDataBase.Size = new System.Drawing.Size(121, 20);
            this.comDataBase.TabIndex = 7;
            // 
            // panelLeft
            // 
            this.panelLeft.Controls.Add(this.dataGridFind);
            this.panelLeft.Controls.Add(this.btnFind);
            this.panelLeft.Controls.Add(this.textFind);
            this.panelLeft.Location = new System.Drawing.Point(12, 37);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(284, 392);
            this.panelLeft.TabIndex = 8;
            // 
            // panelRight
            // 
            this.panelRight.Controls.Add(this.tabDaoShu);
            this.panelRight.Controls.Add(this.btnSaveDescription);
            this.panelRight.Controls.Add(this.dataGridView1);
            this.panelRight.Location = new System.Drawing.Point(302, 37);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(588, 392);
            this.panelRight.TabIndex = 9;
            // 
            // buttonConnection
            // 
            this.buttonConnection.Location = new System.Drawing.Point(775, 7);
            this.buttonConnection.Name = "buttonConnection";
            this.buttonConnection.Size = new System.Drawing.Size(115, 23);
            this.buttonConnection.TabIndex = 10;
            this.buttonConnection.Text = "Connection";
            this.buttonConnection.UseVisualStyleBackColor = true;
            // 
            // textFind
            // 
            this.textFind.Location = new System.Drawing.Point(18, 4);
            this.textFind.Name = "textFind";
            this.textFind.Size = new System.Drawing.Size(182, 21);
            this.textFind.TabIndex = 0;
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(206, 4);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(64, 23);
            this.btnFind.TabIndex = 1;
            this.btnFind.Text = "查找";
            this.btnFind.UseVisualStyleBackColor = true;
            // 
            // dataGridFind
            // 
            this.dataGridFind.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridFind.Location = new System.Drawing.Point(18, 33);
            this.dataGridFind.Name = "dataGridFind";
            this.dataGridFind.RowTemplate.Height = 23;
            this.dataGridFind.Size = new System.Drawing.Size(252, 345);
            this.dataGridFind.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(559, 139);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnSaveDescription
            // 
            this.btnSaveDescription.Location = new System.Drawing.Point(456, 149);
            this.btnSaveDescription.Name = "btnSaveDescription";
            this.btnSaveDescription.Size = new System.Drawing.Size(118, 23);
            this.btnSaveDescription.TabIndex = 1;
            this.btnSaveDescription.Text = "Save Description";
            this.btnSaveDescription.UseVisualStyleBackColor = true;
            // 
            // tabDaoShu
            // 
            this.tabDaoShu.Controls.Add(this.tabData);
            this.tabDaoShu.Controls.Add(this.tabCode);
            this.tabDaoShu.Controls.Add(this.tabSql);
            this.tabDaoShu.Controls.Add(this.tabPage4);
            this.tabDaoShu.Location = new System.Drawing.Point(15, 187);
            this.tabDaoShu.Name = "tabDaoShu";
            this.tabDaoShu.SelectedIndex = 0;
            this.tabDaoShu.Size = new System.Drawing.Size(559, 191);
            this.tabDaoShu.TabIndex = 2;
            // 
            // tabData
            // 
            this.tabData.Location = new System.Drawing.Point(4, 22);
            this.tabData.Name = "tabData";
            this.tabData.Padding = new System.Windows.Forms.Padding(3);
            this.tabData.Size = new System.Drawing.Size(551, 165);
            this.tabData.TabIndex = 0;
            this.tabData.Text = "Data";
            this.tabData.UseVisualStyleBackColor = true;
            // 
            // tabCode
            // 
            this.tabCode.Location = new System.Drawing.Point(4, 22);
            this.tabCode.Name = "tabCode";
            this.tabCode.Padding = new System.Windows.Forms.Padding(3);
            this.tabCode.Size = new System.Drawing.Size(551, 165);
            this.tabCode.TabIndex = 1;
            this.tabCode.Text = "Code";
            this.tabCode.UseVisualStyleBackColor = true;
            // 
            // tabSql
            // 
            this.tabSql.Location = new System.Drawing.Point(4, 22);
            this.tabSql.Name = "tabSql";
            this.tabSql.Padding = new System.Windows.Forms.Padding(3);
            this.tabSql.Size = new System.Drawing.Size(551, 165);
            this.tabSql.TabIndex = 2;
            this.tabSql.Text = "Sql";
            this.tabSql.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(551, 165);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "导数";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // SqlTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(902, 441);
            this.Controls.Add(this.buttonConnection);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.comDataBase);
            this.Controls.Add(this.labelDataBase);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.textUser);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.texServer);
            this.Controls.Add(this.labelServer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SqlTool";
            this.Text = "SqlTool";
            this.Load += new System.EventHandler(this.SqlTool_Load);
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            this.panelRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFind)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabDaoShu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelServer;
        private System.Windows.Forms.TextBox texServer;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.TextBox textUser;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.Label labelDataBase;
        private System.Windows.Forms.ComboBox comDataBase;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Button buttonConnection;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox textFind;
        private System.Windows.Forms.DataGridView dataGridFind;
        private System.Windows.Forms.TabControl tabDaoShu;
        private System.Windows.Forms.TabPage tabData;
        private System.Windows.Forms.TabPage tabCode;
        private System.Windows.Forms.TabPage tabSql;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btnSaveDescription;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

