namespace SaleCalculator
{
    partial class mainWindow
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
            this.inputSalePrice = new System.Windows.Forms.TextBox();
            this.inputClosing = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.resultProfit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.inputMortgage = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.inputDebt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.resultDebt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.resultFinal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.calculate = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.resultsGridView = new System.Windows.Forms.DataGridView();
            this.colOffer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCosts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProfit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMortgage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDebt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotalDebt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.resultsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Offer Price:";
            // 
            // inputSalePrice
            // 
            this.inputSalePrice.Location = new System.Drawing.Point(111, 10);
            this.inputSalePrice.Name = "inputSalePrice";
            this.inputSalePrice.Size = new System.Drawing.Size(100, 20);
            this.inputSalePrice.TabIndex = 1;
            // 
            // inputClosing
            // 
            this.inputClosing.Location = new System.Drawing.Point(111, 36);
            this.inputClosing.Name = "inputClosing";
            this.inputClosing.Size = new System.Drawing.Size(100, 20);
            this.inputClosing.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Closing Costs:";
            // 
            // resultProfit
            // 
            this.resultProfit.Location = new System.Drawing.Point(111, 62);
            this.resultProfit.Name = "resultProfit";
            this.resultProfit.ReadOnly = true;
            this.resultProfit.Size = new System.Drawing.Size(100, 20);
            this.resultProfit.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Total Profit:";
            // 
            // inputMortgage
            // 
            this.inputMortgage.Location = new System.Drawing.Point(111, 120);
            this.inputMortgage.Name = "inputMortgage";
            this.inputMortgage.Size = new System.Drawing.Size(100, 20);
            this.inputMortgage.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Current Mortgage:";
            // 
            // inputDebt
            // 
            this.inputDebt.Location = new System.Drawing.Point(111, 146);
            this.inputDebt.Name = "inputDebt";
            this.inputDebt.Size = new System.Drawing.Size(100, 20);
            this.inputDebt.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Current Credit Debt:";
            // 
            // resultDebt
            // 
            this.resultDebt.Location = new System.Drawing.Point(111, 172);
            this.resultDebt.Name = "resultDebt";
            this.resultDebt.ReadOnly = true;
            this.resultDebt.Size = new System.Drawing.Size(100, 20);
            this.resultDebt.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Total Debt:";
            // 
            // resultFinal
            // 
            this.resultFinal.Location = new System.Drawing.Point(111, 229);
            this.resultFinal.Name = "resultFinal";
            this.resultFinal.ReadOnly = true;
            this.resultFinal.Size = new System.Drawing.Size(100, 20);
            this.resultFinal.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 232);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Final Over/Under";
            // 
            // calculate
            // 
            this.calculate.Location = new System.Drawing.Point(136, 269);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(75, 23);
            this.calculate.TabIndex = 14;
            this.calculate.Text = "Calcualte";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(8, 269);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(75, 23);
            this.reset.TabIndex = 15;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // resultsGridView
            // 
            this.resultsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colOffer,
            this.colCosts,
            this.colProfit,
            this.colMortgage,
            this.colDebt,
            this.colTotalDebt,
            this.colFinal});
            this.resultsGridView.Location = new System.Drawing.Point(217, 10);
            this.resultsGridView.Name = "resultsGridView";
            this.resultsGridView.RowHeadersWidth = 20;
            this.resultsGridView.Size = new System.Drawing.Size(512, 282);
            this.resultsGridView.TabIndex = 16;
            this.resultsGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // colOffer
            // 
            this.colOffer.HeaderText = "Offer Price";
            this.colOffer.Name = "colOffer";
            this.colOffer.ReadOnly = true;
            this.colOffer.Width = 70;
            // 
            // colCosts
            // 
            this.colCosts.HeaderText = "Closing Costs";
            this.colCosts.Name = "colCosts";
            this.colCosts.ReadOnly = true;
            this.colCosts.Width = 70;
            // 
            // colProfit
            // 
            this.colProfit.HeaderText = "Total Profit";
            this.colProfit.Name = "colProfit";
            this.colProfit.ReadOnly = true;
            this.colProfit.Width = 70;
            // 
            // colMortgage
            // 
            this.colMortgage.HeaderText = "Mortgage";
            this.colMortgage.Name = "colMortgage";
            this.colMortgage.ReadOnly = true;
            this.colMortgage.Width = 70;
            // 
            // colDebt
            // 
            this.colDebt.HeaderText = "Credit Debt";
            this.colDebt.Name = "colDebt";
            this.colDebt.ReadOnly = true;
            this.colDebt.Width = 70;
            // 
            // colTotalDebt
            // 
            this.colTotalDebt.HeaderText = "Total Debt";
            this.colTotalDebt.Name = "colTotalDebt";
            this.colTotalDebt.ReadOnly = true;
            this.colTotalDebt.Width = 70;
            // 
            // colFinal
            // 
            this.colFinal.HeaderText = "Final Over/Under";
            this.colFinal.Name = "colFinal";
            this.colFinal.ReadOnly = true;
            this.colFinal.Width = 70;
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 304);
            this.Controls.Add(this.resultsGridView);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.resultFinal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.resultDebt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.inputDebt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.inputMortgage);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.resultProfit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.inputClosing);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inputSalePrice);
            this.Controls.Add(this.label1);
            this.Name = "mainWindow";
            this.Text = "Home Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.resultsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputSalePrice;
        private System.Windows.Forms.TextBox inputClosing;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox resultProfit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox inputMortgage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox inputDebt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox resultDebt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox resultFinal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.DataGridView resultsGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOffer;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCosts;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProfit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMortgage;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDebt;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotalDebt;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFinal;
    }
}

