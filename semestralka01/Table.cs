using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace semestralka01
{
    public class Table
    {
        public Table(int id, string name, bool active)
        {
            this.IDtable = id;
            this.NameTable = name;
            this.ActiveTable = active ;
        }
        public Table()
        {
        }
        public int IDtable { get; set; }

        public string NameTable { get; set; }

        public bool ActiveTable { get; set; }

        public BindingList<Order> TableOrders = new BindingList<Order>();
    }
}

