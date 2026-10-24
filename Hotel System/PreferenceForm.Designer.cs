using System;
using System.Drawing;
using System.Windows.Forms;

namespace Hotel_System
{
    partial class PreferenceForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblKey;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblKey = new System.Windows.Forms.Label();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.lblValue = new System.Windows.Forms.Label();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(105, 20);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Add Preference";

            // lblKey
            this.lblKey.AutoSize = true;
            this.lblKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblKey.Location = new System.Drawing.Point(12, 45);
            this.lblKey.Name = "lblKey";
            this.lblKey.Size = new System.Drawing.Size(68, 17);
            this.lblKey.TabIndex = 1;
            this.lblKey.Text = "Key:";

            // txtKey
            this.txtKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtKey.Location = new System.Drawing.Point(12, 65);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(200, 23);
            this.txtKey.TabIndex = 2;

            // lblValue
            this.lblValue.AutoSize = true;
            this.lblValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblValue.Location = new System.Drawing.Point(12, 95);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(51, 17);
            this.lblValue.TabIndex = 3;
            this.lblValue.Text = "Value:";

            // txtValue
            this.txtValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtValue.Location = new System.Drawing.Point(12, 115);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(200, 23);
            this.txtValue.TabIndex = 4;

            // btnOK
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnOK.Location = new System.Drawing.Point(60, 155);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(80, 30);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);

            // btnCancel
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnCancel.Location = new System.Drawing.Point(150, 155);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 30);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 200);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.lblValue);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.lblKey);
            this.Controls.Add(this.lblTitle);
            this.Name = "PreferenceForm";
            this.Text = "Add Preference";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}