using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace data_grid_view_clear
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        BindingList<Record> DataSource = new BindingList<Record>();
        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);

            // Attach the DataSurce to your DataGridView
            // Now changes to source records refresh in the view.
            dataGridView1.DataSource = this.DataSource;

            // Adding one or more records will generate the columns.
            DataSource.Add(new Record { Licznic = "ABC123", Procent = "XYZ" });
            DataSource.Add(new Record { Licznic = "DEF456", Procent = "PQR" });

            // Use string indexer to get a column
            dataGridView1.Columns[nameof(Record.Licznic)].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[nameof(Record.Licznic)].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            DataSource.Clear();
        }
    }

    public class Record
    {
        public string Licznic { get; set; }
        public string Procent { get; set; }
    }
}
