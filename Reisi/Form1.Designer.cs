namespace Reisi
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
            btnOpenForm = new Button();
            txtDestination = new Label();
            txtResult = new Label();
            btnExit = new Button();
            SuspendLayout();
            // 
            // btnOpenForm
            // 
            btnOpenForm.Location = new Point(88, 77);
            btnOpenForm.Name = "btnOpenForm";
            btnOpenForm.Size = new Size(75, 23);
            btnOpenForm.TabIndex = 0;
            btnOpenForm.Text = "Начать";
            btnOpenForm.UseVisualStyleBackColor = true;
            btnOpenForm.Click += btnOpenForm_Click;
            // 
            // txtDestination
            // 
            txtDestination.AutoSize = true;
            txtDestination.Location = new Point(66, 59);
            txtDestination.Name = "txtDestination";
            txtDestination.Size = new Size(38, 15);
            txtDestination.TabIndex = 1;
            txtDestination.Text = "label1";
            txtDestination.Visible = false;
            txtDestination.Click += txtDestination_Click;
            // 
            // txtResult
            // 
            txtResult.AutoSize = true;
            txtResult.Location = new Point(47, 44);
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(168, 30);
            txtResult.TabIndex = 2;
            txtResult.Text = "     Ищите куда полететь?\r\nНажмите ниже чтобы начать";
            // 
            // btnExit
            // 
            btnExit.Location = new Point(192, 143);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 3;
            btnExit.Text = "Заново";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(268, 166);
            Controls.Add(btnExit);
            Controls.Add(txtResult);
            Controls.Add(txtDestination);
            Controls.Add(btnOpenForm);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOpenForm;
        private Label txtResult;
        public Label txtDestination;
        private Button btnExit;
    }
}