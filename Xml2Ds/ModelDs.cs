using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Xml2Ds
{
    class ModelDs
    {
        public BindingSource dtBindingSource { get; set; }
        public BindingSource cbbBindingSource { get; set; }

        public DataTable dt { get; set; }
        public DataSet ds { get; internal set; }
        public List<string> ListTable
        {
            get
            {
                var rs = new List<string>();
                if (ds != null)
                {
                    foreach (DataTable dtbl in ds.Tables)
                    {
                        rs.Add(dtbl.TableName);
                    }
                }
                return rs;
            }
        }

        public ModelDs()
        {
            ds = new DataSet();
            dt = new DataTable();
            dtBindingSource = new BindingSource();
            dtBindingSource.DataSource = dt;
            cbbBindingSource = new BindingSource();
            cbbBindingSource.DataSource = ListTable;
            refresh();

        }
        public void refresh()
        {
            //dvLeft = new DataView(dt, WhereLeft, defaultSort, DataViewRowState.CurrentRows);
            //dvRight = new DataView(dt, WhereRight, defaultSort, DataViewRowState.CurrentRows);
            dtBindingSource.DataSource = dt;
            cbbBindingSource.DataSource = ListTable;
            
        }
                public void refreshDt()
        {
            //dvLeft = new DataView(dt, WhereLeft, defaultSort, DataViewRowState.CurrentRows);
            //dvRight = new DataView(dt, WhereRight, defaultSort, DataViewRowState.CurrentRows);
            dtBindingSource.DataSource = dt;
            
        }
    }
}
