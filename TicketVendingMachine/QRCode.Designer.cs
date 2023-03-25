
namespace TicketVendingMachine
{
    partial class QRCode
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QRCode));
            this.txtStartpoint = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBoxQRCode = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelTotal = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnFinish = new System.Windows.Forms.Button();
            this.groupBoxQRCode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtStartpoint
            // 
            this.txtStartpoint.Location = new System.Drawing.Point(0, 2);
            this.txtStartpoint.Multiline = true;
            this.txtStartpoint.Name = "txtStartpoint";
            this.txtStartpoint.ReadOnly = true;
            this.txtStartpoint.Size = new System.Drawing.Size(201, 103);
            this.txtStartpoint.TabIndex = 4;
            this.txtStartpoint.Text = "Machine 01\r\n\r\nHoChiMinh Station\r\n";
            this.txtStartpoint.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 362);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(201, 85);
            this.textBox1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 372);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 418);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Date";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBoxQRCode
            // 
            this.groupBoxQRCode.Controls.Add(this.label3);
            this.groupBoxQRCode.Controls.Add(this.labelTotal);
            this.groupBoxQRCode.Controls.Add(this.pictureBox1);
            this.groupBoxQRCode.Location = new System.Drawing.Point(207, 102);
            this.groupBoxQRCode.Name = "groupBoxQRCode";
            this.groupBoxQRCode.Size = new System.Drawing.Size(592, 263);
            this.groupBoxQRCode.TabIndex = 8;
            this.groupBoxQRCode.TabStop = false;
            this.groupBoxQRCode.Text = "QRCode";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(208, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(162, 151);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(204, 205);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(85, 20);
            this.labelTotal.TabIndex = 1;
            this.labelTotal.Text = "Total Cost:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(295, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            // 
            // btnFinish
            // 
            this.btnFinish.Location = new System.Drawing.Point(415, 372);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(162, 55);
            this.btnFinish.TabIndex = 3;
            this.btnFinish.Text = "Finish Transaction";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // QRCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.groupBoxQRCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtStartpoint);
            this.Name = "QRCode";
            this.Text = "QRCode";
            this.Load += new System.EventHandler(this.QRCode_Load);
            this.groupBoxQRCode.ResumeLayout(false);
            this.groupBoxQRCode.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtStartpoint;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBoxQRCode;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnFinish;
    }
}