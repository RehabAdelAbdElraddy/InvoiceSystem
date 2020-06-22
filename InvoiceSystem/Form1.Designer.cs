namespace InvoiceSystem
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.InvoiceNo = new System.Windows.Forms.Label();
            this.InvoiceNoTXT = new System.Windows.Forms.TextBox();
            this.invoiceDatelabel = new System.Windows.Forms.Label();
            this.Store = new System.Windows.Forms.Label();
            this.StoreComBox = new System.Windows.Forms.ComboBox();
            this.ItemComBox = new System.Windows.Forms.ComboBox();
            this.item = new System.Windows.Forms.Label();
            this.UnitComBox = new System.Windows.Forms.ComboBox();
            this.label5Unit = new System.Windows.Forms.Label();
            this.PriceTXT = new System.Windows.Forms.TextBox();
            this.Price = new System.Windows.Forms.Label();
            this.TotalPerItemTXT = new System.Windows.Forms.TextBox();
            this.Total = new System.Windows.Forms.Label();
            this.DiscountTXT = new System.Windows.Forms.TextBox();
            this.Discount = new System.Windows.Forms.Label();
            this.NetPerItemTXT = new System.Windows.Forms.TextBox();
            this.Net = new System.Windows.Forms.Label();
            this.AddBtn = new System.Windows.Forms.Button();
            this.NetTXT = new System.Windows.Forms.TextBox();
            this.Netlabel = new System.Windows.Forms.Label();
            this.TaxesTXT = new System.Windows.Forms.TextBox();
            this.taxes = new System.Windows.Forms.Label();
            this.TotalTXT = new System.Windows.Forms.TextBox();
            this.Totallabel = new System.Windows.Forms.Label();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.QuantityUpDoown = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.InvoiceDate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityUpDoown)).BeginInit();
            this.SuspendLayout();
            // 
            // InvoiceNo
            // 
            this.InvoiceNo.AutoSize = true;
            this.InvoiceNo.Location = new System.Drawing.Point(27, 23);
            this.InvoiceNo.Name = "InvoiceNo";
            this.InvoiceNo.Size = new System.Drawing.Size(79, 13);
            this.InvoiceNo.TabIndex = 0;
            this.InvoiceNo.Text = "InvoiceNumber";
            // 
            // InvoiceNoTXT
            // 
            this.InvoiceNoTXT.Location = new System.Drawing.Point(121, 20);
            this.InvoiceNoTXT.Name = "InvoiceNoTXT";
            this.InvoiceNoTXT.Size = new System.Drawing.Size(125, 20);
            this.InvoiceNoTXT.TabIndex = 1;
            // 
            // invoiceDatelabel
            // 
            this.invoiceDatelabel.AutoSize = true;
            this.invoiceDatelabel.Location = new System.Drawing.Point(290, 23);
            this.invoiceDatelabel.Name = "invoiceDatelabel";
            this.invoiceDatelabel.Size = new System.Drawing.Size(65, 13);
            this.invoiceDatelabel.TabIndex = 2;
            this.invoiceDatelabel.Text = "InvoiceDate";
            // 
            // Store
            // 
            this.Store.AutoSize = true;
            this.Store.Location = new System.Drawing.Point(56, 53);
            this.Store.Name = "Store";
            this.Store.Size = new System.Drawing.Size(33, 13);
            this.Store.TabIndex = 4;
            this.Store.Text = "Store";
            // 
            // StoreComBox
            // 
            this.StoreComBox.FormattingEnabled = true;
            this.StoreComBox.Location = new System.Drawing.Point(121, 50);
            this.StoreComBox.Name = "StoreComBox";
            this.StoreComBox.Size = new System.Drawing.Size(121, 21);
            this.StoreComBox.TabIndex = 5;
            // 
            // ItemComBox
            // 
            this.ItemComBox.FormattingEnabled = true;
            this.ItemComBox.Location = new System.Drawing.Point(59, 137);
            this.ItemComBox.Name = "ItemComBox";
            this.ItemComBox.Size = new System.Drawing.Size(121, 21);
            this.ItemComBox.TabIndex = 7;
            // 
            // item
            // 
            this.item.AutoSize = true;
            this.item.Location = new System.Drawing.Point(12, 143);
            this.item.Name = "item";
            this.item.Size = new System.Drawing.Size(29, 13);
            this.item.TabIndex = 6;
            this.item.Text = "Item";
            // 
            // UnitComBox
            // 
            this.UnitComBox.FormattingEnabled = true;
            this.UnitComBox.Location = new System.Drawing.Point(267, 140);
            this.UnitComBox.Name = "UnitComBox";
            this.UnitComBox.Size = new System.Drawing.Size(121, 21);
            this.UnitComBox.TabIndex = 9;
            // 
            // label5Unit
            // 
            this.label5Unit.AutoSize = true;
            this.label5Unit.Location = new System.Drawing.Point(216, 145);
            this.label5Unit.Name = "label5Unit";
            this.label5Unit.Size = new System.Drawing.Size(26, 13);
            this.label5Unit.TabIndex = 8;
            this.label5Unit.Text = "Unit";
            // 
            // PriceTXT
            // 
            this.PriceTXT.Location = new System.Drawing.Point(452, 140);
            this.PriceTXT.Name = "PriceTXT";
            this.PriceTXT.Size = new System.Drawing.Size(125, 20);
            this.PriceTXT.TabIndex = 11;
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.Location = new System.Drawing.Point(404, 143);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(30, 13);
            this.Price.TabIndex = 10;
            this.Price.Text = "Price";
            // 
            // TotalPerItemTXT
            // 
            this.TotalPerItemTXT.Location = new System.Drawing.Point(59, 178);
            this.TotalPerItemTXT.Name = "TotalPerItemTXT";
            this.TotalPerItemTXT.Size = new System.Drawing.Size(125, 20);
            this.TotalPerItemTXT.TabIndex = 13;
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.Location = new System.Drawing.Point(12, 181);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(31, 13);
            this.Total.TabIndex = 12;
            this.Total.Text = "Total";
            // 
            // DiscountTXT
            // 
            this.DiscountTXT.Location = new System.Drawing.Point(267, 178);
            this.DiscountTXT.Name = "DiscountTXT";
            this.DiscountTXT.Size = new System.Drawing.Size(125, 20);
            this.DiscountTXT.TabIndex = 15;
            // 
            // Discount
            // 
            this.Discount.AutoSize = true;
            this.Discount.Location = new System.Drawing.Point(214, 181);
            this.Discount.Name = "Discount";
            this.Discount.Size = new System.Drawing.Size(48, 13);
            this.Discount.TabIndex = 14;
            this.Discount.Text = "Discount";
            // 
            // NetPerItemTXT
            // 
            this.NetPerItemTXT.Location = new System.Drawing.Point(452, 181);
            this.NetPerItemTXT.Name = "NetPerItemTXT";
            this.NetPerItemTXT.Size = new System.Drawing.Size(125, 20);
            this.NetPerItemTXT.TabIndex = 17;
            // 
            // Net
            // 
            this.Net.AutoSize = true;
            this.Net.Location = new System.Drawing.Point(404, 184);
            this.Net.Name = "Net";
            this.Net.Size = new System.Drawing.Size(24, 13);
            this.Net.TabIndex = 16;
            this.Net.Text = "Net";
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AddBtn.Font = new System.Drawing.Font("Tekton Pro Ext", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.AddBtn.Location = new System.Drawing.Point(690, 140);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(98, 68);
            this.AddBtn.TabIndex = 18;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // NetTXT
            // 
            this.NetTXT.Location = new System.Drawing.Point(137, 384);
            this.NetTXT.Name = "NetTXT";
            this.NetTXT.Size = new System.Drawing.Size(125, 20);
            this.NetTXT.TabIndex = 20;
            // 
            // Netlabel
            // 
            this.Netlabel.AutoSize = true;
            this.Netlabel.Location = new System.Drawing.Point(58, 384);
            this.Netlabel.Name = "Netlabel";
            this.Netlabel.Size = new System.Drawing.Size(24, 13);
            this.Netlabel.TabIndex = 19;
            this.Netlabel.Text = "Net";
            // 
            // TaxesTXT
            // 
            this.TaxesTXT.Location = new System.Drawing.Point(137, 348);
            this.TaxesTXT.Name = "TaxesTXT";
            this.TaxesTXT.Size = new System.Drawing.Size(125, 20);
            this.TaxesTXT.TabIndex = 22;
            // 
            // taxes
            // 
            this.taxes.AutoSize = true;
            this.taxes.Location = new System.Drawing.Point(58, 351);
            this.taxes.Name = "taxes";
            this.taxes.Size = new System.Drawing.Size(36, 13);
            this.taxes.TabIndex = 21;
            this.taxes.Text = "Taxes";
            // 
            // TotalTXT
            // 
            this.TotalTXT.Location = new System.Drawing.Point(137, 312);
            this.TotalTXT.Name = "TotalTXT";
            this.TotalTXT.Size = new System.Drawing.Size(125, 20);
            this.TotalTXT.TabIndex = 24;
            // 
            // Totallabel
            // 
            this.Totallabel.AutoSize = true;
            this.Totallabel.Location = new System.Drawing.Point(58, 319);
            this.Totallabel.Name = "Totallabel";
            this.Totallabel.Size = new System.Drawing.Size(31, 13);
            this.Totallabel.TabIndex = 23;
            this.Totallabel.Text = "Total";
            // 
            // SaveBtn
            // 
            this.SaveBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SaveBtn.Font = new System.Drawing.Font("Tekton Pro Ext", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.SaveBtn.Location = new System.Drawing.Point(293, 326);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(125, 52);
            this.SaveBtn.TabIndex = 25;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = false;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.DeleteBtn.Font = new System.Drawing.Font("Tekton Pro Ext", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.DeleteBtn.Location = new System.Drawing.Point(452, 326);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(143, 52);
            this.DeleteBtn.TabIndex = 26;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // QuantityUpDoown
            // 
            this.QuantityUpDoown.Location = new System.Drawing.Point(638, 141);
            this.QuantityUpDoown.Name = "QuantityUpDoown";
            this.QuantityUpDoown.Size = new System.Drawing.Size(46, 20);
            this.QuantityUpDoown.TabIndex = 27;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(583, 145);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 13);
            this.label13.TabIndex = 28;
            this.label13.Text = "Quantity";
            // 
            // InvoiceDate
            // 
            this.InvoiceDate.Location = new System.Drawing.Point(361, 20);
            this.InvoiceDate.Name = "InvoiceDate";
            this.InvoiceDate.Size = new System.Drawing.Size(200, 20);
            this.InvoiceDate.TabIndex = 29;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.InvoiceDate);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.QuantityUpDoown);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.TotalTXT);
            this.Controls.Add(this.Totallabel);
            this.Controls.Add(this.TaxesTXT);
            this.Controls.Add(this.taxes);
            this.Controls.Add(this.NetTXT);
            this.Controls.Add(this.Netlabel);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.NetPerItemTXT);
            this.Controls.Add(this.Net);
            this.Controls.Add(this.DiscountTXT);
            this.Controls.Add(this.Discount);
            this.Controls.Add(this.TotalPerItemTXT);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.PriceTXT);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.UnitComBox);
            this.Controls.Add(this.label5Unit);
            this.Controls.Add(this.ItemComBox);
            this.Controls.Add(this.item);
            this.Controls.Add(this.StoreComBox);
            this.Controls.Add(this.Store);
            this.Controls.Add(this.invoiceDatelabel);
            this.Controls.Add(this.InvoiceNoTXT);
            this.Controls.Add(this.InvoiceNo);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.QuantityUpDoown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label InvoiceNo;
        private System.Windows.Forms.TextBox InvoiceNoTXT;
        private System.Windows.Forms.Label invoiceDatelabel;
        private System.Windows.Forms.Label Store;
        private System.Windows.Forms.ComboBox StoreComBox;
        private System.Windows.Forms.ComboBox ItemComBox;
        private System.Windows.Forms.Label item;
        private System.Windows.Forms.ComboBox UnitComBox;
        private System.Windows.Forms.Label label5Unit;
        private System.Windows.Forms.TextBox PriceTXT;
        private System.Windows.Forms.Label Price;
        private System.Windows.Forms.TextBox TotalPerItemTXT;
        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.TextBox DiscountTXT;
        private System.Windows.Forms.Label Discount;
        private System.Windows.Forms.TextBox NetPerItemTXT;
        private System.Windows.Forms.Label Net;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.TextBox NetTXT;
        private System.Windows.Forms.Label Netlabel;
        private System.Windows.Forms.TextBox TaxesTXT;
        private System.Windows.Forms.Label taxes;
        private System.Windows.Forms.TextBox TotalTXT;
        private System.Windows.Forms.Label Totallabel;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.NumericUpDown QuantityUpDoown;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker InvoiceDate;
    }
}

