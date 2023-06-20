using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reisi
{
    public partial class Form2 : Form
    {
        private Form1 form1;

        public Form2(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }
        public string Destination { get; private set; }

        public Form2(List<Flight> flights)
        {
            InitializeComponent();
            InitDestinations(flights); // инициализация списка пунктов назначения
        }

        private void InitDestinations(List<Flight> flights)
        {
            var destinations = flights.Select(f => f.Destination).Distinct();
            comboBox1.Items.AddRange(destinations.ToArray());
        }



        private void btnOk_Click_1(object sender, EventArgs e)
        {
            Destination = comboBox1.SelectedItem?.ToString();
            DialogResult = DialogResult.OK;
            Close(); ;
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
