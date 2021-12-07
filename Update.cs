using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiaryMaker
{
    public partial class Update : Form
    {
        int id;
        public Update(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (UpdateImportanceComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select any importance level");
            }
            else
            {
                string file, Importance, Date, Pic;
                //int id;
                file = UpdateTextBox.Text.ToString();
                Date = DateTimePicker.Value.Date.ToString();
                Importance = UpdateImportanceComboBox.SelectedItem.ToString();
                Pic = path2;
                //id = Program.User_Id;
                DataAccess db = new DataAccess();

                int i = db.UpdateEvent(file, Importance, Date, Pic,   this.id.ToString());
                if (i == 1)
                {
                    MessageBox.Show("DOCUMENT Updated");
                }

            }
        }
        string path2;
        static int count2 = 0;
        private void UpdateUploadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                count2++;
                UpdateUploadPictureBox.Image = new Bitmap(fd.FileName);
                UpdateUploadPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                path2 = @"E:\AIUB\study\c#\task\DiaryMaker\Pic\" + count2 + ".jpg";
                File.Copy(fd.FileName, path2, true);
            }
        }

        private void UpdateBackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AllDocuments().Show();
        }

        private void UpdateUploadPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void UpdateTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Update_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Update_Load(object sender, EventArgs e)
        {

        }

        
    }
}
