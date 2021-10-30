using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeDataBase
{
    public partial class FormEmployee : Form
    {
        public FormEmployee()
        {
            InitializeComponent();
            this.dataGridView1.Columns[0].Visible = false;
        }

        private void FormEmployee_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'employeedbDataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.employeedbDataSet.Employee);

        }

        private void buttonAddNew_Click(object sender, EventArgs e)
        {

        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            this.employeeBindingSource.MoveNext();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
            
        private void buttonSave_Click(object sender, EventArgs e)
        {
               // TODO :)
            try
            {
                string msg = "Do you want to Save | Update the selected record  ?";
                string caption = "Save | Update : ThyView";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                MessageBoxIcon ico = MessageBoxIcon.Question;

                DialogResult result;

                result = MessageBox.Show(this, msg, caption, buttons, ico);


                if (result == DialogResult.Yes)
                {
                    // Save | Update
                    this.employeeBindingSource.EndEdit();
                    this.employeeTableAdapter.Connection.Open();
                    Console.WriteLine(this.employeeTableAdapter.Connection.ConnectionString);
                    Console.WriteLine(this.employeeTableAdapter.Connection.ServerVersion);
                    this.employeeTableAdapter.Update(this.employeedbDataSet.Employee);

                    //Refresh Data
                    this.employeeTableAdapter.Fill(this.employeedbDataSet.Employee);

                    MessageBox.Show("The record has been saved successfully. ",
                        "Sava Data : ThyView ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    return;
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Save | Update data failed :" + ex.Message.ToString(),
                    "Save Data : ThyView ",MessageBoxButtons.OK,MessageBoxIcon.Error);

            }
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            this.employeeBindingSource.MovePrevious();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            // TODO :)
            try
            {
                string msg = "Do you want to permenanently  delete the select record ?";
                string caption = "Save | Update : ThyView";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                MessageBoxIcon ico = MessageBoxIcon.Question;

                DialogResult result;

                result = MessageBox.Show(this, msg, caption, buttons, ico);


                if (result == DialogResult.Yes)
                {
                    // Delete 
                    this.employeeBindingSource.RemoveCurrent(); 

                    // save the change  
                    this.employeeBindingSource.EndEdit();
                    this.employeeTableAdapter.Update(this.employeedbDataSet.Employee);

                    //Refresh Data
                    this.employeeTableAdapter.Fill(this.employeedbDataSet.Employee);

                    MessageBox.Show("The record has been Deleted ",
                        "Delete Data : ThyView ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

                else
                {
                    return;
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Delete  data failed :" + ex.Message.ToString(),
                    "Delete Data : ThyView ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void phoneTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void phoneLabel_Click(object sender, EventArgs e)
        {

        }

        private void last_NameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void youTubeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void emailLabel_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void FormEmployee_FormClosing(object sender, FormClosingEventArgs e)
        {
            string msg = "Do you want to exit the application?";
            string caption = "Exit application : ThyView";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            MessageBoxIcon ico = MessageBoxIcon.Question;

            DialogResult result;

            result = MessageBox.Show(this, msg, caption, buttons, ico);

            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Goodbye,it was a  great time to to meet you ", "ThyView",
                    MessageBoxButtons.OK,MessageBoxIcon.Information);
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;

            }

            
        } 

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            buttonAddNew.PerformClick();        
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            buttonDelete.PerformClick();
        }

        private void toolStripButtonUpdateitem_Click(object sender, EventArgs e)
        {
            buttonSave.PerformClick();
        }

        private void toolStripButtonRefresh_Click(object sender, EventArgs e)
        {
            FormEmployee_Load(sender,e);
        }
    }
}
