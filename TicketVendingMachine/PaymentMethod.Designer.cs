
namespace TicketVendingMachine
{
    partial class PaymentMethod
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
            this.txtStartpoint = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBoxSelectedInfo = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelChildren = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelAdult = new System.Windows.Forms.Label();
            this.labelCost = new System.Windows.Forms.Label();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.labelDestination = new System.Windows.Forms.Label();
            this.btnCreditCard = new System.Windows.Forms.Button();
            this.btnQRCode = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.btnStartAgain = new System.Windows.Forms.Button();
            this.groupBoxSelectedInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtStartpoint
            // 
            this.txtStartpoint.Location = new System.Drawing.Point(0, 0);
            this.txtStartpoint.Multiline = true;
            this.txtStartpoint.Name = "txtStartpoint";
            this.txtStartpoint.ReadOnly = true;
            this.txtStartpoint.Size = new System.Drawing.Size(201, 103);
            this.txtStartpoint.TabIndex = 2;
            this.txtStartpoint.Text = "Machine 01\r\n\r\nHoChiMinh Station\r\n";
            this.txtStartpoint.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 366);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(201, 86);
            this.textBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 375);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 418);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Date";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBoxSelectedInfo
            // 
            this.groupBoxSelectedInfo.Controls.Add(this.label9);
            this.groupBoxSelectedInfo.Controls.Add(this.labelTotal);
            this.groupBoxSelectedInfo.Controls.Add(this.label8);
            this.groupBoxSelectedInfo.Controls.Add(this.label7);
            this.groupBoxSelectedInfo.Controls.Add(this.label6);
            this.groupBoxSelectedInfo.Controls.Add(this.labelChildren);
            this.groupBoxSelectedInfo.Controls.Add(this.label5);
            this.groupBoxSelectedInfo.Controls.Add(this.label4);
            this.groupBoxSelectedInfo.Controls.Add(this.label3);
            this.groupBoxSelectedInfo.Controls.Add(this.labelAdult);
            this.groupBoxSelectedInfo.Controls.Add(this.labelCost);
            this.groupBoxSelectedInfo.Controls.Add(this.labelQuantity);
            this.groupBoxSelectedInfo.Controls.Add(this.labelDestination);
            this.groupBoxSelectedInfo.Location = new System.Drawing.Point(207, 99);
            this.groupBoxSelectedInfo.Name = "groupBoxSelectedInfo";
            this.groupBoxSelectedInfo.Size = new System.Drawing.Size(595, 270);
            this.groupBoxSelectedInfo.TabIndex = 6;
            this.groupBoxSelectedInfo.TabStop = false;
            this.groupBoxSelectedInfo.Text = "Selected Information";
            this.groupBoxSelectedInfo.Enter += new System.EventHandler(this.groupBoxSelectedInfo_Enter);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(462, 225);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 20);
            this.label9.TabIndex = 12;
            this.label9.Text = "label9";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(364, 226);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(85, 20);
            this.labelTotal.TabIndex = 11;
            this.labelTotal.Text = "Total Cost:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(458, 138);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "label8";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(310, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "label7";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(167, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "label6";
            // 
            // labelChildren
            // 
            this.labelChildren.AutoSize = true;
            this.labelChildren.Location = new System.Drawing.Point(55, 139);
            this.labelChildren.Name = "labelChildren";
            this.labelChildren.Size = new System.Drawing.Size(67, 20);
            this.labelChildren.TabIndex = 7;
            this.labelChildren.Text = "Children";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(462, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(310, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(167, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "label3";
            // 
            // labelAdult
            // 
            this.labelAdult.AutoSize = true;
            this.labelAdult.Location = new System.Drawing.Point(51, 92);
            this.labelAdult.Name = "labelAdult";
            this.labelAdult.Size = new System.Drawing.Size(46, 20);
            this.labelAdult.TabIndex = 3;
            this.labelAdult.Text = "Adult";
            // 
            // labelCost
            // 
            this.labelCost.AutoSize = true;
            this.labelCost.Location = new System.Drawing.Point(462, 52);
            this.labelCost.Name = "labelCost";
            this.labelCost.Size = new System.Drawing.Size(42, 20);
            this.labelCost.TabIndex = 2;
            this.labelCost.Text = "Cost";
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Location = new System.Drawing.Point(293, 52);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(68, 20);
            this.labelQuantity.TabIndex = 1;
            this.labelQuantity.Text = "Quantity";
            // 
            // labelDestination
            // 
            this.labelDestination.AutoSize = true;
            this.labelDestination.Location = new System.Drawing.Point(149, 52);
            this.labelDestination.Name = "labelDestination";
            this.labelDestination.Size = new System.Drawing.Size(90, 20);
            this.labelDestination.TabIndex = 0;
            this.labelDestination.Text = "Destination";
            // 
            // btnCreditCard
            // 
            this.btnCreditCard.Location = new System.Drawing.Point(253, 375);
            this.btnCreditCard.Name = "btnCreditCard";
            this.btnCreditCard.Size = new System.Drawing.Size(193, 46);
            this.btnCreditCard.TabIndex = 7;
            this.btnCreditCard.Text = "Credit Card";
            this.btnCreditCard.UseVisualStyleBackColor = true;
            this.btnCreditCard.Click += new System.EventHandler(this.btnCreditCard_Click);
            // 
            // btnQRCode
            // 
            this.btnQRCode.Location = new System.Drawing.Point(518, 375);
            this.btnQRCode.Name = "btnQRCode";
            this.btnQRCode.Size = new System.Drawing.Size(193, 46);
            this.btnQRCode.TabIndex = 8;
            this.btnQRCode.Text = "QR Code";
            this.btnQRCode.UseVisualStyleBackColor = true;
            this.btnQRCode.Click += new System.EventHandler(this.btnQRCode_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(380, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(223, 58);
            this.label10.TabIndex = 9;
            this.label10.Text = "Payment";
            // 
            // btnStartAgain
            // 
            this.btnStartAgain.Location = new System.Drawing.Point(12, 176);
            this.btnStartAgain.Name = "btnStartAgain";
            this.btnStartAgain.Size = new System.Drawing.Size(166, 81);
            this.btnStartAgain.TabIndex = 10;
            this.btnStartAgain.Text = "Start Again";
            this.btnStartAgain.UseVisualStyleBackColor = true;
            this.btnStartAgain.Click += new System.EventHandler(this.btnStartAgain_Click);
            // 
            // PaymentMethod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnStartAgain);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnQRCode);
            this.Controls.Add(this.btnCreditCard);
            this.Controls.Add(this.groupBoxSelectedInfo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtStartpoint);
            this.Name = "PaymentMethod";
            this.Text = "PaymentMethod";
            this.Load += new System.EventHandler(this.PaymentMethod_Load);
            this.groupBoxSelectedInfo.ResumeLayout(false);
            this.groupBoxSelectedInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtStartpoint;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBoxSelectedInfo;
        private System.Windows.Forms.Label labelCost;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.Label labelDestination;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelAdult;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelChildren;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCreditCard;
        private System.Windows.Forms.Button btnQRCode;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnStartAgain;
    }
}