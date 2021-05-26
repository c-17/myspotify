﻿using System;
using System.Collections.Generic;
using System.Reflection;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Json;

namespace MySpotify.Models{
    internal class Album{
        #region PROPERTIES
        internal readonly Artist Artist;

        internal Int64 Id;
        internal readonly String Name;
        internal readonly String Genre;
        internal readonly String Released;
        private readonly String _Thumbnail;
        private Image Image = null;
        internal Image Thumbnail{
            get{
                if(Image != null)
                    return Image;

                try{
                    System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

                    WebClient WebClient = new WebClient();
                    Stream Stream = WebClient.OpenRead(_Thumbnail);
                    Bitmap Bitmap = new Bitmap(Stream);

                    Stream.Flush();
                    Stream.Close();

                    WebClient.Dispose();

                    return (Image = Bitmap);
                    }
                catch{}

                return (Image = Properties.Resources.ic_album);
                }
            }

        internal List<Track> Tracks = new List<Track>();
        #endregion
        
        #region CONSTRUCTORS
        internal Album(Artist Artist, Int64 Id, String Name, String Genre, String Thumbnail, String Released){
            this.Artist = Artist;

            this.Name = Name;

            this.Genre = Genre;

            this._Thumbnail = Thumbnail;

            this.Released = Released;
            }
        
        internal Album(Artist Artist, JsonObjectCollection JsonObjectCollection){
            this.Artist = Artist;

            this.Id = Convert.ToInt64(JsonObjectCollection["idAlbum"].GetValue());

            this.Name = Convert.ToString(JsonObjectCollection["strAlbum"].GetValue());
            
            this.Genre = Convert.ToString(JsonObjectCollection["strGenre"].GetValue());
            
            this.Released = Convert.ToString(JsonObjectCollection["intYearReleased"].GetValue());

            this._Thumbnail = Convert.ToString(JsonObjectCollection["strAlbumThumb"].GetValue());
            }
        #endregion
        }
    }
