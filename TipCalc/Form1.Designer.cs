namespace TipCalc
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            lblLabel1 = new Label();
            txtBillAmt = new TextBox();
            lblFifteenPct = new Label();
            lblTwentyPct = new Label();
            lblFifteenBillAmt = new Label();
            lblTwentyBillAmt = new Label();
            lblFifteenTipAmt = new Label();
            lblTwentyTipAmt = new Label();
            lblFiteenTotal = new Label();
            lblTwentyTotal = new Label();
            btnCalc = new Button();
            panel1 = new Panel();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            lblSym1 = new Label();
            txtTwentyTotal = new TextBox();
            txtTwentyTipAmt = new TextBox();
            txtTwentyBillAmt = new TextBox();
            txtFifteenTotal = new TextBox();
            txtFifteenTipAmt = new TextBox();
            txtFifeentBillAmt = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblLabel1
            // 
            lblLabel1.AutoSize = true;
            lblLabel1.Location = new Point(33, 41);
            lblLabel1.Name = "lblLabel1";
            lblLabel1.Size = new Size(114, 15);
            lblLabel1.TabIndex = 0;
            lblLabel1.Text = "Pre-Tip Bill Amount:";
            // 
            // txtBillAmt
            // 
            txtBillAmt.Location = new Point(163, 33);
            txtBillAmt.Name = "txtBillAmt";
            txtBillAmt.Size = new Size(80, 23);
            txtBillAmt.TabIndex = 1;
            // 
            // lblFifteenPct
            // 
            lblFifteenPct.AutoSize = true;
            lblFifteenPct.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblFifteenPct.Location = new Point(25, 15);
            lblFifteenPct.Name = "lblFifteenPct";
            lblFifteenPct.Size = new Size(40, 20);
            lblFifteenPct.TabIndex = 2;
            lblFifteenPct.Text = "15%";
            // 
            // lblTwentyPct
            // 
            lblTwentyPct.AutoSize = true;
            lblTwentyPct.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTwentyPct.Location = new Point(25, 125);
            lblTwentyPct.Name = "lblTwentyPct";
            lblTwentyPct.Size = new Size(42, 21);
            lblTwentyPct.TabIndex = 3;
            lblTwentyPct.Text = "20%";
            // 
            // lblFifteenBillAmt
            // 
            lblFifteenBillAmt.AutoSize = true;
            lblFifteenBillAmt.Location = new Point(44, 39);
            lblFifteenBillAmt.Name = "lblFifteenBillAmt";
            lblFifteenBillAmt.Size = new Size(55, 15);
            lblFifteenBillAmt.TabIndex = 4;
            lblFifteenBillAmt.Text = "Bill Amt: ";
            // 
            // lblTwentyBillAmt
            // 
            lblTwentyBillAmt.AutoSize = true;
            lblTwentyBillAmt.Location = new Point(44, 149);
            lblTwentyBillAmt.Name = "lblTwentyBillAmt";
            lblTwentyBillAmt.Size = new Size(52, 15);
            lblTwentyBillAmt.TabIndex = 5;
            lblTwentyBillAmt.Text = "Bill Amt:";
            // 
            // lblFifteenTipAmt
            // 
            lblFifteenTipAmt.AutoSize = true;
            lblFifteenTipAmt.Location = new Point(44, 65);
            lblFifteenTipAmt.Name = "lblFifteenTipAmt";
            lblFifteenTipAmt.Size = new Size(52, 15);
            lblFifteenTipAmt.TabIndex = 6;
            lblFifteenTipAmt.Text = "Tip Amt:";
            // 
            // lblTwentyTipAmt
            // 
            lblTwentyTipAmt.AutoSize = true;
            lblTwentyTipAmt.Location = new Point(44, 175);
            lblTwentyTipAmt.Name = "lblTwentyTipAmt";
            lblTwentyTipAmt.Size = new Size(52, 15);
            lblTwentyTipAmt.TabIndex = 7;
            lblTwentyTipAmt.Text = "Tip Amt:";
            // 
            // lblFiteenTotal
            // 
            lblFiteenTotal.AutoSize = true;
            lblFiteenTotal.Location = new Point(44, 91);
            lblFiteenTotal.Name = "lblFiteenTotal";
            lblFiteenTotal.Size = new Size(96, 15);
            lblFiteenTotal.TabIndex = 8;
            lblFiteenTotal.Text = "Total w/15% Tip: ";
            // 
            // lblTwentyTotal
            // 
            lblTwentyTotal.AutoSize = true;
            lblTwentyTotal.Location = new Point(44, 201);
            lblTwentyTotal.Name = "lblTwentyTotal";
            lblTwentyTotal.Size = new Size(93, 15);
            lblTwentyTotal.TabIndex = 9;
            lblTwentyTotal.Text = "Total w/20% Tip:";
            // 
            // btnCalc
            // 
            btnCalc.Location = new Point(241, 32);
            btnCalc.Name = "btnCalc";
            btnCalc.Size = new Size(46, 24);
            btnCalc.TabIndex = 10;
            btnCalc.Text = "Calc";
            btnCalc.UseVisualStyleBackColor = true;
            btnCalc.Click += btnCalc_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lblSym1);
            panel1.Controls.Add(txtTwentyTotal);
            panel1.Controls.Add(txtTwentyTipAmt);
            panel1.Controls.Add(txtTwentyBillAmt);
            panel1.Controls.Add(txtFifteenTotal);
            panel1.Controls.Add(txtFifteenTipAmt);
            panel1.Controls.Add(txtFifeentBillAmt);
            panel1.Controls.Add(lblFifteenPct);
            panel1.Controls.Add(lblFifteenBillAmt);
            panel1.Controls.Add(lblTwentyTotal);
            panel1.Controls.Add(lblTwentyPct);
            panel1.Controls.Add(lblFiteenTotal);
            panel1.Controls.Add(lblTwentyBillAmt);
            panel1.Controls.Add(lblTwentyTipAmt);
            panel1.Controls.Add(lblFifteenTipAmt);
            panel1.Location = new Point(36, 95);
            panel1.Name = "panel1";
            panel1.Size = new Size(251, 265);
            panel1.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(143, 201);
            label5.Name = "label5";
            label5.Size = new Size(13, 15);
            label5.TabIndex = 21;
            label5.Text = "$";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(143, 172);
            label4.Name = "label4";
            label4.Size = new Size(13, 15);
            label4.TabIndex = 20;
            label4.Text = "$";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(143, 144);
            label3.Name = "label3";
            label3.Size = new Size(13, 15);
            label3.TabIndex = 19;
            label3.Text = "$";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(143, 86);
            label2.Name = "label2";
            label2.Size = new Size(13, 15);
            label2.TabIndex = 18;
            label2.Text = "$";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(143, 60);
            label1.Name = "label1";
            label1.Size = new Size(13, 15);
            label1.TabIndex = 17;
            label1.Text = "$";
            // 
            // lblSym1
            // 
            lblSym1.AutoSize = true;
            lblSym1.Location = new Point(143, 34);
            lblSym1.Name = "lblSym1";
            lblSym1.Size = new Size(13, 15);
            lblSym1.TabIndex = 16;
            lblSym1.Text = "$";
            // 
            // txtTwentyTotal
            // 
            txtTwentyTotal.Enabled = false;
            txtTwentyTotal.Location = new Point(154, 198);
            txtTwentyTotal.Name = "txtTwentyTotal";
            txtTwentyTotal.Size = new Size(50, 23);
            txtTwentyTotal.TabIndex = 15;
            txtTwentyTotal.TextAlign = HorizontalAlignment.Right;
            // 
            // txtTwentyTipAmt
            // 
            txtTwentyTipAmt.Enabled = false;
            txtTwentyTipAmt.Location = new Point(154, 169);
            txtTwentyTipAmt.Name = "txtTwentyTipAmt";
            txtTwentyTipAmt.Size = new Size(50, 23);
            txtTwentyTipAmt.TabIndex = 14;
            txtTwentyTipAmt.TextAlign = HorizontalAlignment.Right;
            // 
            // txtTwentyBillAmt
            // 
            txtTwentyBillAmt.Enabled = false;
            txtTwentyBillAmt.Location = new Point(154, 141);
            txtTwentyBillAmt.Name = "txtTwentyBillAmt";
            txtTwentyBillAmt.Size = new Size(50, 23);
            txtTwentyBillAmt.TabIndex = 13;
            txtTwentyBillAmt.TextAlign = HorizontalAlignment.Right;
            // 
            // txtFifteenTotal
            // 
            txtFifteenTotal.Enabled = false;
            txtFifteenTotal.Location = new Point(154, 83);
            txtFifteenTotal.Name = "txtFifteenTotal";
            txtFifteenTotal.Size = new Size(50, 23);
            txtFifteenTotal.TabIndex = 12;
            txtFifteenTotal.TextAlign = HorizontalAlignment.Right;
            // 
            // txtFifteenTipAmt
            // 
            txtFifteenTipAmt.Enabled = false;
            txtFifteenTipAmt.Location = new Point(154, 57);
            txtFifteenTipAmt.Name = "txtFifteenTipAmt";
            txtFifteenTipAmt.Size = new Size(50, 23);
            txtFifteenTipAmt.TabIndex = 11;
            txtFifteenTipAmt.TextAlign = HorizontalAlignment.Right;
            // 
            // txtFifeentBillAmt
            // 
            txtFifeentBillAmt.Enabled = false;
            txtFifeentBillAmt.Location = new Point(154, 31);
            txtFifeentBillAmt.Name = "txtFifeentBillAmt";
            txtFifeentBillAmt.Size = new Size(50, 23);
            txtFifeentBillAmt.TabIndex = 10;
            txtFifeentBillAmt.TextAlign = HorizontalAlignment.Right;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(331, 417);
            Controls.Add(panel1);
            Controls.Add(btnCalc);
            Controls.Add(txtBillAmt);
            Controls.Add(lblLabel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmMain";
            Text = "TipCalc";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLabel1;
        private TextBox txtBillAmt;
        private Label lblFifteenPct;
        private Label lblTwentyPct;
        private Label lblFifteenBillAmt;
        private Label lblTwentyBillAmt;
        private Label lblFifteenTipAmt;
        private Label lblTwentyTipAmt;
        private Label lblFiteenTotal;
        private Label lblTwentyTotal;
        private Button button1;
        private Button btnCalc;
        private Panel panel1;
        private TextBox txtTwentyTotal;
        private TextBox txtTwentyTipAmt;
        private TextBox txtTwentyBillAmt;
        private TextBox txtFifteenTotal;
        private TextBox txtFifteenTipAmt;
        private TextBox txtFifeentBillAmt;
        private Label lblSym1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}