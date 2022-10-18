
namespace ArcInfrastructure
{
    partial class frmShape
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
            this.cmbShape = new System.Windows.Forms.ComboBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblOne = new System.Windows.Forms.Label();
            this.txtOne = new System.Windows.Forms.TextBox();
            this.txtTwo = new System.Windows.Forms.TextBox();
            this.lblTwo = new System.Windows.Forms.Label();
            this.lblSelectShape = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbShape
            // 
            this.cmbShape.FormattingEnabled = true;
            this.cmbShape.Location = new System.Drawing.Point(89, 49);
            this.cmbShape.Name = "cmbShape";
            this.cmbShape.Size = new System.Drawing.Size(121, 23);
            this.cmbShape.TabIndex = 0;
            this.cmbShape.SelectedValueChanged += new System.EventHandler(this.cmbShape_SelectedValueChanged);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(89, 153);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(109, 23);
            this.btnCalculate.TabIndex = 1;
            this.btnCalculate.Text = "Calculate Area";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblOne
            // 
            this.lblOne.AutoSize = true;
            this.lblOne.Location = new System.Drawing.Point(81, 88);
            this.lblOne.Name = "lblOne";
            this.lblOne.Size = new System.Drawing.Size(38, 15);
            this.lblOne.TabIndex = 2;
            this.lblOne.Text = "label1";
            // 
            // txtOne
            // 
            this.txtOne.Location = new System.Drawing.Point(125, 85);
            this.txtOne.Name = "txtOne";
            this.txtOne.Size = new System.Drawing.Size(100, 23);
            this.txtOne.TabIndex = 3;
            // 
            // txtTwo
            // 
            this.txtTwo.Location = new System.Drawing.Point(125, 114);
            this.txtTwo.Name = "txtTwo";
            this.txtTwo.Size = new System.Drawing.Size(100, 23);
            this.txtTwo.TabIndex = 5;
            // 
            // lblTwo
            // 
            this.lblTwo.AutoSize = true;
            this.lblTwo.Location = new System.Drawing.Point(81, 117);
            this.lblTwo.Name = "lblTwo";
            this.lblTwo.Size = new System.Drawing.Size(38, 15);
            this.lblTwo.TabIndex = 4;
            this.lblTwo.Text = "label1";
            // 
            // lblSelectShape
            // 
            this.lblSelectShape.AutoSize = true;
            this.lblSelectShape.Location = new System.Drawing.Point(89, 22);
            this.lblSelectShape.Name = "lblSelectShape";
            this.lblSelectShape.Size = new System.Drawing.Size(73, 15);
            this.lblSelectShape.TabIndex = 8;
            this.lblSelectShape.Text = "Select Shape";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(89, 197);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(0, 15);
            this.lblArea.TabIndex = 9;
            // 
            // frmShape
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.lblSelectShape);
            this.Controls.Add(this.txtTwo);
            this.Controls.Add(this.lblTwo);
            this.Controls.Add(this.txtOne);
            this.Controls.Add(this.lblOne);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.cmbShape);
            this.Name = "frmShape";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbShape;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblOne;
        private System.Windows.Forms.TextBox txtOne;
        private System.Windows.Forms.TextBox txtTwo;
        private System.Windows.Forms.Label lblTwo;
        private System.Windows.Forms.Label lblSelectShape;
        private System.Windows.Forms.Label lblArea;
    }
}

