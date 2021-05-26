using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace MySpotify{
    public class CirclePictureBox : PictureBox{
        public CirclePictureBox(Image Image){
            BackColor = Color.FromArgb(0, 153, 186);
            BackgroundImage = Image;
            Dock = DockStyle.Fill;
            BackgroundImageLayout = ImageLayout.Stretch;
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


