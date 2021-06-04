
namespace MySpotify.Views
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.LabelPassword = new System.Windows.Forms.Label();
            this.LabelUser = new System.Windows.Forms.Label();
            this.ButtonStartSession = new System.Windows.Forms.Button();
            this.TextBoxPassword = new System.Windows.Forms.TextBox();
            this.TextBoxUser = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.50135F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 64.49864F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(234, 362);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImage = global::MySpotify.Properties.Resources.Spotify;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tableLayoutPanel1.SetColumnSpan(this.pictureBox1, 2);
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(234, 128);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel2, 2);
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 128);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(234, 234);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.panel1, 2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.LabelPassword);
            this.panel1.Controls.Add(this.LabelUser);
            this.panel1.Controls.Add(this.ButtonStartSession);
            this.panel1.Controls.Add(this.TextBoxPassword);
            this.panel1.Controls.Add(this.TextBoxUser);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.tableLayoutPanel2.SetRowSpan(this.panel1, 2);
            this.panel1.Size = new System.Drawing.Size(234, 234);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(170, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Ver 1.0.0";
            // 
            // LabelPassword
            // 
            this.LabelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPassword.Location = new System.Drawing.Point(10, 69);
            this.LabelPassword.Name = "LabelPassword";
            this.LabelPassword.Size = new System.Drawing.Size(89, 15);
            this.LabelPassword.TabIndex = 10;
            this.LabelPassword.Text = "Contraseña:";
            // 
            // LabelUser
            // 
            this.LabelUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelUser.Location = new System.Drawing.Point(10, 28);
            this.LabelUser.Name = "LabelUser";
            this.LabelUser.Size = new System.Drawing.Size(73, 15);
            this.LabelUser.TabIndex = 9;
            this.LabelUser.Text = "Usuario:";
            // 
            // ButtonStartSession
            // 
            this.ButtonStartSession.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(202)))), ((int)(((byte)(88)))));
            this.ButtonStartSession.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ButtonStartSession.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonStartSession.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonStartSession.ForeColor = System.Drawing.Color.Black;
            this.ButtonStartSession.Location = new System.Drawing.Point(13, 144);
            this.ButtonStartSession.Name = "ButtonStartSession";
            this.ButtonStartSession.Size = new System.Drawing.Size(207, 34);
            this.ButtonStartSession.TabIndex = 8;
            this.ButtonStartSession.Text = "Iniciar Sesión";
            this.ButtonStartSession.UseVisualStyleBackColor = false;
            this.ButtonStartSession.Click += new System.EventHandler(this.ButtonStartSessionClick);
            // 
            // TextBoxPassword
            // 
            this.TextBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxPassword.Location = new System.Drawing.Point(13, 87);
            this.TextBoxPassword.Name = "TextBoxPassword";
            this.TextBoxPassword.Size = new System.Drawing.Size(207, 21);
            this.TextBoxPassword.TabIndex = 7;
            this.TextBoxPassword.Text = "Tester";
            this.TextBoxPassword.UseSystemPasswordChar = true;
            this.TextBoxPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxUserPasswordKeyDown);
            this.TextBoxPassword.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBoxPasswordKeyUp);
            // 
            // TextBoxUser
            // 
            this.TextBoxUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxUser.Location = new System.Drawing.Point(13, 46);
            this.TextBoxUser.Name = "TextBoxUser";
            this.TextBoxUser.Size = new System.Drawing.Size(207, 21);
            this.TextBoxUser.TabIndex = 6;
            this.TextBoxUser.Text = "Tester";
            this.TextBoxUser.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxUserPasswordKeyDown);
            this.TextBoxUser.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBoxUserKeyUp);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 362);
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(250, 400);
            this.MinimumSize = new System.Drawing.Size(250, 400);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Spotify";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LabelPassword;
        private System.Windows.Forms.Label LabelUser;
        private System.Windows.Forms.Button ButtonStartSession;
        private System.Windows.Forms.TextBox TextBoxPassword;
        private System.Windows.Forms.TextBox TextBoxUser;
        private System.Windows.Forms.Label label1;
    }
}