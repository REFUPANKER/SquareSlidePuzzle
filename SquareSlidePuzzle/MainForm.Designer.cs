namespace SquareSlidePuzzle
{
    partial class MainForm
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
            panel1 = new Panel();
            label4 = new Label();
            ExampleButton = new Button();
            panel2 = new Panel();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            panel3 = new Panel();
            comboBox1 = new ComboBox();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Location = new Point(0, 50);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(510, 510);
            panel1.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(185, 6);
            label4.Name = "label4";
            label4.Size = new Size(55, 25);
            label4.TabIndex = 6;
            label4.Text = "Level";
            // 
            // ExampleButton
            // 
            ExampleButton.BackColor = Color.White;
            ExampleButton.Dock = DockStyle.Right;
            ExampleButton.FlatAppearance.MouseDownBackColor = Color.Gray;
            ExampleButton.FlatAppearance.MouseOverBackColor = Color.Silver;
            ExampleButton.FlatStyle = FlatStyle.Flat;
            ExampleButton.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            ExampleButton.Location = new Point(408, 0);
            ExampleButton.Margin = new Padding(0);
            ExampleButton.Name = "ExampleButton";
            ExampleButton.Size = new Size(50, 48);
            ExampleButton.TabIndex = 0;
            ExampleButton.Text = "🔃";
            ExampleButton.UseVisualStyleBackColor = false;
            ExampleButton.Click += ExampleButton_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(ExampleButton);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(510, 50);
            panel2.TabIndex = 0;
            panel2.MouseDown += panel2_MouseDown;
            panel2.MouseMove += panel2_MouseMove;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.Dock = DockStyle.Right;
            button2.FlatAppearance.MouseDownBackColor = Color.Gray;
            button2.FlatAppearance.MouseOverBackColor = Color.Silver;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(458, 0);
            button2.Name = "button2";
            button2.Size = new Size(50, 48);
            button2.TabIndex = 1;
            button2.Text = "X";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Left;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(290, 48);
            label1.TabIndex = 0;
            label1.Text = "Slide Square Puzzle";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            label1.MouseDown += panel2_MouseDown;
            label1.MouseMove += panel2_MouseMove;
            // 
            // label2
            // 
            label2.Cursor = Cursors.Hand;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 6);
            label2.Name = "label2";
            label2.Size = new Size(170, 25);
            label2.TabIndex = 3;
            label2.Text = "Movements : 0 ";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(346, 6);
            label3.Name = "label3";
            label3.Size = new Size(152, 25);
            label3.TabIndex = 4;
            label3.Text = "Progression : %0";
            // 
            // panel3
            // 
            panel3.Controls.Add(label4);
            panel3.Controls.Add(comboBox1);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 560);
            panel3.Name = "panel3";
            panel3.Size = new Size(510, 40);
            panel3.TabIndex = 2;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "2", "3", "4", "5", "6", "7" });
            comboBox1.Location = new Point(246, 3);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(78, 33);
            comboBox1.TabIndex = 5;
            comboBox1.Text = "3";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(510, 600);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Square Slide Puzzle";
            Load += Form1_Load;
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Button ExampleButton;
        private Panel panel2;
        private Label label1;
        private Button button2;
        private Label label2;
        private Label label3;
        private Panel panel3;
        private ComboBox comboBox1;
        private Label label4;
    }
}