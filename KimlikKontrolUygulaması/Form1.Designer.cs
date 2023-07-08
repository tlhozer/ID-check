
namespace KimlikKontrolUygulaması
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
            this.label1 = new System.Windows.Forms.Label();
            this.adtxt = new System.Windows.Forms.TextBox();
            this.dgtxt = new System.Windows.Forms.DateTimePicker();
            this.kontrolbtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.soyadtxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tctxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad";
            // 
            // adtxt
            // 
            this.adtxt.Location = new System.Drawing.Point(121, 75);
            this.adtxt.Name = "adtxt";
            this.adtxt.Size = new System.Drawing.Size(200, 22);
            this.adtxt.TabIndex = 1;
            // 
            // dgtxt
            // 
            this.dgtxt.Location = new System.Drawing.Point(121, 155);
            this.dgtxt.Name = "dgtxt";
            this.dgtxt.Size = new System.Drawing.Size(200, 22);
            this.dgtxt.TabIndex = 2;
            // 
            // kontrolbtn
            // 
            this.kontrolbtn.BackColor = System.Drawing.Color.Tomato;
            this.kontrolbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kontrolbtn.ForeColor = System.Drawing.Color.White;
            this.kontrolbtn.Location = new System.Drawing.Point(28, 201);
            this.kontrolbtn.Name = "kontrolbtn";
            this.kontrolbtn.Size = new System.Drawing.Size(306, 51);
            this.kontrolbtn.TabIndex = 3;
            this.kontrolbtn.Text = "Kimlik Kontrolü Yap";
            this.kontrolbtn.UseVisualStyleBackColor = false;
            this.kontrolbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Soyad";
            // 
            // soyadtxt
            // 
            this.soyadtxt.Location = new System.Drawing.Point(121, 101);
            this.soyadtxt.Name = "soyadtxt";
            this.soyadtxt.Size = new System.Drawing.Size(200, 22);
            this.soyadtxt.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(13, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "TCKN";
            // 
            // tctxt
            // 
            this.tctxt.Location = new System.Drawing.Point(121, 127);
            this.tctxt.Name = "tctxt";
            this.tctxt.Size = new System.Drawing.Size(200, 22);
            this.tctxt.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(12, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Doğum Yılı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 32);
            this.label5.TabIndex = 4;
            this.label5.Text = "Hello ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(351, 275);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.kontrolbtn);
            this.Controls.Add(this.dgtxt);
            this.Controls.Add(this.tctxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.soyadtxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.adtxt);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Kimlik Doğrulama Uygulaması";
            this.TransparencyKey = System.Drawing.Color.SlateGray;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox adtxt;
        private System.Windows.Forms.DateTimePicker dgtxt;
        private System.Windows.Forms.Button kontrolbtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox soyadtxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tctxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

