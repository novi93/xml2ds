namespace Xml2Ds
{
    partial class frmSemi
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.tblMain = new System.Windows.Forms.TableLayoutPanel();
            this.grdLeft = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnLoad_Left = new System.Windows.Forms.Button();
            this.txtSearch_Left = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.txtpath = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnLoad_Right = new System.Windows.Forms.Button();
            this.txtSearch_Right = new System.Windows.Forms.TextBox();
            this.grdRight = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.tblMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdLeft)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdRight)).BeginInit();
            this.SuspendLayout();
            // 
            // tblMain
            // 
            this.tblMain.ColumnCount = 3;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblMain.Controls.Add(this.grdLeft, 0, 2);
            this.tblMain.Controls.Add(this.panel3, 0, 1);
            this.tblMain.Controls.Add(this.panel1, 0, 0);
            this.tblMain.Controls.Add(this.panel4, 2, 1);
            this.tblMain.Controls.Add(this.grdRight, 2, 2);
            this.tblMain.Controls.Add(this.button1, 1, 2);
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMain.Location = new System.Drawing.Point(0, 0);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 3;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.Size = new System.Drawing.Size(968, 385);
            this.tblMain.TabIndex = 0;
            // 
            // grdLeft
            // 
            this.grdLeft.AllowUserToAddRows = false;
            this.grdLeft.AllowUserToDeleteRows = false;
            this.grdLeft.AllowUserToResizeColumns = false;
            this.grdLeft.AllowUserToResizeRows = false;
            this.grdLeft.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdLeft.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdLeft.Location = new System.Drawing.Point(3, 75);
            this.grdLeft.Name = "grdLeft";
            this.grdLeft.ReadOnly = true;
            this.grdLeft.RowTemplate.Height = 21;
            this.grdLeft.Size = new System.Drawing.Size(453, 307);
            this.grdLeft.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnLoad_Left);
            this.panel3.Controls.Add(this.txtSearch_Left);
            this.panel3.Location = new System.Drawing.Point(3, 35);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(453, 34);
            this.panel3.TabIndex = 2;
            // 
            // btnLoad_Left
            // 
            this.btnLoad_Left.Location = new System.Drawing.Point(232, 4);
            this.btnLoad_Left.Name = "btnLoad_Left";
            this.btnLoad_Left.Size = new System.Drawing.Size(75, 23);
            this.btnLoad_Left.TabIndex = 1;
            this.btnLoad_Left.Text = "button1";
            this.btnLoad_Left.UseVisualStyleBackColor = true;
            this.btnLoad_Left.Click += new System.EventHandler(this.btnLoad_Left_Click);
            // 
            // txtSearch_Left
            // 
            this.txtSearch_Left.Location = new System.Drawing.Point(47, 6);
            this.txtSearch_Left.Name = "txtSearch_Left";
            this.txtSearch_Left.Size = new System.Drawing.Size(179, 19);
            this.txtSearch_Left.TabIndex = 0;
            // 
            // panel1
            // 
            this.tblMain.SetColumnSpan(this.panel1, 3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.txtpath);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(962, 26);
            this.panel1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(47, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "button1";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // txtpath
            // 
            this.txtpath.Location = new System.Drawing.Point(135, 4);
            this.txtpath.Name = "txtpath";
            this.txtpath.Size = new System.Drawing.Size(824, 19);
            this.txtpath.TabIndex = 0;
            this.txtpath.Validated += new System.EventHandler(this.txtpath_Validated);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnLoad_Right);
            this.panel4.Controls.Add(this.txtSearch_Right);
            this.panel4.Location = new System.Drawing.Point(512, 35);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(453, 34);
            this.panel4.TabIndex = 6;
            // 
            // btnLoad_Right
            // 
            this.btnLoad_Right.Location = new System.Drawing.Point(232, 4);
            this.btnLoad_Right.Name = "btnLoad_Right";
            this.btnLoad_Right.Size = new System.Drawing.Size(75, 23);
            this.btnLoad_Right.TabIndex = 1;
            this.btnLoad_Right.Text = "button3";
            this.btnLoad_Right.UseVisualStyleBackColor = true;
            this.btnLoad_Right.Click += new System.EventHandler(this.btnLoad_Right_Click);
            // 
            // txtSearch_Right
            // 
            this.txtSearch_Right.Location = new System.Drawing.Point(47, 6);
            this.txtSearch_Right.Name = "txtSearch_Right";
            this.txtSearch_Right.Size = new System.Drawing.Size(179, 19);
            this.txtSearch_Right.TabIndex = 0;
            // 
            // grdRight
            // 
            this.grdRight.AllowUserToAddRows = false;
            this.grdRight.AllowUserToDeleteRows = false;
            this.grdRight.AllowUserToResizeColumns = false;
            this.grdRight.AllowUserToResizeRows = false;
            this.grdRight.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdRight.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdRight.Location = new System.Drawing.Point(512, 75);
            this.grdRight.Name = "grdRight";
            this.grdRight.ReadOnly = true;
            this.grdRight.RowTemplate.Height = 21;
            this.grdRight.Size = new System.Drawing.Size(453, 307);
            this.grdRight.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(462, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(44, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "<=>";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmSemi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 385);
            this.Controls.Add(this.tblMain);
            this.Name = "frmSemi";
            this.Text = "xml2ds";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tblMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdLeft)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdRight)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblMain;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtpath;
        private System.Windows.Forms.DataGridView grdLeft;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnLoad_Left;
        private System.Windows.Forms.TextBox txtSearch_Left;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnLoad_Right;
        private System.Windows.Forms.TextBox txtSearch_Right;
        private System.Windows.Forms.DataGridView grdRight;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

