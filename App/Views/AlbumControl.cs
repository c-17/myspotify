using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

using MySpotify.Models;

namespace MySpotify.Views{
    internal partial class AlbumControl : UserControl{
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(Int32 nLeftRect, Int32 nTopRect, Int32 nRightRect, Int32 nBottomRect, Int32 nWidthEllipse, Int32 nHeightEllipse);

        #region PROPERTIES
        internal Album Album;
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

            DataGridViewTracks.Rows.Clear();

            if(Album.Tracks != null){
                foreach(Track Track in Album.Tracks){

                    TimeSpan t = TimeSpan.FromMilliseconds(Track.Duration);
                    string answer = string.Format("{1:D2}m:{2:D2}s", 
                        t.Hours, 
                        t.Minutes, 
                        t.Seconds, 
                        t.Milliseconds);

                    DataGridViewTracks.Rows.Add(new Object[]{Properties.Resources.ic_song, Track.Name, answer});

                    DataGridViewTracks.Rows[DataGridViewTracks.Rows.Count-1].Tag = Track;
                    }
                }

            return this;
            }
        #endregion
        
        #region EVENTS
        #endregion
        }
    }
