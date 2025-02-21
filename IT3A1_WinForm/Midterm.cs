using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT3A1_WinForm
{
    internal class Midterm
    {
        private void Answer()
        {
            ComboBox cbo1 = new ComboBox();
            cbo1.Items.Add("List item");

            ListBox lb1 = new ListBox();
            lb1.Items.Add("Your item");

            ListView lv1 = new ListView();
            ListViewItem li = new ListViewItem();
            lv1.Items.Add(li);

            Form form1 = new Form();
            Form form2 = new Form();
            form2.IsMdiContainer = true;
            form1.MdiParent = form2;
            form1.Show();

            RadioButton rb = new RadioButton();
            rb.Checked = true;

            CheckBox cb = new CheckBox();
            cb.Checked = true;
        }
    }
}
