
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PanelBackground = new System.Windows.Forms.Panel();
            this.PanelBackground2 = new System.Windows.Forms.Panel();
            this.TableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.TableLayoutPanelArtist = new System.Windows.Forms.TableLayoutPanel();
            this.LabelCountryGenre = new System.Windows.Forms.Label();
            this.ButtonPlay = new System.Windows.Forms.Button();
            this.ButtonFollow = new System.Windows.Forms.Button();
            this.LabelName = new System.Windows.Forms.Label();
            this.PanelControls = new System.Windows.Forms.Panel();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LabelAlbum = new System.Windows.Forms.Label();
            this.ButtonBack = new System.Windows.Forms.Button();
            this.PanelBackground.SuspendLayout();
            this.PanelBackground2.SuspendLayout();
            this.TableLayoutPanel.SuspendLayout();
            this.TableLayoutPanelArtist.SuspendLayout();
            this.PanelControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
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
            this.PanelBackground2.Controls.Add(this.TableLayoutPanel);
            this.PanelBackground2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelBackground2.Location = new System.Drawing.Point(0, 0);
            this.PanelBackground2.Margin = new System.Windows.Forms.Padding(0);
            this.PanelBackground2.Name = "PanelBackground2";
            this.PanelBackground2.Size = new System.Drawing.Size(670, 442);
            this.PanelBackground2.TabIndex = 1;
            // 
            // TableLayoutPanel
            // 
            this.TableLayoutPanel.BackColor = System.Drawing.Color.Transparent;
            this.TableLayoutPanel.ColumnCount = 1;
            this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanel.Controls.Add(this.TableLayoutPanelArtist, 0, 5);
            this.TableLayoutPanel.Controls.Add(this.PanelControls, 0, 8);
            this.TableLayoutPanel.Controls.Add(this.LabelAlbum, 0, 4);
            this.TableLayoutPanel.Controls.Add(this.ButtonBack, 0, 0);
            this.TableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.TableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.TableLayoutPanel.Name = "TableLayoutPanel";
            this.TableLayoutPanel.RowCount = 9;
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanel.Size = new System.Drawing.Size(670, 442);
            this.TableLayoutPanel.TabIndex = 0;
            // 
            // TableLayoutPanelArtist
            // 
            this.TableLayoutPanelArtist.ColumnCount = 4;
            this.TableLayoutPanelArtist.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanelArtist.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.TableLayoutPanelArtist.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.TableLayoutPanelArtist.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.TableLayoutPanelArtist.Controls.Add(this.LabelCountryGenre, 0, 2);
            this.TableLayoutPanelArtist.Controls.Add(this.ButtonPlay, 2, 2);
            this.TableLayoutPanelArtist.Controls.Add(this.ButtonFollow, 3, 2);
            this.TableLayoutPanelArtist.Controls.Add(this.LabelName, 0, 0);
            this.TableLayoutPanelArtist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanelArtist.Location = new System.Drawing.Point(0, 152);
            this.TableLayoutPanelArtist.Margin = new System.Windows.Forms.Padding(0);
            this.TableLayoutPanelArtist.Name = "TableLayoutPanelArtist";
            this.TableLayoutPanelArtist.RowCount = 3;
            this.TableLayoutPanel.SetRowSpan(this.TableLayoutPanelArtist, 3);
            this.TableLayoutPanelArtist.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TableLayoutPanelArtist.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TableLayoutPanelArtist.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TableLayoutPanelArtist.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TableLayoutPanelArtist.Size = new System.Drawing.Size(670, 64);
            this.TableLayoutPanelArtist.TabIndex = 2;
            // 
            // LabelCountryGenre
            // 
            this.LabelCountryGenre.AutoSize = true;
            this.TableLayoutPanelArtist.SetColumnSpan(this.LabelCountryGenre, 2);
            this.LabelCountryGenre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelCountryGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCountryGenre.Location = new System.Drawing.Point(3, 42);
            this.LabelCountryGenre.Name = "LabelCountryGenre";
            this.LabelCountryGenre.Size = new System.Drawing.Size(414, 22);
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
            this.ButtonFollow.Text = "Add to Fav";
            this.ButtonFollow.UseVisualStyleBackColor = false;
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.TableLayoutPanelArtist.SetColumnSpan(this.LabelName, 4);
            this.LabelName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 27F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.LabelName.Location = new System.Drawing.Point(0, 0);
            this.LabelName.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.LabelName.Name = "LabelName";
            this.TableLayoutPanelArtist.SetRowSpan(this.LabelName, 2);
            this.LabelName.Size = new System.Drawing.Size(667, 42);
            this.LabelName.TabIndex = 1;
            this.LabelName.Text = "Name";
            this.LabelName.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // PanelControls
            // 
            this.PanelControls.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PanelControls.Controls.Add(this.DataGridView);
            this.PanelControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelControls.Location = new System.Drawing.Point(0, 216);
            this.PanelControls.Margin = new System.Windows.Forms.Padding(0);
            this.PanelControls.Name = "PanelControls";
            this.PanelControls.Size = new System.Drawing.Size(670, 226);
            this.PanelControls.TabIndex = 5;
            // 
            // DataGridView
            // 
            this.DataGridView.AllowUserToAddRows = false;
            this.DataGridView.AllowUserToDeleteRows = false;
            this.DataGridView.AllowUserToResizeColumns = false;
            this.DataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.DataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.ColumnHeadersVisible = false;
            this.DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column3});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView.DefaultCellStyle = dataGridViewCellStyle4;
            this.DataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.DataGridView.Location = new System.Drawing.Point(0, 0);
            this.DataGridView.Margin = new System.Windows.Forms.Padding(0);
            this.DataGridView.MultiSelect = false;
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.ReadOnly = true;
            this.DataGridView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DataGridView.RowHeadersVisible = false;
            this.DataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DataGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DataGridView.RowTemplate.Height = 50;
            this.DataGridView.RowTemplate.ReadOnly = true;
            this.DataGridView.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView.ShowCellErrors = false;
            this.DataGridView.ShowEditingIcon = false;
            this.DataGridView.ShowRowErrors = false;
            this.DataGridView.Size = new System.Drawing.Size(670, 226);
            this.DataGridView.TabIndex = 3;
            this.DataGridView.CurrentCellDirtyStateChanged += new System.EventHandler(this.DataGridViewCurrentCellDirtyStateChanged);
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(202)))), ((int)(((byte)(88)))));
            this.Column2.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column2.HeaderText = "";
            this.Column2.MinimumWidth = 350;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(202)))), ((int)(((byte)(88)))));
            this.Column3.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column3.FillWeight = 25F;
            this.Column3.HeaderText = "";
            this.Column3.MinimumWidth = 150;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // LabelAlbum
            // 
            this.LabelAlbum.AutoSize = true;
            this.LabelAlbum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelAlbum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelAlbum.Location = new System.Drawing.Point(3, 128);
            this.LabelAlbum.Name = "LabelAlbum";
            this.LabelAlbum.Size = new System.Drawing.Size(664, 24);
            this.LabelAlbum.TabIndex = 0;
            this.LabelAlbum.Text = "Album";
            this.LabelAlbum.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // ButtonBack
            // 
            this.ButtonBack.BackgroundImage = global::MySpotify.Properties.Resources.ic_navigate_back;
            this.ButtonBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonBack.Dock = System.Windows.Forms.DockStyle.Left;
            this.ButtonBack.FlatAppearance.BorderSize = 0;
            this.ButtonBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ButtonBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ButtonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonBack.Location = new System.Drawing.Point(0, 0);
            this.ButtonBack.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(32, 32);
            this.ButtonBack.TabIndex = 4;
            this.ButtonBack.UseVisualStyleBackColor = true;
            this.ButtonBack.Click += new System.EventHandler(this.ButtonBackClick);
            // 
            // AlbumControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.Controls.Add(this.PanelBackground);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "AlbumControl";
            this.Size = new System.Drawing.Size(670, 442);
            this.PanelBackground.ResumeLayout(false);
            this.PanelBackground2.ResumeLayout(false);
            this.TableLayoutPanel.ResumeLayout(false);
            this.TableLayoutPanel.PerformLayout();
            this.TableLayoutPanelArtist.ResumeLayout(false);
            this.TableLayoutPanelArtist.PerformLayout();
            this.PanelControls.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelBackground;
        private System.Windows.Forms.TableLayoutPanel TableLayoutPanel;
        private System.Windows.Forms.Label LabelAlbum;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.TableLayoutPanel TableLayoutPanelArtist;
        private System.Windows.Forms.Button ButtonPlay;
        private System.Windows.Forms.Button ButtonFollow;
        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.Panel PanelBackground2;
        private System.Windows.Forms.Label LabelCountryGenre;
        private System.Windows.Forms.Button ButtonBack;
        private System.Windows.Forms.Panel PanelControls;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}
