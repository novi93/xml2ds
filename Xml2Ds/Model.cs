using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xml2Ds
{
    class Model
    {
        public DataTable dt { get; set; }
        public string SearchLeft { get; set; }
        public string SearchRight { get; set; }
        public DataView dvLeft { get; set; }
        public DataView dvRight { get; set; }

        public string WhereLeft {
            get { return string.Concat("SQL_CODE Like '", SearchLeft,"'"); }
        }

        public string WhereRight
        {
            get { return string.Concat("SQL_CODE Like '", SearchRight, "'"); }
        }
        string defaultSort = "SQL_CODE, SQL_EVENT";

        public Model()
        {
            dt = new DataTable();
            dt.Columns.Add("SQL_CODE");
            dt.Columns.Add("SQL_EVENT");
            refresh();

        }
        public void refresh()
        {
            dvLeft = new DataView(dt, WhereLeft, defaultSort, DataViewRowState.CurrentRows);
            dvRight = new DataView(dt, WhereRight, defaultSort, DataViewRowState.CurrentRows);
        }
    }
}
