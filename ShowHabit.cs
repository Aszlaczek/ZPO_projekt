using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt_AWzorek_167366
{
    public partial class ShowHabit : UserControl
    {
        Habit Habit { get; set; }
        public ShowHabit()
        {
            InitializeComponent();
        }

        internal void LoadHabit(Habit habit)
        {
            this.Lb_one_habit.Text = habit.name;
            this.Habit = habit;
            this.Box_done.Checked = habit.isDone;
        }

        private void Btn_delete_habit_Click_1(object sender, EventArgs e)
        {
            // Sprawdzenie, czy Habit nie jest null
            if (this.Habit == null)
            {
                MessageBox.Show("Nie wybrano nawyku do usunięcia!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Potwierdzenie usunięcia nawyku
            DialogResult result = MessageBox.Show(
                $"Czy na pewno chcesz usunąć nawyk: {this.Habit.name}?",
                "Potwierdzenie",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            // Sprawdzenie odpowiedzi użytkownika
            if (result == DialogResult.Yes)
            {
                HabitList habitList = new HabitList();
                habitList.RemoveHabit(this.Habit);
                habitList.WriteToFile();
                MessageBox.Show($"Usunięto nawyk: {this.Habit.name}", "Usunięto nawyk", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Odświeżenie listy nawyków w głównym formularzu
                Form1 mainForm = (Form1)Application.OpenForms["Form1"];
                mainForm.RefreshHabits();
            }
            else
            {
                MessageBox.Show("Nie usunięto nawyku.", "Anulowano", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Btn_description_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.Habit.ShowDescription(), "Opis nawyku", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Box_done_CheckedChanged(object sender, EventArgs e)
        {
            this.Habit.isDone = this.Box_done.Checked;
        }
    }
}
