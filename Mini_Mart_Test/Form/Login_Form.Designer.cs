namespace Mini_Mart_Test
{
    partial class Login_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Form));
            this.Username = new System.Windows.Forms.Label();
            this.BTN_Login = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_Password = new System.Windows.Forms.TextBox();
            this.Txt_Username = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.Location = new System.Drawing.Point(3, 165);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(91, 20);
            this.Username.TabIndex = 10;
            this.Username.Text = "Username:";
            // 
            // BTN_Login
            // 
            this.BTN_Login.Font = new System.Drawing.Font("Khmer OS Content", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Login.Location = new System.Drawing.Point(140, 286);
            this.BTN_Login.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTN_Login.Name = "BTN_Login";
            this.BTN_Login.Size = new System.Drawing.Size(132, 37);
            this.BTN_Login.TabIndex = 14;
            this.BTN_Login.Text = "Log in";
            this.BTN_Login.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Password:";
            // 
            // Txt_Password
            // 
            this.Txt_Password.Font = new System.Drawing.Font("Khmer OS Content", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Password.Location = new System.Drawing.Point(132, 208);
            this.Txt_Password.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_Password.Name = "Txt_Password";
            this.Txt_Password.PasswordChar = '*';
            this.Txt_Password.Size = new System.Drawing.Size(173, 39);
            this.Txt_Password.TabIndex = 13;
            this.Txt_Password.Text = "admin";
            // 
            // Txt_Username
            // 
            this.Txt_Username.Font = new System.Drawing.Font("Khmer OS Content", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Username.Location = new System.Drawing.Point(132, 158);
            this.Txt_Username.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_Username.Name = "Txt_Username";
            this.Txt_Username.Size = new System.Drawing.Size(173, 39);
            this.Txt_Username.TabIndex = 12;
            this.Txt_Username.Text = "Admin";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(69, 28);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(173, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(322, 505);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.BTN_Login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Txt_Password);
            this.Controls.Add(this.Txt_Username);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login_Form";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Button BTN_Login;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_Password;
        private System.Windows.Forms.TextBox Txt_Username;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}