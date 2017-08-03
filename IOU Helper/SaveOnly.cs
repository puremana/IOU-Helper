using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace IOU_Helper
{
    public partial class SaveOnly : Form
    {

        List<Tab> _tabList = new List<Tab>();
        List<String> _tabListAdded = new List<String>();
        private readonly Form1 _form1;

        public SaveOnly(List<Tab> tabList, Form1 form1)
        {
            InitializeComponent();
            _tabList = tabList;
            _form1 = form1;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (listBoxAccounts.SelectedIndex != -1)
            {
                int sIndex = listBoxAccounts.SelectedIndex;
                if (_tabListAdded[sIndex] == "removed")
                {
                    _tabListAdded[sIndex] = "added";
                    listBoxAccounts.Items[sIndex] = _tabList[sIndex].getUsername() + " (Added)";
                }
                else
                {
                    MessageBox.Show("This account is already added.");
                }
            }
            else
            {
                MessageBox.Show("Please select an account to add first.");
            }
        }

        private void SaveOnly_Load(object sender, EventArgs e)
        {
            foreach (Tab tab in _tabList)
            {
                listBoxAccounts.Items.Add(tab.getUsername() + " (Added)");
                _tabListAdded.Add("added");
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (listBoxAccounts.SelectedIndex != -1)
            {
                int sIndex = listBoxAccounts.SelectedIndex;
                if (_tabListAdded[sIndex] == "added")
                {
                    _tabListAdded[sIndex] = "removed";
                    listBoxAccounts.Items[sIndex] = _tabList[sIndex].getUsername() + " (Removed)";
                }
                else
                {
                    MessageBox.Show("This account is already removed.");
                }
            }
            else
            {
                MessageBox.Show("Please select an account to remove first.");
            }
        }

        private void buttonSaveAs_Click(object sender, EventArgs e)
        {
            const string FILTER = "CSV Files|*.csv|All Files|*.*";
            saveFileDialog1.Filter = FILTER;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StreamWriter writer = File.CreateText(saveFileDialog1.FileName);
                    string details = "";
                    int i = 0;
                    foreach (Tab tab in _tabList)
                    {
                        if (_tabListAdded[i] == "added")
                        {
                            details = details + tab.ToString() + ",";
                        }
                        i++;
                    }

                    writer.WriteLine(details);
                    writer.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
    }
}
