
namespace CollageManagementSystem
{
    partial class DeleteStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteStudent));
            this.stdid = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.stdname = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.delete = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.SuspendLayout();
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
            this.stdid.Location = new System.Drawing.Point(293, 73);
            this.stdid.Margin = new System.Windows.Forms.Padding(4);
            this.stdid.Name = "stdid";
            this.stdid.Size = new System.Drawing.Size(253, 39);
            this.stdid.TabIndex = 12;
            this.stdid.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.stdid.OnValueChanged += new System.EventHandler(this.stdid_OnValueChanged);
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
            this.stdname.Location = new System.Drawing.Point(293, 143);
            this.stdname.Margin = new System.Windows.Forms.Padding(4);
            this.stdname.Name = "stdname";
            this.stdname.Size = new System.Drawing.Size(253, 39);
            this.stdname.TabIndex = 13;
            this.stdname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.stdname.OnValueChanged += new System.EventHandler(this.stdname_OnValueChanged);
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.CheckedState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(200, 300);
            this.guna2ImageButton1.HoverState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton1.Image")));
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.ImageSize = new System.Drawing.Size(200, 300);
            this.guna2ImageButton1.Location = new System.Drawing.Point(-5, -32);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(200, 300);
            this.guna2ImageButton1.PressedState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.Size = new System.Drawing.Size(279, 352);
            this.guna2ImageButton1.TabIndex = 14;
            this.guna2ImageButton1.Click += new System.EventHandler(this.guna2ImageButton1_Click);
            // 
            // delete
            // 
            this.delete.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(161)))), ((int)(((byte)(242)))));
            this.delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(182)))), ((int)(((byte)(245)))));
            this.delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.delete.BorderRadius = 0;
            this.delete.ButtonText = "Remove Student";
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
            this.delete.Location = new System.Drawing.Point(293, 214);
            this.delete.Name = "delete";
            this.delete.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(182)))), ((int)(((byte)(245)))));
            this.delete.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(142)))), ((int)(((byte)(221)))));
            this.delete.OnHoverTextColor = System.Drawing.Color.White;
            this.delete.selected = false;
            this.delete.Size = new System.Drawing.Size(253, 37);
            this.delete.TabIndex = 20;
            this.delete.Text = "Remove Student";
            this.delete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.delete.Textcolor = System.Drawing.Color.White;
            this.delete.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(288, 27);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(172, 25);
            this.bunifuCustomLabel1.TabIndex = 21;
            this.bunifuCustomLabel1.Text = "Delete a Student";
            // 
            // DeleteStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(594, 287);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.guna2ImageButton1);
            this.Controls.Add(this.stdname);
            this.Controls.Add(this.stdid);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DeleteStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "deletestudent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMaterialTextbox stdid;
        private Bunifu.Framework.UI.BunifuMaterialTextbox stdname;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private Bunifu.Framework.UI.BunifuFlatButton delete;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
    }
}