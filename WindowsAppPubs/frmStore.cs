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

namespace WindowsAppPubs
{
    public partial class frmStore : Form
    {
        public frmStore()
        {
            InitializeComponent();
        }

        private void btnGetAll_Click(object sender, EventArgs e)
        {
            List<Store> stores = DacStore.Listar();

            gridStore.DataSource = stores;
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            string id = txtIdStore.Text;

            Store store = DacStore.TraerUno(id);
            MessageBox.Show("Store ID = " + store.stor_id + ". Store Name = " + store.stor_name + ". Store Address = " + store.stor_address + ". Store City = " + store.city + ". Store State = " + store.state + ". Store Zip = " + store.zip );
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string id = txtIdStore.Text;

            Store store = DacStore.TraerUno(id);

            int filaAfectada = DacStore.Eliminar(store);

            if (filaAfectada > 0)
            {
                MessageBox.Show("Eliminacion completa y exitosa. Ahora se mostrara el elemento borrado.");
                MessageBox.Show("Store ID = " + store.stor_id + ". Store Name = " + store.stor_name + ". Store Address = " + store.stor_address + ". Store City = " + store.city + ". Store State = " + store.state + ". Store Zip = " + store.zip);

                List<Store> stores = DacStore.Listar();

                gridStore.DataSource = stores;
            }
            else
            {
                MessageBox.Show("Eliminaicon fallida, vuelve a intentarlo.");
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Store store = new Store();

            store.stor_id= txtId.Text;
            store.stor_name= txtName.Text;
            store.stor_address= txtAddress.Text;
            store.city= txtCity.Text;
            store.state= txtState.Text;
            store.zip= txtZip.Text;

            int filaAfectada = DacStore.Nuevo(store);

            if (filaAfectada > 0)
            {
                MessageBox.Show("Creacion completa y exitosa. Ahora se mostrara el elemento creado.");
                MessageBox.Show("Store ID = " + store.stor_id + ". Store Name = " + store.stor_name + ". Store Address = " + store.stor_address + ". Store City = " + store.city + ". Store State = " + store.state + ". Store Zip = " + store.zip);
                
                
                List<Store> stores = DacStore.Listar();

                gridStore.DataSource = stores;
            }
            else
            {
                MessageBox.Show("Creacion fallida, vuelve a intentarlo.");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Store store = new Store();

            store.stor_id = txtId.Text;
            store.stor_name = txtName.Text;
            store.stor_address = txtAddress.Text;
            store.city = txtCity.Text;
            store.state = txtState.Text;
            store.zip = txtZip.Text;

            int filaAfectada = DacStore.Modificar(store);

            if (filaAfectada > 0)
            {
                MessageBox.Show("Modificacion completa y exitosa. Ahora se mostrara el elemento modificado.");
                MessageBox.Show("Store ID = " + store.stor_id + ". Store Name = " + store.stor_name + ". Store Address = " + store.stor_address + ". Store City = " + store.city + ". Store State = " + store.state + ". Store Zip = " + store.zip);

                List<Store> stores = DacStore.Listar();

                gridStore.DataSource = stores;
            }
            else
            {
                MessageBox.Show("Modificacion fallida, vuelve a intentarlo.");
            }
        }
    }
}
