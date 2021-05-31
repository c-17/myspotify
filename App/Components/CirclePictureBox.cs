using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace MySpotify.Components{
    internal class CirclePictureBox : PictureBox{
        internal CirclePictureBox(Image Image){
            //BackColor = Color.FromArgb(99, 99, 99);

            BackgroundImage = Image;
            BackgroundImageLayout = ImageLayout.Zoom;

            Dock = DockStyle.Fill;
            }

        protected override void OnResize(EventArgs e){
            base.OnResize(e);

            using(GraphicsPath GraphicsPath = new GraphicsPath()){
                GraphicsPath.AddEllipse(new Rectangle(1, 1, Width-2, Height-2));
                Region = new Region(GraphicsPath);
                }
            }
        }
    }


