using System;
using System.Reflection;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Xml2Ds
{
    public partial class frmSemi : Form
    {
        private Model model;

        public frmSemi()
        {
            InitializeComponent();
            model = new Model();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            txtpath.Text = @"E:\10_Ogawakensetsu\V6\01_Develop\Product\Its.Process.Musashi\Web\ITS.Usolia.Process.Web\App_Data\SqlText.xml";
            txtSearch_Left.Text = @"131001";
            txtSearch_Right.Text = @"131001";

            
            SettingBinding();


        }

        private void SettingBinding()
        {
            txtSearch_Left.DataBindings.Add("Text", model, "SearchLeft", false, DataSourceUpdateMode.OnPropertyChanged);
            txtSearch_Right.DataBindings.Add("Text", model, "SearchRight", false, DataSourceUpdateMode.OnPropertyChanged);

            var contactBindingSource = new BindingSource();
            grdLeft.DataSource = contactBindingSource;
            contactBindingSource.DataSource = model.dvLeft;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //LoadFile();
        }

        private void LoadFile()
        {
            var path = Path.Combine(txtpath.Text);
            var ds = new DataSet();
            ds.ReadXml(path);
            model.dt = ds.Tables[0].Copy();
            model.refresh();
            grdLeft.DataSource = model.dvLeft;
            grdRight.DataSource = model.dvRight;
        }

        private void btnLoad_Left_Click(object sender, EventArgs e)
        {
            model.refresh();
            grdLeft.DataSource = model.dvLeft;
        }

        private void btnLoad_Right_Click(object sender, EventArgs e)
        {
            model.refresh();
            grdRight.DataSource = model.dvRight;
        }

        private void txtpath_Validated(object sender, EventArgs e)
        {
            LoadFile();
        }
    }
}
