using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySpotify.Models;

namespace MySpotify.Views{
    internal partial class Login : Form{
        #region PROPERTIES
        internal User User;
        #endregion
        
        #region CONSTRUCTORS
        internal Login(){
            InitializeComponent();
            }
        #endregion

        #region FUNCTIONS
        #endregion

        #region EVENTS
        private void TextBoxUserKeyUp(Object Object, KeyEventArgs KeyEventArgs) => LabelUser.ForeColor = Color.Black;

        private void TextBoxPasswordKeyUp(Object Object, KeyEventArgs KeyEventArgs) => LabelPassword.ForeColor = Color.Black;

        private void TextBoxUserPasswordKeyDown(Object Object, KeyEventArgs KeyEventArgs){
            switch(KeyEventArgs.KeyCode){
                case Keys.Enter:
                    KeyEventArgs.SuppressKeyPress = true;
                    ButtonStartSession.PerformClick();
                break;
                }
            }

        private void ButtonStartSessionClick(Object Object, EventArgs EventArgs){
            if(TextBoxUser.Text.Length == 0){
                LabelUser.ForeColor = Color.Red;
                TextBoxUser.Focus();
                return;
                }

            if(TextBoxPassword.Text.Length == 0){
                LabelPassword.ForeColor = Color.Red;
                TextBoxPassword.Focus();
                return;
                }

            User = new User(TextBoxUser.Text, TextBoxPassword.Text);

            TextBoxUser.Text = "";
                            
            TextBoxPassword.Text = "";

            ButtonStartSession.Enabled = true;

            Hide();

            DialogResult = DialogResult.OK;
            }
        #endregion
        }
    }
