namespace MyToDoApp
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
            TaskTbx = new TextBox();
            AddTaskBtn = new Button();
            TaskLbx = new ListBox();
            SuspendLayout();
            // 
            // TaskTbx
            // 
            TaskTbx.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            TaskTbx.Location = new Point(15, 56);
            TaskTbx.Margin = new Padding(6);
            TaskTbx.Name = "TaskTbx";
            TaskTbx.Size = new Size(363, 43);
            TaskTbx.TabIndex = 0;
            // 
            // AddTaskBtn
            // 
            AddTaskBtn.Location = new Point(412, 56);
            AddTaskBtn.Name = "AddTaskBtn";
            AddTaskBtn.Size = new Size(145, 43);
            AddTaskBtn.TabIndex = 1;
            AddTaskBtn.Text = "Add Task";
            AddTaskBtn.UseVisualStyleBackColor = true;
            AddTaskBtn.Click += button1_Click;
            // 
            // TaskLbx
            // 
            TaskLbx.FormattingEnabled = true;
            TaskLbx.ItemHeight = 37;
            TaskLbx.Location = new Point(15, 127);
            TaskLbx.Name = "TaskLbx";
            TaskLbx.Size = new Size(557, 448);
            TaskLbx.TabIndex = 2;
            TaskLbx.Click += TaskLbx_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 612);
            Controls.Add(TaskLbx);
            Controls.Add(AddTaskBtn);
            Controls.Add(TaskTbx);
            Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(6);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TaskTbx;
        private Button AddTaskBtn;
        private ListBox TaskLbx;
    }
}
