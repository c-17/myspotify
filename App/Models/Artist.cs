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
    internal class Artist{
        #region PROPERTIES
        internal readonly Int64 Id;
        internal readonly String Name;
        internal readonly String Style;
        internal readonly String Genre;
        internal readonly String Country;
        internal readonly String Biography;
        internal readonly String URLThumbnail;
        internal Image Thumbnail;

        internal List<Album> Albums = new List<Album>();
        #endregion
        
        #region CONSTRUCTORS
        internal Artist(Int64 Id, String Name, String Style, String Genre, String Country, String Biography, String URLThumbnail){
            this.Id = Id;

            this.Name = Name;

            this.Style = Style;

            this.Genre = Genre;
            
            this.Country = Country;
            
            this.Biography = Biography;

            this.URLThumbnail = URLThumbnail;

            Storage.AddArtist(this);
            }

        internal Artist(DataRow DataRow){
            this.Id = Convert.ToInt64(DataRow["idArtist"]);

            this.Name = Convert.ToString(DataRow["strArtist"]);

            this.Style = Convert.ToString(DataRow["strStyle"]);

            this.Genre = Convert.ToString(DataRow["strGenre"]);

            this.Country = Convert.ToString(DataRow["strCountry"]);

            this.Biography = Convert.ToString(DataRow["strBiographyEN"]);

            this.URLThumbnail = Convert.ToString(DataRow["strArtistThumb"]);

            Storage.AddArtist(this);
            }
        #endregion
        }
    }
