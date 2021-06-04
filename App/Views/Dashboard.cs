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
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(Int32 nLeftRect, Int32 nTopRect, Int32 nRightRect, Int32 nBottomRect, Int32 nWidthEllipse, Int32 nHeightEllipse);

        #region PROPERTIES
        internal readonly WaitingControl WaitingControl = new WaitingControl();
        
        private readonly ArtistControl ArtistControl;
        
        private readonly AlbumControl AlbumControl;

        private readonly SearchControl SearchControl = new SearchControl();

        private readonly FavoriteArtistsControl FavoriteArtistsControl = new FavoriteArtistsControl();

        private readonly FavoriteAlbumsControl FavoriteAlbumsControl = new FavoriteAlbumsControl();

        internal static Dashboard Instance;
        #endregion
        
        #region CONSTRUCTORS
        internal Dashboard(){
            InitializeComponent();
            
            ArtistControl = new ArtistControl(ButtonNext);
        
            AlbumControl = new AlbumControl(ButtonBack);

            Instance = this;

            PanelUser.Controls.Add(new CirclePictureBox(Properties.Resources.ic_user));

            TextBoxSearcher.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, TextBoxSearcher.Width, TextBoxSearcher.Height, 5, 5));
            
            ButtonBack.GotFocus += new EventHandler(RemoveFocus);
            ButtonNext.GotFocus += new EventHandler(RemoveFocus);

            ButtonExplore.GotFocus += new EventHandler(RemoveFocus);

            ButtonFavoriteArtists.GotFocus += new EventHandler(RemoveFocus);
            ButtonFavoriteAlbums.GotFocus += new EventHandler(RemoveFocus);
            ButtonFavoriteSongs.GotFocus += new EventHandler(RemoveFocus);
            }
        #endregion
        
        #region FUNCTIONS
        internal Dashboard Init(){
            LabelUser.Text = Program.User.Name;
            
            return this;
            }

        internal Dashboard UpdateArtist(Artist Artist, Album Album = null){
            ButtonBack.BackgroundImage = Properties.Resources.ic_back_gray;

            ButtonBack.Enabled = false;

            PanelControls.Controls.Clear();

            PanelControls.Controls.Add(ArtistControl.UpdateArtist(Artist, Album));

            return this;
            }

        internal Dashboard UpdateAlbum(Album Album){
            ButtonNext.BackgroundImage = Properties.Resources.ic_next_gray;

            ButtonNext.Enabled = false;

            PanelControls.Controls.Clear();
            
            PanelControls.Controls.Add(AlbumControl.UpdateAlbum(Album));

            return this;
            }

        internal Dashboard UpdateFavorteArtists(){
            ButtonBack.BackgroundImage = Properties.Resources.ic_back_gray;

            ButtonNext.BackgroundImage = Properties.Resources.ic_next_gray;

            ButtonBack.Enabled = ButtonNext.Enabled = false;

            PanelControls.Controls.Clear();
            
            PanelControls.Controls.Add(FavoriteArtistsControl.UpdateArtists());

            return this;
            }

        internal Dashboard UpdateFavorteAlbums(){
            ButtonBack.BackgroundImage = Properties.Resources.ic_back_gray;

            ButtonNext.BackgroundImage = Properties.Resources.ic_next_gray;

            ButtonBack.Enabled = ButtonNext.Enabled = false;

            PanelControls.Controls.Clear();
            
            PanelControls.Controls.Add(FavoriteAlbumsControl.UpdateAlbums());

            return this;
            }
        
        internal Dashboard UpdateFavorteSongs(){
            ButtonBack.BackgroundImage = Properties.Resources.ic_back_gray;

            ButtonNext.BackgroundImage = Properties.Resources.ic_next_gray;

            ButtonBack.Enabled = ButtonNext.Enabled = false;

            PanelControls.Controls.Clear();
            
            PanelControls.Controls.Add(FavoriteAlbumsControl.UpdateAlbums());

            return this;
            }
        
        #endregion
        
        #region EVENTS
        private void RemoveFocus(Object Object, EventArgs EventArgs) => LabelMySpotify.Focus();

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
            TextBoxSearcher.Text = String.Empty;

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

        private void ButtonFavoriteAlbumsClick(Object Object, EventArgs EventArgs) => UpdateFavorteAlbums();
        
        private void ButtonFavoriteSongsClick(Object Object, EventArgs EventArgs) => UpdateFavorteSongs();
        #endregion
        }
    }
