namespace Alcohol
{
    partial class AddForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TypeText = new System.Windows.Forms.TextBox();
            this.BrandText = new System.Windows.Forms.TextBox();
            this.ManText = new System.Windows.Forms.TextBox();
            this.ExpDateText = new System.Windows.Forms.TextBox();
            this.SupText = new System.Windows.Forms.TextBox();
            this.PriceText = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Brand";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Manufacturer";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Expiration Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Supplier";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = " Price";
            // 
            // TypeText
            // 
            this.TypeText.Location = new System.Drawing.Point(164, 91);
            this.TypeText.Name = "TypeText";
            this.TypeText.Size = new System.Drawing.Size(100, 20);
            this.TypeText.TabIndex = 6;
            // 
            // BrandText
            // 
            this.BrandText.Location = new System.Drawing.Point(164, 128);
            this.BrandText.Name = "BrandText";
            this.BrandText.Size = new System.Drawing.Size(100, 20);
            this.BrandText.TabIndex = 7;
            // 
            // ManText
            // 
            this.ManText.Location = new System.Drawing.Point(164, 163);
            this.ManText.Name = "ManText";
            this.ManText.Size = new System.Drawing.Size(100, 20);
            this.ManText.TabIndex = 8;
            // 
            // ExpDateText
            // 
            this.ExpDateText.Location = new System.Drawing.Point(164, 198);
            this.ExpDateText.Name = "ExpDateText";
            this.ExpDateText.Size = new System.Drawing.Size(100, 20);
            this.ExpDateText.TabIndex = 9;
            // 
            // SupText
            // 
            this.SupText.Location = new System.Drawing.Point(164, 235);
            this.SupText.Name = "SupText";
            this.SupText.Size = new System.Drawing.Size(100, 20);
            this.SupText.TabIndex = 10;
            // 
            // PriceText
            // 
            this.PriceText.Location = new System.Drawing.Point(164, 266);
            this.PriceText.Name = "PriceText";
            this.PriceText.Size = new System.Drawing.Size(100, 20);
            this.PriceText.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 475);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(164, 474);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 561);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PriceText);
            this.Controls.Add(this.SupText);
            this.Controls.Add(this.ExpDateText);
            this.Controls.Add(this.ManText);
            this.Controls.Add(this.BrandText);
            this.Controls.Add(this.TypeText);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddForm";
            this.Text = "AddForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TypeText;
        private System.Windows.Forms.TextBox BrandText;
        private System.Windows.Forms.TextBox ManText;
        private System.Windows.Forms.TextBox ExpDateText;
        private System.Windows.Forms.TextBox SupText;
        private System.Windows.Forms.TextBox PriceText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}