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
    internal class Artist{
        #region PROPERTIES
        internal readonly Int64 Id;
        internal readonly String Name;
        internal readonly String Style;
        internal readonly String Genre;
        internal readonly String Country;
        internal readonly String Biography;
        private readonly String _Thumbnail;

        internal Image Thumbnail{
            get{
                try{
                    System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

                    WebClient WebClient = new WebClient();
                    Stream Stream = WebClient.OpenRead(_Thumbnail);
                    Bitmap Bitmap = new Bitmap(Stream);

                    Stream.Flush();
                    Stream.Close();

                    WebClient.Dispose();

                    return Bitmap;
                    }
                catch{
                    //Console.WriteLine(Exception.StackTrace+" -> "+Exception.Message);
                    }

                return Properties.Resources.Thumbnail;
                }
            }

        internal List<Album> Albums = new List<Album>();
        #endregion
        
        #region CONSTRUCTORS
        internal Artist(Int64 Id, String Name, String Style, String Genre, String Country, String Biography, String Thumbnail){
            this.Id = Id;

            this.Name = Name;

            this.Style = Style;

            this.Genre = Genre;
            
            this.Country = Country;
            
            this.Biography = Biography;

            this._Thumbnail = Thumbnail;
            }

        internal Artist(JsonObjectCollection JsonObjectCollection){
            this.Id = Convert.ToInt64(JsonObjectCollection["idArtist"].GetValue());

            this.Name = Convert.ToString(JsonObjectCollection["strArtist"].GetValue());

            this.Style = Convert.ToString(JsonObjectCollection["strStyle"].GetValue());

            this.Genre = Convert.ToString(JsonObjectCollection["strGenre"].GetValue());

            this.Country = Convert.ToString(JsonObjectCollection["strCountry"].GetValue());

            this.Biography = Convert.ToString(JsonObjectCollection["strBiographyEN"].GetValue());

            this._Thumbnail = Convert.ToString(JsonObjectCollection["strArtistThumb"].GetValue());

            Storage.AddArtist(this);
            }
        #endregion
        
        #region FUNCTIONS
        #endregion
        
        #region EVENTS
        #endregion
        }
    }
