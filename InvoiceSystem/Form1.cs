using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace InvoiceSystem
{
    public partial class Form1 : Form
    {
        List<Details>detailsList=new List<Details>();
        Model Db;
        Details details;
        public Form1()
        {
            InitializeComponent();
            Db = new Model();
            var StoreQuery = Db.Store.Select(c => c.StoreName);
            foreach (var Store in StoreQuery)
            {
                StoreComBox.Items.Add(Store);
            }
            var ItemQuery = Db.Items.Select(i => i.Item);
            foreach (var item in ItemQuery)
            {
                ItemComBox.Items.Add(item);
            }
            var UnitQuery = Db.Unit.Select(U => U.UnitName);
            foreach (var Unit in UnitQuery)
            {
                UnitComBox.Items.Add(Unit);
            }

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
             details = new Details();
            details.TotalperItem = int.Parse(TotalPerItemTXT.Text);
            details.Discount = int.Parse(DiscountTXT.Text);
            details.NetperItem = int.Parse(NetPerItemTXT.Text);
            details.Price = int.Parse(PriceTXT.Text);
            details.Quantity = (int)QuantityUpDoown.Value;
            Items items = Db.Items.Single(i => i.Item == ItemComBox.SelectedItem.ToString());
            details.Items = items;
            Unit ItemUnit = Db.Unit.Single(u => u.UnitName == UnitComBox.SelectedItem.ToString());
            details.Unit = ItemUnit;
            detailsList.Add(details);

            TotalPerItemTXT.Text = "";
            NetPerItemTXT.Text = "";
            DiscountTXT.Text = "";
            PriceTXT.Text = "";
            QuantityUpDoown.Value = 0;
            ItemComBox.Text = "";
            UnitComBox.Text = "";
            MessageBox.Show("Adding.............");
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {  
            var InvoicesQuery = Db.Invoice.Select(i => i.InvoiceID);
            foreach (var item in InvoicesQuery)
            {
                if (item == int.Parse(InvoiceNoTXT.Text)|| InvoiceNoTXT.Text=="")
                {
                    MessageBox.Show("Invalid Invoice number");
                    InvoiceNoTXT.Text = "";                 
                    return;

                }
            }

            Invoice invoice = new Invoice();
            invoice.InvoiceID = int.Parse(InvoiceNoTXT.Text);
            invoice.Date = InvoiceDate.Value;
           int StoreId = Db.Store.Single(s => s.StoreName == StoreComBox.SelectedItem.ToString()).StoreID;
            Db.Invoice.Add(invoice);
            invoice.StoreID = StoreId;
            invoice.Total = int.Parse(TotalTXT.Text);
            invoice.Taxes = int.Parse(TaxesTXT.Text);
            invoice.TotalNet = int.Parse(NetTXT.Text);

            Db.SaveChanges();
            foreach (var item in detailsList)
            {

                invoice.Details.Add(item);
                Db.SaveChanges();
            }
            
          
            MessageBox.Show("Saved Successfully");
            InvoiceNoTXT.Text = "";
            StoreComBox.Text = "";
            TotalTXT.Text = "";
            NetTXT.Text = "";
            TaxesTXT.Text = "";
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            bool found = false;
            List<Details> details = new List<Details>();
            Invoice invoiceToBeDeleted = new Invoice();
            var InvoicesQuery = Db.Invoice;
            foreach (var item in InvoicesQuery)
            {
                if (item.InvoiceID == int.Parse(InvoiceNoTXT.Text))
                {
                    found = true;
                    invoiceToBeDeleted = item;
                    break;
                }
            }
            if(found==true)
            {
                foreach (var item in invoiceToBeDeleted.Details)
                {
                   
                    details.Add(item);
                }
                foreach (var item in details)
                {
                     Db.Details.Remove(item);
                    
                }
                Db.Invoice.Remove(invoiceToBeDeleted);
              
                Db.SaveChanges();
                MessageBox.Show("Deleted Successfully");
                InvoiceNoTXT.Text = "";
            }

            else
            {
                MessageBox.Show("This Invoice not Exist");
                InvoiceNoTXT.Text = "";
            }
        }
    }
}
