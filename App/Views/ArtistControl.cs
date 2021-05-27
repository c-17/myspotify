﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

using MySpotify.Models;
using System.Reflection;

namespace MySpotify.Views{
    internal partial class ArtistControl : UserControl{
        #region PROPERTIES
        internal Artist Artist;

        internal Album Album;

        private readonly WaitingControl WaitingControl = new WaitingControl();
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
            
            PanelControls.Controls.Clear();

            if(Artist.Albums != null && Artist.Albums.Count > 0){
                foreach(Album A1bum in Artist.Albums){
                    DataGridView.Rows.Add(new Object[]{A1bum.Thumbnail, A1bum.Name});

                    DataGridView.Rows[DataGridView.Rows.Count-1].Tag = A1bum;
                    }

                PanelControls.Controls.Add(DataGridView);
                }
            else{
                PanelControls.Controls.Add(WaitingControl);

                new Thread(new ThreadStart(delegate{
                    Artist.Albums = Internet.SearchAlbums(Artist).Result;

                    foreach(Album A1bum in Artist.Albums){
                        DataGridView.Rows.Add(new Object[]{A1bum.Thumbnail, A1bum.Name});

                        DataGridView.Rows[DataGridView.Rows.Count-1].Tag = A1bum;
                        }
                    
                    PanelControls.Controls.Clear();
                    
                    PanelControls.Controls.Add(DataGridView);
                    })).Start();
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
