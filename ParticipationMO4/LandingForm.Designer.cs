namespace ParticipationMO4
{
  partial class LandingForm
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
      this.BtnLocalPhoneNums = new System.Windows.Forms.Button();
      this.BtnImportedNums = new System.Windows.Forms.Button();
      this.BtnClose = new System.Windows.Forms.Button();
      this.BtnOnlineNums = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // BtnLocalPhoneNums
      // 
      this.BtnLocalPhoneNums.Location = new System.Drawing.Point(39, 38);
      this.BtnLocalPhoneNums.Name = "BtnLocalPhoneNums";
      this.BtnLocalPhoneNums.Size = new System.Drawing.Size(194, 117);
      this.BtnLocalPhoneNums.TabIndex = 0;
      this.BtnLocalPhoneNums.Text = "&Local Phone Numbers";
      this.BtnLocalPhoneNums.UseVisualStyleBackColor = true;
      this.BtnLocalPhoneNums.Click += new System.EventHandler(this.BtnLocalPhoneNums_Click);
      // 
      // BtnImportedNums
      // 
      this.BtnImportedNums.Location = new System.Drawing.Point(266, 38);
      this.BtnImportedNums.Name = "BtnImportedNums";
      this.BtnImportedNums.Size = new System.Drawing.Size(194, 117);
      this.BtnImportedNums.TabIndex = 0;
      this.BtnImportedNums.Text = "&Imported Phone Numbers";
      this.BtnImportedNums.UseVisualStyleBackColor = true;
      this.BtnImportedNums.Click += new System.EventHandler(this.BtnImportedNums_Click);
      // 
      // BtnClose
      // 
      this.BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.BtnClose.Location = new System.Drawing.Point(266, 185);
      this.BtnClose.Name = "BtnClose";
      this.BtnClose.Size = new System.Drawing.Size(194, 117);
      this.BtnClose.TabIndex = 0;
      this.BtnClose.Text = "Clo&se";
      this.BtnClose.UseVisualStyleBackColor = true;
      this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
      // 
      // BtnOnlineNums
      // 
      this.BtnOnlineNums.Location = new System.Drawing.Point(39, 185);
      this.BtnOnlineNums.Name = "BtnOnlineNums";
      this.BtnOnlineNums.Size = new System.Drawing.Size(194, 117);
      this.BtnOnlineNums.TabIndex = 0;
      this.BtnOnlineNums.Text = "&Online Phone Numbers";
      this.BtnOnlineNums.UseVisualStyleBackColor = true;
      this.BtnOnlineNums.Click += new System.EventHandler(this.BtnOnlineNums_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.BtnClose;
      this.ClientSize = new System.Drawing.Size(503, 332);
      this.Controls.Add(this.BtnOnlineNums);
      this.Controls.Add(this.BtnClose);
      this.Controls.Add(this.BtnImportedNums);
      this.Controls.Add(this.BtnLocalPhoneNums);
      this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
      this.Name = "Form1";
      this.Text = "Kodey\'s Phone Numbers";
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button BtnLocalPhoneNums;
    private System.Windows.Forms.Button BtnImportedNums;
    private System.Windows.Forms.Button BtnClose;
    private System.Windows.Forms.Button BtnOnlineNums;
  }
}

