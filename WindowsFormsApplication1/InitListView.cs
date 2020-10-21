using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public static class InitListView
    {
        public static void InitColumns(ListView showMessages)
        {
            var headers = new List<String> { "Name", "Phone Number", "Message", "Time" };
            foreach (var header in headers)
            {
                AddColumns(showMessages, header);
            }
        }
        public static void AddColumns(ListView showMessages, string header)
        {
            ColumnHeader column = new ColumnHeader();
            column.Text = header;
            column.TextAlign = HorizontalAlignment.Left;            
            column.Width = -2;
            showMessages.Columns.Add(column);
        }
    }
}
