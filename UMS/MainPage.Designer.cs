namespace UMS
{
    partial class MainPage
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
            menuStrip1=new MenuStrip();
            studentToolStripMenuItem=new ToolStripMenuItem();
            courseToolStripMenuItem=new ToolStripMenuItem();
            scoreToolStripMenuItem=new ToolStripMenuItem();
            addNewStudentToolStripMenuItem=new ToolStripMenuItem();
            toolStripMenuItem1=new ToolStripSeparator();
            studentListToolStripMenuItem=new ToolStripMenuItem();
            toolStripMenuItem2=new ToolStripSeparator();
            staticsToolStripMenuItem=new ToolStripMenuItem();
            toolStripMenuItem3=new ToolStripSeparator();
            editRemoveToolStripMenuItem=new ToolStripMenuItem();
            toolStripMenuItem4=new ToolStripSeparator();
            manageStudentsFormToolStripMenuItem=new ToolStripMenuItem();
            toolStripMenuItem5=new ToolStripSeparator();
            printToolStripMenuItem=new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Font=new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            menuStrip1.Items.AddRange(new ToolStripItem[] { studentToolStripMenuItem, courseToolStripMenuItem, scoreToolStripMenuItem });
            menuStrip1.Location=new Point(0, 0);
            menuStrip1.Name="menuStrip1";
            menuStrip1.Size=new Size(1190, 29);
            menuStrip1.TabIndex=1;
            menuStrip1.Text="menuStrip1";
            // 
            // studentToolStripMenuItem
            // 
            studentToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addNewStudentToolStripMenuItem, toolStripMenuItem1, studentListToolStripMenuItem, toolStripMenuItem2, staticsToolStripMenuItem, toolStripMenuItem3, editRemoveToolStripMenuItem, toolStripMenuItem4, manageStudentsFormToolStripMenuItem, toolStripMenuItem5, printToolStripMenuItem });
            studentToolStripMenuItem.Name="studentToolStripMenuItem";
            studentToolStripMenuItem.Size=new Size(75, 25);
            studentToolStripMenuItem.Text="Student";
            // 
            // courseToolStripMenuItem
            // 
            courseToolStripMenuItem.Name="courseToolStripMenuItem";
            courseToolStripMenuItem.Size=new Size(71, 25);
            courseToolStripMenuItem.Text="Course";
            // 
            // scoreToolStripMenuItem
            // 
            scoreToolStripMenuItem.Name="scoreToolStripMenuItem";
            scoreToolStripMenuItem.Size=new Size(61, 25);
            scoreToolStripMenuItem.Text="Score";
            // 
            // addNewStudentToolStripMenuItem
            // 
            addNewStudentToolStripMenuItem.Name="addNewStudentToolStripMenuItem";
            addNewStudentToolStripMenuItem.Size=new Size(241, 26);
            addNewStudentToolStripMenuItem.Text="Add New Student";
            addNewStudentToolStripMenuItem.Click+=addNewStudentToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name="toolStripMenuItem1";
            toolStripMenuItem1.Size=new Size(238, 6);
            // 
            // studentListToolStripMenuItem
            // 
            studentListToolStripMenuItem.Name="studentListToolStripMenuItem";
            studentListToolStripMenuItem.Size=new Size(241, 26);
            studentListToolStripMenuItem.Text="Student List";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name="toolStripMenuItem2";
            toolStripMenuItem2.Size=new Size(238, 6);
            // 
            // staticsToolStripMenuItem
            // 
            staticsToolStripMenuItem.Name="staticsToolStripMenuItem";
            staticsToolStripMenuItem.Size=new Size(241, 26);
            staticsToolStripMenuItem.Text="Statics";
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name="toolStripMenuItem3";
            toolStripMenuItem3.Size=new Size(238, 6);
            // 
            // editRemoveToolStripMenuItem
            // 
            editRemoveToolStripMenuItem.Name="editRemoveToolStripMenuItem";
            editRemoveToolStripMenuItem.Size=new Size(241, 26);
            editRemoveToolStripMenuItem.Text="Edit/Remove";
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.Name="toolStripMenuItem4";
            toolStripMenuItem4.Size=new Size(238, 6);
            // 
            // manageStudentsFormToolStripMenuItem
            // 
            manageStudentsFormToolStripMenuItem.Name="manageStudentsFormToolStripMenuItem";
            manageStudentsFormToolStripMenuItem.Size=new Size(241, 26);
            manageStudentsFormToolStripMenuItem.Text="Manage Students Form";
            // 
            // toolStripMenuItem5
            // 
            toolStripMenuItem5.Name="toolStripMenuItem5";
            toolStripMenuItem5.Size=new Size(238, 6);
            // 
            // printToolStripMenuItem
            // 
            printToolStripMenuItem.Name="printToolStripMenuItem";
            printToolStripMenuItem.Size=new Size(241, 26);
            printToolStripMenuItem.Text="Print";
            // 
            // MainPage
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(1190, 636);
            Controls.Add(menuStrip1);
            IsMdiContainer=true;
            MainMenuStrip=menuStrip1;
            Name="MainPage";
            Text="MainPage";
            WindowState=FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem studentToolStripMenuItem;
        private ToolStripMenuItem addNewStudentToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem studentListToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripMenuItem staticsToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem3;
        private ToolStripMenuItem editRemoveToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem4;
        private ToolStripMenuItem manageStudentsFormToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem5;
        private ToolStripMenuItem printToolStripMenuItem;
        private ToolStripMenuItem courseToolStripMenuItem;
        private ToolStripMenuItem scoreToolStripMenuItem;
    }
}