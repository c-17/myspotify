using System;
using System.Collections.Generic;
using System.Reflection;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Data;
using System.Net;

using Newtonsoft.Json;

namespace MySpotify.Models{
    internal class Album{
        #region PROPERTIES
        internal readonly Artist Artist;

        internal Int64 Id;
        internal readonly String Name;
        internal readonly String Genre;
        internal readonly String Released;
        internal readonly String Description;
        internal readonly String URLThumbnail;
        internal Image Thumbnail;

        internal List<Track> Tracks = new List<Track>();
        #endregion
        
        #region CONSTRUCTORS
        internal Album(Artist Artist, Int64 Id, String Name, String Genre, String Released, String Description, String URLThumbnail){
            this.Artist = Artist;

            this.Name = Name;

            this.Genre = Genre;

            this.Released = Released;

            this.Description = Description;

            this.URLThumbnail = URLThumbnail;
            }
        
        internal Album(Artist Artist, DataRow DataRow){
            this.Artist = Artist;

            this.Id = Convert.ToInt64(DataRow["idAlbum"]);

            this.Name = Convert.ToString(DataRow["strAlbum"]);
            
            this.Genre = Convert.ToString(DataRow["strGenre"]);
            
            this.Released = Convert.ToString(DataRow["intYearReleased"]);

            this.Description = Convert.ToString(DataRow["strDescriptionEN"]);

            this.URLThumbnail = Convert.ToString(DataRow["strAlbumThumb"]);
            }
        #endregion
        }
    }
