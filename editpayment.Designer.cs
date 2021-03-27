
namespace CollageManagementSystem
{
    partial class editpayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(editpayment));
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.feenum = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.stdid = new System.Windows.Forms.ComboBox();
            this.stdname = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.period = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Amount = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.add = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SuspendLayout();
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.CheckedState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(320, 500);
            this.guna2ImageButton1.HoverState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton1.Image")));
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.ImageSize = new System.Drawing.Size(320, 500);
            this.guna2ImageButton1.Location = new System.Drawing.Point(-12, -2);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(320, 500);
            this.guna2ImageButton1.PressedState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.Size = new System.Drawing.Size(332, 449);
            this.guna2ImageButton1.TabIndex = 41;
            this.guna2ImageButton1.Click += new System.EventHandler(this.guna2ImageButton1_Click);
            // 
            // feenum
            // 
            this.feenum.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.feenum.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.feenum.ForeColor = System.Drawing.Color.Black;
            this.feenum.HintForeColor = System.Drawing.Color.Black;
            this.feenum.HintText = "Fee Number";
            this.feenum.isPassword = false;
            this.feenum.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(142)))), ((int)(((byte)(221)))));
            this.feenum.LineIdleColor = System.Drawing.Color.White;
            this.feenum.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(142)))), ((int)(((byte)(221)))));
            this.feenum.LineThickness = 2;
            this.feenum.Location = new System.Drawing.Point(409, 77);
            this.feenum.Margin = new System.Windows.Forms.Padding(4);
            this.feenum.Name = "feenum";
            this.feenum.Size = new System.Drawing.Size(253, 39);
            this.feenum.TabIndex = 34;
            this.feenum.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // stdid
            // 
            this.stdid.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.stdid.FormattingEnabled = true;
            this.stdid.Location = new System.Drawing.Point(409, 137);
            this.stdid.Name = "stdid";
            this.stdid.Size = new System.Drawing.Size(253, 25);
            this.stdid.TabIndex = 35;
            this.stdid.Text = "Select Student ID ";
            this.stdid.SelectionChangeCommitted += new System.EventHandler(this.stdid_SelectionChangeCommitted);
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
            this.stdname.Location = new System.Drawing.Point(409, 183);
            this.stdname.Margin = new System.Windows.Forms.Padding(4);
            this.stdname.Name = "stdname";
            this.stdname.Size = new System.Drawing.Size(253, 39);
            this.stdname.TabIndex = 36;
            this.stdname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // period
            // 
            this.period.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.period.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.period.ForeColor = System.Drawing.Color.Black;
            this.period.HintForeColor = System.Drawing.Color.Black;
            this.period.HintText = "Period";
            this.period.isPassword = false;
            this.period.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(142)))), ((int)(((byte)(221)))));
            this.period.LineIdleColor = System.Drawing.Color.White;
            this.period.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(142)))), ((int)(((byte)(221)))));
            this.period.LineThickness = 2;
            this.period.Location = new System.Drawing.Point(409, 240);
            this.period.Margin = new System.Windows.Forms.Padding(4);
            this.period.Name = "period";
            this.period.Size = new System.Drawing.Size(253, 39);
            this.period.TabIndex = 37;
            this.period.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Amount
            // 
            this.Amount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Amount.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Amount.ForeColor = System.Drawing.Color.Black;
            this.Amount.HintForeColor = System.Drawing.Color.Black;
            this.Amount.HintText = "Amount";
            this.Amount.isPassword = false;
            this.Amount.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(142)))), ((int)(((byte)(221)))));
            this.Amount.LineIdleColor = System.Drawing.Color.White;
            this.Amount.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(142)))), ((int)(((byte)(221)))));
            this.Amount.LineThickness = 2;
            this.Amount.Location = new System.Drawing.Point(409, 296);
            this.Amount.Margin = new System.Windows.Forms.Padding(4);
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(253, 39);
            this.Amount.TabIndex = 38;
            this.Amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(404, 25);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(127, 25);
            this.bunifuCustomLabel1.TabIndex = 39;
            this.bunifuCustomLabel1.Text = "Edit Details ";
            // 
            // add
            // 
            this.add.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(161)))), ((int)(((byte)(242)))));
            this.add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(182)))), ((int)(((byte)(245)))));
            this.add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.add.BorderRadius = 0;
            this.add.ButtonText = "Edit Details";
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
            this.add.Location = new System.Drawing.Point(409, 371);
            this.add.Name = "add";
            this.add.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(182)))), ((int)(((byte)(245)))));
            this.add.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(142)))), ((int)(((byte)(221)))));
            this.add.OnHoverTextColor = System.Drawing.Color.White;
            this.add.selected = false;
            this.add.Size = new System.Drawing.Size(253, 37);
            this.add.TabIndex = 40;
            this.add.Text = "Edit Details";
            this.add.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.add.Textcolor = System.Drawing.Color.White;
            this.add.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // editpayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(756, 438);
            this.Controls.Add(this.guna2ImageButton1);
            this.Controls.Add(this.add);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.Amount);
            this.Controls.Add(this.period);
            this.Controls.Add(this.stdname);
            this.Controls.Add(this.stdid);
            this.Controls.Add(this.feenum);
            this.MaximizeBox = false;
            this.Name = "editpayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "editpayment";
            this.Load += new System.EventHandler(this.editpayment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox feenum;
        private System.Windows.Forms.ComboBox stdid;
        private Bunifu.Framework.UI.BunifuMaterialTextbox stdname;
        private Bunifu.Framework.UI.BunifuMaterialTextbox period;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Amount;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuFlatButton add;
    }
}