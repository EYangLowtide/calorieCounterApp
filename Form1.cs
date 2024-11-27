namespace calorieCounterAppi
{
    public partial class Form1 : Form
    {
        private List<string> foodItems = new List<string>(); // Temporary list for food items

        public Form1()
        {
            InitializeComponent();
            LoadData();
            UpdateListBox();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Placeholder for label click event
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Placeholder for dateTextBox text change event
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // Placeholder for foodItemTextBox text change event
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            // Placeholder for caloriesTextBox text change event
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Placeholder for foodItemsListBox selected index change event
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Placeholder for entriesListBox selected index change event
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Add food item to the list
            string foodItem = foodItemTextBox.Text;
            string calories = caloriesTextBox.Text;

            if (string.IsNullOrWhiteSpace(foodItem) || string.IsNullOrWhiteSpace(calories))
            {
                MessageBox.Show("Please enter both food item and calories.");
                return;
            }

            string itemEntry = $"{foodItem} ({calories})";
            foodItems.Add(itemEntry);
            UpdateFoodItemsListBox();
            foodItemTextBox.Clear();
            caloriesTextBox.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Start a new entry
            dateTextBox.Clear();
            foodItemTextBox.Clear();
            caloriesTextBox.Clear();
            foodItems.Clear();
            UpdateFoodItemsListBox();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Save the current day's data
            string date = dateTextBox.Text;

            if (string.IsNullOrWhiteSpace(date) || foodItems.Count == 0)
            {
                MessageBox.Show("Please enter a date and add at least one food item.");
                return;
            }

            string foodItemsCombined = string.Join(", ", foodItems);
            string logEntry = $"{{{foodItemsCombined} [{date}]}}";

            SaveData(logEntry);
            entriesListBox.Items.Add(logEntry);
            foodItems.Clear();
            UpdateFoodItemsListBox();
            dateTextBox.Clear();
            MessageBox.Show("Data Saved");

            UpdateCalendar(ReadDataFromFile());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Delete the selected entry
            if (entriesListBox.SelectedIndex != -1)
            {
                var entries = ReadDataFromFile().ToList();
                entries.RemoveAt(entriesListBox.SelectedIndex);
                File.WriteAllLines("calorieData.txt", entries);
                LoadData();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // Placeholder for cheat day checkbox change event
        }

        private void label6_Click(object sender, EventArgs e)
        {
            // Placeholder for label click event
        }

        private void LoadData()
        {
            var entries = ReadDataFromFile();
            entriesListBox.Items.Clear();
            entriesListBox.Items.AddRange(entries.ToArray());

            if (entries.Any())
            {
                string lastEntry = entries.Last();
                DisplayMostRecentEntry(lastEntry);
            }

            UpdateCalendar(entries);
        }

        private void SaveData(string entry)
        {
            File.AppendAllText("calorieData.txt", entry + Environment.NewLine);
        }

        private List<string> ReadDataFromFile()
        {
            if (File.Exists("calorieData.txt"))
            {
                return File.ReadAllLines("calorieData.txt").ToList();
            }
            return new List<string>();
        }

        private void UpdateListBox()
        {
            entriesListBox.Items.Clear();
            foreach (var entry in ReadDataFromFile())
            {
                entriesListBox.Items.Add(entry);
            }
        }

        private void UpdateFoodItemsListBox()
        {
            foodItemsListBox.Items.Clear();
            foreach (var item in foodItems)
            {
                foodItemsListBox.Items.Add(item);
            }
        }

        private void DisplayMostRecentEntry(string lastEntry)
        {
            int lastBracketIndex = lastEntry.LastIndexOf("[");
            int lastBraceIndex = lastEntry.LastIndexOf("}");

            if (lastBracketIndex != -1 && lastBraceIndex != -1 && lastBracketIndex < lastBraceIndex)
            {
                string date = lastEntry.Substring(lastBracketIndex + 1, lastBraceIndex - lastBracketIndex - 2);
                dateTextBox.Text = date;
            }

            int braceIndex = lastEntry.IndexOf("{");
            if (braceIndex != -1 && lastBracketIndex != -1)
            {
                string foodItemsString = lastEntry.Substring(braceIndex + 1, lastBracketIndex - braceIndex - 2);
                foodItems = foodItemsString.Split(',').Select(item => item.Trim()).ToList();
                UpdateFoodItemsListBox();
            }
        }

        private void UpdateCalendar(List<string> entries)
        {
            calendarPanel.Controls.Clear();

            for (int i = 0; i < 7; i++)
            {
                var dayLabel = new Label();
                dayLabel.Text = GetDayOfWeek(i);
                dayLabel.AutoSize = true;
                calendarPanel.Controls.Add(dayLabel);
            }

            foreach (var entry in entries)
            {
                int lastBracketIndex = entry.LastIndexOf("[");
                int lastBraceIndex = entry.LastIndexOf("]");

                if (lastBracketIndex != -1 && lastBraceIndex != -1)
                {
                    string dateString = entry.Substring(lastBracketIndex + 1, lastBraceIndex - lastBracketIndex - 1);
                    if (DateTime.TryParse(dateString, out DateTime entryDate))
                    {
                        int dayOfWeek = (int)entryDate.DayOfWeek;
                        var entryLabel = new Label();
                        entryLabel.Text = entry;
                        entryLabel.AutoSize = true;
                        calendarPanel.Controls.Add(entryLabel);
                    }
                }
            }
        }

        private string GetDayOfWeek(int i)
        {
            switch (i)
            {
                case 0: return "Sunday";
                case 1: return "Monday";
                case 2: return "Tuesday";
                case 3: return "Wednesday";
                case 4: return "Thursday";
                case 5: return "Friday";
                case 6: return "Saturday";
                default: return "";
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
