using FleaMarketApp.Presenter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FleaMarketApp.View
{
    public partial class NewOrderView : Form, INewOrderView
    {
        private NewOrderPresenter presenter;

        public NewOrderView()
        {
            InitializeComponent();

            presenter = new NewOrderPresenter(this);
        }

        public string OrdererName => txtName.Text;
        public string Address => txtAddress.Text;
        public string Email => txtEmail.Text;
        public string Phone => txtPhone.Text;

        public decimal ItemId { get; set; }

        public Form Form => this;

        public event EventHandler<EventArgs> BtnSaveOrderClicked;

        private void NewOrderView_FormClosed(object sender, FormClosedEventArgs e)
        {
            Owner.Enabled = true;
        }

        private void btnSaveOrder_Click(object sender, EventArgs e)
        {
            // Validate
            if (ValidateInputs())
            {
                BtnSaveOrderClicked?.Invoke(null, EventArgs.Empty);
            }
        }

        private bool ValidateInputs()
        {
            bool error = false;
            string dialogTitle = "Hiba a megrendeléskor";

            // Üresen maradt mező
            if (string.IsNullOrEmpty(txtName.Text) || 
                string.IsNullOrEmpty(txtAddress.Text) ||
                string.IsNullOrEmpty(txtEmail.Text) ||
                string.IsNullOrEmpty(txtPhone.Text))
            {
                MessageBox.Show("Nem maradhat mező üresen", dialogTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                error = true;
            }

            // E-Mail validáció
            Regex reg = new Regex(@"^[A-Z0-9._%+-]+@[A-Z0-9.-]+\.[A-Z]{2,6}$", RegexOptions.IgnoreCase);
            if (!reg.IsMatch(txtEmail.Text))
            {
                MessageBox.Show("Az e-mail cím nem helyes", dialogTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                error = true;
            }

                return !error;
        }
    }
}
