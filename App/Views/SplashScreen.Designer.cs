namespace MySpotify.Views
{
    partial class SplashScreen
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.PictureBoxSplashScreen = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxSplashScreen)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBoxSplashScreen
            // 
            this.PictureBoxSplashScreen.BackgroundImage = global::MySpotify.Properties.Resources.MySpotify;
            this.PictureBoxSplashScreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PictureBoxSplashScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureBoxSplashScreen.Location = new System.Drawing.Point(0, 0);
            this.PictureBoxSplashScreen.Margin = new System.Windows.Forms.Padding(0);
            this.PictureBoxSplashScreen.Name = "PictureBoxSplashScreen";
            this.PictureBoxSplashScreen.Size = new System.Drawing.Size(400, 200);
            this.PictureBoxSplashScreen.TabIndex = 1;
            this.PictureBoxSplashScreen.TabStop = false;
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(400, 200);
            this.ControlBox = false;
            this.Controls.Add(this.PictureBoxSplashScreen);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SplashScreen";
            this.Opacity = 0D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MySplashScreenFormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxSplashScreen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBoxSplashScreen;
    }
}

