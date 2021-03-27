
namespace CollageManagementSystem
{
    partial class students
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(students));
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.stddepartment = new System.Windows.Forms.ComboBox();
            this.edit = new Bunifu.Framework.UI.BunifuFlatButton();
            this.home = new Bunifu.Framework.UI.BunifuFlatButton();
            this.delete = new Bunifu.Framework.UI.BunifuFlatButton();
            this.add = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dateofbirth = new Guna.UI.WinForms.GunaDateTimePicker();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.gender = new System.Windows.Forms.ComboBox();
            this.phone = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.stdid = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.stdname = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.studenttablebox = new Guna.UI2.WinForms.Guna2DataGridView();
            this.searchbtn = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2ImageButton2 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2ImageButton3 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2ImageButton5 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studenttablebox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(576, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Student Detials";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(161)))), ((int)(((byte)(242)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 864);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1315, 28);
            this.panel2.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(161)))), ((int)(((byte)(242)))));
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(1118, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "V 1.0 ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(161)))), ((int)(((byte)(242)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1315, 119);
            this.panel1.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.stddepartment);
            this.panel3.Controls.Add(this.edit);
            this.panel3.Controls.Add(this.home);
            this.panel3.Controls.Add(this.delete);
            this.panel3.Controls.Add(this.add);
            this.panel3.Controls.Add(this.dateofbirth);
            this.panel3.Controls.Add(this.bunifuCustomLabel2);
            this.panel3.Controls.Add(this.gender);
            this.panel3.Controls.Add(this.phone);
            this.panel3.Controls.Add(this.stdid);
            this.panel3.Controls.Add(this.stdname);
            this.panel3.Controls.Add(this.bunifuCustomLabel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 119);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(327, 745);
            this.panel3.TabIndex = 9;
            // 
            // stddepartment
            // 
            this.stddepartment.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.stddepartment.FormattingEnabled = true;
            this.stddepartment.Location = new System.Drawing.Point(45, 278);
            this.stddepartment.Name = "stddepartment";
            this.stddepartment.Size = new System.Drawing.Size(253, 25);
            this.stddepartment.TabIndex = 23;
            this.stddepartment.Text = "Select Department";
            // 
            // edit
            // 
            this.edit.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(161)))), ((int)(((byte)(242)))));
            this.edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(182)))), ((int)(((byte)(245)))));
            this.edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.edit.BorderRadius = 0;
            this.edit.ButtonText = "Edit Student";
            this.edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.edit.DisabledColor = System.Drawing.Color.Gray;
            this.edit.Iconcolor = System.Drawing.Color.Transparent;
            this.edit.Iconimage = null;
            this.edit.Iconimage_right = null;
            this.edit.Iconimage_right_Selected = null;
            this.edit.Iconimage_Selected = null;
            this.edit.IconMarginLeft = 0;
            this.edit.IconMarginRight = 0;
            this.edit.IconRightVisible = true;
            this.edit.IconRightZoom = 0D;
            this.edit.IconVisible = true;
            this.edit.IconZoom = 90D;
            this.edit.IsTab = false;
            this.edit.Location = new System.Drawing.Point(45, 530);
            this.edit.Name = "edit";
            this.edit.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(182)))), ((int)(((byte)(245)))));
            this.edit.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(142)))), ((int)(((byte)(221)))));
            this.edit.OnHoverTextColor = System.Drawing.Color.White;
            this.edit.selected = false;
            this.edit.Size = new System.Drawing.Size(253, 37);
            this.edit.TabIndex = 21;
            this.edit.Text = "Edit Student";
            this.edit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.edit.Textcolor = System.Drawing.Color.White;
            this.edit.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // home
            // 
            this.home.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(161)))), ((int)(((byte)(242)))));
            this.home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(182)))), ((int)(((byte)(245)))));
            this.home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.home.BorderRadius = 0;
            this.home.ButtonText = "Home";
            this.home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.home.DisabledColor = System.Drawing.Color.Gray;
            this.home.Iconcolor = System.Drawing.Color.Transparent;
            this.home.Iconimage = null;
            this.home.Iconimage_right = null;
            this.home.Iconimage_right_Selected = null;
            this.home.Iconimage_Selected = null;
            this.home.IconMarginLeft = 0;
            this.home.IconMarginRight = 0;
            this.home.IconRightVisible = true;
            this.home.IconRightZoom = 0D;
            this.home.IconVisible = true;
            this.home.IconZoom = 90D;
            this.home.IsTab = false;
            this.home.Location = new System.Drawing.Point(45, 675);
            this.home.Name = "home";
            this.home.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(182)))), ((int)(((byte)(245)))));
            this.home.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(142)))), ((int)(((byte)(221)))));
            this.home.OnHoverTextColor = System.Drawing.Color.White;
            this.home.selected = false;
            this.home.Size = new System.Drawing.Size(253, 37);
            this.home.TabIndex = 20;
            this.home.Text = "Home";
            this.home.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.home.Textcolor = System.Drawing.Color.White;
            this.home.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home.Click += new System.EventHandler(this.home_Click);
            // 
            // delete
            // 
            this.delete.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(161)))), ((int)(((byte)(242)))));
            this.delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(182)))), ((int)(((byte)(245)))));
            this.delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.delete.BorderRadius = 0;
            this.delete.ButtonText = "Delete";
            this.delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete.DisabledColor = System.Drawing.Color.Gray;
            this.delete.Iconcolor = System.Drawing.Color.Transparent;
            this.delete.Iconimage = null;
            this.delete.Iconimage_right = null;
            this.delete.Iconimage_right_Selected = null;
            this.delete.Iconimage_Selected = null;
            this.delete.IconMarginLeft = 0;
            this.delete.IconMarginRight = 0;
            this.delete.IconRightVisible = true;
            this.delete.IconRightZoom = 0D;
            this.delete.IconVisible = true;
            this.delete.IconZoom = 90D;
            this.delete.IsTab = false;
            this.delete.Location = new System.Drawing.Point(45, 586);
            this.delete.Name = "delete";
            this.delete.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(182)))), ((int)(((byte)(245)))));
            this.delete.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(142)))), ((int)(((byte)(221)))));
            this.delete.OnHoverTextColor = System.Drawing.Color.White;
            this.delete.selected = false;
            this.delete.Size = new System.Drawing.Size(253, 37);
            this.delete.TabIndex = 19;
            this.delete.Text = "Delete";
            this.delete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.delete.Textcolor = System.Drawing.Color.White;
            this.delete.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // add
            // 
            this.add.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(161)))), ((int)(((byte)(242)))));
            this.add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(182)))), ((int)(((byte)(245)))));
            this.add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.add.BorderRadius = 0;
            this.add.ButtonText = "Add The Student";
            this.add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add.DisabledColor = System.Drawing.Color.Gray;
            this.add.Iconcolor = System.Drawing.Color.Transparent;
            this.add.Iconimage = null;
            this.add.Iconimage_right = null;
            this.add.Iconimage_right_Selected = null;
            this.add.Iconimage_Selected = null;
            this.add.IconMarginLeft = 0;
            this.add.IconMarginRight = 0;
            this.add.IconRightVisible = true;
            this.add.IconRightZoom = 0D;
            this.add.IconVisible = true;
            this.add.IconZoom = 90D;
            this.add.IsTab = false;
            this.add.Location = new System.Drawing.Point(45, 478);
            this.add.Name = "add";
            this.add.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(182)))), ((int)(((byte)(245)))));
            this.add.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(142)))), ((int)(((byte)(221)))));
            this.add.OnHoverTextColor = System.Drawing.Color.White;
            this.add.selected = false;
            this.add.Size = new System.Drawing.Size(253, 37);
            this.add.TabIndex = 11;
            this.add.Text = "Add The Student";
            this.add.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.add.Textcolor = System.Drawing.Color.White;
            this.add.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // dateofbirth
            // 
            this.dateofbirth.BaseColor = System.Drawing.Color.White;
            this.dateofbirth.BorderColor = System.Drawing.Color.Silver;
            this.dateofbirth.CustomFormat = null;
            this.dateofbirth.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dateofbirth.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(161)))), ((int)(((byte)(242)))));
            this.dateofbirth.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dateofbirth.ForeColor = System.Drawing.Color.Black;
            this.dateofbirth.Location = new System.Drawing.Point(45, 370);
            this.dateofbirth.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateofbirth.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateofbirth.Name = "dateofbirth";
            this.dateofbirth.OnHoverBaseColor = System.Drawing.Color.White;
            this.dateofbirth.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(161)))), ((int)(((byte)(242)))));
            this.dateofbirth.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(161)))), ((int)(((byte)(242)))));
            this.dateofbirth.OnPressedColor = System.Drawing.Color.Black;
            this.dateofbirth.Size = new System.Drawing.Size(253, 30);
            this.dateofbirth.TabIndex = 16;
            this.dateofbirth.Text = "Sunday, March 21, 2021";
            this.dateofbirth.Value = new System.DateTime(2021, 3, 21, 14, 18, 50, 316);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(42, 336);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(95, 16);
            this.bunifuCustomLabel2.TabIndex = 15;
            this.bunifuCustomLabel2.Text = "Date Of Birth";
            this.bunifuCustomLabel2.Click += new System.EventHandler(this.bunifuCustomLabel2_Click);
            // 
            // gender
            // 
            this.gender.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.gender.FormattingEnabled = true;
            this.gender.Items.AddRange(new object[] {
            "Male ",
            "Female",
            "Other"});
            this.gender.Location = new System.Drawing.Point(45, 424);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(253, 25);
            this.gender.TabIndex = 13;
            this.gender.Text = "Select Gender";
            this.gender.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // phone
            // 
            this.phone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.phone.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.phone.ForeColor = System.Drawing.Color.Black;
            this.phone.HintForeColor = System.Drawing.Color.Black;
            this.phone.HintText = "Phone Number";
            this.phone.isPassword = false;
            this.phone.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(142)))), ((int)(((byte)(221)))));
            this.phone.LineIdleColor = System.Drawing.Color.White;
            this.phone.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(142)))), ((int)(((byte)(221)))));
            this.phone.LineThickness = 2;
            this.phone.Location = new System.Drawing.Point(45, 211);
            this.phone.Margin = new System.Windows.Forms.Padding(4);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(253, 39);
            this.phone.TabIndex = 12;
            this.phone.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // stdid
            // 
            this.stdid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.stdid.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.stdid.ForeColor = System.Drawing.Color.Black;
            this.stdid.HintForeColor = System.Drawing.Color.Black;
            this.stdid.HintText = "Student ID";
            this.stdid.isPassword = false;
            this.stdid.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(142)))), ((int)(((byte)(221)))));
            this.stdid.LineIdleColor = System.Drawing.Color.White;
            this.stdid.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(142)))), ((int)(((byte)(221)))));
            this.stdid.LineThickness = 2;
            this.stdid.Location = new System.Drawing.Point(45, 89);
            this.stdid.Margin = new System.Windows.Forms.Padding(4);
            this.stdid.Name = "stdid";
            this.stdid.Size = new System.Drawing.Size(253, 39);
            this.stdid.TabIndex = 11;
            this.stdid.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // stdname
            // 
            this.stdname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.stdname.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.stdname.ForeColor = System.Drawing.Color.Black;
            this.stdname.HintForeColor = System.Drawing.Color.Black;
            this.stdname.HintText = "Student Name";
            this.stdname.isPassword = false;
            this.stdname.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(142)))), ((int)(((byte)(221)))));
            this.stdname.LineIdleColor = System.Drawing.Color.White;
            this.stdname.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(142)))), ((int)(((byte)(221)))));
            this.stdname.LineThickness = 2;
            this.stdname.Location = new System.Drawing.Point(45, 150);
            this.stdname.Margin = new System.Windows.Forms.Padding(4);
            this.stdname.Name = "stdname";
            this.stdname.Size = new System.Drawing.Size(253, 39);
            this.stdname.TabIndex = 10;
            this.stdname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(66, 30);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(196, 25);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "Add a New Student";
            // 
            // studenttablebox
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F);
            this.studenttablebox.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.studenttablebox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.studenttablebox.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.studenttablebox.BackgroundColor = System.Drawing.Color.White;
            this.studenttablebox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.studenttablebox.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.studenttablebox.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(161)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.studenttablebox.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.studenttablebox.ColumnHeadersHeight = 50;
            this.studenttablebox.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(161)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.studenttablebox.DefaultCellStyle = dataGridViewCellStyle3;
            this.studenttablebox.EnableHeadersVisualStyles = false;
            this.studenttablebox.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(161)))), ((int)(((byte)(242)))));
            this.studenttablebox.Location = new System.Drawing.Point(356, 208);
            this.studenttablebox.Margin = new System.Windows.Forms.Padding(0);
            this.studenttablebox.Name = "studenttablebox";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.studenttablebox.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.studenttablebox.RowHeadersVisible = false;
            this.studenttablebox.RowHeadersWidth = 1000;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F);
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.studenttablebox.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.studenttablebox.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F);
            this.studenttablebox.RowTemplate.Height = 43;
            this.studenttablebox.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.studenttablebox.Size = new System.Drawing.Size(926, 575);
            this.studenttablebox.StandardTab = true;
            this.studenttablebox.TabIndex = 23;
            this.studenttablebox.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.studenttablebox.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.studenttablebox.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F);
            this.studenttablebox.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.studenttablebox.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.studenttablebox.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.studenttablebox.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.studenttablebox.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(161)))), ((int)(((byte)(242)))));
            this.studenttablebox.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(161)))), ((int)(((byte)(242)))));
            this.studenttablebox.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.studenttablebox.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studenttablebox.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.studenttablebox.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.studenttablebox.ThemeStyle.HeaderStyle.Height = 50;
            this.studenttablebox.ThemeStyle.ReadOnly = false;
            this.studenttablebox.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.studenttablebox.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.studenttablebox.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F);
            this.studenttablebox.ThemeStyle.RowsStyle.ForeColor = System.Drawing.SystemColors.Desktop;
            this.studenttablebox.ThemeStyle.RowsStyle.Height = 43;
            this.studenttablebox.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.White;
            this.studenttablebox.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(161)))), ((int)(((byte)(242)))));
            this.studenttablebox.VirtualMode = true;
            // 
            // searchbtn
            // 
            this.searchbtn.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchbtn.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.searchbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(161)))), ((int)(((byte)(242)))));
            this.searchbtn.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(161)))), ((int)(((byte)(242)))));
            this.searchbtn.HintText = "Search Here";
            this.searchbtn.isPassword = false;
            this.searchbtn.LineFocusedColor = System.Drawing.Color.White;
            this.searchbtn.LineIdleColor = System.Drawing.Color.White;
            this.searchbtn.LineMouseHoverColor = System.Drawing.Color.White;
            this.searchbtn.LineThickness = 2;
            this.searchbtn.Location = new System.Drawing.Point(356, 149);
            this.searchbtn.Margin = new System.Windows.Forms.Padding(4);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(320, 37);
            this.searchbtn.TabIndex = 24;
            this.searchbtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.searchbtn.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox1_OnValueChanged);
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.CheckedState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(31, 31);
            this.guna2ImageButton1.HoverState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton1.Image")));
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2ImageButton1.Location = new System.Drawing.Point(683, 149);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(31, 31);
            this.guna2ImageButton1.PressedState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.Size = new System.Drawing.Size(38, 37);
            this.guna2ImageButton1.TabIndex = 25;
            this.guna2ImageButton1.Click += new System.EventHandler(this.guna2ImageButton1_Click);
            // 
            // guna2ImageButton2
            // 
            this.guna2ImageButton2.BackColor = System.Drawing.Color.Transparent;
            this.guna2ImageButton2.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton2.CheckedState.Parent = this.guna2ImageButton2;
            this.guna2ImageButton2.HoverState.ImageSize = new System.Drawing.Size(31, 31);
            this.guna2ImageButton2.HoverState.Parent = this.guna2ImageButton2;
            this.guna2ImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton2.Image")));
            this.guna2ImageButton2.ImageRotate = 0F;
            this.guna2ImageButton2.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2ImageButton2.Location = new System.Drawing.Point(1156, 149);
            this.guna2ImageButton2.Name = "guna2ImageButton2";
            this.guna2ImageButton2.PressedState.ImageSize = new System.Drawing.Size(31, 31);
            this.guna2ImageButton2.PressedState.Parent = this.guna2ImageButton2;
            this.guna2ImageButton2.Size = new System.Drawing.Size(38, 37);
            this.guna2ImageButton2.TabIndex = 26;
            this.guna2ImageButton2.Click += new System.EventHandler(this.guna2ImageButton2_Click);
            // 
            // guna2ImageButton3
            // 
            this.guna2ImageButton3.BackColor = System.Drawing.Color.Transparent;
            this.guna2ImageButton3.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton3.CheckedState.Parent = this.guna2ImageButton3;
            this.guna2ImageButton3.HoverState.ImageSize = new System.Drawing.Size(31, 31);
            this.guna2ImageButton3.HoverState.Parent = this.guna2ImageButton3;
            this.guna2ImageButton3.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton3.Image")));
            this.guna2ImageButton3.ImageRotate = 0F;
            this.guna2ImageButton3.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2ImageButton3.Location = new System.Drawing.Point(1200, 149);
            this.guna2ImageButton3.Name = "guna2ImageButton3";
            this.guna2ImageButton3.PressedState.ImageSize = new System.Drawing.Size(31, 31);
            this.guna2ImageButton3.PressedState.Parent = this.guna2ImageButton3;
            this.guna2ImageButton3.Size = new System.Drawing.Size(38, 37);
            this.guna2ImageButton3.TabIndex = 27;
            this.guna2ImageButton3.Click += new System.EventHandler(this.guna2ImageButton3_Click);
            // 
            // guna2ImageButton5
            // 
            this.guna2ImageButton5.BackColor = System.Drawing.Color.Transparent;
            this.guna2ImageButton5.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton5.CheckedState.Parent = this.guna2ImageButton5;
            this.guna2ImageButton5.HoverState.ImageSize = new System.Drawing.Size(31, 31);
            this.guna2ImageButton5.HoverState.Parent = this.guna2ImageButton5;
            this.guna2ImageButton5.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton5.Image")));
            this.guna2ImageButton5.ImageRotate = 0F;
            this.guna2ImageButton5.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2ImageButton5.Location = new System.Drawing.Point(1244, 149);
            this.guna2ImageButton5.Name = "guna2ImageButton5";
            this.guna2ImageButton5.PressedState.ImageSize = new System.Drawing.Size(31, 31);
            this.guna2ImageButton5.PressedState.Parent = this.guna2ImageButton5;
            this.guna2ImageButton5.Size = new System.Drawing.Size(38, 37);
            this.guna2ImageButton5.TabIndex = 29;
            this.guna2ImageButton5.Click += new System.EventHandler(this.guna2ImageButton5_Click);
            // 
            // students
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1315, 892);
            this.Controls.Add(this.guna2ImageButton5);
            this.Controls.Add(this.guna2ImageButton3);
            this.Controls.Add(this.guna2ImageButton2);
            this.Controls.Add(this.guna2ImageButton1);
            this.Controls.Add(this.searchbtn);
            this.Controls.Add(this.studenttablebox);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "students";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "students";
            this.Load += new System.EventHandler(this.students_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studenttablebox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox stdname;
        private Bunifu.Framework.UI.BunifuMaterialTextbox phone;
        private Bunifu.Framework.UI.BunifuMaterialTextbox stdid;
        private System.Windows.Forms.ComboBox gender;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Guna.UI.WinForms.GunaDateTimePicker dateofbirth;
        private Bunifu.Framework.UI.BunifuFlatButton edit;
        private Bunifu.Framework.UI.BunifuFlatButton home;
        private Bunifu.Framework.UI.BunifuFlatButton delete;
        private Bunifu.Framework.UI.BunifuFlatButton add;
        private Guna.UI2.WinForms.Guna2DataGridView studenttablebox;
        private System.Windows.Forms.ComboBox stddepartment;
        private Bunifu.Framework.UI.BunifuMaterialTextbox searchbtn;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton2;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton3;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton5;
    }
}