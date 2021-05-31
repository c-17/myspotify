using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySpotify.Models{
    internal class User{
        #region PROPERTIES
        internal String Id;

        internal readonly String Name;

        internal readonly String Password;

        internal readonly List<Artist> Artists = new List<Artist>();

        internal readonly List<Album> Albums = new List<Album>();

        internal readonly List<Track> Tracks = new List<Track>();

        internal static User Instance;
        #endregion
        
        #region CONSTRUCTORS
        internal User(String Name, String Password){
            this.Id = DateTime.Now.ToString("yyyyMMddHHmmss");

            this.Name = Name;

            this.Password = Password;

            Instance = this;
            }
        #endregion
        }
    }
