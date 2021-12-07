using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiaryMaker
{
    public partial class MainDairy : Form
    {
        public MainDairy()
        {
            InitializeComponent();
        }

        private void MainDairy_Load(object sender, EventArgs e)
        {

        }

        private void MainDairy_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (ImportanceComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select any importance level");
            }
            else
            {
                string file, Importance,Date,Pic;
                //int id;
                file = MainDiaryTextBox.Text;
                Date = DateTimePicker.Value.Date.ToString();
                Importance = ImportanceComboBox.SelectedItem.ToString();
                Pic = path;
                //id = Program.User_Id;
                DataAccess db = new DataAccess();

                int i = db.AddEvent(file, Importance, Date, Pic, Program.User_Id.ToString());
                if (i == 1)
                {
                    MessageBox.Show("DOCUMENT Saved");
                }

            }
        }

        string path;
        static int count = 0;
        private void UploadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                count++;
                UploadPictureBox.Image = new Bitmap(fd.FileName);
                UploadPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                path = @"E:\AIUB\study\c#\task\DiaryMaker\Pic\"+count+".jpg";
                File.Copy(fd.FileName, path, true);
            }
        }
        
        private void MainDiaryTextBox_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void UploadpictureBox_Click(object sender, EventArgs e)
        {

        }

        private void ImportaneLabel_Click(object sender, EventArgs e)
        {

        }

        
    }
}
