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
    internal partial class FavoriteArtistsControl : UserControl{
        #region PROPERTIES
        #endregion
        
        #region CONSTRUCTORS
        internal FavoriteArtistsControl(){
            InitializeComponent();

            Dock = DockStyle.Fill;
            }
        #endregion
        
        #region FUNCTIONS
        internal FavoriteArtistsControl UpdateArtists(){
            Controls.Clear();

            if(User.Instance.Artists.Count > 0){
                DataGridView.Rows.Clear();

                foreach(Artist Artist in User.Instance.Artists){
                    DataGridView.Rows.Add(new Object[]{Artist.Thumbnail, Artist.Name, Artist.Biography});

                    DataGridView.Rows[DataGridView.Rows.Count-1].Tag = Artist;
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
