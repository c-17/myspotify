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

using System.Net.Json;

namespace MySpotify.Models{
    internal class Animation{
        #region PROPERTIES
        private Image Image;
        private readonly PictureBox PictureBox;
        private readonly FrameDimension FrameDimension;
        private readonly Int32 FrameCount;
        private Int32 CurrentFrame = -1;
        private System.Windows.Forms.Timer Timer;
        #endregion

        #region CONSTRUCTORS
        internal Animation(Image Image, PictureBox PictureBox){
            this.Image = Image;

            this.PictureBox = PictureBox;

            FrameDimension = new FrameDimension(Image.FrameDimensionsList[0]);

            FrameCount = Image.GetFrameCount(FrameDimension);

            Timer = new System.Windows.Forms.Timer{
                Interval = (1000/FrameCount)
                };

            Timer.Tick += new EventHandler(delegate{
                PictureBox.BackgroundImage = GetNextFrame();
                });
            }
        #endregion

        #region FUNCTIONS
        internal void Start() => Timer.Enabled = true;

        internal void Stop() => Timer.Stop();

        public Image GetNextFrame(){
            CurrentFrame += 1;

            if(CurrentFrame >= FrameCount || CurrentFrame < 0)
                CurrentFrame = 0;

            return GetFrame(CurrentFrame);
            }

        public Image GetFrame(Int32 Index){
            Image.SelectActiveFrame(FrameDimension, Index);
            return (Image)Image.Clone();
            }
        #endregion
        }
    }
