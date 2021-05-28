using System;
using System.Collections.Generic;
using System.Reflection;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.ComponentModel;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

using Newtonsoft.Json;

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
                
                return String.Format("{0:D2}:{1:D2}", TimeSpan.Minutes, TimeSpan.Seconds);
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
        
        internal Track(Album Album, DataRow DataRow){
            this.Album = Album;

            this.Id = Convert.ToInt64(DataRow["idTrack"]);

            this.Name = Convert.ToString(DataRow["strTrack"]);
            
            this._Duration = Convert.ToInt64(DataRow["intDuration"]);
            }
        #endregion
        }
    }
