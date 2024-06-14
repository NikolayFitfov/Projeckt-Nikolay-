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
using Zadacha6Nikolay.Controller;
using Zadacha6Nikolay.Model;

namespace Zadacha6Nikolay
{
    public partial class Form1 : Form
    {
        AnimalController controllerAnimal = new AnimalController();
        BreedController breedController = new BreedController();
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Breed> allbreed  = breedController.GetBreeds();
            cmb1.DataSource = allbreed;
            cmb1.DisplayMember = "Name";
            cmb1.ValueMember = "Id";
            
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt4.Text) || txt4.Text == "")
            {
                MessageBox.Show("Vuvedete danni!");
                txt4.Focus();
                return;
            }
            Animal newAnimal = new Animal();
            newAnimal.Age = int.Parse(txt3.Text);
            newAnimal.Name = txt4.Text;
            newAnimal.BreedId = (int)cmb1.SelectedValue;
            controllerAnimal.Create(newAnimal);
            MessageBox.Show("Успешно е направен запис!");
        }
        private void ClearScreen()
        {
            txt1?.Clear();
            txt4.Clear();
            txt3?.Clear();
            cmb1.Text = "";
        }

        private void lbl4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            int findId = 0;
            if(string.IsNullOrEmpty(txt1.Text) || !txt1.Text.All(char.IsDigit))
            {
                MessageBox.Show("Въведете Id за търсене!");
                txt1.BackColor = Color.Green;
                txt1.Focus();
                return;
            }
            else
            {
                findId = int.Parse(txt1.Text);
            }
            Animal animal = controllerAnimal.Get(findId);
            if (animal == null)
            {
                MessageBox.Show("Няма такъв запис в БД! \n Въведете Id за търсене");
                txt1.BackColor = Color.Green;
                txt1.Focus();
                return;
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            int findId = 0;
            if (string.IsNullOrEmpty(txt1.Text) || !txt1.Text.All(char.IsDigit))
            {
                MessageBox.Show("Въведете Id за търсене!");
                txt1.BackColor = Color.Green;
                txt1.Focus();
                return;
            }
            else
            {
                findId = int.Parse(txt1.Text);
            }
            Animal animal = controllerAnimal.Get(findId);
            if (animal == null)
            {
                MessageBox.Show("Няма такъв запис в БД! \n Въведете Id за търсене");
                txt1.BackColor = Color.Green;
                txt1.Focus();
                return;
            }
        }
    }
}
