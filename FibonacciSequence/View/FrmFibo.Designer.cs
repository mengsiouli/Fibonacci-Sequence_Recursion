namespace FibonacciSequence
{
	partial class FrmFibo
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose( bool disposing )
		{
			if( disposing && ( components != null ) ) {
				components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.m_txbFiboSeqItem = new System.Windows.Forms.TextBox();
			this.m_txbFiboSeqOutput = new System.Windows.Forms.TextBox();
			this.m_lblFiboSeqInput = new System.Windows.Forms.Label();
			this.m_lblFiboSeqCal = new System.Windows.Forms.Label();
			this.m_btnCalculate = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// m_txbFiboSeqItem
			// 
			this.m_txbFiboSeqItem.Font = new System.Drawing.Font("Microsoft JhengHei", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.m_txbFiboSeqItem.Location = new System.Drawing.Point(44, 123);
			this.m_txbFiboSeqItem.Name = "m_txbFiboSeqItem";
			this.m_txbFiboSeqItem.Size = new System.Drawing.Size(325, 57);
			this.m_txbFiboSeqItem.TabIndex = 0;
			// 
			// m_txbFiboSeqOutput
			// 
			this.m_txbFiboSeqOutput.BackColor = System.Drawing.SystemColors.Window;
			this.m_txbFiboSeqOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.m_txbFiboSeqOutput.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.m_txbFiboSeqOutput.Location = new System.Drawing.Point(42, 253);
			this.m_txbFiboSeqOutput.Multiline = true;
			this.m_txbFiboSeqOutput.Name = "m_txbFiboSeqOutput";
			this.m_txbFiboSeqOutput.ReadOnly = true;
			this.m_txbFiboSeqOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.m_txbFiboSeqOutput.Size = new System.Drawing.Size(602, 145);
			this.m_txbFiboSeqOutput.TabIndex = 3;
			// 
			// m_lblFiboSeqInput
			// 
			this.m_lblFiboSeqInput.AutoSize = true;
			this.m_lblFiboSeqInput.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.m_lblFiboSeqInput.Location = new System.Drawing.Point(38, 33);
			this.m_lblFiboSeqInput.Name = "m_lblFiboSeqInput";
			this.m_lblFiboSeqInput.Size = new System.Drawing.Size(474, 80);
			this.m_lblFiboSeqInput.TabIndex = 2;
			this.m_lblFiboSeqInput.Text = "Please enter a positive integer \r\nbetween 1 and 30:";
			// 
			// m_lblFiboSeqCal
			// 
			this.m_lblFiboSeqCal.AutoSize = true;
			this.m_lblFiboSeqCal.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.m_lblFiboSeqCal.Location = new System.Drawing.Point(39, 197);
			this.m_lblFiboSeqCal.Name = "m_lblFiboSeqCal";
			this.m_lblFiboSeqCal.Size = new System.Drawing.Size(298, 40);
			this.m_lblFiboSeqCal.TabIndex = 2;
			this.m_lblFiboSeqCal.Text = "Calculation results:";
			// 
			// m_btnCalculate
			// 
			this.m_btnCalculate.Font = new System.Drawing.Font("Microsoft JhengHei", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.m_btnCalculate.Location = new System.Drawing.Point(387, 123);
			this.m_btnCalculate.Name = "m_btnCalculate";
			this.m_btnCalculate.Size = new System.Drawing.Size(230, 56);
			this.m_btnCalculate.TabIndex = 1;
			this.m_btnCalculate.Text = "Calculate";
			this.m_btnCalculate.UseVisualStyleBackColor = true;
			this.m_btnCalculate.Click += new System.EventHandler(this.m_btnCalculate_Click);
			// 
			// FrmFibo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(656, 430);
			this.Controls.Add(this.m_txbFiboSeqItem);
			this.Controls.Add(this.m_btnCalculate);
			this.Controls.Add(this.m_lblFiboSeqInput);
			this.Controls.Add(this.m_txbFiboSeqOutput);
			this.Controls.Add(this.m_lblFiboSeqCal);
			this.Name = "FrmFibo";
			this.Text = "FiboNacci Generator";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox m_txbFiboSeqItem;
		private System.Windows.Forms.TextBox m_txbFiboSeqOutput;
		private System.Windows.Forms.Label m_lblFiboSeqInput;
		private System.Windows.Forms.Label m_lblFiboSeqCal;
		private System.Windows.Forms.Button m_btnCalculate;
	}
}

