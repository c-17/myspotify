﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

using MySpotify.Models;
using MySpotify.Components;

namespace MySpotify.Views{
    internal partial class ArtistControl : UserControl{
        #region PROPERTIES
        internal Artist Artist;

        internal Album Album;
        #endregion
        
        #region CONSTRUCTORS
        internal ArtistControl(){
            InitializeComponent();

            Dock = DockStyle.Fill;

            PanelBackground2.BackColor = Color.FromArgb(75, 33, 33, 33);

            ParentChanged += new EventHandler(ArtistControlParentChanged);

            DataGridView.MouseWheel += new MouseEventHandler(DataGridViewMouseWheel);
            }
        #endregion
        
        #region FUNCTIONS
        internal ArtistControl UpdateArtist(Artist Artist, Album Album = null){
            this.Artist = Artist;

            //ButtonBack.Visible = (Album != null);

            PictureBoxArtist.BackgroundImage = Artist.Thumbnail;

            LabelName.Text = Artist.Name;

            LabelCountryGenre.Text = Artist.Genre+", "+Artist.Country;

            LabelBiography.Text = Artist.Biography;

            ButtonAddToFavorites.BackgroundImage = (User.Instance.Artists.Contains(Artist)?Properties.Resources.ic_favorite:Properties.Resources.ic_no_favorite);

            DataGridView.Rows.Clear();
            
            PanelControls.Controls.Clear();

            if(Artist.Albums != null && Artist.Albums.Count > 0){
                foreach(Album A1bum in Artist.Albums){
                    DataGridView.Rows.Add(new Object[]{A1bum.Thumbnail, A1bum.Name});

                    DataGridView.Rows[DataGridView.Rows.Count-1].Tag = A1bum;
                    }

                PanelControls.Controls.Add(DataGridView);

                ActiveControl = DataGridView;
                }
            else{
                PanelControls.Controls.Add(Dashboard.Instance.WaitingControl);

                new Thread(new ThreadStart(delegate{
                    Artist.Albums = Internet.SearchAlbums(Artist).Result;

                    if(Artist.Albums != null){
                        foreach(Album A1bum in Artist.Albums){
                            DataGridView.Rows.Add(new Object[]{A1bum.Thumbnail, A1bum.Name});

                            DataGridView.Rows[DataGridView.Rows.Count-1].Tag = A1bum;
                            }
                        }
                    
                    PanelControls.Controls.Clear();
                    
                    PanelControls.Controls.Add(DataGridView);
                
                    ActiveControl = DataGridView;
                    })).Start();
                }

            return this;
            }
        #endregion
        
        #region EVENTS
        private void ArtistControlParentChanged(Object Object, EventArgs EventArgs){
            /*if(Parent != null && Visible)
                ActiveControl = DataGridView;*/
            }

        private void TableLayoutPanelArtistPaint(object sender, PaintEventArgs e){
            Graphics Graphics = e.Graphics;

            Rectangle Rectangle = new Rectangle(0, 0, TableLayoutPanelArtist.Width, TableLayoutPanelArtist.Height);

            Brush Brush = new LinearGradientBrush(Rectangle, Color.FromArgb(22, 22, 22), Color.FromArgb(33, 33, 33), LinearGradientMode.Vertical);  

            Graphics.FillRectangle(Brush, Rectangle);
            }

        private void ButtonBackClick(Object Object, EventArgs EventArgs){
            Dashboard.Instance.UpdateAlbum(Album);
            }

        private void ButtonAddToFavoritesClick(Object Object, EventArgs EventArgs){
            if(User.Instance.Artists.Contains(Artist))
                User.Instance.Artists.Remove(Artist);
            else
                User.Instance.Artists.Add(Artist);
            
            ButtonAddToFavorites.BackgroundImage = (User.Instance.Artists.Contains(Artist)?Properties.Resources.ic_favorite:Properties.Resources.ic_no_favorite);
            }

        private void DataGridViewCellMouseDoubleClick(Object Object, DataGridViewCellMouseEventArgs DataGridViewCellMouseEventArgs){
            Album = DataGridView.Rows[DataGridViewCellMouseEventArgs.RowIndex].Tag as Album;
            
            Dashboard.Instance.UpdateAlbum(Album);
            }
        
        private void DataGridViewCurrentCellDirtyStateChanged(Object Object, EventArgs EventArgs){
            if(DataGridView.IsCurrentCellDirty)
                DataGridView.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }

        private void DataGridViewMouseWheel(Object Object, MouseEventArgs MouseEventArgs){
            if(MouseEventArgs.Delta > 0){
                if(DataGridView.FirstDisplayedScrollingRowIndex > 0)
                    DataGridView.FirstDisplayedScrollingRowIndex--;
                }
            else if(MouseEventArgs.Delta < 0)
                if(DataGridView.FirstDisplayedScrollingRowIndex < DataGridView.Rows.Count-1)
                    DataGridView.FirstDisplayedScrollingRowIndex++;
            }
        #endregion
        }
    }
