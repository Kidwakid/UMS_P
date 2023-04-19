namespace UMS
{
    partial class AddStudentForm
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
            components=new System.ComponentModel.Container();
            label1FN=new Label();
            label1LN=new Label();
            label1BD=new Label();
            labelG=new Label();
            labelPhone=new Label();
            label1Addr=new Label();
            label1Pict=new Label();
            textBoxFname=new TextBox();
            textBoxLname=new TextBox();
            textBoxPhone=new TextBox();
            dateTimePicker1=new DateTimePicker();
            groupBox1=new GroupBox();
            radioButtonM=new RadioButton();
            radioButtonF=new RadioButton();
            textBoxAddr=new TextBox();
            contextMenuStrip1=new ContextMenuStrip(components);
            pictureBoxStudentImage=new PictureBox();
            buttonUploadImage=new Button();
            buttonAdd=new Button();
            buttonCancel=new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxStudentImage).BeginInit();
            SuspendLayout();
            // 
            // label1FN
            // 
            label1FN.AutoSize=true;
            label1FN.Font=new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1FN.Location=new Point(51, 50);
            label1FN.Name="label1FN";
            label1FN.Size=new Size(89, 21);
            label1FN.TabIndex=0;
            label1FN.Text="First Name:";
            // 
            // label1LN
            // 
            label1LN.AutoSize=true;
            label1LN.Font=new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1LN.Location=new Point(51, 86);
            label1LN.Name="label1LN";
            label1LN.Size=new Size(87, 21);
            label1LN.TabIndex=1;
            label1LN.Text="Last Name:";
            // 
            // label1BD
            // 
            label1BD.AutoSize=true;
            label1BD.Font=new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1BD.Location=new Point(59, 143);
            label1BD.Name="label1BD";
            label1BD.Size=new Size(78, 21);
            label1BD.TabIndex=2;
            label1BD.Text="BirthDate:";
            // 
            // labelG
            // 
            labelG.AutoSize=true;
            labelG.Font=new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelG.Location=new Point(74, 184);
            labelG.Name="labelG";
            labelG.Size=new Size(64, 21);
            labelG.TabIndex=3;
            labelG.Text="Gender:";
            // 
            // labelPhone
            // 
            labelPhone.AutoSize=true;
            labelPhone.Font=new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelPhone.Location=new Point(74, 234);
            labelPhone.Name="labelPhone";
            labelPhone.Size=new Size(57, 21);
            labelPhone.TabIndex=4;
            labelPhone.Text="Phone:";
            // 
            // label1Addr
            // 
            label1Addr.AutoSize=true;
            label1Addr.Font=new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1Addr.Location=new Point(74, 281);
            label1Addr.Name="label1Addr";
            label1Addr.Size=new Size(69, 21);
            label1Addr.TabIndex=5;
            label1Addr.Text="Address:";
            // 
            // label1Pict
            // 
            label1Pict.AutoSize=true;
            label1Pict.Font=new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1Pict.Location=new Point(530, 26);
            label1Pict.Name="label1Pict";
            label1Pict.Size=new Size(61, 21);
            label1Pict.TabIndex=6;
            label1Pict.Text="Picture:";
            // 
            // textBoxFname
            // 
            textBoxFname.Location=new Point(146, 52);
            textBoxFname.Name="textBoxFname";
            textBoxFname.Size=new Size(327, 23);
            textBoxFname.TabIndex=7;
            // 
            // textBoxLname
            // 
            textBoxLname.Location=new Point(146, 88);
            textBoxLname.Name="textBoxLname";
            textBoxLname.Size=new Size(327, 23);
            textBoxLname.TabIndex=8;
            // 
            // textBoxPhone
            // 
            textBoxPhone.Location=new Point(146, 236);
            textBoxPhone.Name="textBoxPhone";
            textBoxPhone.Size=new Size(327, 23);
            textBoxPhone.TabIndex=9;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location=new Point(145, 143);
            dateTimePicker1.Name="dateTimePicker1";
            dateTimePicker1.Size=new Size(200, 23);
            dateTimePicker1.TabIndex=10;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButtonF);
            groupBox1.Controls.Add(radioButtonM);
            groupBox1.Location=new Point(148, 184);
            groupBox1.Name="groupBox1";
            groupBox1.Size=new Size(298, 36);
            groupBox1.TabIndex=11;
            groupBox1.TabStop=false;
            groupBox1.Text="groupBox1";
            // 
            // radioButtonM
            // 
            radioButtonM.AutoSize=true;
            radioButtonM.Location=new Point(15, 11);
            radioButtonM.Name="radioButtonM";
            radioButtonM.Size=new Size(51, 19);
            radioButtonM.TabIndex=0;
            radioButtonM.TabStop=true;
            radioButtonM.Text="Male";
            radioButtonM.UseVisualStyleBackColor=true;
            // 
            // radioButtonF
            // 
            radioButtonF.AutoSize=true;
            radioButtonF.Location=new Point(124, 9);
            radioButtonF.Name="radioButtonF";
            radioButtonF.Size=new Size(63, 19);
            radioButtonF.TabIndex=1;
            radioButtonF.TabStop=true;
            radioButtonF.Text="Female";
            radioButtonF.UseVisualStyleBackColor=true;
            // 
            // textBoxAddr
            // 
            textBoxAddr.Location=new Point(148, 283);
            textBoxAddr.Multiline=true;
            textBoxAddr.Name="textBoxAddr";
            textBoxAddr.Size=new Size(327, 94);
            textBoxAddr.TabIndex=12;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name="contextMenuStrip1";
            contextMenuStrip1.Size=new Size(61, 4);
            // 
            // pictureBoxStudentImage
            // 
            pictureBoxStudentImage.Location=new Point(530, 50);
            pictureBoxStudentImage.Name="pictureBoxStudentImage";
            pictureBoxStudentImage.Size=new Size(258, 252);
            pictureBoxStudentImage.TabIndex=14;
            pictureBoxStudentImage.TabStop=false;
            // 
            // buttonUploadImage
            // 
            buttonUploadImage.Location=new Point(594, 308);
            buttonUploadImage.Name="buttonUploadImage";
            buttonUploadImage.Size=new Size(127, 23);
            buttonUploadImage.TabIndex=15;
            buttonUploadImage.Text="Upload Image";
            buttonUploadImage.UseVisualStyleBackColor=true;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor=Color.YellowGreen;
            buttonAdd.Font=new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAdd.Location=new Point(619, 469);
            buttonAdd.Name="buttonAdd";
            buttonAdd.Size=new Size(138, 53);
            buttonAdd.TabIndex=16;
            buttonAdd.Text="Add";
            buttonAdd.UseVisualStyleBackColor=false;
            // 
            // buttonCancel
            // 
            buttonCancel.BackColor=Color.IndianRed;
            buttonCancel.Font=new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCancel.Location=new Point(442, 469);
            buttonCancel.Name="buttonCancel";
            buttonCancel.Size=new Size(138, 53);
            buttonCancel.TabIndex=17;
            buttonCancel.Text="Cancel";
            buttonCancel.UseVisualStyleBackColor=false;
            // 
            // AddStudentForm
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(800, 546);
            Controls.Add(buttonCancel);
            Controls.Add(buttonAdd);
            Controls.Add(buttonUploadImage);
            Controls.Add(pictureBoxStudentImage);
            Controls.Add(textBoxAddr);
            Controls.Add(groupBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBoxPhone);
            Controls.Add(textBoxLname);
            Controls.Add(textBoxFname);
            Controls.Add(label1Pict);
            Controls.Add(label1Addr);
            Controls.Add(labelPhone);
            Controls.Add(labelG);
            Controls.Add(label1BD);
            Controls.Add(label1LN);
            Controls.Add(label1FN);
            Name="AddStudentForm";
            Text="AddStudentForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxStudentImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1FN;
        private Label label1LN;
        private Label label1BD;
        private Label labelG;
        private Label labelPhone;
        private Label label1Addr;
        private Label label1Pict;
        private TextBox textBoxFname;
        private TextBox textBoxLname;
        private TextBox textBoxPhone;
        private DateTimePicker dateTimePicker1;
        private GroupBox groupBox1;
        private RadioButton radioButtonF;
        private RadioButton radioButtonM;
        private TextBox textBoxAddr;
        private ContextMenuStrip contextMenuStrip1;
        private PictureBox pictureBoxStudentImage;
        private Button buttonUploadImage;
        private Button buttonAdd;
        private Button buttonCancel;
    }
}