using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace Xml2Ds
{
    public partial class frmDs : Form
    {
        private ModelDs model;

        public frmDs()
        {
            InitializeComponent();
            model = new ModelDs();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtpath.Text = @"";
            SettingBinding();

        }

        private void SettingBinding()
        {
            cbbTable.DataSource = model.cbbBindingSource;
            grdLeft.DataSource = model.dtBindingSource;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //LoadFile();
        }



        private void txtpath_Validated(object sender, EventArgs e)
        {
            LoadFile();
        }
        private void LoadFile()
        {
            try
            {
                var path = Path.Combine(txtpath.Text);
                var ds = new DataSet();
                ds.ReadXml(path);
                model.ds = ds.Copy();
                model.dt = ds.Tables[0].Copy();
                model.refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbbTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var tblName = cbbTable.SelectedItem.ToString();
                model.dt = model.ds.Tables[tblName];
                model.refreshDt();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
