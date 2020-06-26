namespace ProjectEX
{
    partial class shops
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.Exitshops = new System.Windows.Forms.Label();
            this.Shopstr = new System.Windows.Forms.TextBox();
            this.backbutton = new System.Windows.Forms.Label();
            this.numbox = new System.Windows.Forms.TextBox();
            this.delnumber = new System.Windows.Forms.Label();
            this.delbutton = new System.Windows.Forms.Label();
            this.totalbutton = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // Exitshops
            // 
            this.Exitshops.AutoSize = true;
            this.Exitshops.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exitshops.Dock = System.Windows.Forms.DockStyle.Right;
            this.Exitshops.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Exitshops.Location = new System.Drawing.Point(764, 0);
            this.Exitshops.Name = "Exitshops";
            this.Exitshops.Size = new System.Drawing.Size(20, 21);
            this.Exitshops.TabIndex = 1;
            this.Exitshops.Text = "X";
            this.Exitshops.Click += new System.EventHandler(this.Exitshops_Click);
            // 
            // Shopstr
            // 
            this.Shopstr.Dock = System.Windows.Forms.DockStyle.Top;
            this.Shopstr.Location = new System.Drawing.Point(0, 0);
            this.Shopstr.Multiline = true;
            this.Shopstr.Name = "Shopstr";
            this.Shopstr.ReadOnly = true;
            this.Shopstr.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Shopstr.Size = new System.Drawing.Size(764, 273);
            this.Shopstr.TabIndex = 2;
            this.Shopstr.Text = "  ";
            this.Shopstr.TextChanged += new System.EventHandler(this.Shopstr_TextChanged);
            // 
            // backbutton
            // 
            this.backbutton.AutoSize = true;
            this.backbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backbutton.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.backbutton.Location = new System.Drawing.Point(764, 21);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(27, 29);
            this.backbutton.TabIndex = 3;
            this.backbutton.Text = "<";
            this.backbutton.Click += new System.EventHandler(this.backbutton_Click);
            // 
            // numbox
            // 
            this.numbox.Location = new System.Drawing.Point(230, 326);
            this.numbox.Name = "numbox";
            this.numbox.Size = new System.Drawing.Size(85, 23);
            this.numbox.TabIndex = 4;
            // 
            // delnumber
            // 
            this.delnumber.AutoSize = true;
            this.delnumber.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.delnumber.Location = new System.Drawing.Point(27, 324);
            this.delnumber.Name = "delnumber";
            this.delnumber.Size = new System.Drawing.Size(197, 21);
            this.delnumber.TabIndex = 5;
            this.delnumber.Text = "Введите номер покупки:";
            // 
            // delbutton
            // 
            this.delbutton.AutoSize = true;
            this.delbutton.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.delbutton.Location = new System.Drawing.Point(215, 368);
            this.delbutton.Name = "delbutton";
            this.delbutton.Size = new System.Drawing.Size(114, 17);
            this.delbutton.TabIndex = 6;
            this.delbutton.Text = "Удалить покупку";
            this.delbutton.Click += new System.EventHandler(this.delbutton_Click);
            // 
            // totalbutton
            // 
            this.totalbutton.AutoSize = true;
            this.totalbutton.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.totalbutton.Location = new System.Drawing.Point(445, 329);
            this.totalbutton.Name = "totalbutton";
            this.totalbutton.Size = new System.Drawing.Size(224, 20);
            this.totalbutton.TabIndex = 7;
            this.totalbutton.Text = "Общая стоимость покупок:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(668, 330);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(104, 23);
            this.textBox2.TabIndex = 8;
            // 
            // shops
            // 
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.totalbutton);
            this.Controls.Add(this.delbutton);
            this.Controls.Add(this.delnumber);
            this.Controls.Add(this.numbox);
            this.Controls.Add(this.backbutton);
            this.Controls.Add(this.Shopstr);
            this.Controls.Add(this.Exitshops);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "shops";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Exitshops;
        public System.Windows.Forms.TextBox Shopstr;
        private System.Windows.Forms.Label backbutton;
        private System.Windows.Forms.TextBox numbox;
        private System.Windows.Forms.Label delnumber;
        private System.Windows.Forms.Label delbutton;
        private System.Windows.Forms.Label totalbutton;
        private System.Windows.Forms.TextBox textBox2;
    }
}

