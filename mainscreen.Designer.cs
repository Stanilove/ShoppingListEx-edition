namespace ProjectEX
{
    partial class Mainscreen
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
            this.namestr = new System.Windows.Forms.TextBox();
            this.coststr = new System.Windows.Forms.TextBox();
            this.commentstr = new System.Windows.Forms.TextBox();
            this.buybutton = new System.Windows.Forms.Label();
            this.shopbutton = new System.Windows.Forms.Label();
            this.datestr = new System.Windows.Forms.TextBox();
            this.Exitbutton = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // namestr
            // 
            this.namestr.Location = new System.Drawing.Point(281, 42);
            this.namestr.Name = "namestr";
            this.namestr.PlaceholderText = "Наименование";
            this.namestr.Size = new System.Drawing.Size(212, 23);
            this.namestr.TabIndex = 0;
            // 
            // coststr
            // 
            this.coststr.Location = new System.Drawing.Point(281, 128);
            this.coststr.Name = "coststr";
            this.coststr.PlaceholderText = "Цена";
            this.coststr.Size = new System.Drawing.Size(212, 23);
            this.coststr.TabIndex = 2;
            // 
            // commentstr
            // 
            this.commentstr.Location = new System.Drawing.Point(281, 264);
            this.commentstr.Multiline = true;
            this.commentstr.Name = "commentstr";
            this.commentstr.PlaceholderText = "Комментарий";
            this.commentstr.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.commentstr.Size = new System.Drawing.Size(287, 87);
            this.commentstr.TabIndex = 3;
            // 
            // buybutton
            // 
            this.buybutton.AutoSize = true;
            this.buybutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buybutton.Location = new System.Drawing.Point(351, 403);
            this.buybutton.Name = "buybutton";
            this.buybutton.Size = new System.Drawing.Size(107, 15);
            this.buybutton.TabIndex = 4;
            this.buybutton.Text = "Добавить покупку";
            this.buybutton.Click += new System.EventHandler(this.Buybutton_Click);
            // 
            // shopbutton
            // 
            this.shopbutton.AutoSize = true;
            this.shopbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.shopbutton.Location = new System.Drawing.Point(630, 99);
            this.shopbutton.Name = "shopbutton";
            this.shopbutton.Size = new System.Drawing.Size(81, 15);
            this.shopbutton.TabIndex = 4;
            this.shopbutton.Text = "Мои покупки";
            this.shopbutton.Click += new System.EventHandler(this.Shopbutton_Click);
            // 
            // datestr
            // 
            this.datestr.Location = new System.Drawing.Point(281, 203);
            this.datestr.Name = "datestr";
            this.datestr.PlaceholderText = "Дата покупки";
            this.datestr.Size = new System.Drawing.Size(212, 23);
            this.datestr.TabIndex = 5;
            // 
            // Exitbutton
            // 
            this.Exitbutton.AutoSize = true;
            this.Exitbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exitbutton.Dock = System.Windows.Forms.DockStyle.Right;
            this.Exitbutton.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Exitbutton.Location = new System.Drawing.Point(766, 0);
            this.Exitbutton.Name = "Exitbutton";
            this.Exitbutton.Size = new System.Drawing.Size(18, 20);
            this.Exitbutton.TabIndex = 6;
            this.Exitbutton.Text = "X";
            this.Exitbutton.Click += new System.EventHandler(this.Exitbutton_Click);
            // 
            // Mainscreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.ControlBox = false;
            this.Controls.Add(this.Exitbutton);
            this.Controls.Add(this.datestr);
            this.Controls.Add(this.shopbutton);
            this.Controls.Add(this.buybutton);
            this.Controls.Add(this.commentstr);
            this.Controls.Add(this.coststr);
            this.Controls.Add(this.namestr);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Mainscreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shopping List";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox namestr;
        private System.Windows.Forms.TextBox coststr;
        private System.Windows.Forms.TextBox commentstr;
        private System.Windows.Forms.Label buybutton;
        private System.Windows.Forms.Label shopbutton;
        private System.Windows.Forms.TextBox datestr;
        private System.Windows.Forms.Label Exitbutton;
    }
}

