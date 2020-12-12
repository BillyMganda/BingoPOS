namespace Bingo_3._0
{
    partial class Manager_Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manager_Dashboard));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnOpenSales = new System.Windows.Forms.Button();
            this.btnCloseSales = new System.Windows.Forms.Button();
            this.btnReprintValidator = new System.Windows.Forms.Button();
            this.btnSalesModule = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.labelLoggedInUser = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel5);
            this.groupBox1.Controls.Add(this.labelDescription);
            this.groupBox1.Controls.Add(this.labelLoggedInUser);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Controls.Add(this.btnSalesModule);
            this.groupBox1.Controls.Add(this.btnReprintValidator);
            this.groupBox1.Controls.Add(this.btnCloseSales);
            this.groupBox1.Controls.Add(this.btnOpenSales);
            this.groupBox1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(8, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(535, 245);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Managers Madule";
            // 
            // btnOpenSales
            // 
            this.btnOpenSales.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpenSales.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnOpenSales.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnOpenSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenSales.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenSales.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenSales.Image")));
            this.btnOpenSales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpenSales.Location = new System.Drawing.Point(6, 22);
            this.btnOpenSales.Name = "btnOpenSales";
            this.btnOpenSales.Size = new System.Drawing.Size(125, 81);
            this.btnOpenSales.TabIndex = 21;
            this.btnOpenSales.Text = "&Open \r\nSession";
            this.btnOpenSales.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOpenSales.UseVisualStyleBackColor = true;
            this.btnOpenSales.Click += new System.EventHandler(this.btnOpenSales_Click);
            this.btnOpenSales.MouseHover += new System.EventHandler(this.btnOpenSales_MouseHover);
            // 
            // btnCloseSales
            // 
            this.btnCloseSales.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCloseSales.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnCloseSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseSales.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseSales.Image = ((System.Drawing.Image)(resources.GetObject("btnCloseSales.Image")));
            this.btnCloseSales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCloseSales.Location = new System.Drawing.Point(137, 22);
            this.btnCloseSales.Name = "btnCloseSales";
            this.btnCloseSales.Size = new System.Drawing.Size(125, 81);
            this.btnCloseSales.TabIndex = 22;
            this.btnCloseSales.Text = "&Close \r\nSales ";
            this.btnCloseSales.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCloseSales.UseVisualStyleBackColor = true;
            this.btnCloseSales.Click += new System.EventHandler(this.btnCloseSales_Click);
            this.btnCloseSales.MouseHover += new System.EventHandler(this.btnCloseSales_MouseHover);
            // 
            // btnReprintValidator
            // 
            this.btnReprintValidator.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReprintValidator.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnReprintValidator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReprintValidator.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReprintValidator.Image = ((System.Drawing.Image)(resources.GetObject("btnReprintValidator.Image")));
            this.btnReprintValidator.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReprintValidator.Location = new System.Drawing.Point(268, 22);
            this.btnReprintValidator.Name = "btnReprintValidator";
            this.btnReprintValidator.Size = new System.Drawing.Size(125, 81);
            this.btnReprintValidator.TabIndex = 23;
            this.btnReprintValidator.Text = "&Reprint\r\nReceipt";
            this.btnReprintValidator.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReprintValidator.UseVisualStyleBackColor = true;
            this.btnReprintValidator.Click += new System.EventHandler(this.btnReprintValidator_Click);
            this.btnReprintValidator.MouseHover += new System.EventHandler(this.btnReprintValidator_MouseHover);
            // 
            // btnSalesModule
            // 
            this.btnSalesModule.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalesModule.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnSalesModule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalesModule.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalesModule.Image = ((System.Drawing.Image)(resources.GetObject("btnSalesModule.Image")));
            this.btnSalesModule.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalesModule.Location = new System.Drawing.Point(399, 22);
            this.btnSalesModule.Name = "btnSalesModule";
            this.btnSalesModule.Size = new System.Drawing.Size(125, 81);
            this.btnSalesModule.TabIndex = 25;
            this.btnSalesModule.Text = "&Sales \r\nModule";
            this.btnSalesModule.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalesModule.UseVisualStyleBackColor = true;
            this.btnSalesModule.Click += new System.EventHandler(this.btnSalesModule_Click);
            this.btnSalesModule.MouseHover += new System.EventHandler(this.btnSalesModule_MouseHover);
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(399, 111);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(125, 81);
            this.btnClose.TabIndex = 26;
            this.btnClose.Text = "&Switch\r\nUser";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.MouseHover += new System.EventHandler(this.btnClose_MouseHover);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(6, 111);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 81);
            this.button1.TabIndex = 27;
            this.button1.Text = "&Validate\r\nWinning\r\nCard";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(268, 111);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 81);
            this.button2.TabIndex = 28;
            this.button2.Text = "&Reports";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.MouseHover += new System.EventHandler(this.button2_MouseHover);
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(137, 111);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(125, 81);
            this.button3.TabIndex = 28;
            this.button3.Text = "&Void\r\nSales";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            this.button3.MouseHover += new System.EventHandler(this.button3_MouseHover);
            // 
            // labelLoggedInUser
            // 
            this.labelLoggedInUser.AutoSize = true;
            this.labelLoggedInUser.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoggedInUser.Location = new System.Drawing.Point(6, 221);
            this.labelLoggedInUser.Name = "labelLoggedInUser";
            this.labelLoggedInUser.Size = new System.Drawing.Size(108, 15);
            this.labelLoggedInUser.TabIndex = 29;
            this.labelLoggedInUser.Text = "Logged In User";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescription.Location = new System.Drawing.Point(6, 199);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(57, 15);
            this.labelDescription.TabIndex = 30;
            this.labelDescription.Text = "Describe";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Teal;
            this.panel3.Location = new System.Drawing.Point(7, 16);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1, 236);
            this.panel3.TabIndex = 76;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Location = new System.Drawing.Point(542, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 236);
            this.panel1.TabIndex = 77;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Location = new System.Drawing.Point(136, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(407, 1);
            this.panel2.TabIndex = 78;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Teal;
            this.panel4.Location = new System.Drawing.Point(7, 252);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(536, 1);
            this.panel4.TabIndex = 79;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Teal;
            this.panel5.Location = new System.Drawing.Point(0, 9);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(10, 1);
            this.panel5.TabIndex = 80;
            // 
            // Manager_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(552, 264);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Manager_Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Manager_Dashboard_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnOpenSales;
        private System.Windows.Forms.Button btnCloseSales;
        private System.Windows.Forms.Button btnReprintValidator;
        private System.Windows.Forms.Button btnSalesModule;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label labelLoggedInUser;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
    }
}