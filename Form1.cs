using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;

namespace Gif_to_Sheet
{
    public partial class Form1 : Form
    {

        Image gif;
        Bitmap bitmap;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "GIF Images (*.gif)|*.gif";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                gif = Image.FromFile(ofd.FileName);
                tbFile.Text = ofd.FileName;
                pbSprite.Visible = true;
                FormatImage();
            }
        }

        private void FormatImage()
        {
            if (gif == null)
                return;
            if (bitmap != null)
                bitmap.Dispose();
            FrameDimension frameSize = new FrameDimension(gif.FrameDimensionsList[0]);
            Size imageSize = new Size(gif.Size.Width, gif.Size.Height);
            int frames = gif.GetFrameCount(frameSize);
            int calculatedColumns = (int)Math.Round(Math.Sqrt(frames));
            int columns = (int)calculatedColumns < 1 ? frames : (int)calculatedColumns;
            int rows = (int)Math.Ceiling((double)frames / columns);
            bitmap = new Bitmap(columns * imageSize.Width, rows * imageSize.Height);
            Graphics g = Graphics.FromImage(bitmap);
            SolidBrush brush = new SolidBrush(Color.Transparent);
            g.FillRectangle(brush, new Rectangle(0, 0, bitmap.Width, bitmap.Height));
            for (int i = 0; i < frames; i++)
            {
                gif.SelectActiveFrame(frameSize, i);
                g.DrawImage(gif, i % columns * imageSize.Width, i / columns * imageSize.Height);
            }
            g.Dispose();
            pbSprite.Image = bitmap;
            pbSprite.Size = bitmap.Size;
            this.Refresh();
        }

        private void nudColumns_ValueChanged(object sender, EventArgs e)
        {
            FormatImage();
        }

        private void pbBackColor_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.Color = Color.Transparent;
            if (cd.ShowDialog() == DialogResult.OK)
            {
                FormatImage();
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PNG Files (*.png)|*.png|BMP Files (*.bmp)|*.bmp|JPEG Files (*.jpeg)|*.jpeg|GIF Files (*.gif)|*.gif";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                ImageFormat format;
                string ext = Path.GetExtension(sfd.FileName);
                switch (ext)
                {
                    case ".png":
                        format = ImageFormat.Png;
                        break;
                    case ".jpeg":
                        format = ImageFormat.Jpeg;
                        break;
                    case ".bmp":
                        format = ImageFormat.Bmp;
                        break;
                    case ".gif":
                        format = ImageFormat.Gif;
                        break;
                    default:
                        format = ImageFormat.Png;
                        break;
                }
                pbSprite.Image.Save(sfd.FileName, format);
            }
        }

        private void inputFolderButton_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    inputFolderBox.Text = dialog.SelectedPath;
                }
            }
        }

        private void exportFolderButton_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    outputFolderBox.Text = dialog.SelectedPath;
                }
            }
        }

        private void folderGoButton_Click(object sender, EventArgs e)
        {
            string[] fileEntries = Directory.GetFiles(inputFolderBox.Text);
            foreach (string filename in fileEntries)
            {

                gif = Image.FromFile(filename);
                pbSprite.Visible = true;
                FormatImage();
                pbSprite.Image.Save(Path.Combine(outputFolderBox.Text,Path.GetFileNameWithoutExtension(filename) + ".png"), ImageFormat.Png);
                Console.WriteLine("Wrote : " + Path.GetFileNameWithoutExtension(filename) + "*.png");
            }
            MessageBox.Show("Operation complete");
        }
    }
}
