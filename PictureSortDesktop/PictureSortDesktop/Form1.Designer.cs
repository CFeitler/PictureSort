namespace PictureSortDesktop
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
      this.picture = new System.Windows.Forms.PictureBox();
      this.buttonOpenFolder = new System.Windows.Forms.Button();
      this.buttonClose = new System.Windows.Forms.Button();
      this.buttonUp = new System.Windows.Forms.Button();
      this.buttonRight = new System.Windows.Forms.Button();
      this.buttonLeft = new System.Windows.Forms.Button();
      this.buttonDown = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
      this.SuspendLayout();
      // 
      // picture
      // 
      this.picture.Location = new System.Drawing.Point(163, 159);
      this.picture.Name = "picture";
      this.picture.Size = new System.Drawing.Size(421, 277);
      this.picture.TabIndex = 0;
      this.picture.TabStop = false;
      // 
      // buttonOpenFolder
      // 
      this.buttonOpenFolder.Location = new System.Drawing.Point(12, 12);
      this.buttonOpenFolder.Name = "buttonOpenFolder";
      this.buttonOpenFolder.Size = new System.Drawing.Size(145, 60);
      this.buttonOpenFolder.TabIndex = 1;
      this.buttonOpenFolder.Text = "Open";
      this.buttonOpenFolder.UseVisualStyleBackColor = true;
      // 
      // buttonClose
      // 
      this.buttonClose.Location = new System.Drawing.Point(590, 531);
      this.buttonClose.Name = "buttonClose";
      this.buttonClose.Size = new System.Drawing.Size(145, 60);
      this.buttonClose.TabIndex = 2;
      this.buttonClose.Text = "Close";
      this.buttonClose.UseVisualStyleBackColor = true;
      // 
      // buttonUp
      // 
      this.buttonUp.Location = new System.Drawing.Point(300, 60);
      this.buttonUp.Name = "buttonUp";
      this.buttonUp.Size = new System.Drawing.Size(145, 60);
      this.buttonUp.TabIndex = 3;
      this.buttonUp.Text = "Up";
      this.buttonUp.UseVisualStyleBackColor = true;
      // 
      // buttonRight
      // 
      this.buttonRight.Location = new System.Drawing.Point(590, 273);
      this.buttonRight.Name = "buttonRight";
      this.buttonRight.Size = new System.Drawing.Size(145, 60);
      this.buttonRight.TabIndex = 4;
      this.buttonRight.Text = "Left";
      this.buttonRight.UseVisualStyleBackColor = true;
      // 
      // buttonLeft
      // 
      this.buttonLeft.Location = new System.Drawing.Point(12, 273);
      this.buttonLeft.Name = "buttonLeft";
      this.buttonLeft.Size = new System.Drawing.Size(145, 60);
      this.buttonLeft.TabIndex = 5;
      this.buttonLeft.Text = "Right";
      this.buttonLeft.UseVisualStyleBackColor = true;
      // 
      // buttonDown
      // 
      this.buttonDown.Location = new System.Drawing.Point(300, 487);
      this.buttonDown.Name = "buttonDown";
      this.buttonDown.Size = new System.Drawing.Size(145, 60);
      this.buttonDown.TabIndex = 6;
      this.buttonDown.Text = "Down";
      this.buttonDown.UseVisualStyleBackColor = true;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(747, 603);
      this.Controls.Add(this.buttonDown);
      this.Controls.Add(this.buttonLeft);
      this.Controls.Add(this.buttonRight);
      this.Controls.Add(this.buttonUp);
      this.Controls.Add(this.buttonClose);
      this.Controls.Add(this.buttonOpenFolder);
      this.Controls.Add(this.picture);
      this.Name = "Form1";
      this.Text = "Picture sort";
      ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.PictureBox picture;
    private System.Windows.Forms.Button buttonOpenFolder;
    private System.Windows.Forms.Button buttonClose;
    private System.Windows.Forms.Button buttonUp;
    private System.Windows.Forms.Button buttonRight;
    private System.Windows.Forms.Button buttonLeft;
    private System.Windows.Forms.Button buttonDown;
  }
}

