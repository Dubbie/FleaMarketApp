using FleaMarketApp.Presenter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FleaMarketApp.View
{
    public partial class OfferItemView : Form, IOfferItemView
    {
        private readonly OfferItemPresenter presenter;

        public OfferItemView()
        {
            InitializeComponent();

            presenter = new OfferItemPresenter(this);
        }

        public decimal ItemId { get; set; }

        public double Price { 
            get
            {
                if (double.TryParse(txtPrice.Text, out double price))
                {
                    return price;
                } else
                {
                    throw new InvalidOperationException("Nem szám lett megadva");
                }
            }
        }

        public Form Form => this;

        public event EventHandler<EventArgs> BtnOfferClicked;

        private void BtnOffer_Click(object sender, EventArgs e)
        {
            // Validáljuk, hogy egy nem üres, helyesen megadott ár van ott
            if (string.IsNullOrEmpty(txtPrice.Text) || !double.TryParse(txtPrice.Text, out _))
            {
                MessageBox.Show(
                    "Az eladásra bocsájtandó termék árát kötelező helyesen kitölteni.",
                    "Hiba a termék eladására bocsájtásakor",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            } else
            {
                BtnOfferClicked?.Invoke(this, EventArgs.Empty);
            }
        }

        private void OfferItemView_FormClosed(object sender, FormClosedEventArgs e)
        {
            Owner.Enabled = true;
        }
    }
}
