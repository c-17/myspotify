
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
            this.TableLayoutPanelAll = new System.Windows.Forms.TableLayoutPanel();
            this.PanelControls = new System.Windows.Forms.Panel();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.TableLayoutPanelArtist = new System.Windows.Forms.TableLayoutPanel();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.LabelArtist = new System.Windows.Forms.Label();
            this.LabelName = new System.Windows.Forms.Label();
            this.LabelCountryGenre = new System.Windows.Forms.Label();
            this.ButtonAddToFavorites = new System.Windows.Forms.Button();
            this.TextBoxBiography = new System.Windows.Forms.TextBox();
            this.Column1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PanelBackground.SuspendLayout();
            this.TableLayoutPanelAll.SuspendLayout();
            this.PanelControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.TableLayoutPanelArtist.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelBackground
            // 
            this.PanelBackground.Controls.Add(this.TableLayoutPanelAll);
            this.PanelBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelBackground.Location = new System.Drawing.Point(0, 0);
            this.PanelBackground.Margin = new System.Windows.Forms.Padding(0);
            this.PanelBackground.Name = "PanelBackground";
            this.PanelBackground.Size = new System.Drawing.Size(670, 442);
            this.PanelBackground.TabIndex = 1;
            // 
            // TableLayoutPanelAll
            // 
            this.TableLayoutPanelAll.BackColor = System.Drawing.Color.Transparent;
            this.TableLayoutPanelAll.ColumnCount = 1;
            this.TableLayoutPanelAll.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanelAll.Controls.Add(this.PanelControls, 0, 1);
            this.TableLayoutPanelAll.Controls.Add(this.TableLayoutPanelArtist, 0, 0);
            this.TableLayoutPanelAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanelAll.Location = new System.Drawing.Point(0, 0);
            this.TableLayoutPanelAll.Margin = new System.Windows.Forms.Padding(0);
            this.TableLayoutPanelAll.Name = "TableLayoutPanelAll";
            this.TableLayoutPanelAll.RowCount = 2;
            this.TableLayoutPanelAll.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 175F));
            this.TableLayoutPanelAll.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanelAll.Size = new System.Drawing.Size(670, 442);
            this.TableLayoutPanelAll.TabIndex = 0;
            // 
            // PanelControls
            // 
            this.PanelControls.Controls.Add(this.DataGridView);
            this.PanelControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelControls.Location = new System.Drawing.Point(5, 180);
            this.PanelControls.Margin = new System.Windows.Forms.Padding(5);
            this.PanelControls.Name = "PanelControls";
            this.PanelControls.Size = new System.Drawing.Size(660, 257);
            this.PanelControls.TabIndex = 5;
            // 
            // DataGridView
            // 
            this.DataGridView.AllowUserToAddRows = false;
            this.DataGridView.AllowUserToDeleteRows = false;
            this.DataGridView.AllowUserToResizeColumns = false;
            this.DataGridView.AllowUserToResizeRows = false;
            this.DataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.DataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.ColumnHeadersVisible = false;
            this.DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.DataGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.DataGridView.Location = new System.Drawing.Point(0, 0);
            this.DataGridView.Margin = new System.Windows.Forms.Padding(5);
            this.DataGridView.MultiSelect = false;
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.ReadOnly = true;
            this.DataGridView.RowHeadersVisible = false;
            this.DataGridView.RowTemplate.Height = 50;
            this.DataGridView.RowTemplate.ReadOnly = true;
            this.DataGridView.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView.ShowCellErrors = false;
            this.DataGridView.ShowEditingIcon = false;
            this.DataGridView.ShowRowErrors = false;
            this.DataGridView.Size = new System.Drawing.Size(660, 257);
            this.DataGridView.TabIndex = 3;
            this.DataGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridViewCellMouseDoubleClick);
            this.DataGridView.CurrentCellDirtyStateChanged += new System.EventHandler(this.DataGridViewCurrentCellDirtyStateChanged);
            // 
            // TableLayoutPanelArtist
            // 
            this.TableLayoutPanelArtist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.TableLayoutPanelArtist.ColumnCount = 3;
            this.TableLayoutPanelArtist.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 175F));
            this.TableLayoutPanelArtist.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanelArtist.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.TableLayoutPanelArtist.Controls.Add(this.PictureBox, 0, 0);
            this.TableLayoutPanelArtist.Controls.Add(this.LabelArtist, 1, 0);
            this.TableLayoutPanelArtist.Controls.Add(this.LabelName, 1, 1);
            this.TableLayoutPanelArtist.Controls.Add(this.LabelCountryGenre, 1, 3);
            this.TableLayoutPanelArtist.Controls.Add(this.ButtonAddToFavorites, 2, 3);
            this.TableLayoutPanelArtist.Controls.Add(this.TextBoxBiography, 1, 4);
            this.TableLayoutPanelArtist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanelArtist.Location = new System.Drawing.Point(0, 0);
            this.TableLayoutPanelArtist.Margin = new System.Windows.Forms.Padding(0);
            this.TableLayoutPanelArtist.Name = "TableLayoutPanelArtist";
            this.TableLayoutPanelArtist.RowCount = 7;
            this.TableLayoutPanelArtist.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.TableLayoutPanelArtist.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.TableLayoutPanelArtist.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.TableLayoutPanelArtist.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.TableLayoutPanelArtist.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.TableLayoutPanelArtist.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.TableLayoutPanelArtist.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.TableLayoutPanelArtist.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TableLayoutPanelArtist.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TableLayoutPanelArtist.Size = new System.Drawing.Size(670, 175);
            this.TableLayoutPanelArtist.TabIndex = 6;
            // 
            // PictureBox
            // 
            this.PictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureBox.Location = new System.Drawing.Point(5, 5);
            this.PictureBox.Margin = new System.Windows.Forms.Padding(5);
            this.PictureBox.Name = "PictureBox";
            this.TableLayoutPanelArtist.SetRowSpan(this.PictureBox, 7);
            this.PictureBox.Size = new System.Drawing.Size(165, 165);
            this.PictureBox.TabIndex = 0;
            this.PictureBox.TabStop = false;
            // 
            // LabelArtist
            // 
            this.LabelArtist.AutoSize = true;
            this.TableLayoutPanelArtist.SetColumnSpan(this.LabelArtist, 2);
            this.LabelArtist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelArtist.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelArtist.Location = new System.Drawing.Point(178, 0);
            this.LabelArtist.Name = "LabelArtist";
            this.LabelArtist.Size = new System.Drawing.Size(489, 24);
            this.LabelArtist.TabIndex = 0;
            this.LabelArtist.Text = "Artist";
            this.LabelArtist.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.TableLayoutPanelArtist.SetColumnSpan(this.LabelName, 2);
            this.LabelName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 27F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.LabelName.Location = new System.Drawing.Point(175, 24);
            this.LabelName.Margin = new System.Windows.Forms.Padding(0);
            this.LabelName.Name = "LabelName";
            this.TableLayoutPanelArtist.SetRowSpan(this.LabelName, 2);
            this.LabelName.Size = new System.Drawing.Size(495, 50);
            this.LabelName.TabIndex = 1;
            this.LabelName.Text = "Name";
            this.LabelName.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // LabelCountryGenre
            // 
            this.LabelCountryGenre.AutoSize = true;
            this.LabelCountryGenre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelCountryGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCountryGenre.Location = new System.Drawing.Point(178, 74);
            this.LabelCountryGenre.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.LabelCountryGenre.Name = "LabelCountryGenre";
            this.LabelCountryGenre.Size = new System.Drawing.Size(468, 25);
            this.LabelCountryGenre.TabIndex = 2;
            this.LabelCountryGenre.Text = "Country";
            // 
            // ButtonAddToFavorites
            // 
            this.ButtonAddToFavorites.BackColor = System.Drawing.Color.Transparent;
            this.ButtonAddToFavorites.BackgroundImage = global::MySpotify.Properties.Resources.ic_no_favorite;
            this.ButtonAddToFavorites.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonAddToFavorites.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonAddToFavorites.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonAddToFavorites.FlatAppearance.BorderSize = 0;
            this.ButtonAddToFavorites.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ButtonAddToFavorites.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ButtonAddToFavorites.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAddToFavorites.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.ButtonAddToFavorites.ForeColor = System.Drawing.Color.Transparent;
            this.ButtonAddToFavorites.Location = new System.Drawing.Point(649, 77);
            this.ButtonAddToFavorites.Margin = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.ButtonAddToFavorites.Name = "ButtonAddToFavorites";
            this.ButtonAddToFavorites.Size = new System.Drawing.Size(14, 19);
            this.ButtonAddToFavorites.TabIndex = 1;
            this.ButtonAddToFavorites.UseVisualStyleBackColor = false;
            this.ButtonAddToFavorites.Click += new System.EventHandler(this.ButtonAddToFavoritesClick);
            // 
            // TextBoxBiography
            // 
            this.TextBoxBiography.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.TextBoxBiography.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TableLayoutPanelArtist.SetColumnSpan(this.TextBoxBiography, 2);
            this.TextBoxBiography.Cursor = System.Windows.Forms.Cursors.Default;
            this.TextBoxBiography.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.TextBoxBiography.ForeColor = System.Drawing.Color.White;
            this.TextBoxBiography.Location = new System.Drawing.Point(178, 102);
            this.TextBoxBiography.Multiline = true;
            this.TextBoxBiography.Name = "TextBoxBiography";
            this.TextBoxBiography.ReadOnly = true;
            this.TableLayoutPanelArtist.SetRowSpan(this.TextBoxBiography, 3);
            this.TextBoxBiography.Size = new System.Drawing.Size(489, 70);
            this.TextBoxBiography.TabIndex = 3;
            this.TextBoxBiography.Text = "Biography";
            // 
            // Column1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle1.NullValue")));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(202)))), ((int)(((byte)(88)))));
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
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(202)))), ((int)(((byte)(88)))));
            this.Column2.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column2.HeaderText = "";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ArtistControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.Controls.Add(this.PanelBackground);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "ArtistControl";
            this.Size = new System.Drawing.Size(670, 442);
            this.PanelBackground.ResumeLayout(false);
            this.TableLayoutPanelAll.ResumeLayout(false);
            this.PanelControls.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.TableLayoutPanelArtist.ResumeLayout(false);
            this.TableLayoutPanelArtist.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel TableLayoutPanelAll;
        private System.Windows.Forms.Label LabelArtist;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.Panel PanelBackground;
        private System.Windows.Forms.Panel PanelControls;
        private System.Windows.Forms.Label LabelCountryGenre;
        private System.Windows.Forms.Button ButtonAddToFavorites;
        private System.Windows.Forms.TableLayoutPanel TableLayoutPanelArtist;
        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.TextBox TextBoxBiography;
        private System.Windows.Forms.DataGridViewImageColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}
