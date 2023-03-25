
namespace TicketVendingMachine
{
    partial class Destination
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBoxDestination = new System.Windows.Forms.GroupBox();
            this.txtTiming = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dataGridViewDestination = new System.Windows.Forms.DataGridView();
            this.labelDestination = new System.Windows.Forms.Label();
            this.labelCost = new System.Windows.Forms.Label();
            this.txtDestination = new System.Windows.Forms.TextBox();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBoxDestination.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDestination)).BeginInit();
            this.SuspendLayout();
            // 
            // txtStartpoint
            // 
            this.txtStartpoint.Location = new System.Drawing.Point(2, 1);
            this.txtStartpoint.Multiline = true;
            this.txtStartpoint.Name = "txtStartpoint";
            this.txtStartpoint.ReadOnly = true;
            this.txtStartpoint.Size = new System.Drawing.Size(192, 103);
            this.txtStartpoint.TabIndex = 0;
            this.txtStartpoint.Text = "Machine 01\r\n\r\nHoChiMinh Station\r\n";
            this.txtStartpoint.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtStartpoint.TextChanged += new System.EventHandler(this.txtStartpoint_TextChanged);
            // 
            // groupBoxDestination
            // 
            this.groupBoxDestination.Controls.Add(this.dataGridViewDestination);
            this.groupBoxDestination.Location = new System.Drawing.Point(201, 75);
            this.groupBoxDestination.Name = "groupBoxDestination";
            this.groupBoxDestination.Size = new System.Drawing.Size(587, 280);
            this.groupBoxDestination.TabIndex = 1;
            this.groupBoxDestination.TabStop = false;
            this.groupBoxDestination.Text = "Destination";
            // 
            // txtTiming
            // 
            this.txtTiming.Location = new System.Drawing.Point(2, 361);
            this.txtTiming.Multiline = true;
            this.txtTiming.Name = "txtTiming";
            this.txtTiming.ReadOnly = true;
            this.txtTiming.Size = new System.Drawing.Size(202, 87);
            this.txtTiming.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 376);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 410);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Date";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dataGridViewDestination
            // 
            this.dataGridViewDestination.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDestination.Location = new System.Drawing.Point(6, 25);
            this.dataGridViewDestination.Name = "dataGridViewDestination";
            this.dataGridViewDestination.RowHeadersWidth = 62;
            this.dataGridViewDestination.RowTemplate.Height = 28;
            this.dataGridViewDestination.Size = new System.Drawing.Size(575, 255);
            this.dataGridViewDestination.TabIndex = 0;
            this.dataGridViewDestination.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDestination_CellContentClick);
            // 
            // labelDestination
            // 
            this.labelDestination.AutoSize = true;
            this.labelDestination.Location = new System.Drawing.Point(227, 362);
            this.labelDestination.Name = "labelDestination";
            this.labelDestination.Size = new System.Drawing.Size(90, 20);
            this.labelDestination.TabIndex = 5;
            this.labelDestination.Text = "Destination";
            // 
            // labelCost
            // 
            this.labelCost.AutoSize = true;
            this.labelCost.Location = new System.Drawing.Point(553, 362);
            this.labelCost.Name = "labelCost";
            this.labelCost.Size = new System.Drawing.Size(42, 20);
            this.labelCost.TabIndex = 6;
            this.labelCost.Text = "Cost";
            // 
            // txtDestination
            // 
            this.txtDestination.Location = new System.Drawing.Point(231, 393);
            this.txtDestination.Name = "txtDestination";
            this.txtDestination.Size = new System.Drawing.Size(224, 26);
            this.txtDestination.TabIndex = 7;
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(557, 393);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(225, 26);
            this.txtCost.TabIndex = 8;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(29, 175);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(145, 85);
            this.btnConfirm.TabIndex = 9;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(365, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(276, 58);
            this.label3.TabIndex = 10;
            this.label3.Text = "Destination";
            // 
            // Destination
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.txtDestination);
            this.Controls.Add(this.labelCost);
            this.Controls.Add(this.labelDestination);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTiming);
            this.Controls.Add(this.groupBoxDestination);
            this.Controls.Add(this.txtStartpoint);
            this.Name = "Destination";
            this.Text = "Destination";
            this.Load += new System.EventHandler(this.Destination_Load);
            this.groupBoxDestination.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDestination)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtStartpoint;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBoxDestination;
        private System.Windows.Forms.TextBox txtTiming;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView dataGridViewDestination;
        private System.Windows.Forms.Label labelDestination;
        private System.Windows.Forms.Label labelCost;
        private System.Windows.Forms.TextBox txtDestination;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label label3;
    }
}