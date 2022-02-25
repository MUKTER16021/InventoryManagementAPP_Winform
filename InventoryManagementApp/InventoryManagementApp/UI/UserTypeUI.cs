using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InventoryManagementApp.Manager;
using InventoryManagementApp.Model;

namespace InventoryManagementApp
{
    public partial class userTypeForm : Form
    {
        public userTypeForm()
        {
            InitializeComponent();
        }

        UserTypesManager userTypesManager = new UserTypesManager();

        private void userTypeForm_Load(object sender, EventArgs e)
        {
            Dictionary<string, string> comboDictionary = new Dictionary<string, string>();
            comboDictionary.Add("1", "Active");
            comboDictionary.Add("2", "Inactive");
            statusComboBox.DataSource = new BindingSource(comboDictionary, null);
            statusComboBox.DisplayMember = "Value";
            statusComboBox.ValueMember = "Key";

            LoadAllTypes();
        }

        private void addButton_Click(object sender, EventArgs e)
        {

            UserTypes userTypes = new UserTypes();
            userTypes.UserType = userTypeTextBox.Text;
            userTypes.Status = ((KeyValuePair<string, string>) statusComboBox.SelectedItem).Value;
            string message = userTypesManager.AddUserTypes(userTypes);
            MessageBox.Show(message);
            LoadAllTypes();
        }

        private void LoadAllTypes()
        {
            showUserTypeListView.Items.Clear();
            List<UserTypes> userTypes = userTypesManager.GetAllUserTypeses();

            foreach (UserTypes types in userTypes)
            {
                ListViewItem item = new ListViewItem();
                item.Text = types.UserType;
                item.SubItems.Add(types.Status);
                item.Tag = types;

                showUserTypeListView.Items.Add(item);
            }
        }

        private void showUserTypeListView_DoubleClick(object sender, EventArgs e)
        {
            ListViewItem selectecdItem = showUserTypeListView.SelectedItems[0];
            UserTypes types = selectecdItem.Tag as UserTypes;
            userTypeTextBox.Text = types.UserType;
            statusComboBox.SelectedItem=types.Status;
            showIdLabel.Text = types.Id.ToString();

            addButton.Text = "Update";
            //removeButton.Enabled = true;
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(showIdLabel.Text);
            DialogResult result = MessageBox.Show("Are you sure delete this person", "Delete Person",
                MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                string message = userTypesManager.DeleteTypes(id);
                MessageBox.Show(message);
                LoadAllTypes();
                addButton.Text = "Save";
                removeButton.Enabled = false;

            }
        }
    }
}
