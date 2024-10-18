namespace MyToDoApp
{
    public partial class Form1 : Form
    {
        List<string> MyTask = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyTask.Add(TaskTbx.Text);

            TaskLbx.DataSource = null;
            TaskLbx.DataSource = MyTask;
        }

        private void TaskLbx_Click(object sender, EventArgs e)
        {
            if (MyTask.Count<=0)
                return;


            MyTask.RemoveAt(TaskLbx.SelectedIndex);

            TaskLbx.DataSource = null;
            TaskLbx.DataSource = MyTask;
        }
    }
}
