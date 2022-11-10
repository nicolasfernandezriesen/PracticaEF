using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsAppPubs.Models;

namespace WindowsAppPubs
{
    public partial class Form1 : Form
    {
        PubsContext context = new PubsContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetAll_Click(object sender, EventArgs e)
        {
            List<Publisher> publishers = context.Publishers.ToList();

            gridPublishers.DataSource = publishers;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Publisher publisher = new Publisher() {pub_id="10", pub_name="Rokkolosss", city="Mar del Plata", country="Argentina", state="BS"};

            context.Publishers.Add(publisher);

            int i = context.SaveChanges();

            if (i > 0)
            {
                MessageBox.Show("Publisher creado");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string id = "10";

            Publisher publisher = context.Publishers.Find(id);
            if (publisher != null) 
            {
                publisher.pub_name = "ElendVin";

                int i = context.SaveChanges();

                if (i > 0)
                {
                    MessageBox.Show("Nuevo nombre del publisher " + publisher.pub_name);
                }
            }
        }

        private void btnDeleted_Click(object sender, EventArgs e)
        {
            string id = "10";

            var publisher = context.Publishers.Find(id);

            if (publisher != null)
            {
                context.Publishers.Remove(publisher);

                int i = context.SaveChanges();
                if(i > 0)
                {
                    MessageBox.Show("El publisher " + publisher.pub_name + " se ha borrado");
                }
            }
        }
    }
}
