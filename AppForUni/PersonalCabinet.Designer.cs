namespace AppForUni
{
    partial class PersonalCabinet
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
            this.pictureBoxim = new System.Windows.Forms.PictureBox();
            this.usegas = new System.Windows.Forms.Label();
            this.useelec = new System.Windows.Forms.Label();
            this.usewater = new System.Windows.Forms.Label();
            this.nametag = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.gascost = new System.Windows.Forms.Label();
            this.watercost = new System.Windows.Forms.Label();
            this.eleccost = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.changeimg = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.date = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxim)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxim
            // 
            this.pictureBoxim.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxim.Image = global::AppForUni.Properties.Resources._1669367068_2_1_1_;
            this.pictureBoxim.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxim.Name = "pictureBoxim";
            this.pictureBoxim.Size = new System.Drawing.Size(198, 195);
            this.pictureBoxim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxim.TabIndex = 0;
            this.pictureBoxim.TabStop = false;
            // 
            // usegas
            // 
            this.usegas.AutoSize = true;
            this.usegas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usegas.Location = new System.Drawing.Point(35, 101);
            this.usegas.Name = "usegas";
            this.usegas.Size = new System.Drawing.Size(47, 25);
            this.usegas.TabIndex = 1;
            this.usegas.Text = "Газ";
            // 
            // useelec
            // 
            this.useelec.AutoSize = true;
            this.useelec.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.useelec.Location = new System.Drawing.Point(35, 133);
            this.useelec.Name = "useelec";
            this.useelec.Size = new System.Drawing.Size(118, 25);
            this.useelec.TabIndex = 2;
            this.useelec.Text = "Електрика";
            this.useelec.Click += new System.EventHandler(this.useelec_Click);
            // 
            // usewater
            // 
            this.usewater.AutoSize = true;
            this.usewater.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usewater.Location = new System.Drawing.Point(35, 166);
            this.usewater.Name = "usewater";
            this.usewater.Size = new System.Drawing.Size(62, 25);
            this.usewater.TabIndex = 3;
            this.usewater.Text = "Вода";
            // 
            // nametag
            // 
            this.nametag.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nametag.AutoSize = true;
            this.nametag.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nametag.Location = new System.Drawing.Point(64, 198);
            this.nametag.Name = "nametag";
            this.nametag.Size = new System.Drawing.Size(47, 25);
            this.nametag.TabIndex = 4;
            this.nametag.Text = "Ім\'я";
            this.nametag.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.pictureBoxim);
            this.panel1.Controls.Add(this.nametag);
            this.panel1.Location = new System.Drawing.Point(532, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(198, 223);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(35, 269);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "До сплати";
            // 
            // gascost
            // 
            this.gascost.AutoSize = true;
            this.gascost.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gascost.Location = new System.Drawing.Point(35, 309);
            this.gascost.Name = "gascost";
            this.gascost.Size = new System.Drawing.Size(152, 25);
            this.gascost.TabIndex = 7;
            this.gascost.Text = "Оплата за газ";
            // 
            // watercost
            // 
            this.watercost.AutoSize = true;
            this.watercost.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.watercost.Location = new System.Drawing.Point(35, 365);
            this.watercost.Name = "watercost";
            this.watercost.Size = new System.Drawing.Size(167, 25);
            this.watercost.TabIndex = 8;
            this.watercost.Text = "Оплата за воду";
            // 
            // eleccost
            // 
            this.eleccost.AutoSize = true;
            this.eleccost.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eleccost.Location = new System.Drawing.Point(35, 337);
            this.eleccost.Name = "eleccost";
            this.eleccost.Size = new System.Drawing.Size(224, 25);
            this.eleccost.TabIndex = 9;
            this.eleccost.Text = "Оплата за електрику";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(539, 347);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 48);
            this.button1.TabIndex = 10;
            this.button1.Text = "Внести нові показники";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // changeimg
            // 
            this.changeimg.Location = new System.Drawing.Point(532, 290);
            this.changeimg.Name = "changeimg";
            this.changeimg.Size = new System.Drawing.Size(198, 23);
            this.changeimg.TabIndex = 11;
            this.changeimg.Text = "Змінити картинку";
            this.changeimg.UseVisualStyleBackColor = true;
            this.changeimg.Click += new System.EventHandler(this.changeimg_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(7, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(157, 32);
            this.button2.TabIndex = 12;
            this.button2.Text = "Змінити користувача";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.date.Location = new System.Drawing.Point(488, 9);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(39, 16);
            this.date.TabIndex = 13;
            this.date.Text = "Дата";
            // 
            // PersonalCabinet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AppForUni.Properties.Resources._1669367068_2_1_1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.date);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.changeimg);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.eleccost);
            this.Controls.Add(this.watercost);
            this.Controls.Add(this.gascost);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.usewater);
            this.Controls.Add(this.useelec);
            this.Controls.Add(this.usegas);
            this.Name = "PersonalCabinet";
            this.Text = "PersonalCabinet";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PersonalCabinet_FormClosing);
            this.Load += new System.EventHandler(this.PersonalCabinet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxim)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxim;
        private System.Windows.Forms.Label usegas;
        private System.Windows.Forms.Label useelec;
        private System.Windows.Forms.Label usewater;
        private System.Windows.Forms.Label nametag;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label gascost;
        private System.Windows.Forms.Label watercost;
        private System.Windows.Forms.Label eleccost;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button changeimg;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label date;
    }
}