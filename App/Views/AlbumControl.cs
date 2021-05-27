using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

using MySpotify.Models;

namespace MySpotify.Views{
    internal partial class AlbumControl : UserControl{
        #region PROPERTIES
        internal Album Album;

        private readonly WaitingControl WaitingControl = new WaitingControl();
        #endregion
        
        #region CONSTRUCTORS
        internal AlbumControl(){
            InitializeComponent();

            Dock = DockStyle.Fill;

            PanelBackground2.BackColor = Color.FromArgb(75, 24, 202, 88);
            }
        #endregion
        
        #region FUNCTIONS
        internal AlbumControl UpdateAlbum(Album Album){
            this.Album = Album;

            LabelName.Text = Album.Name+", "+Album.Artist.Name;

            LabelCountryGenre.Text = Album.Genre;

            PanelBackground.BackgroundImage = Album.Thumbnail;

            DataGridView.Rows.Clear();

            if(Album.Tracks != null && Album.Tracks.Count > 0){
                foreach(Track Track in Album.Tracks){
                    DataGridView.Rows.Add(new Object[]{Properties.Resources.ic_song, Track.Name, Track.Duration});

                    DataGridView.Rows[DataGridView.Rows.Count-1].Tag = Track;
                    }
                }
            else{
                PanelControls.Controls.Add(WaitingControl);

                new Thread(new ThreadStart(delegate{
                    Album.Tracks = Internet.GetTracks(Album).Result;
                    
                    foreach(Track Track in Album.Tracks){
                        DataGridView.Rows.Add(new Object[]{Properties.Resources.ic_song, Track.Name, Track.Duration});

                        DataGridView.Rows[DataGridView.Rows.Count-1].Tag = Track;
                        }
                    
                    PanelControls.Controls.Clear();

                    PanelControls.Controls.Add(DataGridView);
                    })).Start();
                }

            return this;
            }
        #endregion

        #region EVENTS
        private void ButtonBackClick(Object Object, EventArgs EventArgs){
            Dashboard.Instance.UpdateArtist(Album.Artist, Album);
            }
        #endregion
        }
    }
