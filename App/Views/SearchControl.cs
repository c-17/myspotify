﻿using System;
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
    internal partial class SearchControl : UserControl{
        
        #region PROPERTIES
        #endregion
        
        #region CONSTRUCTORS
        internal SearchControl(){
            InitializeComponent();

            Dock = DockStyle.Fill;
            }
        #endregion
        
        #region FUNCTIONS
        internal SearchControl UpdateArtists(List<Artist> Artists){
            DataGridView.Rows.Clear();

            foreach(Artist Artist in Artists){
                DataGridView.Rows.Add(new Object[]{Artist.Thumbnail, Artist.Name, Artist.Biography});

                DataGridView.Rows[DataGridView.Rows.Count-1].Tag = Artist;
                }

            return this;
            }
        #endregion

        #region EVENTS
        private void DataGridView_CellMouseDoubleClick(Object Object, DataGridViewCellMouseEventArgs DataGridViewCellMouseEventArgs){
            Artist Artist = DataGridView.Rows[DataGridViewCellMouseEventArgs.RowIndex].Tag as Artist;
            
            Dashboard.Instance.UpdateArtist(Artist);
            }
        #endregion
        }
    }
