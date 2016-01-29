using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Flipbook
{
    public partial class Zoom : Form
    {
        Bitmap _mybmp;
        bool _showGrid = false;
        bool _showNumbers = false;

        public Zoom()
        {
            InitializeComponent();
        }

        private void Zoom_Load(object sender, EventArgs e)
        {

        }

        private void SetShowGrid(bool value)
        {
            if (_showGrid != value)
            {
                btnGridlines.Checked = value;
                _showGrid = value;
                BuildImage();
            }
        }

        /*
        private void SetShowNumbers(bool value)
        {
            if (_showNumbers != value)
            {
                btnNumbers.Checked = value;
                _showNumbers = value;
                BuildImage();
            }
        }
         * */

        private void BuildImage()
        {
            if (_mybmp != null)
            {
                double relation = ((double)_mybmp.Width / (double)_mybmp.Height);
                
                int target_width = pictureBox1.Width;
                int target_height = (int)(target_width / relation);

                if (pictureBox1.Height > 960) target_height = 960;
                else if (pictureBox1.Height > 768) target_height = 768;
                else if (pictureBox1.Height > 576) target_height = 576;
                else if (pictureBox1.Height > 384) target_height = 384;
                else target_height = 192;
                target_width = (int)(target_height * relation);

                /*
                if (target_height > pictureBox1.Height)
                {
                    target_height = pictureBox1.Height;
                    target_width = (int)(target_height * relation);
                }
                 * */

                Bitmap newImage = new Bitmap(target_width, target_height);

                Graphics g = Graphics.FromImage(newImage);

                g.CompositingMode = CompositingMode.SourceOver;
                g.CompositingQuality = CompositingQuality.Default;
                g.InterpolationMode = InterpolationMode.NearestNeighbor;
                g.SmoothingMode = SmoothingMode.None;
                
                int w = _mybmp.Width;
                int h = _mybmp.Height;

                int x = 0;
                int y = 0;

                Rectangle destRect = new Rectangle(x, y, w, h);

                g.DrawImage(_mybmp,
                     new Rectangle(0, 0, target_width, target_height),
                     new Rectangle(0, 0, _mybmp.Width, _mybmp.Height),
                     GraphicsUnit.Pixel);

                if (_showGrid && (pictureBox1.Height > 384))
                {
                    float pix_per_line = (float)newImage.Height / (float)_mybmp.Height;
                    for (int i = 0; i < _mybmp.Height; i++)
                    {
                        g.DrawLine(new Pen(new SolidBrush(Color.FromArgb(100, Color.Black))), (float)0, (float)i * pix_per_line - 2, (float)newImage.Width, (float)i * pix_per_line - 2);
                    }
                    float pix_per_row = (float)newImage.Width / (float)_mybmp.Width;
                    for (int i = 0; i < _mybmp.Width; i++)
                    {
                        g.DrawLine(new Pen(new SolidBrush(Color.FromArgb(100,Color.Black))), (float)i * pix_per_row-2, (float)0, (float)i * pix_per_row-2, (float)newImage.Height);
                    }
                    
                    
                }

                if (_showNumbers)
                {
                }

                g.Dispose();


                pictureBox1.Image = newImage;
            }
        }
        
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            BuildImage();
        }

        public void ShowImage(Bitmap bmp)
        {
            _mybmp = bmp;
            BuildImage();
        }

        private void btnGridlines_Click(object sender, EventArgs e)
        {
            SetShowGrid(!_showGrid);
        }

        /*
        private void btnNumbers_Click(object sender, EventArgs e)
        {
            SetShowNumbers(!_showNumbers);
        }
         * */

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                saveFileDialog1.Title = "Save Zoomed Image";
                saveFileDialog1.Filter = "Portable Network Graphic (*.png)|*.png";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image.Save(saveFileDialog1.FileName);
                }
            }
        }

    }
}