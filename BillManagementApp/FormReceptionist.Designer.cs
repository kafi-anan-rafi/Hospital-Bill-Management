
namespace BillManagementApp
{
    partial class FormReceptionist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReceptionist));
            this.lblGreeting = new System.Windows.Forms.Label();
            this.pnlPrepareBill = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnBillList = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.btnPrepareBill = new System.Windows.Forms.Button();
            this.picTest = new System.Windows.Forms.PictureBox();
            this.picChangePassword = new System.Windows.Forms.PictureBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pnlPrepareBill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picChangePassword)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGreeting
            // 
            this.lblGreeting.AutoSize = true;
            this.lblGreeting.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGreeting.Location = new System.Drawing.Point(256, 84);
            this.lblGreeting.Name = "lblGreeting";
            this.lblGreeting.Size = new System.Drawing.Size(121, 29);
            this.lblGreeting.TabIndex = 0;
            this.lblGreeting.Text = "Welcome ";
            // 
            // pnlPrepareBill
            // 
            this.pnlPrepareBill.Controls.Add(this.btnLogout);
            this.pnlPrepareBill.Controls.Add(this.button1);
            this.pnlPrepareBill.Controls.Add(this.pictureBox2);
            this.pnlPrepareBill.Controls.Add(this.btnBillList);
            this.pnlPrepareBill.Controls.Add(this.pictureBox1);
            this.pnlPrepareBill.Controls.Add(this.btnChangePassword);
            this.pnlPrepareBill.Controls.Add(this.btnPrepareBill);
            this.pnlPrepareBill.Controls.Add(this.picTest);
            this.pnlPrepareBill.Controls.Add(this.picChangePassword);
            this.pnlPrepareBill.Controls.Add(this.lblGreeting);
            this.pnlPrepareBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPrepareBill.Location = new System.Drawing.Point(0, 0);
            this.pnlPrepareBill.Name = "pnlPrepareBill";
            this.pnlPrepareBill.Size = new System.Drawing.Size(800, 450);
            this.pnlPrepareBill.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(590, 305);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 37);
            this.button1.TabIndex = 17;
            this.button1.Text = "Add Patient";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(583, 163);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(130, 124);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // btnBillList
            // 
            this.btnBillList.Location = new System.Drawing.Point(268, 305);
            this.btnBillList.Name = "btnBillList";
            this.btnBillList.Size = new System.Drawing.Size(117, 37);
            this.btnBillList.TabIndex = 15;
            this.btnBillList.Text = "Bill List";
            this.btnBillList.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(261, 163);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 124);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Location = new System.Drawing.Point(410, 305);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(163, 37);
            this.btnChangePassword.TabIndex = 13;
            this.btnChangePassword.Text = "Change Password";
            this.btnChangePassword.UseVisualStyleBackColor = true;
            // 
            // btnPrepareBill
            // 
            this.btnPrepareBill.Location = new System.Drawing.Point(92, 305);
            this.btnPrepareBill.Name = "btnPrepareBill";
            this.btnPrepareBill.Size = new System.Drawing.Size(141, 37);
            this.btnPrepareBill.TabIndex = 12;
            this.btnPrepareBill.Text = "Prepare Bill";
            this.btnPrepareBill.UseVisualStyleBackColor = true;
            // 
            // picTest
            // 
            this.picTest.Image = ((System.Drawing.Image)(resources.GetObject("picTest.Image")));
            this.picTest.Location = new System.Drawing.Point(97, 163);
            this.picTest.Name = "picTest";
            this.picTest.Size = new System.Drawing.Size(130, 124);
            this.picTest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTest.TabIndex = 10;
            this.picTest.TabStop = false;
            // 
            // picChangePassword
            // 
            this.picChangePassword.Image = ((System.Drawing.Image)(resources.GetObject("picChangePassword.Image")));
            this.picChangePassword.Location = new System.Drawing.Point(426, 163);
            this.picChangePassword.Name = "picChangePassword";
            this.picChangePassword.Size = new System.Drawing.Size(130, 124);
            this.picChangePassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picChangePassword.TabIndex = 8;
            this.picChangePassword.TabStop = false;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(649, 28);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(113, 37);
            this.btnLogout.TabIndex = 20;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // FormReceptionist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlPrepareBill);
            this.MaximizeBox = false;
            this.Name = "FormReceptionist";
            this.Text = "Receptionist";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormReceptionist_FormClosed);
            this.pnlPrepareBill.ResumeLayout(false);
            this.pnlPrepareBill.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picChangePassword)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblGreeting;
        private System.Windows.Forms.Panel pnlPrepareBill;
        private System.Windows.Forms.PictureBox picTest;
        private System.Windows.Forms.PictureBox picChangePassword;
        private System.Windows.Forms.Button btnBillList;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Button btnPrepareBill;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnLogout;
    }
}