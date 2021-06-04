using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySpotify.Models;

using MySpotify.Views;

namespace MySpotify{
    static class Program{
        
        #region PROPERTIES
        internal static Artist Artist;

        internal static User User;
        
        internal static SplashScreen SplashScreen;

        internal static Login Login;

        internal static Dashboard Dashboard;
        #endregion
        
        #region FUNCTIONS
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main(){
            Application.EnableVisualStyles();

            Application.SetCompatibleTextRenderingDefault(true);

            SplashScreen = new SplashScreen();

            Login = new Login();

            Dashboard = new Dashboard();

            SplashScreen.ShowDialog();

            Artist = SplashScreen.Artist;

            while(Login.ShowDialog() == DialogResult.OK && (User = Login.User) != null && Dashboard.Init().UpdateArtist(Artist).ShowDialog() != DialogResult.Cancel);

            //Application.Run(new Login());
            }
        #endregion
        }
    }
