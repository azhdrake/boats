namespace BoatTime
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
      this.cmbBoatType = new System.Windows.Forms.ComboBox();
      this.btnCheck = new System.Windows.Forms.Button();
      this.btnReserve = new System.Windows.Forms.Button();
      this.btnReset = new System.Windows.Forms.Button();
      this.btnExit = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.lblStatus = new System.Windows.Forms.Label();
      this.numAdults = new System.Windows.Forms.NumericUpDown();
      this.numChildren = new System.Windows.Forms.NumericUpDown();
      ((System.ComponentModel.ISupportInitialize)(this.numAdults)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numChildren)).BeginInit();
      this.SuspendLayout();
      // 
      // cmbBoatType
      // 
      this.cmbBoatType.FormattingEnabled = true;
      this.cmbBoatType.Location = new System.Drawing.Point(195, 38);
      this.cmbBoatType.Name = "cmbBoatType";
      this.cmbBoatType.Size = new System.Drawing.Size(141, 33);
      this.cmbBoatType.TabIndex = 0;
      this.cmbBoatType.Text = " ";
      // 
      // btnCheck
      // 
      this.btnCheck.Location = new System.Drawing.Point(42, 275);
      this.btnCheck.Name = "btnCheck";
      this.btnCheck.Size = new System.Drawing.Size(141, 44);
      this.btnCheck.TabIndex = 3;
      this.btnCheck.Text = "Check";
      this.btnCheck.UseVisualStyleBackColor = true;
      this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
      // 
      // btnReserve
      // 
      this.btnReserve.Enabled = false;
      this.btnReserve.Location = new System.Drawing.Point(42, 358);
      this.btnReserve.Name = "btnReserve";
      this.btnReserve.Size = new System.Drawing.Size(141, 44);
      this.btnReserve.TabIndex = 4;
      this.btnReserve.Text = "Reserve";
      this.btnReserve.UseVisualStyleBackColor = true;
      this.btnReserve.Click += new System.EventHandler(this.btnReserve_Click);
      // 
      // btnReset
      // 
      this.btnReset.Location = new System.Drawing.Point(42, 437);
      this.btnReset.Name = "btnReset";
      this.btnReset.Size = new System.Drawing.Size(141, 44);
      this.btnReset.TabIndex = 5;
      this.btnReset.Text = "Reset";
      this.btnReset.UseVisualStyleBackColor = true;
      this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
      // 
      // btnExit
      // 
      this.btnExit.Location = new System.Drawing.Point(195, 437);
      this.btnExit.Name = "btnExit";
      this.btnExit.Size = new System.Drawing.Size(141, 44);
      this.btnExit.TabIndex = 6;
      this.btnExit.Text = "E&xit";
      this.btnExit.UseVisualStyleBackColor = true;
      this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(37, 46);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(116, 25);
      this.label1.TabIndex = 7;
      this.label1.Text = "Boat Type:";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(37, 124);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(135, 25);
      this.label2.TabIndex = 8;
      this.label2.Text = "Adult Riders:";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(37, 203);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(135, 25);
      this.label3.TabIndex = 9;
      this.label3.Text = "Child Riders:";
      // 
      // lblStatus
      // 
      this.lblStatus.Location = new System.Drawing.Point(195, 275);
      this.lblStatus.Name = "lblStatus";
      this.lblStatus.Size = new System.Drawing.Size(141, 30);
      this.lblStatus.TabIndex = 10;
      // 
      // numAdults
      // 
      this.numAdults.Location = new System.Drawing.Point(195, 122);
      this.numAdults.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
      this.numAdults.Name = "numAdults";
      this.numAdults.Size = new System.Drawing.Size(141, 31);
      this.numAdults.TabIndex = 2;
      // 
      // numChildren
      // 
      this.numChildren.Location = new System.Drawing.Point(195, 201);
      this.numChildren.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
      this.numChildren.Name = "numChildren";
      this.numChildren.Size = new System.Drawing.Size(141, 31);
      this.numChildren.TabIndex = 3;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(370, 523);
      this.Controls.Add(this.numChildren);
      this.Controls.Add(this.numAdults);
      this.Controls.Add(this.lblStatus);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.btnExit);
      this.Controls.Add(this.btnReset);
      this.Controls.Add(this.btnReserve);
      this.Controls.Add(this.btnCheck);
      this.Controls.Add(this.cmbBoatType);
      this.Name = "Form1";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      ((System.ComponentModel.ISupportInitialize)(this.numAdults)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numChildren)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ComboBox cmbBoatType;
    private System.Windows.Forms.Button btnCheck;
    private System.Windows.Forms.Button btnReserve;
    private System.Windows.Forms.Button btnReset;
    private System.Windows.Forms.Button btnExit;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label lblStatus;
    private System.Windows.Forms.NumericUpDown numAdults;
    private System.Windows.Forms.NumericUpDown numChildren;
  }
}

