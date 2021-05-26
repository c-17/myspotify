using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySpotify.Frameworks;

namespace MySpotify.Models{
    internal static class Storage{
        #region PROPERTIES
        private static readonly Dictionary<Int64, Artist> Artists = new Dictionary<Int64, Artist>();
        #endregion

        #region FUNCTIONS
        internal static Artist AddArtist(Artist Artist){
            Artists.AddIfNotExists(Artist.Id, Artist);

            foreach(Artist AA in Artists.Values)
                Console.WriteLine(AA.Name);

            return Artist;
            }

        internal static Artist GetArtist(String Name) => Artists.Values.ToList().FirstOrDefault(A => A.Name.ToLower().StartsWith(Name.ToLower()));

        internal static Boolean ContainsArtist(String Name) => Artists.Values.ToList().Exists(A => A.Name.ToLower().StartsWith(Name.ToLower()));

        internal static Artist RemoveArtist(Artist Artist){
            Artists.RemoveIfExists(Artist.Id);

            return Artist;
            }
        #endregion
        }
    }
