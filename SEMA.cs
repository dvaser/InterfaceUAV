using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.MapProviders;
using System.Drawing.Drawing2D;

namespace SemaInterface
{
    public partial class Sema : Form
    {
        public Sema()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyPress += (ss, ee) =>
            {
                if (ee.KeyChar == 27) //= escape
                {
                    Environment.Exit(1);
                }
            };
        }

        Point İlkkonum; // Bu değişkenler Global olarak tanımlanmalı.
        bool durum = false;

        private void tabL_MouseDown(object sender, MouseEventArgs e)
        {
            // Mouse a tıklandığı anda. Burada sol yada sağ tıklanması farketmeyecektir.
            durum = true;
            this.Cursor = Cursors.SizeAll; // Fareyi taşıma şeklinde seçim yapılmış ikon halini almasını sağladık.
            İlkkonum = e.Location; /* İlk konum olarak fareye tam basıldığında e parametresinin Location özelliğini
                                    * kullanarak konum aldık. X ve Y koordinatlarını almış olduk.*/
        }

        private void tabL_MouseUp(object sender, MouseEventArgs e)
        {
            // Mouse'u bıraktığımızda çalışacak kodlar.
            durum = false;
            this.Cursor = Cursors.Default; // Fare işaretçisi Default halini aldı.
        }

        private void tabL_MouseMove(object sender, MouseEventArgs e)
        {
            // Mouse'u hareket ettirdiğimizde çalışacak kodlar.
            if (durum)
            {
                this.Left = e.X + this.Left - (İlkkonum.X);
                this.Top = e.Y + this.Top - (İlkkonum.Y);
            }
        }


        private Bitmap rotateImage90(int c,Bitmap b)
        {
            Bitmap returnBitmap = new Bitmap(b.Height, b.Width);
            Graphics g = Graphics.FromImage(returnBitmap);
            g.TranslateTransform((float)b.Width / 2, (float)b.Height / 2);
            g.RotateTransform(c);
            g.TranslateTransform(-(float)b.Width / 2, -(float)b.Height / 2);
            g.DrawImage(b, new Point(0, 0));
            return returnBitmap;
        }
        private void Sema_Load(object sender, EventArgs e)
        {
            trackBar1.Maximum = 91;
            trackBar1.Minimum = -91;
            map.MapProvider = GMap.NET.MapProviders.GMapProviders.GoogleHybridMap;
            map.Position = new GMap.NET.PointLatLng(40.23, 27.34);
            map.MinZoom = 5;
            map.MaxZoom = 100;
            map.Zoom = 10;
            map.DragButton = MouseButtons.Left;
            GMap.NET.PointLatLng point = new GMap.NET.PointLatLng(40.23, 27.34);
            GMapOverlay markers = new GMapOverlay("markers");
            Bitmap original = (Bitmap)Image.FromFile("C:/Users/aeker/source/repos/Interface/Resources/uav.png");
            Bitmap resized = new Bitmap(original, new Size(original.Width / 10, original.Height / 10));

            GMapMarker marker = new GMarkerGoogle(
                new PointLatLng(40.23, 27.34),
                resized);
            markers.Markers.Add(marker);
            map.Overlays.Add(markers);
            resized = rotateImage90(0, resized);


        }

        private void tab_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            WindowState = (WindowState == FormWindowState.Normal ? FormWindowState.Maximized : FormWindowState.Normal);
        }

        private void buttonFPV_Click(object sender, EventArgs e)
        {

        }

        private void buttonPFD_Click(object sender, EventArgs e)
        {

        }

        private void buttonSensors_Click(object sender, EventArgs e)
        {

        }

        private void buttonPlaneData_Click(object sender, EventArgs e)
        {

        }

        private void buttonMap_Click(object sender, EventArgs e)
        {
            
        }

        private void elementHost1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            roll1.Rotate();
            height1.Translate();
            yaw1.Rotate();
            pitch1.Rotate();
            speed1.Rotate();
            pitch1.pointerValue = trackBar1.Value;
            yaw1.pointerValue = trackBar1.Value;
            height1.pointerValue = 90+trackBar1.Value;
            roll1.pointerValue = trackBar1.Value;
            speed1.pointerValue = trackBar1.Value;
        }

        private void panelPlaneData_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void map_Load(object sender, EventArgs e)
        {

            
            
        }

        private void tabL_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
