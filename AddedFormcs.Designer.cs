namespace Projekt_AWzorek_167366
{
    partial class AddedFormcs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Inp_name = new TextBox();
            Inp_desc = new TextBox();
            Lb_name = new Label();
            Lb_desc = new Label();
            Btn_cancel = new Button();
            Btn_add = new Button();
            Lb_new_item = new Label();
            SuspendLayout();
            // 
            // Inp_name
            // 
            Inp_name.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Inp_name.Font = new Font("Segoe UI", 12F);
            Inp_name.Location = new Point(164, 133);
            Inp_name.MaximumSize = new Size(350, 50);
            Inp_name.MinimumSize = new Size(150, 50);
            Inp_name.Name = "Inp_name";
            Inp_name.PlaceholderText = "Nazwa";
            Inp_name.Size = new Size(350, 50);
            Inp_name.TabIndex = 1;
            // 
            // Inp_desc
            // 
            Inp_desc.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Inp_desc.Font = new Font("Segoe UI", 12F);
            Inp_desc.Location = new Point(164, 205);
            Inp_desc.MaximumSize = new Size(350, 250);
            Inp_desc.MinimumSize = new Size(150, 100);
            Inp_desc.Multiline = true;
            Inp_desc.Name = "Inp_desc";
            Inp_desc.PlaceholderText = "Opis";
            Inp_desc.Size = new Size(350, 100);
            Inp_desc.TabIndex = 1;
            // 
            // Lb_name
            // 
            Lb_name.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Lb_name.AutoSize = true;
            Lb_name.Font = new Font("Segoe UI", 18F);
            Lb_name.Location = new Point(12, 133);
            Lb_name.Name = "Lb_name";
            Lb_name.Size = new Size(106, 41);
            Lb_name.TabIndex = 2;
            Lb_name.Text = "Nazwa";
            // 
            // Lb_desc
            // 
            Lb_desc.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Lb_desc.AutoSize = true;
            Lb_desc.Font = new Font("Segoe UI", 18F);
            Lb_desc.Location = new Point(12, 220);
            Lb_desc.Name = "Lb_desc";
            Lb_desc.Size = new Size(79, 41);
            Lb_desc.TabIndex = 2;
            Lb_desc.Text = "Opis";
            // 
            // Btn_cancel
            // 
            Btn_cancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Btn_cancel.BackColor = Color.FromArgb(255, 192, 192);
            Btn_cancel.Cursor = Cursors.Hand;
            Btn_cancel.Font = new Font("Segoe UI", 12F);
            Btn_cancel.ForeColor = Color.FromArgb(192, 0, 0);
            Btn_cancel.Location = new Point(396, 373);
            Btn_cancel.Name = "Btn_cancel";
            Btn_cancel.Size = new Size(150, 50);
            Btn_cancel.TabIndex = 0;
            Btn_cancel.Text = "Odrzuć";
            Btn_cancel.UseVisualStyleBackColor = false;
            Btn_cancel.Click += Btn_close_Click;
            // 
            // Btn_add
            // 
            Btn_add.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Btn_add.BackColor = Color.FromArgb(192, 255, 192);
            Btn_add.Cursor = Cursors.Hand;
            Btn_add.Font = new Font("Segoe UI", 12F);
            Btn_add.ForeColor = Color.FromArgb(0, 192, 0);
            Btn_add.Location = new Point(552, 373);
            Btn_add.Name = "Btn_add";
            Btn_add.Size = new Size(150, 50);
            Btn_add.TabIndex = 3;
            Btn_add.Text = "Dodaj";
            Btn_add.UseVisualStyleBackColor = false;
            Btn_add.Click += Btn_add_Click;
            // 
            // Lb_new_item
            // 
            Lb_new_item.BorderStyle = BorderStyle.Fixed3D;
            Lb_new_item.Dock = DockStyle.Top;
            Lb_new_item.Font = new Font("Segoe UI", 20F);
            Lb_new_item.Location = new Point(0, 0);
            Lb_new_item.Name = "Lb_new_item";
            Lb_new_item.Size = new Size(732, 69);
            Lb_new_item.TabIndex = 4;
            Lb_new_item.Text = "Dodaj nowy nawyk";
            Lb_new_item.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AddedFormcs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(732, 453);
            Controls.Add(Lb_new_item);
            Controls.Add(Btn_add);
            Controls.Add(Lb_desc);
            Controls.Add(Lb_name);
            Controls.Add(Inp_desc);
            Controls.Add(Inp_name);
            Controls.Add(Btn_cancel);
            MaximumSize = new Size(750, 500);
            MinimumSize = new Size(450, 500);
            Name = "AddedFormcs";
            Text = "AddedFormcs";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox Inp_name;
        private TextBox Inp_desc;
        private Label Lb_name;
        private Label Lb_desc;
        private Button Btn_cancel;
        private Button Btn_add;
        private Label Lb_new_item;
    }
}