using System;
using System.Collections.Generic;
using System.Reflection;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Json;
using System.ComponentModel;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace MySpotify.Models{
    internal class Track{
        #region PROPERTIES
        internal readonly Album Album;
        
        internal readonly Int64 Id;

        internal readonly String Name;
        
        private readonly Int64 _Duration;
        
        internal String Duration{
            get{
                TimeSpan TimeSpan = TimeSpan.FromMilliseconds(_Duration);
                
                return String.Format("{1:D2}m:{2:D2}s", TimeSpan.Hours, TimeSpan.Minutes, TimeSpan.Seconds, TimeSpan.Milliseconds);
                }
            }
        #endregion
        
        #region CONSTRUCTORS
        internal Track(Album Album, Int64 Id, String Name, Int64 Duration){
            this.Album = Album;

            this.Id = Id;

            this.Name = Name;

            this._Duration = Duration;
            }

        internal Track(Album Album, JsonObjectCollection JsonObjectCollection){
            this.Album = Album;

            this.Id = Convert.ToInt64(JsonObjectCollection["idTrack"].GetValue());

            this.Name = Convert.ToString(JsonObjectCollection["strTrack"].GetValue());
            
            this._Duration = Convert.ToInt64(JsonObjectCollection["intDuration"].GetValue());
            }
        #endregion
        }
    }
