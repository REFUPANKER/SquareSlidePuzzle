using System.Diagnostics.CodeAnalysis;

namespace SquareSlidePuzzle
{
    public partial class MainForm : Form
    {
        public MainForm()
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
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// <b>Must equal</b><br></br> to 2nd power of <seealso cref="SizeDivider"/>
        /// </summary>
        private int MaxButtonCount = 3 * 3;

        /// <summary>
        /// Indicates Column/Row count <br></br>
        /// see also <seealso cref="ButtonSize"/> for Calculations<br></br>
        /// <u>See Also</u><br></br>
        /// <seealso cref="MaxButtonCount"/>
        /// </summary>
        private int SizeDivider = 3;

        /// <summary>
        /// The size of Button Item <br></br>
        /// Divides <seealso cref="panel1"/> Width to <seealso cref="SizeDivider"/><br></br>
        /// for calculating fit size <br></br>
        /// <u>Button Width equals to Button Height</u>
        /// </summary>
        private int ButtonSize
        {
            get
            {
                return panel1.Width / SizeDivider;
            }
        }
        public void CreateButtons()
        {
            MaxButtonCount = SizeDivider * SizeDivider;
            panel1.Controls.Clear();
            int px = 0, py = 0;
            for (int i = 0; i < MaxButtonCount; i++)
            {
                Button tButton = new Button();
                tButton.FlatAppearance.MouseDownBackColor = Color.Gray;
                tButton.FlatAppearance.MouseOverBackColor = Color.Silver;
                tButton.FlatStyle = FlatStyle.Flat;
                tButton.Font = new Font("Segoe UI", ButtonSize / SizeDivider, FontStyle.Regular, GraphicsUnit.Point);
                tButton.Location = new Point(px, py);
                tButton.Margin = new Padding(0);
                tButton.Name = "tButton" + (i + 1).ToString();
                tButton.Size = new Size(ButtonSize, ButtonSize);
                tButton.TabIndex = 0;
                tButton.UseVisualStyleBackColor = true;
                if (i + 1 != MaxButtonCount)
                {
                    tButton.Text = (i + 1).ToString();
                }
                px += ButtonSize;
                panel1.Controls.Add(tButton);
                if (px % (ButtonSize * SizeDivider) == 0)
                {
                    px = 0;
                    py += ButtonSize;
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
            int y = bindex / SizeDivider, x = bindex % SizeDivider;
            // up
            if (y - 1 >= 0 && CheckButtonEmpty(bindex - SizeDivider))
            {
                SwitchButtonTexts(bindex, bindex - SizeDivider);
            }
            // down
            if (y + 1 < SizeDivider && CheckButtonEmpty(bindex + SizeDivider))
            {
                SwitchButtonTexts(bindex, bindex + SizeDivider);
            }
            // left
            if (x - 1 >= 0 && CheckButtonEmpty(bindex - 1))
            {
                SwitchButtonTexts(bindex, bindex - 1);
            }
            // right
            if (x + 1 < SizeDivider && CheckButtonEmpty(bindex + 1))
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
            int x = rnd.Next(0, MaxButtonCount);
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
                rx = rnd.Next(0, MaxButtonCount);
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
                    label3.Text = "Progression : %" + ((i * 100) / MaxButtonCount);
                    return false;
                }
            }
            label3.Text = "Progression : %100";
            if (MessageBox.Show("CONGRULATIONS!!!!\nYOU COMPLETED !!!!\nWant to play again?", "CONGRULATIONS GENIUS USER", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ReStartGame();
            }
            return true;
        }
        public void ReStartGame()
        {
            CreateButtons();
            SetRandomNumbers();
            SetEmptyCell();
            CheckTableCompleted();
            MovementScore = 0;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ReStartGame();
        }

        private void ExampleButton_Click(object sender, EventArgs e)
        {
            ReStartGame();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Total Movements : " + MovementScore, "Movements", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to change Difficulty to " + comboBox1.SelectedItem, "Change Difficulty", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                SizeDivider = Convert.ToInt32(comboBox1.SelectedItem);
                ReStartGame();
            }
        }
    }
}