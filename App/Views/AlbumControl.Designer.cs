
namespace MySpotify.Views
{
    partial class AlbumControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PanelBackground = new System.Windows.Forms.Panel();
            this.TableLayoutPanelAll = new System.Windows.Forms.TableLayoutPanel();
            this.PanelControls = new System.Windows.Forms.Panel();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.TableLayoutPanelAlbum = new System.Windows.Forms.TableLayoutPanel();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.LabelAlbum = new System.Windows.Forms.Label();
            this.LabelName = new System.Windows.Forms.Label();
            this.LabelCountryGenre = new System.Windows.Forms.Label();
            this.ButtonAddToFavorites = new System.Windows.Forms.Button();
            this.TextBoxDescription = new System.Windows.Forms.TextBox();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PanelBackground.SuspendLayout();
            this.TableLayoutPanelAll.SuspendLayout();
            this.PanelControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.TableLayoutPanelAlbum.SuspendLayout();
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
            this.TableLayoutPanelAll.Controls.Add(this.TableLayoutPanelAlbum, 0, 0);
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
            this.Column2,
            this.Column1});
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
            this.DataGridView.CurrentCellDirtyStateChanged += new System.EventHandler(this.DataGridViewCurrentCellDirtyStateChanged);
            // 
            // TableLayoutPanelAlbum
            // 
            this.TableLayoutPanelAlbum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.TableLayoutPanelAlbum.ColumnCount = 3;
            this.TableLayoutPanelAlbum.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 175F));
            this.TableLayoutPanelAlbum.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanelAlbum.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.TableLayoutPanelAlbum.Controls.Add(this.PictureBox, 0, 0);
            this.TableLayoutPanelAlbum.Controls.Add(this.LabelAlbum, 1, 0);
            this.TableLayoutPanelAlbum.Controls.Add(this.LabelName, 1, 1);
            this.TableLayoutPanelAlbum.Controls.Add(this.LabelCountryGenre, 1, 3);
            this.TableLayoutPanelAlbum.Controls.Add(this.ButtonAddToFavorites, 2, 3);
            this.TableLayoutPanelAlbum.Controls.Add(this.TextBoxDescription, 1, 4);
            this.TableLayoutPanelAlbum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanelAlbum.Location = new System.Drawing.Point(0, 0);
            this.TableLayoutPanelAlbum.Margin = new System.Windows.Forms.Padding(0);
            this.TableLayoutPanelAlbum.Name = "TableLayoutPanelAlbum";
            this.TableLayoutPanelAlbum.RowCount = 7;
            this.TableLayoutPanelAlbum.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.TableLayoutPanelAlbum.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.TableLayoutPanelAlbum.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.TableLayoutPanelAlbum.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.TableLayoutPanelAlbum.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.TableLayoutPanelAlbum.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.TableLayoutPanelAlbum.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.TableLayoutPanelAlbum.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TableLayoutPanelAlbum.Size = new System.Drawing.Size(670, 175);
            this.TableLayoutPanelAlbum.TabIndex = 6;
            // 
            // PictureBox
            // 
            this.PictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureBox.Location = new System.Drawing.Point(5, 5);
            this.PictureBox.Margin = new System.Windows.Forms.Padding(5);
            this.PictureBox.Name = "PictureBox";
            this.TableLayoutPanelAlbum.SetRowSpan(this.PictureBox, 7);
            this.PictureBox.Size = new System.Drawing.Size(165, 165);
            this.PictureBox.TabIndex = 0;
            this.PictureBox.TabStop = false;
            // 
            // LabelAlbum
            // 
            this.LabelAlbum.AutoSize = true;
            this.TableLayoutPanelAlbum.SetColumnSpan(this.LabelAlbum, 2);
            this.LabelAlbum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelAlbum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelAlbum.Location = new System.Drawing.Point(178, 0);
            this.LabelAlbum.Name = "LabelAlbum";
            this.LabelAlbum.Size = new System.Drawing.Size(489, 24);
            this.LabelAlbum.TabIndex = 0;
            this.LabelAlbum.Text = "Album";
            this.LabelAlbum.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.TableLayoutPanelAlbum.SetColumnSpan(this.LabelName, 2);
            this.LabelName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 27F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.LabelName.Location = new System.Drawing.Point(175, 24);
            this.LabelName.Margin = new System.Windows.Forms.Padding(0);
            this.LabelName.Name = "LabelName";
            this.TableLayoutPanelAlbum.SetRowSpan(this.LabelName, 2);
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
            // TextBoxDescription
            // 
            this.TextBoxDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.TextBoxDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TableLayoutPanelAlbum.SetColumnSpan(this.TextBoxDescription, 2);
            this.TextBoxDescription.Cursor = System.Windows.Forms.Cursors.Default;
            this.TextBoxDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBoxDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.TextBoxDescription.ForeColor = System.Drawing.Color.White;
            this.TextBoxDescription.Location = new System.Drawing.Point(178, 102);
            this.TextBoxDescription.Multiline = true;
            this.TextBoxDescription.Name = "TextBoxDescription";
            this.TextBoxDescription.ReadOnly = true;
            this.TableLayoutPanelAlbum.SetRowSpan(this.TextBoxDescription, 3);
            this.TextBoxDescription.Size = new System.Drawing.Size(489, 70);
            this.TextBoxDescription.TabIndex = 3;
            this.TextBoxDescription.Text = "Description";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(202)))), ((int)(((byte)(88)))));
            this.Column2.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column2.HeaderText = "";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column1
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(202)))), ((int)(((byte)(88)))));
            this.Column1.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // AlbumControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.Controls.Add(this.PanelBackground);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "AlbumControl";
            this.Size = new System.Drawing.Size(670, 442);
            this.PanelBackground.ResumeLayout(false);
            this.TableLayoutPanelAll.ResumeLayout(false);
            this.PanelControls.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.TableLayoutPanelAlbum.ResumeLayout(false);
            this.TableLayoutPanelAlbum.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel TableLayoutPanelAll;
        private System.Windows.Forms.Label LabelAlbum;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.Panel PanelBackground;
        private System.Windows.Forms.Panel PanelControls;
        private System.Windows.Forms.Label LabelCountryGenre;
        private System.Windows.Forms.Button ButtonAddToFavorites;
        private System.Windows.Forms.TableLayoutPanel TableLayoutPanelAlbum;
        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.TextBox TextBoxDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}
