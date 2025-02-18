using System;
using System.Data;
using Microsoft.Data.Sqlite;
using System.Windows.Forms;


namespace proj
{
    public partial class Form1 : Form
    {
        private string connectionString = "Data Source=media_library.db";

        public Form1()
        {
            InitializeComponent();
            InitializeDatabase();
            InitializeTypeComboBox();
            LoadMedia();
        }

        private void InitializeDatabase()
        {
            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                string createTableQuery = @"CREATE TABLE IF NOT EXISTS Media (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Title TEXT NOT NULL,
                    Type TEXT NOT NULL CHECK(Type IN ('Book', 'Movie', 'Music')),
                    Author TEXT,
                    Year INTEGER
                );";
                using (var command = new SqliteCommand(createTableQuery, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }
        private void InitializeTypeComboBox()
        {
            ComboBox.Items.Clear();
            ComboBox.Items.Add("Book");
            ComboBox.Items.Add("Movie");
            ComboBox.Items.Add("Music");
            ComboBox.SelectedIndex = 0;
        }

        private void LoadMedia(string filter = "")
        {
            MediaList.Items.Clear();
            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                string selectQuery = "SELECT Id, Title, Type, Author, Year FROM Media";
                if (!string.IsNullOrWhiteSpace(filter))
                {
                    selectQuery += " WHERE Title LIKE @Filter OR Type LIKE @Filter OR Author LIKE @Filter OR Year LIKE @Filter";
                }
                using (var command = new SqliteCommand(selectQuery, connection))
                {
                    if (!string.IsNullOrWhiteSpace(filter))
                    {
                        command.Parameters.AddWithValue("@Filter", "%" + filter + "%");
                    }
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            MediaList.Items.Add($"{reader["Id"]}: {reader["Title"]} ({reader["Type"]}) - {reader["Author"]}, {reader["Year"]}");
                        }
                    }
                }
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            string title = TitleInput.Text.Trim();
            string type = ComboBox.Text;
            string author = AuthorInput.Text.Trim();
            int year = int.TryParse(YearInput.Text, out int y) ? y : 0;

            if (!string.IsNullOrWhiteSpace(title) && !string.IsNullOrWhiteSpace(type))
            {
                using (var connection = new SqliteConnection(connectionString))
                {
                    connection.Open();
                    string insertQuery = "INSERT INTO Media (Title, Type, Author, Year) VALUES (@Title, @Type, @Author, @Year);";
                    using (var command = new SqliteCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@Title", title);
                        command.Parameters.AddWithValue("@Type", type);
                        command.Parameters.AddWithValue("@Author", author);
                        command.Parameters.AddWithValue("@Year", year);
                        command.ExecuteNonQuery();
                    }
                }
                LoadMedia();
            }
            else
            {
                MessageBox.Show("Wype³nij wymagane pola: Tytu³ i Typ.");
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (MediaList.SelectedItem != null)
            {
                string selectedItem = MediaList.SelectedItem.ToString();
                int mediaId = int.Parse(selectedItem.Split(':')[0]);

                using (var connection = new SqliteConnection(connectionString))
                {
                    connection.Open();
                    string deleteQuery = "DELETE FROM Media WHERE Id = @Id;";
                    using (var command = new SqliteCommand(deleteQuery, connection))
                    {
                        command.Parameters.AddWithValue("@Id", mediaId);
                        command.ExecuteNonQuery();
                    }
                }
                LoadMedia();
            }
            else
            {
                MessageBox.Show("Wybierz element do usuniêcia.");
            }
        }

        private void Edit1_Click(object sender, EventArgs e)
        {
            if (MediaList.SelectedItem != null)
            {
                string selectedItem = MediaList.SelectedItem.ToString();
                int mediaId = int.Parse(selectedItem.Split(':')[0]);

                string title = TitleInput.Text.Trim();
                string type = ComboBox.Text;
                string author = AuthorInput.Text.Trim();
                int year = int.TryParse(YearInput.Text, out int y) ? y : 0;

                if (!string.IsNullOrWhiteSpace(title) && !string.IsNullOrWhiteSpace(type))
                {
                    using (var connection = new SqliteConnection(connectionString))
                    {
                        connection.Open();
                        string updateQuery = "UPDATE Media SET Title = @Title, Type = @Type, Author = @Author, Year = @Year WHERE Id = @Id;";
                        using (var command = new SqliteCommand(updateQuery, connection))
                        {
                            command.Parameters.AddWithValue("@Title", title);
                            command.Parameters.AddWithValue("@Type", type);
                            command.Parameters.AddWithValue("@Author", author);
                            command.Parameters.AddWithValue("@Year", year);
                            command.Parameters.AddWithValue("@Id", mediaId);
                            command.ExecuteNonQuery();
                        }
                    }
                    LoadMedia();
                }
                else
                {
                    MessageBox.Show("Wype³nij wymagane pola: Tytu³ i Typ.");
                }
            }
            else
            {
                MessageBox.Show("Wybierz element do edycji.");
            }
        }

        private void Search_Click(object sender, EventArgs e)
        {
            string filter = SearchInput.Text.Trim();
            LoadMedia(filter);
        }

        private void MediaList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void TitleInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void AuthorInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void YearInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void SearchInput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
