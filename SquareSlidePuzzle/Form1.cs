using System.Diagnostics.CodeAnalysis;

namespace SquareSlidePuzzle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Point movement;
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            movement = e.Location;
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - movement.X;
                this.Top += e.Y - movement.Y;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        Button[,] ButtonTable = new Button[3, 3];
        public void CreateButtons()
        {
            panel1.Controls.Clear();
            int px = 0, py = 0, size = panel1.Width / 3, end = 9;
            for (int i = 0; i < end; i++)
            {
                Button tButton = new Button();
                tButton.FlatAppearance.MouseDownBackColor = Color.Gray;
                tButton.FlatAppearance.MouseOverBackColor = Color.Silver;
                tButton.FlatStyle = FlatStyle.Flat;
                tButton.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
                tButton.Location = new Point(px, py);
                tButton.Margin = new Padding(0);
                tButton.Name = "tButton" + (i + 1).ToString();
                tButton.Size = new Size(size, size);
                tButton.TabIndex = 0;
                tButton.UseVisualStyleBackColor = true;
                if (i + 1 != end)
                {
                    tButton.Text = (i + 1).ToString();
                }
                ButtonTable[py / size, px / size] = tButton;
                px += size;
                panel1.Controls.Add(tButton);
                if (px % (size * 3) == 0)
                {
                    px = 0;
                    py += size;
                }
                tButton.Click += TButton_Click;
            }
        }

        private int mvscr;
        public int MovementScore
        {
            get
            {
                label2.Text = "Movements : " + mvscr;
                return mvscr;
            }
            set
            {
                mvscr = value;
                label2.Text = "Movements : " + mvscr;
            }
        }
        private void TButton_Click(object? sender, EventArgs e)
        {
#pragma warning disable
            Button? btn = (Button)sender;
            int bindex = panel1.Controls.IndexOf(btn);
            if (btn.Text == string.Empty)
            {
                return;
            }
            int emptyCell = 0;
            int y = bindex / 3, x = bindex % 3;
            // up
            if (y - 1 >= 0 && CheckButtonEmpty(bindex - 3))
            {
                SwitchButtonTexts(bindex, bindex - 3);
            }
            // down
            if (y + 1 < 3 && CheckButtonEmpty(bindex + 3))
            {
                SwitchButtonTexts(bindex, bindex + 3);
            }
            // left
            if (x - 1 >= 0 && CheckButtonEmpty(bindex - 1))
            {
                SwitchButtonTexts(bindex, bindex - 1);
            }
            // right
            if (x + 1 < 3 && CheckButtonEmpty(bindex + 1))
            {
                SwitchButtonTexts(bindex, bindex + 1);
            }
        }
        public void SwitchButtonTexts(int src, int dest)
        {
            MovementScore += 1;
            string trash = panel1.Controls[src].Text;
            panel1.Controls[src].Text = panel1.Controls[dest].Text;
            panel1.Controls[dest].Text = trash;
            CheckTableCompleted();
        }
        public int GetEmptyCell()
        {
            for (int i = 0; i < panel1.Controls.Count; i++)
            {
                if (panel1.Controls[i].Text == string.Empty)
                {
                    return i;
                }
            }
            return 0;
        }
        public void SetEmptyCell()
        {
            Random rnd = new Random();
            int x = rnd.Next(0, 9);
            panel1.Controls[GetEmptyCell()].Text = panel1.Controls[x].Text;
            panel1.Controls[x].Text = string.Empty;
        }
        public void SetRandomNumbers()
        {
            Random rnd = new Random();
            string trash = "";
            int rx = 0;
            for (int i = 0; i < panel1.Controls.Count; i++)
            {
                rx = rnd.Next(0, 9);
                for (int j = 0; j < panel1.Controls.Count; j++)
                {

                    trash = panel1.Controls[j].Text;
                    panel1.Controls[j].Text = panel1.Controls[rx].Text;
                    panel1.Controls[rx].Text = trash;
                }
            }
        }
        public bool CheckButtonEmpty(int index)
        {
            return string.IsNullOrEmpty(panel1.Controls[index].Text);
        }
        public bool CheckTableCompleted()
        {
            for (int i = 0; i < panel1.Controls.Count - 1; i++)
            {
                if ((i + 1).ToString() != panel1.Controls[i].Text)
                {
                    label3.Text = "Progression : %" + ((i + 1) * 10);
                    return false;
                }
            }
            label3.Text = "Progression : %100";
            if (MessageBox.Show("CONGRULATIONS!!!!\nYOU COMPLETED !!!!\nWant to play again?", "CONGRULATIONS GENIUS USER", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                RestartGame();
            }
            return true;
        }
        public void StartGame()
        {
            CreateButtons();
            SetRandomNumbers();
            SetEmptyCell();
            CheckTableCompleted();
        }
        public void RestartGame()
        {
            SetRandomNumbers();
            SetEmptyCell();
            CheckTableCompleted();
            MovementScore = 0;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            StartGame();
        }

        private void ExampleButton_Click(object sender, EventArgs e)
        {
            RestartGame();
        }
    }
}