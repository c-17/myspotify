using System;
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
    internal partial class AlbumControl : UserControl{
        #region PROPERTIES
        internal Button ButtonBack;

        internal Album Album;
        #endregion
        
        #region CONSTRUCTORS
        internal AlbumControl(Button ButtonBack){
            InitializeComponent();

            Dock = DockStyle.Fill;

            this.ButtonBack = ButtonBack;

            ButtonBack.Click += new EventHandler(ButtonBackClick);

            ParentChanged += new EventHandler(ArtistControlParentChanged);

            DataGridView.MouseWheel += new MouseEventHandler(DataGridViewMouseWheel);
            }
        #endregion
        
        #region FUNCTIONS
        internal AlbumControl UpdateAlbum(Album Album){
            this.Album = Album;

            ButtonBack.BackgroundImage = (((ButtonBack.Enabled = (Album != null)))?Properties.Resources.ic_back_white:Properties.Resources.ic_back_gray);

            PictureBox.BackgroundImage = Album.Thumbnail;

            LabelName.Text = Album.Name;

            LabelCountryGenre.Text = Album.Genre;

            TextBoxDescription.Text = Album.Description;

            ButtonAddToFavorites.BackgroundImage = (User.Instance.Albums.Contains(Album)?Properties.Resources.ic_favorite:Properties.Resources.ic_no_favorite);

            DataGridView.Rows.Clear();
            
            PanelControls.Controls.Clear();

            if(Album.Tracks != null && Album.Tracks.Count > 0){
                foreach(Track Track in Album.Tracks){
                    DataGridView.Rows.Add(new Object[]{Track.Name, Track.Duration});

                    DataGridView.Rows[DataGridView.Rows.Count-1].Tag = Track;
                    }

                PanelControls.Controls.Add(DataGridView);

                ActiveControl = DataGridView;
                }
            else{
                PanelControls.Controls.Add(Dashboard.Instance.WaitingControl);

                new Thread(new ThreadStart(delegate{
                    Album.Tracks = Internet.GetTracks(Album).Result;
                    
                    foreach(Track Track in Album.Tracks){
                        DataGridView.Rows.Add(new Object[]{Track.Name, Track.Duration});

                        DataGridView.Rows[DataGridView.Rows.Count-1].Tag = Track;
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
        
        private void ButtonBackClick(Object Object, EventArgs EventArgs){
            Dashboard.Instance.UpdateArtist(Album.Artist, Album);
            }

        private void ButtonAddToFavoritesClick(Object Object, EventArgs EventArgs){
            if(User.Instance.Albums.Contains(Album))
                User.Instance.Albums.Remove(Album);
            else
                User.Instance.Albums.Add(Album);
            
            ButtonAddToFavorites.BackgroundImage = (User.Instance.Albums.Contains(Album)?Properties.Resources.ic_favorite:Properties.Resources.ic_no_favorite);
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
            else if(MouseEventArgs.Delta < 0){
                if(DataGridView.FirstDisplayedScrollingRowIndex < DataGridView.Rows.Count-1)
                    DataGridView.FirstDisplayedScrollingRowIndex++;
                }
            }
        #endregion
        }
    }
