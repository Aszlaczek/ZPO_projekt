namespace Projekt_AWzorek_167366
{
    partial class ShowHabit
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            Lb_one_habit = new Label();
            Box_done = new CheckBox();
            Btn_delete_habit = new Button();
            Btn_description = new Button();
            splitContainer1 = new SplitContainer();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // Lb_one_habit
            // 
            Lb_one_habit.AutoSize = true;
            Lb_one_habit.Dock = DockStyle.Top;
            Lb_one_habit.Font = new Font("Segoe UI", 18F);
            Lb_one_habit.Location = new Point(0, 0);
            Lb_one_habit.Margin = new Padding(2);
            Lb_one_habit.Name = "Lb_one_habit";
            Lb_one_habit.Size = new Size(119, 41);
            Lb_one_habit.TabIndex = 0;
            Lb_one_habit.Text = "adwasd";
            // 
            // Box_done
            // 
            Box_done.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Box_done.AutoSize = true;
            Box_done.BackgroundImageLayout = ImageLayout.None;
            Box_done.Cursor = Cursors.Hand;
            Box_done.FlatAppearance.CheckedBackColor = Color.ForestGreen;
            Box_done.Font = new Font("Segoe UI", 18F);
            Box_done.Location = new Point(197, 61);
            Box_done.Name = "Box_done";
            Box_done.Size = new Size(150, 45);
            Box_done.TabIndex = 1;
            Box_done.Text = "Zakończ";
            Box_done.UseVisualStyleBackColor = true;
            Box_done.CheckedChanged += Box_done_CheckedChanged;
            // 
            // Btn_delete_habit
            // 
            Btn_delete_habit.BackColor = Color.FromArgb(255, 192, 192);
            Btn_delete_habit.Cursor = Cursors.Hand;
            Btn_delete_habit.Dock = DockStyle.Fill;
            Btn_delete_habit.Font = new Font("Segoe UI", 12F);
            Btn_delete_habit.ForeColor = Color.Red;
            Btn_delete_habit.Location = new Point(0, 0);
            Btn_delete_habit.Margin = new Padding(0);
            Btn_delete_habit.Name = "Btn_delete_habit";
            Btn_delete_habit.Size = new Size(180, 36);
            Btn_delete_habit.TabIndex = 2;
            Btn_delete_habit.Text = "Usuń";
            Btn_delete_habit.UseVisualStyleBackColor = false;
            Btn_delete_habit.Click += Btn_delete_habit_Click_1;
            // 
            // Btn_description
            // 
            Btn_description.BackColor = Color.FromArgb(192, 255, 255);
            Btn_description.Cursor = Cursors.Hand;
            Btn_description.Dock = DockStyle.Fill;
            Btn_description.Font = new Font("Segoe UI", 12F);
            Btn_description.ForeColor = Color.DarkOliveGreen;
            Btn_description.Location = new Point(0, 0);
            Btn_description.Name = "Btn_description";
            Btn_description.Size = new Size(168, 36);
            Btn_description.TabIndex = 3;
            Btn_description.Text = "Opis";
            Btn_description.UseVisualStyleBackColor = false;
            Btn_description.Click += Btn_description_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Bottom;
            splitContainer1.Location = new Point(0, 164);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(Btn_description);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(Btn_delete_habit);
            splitContainer1.Size = new Size(350, 36);
            splitContainer1.SplitterDistance = 168;
            splitContainer1.SplitterWidth = 2;
            splitContainer1.TabIndex = 0;
            // 
            // ShowHabit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            Controls.Add(splitContainer1);
            Controls.Add(Box_done);
            Controls.Add(Lb_one_habit);
            MaximumSize = new Size(350, 200);
            MinimumSize = new Size(250, 200);
            Name = "ShowHabit";
            Size = new Size(350, 200);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Lb_one_habit;
        private CheckBox Box_done;
        private Button Btn_delete_habit;
        private Button Btn_description;
        private SplitContainer splitContainer1;
    }
}
