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
    public partial class WaitingControl : UserControl{
        
        #region PROPERTIES
        private readonly Animation MyAnimation;
        #endregion
        
        #region CONSTRUCTORS
        public WaitingControl(){
            InitializeComponent();
            
            Dock = DockStyle.Fill;

            (MyAnimation = new Animation(Properties.Resources.MySpotify, PictureBox)).Start();
            }
        #endregion
        
        #region FUNCTIONS
        #endregion
        }
    }
