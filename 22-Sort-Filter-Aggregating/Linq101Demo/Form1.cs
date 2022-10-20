using LinqLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Linq101Demo
{
    public partial class Dashboard : Form
    {
        List<Person> people = ListManager.LoadSampleData();

        public Dashboard()
        {
            InitializeComponent();
            InitializeBindings();
        }

        private void InitializeBindings()
        {
            allPeopleDropdown.DataSource = people;
            allPeopleDropdown.DisplayMember = "FullName";

            var experiencedPeople = people.Where(x => x.YearsExperience >= 5).ToList();
            foreach (var experiencedPerson in experiencedPeople)
            {
                filteredPeopleList.Items.Add(experiencedPerson.FullName);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Person selectedPerson = (Person)allPeopleDropdown.SelectedItem;
            numericUpDown1.Value = selectedPerson.YearsExperience;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Person selectedPerson = (Person)allPeopleDropdown.SelectedItem;
            selectedPerson.YearsExperience = Convert.ToInt32(numericUpDown1.Value);
            UpdateBindings();
        }

        private void UpdateBindings()
        {

        }
    }
}
