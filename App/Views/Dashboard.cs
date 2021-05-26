using Microsoft.Win32;
using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Management;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.IO;

using System.Net.Json;

using MySpotify.Models;

namespace MySpotify.Views{
    internal partial class Dashboard : Form{
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(Int32 nLeftRect, Int32 nTopRect, Int32 nRightRect, Int32 nBottomRect, Int32 nWidthEllipse, Int32 nHeightEllipse);

        #region PROPERTIES
        private readonly WaitingControl WaitingControl = new WaitingControl();
        
        private readonly ArtistControl ArtistControl = new ArtistControl();
        
        private readonly AlbumControl AlbumControl = new AlbumControl();

        private readonly SearchControl SearchControl = new SearchControl();

        internal static Dashboard Instance;
        #endregion
        
        #region CONSTRUCTORS
        internal Dashboard(){
            InitializeComponent();

            Instance = this;
            
            TextBoxSearcher.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, TextBoxSearcher.Width, TextBoxSearcher.Height, 5, 5));
            }
        #endregion
        
        #region FUNCTIONS
        internal Dashboard UpdateArtist(Artist Artist, Album Album = null){
            LabelUser.Text = Program.User.Name;

            PanelControls.Controls.Clear();

            ArtistControl.DpiChangedAfterParent += new EventHandler(delegate{
                Console.WriteLine("Validate");
                });
            
            PanelControls.Controls.Add(ArtistControl.UpdateArtist(Artist, Album));

            return this;
            }

        internal Dashboard UpdateAlbum(Album Album){
            PanelControls.Controls.Clear();
            
            PanelControls.Controls.Add(AlbumControl.UpdateAlbum(Album));

            return this;
            }
        #endregion
        
        #region EVENTS
        private async void TextBoxSearcherKeyUp(Object Object, KeyEventArgs KeyEventArgs){
            if(TextBoxSearcher.Text.Length >= 2){
                String Searching = Uri.EscapeDataString(TextBoxSearcher.Text.ToLower());

                if(Storage.ContainsArtist(Searching)){
                    PanelControls.Controls.Clear();
            
                    PanelControls.Controls.Add(SearchControl.UpdateArtists(new List<Artist>{Storage.GetArtist(Searching)}));

                    return;
                    }
                
                Artist Artist = await Internet.SearchArtistAsync(Searching);

                if(Artist != null){
                    PanelControls.Controls.Clear();
            
                    PanelControls.Controls.Add(SearchControl.UpdateArtists(new List<Artist>{Artist}));
                    }

                //Console.WriteLine(Response.Length.ToString());
                }
            }

        private void ButtonExploreClick(Object Object, EventArgs EventArgs){
            PanelControls.Controls.Clear();
            
            PanelControls.Controls.Add(WaitingControl);

            new Thread(new ThreadStart(delegate{
                while(true){
                    if(Internet.IsConnected){
                        Artist Artist;
                        if((Artist = Internet.SearchRandomArtist()) != null){
                            UpdateArtist(Artist);
                        
                            break;
                            }
                        }
                    else
                        Thread.Sleep(2000);
                    }
                })).Start();
            }
        #endregion
        }
    }
