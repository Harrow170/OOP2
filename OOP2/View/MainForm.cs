using OOP2.Model;
using OOP2.Services;
using OOP2.View.Tabs;
using System.Windows.Forms;




namespace OOP2
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Ïåðåìåííàÿ òèïà Store.
        /// </summary>
        private Store _store = new Store();
        public MainForm()
        {
            InitializeComponent();
            itemsTab1.Items = _store.Items;
            customer1.Customers = _store.Customers;

            cartTab1.Items = _store.Items;
            cartTab1.Customers = _store.Customers;

            ordersTab1.Customers = _store.Customers;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedIndex)
            {
                case 2:
                    cartTab1.RefreshData();
                    break;
                case 3:
                    ordersTab1.RefreshData();
                    break;
            }
        }
    }
}