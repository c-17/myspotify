
namespace MySpotify.Views
{
    partial class ArtistControl
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ArtistControl));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PanelBackground = new System.Windows.Forms.Panel();
            this.PanelBackground2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.LabelCountryGenre = new System.Windows.Forms.Label();
            this.ButtonPlay = new System.Windows.Forms.Button();
            this.ButtonFollow = new System.Windows.Forms.Button();
            this.LabelName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PanelBackground.SuspendLayout();
            this.PanelBackground2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelBackground
            // 
            this.PanelBackground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelBackground.Controls.Add(this.PanelBackground2);
            this.PanelBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelBackground.Location = new System.Drawing.Point(0, 0);
            this.PanelBackground.Margin = new System.Windows.Forms.Padding(0);
            this.PanelBackground.Name = "PanelBackground";
            this.PanelBackground.Size = new System.Drawing.Size(670, 442);
            this.PanelBackground.TabIndex = 0;
            // 
            // PanelBackground2
            // 
            this.PanelBackground2.Controls.Add(this.tableLayoutPanel1);
            this.PanelBackground2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelBackground2.Location = new System.Drawing.Point(0, 0);
            this.PanelBackground2.Margin = new System.Windows.Forms.Padding(0);
            this.PanelBackground2.Name = "PanelBackground2";
            this.PanelBackground2.Size = new System.Drawing.Size(670, 442);
            this.PanelBackground2.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.DataGridView, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(670, 442);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // DataGridView
            // 
            this.DataGridView.AllowUserToAddRows = false;
            this.DataGridView.AllowUserToDeleteRows = false;
            this.DataGridView.AllowUserToResizeColumns = false;
            this.DataGridView.AllowUserToResizeRows = false;
            this.DataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.DataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.ColumnHeadersVisible = false;
            this.DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.DataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridView.Location = new System.Drawing.Point(0, 216);
            this.DataGridView.Margin = new System.Windows.Forms.Padding(0);
            this.DataGridView.MultiSelect = false;
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.ReadOnly = true;
            this.DataGridView.RowHeadersVisible = false;
            this.DataGridView.RowTemplate.Height = 50;
            this.DataGridView.RowTemplate.ReadOnly = true;
            this.DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView.ShowCellErrors = false;
            this.DataGridView.ShowEditingIcon = false;
            this.DataGridView.ShowRowErrors = false;
            this.DataGridView.Size = new System.Drawing.Size(670, 226);
            this.DataGridView.TabIndex = 3;
            this.DataGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridViewCellMouseDoubleClick);
            // 
            // Column1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle1.NullValue")));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(202)))), ((int)(((byte)(88)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column1.Frozen = true;
            this.Column1.HeaderText = "";
            this.Column1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Column1.MinimumWidth = 50;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(202)))), ((int)(((byte)(88)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column2.HeaderText = "";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.tableLayoutPanel2.Controls.Add(this.LabelCountryGenre, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.ButtonPlay, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.ButtonFollow, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.LabelName, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 152);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel1.SetRowSpan(this.tableLayoutPanel2, 3);
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(670, 64);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // LabelCountryGenre
            // 
            this.LabelCountryGenre.AutoSize = true;
            this.LabelCountryGenre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelCountryGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCountryGenre.Location = new System.Drawing.Point(3, 42);
            this.LabelCountryGenre.Name = "LabelCountryGenre";
            this.LabelCountryGenre.Size = new System.Drawing.Size(289, 22);
            this.LabelCountryGenre.TabIndex = 2;
            this.LabelCountryGenre.Text = "Country";
            // 
            // ButtonPlay
            // 
            this.ButtonPlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(202)))), ((int)(((byte)(88)))));
            this.ButtonPlay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonPlay.FlatAppearance.BorderSize = 0;
            this.ButtonPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.ButtonPlay.Location = new System.Drawing.Point(420, 42);
            this.ButtonPlay.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonPlay.Name = "ButtonPlay";
            this.ButtonPlay.Size = new System.Drawing.Size(125, 22);
            this.ButtonPlay.TabIndex = 0;
            this.ButtonPlay.Text = "Play";
            this.ButtonPlay.UseVisualStyleBackColor = false;
            // 
            // ButtonFollow
            // 
            this.ButtonFollow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.ButtonFollow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonFollow.FlatAppearance.BorderSize = 0;
            this.ButtonFollow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonFollow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.ButtonFollow.Location = new System.Drawing.Point(545, 42);
            this.ButtonFollow.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonFollow.Name = "ButtonFollow";
            this.ButtonFollow.Size = new System.Drawing.Size(125, 22);
            this.ButtonFollow.TabIndex = 1;
            this.ButtonFollow.Text = "Follow";
            this.ButtonFollow.UseVisualStyleBackColor = false;
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 27F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.LabelName.Location = new System.Drawing.Point(0, 0);
            this.LabelName.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.LabelName.Name = "LabelName";
            this.tableLayoutPanel2.SetRowSpan(this.LabelName, 2);
            this.LabelName.Size = new System.Drawing.Size(292, 42);
            this.LabelName.TabIndex = 1;
            this.LabelName.Text = "Name";
            this.LabelName.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(664, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Artist";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // ArtistControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.Controls.Add(this.PanelBackground);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "ArtistControl";
            this.Size = new System.Drawing.Size(670, 442);
            this.PanelBackground.ResumeLayout(false);
            this.PanelBackground2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelBackground;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button ButtonPlay;
        private System.Windows.Forms.Button ButtonFollow;
        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.Panel PanelBackground2;
        private System.Windows.Forms.Label LabelCountryGenre;
        private System.Windows.Forms.DataGridViewImageColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}
