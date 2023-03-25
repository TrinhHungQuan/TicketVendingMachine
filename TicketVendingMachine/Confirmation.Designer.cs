
namespace TicketVendingMachine
{
    partial class Confirmation
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
            this.groupBoxConfirmation = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.btnAdd1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelChildren = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.labelAdult = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelCost = new System.Windows.Forms.Label();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.labelDestination = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.btnStartAgain = new System.Windows.Forms.Button();
            this.groupBoxConfirmation.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtStartpoint
            // 
            this.txtStartpoint.Location = new System.Drawing.Point(1, 2);
            this.txtStartpoint.Multiline = true;
            this.txtStartpoint.Name = "txtStartpoint";
            this.txtStartpoint.ReadOnly = true;
            this.txtStartpoint.Size = new System.Drawing.Size(201, 103);
            this.txtStartpoint.TabIndex = 1;
            this.txtStartpoint.Text = "Machine 01\r\n\r\nHoChiMinh Station\r\n";
            this.txtStartpoint.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtStartpoint.TextChanged += new System.EventHandler(this.txtStartpoint_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1, 367);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(201, 83);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 383);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 418);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Date";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBoxConfirmation
            // 
            this.groupBoxConfirmation.Controls.Add(this.label9);
            this.groupBoxConfirmation.Controls.Add(this.labelTotal);
            this.groupBoxConfirmation.Controls.Add(this.btnAdd1);
            this.groupBoxConfirmation.Controls.Add(this.label8);
            this.groupBoxConfirmation.Controls.Add(this.label7);
            this.groupBoxConfirmation.Controls.Add(this.label6);
            this.groupBoxConfirmation.Controls.Add(this.labelChildren);
            this.groupBoxConfirmation.Controls.Add(this.btnAdd);
            this.groupBoxConfirmation.Controls.Add(this.labelAdult);
            this.groupBoxConfirmation.Controls.Add(this.label5);
            this.groupBoxConfirmation.Controls.Add(this.label4);
            this.groupBoxConfirmation.Controls.Add(this.label3);
            this.groupBoxConfirmation.Controls.Add(this.labelCost);
            this.groupBoxConfirmation.Controls.Add(this.labelQuantity);
            this.groupBoxConfirmation.Controls.Add(this.labelDestination);
            this.groupBoxConfirmation.Location = new System.Drawing.Point(208, 102);
            this.groupBoxConfirmation.Name = "groupBoxConfirmation";
            this.groupBoxConfirmation.Size = new System.Drawing.Size(596, 268);
            this.groupBoxConfirmation.TabIndex = 5;
            this.groupBoxConfirmation.TabStop = false;
            this.groupBoxConfirmation.Text = "Confirmation";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(473, 229);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 20);
            this.label9.TabIndex = 14;
            this.label9.Text = "label9";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(370, 230);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(85, 20);
            this.labelTotal.TabIndex = 13;
            this.labelTotal.Text = "Total Cost:";
            // 
            // btnAdd1
            // 
            this.btnAdd1.Location = new System.Drawing.Point(497, 133);
            this.btnAdd1.Name = "btnAdd1";
            this.btnAdd1.Size = new System.Drawing.Size(83, 34);
            this.btnAdd1.TabIndex = 12;
            this.btnAdd1.Text = "Add";
            this.btnAdd1.UseVisualStyleBackColor = true;
            this.btnAdd1.Click += new System.EventHandler(this.btnAdd1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(400, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "label8";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(282, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "label7";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(136, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "label6";
            // 
            // labelChildren
            // 
            this.labelChildren.AutoSize = true;
            this.labelChildren.Location = new System.Drawing.Point(24, 140);
            this.labelChildren.Name = "labelChildren";
            this.labelChildren.Size = new System.Drawing.Size(67, 20);
            this.labelChildren.TabIndex = 8;
            this.labelChildren.Text = "Children";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(497, 76);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(83, 34);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // labelAdult
            // 
            this.labelAdult.AutoSize = true;
            this.labelAdult.Location = new System.Drawing.Point(24, 83);
            this.labelAdult.Name = "labelAdult";
            this.labelAdult.Size = new System.Drawing.Size(46, 20);
            this.labelAdult.TabIndex = 6;
            this.labelAdult.Text = "Adult";
            this.labelAdult.Click += new System.EventHandler(this.labelType_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(404, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(282, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(136, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "label3";
            // 
            // labelCost
            // 
            this.labelCost.AutoSize = true;
            this.labelCost.Location = new System.Drawing.Point(400, 38);
            this.labelCost.Name = "labelCost";
            this.labelCost.Size = new System.Drawing.Size(42, 20);
            this.labelCost.TabIndex = 2;
            this.labelCost.Text = "Cost";
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Location = new System.Drawing.Point(265, 38);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(68, 20);
            this.labelQuantity.TabIndex = 1;
            this.labelQuantity.Text = "Quantity";
            // 
            // labelDestination
            // 
            this.labelDestination.AutoSize = true;
            this.labelDestination.Location = new System.Drawing.Point(119, 38);
            this.labelDestination.Name = "labelDestination";
            this.labelDestination.Size = new System.Drawing.Size(90, 20);
            this.labelDestination.TabIndex = 0;
            this.labelDestination.Text = "Destination";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(601, 383);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(187, 46);
            this.btnConfirm.TabIndex = 6;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(349, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(310, 58);
            this.label10.TabIndex = 7;
            this.label10.Text = "Confirmation";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // btnStartAgain
            // 
            this.btnStartAgain.Location = new System.Drawing.Point(17, 169);
            this.btnStartAgain.Name = "btnStartAgain";
            this.btnStartAgain.Size = new System.Drawing.Size(168, 82);
            this.btnStartAgain.TabIndex = 8;
            this.btnStartAgain.Text = "Start Again";
            this.btnStartAgain.UseVisualStyleBackColor = true;
            this.btnStartAgain.Click += new System.EventHandler(this.btnStartAgain_Click);
            // 
            // Confirmation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnStartAgain);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.groupBoxConfirmation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtStartpoint);
            this.Name = "Confirmation";
            this.Text = "Confirmation";
            this.Load += new System.EventHandler(this.Confirmation_Load);
            this.groupBoxConfirmation.ResumeLayout(false);
            this.groupBoxConfirmation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtStartpoint;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBoxConfirmation;
        private System.Windows.Forms.Label labelAdult;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelCost;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.Label labelDestination;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnAdd1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelChildren;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnStartAgain;
    }
}