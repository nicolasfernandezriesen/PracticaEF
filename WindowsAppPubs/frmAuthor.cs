using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsAppPubs.AdminDatos;
using WindowsAppPubs.Models;
using static System.Windows.Forms.AxHost;

namespace WindowsAppPubs
{
    public partial class frmAuthor : Form
    {
        public frmAuthor()
        {
            InitializeComponent();
        }

        private void btnGetAll_Click(object sender, EventArgs e)
        {
            List<Author> list = DacAuthor.Listar();

            gridAuthor.DataSource = list;
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            string id = txtIdAuthor.Text;

            Author author= DacAuthor.TraerUno(id);

            MessageBox.Show(author.au_id + " " + author.au_fname + " " + author.au_lname + " " + author.phone + " " + author.address);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string id = txtIdAuthor.Text;

            Author author = DacAuthor.TraerUno(id);

            int filasAfectadas = DacAuthor.Eliminar(author);

            if(filasAfectadas > 0)
            {
                MessageBox.Show("Eliminacion completa y exitosa. Ahora se mostrara el elemento borrado.");
                MessageBox.Show("Store ID = " + author.au_id + ". Store Name = " + author.au_fname + " " + author.au_lname +". Store Address = " + author.address + ". Store City = " + author.city + ". Store State = " + author.state + ". Store Zip = " + author.zip);
                List<Author> authors = DacAuthor.Listar();

                gridAuthor.DataSource = authors;
            } 
            else
            {
                MessageBox.Show("Eliminaicon fallida, vuelve a intentarlo.");
            }
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            Author author = new Author();
            author.au_id = txtId.Text;
            author.au_fname = txtName.Text;
            author.au_lname = txtLname.Text;
            author.phone = txtPhone.Text;
            author.address = txtAddress.Text;
            author.city = txtCity.Text;
            author.state = txtState.Text;
            author.zip = txtZip.Text;

            int filasAfectadas = DacAuthor.Nuevo(author);

            if(filasAfectadas > 0)
            {
                MessageBox.Show("Creacion completa y exitosa. Ahora se mostrara el elemento creado.");
                MessageBox.Show("Store ID = " + author.au_id + ". Store Name = " + author.au_fname + " " + author.au_lname + ". Store Address = " + author.address + ". Store City = " + author.city + ". Store State = " + author.state + ". Store Zip = " + author.zip);
                List<Author> authors = DacAuthor.Listar();

                gridAuthor.DataSource = authors;
            }
            else
            {
                MessageBox.Show("Creacion fallida, vuelve a intentarlo.");
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Author author = new Author();
            author.au_id = txtId.Text;
            author.au_fname = txtName.Text;
            author.au_lname = txtLname.Text;
            author.phone = txtPhone.Text;
            author.address = txtAddress.Text;
            author.city = txtCity.Text;
            author.state = txtState.Text;
            author.zip = txtZip.Text;

            int filasAfectadas = DacAuthor.Modificar(author);

            if (filasAfectadas > 0)
            {
                MessageBox.Show("Modificacion completa y exitosa. Ahora se mostrara el elemento modificado.");
                MessageBox.Show("Store ID = " + author.au_id + ". Store Name = " + author.au_fname + " " + author.au_lname + ". Store Address = " + author.address + ". Store City = " + author.city + ". Store State = " + author.state + ". Store Zip = " + author.zip);
                List<Author> authors = DacAuthor.Listar();

                gridAuthor.DataSource = authors;
            }
            else
            {
                MessageBox.Show("Modificacion fallida, vuelve a intentarlo.");
            }
        }
    }
}
