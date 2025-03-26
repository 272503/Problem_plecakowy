namespace Aplikacja
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
            num_items = new TextBox();
            seed = new TextBox();
            capacity = new TextBox();
            run_button = new Button();
            items_box = new ListBox();
            results_box = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // num_items
            // 
            num_items.Location = new Point(83, 60);
            num_items.Name = "num_items";
            num_items.Size = new Size(136, 27);
            num_items.TabIndex = 0;
            num_items.TextChanged += textBox1_TextChanged;
            // 
            // seed
            // 
            seed.Location = new Point(83, 123);
            seed.Name = "seed";
            seed.Size = new Size(125, 27);
            seed.TabIndex = 1;
            seed.TextChanged += textBox2_TextChanged;
            // 
            // capacity
            // 
            capacity.Location = new Point(83, 185);
            capacity.Name = "capacity";
            capacity.Size = new Size(125, 27);
            capacity.TabIndex = 2;
            capacity.TextChanged += textBox3_TextChanged;
            // 
            // run_button
            // 
            run_button.Location = new Point(96, 244);
            run_button.Name = "run_button";
            run_button.Size = new Size(94, 29);
            run_button.TabIndex = 3;
            run_button.Text = "Run";
            run_button.UseVisualStyleBackColor = true;
            run_button.Click += button1_Click;
            // 
            // items_box
            // 
            items_box.FormattingEnabled = true;
            items_box.Location = new Point(316, 123);
            items_box.Name = "items_box";
            items_box.Size = new Size(250, 364);
            items_box.TabIndex = 4;
            items_box.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // results_box
            // 
            results_box.FormattingEnabled = true;
            results_box.Location = new Point(51, 323);
            results_box.Name = "results_box";
            results_box.Size = new Size(214, 204);
            results_box.TabIndex = 5;
            results_box.SelectedIndexChanged += listBox2_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 37);
            label1.Name = "label1";
            label1.Size = new Size(177, 20);
            label1.TabIndex = 6;
            label1.Text = "Number of items(1-1000)";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(109, 100);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 7;
            label2.Text = "Seed(0<)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(83, 159);
            label3.Name = "label3";
            label3.Size = new Size(130, 20);
            label3.TabIndex = 8;
            label3.Text = "Capacity(0-10000)";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(135, 300);
            label4.Name = "label4";
            label4.Size = new Size(55, 20);
            label4.TabIndex = 9;
            label4.Text = "Results";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(408, 100);
            label5.Name = "label5";
            label5.Size = new Size(63, 20);
            label5.TabIndex = 10;
            label5.Text = "Instance";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(618, 555);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(results_box);
            Controls.Add(items_box);
            Controls.Add(run_button);
            Controls.Add(capacity);
            Controls.Add(seed);
            Controls.Add(num_items);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox num_items;
        private TextBox seed;
        private TextBox capacity;
        private Button run_button;
        private ListBox items_box;
        private ListBox results_box;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}
