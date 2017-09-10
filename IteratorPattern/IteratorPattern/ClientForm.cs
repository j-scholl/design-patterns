using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IteratorPattern
{
    public partial class clientForm : Form
    {
        ConcreteAggregate agg = new ConcreteAggregate();

        public clientForm()
        {
            InitializeComponent();

            LoadAggregate(agg);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            agg.Add("Alliance");
            agg.Add("Danish Bears");
            agg.Add("Elements Pro");
            agg.Add("mousesports");
            agg.Add("Natus Vincere");
            agg.Add("OG");
            agg.Add("PENTA Sports");
            agg.Add("Team Liquid");
            agg.Add("Team Secret");
        }

        private void LoadAggregate(ConcreteAggregate agg)
        {

        }

        private void standardButton_Click(object sender, EventArgs e)
        {
            fullListBox.Items.Clear();

            Iterator iter = new StandardIterator(agg);
            for (iter.First(); !iter.IsDone(); iter.Next())
            {
                fullListBox.Items.Add(iter.CurrentItem());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fullListBox.Items.Clear();
        }

        private void otherIteratorButton_Click(object sender, EventArgs e)
        {
            fullListBox.Items.Clear();

            Iterator iter = new OtherIterator(agg);
            for (iter.First(); !iter.IsDone(); iter.Next())
            {
                fullListBox.Items.Add(iter.CurrentItem());
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            fullListBox.Items.Clear();

            Iterator iter = new SearchIterator(agg, searchTextBox.Text);
            for (iter.First(); !iter.IsDone(); iter.Next())
            {
                fullListBox.Items.Add(iter.CurrentItem());
            }
        }
    }
}
