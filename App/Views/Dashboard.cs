using Microsoft.Win32;
using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Threading.Tasks;
using System.IO;
using System.Text;
using System.Management;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;

using MySpotify.Components;
using MySpotify.Models;

namespace MySpotify.Views{
    internal partial class Dashboard : Form{
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        private static extern bool ReleaseCapture();
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(Int32 nLeftRect, Int32 nTopRect, Int32 nRightRect, Int32 nBottomRect, Int32 nWidthEllipse, Int32 nHeightEllipse);

        #region PROPERTIES
        internal readonly WaitingControl WaitingControl = new WaitingControl();
        
        private readonly ArtistControl ArtistControl = new ArtistControl();
        
        private readonly AlbumControl AlbumControl = new AlbumControl();

        private readonly SearchControl SearchControl = new SearchControl();

        private readonly FavoriteArtistsControl FavoriteArtistsControl = new FavoriteArtistsControl();

        internal static Dashboard Instance;
        #endregion
        
        #region CONSTRUCTORS
        internal Dashboard(){
            InitializeComponent();

            Instance = this;

            PanelUser.Controls.Add(new CirclePictureBox(Properties.Resources.ic_user));

            TextBoxSearcher.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, TextBoxSearcher.Width, TextBoxSearcher.Height, 5, 5));
            }
        #endregion
        
        #region FUNCTIONS
        internal Dashboard UpdateArtist(Artist Artist, Album Album = null){
            LabelUser.Text = Program.User.Name;

            PanelControls.Controls.Clear();

            PanelControls.Controls.Add(ArtistControl.UpdateArtist(Artist, Album));

            return this;
            }

        internal Dashboard UpdateAlbum(Album Album){
            PanelControls.Controls.Clear();
            
            PanelControls.Controls.Add(AlbumControl.UpdateAlbum(Album));

            return this;
            }

        internal Dashboard UpdateFavorteArtists(){
            PanelControls.Controls.Clear();
            
            PanelControls.Controls.Add(FavoriteArtistsControl.UpdateArtists());

            return this;
            }
        #endregion
        
        #region EVENTS
        private void LabelMySpotifyMouseDown(Object Object, MouseEventArgs MouseEventArgs){
            if(MouseEventArgs.Button == MouseButtons.Left){
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                }
            }

        private void ButtonMinimizeClick(Object Object, EventArgs EventArgs) => WindowState = FormWindowState.Minimized;

        private void ButtonMaximizeClick(Object Object, EventArgs EventArgs) => WindowState = ((WindowState != FormWindowState.Maximized)?FormWindowState.Maximized:FormWindowState.Normal);
        
        /*private void ButtonMaximizeClick(Object Object, EventArgs EventArgs){
            if(WindowState == FormWindowState.Maximized)
                WindowState = FormWindowState.Normal;
            else{
                WindowState = FormWindowState.Maximized;
                Bounds = Screen.PrimaryScreen.WorkingArea;
                }
            }*/

        private void ButtonCloseClick(Object Object, EventArgs EventArgs) => Application.Exit();

        private async void TextBoxSearcherKeyUp(Object Object, KeyEventArgs KeyEventArgs){
            PanelControls.Controls.Clear();

            if(TextBoxSearcher.Text.Length >= 2){
                String Searching = Uri.EscapeDataString(TextBoxSearcher.Text.ToLower());

                if(Storage.ContainsArtist(Searching))
                    PanelControls.Controls.Add(SearchControl.UpdateArtists(new List<Artist>{Storage.GetArtist(Searching)}));
                else{
                    Artist Artist = await Internet.SearchArtist(Searching);

                    if(Artist != null)
                        PanelControls.Controls.Add(SearchControl.UpdateArtists(new List<Artist>{Artist}));
                    }
                }
            
            PanelControls.Controls.Add(WaitingControl);
            }

        private void ButtonExploreClick(Object Object, EventArgs EventArgs){
            PanelControls.Controls.Clear();
            
            PanelControls.Controls.Add(WaitingControl);

            new Thread(new ThreadStart(delegate{
                while(true){
                    if(Internet.IsConnected){
                        Artist Artist;

                        if((Artist = Internet.GetRandomArtist()) != null && UpdateArtist(Artist) != null)
                            break;
                        }
                    else
                        Thread.Sleep(2000);
                    }
                })).Start();
            }
        
        private void ButtonFavoriteArtistsClick(Object Object, EventArgs EventArgs) => UpdateFavorteArtists();
        #endregion
        private void Dashboard_ResizeEnd(object sender, EventArgs e)
        {
        }

        private void Dashboard_MaximizedBoundsChanged(object sender, EventArgs e)
        {

        }

        private void Dashboard_SizeChanged(object sender, EventArgs e)
        {
            
        }

        private void Dashboard_Resize(object sender, EventArgs e)
        {
        }
    }
    }
