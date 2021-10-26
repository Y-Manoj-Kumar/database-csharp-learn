namespace WindowsFormsApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label numberOfStudentsLabel;
            System.Windows.Forms.Label registerNumberLabel;
            System.Windows.Forms.Label departmentLabel;
            System.Windows.Forms.Label sectionLabel;
            System.Windows.Forms.Label yearOfJoiningLabel;
            System.Windows.Forms.Label stateLabel;
            System.Windows.Forms.Label phone_NoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.student_DataDataSet = new WindowsFormsApp.Student_DataDataSet();
            this.student_DataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.student_DataTableAdapter = new WindowsFormsApp.Student_DataDataSetTableAdapters.Student_DataTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp.Student_DataDataSetTableAdapters.TableAdapterManager();
            this.student_DataBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.student_DataBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.student_DataDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberOfStudentsTextBox = new System.Windows.Forms.TextBox();
            this.registerNumberTextBox = new System.Windows.Forms.TextBox();
            this.departmentTextBox = new System.Windows.Forms.TextBox();
            this.sectionTextBox = new System.Windows.Forms.TextBox();
            this.yearOfJoiningTextBox = new System.Windows.Forms.TextBox();
            this.stateTextBox = new System.Windows.Forms.TextBox();
            this.phone_NoTextBox = new System.Windows.Forms.TextBox();
            this.StudentInfo = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.addnewrecord = new System.Windows.Forms.Button();
            this.saverecord = new System.Windows.Forms.Button();
            this.deleterecord = new System.Windows.Forms.Button();
            this.exitapplication = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            numberOfStudentsLabel = new System.Windows.Forms.Label();
            registerNumberLabel = new System.Windows.Forms.Label();
            departmentLabel = new System.Windows.Forms.Label();
            sectionLabel = new System.Windows.Forms.Label();
            yearOfJoiningLabel = new System.Windows.Forms.Label();
            stateLabel = new System.Windows.Forms.Label();
            phone_NoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.student_DataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.student_DataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.student_DataBindingNavigator)).BeginInit();
            this.student_DataBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.student_DataDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // numberOfStudentsLabel
            // 
            numberOfStudentsLabel.AutoSize = true;
            numberOfStudentsLabel.Location = new System.Drawing.Point(96, 92);
            numberOfStudentsLabel.Name = "numberOfStudentsLabel";
            numberOfStudentsLabel.Size = new System.Drawing.Size(159, 20);
            numberOfStudentsLabel.TabIndex = 2;
            numberOfStudentsLabel.Text = "Number Of Students:";
            // 
            // registerNumberLabel
            // 
            registerNumberLabel.AutoSize = true;
            registerNumberLabel.Location = new System.Drawing.Point(96, 124);
            registerNumberLabel.Name = "registerNumberLabel";
            registerNumberLabel.Size = new System.Drawing.Size(133, 20);
            registerNumberLabel.TabIndex = 4;
            registerNumberLabel.Text = "Register Number:";
            // 
            // departmentLabel
            // 
            departmentLabel.AutoSize = true;
            departmentLabel.Location = new System.Drawing.Point(96, 156);
            departmentLabel.Name = "departmentLabel";
            departmentLabel.Size = new System.Drawing.Size(98, 20);
            departmentLabel.TabIndex = 6;
            departmentLabel.Text = "Department:";
            // 
            // sectionLabel
            // 
            sectionLabel.AutoSize = true;
            sectionLabel.Location = new System.Drawing.Point(96, 188);
            sectionLabel.Name = "sectionLabel";
            sectionLabel.Size = new System.Drawing.Size(67, 20);
            sectionLabel.TabIndex = 8;
            sectionLabel.Text = "Section:";
            // 
            // yearOfJoiningLabel
            // 
            yearOfJoiningLabel.AutoSize = true;
            yearOfJoiningLabel.Location = new System.Drawing.Point(96, 220);
            yearOfJoiningLabel.Name = "yearOfJoiningLabel";
            yearOfJoiningLabel.Size = new System.Drawing.Size(122, 20);
            yearOfJoiningLabel.TabIndex = 10;
            yearOfJoiningLabel.Text = "Year Of Joining:";
            // 
            // stateLabel
            // 
            stateLabel.AutoSize = true;
            stateLabel.Location = new System.Drawing.Point(96, 252);
            stateLabel.Name = "stateLabel";
            stateLabel.Size = new System.Drawing.Size(52, 20);
            stateLabel.TabIndex = 12;
            stateLabel.Text = "State:";
            // 
            // phone_NoLabel
            // 
            phone_NoLabel.AutoSize = true;
            phone_NoLabel.Location = new System.Drawing.Point(96, 284);
            phone_NoLabel.Name = "phone_NoLabel";
            phone_NoLabel.Size = new System.Drawing.Size(83, 20);
            phone_NoLabel.TabIndex = 14;
            phone_NoLabel.Text = "Phone No:";
            // 
            // student_DataDataSet
            // 
            this.student_DataDataSet.DataSetName = "Student_DataDataSet";
            this.student_DataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // student_DataBindingSource
            // 
            this.student_DataBindingSource.DataMember = "Student_Data";
            this.student_DataBindingSource.DataSource = this.student_DataDataSet;
            // 
            // student_DataTableAdapter
            // 
            this.student_DataTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Student_DataTableAdapter = this.student_DataTableAdapter;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp.Student_DataDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // student_DataBindingNavigator
            // 
            this.student_DataBindingNavigator.AddNewItem = null;
            this.student_DataBindingNavigator.BindingSource = this.student_DataBindingSource;
            this.student_DataBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.student_DataBindingNavigator.DeleteItem = null;
            this.student_DataBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.student_DataBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.student_DataBindingNavigatorSaveItem,
            this.toolStripButton1});
            this.student_DataBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.student_DataBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.student_DataBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.student_DataBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.student_DataBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.student_DataBindingNavigator.Name = "student_DataBindingNavigator";
            this.student_DataBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.student_DataBindingNavigator.Size = new System.Drawing.Size(1231, 33);
            this.student_DataBindingNavigator.TabIndex = 0;
            this.student_DataBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(54, 28);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 31);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // student_DataBindingNavigatorSaveItem
            // 
            this.student_DataBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.student_DataBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("student_DataBindingNavigatorSaveItem.Image")));
            this.student_DataBindingNavigatorSaveItem.Name = "student_DataBindingNavigatorSaveItem";
            this.student_DataBindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 28);
            this.student_DataBindingNavigatorSaveItem.Text = "Save Data";
            this.student_DataBindingNavigatorSaveItem.Click += new System.EventHandler(this.student_DataBindingNavigatorSaveItem_Click);
            // 
            // student_DataDataGridView
            // 
            this.student_DataDataGridView.AutoGenerateColumns = false;
            this.student_DataDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.student_DataDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.student_DataDataGridView.DataSource = this.student_DataBindingSource;
            this.student_DataDataGridView.Location = new System.Drawing.Point(70, 393);
            this.student_DataDataGridView.Name = "student_DataDataGridView";
            this.student_DataDataGridView.RowHeadersWidth = 62;
            this.student_DataDataGridView.RowTemplate.Height = 28;
            this.student_DataDataGridView.Size = new System.Drawing.Size(1111, 220);
            this.student_DataDataGridView.TabIndex = 1;
            this.student_DataDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.student_DataDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "NumberOfStudents";
            this.dataGridViewTextBoxColumn1.HeaderText = "NumberOfStudents";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "RegisterNumber";
            this.dataGridViewTextBoxColumn2.HeaderText = "RegisterNumber";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Department";
            this.dataGridViewTextBoxColumn3.HeaderText = "Department";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Section";
            this.dataGridViewTextBoxColumn4.HeaderText = "Section";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "YearOfJoining";
            this.dataGridViewTextBoxColumn5.HeaderText = "YearOfJoining";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "State";
            this.dataGridViewTextBoxColumn6.HeaderText = "State";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 150;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Phone No";
            this.dataGridViewTextBoxColumn7.HeaderText = "Phone No";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 150;
            // 
            // numberOfStudentsTextBox
            // 
            this.numberOfStudentsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.student_DataBindingSource, "NumberOfStudents", true));
            this.numberOfStudentsTextBox.Location = new System.Drawing.Point(261, 89);
            this.numberOfStudentsTextBox.Name = "numberOfStudentsTextBox";
            this.numberOfStudentsTextBox.Size = new System.Drawing.Size(141, 26);
            this.numberOfStudentsTextBox.TabIndex = 3;
            // 
            // registerNumberTextBox
            // 
            this.registerNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.student_DataBindingSource, "RegisterNumber", true));
            this.registerNumberTextBox.Location = new System.Drawing.Point(261, 121);
            this.registerNumberTextBox.Name = "registerNumberTextBox";
            this.registerNumberTextBox.Size = new System.Drawing.Size(141, 26);
            this.registerNumberTextBox.TabIndex = 5;
            // 
            // departmentTextBox
            // 
            this.departmentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.student_DataBindingSource, "Department", true));
            this.departmentTextBox.Location = new System.Drawing.Point(261, 153);
            this.departmentTextBox.Name = "departmentTextBox";
            this.departmentTextBox.Size = new System.Drawing.Size(141, 26);
            this.departmentTextBox.TabIndex = 7;
            // 
            // sectionTextBox
            // 
            this.sectionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.student_DataBindingSource, "Section", true));
            this.sectionTextBox.Location = new System.Drawing.Point(261, 185);
            this.sectionTextBox.Name = "sectionTextBox";
            this.sectionTextBox.Size = new System.Drawing.Size(141, 26);
            this.sectionTextBox.TabIndex = 9;
            // 
            // yearOfJoiningTextBox
            // 
            this.yearOfJoiningTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.student_DataBindingSource, "YearOfJoining", true));
            this.yearOfJoiningTextBox.Location = new System.Drawing.Point(261, 217);
            this.yearOfJoiningTextBox.Name = "yearOfJoiningTextBox";
            this.yearOfJoiningTextBox.Size = new System.Drawing.Size(141, 26);
            this.yearOfJoiningTextBox.TabIndex = 11;
            // 
            // stateTextBox
            // 
            this.stateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.student_DataBindingSource, "State", true));
            this.stateTextBox.Location = new System.Drawing.Point(261, 249);
            this.stateTextBox.Name = "stateTextBox";
            this.stateTextBox.Size = new System.Drawing.Size(141, 26);
            this.stateTextBox.TabIndex = 13;
            // 
            // phone_NoTextBox
            // 
            this.phone_NoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.student_DataBindingSource, "Phone No", true));
            this.phone_NoTextBox.Location = new System.Drawing.Point(261, 281);
            this.phone_NoTextBox.Name = "phone_NoTextBox";
            this.phone_NoTextBox.Size = new System.Drawing.Size(141, 26);
            this.phone_NoTextBox.TabIndex = 15;
            // 
            // StudentInfo
            // 
            this.StudentInfo.Location = new System.Drawing.Point(84, 67);
            this.StudentInfo.Name = "StudentInfo";
            this.StudentInfo.Size = new System.Drawing.Size(333, 254);
            this.StudentInfo.TabIndex = 16;
            this.StudentInfo.TabStop = false;
            this.StudentInfo.Text = "StudentInfo";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(917, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(314, 339);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // addnewrecord
            // 
            this.addnewrecord.ForeColor = System.Drawing.SystemColors.Highlight;
            this.addnewrecord.Location = new System.Drawing.Point(541, 67);
            this.addnewrecord.Name = "addnewrecord";
            this.addnewrecord.Size = new System.Drawing.Size(189, 31);
            this.addnewrecord.TabIndex = 18;
            this.addnewrecord.Text = "AddNewRecord";
            this.addnewrecord.UseVisualStyleBackColor = true;
            this.addnewrecord.Click += new System.EventHandler(this.addnewrecord_click);
            // 
            // saverecord
            // 
            this.saverecord.ForeColor = System.Drawing.SystemColors.Highlight;
            this.saverecord.Location = new System.Drawing.Point(541, 124);
            this.saverecord.Name = "saverecord";
            this.saverecord.Size = new System.Drawing.Size(189, 31);
            this.saverecord.TabIndex = 19;
            this.saverecord.Text = "SaveRecord";
            this.saverecord.UseVisualStyleBackColor = true;
            this.saverecord.Click += new System.EventHandler(this.saverecord_Click);
            // 
            // deleterecord
            // 
            this.deleterecord.ForeColor = System.Drawing.SystemColors.Highlight;
            this.deleterecord.Location = new System.Drawing.Point(541, 183);
            this.deleterecord.Name = "deleterecord";
            this.deleterecord.Size = new System.Drawing.Size(189, 31);
            this.deleterecord.TabIndex = 20;
            this.deleterecord.Text = "DeleteRecord";
            this.deleterecord.UseVisualStyleBackColor = true;
            this.deleterecord.Click += new System.EventHandler(this.button3_Click);
            // 
            // exitapplication
            // 
            this.exitapplication.ForeColor = System.Drawing.SystemColors.Highlight;
            this.exitapplication.Location = new System.Drawing.Point(541, 236);
            this.exitapplication.Name = "exitapplication";
            this.exitapplication.Size = new System.Drawing.Size(189, 36);
            this.exitapplication.TabIndex = 21;
            this.exitapplication.Text = "ExitApplication";
            this.exitapplication.UseVisualStyleBackColor = true;
            this.exitapplication.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.textBox1.Location = new System.Drawing.Point(541, 284);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(189, 26);
            this.textBox1.TabIndex = 22;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(34, 28);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 639);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.exitapplication);
            this.Controls.Add(this.deleterecord);
            this.Controls.Add(this.saverecord);
            this.Controls.Add(this.addnewrecord);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(numberOfStudentsLabel);
            this.Controls.Add(this.numberOfStudentsTextBox);
            this.Controls.Add(registerNumberLabel);
            this.Controls.Add(this.registerNumberTextBox);
            this.Controls.Add(departmentLabel);
            this.Controls.Add(this.departmentTextBox);
            this.Controls.Add(sectionLabel);
            this.Controls.Add(this.sectionTextBox);
            this.Controls.Add(yearOfJoiningLabel);
            this.Controls.Add(this.yearOfJoiningTextBox);
            this.Controls.Add(stateLabel);
            this.Controls.Add(this.stateTextBox);
            this.Controls.Add(phone_NoLabel);
            this.Controls.Add(this.phone_NoTextBox);
            this.Controls.Add(this.student_DataDataGridView);
            this.Controls.Add(this.student_DataBindingNavigator);
            this.Controls.Add(this.StudentInfo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.student_DataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.student_DataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.student_DataBindingNavigator)).EndInit();
            this.student_DataBindingNavigator.ResumeLayout(false);
            this.student_DataBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.student_DataDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Student_DataDataSet student_DataDataSet;
        private System.Windows.Forms.BindingSource student_DataBindingSource;
        private Student_DataDataSetTableAdapters.Student_DataTableAdapter student_DataTableAdapter;
        private Student_DataDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator student_DataBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton student_DataBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView student_DataDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.TextBox numberOfStudentsTextBox;
        private System.Windows.Forms.TextBox registerNumberTextBox;
        private System.Windows.Forms.TextBox departmentTextBox;
        private System.Windows.Forms.TextBox sectionTextBox;
        private System.Windows.Forms.TextBox yearOfJoiningTextBox;
        private System.Windows.Forms.TextBox stateTextBox;
        private System.Windows.Forms.TextBox phone_NoTextBox;
        private System.Windows.Forms.GroupBox StudentInfo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button addnewrecord;
        private System.Windows.Forms.Button saverecord;
        private System.Windows.Forms.Button deleterecord;
        private System.Windows.Forms.Button exitapplication;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}

