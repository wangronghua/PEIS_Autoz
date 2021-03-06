﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace PEIS.cxgl
{
    /// <summary>
    /// 对ListView的列排序
    /// </summary>
    public class MyListViewSort : System.Collections.IComparer
    {
        private int col;
        private bool descK;
        public MyListViewSort()
        {
            col = 0;
        }
        public MyListViewSort(int column, object Desc)
        {
            descK = (bool)Desc;
            col = column; //当前列,0,1,2...,参数由ListView控件的ColumnClick事件传递
        }
        public int Compare(object x, object y)
        {
            int tempInt = String.Compare(((ListViewItem)x).SubItems[col].Text, ((ListViewItem)y).SubItems[col].Text);
            if (descK) return -tempInt;
            else return tempInt;
        }
    }

}
