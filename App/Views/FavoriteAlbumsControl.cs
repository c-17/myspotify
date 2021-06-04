using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySpotify.Models;

namespace MySpotify.Views{
    internal partial class FavoriteAlbumsControl : UserControl{
        #region PROPERTIES
        #endregion
        
        #region CONSTRUCTORS
        internal FavoriteAlbumsControl(){
            InitializeComponent();

            Dock = DockStyle.Fill;
            }
        #endregion
        
        #region FUNCTIONS
        internal FavoriteAlbumsControl UpdateAlbums(){
            Controls.Clear();

            if(User.Instance.Artists.Count > 0){
                DataGridView.Rows.Clear();

                foreach(Album Album in User.Instance.Albums){
                    DataGridView.Rows.Add(new Object[]{Album.Thumbnail, Album.Name, Album.Released});

                    DataGridView.Rows[DataGridView.Rows.Count-1].Tag = Album;
                    }

                DataGridView.Dock = DockStyle.Fill;

                Controls.Add(DataGridView);
                }
            else{
                LabelNoArtists.Dock = DockStyle.Fill;

                Controls.Add(LabelNoArtists);
                }

            return this;
            }
        #endregion

        #region EVENTS
        private void DataGridViewCellMouseDoubleClick(Object Object, DataGridViewCellMouseEventArgs DataGridViewCellMouseEventArgs){
            Artist Artist = DataGridView.Rows[DataGridViewCellMouseEventArgs.RowIndex].Tag as Artist;
            
            Dashboard.Instance.UpdateArtist(Artist);
            }
        #endregion
        }
    }
