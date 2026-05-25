namespace CoffeeBeanInventory
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.upperPanel = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lowerPanel = new System.Windows.Forms.Panel();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnUsers = new CoffeeBeanInventory.CustomerButton();
            this.btnRoast = new CoffeeBeanInventory.CustomerButton();
            this.btnCustomer = new CoffeeBeanInventory.CustomerButton();
            this.btnBeans = new CoffeeBeanInventory.CustomerButton();
            this.upperPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRoast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBeans)).BeginInit();
            this.SuspendLayout();
            // 
            // upperPanel
            // 
            this.upperPanel.BackColor = System.Drawing.Color.Beige;
            this.upperPanel.Controls.Add(this.btnUsers);
            this.upperPanel.Controls.Add(this.label9);
            this.upperPanel.Controls.Add(this.btnRoast);
            this.upperPanel.Controls.Add(this.label8);
            this.upperPanel.Controls.Add(this.btnCustomer);
            this.upperPanel.Controls.Add(this.label7);
            this.upperPanel.Controls.Add(this.btnBeans);
            this.upperPanel.Controls.Add(this.label6);
            this.upperPanel.Controls.Add(this.label3);
            this.upperPanel.Controls.Add(this.label5);
            this.upperPanel.Controls.Add(this.label2);
            this.upperPanel.Controls.Add(this.label1);
            this.upperPanel.Controls.Add(this.label4);
            this.upperPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.upperPanel.Location = new System.Drawing.Point(0, 0);
            this.upperPanel.Name = "upperPanel";
            this.upperPanel.Size = new System.Drawing.Size(982, 104);
            this.upperPanel.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lucida Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(628, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 21);
            this.label9.TabIndex = 21;
            this.label9.Text = "Users";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(535, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 21);
            this.label8.TabIndex = 19;
            this.label8.Text = "Types";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(412, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 21);
            this.label7.TabIndex = 17;
            this.label7.Text = "Customers";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(317, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 21);
            this.label6.TabIndex = 15;
            this.label6.Text = "Beans";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(2, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(276, 21);
            this.label3.TabIndex = 10;
            this.label3.Text = "Coffee Bean Inventory System";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Beige;
            this.label5.Font = new System.Drawing.Font("Lucida Sans", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(110, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 21);
            this.label5.TabIndex = 14;
            this.label5.Text = "oir";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 21);
            this.label2.TabIndex = 12;
            this.label2.Text = "afe";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 52);
            this.label1.TabIndex = 11;
            this.label1.Text = "C";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Calligraphy", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(58, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 52);
            this.label4.TabIndex = 13;
            this.label4.Text = "N";
            // 
            // lowerPanel
            // 
            this.lowerPanel.BackColor = System.Drawing.Color.Beige;
            this.lowerPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lowerPanel.Location = new System.Drawing.Point(0, 525);
            this.lowerPanel.Name = "lowerPanel";
            this.lowerPanel.Size = new System.Drawing.Size(982, 28);
            this.lowerPanel.TabIndex = 2;
            // 
            // mainPanel
            // 
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 104);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(982, 421);
            this.mainPanel.TabIndex = 3;
            // 
            // btnUsers
            // 
            this.btnUsers.Image = global::CoffeeBeanInventory.Properties.Resources.usersnormal;
            this.btnUsers.ImageHover = global::CoffeeBeanInventory.Properties.Resources.usershover;
            this.btnUsers.ImageNormal = global::CoffeeBeanInventory.Properties.Resources.usersnormal;
            this.btnUsers.Location = new System.Drawing.Point(629, 9);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(57, 63);
            this.btnUsers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnUsers.TabIndex = 22;
            this.btnUsers.TabStop = false;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnRoast
            // 
            this.btnRoast.Image = global::CoffeeBeanInventory.Properties.Resources.roasttypesnormal;
            this.btnRoast.ImageHover = global::CoffeeBeanInventory.Properties.Resources.roasttypeshover;
            this.btnRoast.ImageNormal = global::CoffeeBeanInventory.Properties.Resources.roasttypesnormal;
            this.btnRoast.Location = new System.Drawing.Point(539, 9);
            this.btnRoast.Name = "btnRoast";
            this.btnRoast.Size = new System.Drawing.Size(57, 63);
            this.btnRoast.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRoast.TabIndex = 20;
            this.btnRoast.TabStop = false;
            this.btnRoast.Click += new System.EventHandler(this.btnRoast_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.Image = global::CoffeeBeanInventory.Properties.Resources.customernormal;
            this.btnCustomer.ImageHover = global::CoffeeBeanInventory.Properties.Resources.customerhover;
            this.btnCustomer.ImageNormal = global::CoffeeBeanInventory.Properties.Resources.customernormal;
            this.btnCustomer.Location = new System.Drawing.Point(427, 9);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(57, 63);
            this.btnCustomer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCustomer.TabIndex = 18;
            this.btnCustomer.TabStop = false;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // btnBeans
            // 
            this.btnBeans.Image = global::CoffeeBeanInventory.Properties.Resources.beansnormal;
            this.btnBeans.ImageHover = global::CoffeeBeanInventory.Properties.Resources.beanshover;
            this.btnBeans.ImageNormal = global::CoffeeBeanInventory.Properties.Resources.beansnormal;
            this.btnBeans.Location = new System.Drawing.Point(321, 9);
            this.btnBeans.Name = "btnBeans";
            this.btnBeans.Size = new System.Drawing.Size(57, 63);
            this.btnBeans.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBeans.TabIndex = 16;
            this.btnBeans.TabStop = false;
            this.btnBeans.Click += new System.EventHandler(this.btnBeans_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.lowerPanel);
            this.Controls.Add(this.upperPanel);
            this.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Coffee Bean System";
            this.upperPanel.ResumeLayout(false);
            this.upperPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRoast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBeans)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel upperPanel;
        private System.Windows.Forms.Panel lowerPanel;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label6;
        private CustomerButton btnBeans;
        private CustomerButton btnUsers;
        private System.Windows.Forms.Label label9;
        private CustomerButton btnRoast;
        private System.Windows.Forms.Label label8;
        private CustomerButton btnCustomer;
        private System.Windows.Forms.Label label7;
    }
}

