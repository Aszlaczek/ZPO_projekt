using System.Runtime.Serialization.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt_AWzorek_167366
{
    public partial class Form1 : Form
    {
        HabitList habits = new HabitList();
        public Form1()
        {
            InitializeComponent();

            // read from the config file and set the default font from confing file

            if (Program.Config != null)
            {
                this.Size = new Size(Program.Config.width, Program.Config.height);
            }
            else
            {
                this.Font = new Font(Program.Config.font, 15.0f);
            }

        }


        private void Btn_close_Click(object sender, EventArgs e)
        {
            // Save the current size and font to the config file before closing
            this.habits.WriteToFile();
            this.Close();
        }

        private void Btn_add_Click(object sender, EventArgs e)
        {
            AddedFormcs addedFormcs = new AddedFormcs();
            addedFormcs.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Main.ColumnCount = 2;
            this.habits.GetHabits().ForEach(habits =>
            {
                ShowHabit showHabit = new ShowHabit();
                showHabit.LoadHabit(habits);
                this.Main.Controls.Add(showHabit);
                
            });
        }

        public void RefreshHabits()
        {
            this.Main.Controls.Clear();
            habits.ReadFromFile();
            this.habits.GetHabits().ForEach(habits =>
            {
                ShowHabit showHabit = new ShowHabit();
                showHabit.LoadHabit(habits);
                this.Main.Controls.Add(showHabit);
            });
        }
    }
}
