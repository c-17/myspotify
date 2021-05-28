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
        #endregion
        
        #region CONSTRUCTORS
        internal AlbumControl(){
            InitializeComponent();

            Dock = DockStyle.Fill;
            
            PanelBackground2.BackColor = Color.FromArgb(75, 24, 202, 88);

            ParentChanged += new EventHandler(AlbumControlParentChanged);

            DataGridView.MouseWheel += new MouseEventHandler(DataGridViewMouseWheel);
            }
        #endregion
        
        #region FUNCTIONS
        internal AlbumControl UpdateAlbum(Album Album){
            this.Album = Album;

            LabelName.Text = Album.Name+", "+Album.Artist.Name;

            LabelCountryGenre.Text = Album.Genre;

            PanelBackground.BackgroundImage = Album.Thumbnail;
            
            DataGridView.Rows.Clear();
            
            PanelControls.Controls.Clear();

            if(Album.Tracks != null && Album.Tracks.Count > 0){
                foreach(Track Track in Album.Tracks){
                    DataGridView.Rows.Add(new Object[]{Track.Name, Track.Duration});

                    DataGridViewRow DataGridViewRow = DataGridView.Rows[DataGridView.Rows.Count-1];

                    DataGridViewRow.Tag = Track;
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
        private void AlbumControlParentChanged(Object Object, EventArgs EventArgs){
            /*if(Parent != null && Visible)
                ActiveControl = DataGridView;*/
            }

        private void ButtonBackClick(Object Object, EventArgs EventArgs){
            Dashboard.Instance.UpdateArtist(Album.Artist, Album);
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
