using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Nodes;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        private DataTable CreateTable(int RowCount)
        {
            DataTable tbl = new DataTable();
            tbl.Columns.Add("Name", typeof(string));
            tbl.Columns.Add("ID", typeof(int));
            tbl.Columns.Add("Number", typeof(int));
            tbl.Columns.Add("Date", typeof(DateTime));
            tbl.Columns.Add("ParentID", typeof(int));
            for (int i = 0; i < RowCount; i++)
                tbl.Rows.Add(new object[] { String.Format("Name{0}", i), i + 1, 3 - i, DateTime.Now.AddDays(i), i % 3 });
            return tbl;
        }

        HideCheckBoxHelper hideCheckBoxHelper;
        public Form1()
        {
            InitializeComponent();
            treeList1.DataSource = CreateTable(30);
            treeList1.ExpandAll();
            hideCheckBoxHelper = new HideCheckBoxHelper(treeList1);
        }

        private void spinEdit1_EditValueChanged(object sender, EventArgs e)
        {
            hideCheckBoxHelper.Level = Convert.ToInt16(spinEdit1.Value);
        }

        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {
            hideCheckBoxHelper.NeedHide = checkEdit1.Checked;
        }
    }

    public class HideCheckBoxHelper
    {
        
        public HideCheckBoxHelper(TreeList treeList)
        {
            _TreeList = treeList;
            treeList.CustomDrawNodeCheckBox += treeList_CustomDrawNodeCheckBox;
            treeList.BeforeCheckNode += treeList_BeforeCheckNode;
        }

        private int _Level = -1;
        private TreeList _TreeList;
        public int Level
        {
            get { return _Level; }
            set { _Level = value; _TreeList.Refresh(); }
        }

        private bool _Hide = true;
        public bool NeedHide
        {
            get { return _Hide; }
            set { _Hide = value; _TreeList.Refresh(); }
        }

        private bool CanCheckNode(TreeListNode node)
        {
            if (Level == -1)
                return true;
            return node.Level == Level;
        }

        void treeList_BeforeCheckNode(object sender, CheckNodeEventArgs e)
        {
            e.CanCheck = CanCheckNode(e.Node);
        }

        void treeList_CustomDrawNodeCheckBox(object sender, CustomDrawNodeCheckBoxEventArgs e)
        {
            bool canCheckNode = CanCheckNode(e.Node);
            if (canCheckNode)
                return;
            e.ObjectArgs.State = DevExpress.Utils.Drawing.ObjectState.Disabled;
            e.Handled = NeedHide;
        }
    }
}