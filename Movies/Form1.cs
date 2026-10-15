using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Movies
{
    public partial class Form1 : Form
    {
        List<string> movies = new List<string>(); // 'notebook' for our movies

        public Form1()
        {
            InitializeComponent();
        }

        private void lstMovies_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string title = txtTitle.Text;

                if (title == "")
                {
                    MessageBox.Show("Enter a movie title.");
                    return;
                }

                if (!int.TryParse(txtYear.Text, out int year))
                {
                    MessageBox.Show("Enter a valid release year.");
                    return;
                }

                if (cmbLocation.SelectedIndex == -1)
                {
                    MessageBox.Show("Select a location.");
                    return;
                }

                string location = cmbLocation.Text;

                DateTime now = DateTime.Now;

                string date = now.ToString("dd/MM/yyyy"); //returns current date
                string time = now.ToString("HH:mm:ss"); // returns current time
                string timestamp = now.ToString("dd/MM/yyyy HH:mm:ss"); // returns current date and time


                string movie = $"{title} ({year})";
                movies.Add(movie);
                lstMovies.Items.Add(movie);

                txtOutput.Text = $"Movie added: {movie}\r\nLocation: {location}\r\nDate: {date}\r\nTime: {time}\r\nTimestamp: {timestamp}";

                lblStatus.Text = "Movie added successfully.";
            }//end try
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }//end catch
            finally
            {
                MessageBox.Show("Movie processing was completed.");
            }//end finally

        }//end addBtn_Click method

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstMovies.SelectedItem == null)
            {
                MessageBox.Show("Select a movie to remove.");
                return;
            }

            string movie = lstMovies.SelectedItem.ToString();

            movies.Remove(movie);
            lstMovies.Items.Remove(movie);

            lblStatus.Text = "Movie removed successfully.";
        }//end removeBtn_Click method

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string search = txtSearch.Text.ToLower();

            lstMovies.Items.Clear();

            foreach (string movie in movies)  // checks each movie 1 by 1
            {
                if (movie.ToLower().Contains(search)) // Contains checks if the movie contains the search string
                {           // ToLower makes the search case insensitive
                    lstMovies.Items.Add(movie);
                }// if checks if results were found
            }

            if (lstMovies.Items.Count == 0)
            {
                MessageBox.Show("No movies found.");
            }
        }//end searchBtn_Click method

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            lstMovies.Items.Clear();

            foreach (string movie in movies)
            {
                lstMovies.Items.Add(movie);
            }
        }//end showAllBtn_Click method


    }//end Form1 class
}//end namespace
