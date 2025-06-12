
namespace Projekt_AWzorek_167366
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
            Btn_add = new Button();
            Lb_title = new Label();
            Btn_close = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            Main = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // Btn_add
            // 
            Btn_add.BackColor = Color.FromArgb(128, 255, 255);
            Btn_add.Cursor = Cursors.Hand;
            Btn_add.Dock = DockStyle.Right;
            Btn_add.Font = new Font("Segoe UI", 12F);
            Btn_add.ForeColor = Color.FromArgb(0, 64, 64);
            Btn_add.Location = new Point(829, 3);
            Btn_add.MaximumSize = new Size(150, 50);
            Btn_add.MinimumSize = new Size(150, 50);
            Btn_add.Name = "Btn_add";
            Btn_add.Size = new Size(150, 50);
            Btn_add.TabIndex = 0;
            Btn_add.Text = "Dodaj Nawyk";
            Btn_add.UseVisualStyleBackColor = false;
            Btn_add.Click += Btn_add_Click;
            // 
            // Lb_title
            // 
            Lb_title.AutoSize = true;
            Lb_title.BackColor = Color.Transparent;
            Lb_title.Dock = DockStyle.Top;
            Lb_title.Font = new Font("Segoe UI", 20F);
            Lb_title.ForeColor = Color.White;
            Lb_title.Location = new Point(0, 0);
            Lb_title.Margin = new Padding(10, 0, 10, 0);
            Lb_title.Name = "Lb_title";
            Lb_title.Size = new Size(224, 46);
            Lb_title.TabIndex = 1;
            Lb_title.Text = "Twoje Nawyki";
            // 
            // Btn_close
            // 
            Btn_close.BackColor = Color.FromArgb(255, 192, 192);
            Btn_close.Cursor = Cursors.Hand;
            Btn_close.Font = new Font("Segoe UI", 12F);
            Btn_close.ForeColor = Color.FromArgb(192, 0, 0);
            Btn_close.Location = new Point(3, 3);
            Btn_close.Name = "Btn_close";
            Btn_close.Size = new Size(150, 50);
            Btn_close.TabIndex = 2;
            Btn_close.Text = "Zamknij";
            Btn_close.UseVisualStyleBackColor = false;
            Btn_close.Click += Btn_close_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(Btn_close, 0, 0);
            tableLayoutPanel1.Controls.Add(Btn_add, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Bottom;
            tableLayoutPanel1.Location = new Point(0, 394);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(982, 59);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // Main
            // 
            Main.AutoScroll = true;
            Main.ColumnCount = 1;
            Main.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            Main.Dock = DockStyle.Fill;
            Main.Location = new Point(0, 46);
            Main.Name = "Main";
            Main.Padding = new Padding(50);
            Main.RowCount = 1;
            Main.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            Main.Size = new Size(982, 348);
            Main.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(982, 453);
            Controls.Add(Main);
            Controls.Add(Lb_title);
            Controls.Add(tableLayoutPanel1);
            MaximumSize = new Size(1000, 1000);
            MinimumSize = new Size(500, 500);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private Button Btn_add;
        private Label Lb_title;
        private Button Btn_close;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel Main;
    }
}
