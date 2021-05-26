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

        internal Album Album;
        #endregion
        
        #region CONSTRUCTORS
        internal ArtistControl(){
            InitializeComponent();

            Dock = DockStyle.Fill;

            PanelBackground2.BackColor = Color.FromArgb(75, 24, 202, 88);
            }
        #endregion
        
        #region FUNCTIONS
        internal ArtistControl UpdateArtist(Artist Artist, Album Album = null){
            this.Artist = Artist;

            ButtonBack.Visible = (Album != null);

            LabelName.Text = Artist.Name;

            LabelCountryGenre.Text = Artist.Genre+", "+Artist.Country;

            PanelBackground.BackgroundImage = Artist.Thumbnail;

            DataGridView.Rows.Clear();

            if(Artist.Albums != null){
                foreach(Album A1bum in Artist.Albums){
                    DataGridView.Rows.Add(new Object[]{A1bum.Thumbnail, A1bum.Name});

                    DataGridView.Rows[DataGridView.Rows.Count-1].Tag = A1bum;
                    }
                }

            return this;
            }
        #endregion
        
        #region EVENTS
        private void DataGridViewCellMouseDoubleClick(Object Object, DataGridViewCellMouseEventArgs DataGridViewCellMouseEventArgs){
            Album = DataGridView.Rows[DataGridViewCellMouseEventArgs.RowIndex].Tag as Album;
            
            Dashboard.Instance.UpdateAlbum(Album);
            }

        private void ButtonBackClick(Object Object, EventArgs EventArgs){
            Dashboard.Instance.UpdateAlbum(Album);
            }
        #endregion
        }
    }
