using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MS_SQL_Management_System
{
    public partial class AddDashboard : Form
    {
        public AddDashboard()
        {
            InitializeComponent();
        }

        String imageLocation = "";
        Image initialImage;



        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            String dashBoardName = nameOfDashboardtxt.Text;
            String dashBoardCreatorName = nameOfCreatorTxt.Text;
            String groupName = grouptxt.Text;
            String publication = datePublished.Text;
            


            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "data source = LAPTOP-48SAL22A\\SQLEXPRESS; database = ManagementDatabase; integrated security = True";

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = connection;

            connection.Open();
            cmd.CommandText = "insert into NewDashboard (dName,dCreatorName,dGroup,dPubl,img) values ('" + dashBoardName + "','" + dashBoardCreatorName + "','" + groupName + "','" + publication + "','" + imageLocation + "')";
            cmd.ExecuteNonQuery();
            connection.Close();

            MessageBox.Show("Data Saved ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Clear the textboxes
            nameOfDashboardtxt.Clear();
            nameOfCreatorTxt.Clear();
            grouptxt.Clear();
            imageLocation = "";
            uploadedDashboard.Image = initialImage;
        }

        private void uploadButton_Click(object sender, EventArgs e)
        {

            initialImage = 
            
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files|*.png| All files(*.*)|*.*";

                if(dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;
                    uploadedDashboard.ImageLocation = imageLocation;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
