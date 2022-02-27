using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InventoryManagementApp.Manager;
using InventoryManagementApp.Model;

namespace InventoryManagementApp.UI
{
    public partial class UserUI : Form
    {
        public UserUI()
        {
            InitializeComponent();
        }
        UserManager userManager=new UserManager();
        
        private void UserUI_Load(object sender, EventArgs e)
        {
            LoadStatusComboBox();
            LoadTypeComboBox();
        }

        private void LoadTypeComboBox()
        {
            List<UserTypes> getAllTypeses = userManager.GetAllUserTypeses();
            typeComboBox.DataSource = getAllTypeses;
            typeComboBox.DisplayMember = "UserType";
            typeComboBox.ValueMember = "Id";
        }

        private void LoadStatusComboBox()
        {
            Dictionary<string, string> comboDictionary = new Dictionary<string, string>();
            comboDictionary.Add("1", "Active");
            comboDictionary.Add("2", "Inactive");
            statusComboBox.DataSource = new BindingSource(comboDictionary, null);
            statusComboBox.DisplayMember = "Value";
            statusComboBox.ValueMember = "Key";
        }

        private void imageButton_Click(object sender, EventArgs e)
        {
            //Image file;
            //OpenFileDialog f = new OpenFileDialog();
            ////f.Filter = "JPG (*.JPG)|*.jpg";
            //f.Filter = "(*.*)|*.*";
            //if (f.ShowDialog() == DialogResult.OK)
            //{
            //    file = Image.FromFile(f.FileName);
            //    uploadPicturBox.Image = file;
            //    uploadPicturBox.SizeMode = PictureBoxSizeMode.StretchImage;
            //}

            //Another process
            using (OpenFileDialog openFileDialog1 = new OpenFileDialog())
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    fileNameLabel.Text = Path.GetFileName(openFileDialog1.FileName);
                    Image img = Image.FromFile(openFileDialog1.FileName);
                    byte[] bytes = (byte[])(new ImageConverter()).ConvertTo(img, typeof(byte[]));
                    uploadPicturBox.Image = Image.FromStream(new MemoryStream(bytes));
                    uploadPicturBox.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }


        }

        private void addButton_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.UserName = userNameTextBox.Text;
            user.EmailAddress = emailAddressTextBox.Text;
            if (passwordTextBox.Text == confirmPasswordTextBox.Text)
            {
                user.Password = passwordTextBox.Text;
            }
            else
            {
                MessageBox.Show("Password don't match");
                return;
            }
            user.UserTypeId =Convert.ToInt32(typeComboBox.SelectedValue);
            user.Status = statusComboBox.SelectedValue.ToString();
            MemoryStream memoryStream=new MemoryStream();
            uploadPicturBox.Image.Save(memoryStream,uploadPicturBox.Image.RawFormat);
            user.Photo = memoryStream.ToArray();
            string message = userManager.AddUser(user);
            MessageBox.Show(message);



        }
    }
}
