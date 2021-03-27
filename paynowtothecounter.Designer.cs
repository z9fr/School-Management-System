
namespace CollageManagementSystem
{
    partial class paynowtothecounter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(paynowtothecounter));
            this.feenum = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.stdid = new System.Windows.Forms.ComboBox();
            this.stdname = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.period = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Amount = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.add = new Bunifu.Framework.UI.BunifuFlatButton();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.SuspendLayout();
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
            this.feenum.Location = new System.Drawing.Point(427, 85);
            this.feenum.Margin = new System.Windows.Forms.Padding(4);
            this.feenum.Name = "feenum";
            this.feenum.Size = new System.Drawing.Size(253, 39);
            this.feenum.TabIndex = 12;
            this.feenum.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // stdid
            // 
            this.stdid.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.stdid.FormattingEnabled = true;
            this.stdid.Location = new System.Drawing.Point(427, 145);
            this.stdid.Name = "stdid";
            this.stdid.Size = new System.Drawing.Size(253, 25);
            this.stdid.TabIndex = 27;
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
            this.stdname.Location = new System.Drawing.Point(427, 191);
            this.stdname.Margin = new System.Windows.Forms.Padding(4);
            this.stdname.Name = "stdname";
            this.stdname.Size = new System.Drawing.Size(253, 39);
            this.stdname.TabIndex = 28;
            this.stdname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.stdname.OnValueChanged += new System.EventHandler(this.stdname_OnValueChanged);
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
            this.period.Location = new System.Drawing.Point(427, 248);
            this.period.Margin = new System.Windows.Forms.Padding(4);
            this.period.Name = "period";
            this.period.Size = new System.Drawing.Size(253, 39);
            this.period.TabIndex = 29;
            this.period.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.period.OnValueChanged += new System.EventHandler(this.period_OnValueChanged);
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
            this.Amount.Location = new System.Drawing.Point(427, 304);
            this.Amount.Margin = new System.Windows.Forms.Padding(4);
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(253, 39);
            this.Amount.TabIndex = 30;
            this.Amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Amount.OnValueChanged += new System.EventHandler(this.Amount_OnValueChanged);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(422, 27);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(144, 25);
            this.bunifuCustomLabel1.TabIndex = 32;
            this.bunifuCustomLabel1.Text = "New Payment";
            this.bunifuCustomLabel1.Click += new System.EventHandler(this.bunifuCustomLabel1_Click);
            // 
            // add
            // 
            this.add.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(161)))), ((int)(((byte)(242)))));
            this.add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(182)))), ((int)(((byte)(245)))));
            this.add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.add.BorderRadius = 0;
            this.add.ButtonText = "Pay Now";
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
            this.add.Location = new System.Drawing.Point(427, 378);
            this.add.Name = "add";
            this.add.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(182)))), ((int)(((byte)(245)))));
            this.add.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(142)))), ((int)(((byte)(221)))));
            this.add.OnHoverTextColor = System.Drawing.Color.White;
            this.add.selected = false;
            this.add.Size = new System.Drawing.Size(253, 37);
            this.add.TabIndex = 33;
            this.add.Text = "Pay Now";
            this.add.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.add.Textcolor = System.Drawing.Color.White;
            this.add.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.Click += new System.EventHandler(this.add_Click);
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
            this.guna2ImageButton1.Location = new System.Drawing.Point(-6, -2);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(320, 500);
            this.guna2ImageButton1.PressedState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.Size = new System.Drawing.Size(318, 460);
            this.guna2ImageButton1.TabIndex = 31;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            this.printPreviewDialog1.Load += new System.EventHandler(this.printPreviewDialog1_Load);
            // 
            // paynowtothecounter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(768, 453);
            this.Controls.Add(this.add);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.guna2ImageButton1);
            this.Controls.Add(this.Amount);
            this.Controls.Add(this.period);
            this.Controls.Add(this.stdname);
            this.Controls.Add(this.stdid);
            this.Controls.Add(this.feenum);
            this.MaximizeBox = false;
            this.Name = "paynowtothecounter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PayNow";
            this.Load += new System.EventHandler(this.paynowtothecounter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuMaterialTextbox feenum;
        private System.Windows.Forms.ComboBox stdid;
        private Bunifu.Framework.UI.BunifuMaterialTextbox stdname;
        private Bunifu.Framework.UI.BunifuMaterialTextbox period;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Amount;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuFlatButton add;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}