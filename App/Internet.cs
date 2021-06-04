using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Collections.Specialized;
using System.Reflection;
using System.Diagnostics;

using Newtonsoft.Json;

using System.Data;

using System.Drawing;

namespace MySpotify.Models{
    public class Internet: WebClient{
        #region CONSTANTS
        internal const String WebService = "https://theaudiodb.com/api/v1/json/1/";
        #endregion

        #region PROPERTIES
        internal static Boolean IsConnected{
            get{
                try{
                    using(Internet Internet = new Internet()){
                        using(Internet.OpenRead("http://www.google.com"))
                            return true;
                        }
                    }
                catch{
                    return false;
                    }
                }
            }
        #endregion

        #region FUNCTIONS
        protected override WebRequest GetWebRequest(Uri Address){
            WebRequest WebRequest = base.GetWebRequest(Address);
            WebRequest.Timeout = 60000;
            return WebRequest;
            }
        #endregion

        #region CONNECTIVITY
        private async static Task<String> Get(String URL){
            try{
                using(Internet Internet = new Internet()){
                    Byte[] Response = await Internet.DownloadDataTaskAsync(URL);

                    return Encoding.Default.GetString(Response);
                    }
                }
            catch(Exception Exception){
                Console.WriteLine(Exception.StackTrace);
                }

            return null;
            }
        
        private async static Task<Image> GetThumbnail(String URL, Image Default){
            if(URL.Length == 0 || URL == null)
                return Default;

            try{
                using(Internet Internet = new Internet()){
                    System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

                    Stream Stream = await Internet.OpenReadTaskAsync(URL);
                    
                    Bitmap Bitmap = new Bitmap(Stream);

                    Stream.Flush();
                    Stream.Close();
                    
                    return Bitmap;
                    }
                }
            catch(Exception Exception){
                Console.WriteLine(Exception.Message+": "+Exception.StackTrace);
                }

            return Default;
            }

        internal static Artist GetRandomArtist(){
            try{
                String Response = Get(WebService+"artist.php?i="+(new Random().Next(111233, 112500)+1)).Result;
                //String Response = Get(WebService+"artist.php?i=112435").Result;
                
                Console.WriteLine("GetRandomArtist: "+Response);

                DataSet DataSet = JsonConvert.DeserializeObject<DataSet>(Response);

                DataTable DataTable = DataSet.Tables["artists"];

                if(DataTable.Rows.Count > 0){
                    Artist Artist = new Artist(DataTable.Rows[0]);

                    Artist.Thumbnail = GetThumbnail(Artist.URLThumbnail, Properties.Resources.Thumbnail).Result;

                    Artist.Albums = GetAlbums(Artist).Result;

                    return Artist;
                    }
                }
            catch(Exception Exception){
                Console.WriteLine(Exception.Message+": "+Exception.StackTrace);
                }

            return null;
            }
        
        internal async static Task<List<Album>> GetAlbums(Artist Artist){
            try{
                String Response = await Get(WebService+"album.php?i="+Artist.Id);

                Console.WriteLine("GetAlbums: "+Response);
                
                DataSet DataSet = JsonConvert.DeserializeObject<DataSet>(Response);

                DataTable DataTable = DataSet.Tables["album"];
                
                if(DataTable.Rows.Count > 0){
                    List<Album> Albums = new List<Album>();

                    foreach(DataRow DataRow in DataTable.Rows){
                        Album Album = new Album(Artist, DataRow);

                        Album.Thumbnail = await GetThumbnail(Album.URLThumbnail, Properties.Resources.Thumbnail);

                        Album.Tracks = await GetTracks(Album);

                        Albums.Add(Album);
                        }

                    return Albums;
                    }
                }
            catch(Exception Exception){
                Console.WriteLine(Exception.Message+": "+Exception.StackTrace);
                }

            return null;
            }

        internal async static Task<List<Track>> GetTracks(Album Album){
            try{
                String Response = await Get(WebService+"track.php?m="+Album.Id);

                Console.WriteLine("GetTracks: "+Response);
                
                DataSet DataSet = JsonConvert.DeserializeObject<DataSet>(Response);

                DataTable DataTable = DataSet.Tables["track"];
                
                if(DataTable.Rows.Count > 0){
                    List<Track> Tracks = new List<Track>();

                    foreach(DataRow DataRow in DataTable.Rows)
                        Tracks.Add(new Track(Album, DataRow));

                    return Tracks;
                    }
                }
            catch(Exception Exception){
                Console.WriteLine(Exception.Message+": "+Exception.StackTrace);
                }

            return null;
            }

        internal async static Task<Artist> SearchArtist(String Searching){
            try{
                String Response = await Get(WebService+"search.php?s="+Searching);

                Console.WriteLine("SearchArtist: "+Response);
                
                DataSet DataSet = JsonConvert.DeserializeObject<DataSet>(Response);

                DataTable DataTable = DataSet.Tables["artists"];
                
                if(DataTable.Rows.Count > 0){
                    Artist Artist = new Artist(DataTable.Rows[0]);

                    Artist.Thumbnail = await GetThumbnail(Artist.URLThumbnail, Properties.Resources.Thumbnail);

                    return Artist;
                    }
                }
            catch{}

            return null;
            }
        
        internal async static Task<List<Album>> SearchAlbums(Artist Artist){
            try{
                String Response = await Get(WebService+"album.php?i="+Artist.Id);

                Console.WriteLine("SearchAlbums: "+Response);
                
                DataSet DataSet = JsonConvert.DeserializeObject<DataSet>(Response);

                DataTable DataTable = DataSet.Tables["album"];
                
                if(DataTable.Rows.Count > 0){
                    List<Album> Albums = new List<Album>();

                    foreach(DataRow DataRow in DataTable.Rows){
                        Album Album = new Album(Artist, DataRow);

                        Album.Thumbnail = await GetThumbnail(Album.URLThumbnail, Properties.Resources.Thumbnail);

                        Albums.Add(Album);
                        }

                    return Albums;
                    }
                }
            catch(Exception Exception){
                Console.WriteLine(Exception.Message+": "+Exception.StackTrace);
                }

            return null;
            }
        
        internal async static Task<List<Track>> SearchTracks(Album Album){
            try{
                String Response = await Get(WebService+"track.php?m="+Album.Id);

                Console.WriteLine("SearchTracks: "+Response);
                
                DataSet DataSet = JsonConvert.DeserializeObject<DataSet>(Response);

                DataTable DataTable = DataSet.Tables["track"];
                
                if(DataTable.Rows.Count > 0){
                    List<Track> Tracks = new List<Track>();

                    foreach(DataRow DataRow in DataTable.Rows)
                        Tracks.Add(new Track(Album, DataRow));

                    return Tracks;
                    }
                }
            catch(Exception Exception){
                Console.WriteLine(Exception.Message+": "+Exception.StackTrace);
                }

            return null;
            }
        #endregion
        }
    }
