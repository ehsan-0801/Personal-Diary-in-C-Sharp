using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiaryMaker
{
    public partial class AllDocuments : Form
    {
        EventAccess evn;
        public AllDocuments()
        {
            InitializeComponent();
            evn = new EventAccess();
            EventDataGridView.DataSource = evn.GetAllComponents();
        }



        private void AllDocuments_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void BackDcButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }



        private void DeleteButton_Click(object sender, EventArgs e)
        {
            int id = int.Parse(EventnoTextBox.Text);
            DataAccess dt = new DataAccess();
            dt.DeleteDocuments(id);
            evn = new EventAccess();
            EventDataGridView.DataSource = evn.GetAllComponents();
            EventnoTextBox.Text = null;
        }

        private void AllDocuments_Load(object sender, EventArgs e)
        {

        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            new MainDairy().Show();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            int id = int.Parse(EventnoTextBox.Text);
            Update u = new Update(id);
            u.Show();
            this.Hide();
        }
    }
}
