namespace UMS
{
    partial class Login_Page
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
            label1=new Label();
            label2=new Label();
            label3=new Label();
            textBox1=new TextBox();
            textBox2=new TextBox();
            button_Cancel=new Button();
            button_Login=new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Font=new Font("Segoe UI", 20F, FontStyle.Underline, GraphicsUnit.Point);
            label1.Location=new Point(152, 19);
            label1.Name="label1";
            label1.Size=new Size(194, 37);
            label1.TabIndex=0;
            label1.Text="Account Login ";
            label1.Click+=label1_Click;
            // 
            // label2
            // 
            label2.AutoSize=true;
            label2.Font=new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location=new Point(65, 134);
            label2.Name="label2";
            label2.Size=new Size(103, 28);
            label2.TabIndex=1;
            label2.Text="Username:";
            // 
            // label3
            // 
            label3.AutoSize=true;
            label3.Font=new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location=new Point(65, 176);
            label3.Name="label3";
            label3.Size=new Size(102, 28);
            label3.TabIndex=2;
            label3.Text="Password: ";
            // 
            // textBox1
            // 
            textBox1.Location=new Point(183, 142);
            textBox1.Name="textBox1";
            textBox1.Size=new Size(244, 23);
            textBox1.TabIndex=3;
            // 
            // textBox2
            // 
            textBox2.Location=new Point(183, 184);
            textBox2.Name="textBox2";
            textBox2.Size=new Size(244, 23);
            textBox2.TabIndex=4;
            textBox2.UseSystemPasswordChar=true;
            // 
            // button_Cancel
            // 
            button_Cancel.BackColor=Color.IndianRed;
            button_Cancel.Font=new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            button_Cancel.Location=new Point(183, 240);
            button_Cancel.Name="button_Cancel";
            button_Cancel.Size=new Size(115, 37);
            button_Cancel.TabIndex=5;
            button_Cancel.Text="Cancel";
            button_Cancel.UseVisualStyleBackColor=false;
            button_Cancel.Click+=button_Cancel_Click;
            // 
            // button_Login
            // 
            button_Login.BackColor=Color.LimeGreen;
            button_Login.Font=new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            button_Login.Location=new Point(312, 240);
            button_Login.Name="button_Login";
            button_Login.Size=new Size(115, 37);
            button_Login.TabIndex=6;
            button_Login.Text="Login";
            button_Login.UseVisualStyleBackColor=false;
            button_Login.Click+=button_Login_Click;
            // 
            // Login_Page
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(559, 406);
            Controls.Add(button_Login);
            Controls.Add(button_Cancel);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name="Login_Page";
            StartPosition=FormStartPosition.CenterScreen;
            Text="Login_Page";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button_Cancel;
        private Button button_Login;
    }
}