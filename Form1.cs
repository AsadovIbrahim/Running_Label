namespace First_Task
{
    public partial class Form1 : Form
    {
        private Label label1;
        public Form1()
        {
            InitializeComponent();
            label1 = new Label
            {
                Location = new Point(50, 50),
                Size = new Size(100, 100),
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = Color.Red,
            };

            label1.MouseHover += Label1_MouseHover;

            Controls.Add(label1);
        }
        private void Label1_MouseHover(object sender, EventArgs e)
        {
            Random random = new Random();
            int x = random.Next(0, Width - label1.Width);
            int y = random.Next(0, Height - label1.Height);

            label1.Location = new Point(x, y);
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }


    }
}

