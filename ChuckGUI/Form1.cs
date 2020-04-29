using ChuckNorrisAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChuckGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {

            PopulateCategories();

        }

        private async void button1_Click(object sender, EventArgs e)
        {
          Joke joke = await ChuckNorrisClient.GetRandomJoke();
          jokeBox.Text = joke.JokeText;
  
        }

        private async void PopulateCategories()
        {

            IEnumerable<string> list = await ChuckNorrisClient.GetCategories();
            

            foreach (string s in list)
            {
                cateBox.Items.Add(s);
            }
        }
    }
}
