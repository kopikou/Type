namespace Type
{
    partial class Form1
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
            txtNumer1 = new TextBox();
            txtDenom1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtDenom2 = new TextBox();
            txtNumer2 = new TextBox();
            cmbOperator = new ComboBox();
            txtResult = new TextBox();
            SuspendLayout();
            // 
            // txtNumer1
            // 
            txtNumer1.Location = new Point(90, 25);
            txtNumer1.Name = "txtNumer1";
            txtNumer1.Size = new Size(46, 27);
            txtNumer1.TabIndex = 0;
            txtNumer1.TextChanged += onValueChanged;
            // 
            // txtDenom1
            // 
            txtDenom1.Location = new Point(163, 25);
            txtDenom1.Name = "txtDenom1";
            txtDenom1.Size = new Size(46, 27);
            txtDenom1.TabIndex = 1;
            txtDenom1.TextChanged += onValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(142, 28);
            label1.Name = "label1";
            label1.Size = new Size(15, 20);
            label1.TabIndex = 2;
            label1.Text = "/";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(142, 82);
            label2.Name = "label2";
            label2.Size = new Size(15, 20);
            label2.TabIndex = 5;
            label2.Text = "/";
            // 
            // txtDenom2
            // 
            txtDenom2.Location = new Point(163, 79);
            txtDenom2.Name = "txtDenom2";
            txtDenom2.Size = new Size(46, 27);
            txtDenom2.TabIndex = 4;
            txtDenom2.TextChanged += onValueChanged;
            // 
            // txtNumer2
            // 
            txtNumer2.Location = new Point(90, 79);
            txtNumer2.Name = "txtNumer2";
            txtNumer2.Size = new Size(46, 27);
            txtNumer2.TabIndex = 3;
            txtNumer2.TextChanged += onValueChanged;
            // 
            // cmbOperator
            // 
            cmbOperator.FormattingEnabled = true;
            cmbOperator.Location = new Point(12, 53);
            cmbOperator.Name = "cmbOperator";
            cmbOperator.Size = new Size(65, 28);
            cmbOperator.TabIndex = 6;
            cmbOperator.SelectedIndexChanged += onValueChanged;
            // 
            // txtResult
            // 
            txtResult.Location = new Point(12, 128);
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(197, 27);
            txtResult.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(224, 173);
            Controls.Add(txtResult);
            Controls.Add(cmbOperator);
            Controls.Add(label2);
            Controls.Add(txtDenom2);
            Controls.Add(txtNumer2);
            Controls.Add(label1);
            Controls.Add(txtDenom1);
            Controls.Add(txtNumer1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNumer1;
        private TextBox txtDenom1;
        private Label label1;
        private Label label2;
        private TextBox txtDenom2;
        private TextBox txtNumer2;
        private ComboBox cmbOperator;
        private TextBox txtResult;
    }
}
