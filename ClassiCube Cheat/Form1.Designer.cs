namespace ClassiCube_Cheat
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
            label1 = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            textBox4 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(200, 28);
            label1.Name = "label1";
            label1.Size = new Size(273, 45);
            label1.TabIndex = 0;
            label1.Text = "ClassiCube Cheat";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Lime;
            button1.Location = new Point(31, 106);
            button1.Name = "button1";
            button1.Size = new Size(138, 43);
            button1.TabIndex = 1;
            button1.Text = "Attach to Game";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(628, 106);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "X";
            textBox1.Size = new Size(46, 33);
            textBox1.TabIndex = 2;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(680, 106);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "X";
            textBox2.Size = new Size(46, 33);
            textBox2.TabIndex = 3;
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(732, 106);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "X";
            textBox3.Size = new Size(46, 33);
            textBox3.TabIndex = 4;
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Lime;
            button2.Location = new Point(628, 145);
            button2.Name = "button2";
            button2.Size = new Size(150, 43);
            button2.TabIndex = 5;
            button2.Text = "Teleport";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.Lime;
            button3.Location = new Point(200, 106);
            button3.Name = "button3";
            button3.Size = new Size(233, 43);
            button3.TabIndex = 6;
            button3.Text = "Toggle NoClip Permission";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.Lime;
            button4.Location = new Point(200, 155);
            button4.Name = "button4";
            button4.Size = new Size(233, 43);
            button4.TabIndex = 7;
            button4.Text = "Toggle Fly Permission";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.Lime;
            button5.Location = new Point(200, 204);
            button5.Name = "button5";
            button5.Size = new Size(233, 43);
            button5.TabIndex = 8;
            button5.Text = "Toggle Speed Permission";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.ForeColor = Color.Lime;
            button6.Location = new Point(200, 253);
            button6.Name = "button6";
            button6.Size = new Size(233, 43);
            button6.TabIndex = 9;
            button6.Text = "Toggle Respawn Permission";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button7.ForeColor = Color.Lime;
            button7.Location = new Point(628, 253);
            button7.Name = "button7";
            button7.Size = new Size(150, 43);
            button7.TabIndex = 11;
            button7.Text = "Apply Horspeed";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox4.Location = new Point(628, 214);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "Horspeed";
            textBox4.Size = new Size(150, 33);
            textBox4.TabIndex = 10;
            textBox4.TextAlign = HorizontalAlignment.Center;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 450);
            Controls.Add(button7);
            Controls.Add(textBox4);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "ClassiCube External";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private TextBox textBox4;
    }
}
