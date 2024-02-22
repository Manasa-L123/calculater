namespace calculater
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
            label1 = new Label();
            label2 = new Label();
            textnum1 = new TextBox();
            textnum2 = new TextBox();
            btnAdd = new Button();
            btnSub = new Button();
            btnmul = new Button();
            btndiv = new Button();
            lblout = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(105, 55);
            label1.Name = "label1";
            label1.Size = new Size(106, 15);
            label1.TabIndex = 0;
            label1.Text = "Enter First Number";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(109, 110);
            label2.Name = "label2";
            label2.Size = new Size(123, 15);
            label2.TabIndex = 1;
            label2.Text = "Enter Second Number";
            label2.Click += label2_Click;
            // 
            // textnum1
            // 
            textnum1.ImeMode = ImeMode.On;
            textnum1.Location = new Point(242, 52);
            textnum1.Name = "textnum1";
            textnum1.Size = new Size(100, 23);
            textnum1.TabIndex = 2;
           
            // 
            // textnum2
            // 
            textnum2.Location = new Point(242, 102);
            textnum2.Name = "textnum2";
            textnum2.Size = new Size(100, 23);
            textnum2.TabIndex = 3;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(118, 166);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSub
            // 
            btnSub.Location = new Point(242, 166);
            btnSub.Name = "btnSub";
            btnSub.Size = new Size(75, 23);
            btnSub.TabIndex = 5;
            btnSub.Text = "Subtract";
            btnSub.UseVisualStyleBackColor = true;
            btnSub.Click += btnSub_Click;
            // 
            // btnmul
            // 
            btnmul.Location = new Point(118, 225);
            btnmul.Name = "btnmul";
            btnmul.Size = new Size(75, 23);
            btnmul.TabIndex = 6;
            btnmul.Text = "Multiply";
            btnmul.UseVisualStyleBackColor = true;
            btnmul.Click += btnmul_Click;
            // 
            // btndiv
            // 
            btndiv.Location = new Point(242, 225);
            btndiv.Name = "btndiv";
            btndiv.Size = new Size(75, 23);
            btndiv.TabIndex = 7;
            btndiv.Text = "Divide";
            btndiv.UseVisualStyleBackColor = true;
            btndiv.Click += btndiv_Click;
            // 
            // lblout
            // 
            lblout.AutoSize = true;
            lblout.Location = new Point(105, 293);
            lblout.Name = "lblout";
            lblout.Size = new Size(38, 15);
            lblout.TabIndex = 8;
            lblout.Text = "Answer";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblout);
            Controls.Add(btndiv);
            Controls.Add(btnmul);
            Controls.Add(btnSub);
            Controls.Add(btnAdd);
            Controls.Add(textnum2);
            Controls.Add(textnum1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnAdd;
        private Button btnSub;
        private Button btnmul;
        private Button btndiv;
        private Label lblout;
        public TextBox textnum1;
        public TextBox textnum2;
    }
}
