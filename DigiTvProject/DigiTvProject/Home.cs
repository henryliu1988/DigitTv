using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigiTvProject
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button_realtime_Click(object sender, EventArgs e)
        {
            RealForm form = new RealForm();
            form.ShowDialog();
        }

        private void button_history_Click(object sender, EventArgs e)
        {
            HistoryForm form = new HistoryForm();
            form.ShowDialog();

        }

        private void button_full_Click(object sender, EventArgs e)
        {
            FullForm form = new FullForm();
            form.ShowDialog();

        }

        private void button_search_Click(object sender, EventArgs e)
        {
            SearchFrom form = new SearchFrom();
            form.ShowDialog();

        }
    }
}
