
namespace Metric_Unit_Converter
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
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonFToC = new System.Windows.Forms.Button();
            this.inputValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.outputValue = new System.Windows.Forms.TextBox();
            this.buttonCToF = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonFtoM = new System.Windows.Forms.Button();
            this.buttonMToF = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(160, 470);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonFToC
            // 
            this.buttonFToC.Location = new System.Drawing.Point(41, 121);
            this.buttonFToC.Name = "buttonFToC";
            this.buttonFToC.Size = new System.Drawing.Size(225, 28);
            this.buttonFToC.TabIndex = 2;
            this.buttonFToC.Text = "Fahrenheit to Celsius";
            this.buttonFToC.UseVisualStyleBackColor = true;
            this.buttonFToC.Click += new System.EventHandler(this.buttonFToC_Click);
            // 
            // inputValue
            // 
            this.inputValue.Location = new System.Drawing.Point(41, 74);
            this.inputValue.Name = "inputValue";
            this.inputValue.Size = new System.Drawing.Size(125, 20);
            this.inputValue.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter Value To Convert:";
            // 
            // outputValue
            // 
            this.outputValue.Location = new System.Drawing.Point(41, 399);
            this.outputValue.Name = "outputValue";
            this.outputValue.ReadOnly = true;
            this.outputValue.Size = new System.Drawing.Size(225, 20);
            this.outputValue.TabIndex = 6;
            // 
            // buttonCToF
            // 
            this.buttonCToF.Location = new System.Drawing.Point(41, 169);
            this.buttonCToF.Name = "buttonCToF";
            this.buttonCToF.Size = new System.Drawing.Size(225, 30);
            this.buttonCToF.TabIndex = 7;
            this.buttonCToF.Text = "Celsius to Fahrenheit";
            this.buttonCToF.UseVisualStyleBackColor = true;
            this.buttonCToF.Click += new System.EventHandler(this.buttonCToF_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(41, 470);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 8;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonFtoM
            // 
            this.buttonFtoM.Location = new System.Drawing.Point(41, 218);
            this.buttonFtoM.Name = "buttonFtoM";
            this.buttonFtoM.Size = new System.Drawing.Size(225, 23);
            this.buttonFtoM.TabIndex = 9;
            this.buttonFtoM.Text = "Feet to Meters";
            this.buttonFtoM.UseVisualStyleBackColor = true;
            this.buttonFtoM.Click += new System.EventHandler(this.buttonFtoM_Click);
            // 
            // buttonMToF
            // 
            this.buttonMToF.Location = new System.Drawing.Point(41, 267);
            this.buttonMToF.Name = "buttonMToF";
            this.buttonMToF.Size = new System.Drawing.Size(225, 23);
            this.buttonMToF.TabIndex = 10;
            this.buttonMToF.Text = "Meters to Feet";
            this.buttonMToF.UseVisualStyleBackColor = true;
            this.buttonMToF.Click += new System.EventHandler(this.buttonMToF_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 574);
            this.Controls.Add(this.buttonMToF);
            this.Controls.Add(this.buttonFtoM);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonCToF);
            this.Controls.Add(this.outputValue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputValue);
            this.Controls.Add(this.buttonFToC);
            this.Controls.Add(this.buttonClose);
            this.Name = "Form1";
            this.Text = "Metric Unit Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonFToC;
        private System.Windows.Forms.TextBox inputValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox outputValue;
        private System.Windows.Forms.Button buttonCToF;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonFtoM;
        private System.Windows.Forms.Button buttonMToF;
    }
}

