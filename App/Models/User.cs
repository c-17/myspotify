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
        #endregion
        
        #region CONSTRUCTORS
        internal User(String Name, String Password){
            this.Id = DateTime.Now.ToString("yyyyMMddHHmmss");

            this.Name = Name;

            this.Password = Password;
            }
        #endregion
        }
    }
