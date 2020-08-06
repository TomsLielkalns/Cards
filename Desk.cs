using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Cards
{
    public partial class Desk : Form
    {
        private string folderPath = null;
        private string[] fileNames = null;
        private Random rand = new Random();

        public Desk()
        {
            InitializeComponent();
            InitializeDesk();
        }

        private void InitializeDesk()
        {
            this.BackColor = Color.Green;
        }

        private void LoadCards_Click(object sender, EventArgs e)
        {
            PictureBox filePictureBox = null;

            folderPath = @"C:\Users\Toms\source\repos\Cards\Playing Cards\playing_card_images\face";
            fileNames = Directory.GetFiles(folderPath);

            foreach (var fileName in fileNames)
            {
                filePictureBox = new PictureBox()
                {
                    Height = 100,
                    Width = 70,
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Left = rand.Next(0, 400),
                    Top = rand.Next(50, 300),
                    Image = Image.FromFile(fileName)
                };
                this.Controls.Add(filePictureBox);
            }
        }
    }
}
