using System;
using System.Collections.Generic;
using System.Reflection;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Json;

namespace MySpotify.Models{
    internal class Track{
        #region PROPERTIES
        internal readonly Album Album;
        
        internal readonly Int64 Id;

        internal readonly String Name;

        internal readonly Int64 Duration;
        #endregion
        
        #region CONSTRUCTORS
        internal Track(Album Album, Int64 Id, String Name){
            this.Album = Album;

            this.Id = Id;

            this.Name = Name;
            }

        internal Track(Album Album, JsonObjectCollection JsonObjectCollection){
            this.Album = Album;

            this.Id = Convert.ToInt64(JsonObjectCollection["idTrack"].GetValue());

            this.Name = Convert.ToString(JsonObjectCollection["strTrack"].GetValue());
            
            this.Duration = Convert.ToInt64(JsonObjectCollection["intDuration"].GetValue());
            }
        #endregion
        }
    }
