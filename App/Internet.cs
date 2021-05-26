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


using System.Net.Json;

namespace MySpotify.Models{
    public class Internet: WebClient{
        #region CONSTANTS
        protected const String WebService = "https://theaudiodb.com/api/v1/json/1/";
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
        
        private async static Task<Byte[]> SearchRandomArtist(Int64 ArtistId){
            Byte[] Response = null;

            try{
                Task<Byte[]> Request = new Internet().DownloadDataTaskAsync(WebService+"artist.php?i="+ArtistId);

                Response = await Request;

                return Response;
                }
            catch(Exception Exception){
                Console.WriteLine(Exception.StackTrace);
                }

            return Response;
            }
        internal static Artist SearchRandomArtist(){
            try{
                Int32 ArtistId = new Random().Next(111233, 112500)+1;

                String Response = Encoding.Default.GetString(SearchRandomArtist(ArtistId).Result);

                Console.WriteLine("SearchRandomArtist: "+Response);

                JsonObjectCollection JsonObjectCollection = new JsonTextParser().Parse(Response) as JsonObjectCollection;

                JsonArrayCollection JsonArrayCollection = JsonObjectCollection["artists"] as JsonArrayCollection;
                
                if(JsonArrayCollection != null){
                    Artist Artist = new Artist(JsonArrayCollection[0] as JsonObjectCollection);

                    Artist.Albums = GetAlbums(Artist);

                    return Artist;
                    }
                }
            catch(Exception Exception){
                Console.WriteLine(Exception.StackTrace);
                }

            return null;
            }

        internal static List<Album> GetAlbums(Artist Artist){
            try{
                Task<Byte[]> Request = new Internet().DownloadDataTaskAsync(WebService+"album.php?i="+Artist.Id);

                String Response = Encoding.Default.GetString(Request.Result);

                Console.WriteLine("Albums: "+Response);

                JsonObjectCollection JsonObjectCollection = new JsonTextParser().Parse(Response) as JsonObjectCollection;

                JsonArrayCollection JsonArrayCollection = JsonObjectCollection["album"] as JsonArrayCollection;
                
                if(JsonArrayCollection != null){
                    List<Album> Albums = new List<Album>();

                    foreach(JsonObjectCollection JsonAlbum in JsonArrayCollection){
                        Album Album = new Album(Artist, JsonAlbum);

                        Album.Tracks = GetTracks(Album);

                        Albums.Add(Album);
                        }

                    return Albums;
                    }
                }
            catch(Exception Exception){
                Console.WriteLine(Exception.StackTrace);
                }

            return null;
            }

        internal static List<Track> GetTracks(Album Album){
            try{
                Task<Byte[]> Request = new Internet().DownloadDataTaskAsync(WebService+"track.php?m="+Album.Id);

                String Response = Encoding.Default.GetString(Request.Result);

                Console.WriteLine("Tracks: "+Response);

                JsonObjectCollection JsonObjectCollection = new JsonTextParser().Parse(Response) as JsonObjectCollection;

                JsonArrayCollection JsonArrayCollection = JsonObjectCollection["track"] as JsonArrayCollection;
                
                if(JsonArrayCollection != null){
                    List<Track> Tracks = new List<Track>();

                    foreach(JsonObjectCollection JsonTrack in JsonArrayCollection)
                        Tracks.Add(new Track(Album, JsonTrack));

                    return Tracks;
                    }
                }
            catch(Exception Exception){
                Console.WriteLine(Exception.StackTrace);
                }

            return null;
            }
        
        internal async static Task<Artist> SearchArtistAsync(String Searching){
            try{
                Task<Byte[]> Request = new Internet().DownloadDataTaskAsync(WebService+"search.php?s="+Searching);

                Byte[] Response = await Request;

                String Result = Encoding.Default.GetString(Response);

                Console.WriteLine("SearchArtist: "+Result);

                JsonObjectCollection JsonObjectCollection = new JsonTextParser().Parse(Result) as JsonObjectCollection;

                JsonArrayCollection JsonArrayCollection = JsonObjectCollection["artists"] as JsonArrayCollection;
                
                if(JsonArrayCollection != null){
                    Artist Artist = new Artist(JsonArrayCollection[0] as JsonObjectCollection);

                    Artist.Albums = await GetAlbumsAsync(Artist);

                    return Artist;
                    }

                return null;
                }
            catch(Exception Exception){
                Console.WriteLine(Exception.StackTrace);
                }

            return null;
            }

        internal async static Task<List<Album>> GetAlbumsAsync(Artist Artist){
            try{
                Task<Byte[]> Request = new Internet().DownloadDataTaskAsync(WebService+"album.php?i="+Artist.Id);

                Byte[] Response = await Request;

                String Result = Encoding.Default.GetString(Response);

                Console.WriteLine("GetAlbums: "+Result);

                JsonObjectCollection JsonObjectCollection = new JsonTextParser().Parse(Result) as JsonObjectCollection;

                JsonArrayCollection JsonArrayCollection = JsonObjectCollection["album"] as JsonArrayCollection;
                
                if(JsonArrayCollection != null){
                    List<Album> Albums = new List<Album>();

                    foreach(JsonObjectCollection JsonAlbum in JsonArrayCollection)
                        Albums.Add(new Album(Artist, JsonAlbum));

                    return Albums;
                    }
                }
            catch{}

            return null;
            }
        #endregion
        }
    }
