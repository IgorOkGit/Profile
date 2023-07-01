namespace AppForUni
{
    partial class Changing_indicators
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGasUsage = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtWaterUsage = new System.Windows.Forms.TextBox();
            this.txtElecUsage = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(558, 329);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 59);
            this.button1.TabIndex = 0;
            this.button1.Text = "Застосувати";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(136, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(362, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введіть показники лічильника газу";
            // 
            // txtGasUsage
            // 
            this.txtGasUsage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtGasUsage.Location = new System.Drawing.Point(136, 111);
            this.txtGasUsage.Multiline = true;
            this.txtGasUsage.Name = "txtGasUsage";
            this.txtGasUsage.Size = new System.Drawing.Size(125, 31);
            this.txtGasUsage.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(136, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(424, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Введіть показники лічильника електрики";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(136, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(367, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Введіть показники лічильника води";
            // 
            // txtWaterUsage
            // 
            this.txtWaterUsage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtWaterUsage.Location = new System.Drawing.Point(136, 271);
            this.txtWaterUsage.Multiline = true;
            this.txtWaterUsage.Name = "txtWaterUsage";
            this.txtWaterUsage.Size = new System.Drawing.Size(125, 31);
            this.txtWaterUsage.TabIndex = 5;
            // 
            // txtElecUsage
            // 
            this.txtElecUsage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtElecUsage.Location = new System.Drawing.Point(136, 191);
            this.txtElecUsage.Multiline = true;
            this.txtElecUsage.Name = "txtElecUsage";
            this.txtElecUsage.Size = new System.Drawing.Size(125, 31);
            this.txtElecUsage.TabIndex = 6;
            // 
            // Changing_indicators
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AppForUni.Properties.Resources._1669367068_2_1_1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtElecUsage);
            this.Controls.Add(this.txtWaterUsage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtGasUsage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Changing_indicators";
            this.Text = "Changing_indicators";
            this.Load += new System.EventHandler(this.Changing_indicators_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGasUsage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtWaterUsage;
        private System.Windows.Forms.TextBox txtElecUsage;
    }
}