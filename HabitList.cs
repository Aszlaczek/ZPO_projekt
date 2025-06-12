using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace Projekt_AWzorek_167366
{
    class HabitList
    {
        public List<Habit> habits { get; set; }
        public HabitList()
        {
            ReadFromFile();
        }

        public void ReadFromFile()
        {
            string json = File.ReadAllText("habits.json");
            if(string.IsNullOrEmpty(json))
            {
                habits = new List<Habit>();
                return;
            }
            var loaded = JsonSerializer.Deserialize<List<Habit>>(json);
            habits = loaded ?? new List<Habit>();       
           
        }

        public void WriteToFile()
        {
            try
            {
                string json = JsonSerializer.Serialize(habits);
                File.WriteAllText("habits.json", json);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error writing to file: {ex.Message}");
            }
        }

        public void AddHabit(Habit habit)
        {
            habits.Add(habit);
            WriteToFile();
        }

        public void RemoveHabit(Habit habit)
        {
            var newHaitsList = this.habits.Where(h => h.name != habit.name).ToList();
            habits = newHaitsList;
            WriteToFile();
        }

        public List<Habit> GetHabits()
        {
            return habits;
        }
        public void UpdateHabit(Habit habit)
        {
            habit.isDone = !habit.isDone;
            this.habits = this.habits.Select(h => h.name == habit.name ? habit : h).ToList();
            WriteToFile();
        }
    }
}