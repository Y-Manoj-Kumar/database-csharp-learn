using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void student_DataBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            //this.Validate();
            //this.student_DataBindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.student_DataDataSet);

            saverecord.PerformClick();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'student_DataDataSet.Student_Data' table. You can move, or remove it, as needed.
            this.student_DataTableAdapter.Fill(this.student_DataDataSet.Student_Data);

        }

        private void student_DataDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            addnewrecord.PerformClick();
           
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            deleterecord.PerformClick();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void addnewrecord_click(object sender, EventArgs e)
        {
            MessageBox.Show("you have pressed a button");

            try
            {
                if(addnewrecord.Text == "AddNewRecord")
                {
                    student_DataBindingSource.AddNew();
                    addnewrecord.Text = "cancel";
                }
                else
                {
                    addnewrecord.Text = "AddNewRecord";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("An errro occured:" + ex.Message.ToString());
                    
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("you have pressed a button");
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void saverecord_Click(object sender, EventArgs e)
        {
            MessageBox.Show("you have pressed a button");
        }
    }
}
