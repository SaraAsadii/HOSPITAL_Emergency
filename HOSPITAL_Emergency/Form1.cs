using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HOSPITAL_Emergency
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Emergency em = new Emergency();
        private void button14_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Hide();
            em.Show();
        }
    }
}
