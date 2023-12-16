namespace TicTacToeAgainstAI
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            button10 = new Button();
            Timer = new System.Windows.Forms.Timer(components);
            button1 = new Button();
            button2 = new Button();
            button4 = new Button();
            button5 = new Button();
            button7 = new Button();
            button8 = new Button();
            button3 = new Button();
            button6 = new Button();
            button9 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkGreen;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(147, 30);
            label1.TabIndex = 0;
            label1.Text = "Player Wins: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(328, 9);
            label2.Name = "label2";
            label2.Size = new Size(104, 30);
            label2.TabIndex = 0;
            label2.Text = "AI Wins: ";
            label2.Click += label2_Click;
            // 
            // button10
            // 
            button10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button10.Location = new Point(139, 386);
            button10.Name = "button10";
            button10.Size = new Size(187, 46);
            button10.TabIndex = 2;
            button10.Text = "Restart Game";
            button10.UseVisualStyleBackColor = true;
            button10.Click += RestartGame;
            // 
            // Timer
            // 
            Timer.Interval = 1000;
            Timer.Tick += AIMove;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Window;
            button1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(81, 65);
            button1.Name = "button1";
            button1.Size = new Size(96, 97);
            button1.TabIndex = 1;
            button1.Text = "?";
            button1.UseVisualStyleBackColor = false;
            button1.Click += PlayerClickButton;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Window;
            button2.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ControlText;
            button2.Location = new Point(183, 65);
            button2.Name = "button2";
            button2.Size = new Size(96, 97);
            button2.TabIndex = 1;
            button2.Text = "?";
            button2.UseVisualStyleBackColor = false;
            button2.Click += PlayerClickButton;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.Window;
            button4.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = SystemColors.ControlText;
            button4.Location = new Point(81, 168);
            button4.Name = "button4";
            button4.Size = new Size(96, 97);
            button4.TabIndex = 1;
            button4.Text = "?";
            button4.UseVisualStyleBackColor = false;
            button4.Click += PlayerClickButton;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.Window;
            button5.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            button5.ForeColor = SystemColors.ControlText;
            button5.Location = new Point(183, 168);
            button5.Name = "button5";
            button5.Size = new Size(96, 97);
            button5.TabIndex = 1;
            button5.Text = "?";
            button5.UseVisualStyleBackColor = false;
            button5.Click += PlayerClickButton;
            // 
            // button7
            // 
            button7.BackColor = SystemColors.Window;
            button7.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            button7.ForeColor = SystemColors.ControlText;
            button7.Location = new Point(81, 271);
            button7.Name = "button7";
            button7.Size = new Size(96, 97);
            button7.TabIndex = 1;
            button7.Text = "?";
            button7.UseVisualStyleBackColor = false;
            button7.Click += PlayerClickButton;
            // 
            // button8
            // 
            button8.BackColor = SystemColors.Window;
            button8.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            button8.ForeColor = SystemColors.ControlText;
            button8.Location = new Point(183, 271);
            button8.Name = "button8";
            button8.Size = new Size(96, 97);
            button8.TabIndex = 1;
            button8.Text = "?";
            button8.UseVisualStyleBackColor = false;
            button8.Click += PlayerClickButton;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.Window;
            button3.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.ControlText;
            button3.Location = new Point(285, 65);
            button3.Name = "button3";
            button3.Size = new Size(96, 97);
            button3.TabIndex = 1;
            button3.Text = "?";
            button3.UseVisualStyleBackColor = false;
            button3.Click += PlayerClickButton;
            // 
            // button6
            // 
            button6.BackColor = SystemColors.Window;
            button6.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            button6.ForeColor = SystemColors.ControlText;
            button6.Location = new Point(285, 168);
            button6.Name = "button6";
            button6.Size = new Size(96, 97);
            button6.TabIndex = 1;
            button6.Text = "?";
            button6.UseVisualStyleBackColor = false;
            button6.Click += PlayerClickButton;
            // 
            // button9
            // 
            button9.BackColor = SystemColors.Window;
            button9.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            button9.ForeColor = SystemColors.ControlText;
            button9.Location = new Point(285, 271);
            button9.Name = "button9";
            button9.Size = new Size(96, 97);
            button9.TabIndex = 1;
            button9.Text = "?";
            button9.UseVisualStyleBackColor = false;
            button9.Click += PlayerClickButton;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(478, 444);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button6);
            Controls.Add(button3);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "TicTacToeGameWinForm";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button10;
        private System.Windows.Forms.Timer Timer;
        private Button button1;
        private Button button2;
        private Button button4;
        private Button button5;
        private Button button7;
        private Button button8;
        private Button button3;
        private Button button6;
        private Button button9;
    }
}