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
    internal partial class ArtistControl : UserControl{
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(Int32 nLeftRect, Int32 nTopRect, Int32 nRightRect, Int32 nBottomRect, Int32 nWidthEllipse, Int32 nHeightEllipse);

        #region PROPERTIES
        internal Artist Artist;
        #endregion
        
        #region CONSTRUCTORS
        internal ArtistControl(){
            InitializeComponent();

            Dock = DockStyle.Fill;

            PanelBackground2.BackColor = Color.FromArgb(75, 24, 202, 88);
            }
        #endregion
        
        #region FUNCTIONS
        internal ArtistControl UpdateArtist(Artist Artist){
            this.Artist = Artist;

            LabelName.Text = Artist.Name;

            LabelCountryGenre.Text = Artist.Genre+", "+Artist.Country;

            PanelBackground.BackgroundImage = Artist.Thumbnail;

            DataGridView.Rows.Clear();

            if(Artist.Albums != null){
                foreach(Album Album in Artist.Albums){
                    DataGridView.Rows.Add(new Object[]{Album.Thumbnail, Album.Name});

                    DataGridView.Rows[DataGridView.Rows.Count-1].Tag = Album;
                    }
                }

            return this;
            }
        #endregion
        
        #region EVENTS
        private void DataGridViewCellMouseDoubleClick(Object Object, DataGridViewCellMouseEventArgs DataGridViewCellMouseEventArgs){
            Album Album = DataGridView.Rows[DataGridViewCellMouseEventArgs.RowIndex].Tag as Album;
            
            Dashboard.Instance.UpdateAlbum(Album);
            }
        #endregion
        }
    }
