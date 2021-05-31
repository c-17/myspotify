using System;
using System.Linq;
using System.ComponentModel;
using System.Data;
using System.Threading;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;

namespace MySpotify.Components{
    internal enum MyMessageBoxButtons{
        OK = 0,
        YesNo = 2,
        Options = 4
        }

    internal enum MyMessageBoxIcon{
        None = 0,
        Success = 1,
        Warning = 2,
        Error = 3,
        Information = 4,
        Question = 5
        }

    internal partial class MyMessageBox : Form{
        #region CONSTANTS
        internal static String NewLine => Environment.NewLine;

        internal static String NewLineX2 => Environment.NewLine+Environment.NewLine;

        internal static String NewLineX3 => Environment.NewLine+Environment.NewLine+Environment.NewLine;
        #endregion
        
        #region PROPERTIES
        private readonly Button DefaultButton;

        private Int32 OptionResult = -1;
        #endregion
        
        #region CONSTRUCTORS
        private MyMessageBox(String Title, String Message, MyMessageBoxIcon Icon, MyMessageBoxButtons Buttons, String[] Options = null, String Option = null){
            InitializeComponent();

            Text = Title;

            LabelMessage.Text = Message;

            Int32 TextHeight = TextRenderer.MeasureText(Message, LabelMessage.Font).Height;

            Int32 TextWidth = ((String.IsNullOrEmpty(Message))?0:Message.Split(new Char[]{'\n'}, StringSplitOptions.None).Max(Text => TextRenderer.MeasureText(Text, LabelMessage.Font).Width));

            Int32 MarginWidth = this.Width - LabelMessage.Width+10;
            Int32 MarginHeight = this.Height - LabelMessage.Height;
            
            Int32 Width = TextWidth + MarginWidth;
            Int32 Height = TextHeight + MarginHeight;

            switch(Icon){
                case MyMessageBoxIcon.Success:
                    PictureBox.BackgroundImage = Properties.Resources.ic_success;
                    break;
                case MyMessageBoxIcon.Warning:
                    PictureBox.BackgroundImage = Properties.Resources.ic_warning;
                    break;
                case MyMessageBoxIcon.Error:
                    PictureBox.BackgroundImage = Properties.Resources.ic_cancel;
                    break;
                case MyMessageBoxIcon.Information:
                    PictureBox.BackgroundImage = Properties.Resources.ic_information;
                    break;
                case MyMessageBoxIcon.Question:
                    PictureBox.BackgroundImage = Properties.Resources.ic_question;
                    break;
                default:
                    PictureBox.Visible = false;
                    TableLayoutPanelTop.Controls.Remove(PictureBox);
                    TableLayoutPanelTop.Controls.Remove(LabelMessage);
                    TableLayoutPanelTop.Controls.Add(LabelMessage, 0, 0);
                    break;
                }

            switch(Buttons){
                case MyMessageBoxButtons.OK:{
                    TableLayoutPanelBottom.ColumnCount = 3;

                    TableLayoutPanelBottom.ColumnStyles.Clear();
                    
                    TableLayoutPanelBottom.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.0F));
                    TableLayoutPanelBottom.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100.0F));
                    TableLayoutPanelBottom.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.0F));
                        
                    //TableLayoutPanelBottom.Controls.Add(DefaultButton = new Button{Text = "OK", FlatStyle = FlatStyle.Flat, UseVisualStyleBackColor = true, Dock = DockStyle.Fill, DialogResult = DialogResult.OK}, 1, 0);
                    TableLayoutPanelBottom.Controls.Add(DefaultButton = CreateButton("OK"), 1, 0);

                    Width = ((TableLayoutPanelBottom.Width > Width)?TableLayoutPanelBottom.Width:Width);
                    }break;
                case MyMessageBoxButtons.YesNo:{
                    TableLayoutPanelBottom.ColumnCount = 4;

                    TableLayoutPanelBottom.ColumnStyles.Clear();
                    
                    TableLayoutPanelBottom.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.0F));
                    TableLayoutPanelBottom.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100.0F));
                    TableLayoutPanelBottom.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100.0F));
                    TableLayoutPanelBottom.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.0F));

                    TableLayoutPanelBottom.Controls.Add(new Button{Text = "Si", FlatStyle = FlatStyle.Flat, UseVisualStyleBackColor = true, Dock = DockStyle.Fill, TabIndex = 0, DialogResult = DialogResult.Yes}, 1, 0);
                    TableLayoutPanelBottom.Controls.Add(DefaultButton = new Button{Text = "No", FlatStyle = FlatStyle.Flat, UseVisualStyleBackColor = true, Dock = DockStyle.Fill, TabIndex = 1, DialogResult = DialogResult.No}, 2, 0);

                    Width = ((TableLayoutPanelBottom.Width > Width)?TableLayoutPanelBottom.Width:Width);
                    }break;
                case MyMessageBoxButtons.Options:{
                    if(Options == null)
                        goto case MyMessageBoxButtons.OK;

                    TableLayoutPanelBottom.ColumnCount = Options.Length+2;
                        
                    TableLayoutPanelBottom.ColumnStyles.Clear();

                    TableLayoutPanelBottom.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.0F));

                    for(Int32 i=0;i<Options.Length;i++)
                        TableLayoutPanelBottom.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, TextRenderer.MeasureText(Options[i], Font).Width + 15));

                    TableLayoutPanelBottom.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.0F));

                    for(Int32 i=0;i<Options.Length;i++){
                        if(Option != null && Option.Equals(Options[i], StringComparison.Ordinal))
                            TableLayoutPanelBottom.Controls.Add(DefaultButton = new Button{Text = Options[i], FlatStyle = FlatStyle.Flat, UseVisualStyleBackColor = true, Dock = DockStyle.Fill, TabIndex = i, Tag = i}, (i+1), 0);
                        else
                            TableLayoutPanelBottom.Controls.Add(new Button{Text = Options[i], FlatStyle = FlatStyle.Flat, UseVisualStyleBackColor = true, Dock = DockStyle.Fill, TabIndex = i, Tag = i}, (i+1), 0);
                        }

                    foreach(Control Control in TableLayoutPanelBottom.Controls)
                        Control.Click += MyMessageBoxClick;
                    
                    Width = ((TableLayoutPanelBottom.Width > Width)?TableLayoutPanelBottom.Width:Width);
                    }break;
                }

            TableLayoutPanelBottom.Dock = DockStyle.Fill;

            Size = new Size(Width, Height);
            }
        #endregion
        
        #region FUNCTIONS
        private static Button CreateButton(String Text, DialogResult DialogResult = DialogResult.OK, Int32 TabIndex = 0, Object Tag = null){
            return new Button{
                Text = Text,
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.FromArgb(33,33,33),
                ForeColor = Color.FromArgb(24, 202, 88),
                UseVisualStyleBackColor = true,
                FlatAppearance = {BorderColor = Color.FromArgb(24, 202, 88), BorderSize = 1},
                Dock = DockStyle.Fill,
                DialogResult = DialogResult,
                TabIndex = TabIndex,
                Tag = Tag
                };
            }
        
        internal static DialogResult Show(String Message) => MyShow(null, String.Empty, Message, MyMessageBoxIcon.None, MyMessageBoxButtons.OK);

        internal static DialogResult Show(IWin32Window Owner, String Message) => MyShow(Owner, String.Empty, Message, MyMessageBoxIcon.None, MyMessageBoxButtons.OK);
        
        internal static DialogResult Show(String Message, MyMessageBoxIcon Icon) => MyShow(null, String.Empty, Message, Icon, MyMessageBoxButtons.OK);
        
        internal static DialogResult Show(IWin32Window Owner, String Message, MyMessageBoxIcon Icon) => MyShow(Owner, String.Empty, Message, Icon, MyMessageBoxButtons.OK);
        
        internal static DialogResult Show(String Message, MyMessageBoxButtons Buttons) => MyShow(null, String.Empty, Message, MyMessageBoxIcon.None, Buttons);
        
        internal static DialogResult Show(IWin32Window Owner, String Message, MyMessageBoxButtons Buttons) => MyShow(Owner, String.Empty, Message, MyMessageBoxIcon.None, Buttons);

        internal static DialogResult Show(String Message, MyMessageBoxIcon Icon, MyMessageBoxButtons Buttons) => MyShow(null, String.Empty, Message, Icon, Buttons);
        
        internal static DialogResult Show(IWin32Window Owner, String Message, MyMessageBoxIcon Icon, MyMessageBoxButtons Buttons) => MyShow(Owner, String.Empty, Message, Icon, Buttons);
        
        internal static Int32 Show(String Message, MyMessageBoxIcon Icon, MyMessageBoxButtons Buttons, String[] Options, String Option = null) => MyShow(null, String.Empty, Message, Icon, Buttons, Options, Option);
        
        internal static Int32 Show(IWin32Window Owner, String Message, MyMessageBoxIcon Icon, MyMessageBoxButtons Buttons, String[] Options, String Option = null) => MyShow(Owner, String.Empty, Message, Icon, Buttons, Options, Option);


        internal static DialogResult Show(String Title, String Message) => MyShow(null, Title, Message, MyMessageBoxIcon.None, MyMessageBoxButtons.OK);

        internal static DialogResult Show(IWin32Window Owner, String Title, String Message) => MyShow(Owner, Title, Message, MyMessageBoxIcon.None, MyMessageBoxButtons.OK);
        
        internal static DialogResult Show(String Title, String Message, MyMessageBoxIcon Icon) => MyShow(null, Title, Message, Icon, MyMessageBoxButtons.OK);
        
        internal static DialogResult Show(IWin32Window Owner, String Title, String Message, MyMessageBoxIcon Icon) => MyShow(Owner, Title, Message, Icon, MyMessageBoxButtons.OK);
        
        internal static DialogResult Show(String Title, String Message, MyMessageBoxButtons Buttons) => MyShow(null, Title, Message, MyMessageBoxIcon.None, Buttons);
        
        internal static DialogResult Show(IWin32Window Owner, String Title, String Message, MyMessageBoxButtons Buttons) => MyShow(Owner, Title, Message, MyMessageBoxIcon.None, Buttons);

        internal static DialogResult Show(String Title, String Message, MyMessageBoxIcon Icon, MyMessageBoxButtons Buttons) => MyShow(null, Title, Message, Icon, Buttons);
        
        internal static DialogResult Show(IWin32Window Owner, String Title, String Message, MyMessageBoxIcon Icon, MyMessageBoxButtons Buttons) => MyShow(Owner, Title, Message, Icon, Buttons);
        
        internal static Int32 Show(String Title, String Message, MyMessageBoxIcon Icon, MyMessageBoxButtons Buttons, String[] Options, String Option = null) => MyShow(null, Title, Message, Icon, Buttons, Options, Option);
        
        internal static Int32 Show(IWin32Window Owner, String Title, String Message, MyMessageBoxIcon Icon, MyMessageBoxButtons Buttons, String[] Options, String Option = null) => MyShow(Owner, Title, Message, Icon, Buttons, Options, Option);


        private static DialogResult MyShow(IWin32Window Owner,  String Title, String Message, MyMessageBoxIcon Icon, MyMessageBoxButtons Buttons) => new MyMessageBox(Title, Message, Icon, Buttons).ShowDialog(Owner);
        
        private static Int32 MyShow(IWin32Window Owner,  String Title, String Message, MyMessageBoxIcon Icon, MyMessageBoxButtons Buttons, String[] Options, String Option = null){
            MyMessageBox MyMessageBox = new MyMessageBox(Title, Message, Icon, Buttons, Options, Option);
            
            MyMessageBox.ShowDialog(Owner);

            return MyMessageBox.OptionResult;
            }
        #endregion

        #region EVENTS
        protected override void OnPaint(PaintEventArgs PaintEventArgs) => ControlPaint.DrawBorder(PaintEventArgs.Graphics, ClientRectangle, Color.FromArgb(24, 202, 88), ButtonBorderStyle.Solid);

        private void MyMessageBoxShown(Object Object, EventArgs EventArgs){
            if(DefaultButton != null)
                DefaultButton.Focus();
            }

        private void MyMessageBoxClick(Object Object, EventArgs EventArgs){
            Button Button = (Object as Button);

            OptionResult = ((Button.Tag != null)?Convert.ToInt32(Button.Tag):-1);

            DialogResult = DialogResult.OK;

            Close();
            }
        #endregion
        }
    }
