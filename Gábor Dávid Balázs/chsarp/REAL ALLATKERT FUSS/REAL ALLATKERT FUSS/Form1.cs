using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace REAL_ALLATKERT_FUSS
{
    public partial class Form1 : Form
    {

        private List<Animal> animals = new List<Animal>()
        {
            new Animal("Panda", "Mammalia", 1),
            new Animal("Mókus", "Mammalia", 2),
            new Animal("Kutya", "Mammalia", 3),
            new Animal("Macska", "Mammalia", 4),
            new Animal("Bálna", "Mammalia", 5)
        };

        public Form1()
        {
            InitializeComponent();

            // DataGridView oszlopok létrehozása
            dgvAnimals.AutoGenerateColumns = false;

            DataGridViewTextBoxColumn nameColumn = new DataGridViewTextBoxColumn();
            nameColumn.DataPropertyName = "Name";
            nameColumn.HeaderText = "Név";
            dgvAnimals.Columns.Add(nameColumn);

            DataGridViewTextBoxColumn speciesColumn = new DataGridViewTextBoxColumn();
            speciesColumn.DataPropertyName = "Species";
            speciesColumn.HeaderText = "Faj";
            dgvAnimals.Columns.Add(speciesColumn);

            DataGridViewTextBoxColumn idColumn = new DataGridViewTextBoxColumn();
            idColumn.DataPropertyName = "ID";
            idColumn.HeaderText = "Azonosító";
            dgvAnimals.Columns.Add(idColumn);

            // ComboBox feltöltése alapértelmezett fajtákkal
            cmbSpecies.Items.Add("Mammalia");
            cmbSpecies.Items.Add("Reptilia");
            cmbSpecies.Items.Add("Aves");
            cmbSpecies.Items.Add("Amphibia");

            // DataGridView adatforrásának beállítása
            dgvAnimals.DataSource = animals;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string species = cmbSpecies.SelectedItem.ToString();
            int id;
            if (!int.TryParse(txtID.Text, out id))
            {
                MessageBox.Show("Az azonosítónak számnak kell lennie.");
                return;
            }

            Animal newAnimal = new Animal(name, species, id);
            animals.Add(newAnimal);
            dgvAnimals.DataSource = null;
            dgvAnimals.DataSource = animals;
            ClearInputFields();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvAnimals.SelectedRows.Count > 0)
            {
                int selectedIndex = dgvAnimals.SelectedRows[0].Index;
                animals.RemoveAt(selectedIndex);
                dgvAnimals.DataSource = null;
                dgvAnimals.DataSource = animals;
            }
            else
            {
                MessageBox.Show("Kérem válasszon ki egy sort a törléshez.");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text.ToLower();
            List<Animal> searchResults = new List<Animal>();

            foreach (Animal animal in animals)
            {
                if (animal.Name.ToLower().Contains(searchTerm) || animal.Species.ToLower().Contains(searchTerm))
                {
                    searchResults.Add(animal);
                }
            }

            dgvAnimals.DataSource = null;
            dgvAnimals.DataSource = searchResults;
        }

        private void ClearInputFields()
        {
            txtName.Clear();
            cmbSpecies.SelectedIndex = -1;
            txtID.Clear();
        }
    }

    public class Animal
    {
        public string Name { get; set; }
        public string Species { get; set; }
        public int ID { get; set; }

        public Animal(string name, string species, int id)
        {
            Name = name;
            Species = species;
            ID = id;
        }
    }
}