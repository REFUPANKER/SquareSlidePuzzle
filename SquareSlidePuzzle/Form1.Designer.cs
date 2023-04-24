namespace SquareSlidePuzzle
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
            panel1 = new Panel();
            ExampleButton = new Button();
            panel2 = new Panel();
            button10 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            panel2.SuspendLayout();
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
            panel2.Controls.Add(button10);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(510, 50);
            panel2.TabIndex = 2;
            panel2.MouseDown += panel2_MouseDown;
            panel2.MouseMove += panel2_MouseMove;
            // 
            // button10
            // 
            button10.BackColor = Color.White;
            button10.Dock = DockStyle.Right;
            button10.FlatAppearance.MouseDownBackColor = Color.Gray;
            button10.FlatAppearance.MouseOverBackColor = Color.Silver;
            button10.FlatStyle = FlatStyle.Flat;
            button10.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button10.Location = new Point(458, 0);
            button10.Name = "button10";
            button10.Size = new Size(50, 48);
            button10.TabIndex = 1;
            button10.Text = "X";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Left;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(341, 48);
            label1.TabIndex = 0;
            label1.Text = "Slide Square Puzzle";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            label1.MouseDown += panel2_MouseDown;
            label1.MouseMove += panel2_MouseMove;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 571);
            label2.Name = "label2";
            label2.Size = new Size(109, 20);
            label2.TabIndex = 3;
            label2.Text = "Movements : 0 ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(363, 571);
            label3.Name = "label3";
            label3.Size = new Size(97, 20);
            label3.TabIndex = 4;
            label3.Text = "Progression : ";
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(510, 600);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Square Slide Puzzle";
            Load += Form1_Load;
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private Button ExampleButton;
        private Panel panel2;
        private Label label1;
        private Button button10;
        private Label label2;
        private Label label3;
    }
}