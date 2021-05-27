using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Threading;
using System.Reflection;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;

using System.Drawing.Imaging;

using MySpotify.Models;

namespace MySpotify.Views{
    public partial class SplashScreen:Form{

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(Int32 nLeftRect, Int32 nTopRect, Int32 nRightRect, Int32 nBottomRect, Int32 nWidthEllipse, Int32 nHeightEllipse);

        #region PROPERTIES
        private readonly Thread ThreadLoading;

        private readonly Animation MyAnimation;

        private readonly String LoadingMessage = ".";
        
        private Boolean Finish = false;

        internal Artist Artist;
        #endregion

        #region CONSTRUCTORS
        public SplashScreen(){
            CheckForIllegalCrossThreadCalls = false;

            InitializeComponent();

            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            
            (MyAnimation = new Animation(Properties.Resources.MySpotify, PictureBoxSplashScreen)).Start();
            
            (ThreadLoading = new Thread(new ThreadStart(Loading))).Start();

            new Thread(new ThreadStart(SearchRandomArtist)).Start();
            
            new Thread(new ThreadStart(FadeEffect)).Start();
            }
        #endregion

        #region FUNCTIONS
        private void SearchRandomArtist(){
            Thread.Sleep(3000);
            
            while(!Finish){
                if(Internet.IsConnected){
                    if((Artist = Internet.GetRandomArtist()) != null)
                        Finish = true;
                    /*if(Internet.SearchRandomArtist(out JsonObjectCollection JsonObjectCollection)){
                        JsonArrayCollection JsonArrayCollection = JsonObjectCollection["artists"] as JsonArrayCollection;

                        JsonObjectCollection = JsonArrayCollection[0] as JsonObjectCollection;
                        
                        Artist = new Artist(JsonObjectCollection);
                        
                        Finish = true;
                        }*/
                    }
                else
                    Thread.Sleep(2000);
                }

            /*try{
                if(Internet.IsConnected){
                    if(Internet.SearchRandomArtist(out JsonObjectCollection JsonObjectCollection)){
                        if(Convert.ToBoolean(JsonObjectCollection["update"].GetValue())){
                            }
                        }
                    }
                }
            catch(Exception Exception){
                Console.WriteLine(Exception.StackTrace);
                }*/
            MyAnimation.Stop();

            Close();
            }

        private void FadeEffect(){
            do{
                Thread.Sleep(150);
                Opacity += 0.1D;
                }while(Opacity != 1.0);
            }
        #endregion

        #region EVENTS
        private void Loading(){
            /*Int32 LoadingTime = 0;
            
            String LoadingText = LoadingMessage;

            while(!Finish){
                LoadingText += ".";

                LoadingTime++;

                if(LoadingTime > 2){
                    LoadingText = LoadingMessage;
                    LoadingTime = 0;
                    }

                LabelLoading.Text = LoadingText;

                Thread.Sleep(250);
                }*/
            }
        
        private void MySplashScreenFormClosing(Object Object, FormClosingEventArgs FormClosingEventArgs){
            ThreadLoading.Abort();
            }
        #endregion
        }
    }
