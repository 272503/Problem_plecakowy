using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Problem_plecakowy; // Upewnij się, że ta przestrzeń nazw pasuje do klasy Problem

namespace Aplikacja
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Czyszczenie wyników
            items_box.Items.Clear();
            results_box.Items.Clear();

            // Pobieranie i walidacja danych wejściowych
            bool isValid = true; // Flaga do sprawdzenia poprawności wszystkich pól

            // Sprawdzenie liczby przedmiotów
            if (!int.TryParse(num_items.Text, out int numItems) || numItems <= 0 || numItems > 1000)
            {
                num_items.BackColor = Color.LightCoral; // Podświetlenie na czerwono
                isValid = false;
            }
            else
            {
                num_items.BackColor = Color.White; // Przywrócenie białego tła
            }

            // Sprawdzenie ziarna losowości
            if (!int.TryParse(seed.Text, out int _seed))
            {
                seed.BackColor = Color.LightCoral;
                isValid = false;
            }
            else
            {
                seed.BackColor = Color.White;
            }

            // Sprawdzenie pojemności plecaka
            if (!int.TryParse(capacity.Text, out int _capacity) || _capacity <= 0 || _capacity > 10000)
            {
                capacity.BackColor = Color.LightCoral;
                isValid = false;
            }
            else
            {
                capacity.BackColor = Color.White;
            }

            // Jeśli jakiekolwiek pole jest niepoprawne, przerwij działanie i wyświetl komunikat
            if (!isValid)
            {
                MessageBox.Show("Popraw błędy w formularzu. Sprawdź podświetlone pola.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            // Tworzenie problemu plecakowego
            Problem problem = new Problem(numItems, _seed);

            // Wyświetlenie wygenerowanych przedmiotów w listBox1
            foreach (var item in problem.Items)
            {
                items_box.Items.Add($"no.: {item.Id}  v: {item.Value}  w: {item.Weight}");
            }

            // Rozwiązanie problemu plecakowego
            Result result = problem.Solve(_capacity);

            // Wyświetlenie wyniku w listBox2
            results_box.Items.Add($"items: {string.Join(",", result.UsedItems)}");
            results_box.Items.Add($"total value: {result.TotalValue}");
            results_box.Items.Add($"total weight: {result.TotalWeight}");
        }

       



        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }
    }
}
