namespace OOP2
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            tabControl1 = new TabControl();
            ItemTab = new TabPage();
            itemsTab1 = new View.Tabs.ItemsTab();
            CustomerTab = new TabPage();
            customer1 = new View.Tabs.CustomerTab();
            CartsTab = new TabPage();
            cartTab1 = new View.Tabs.CartTab();
            OrdersTab = new TabPage();
            ordersTab1 = new View.Tabs.OrdersTab();
            PriorityOrdersTab = new TabPage();
            priorityOrderTab1 = new View.Tabs.PriorityOrderTab();
            tabControl1.SuspendLayout();
            ItemTab.SuspendLayout();
            CustomerTab.SuspendLayout();
            CartsTab.SuspendLayout();
            OrdersTab.SuspendLayout();
            PriorityOrdersTab.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(ItemTab);
            tabControl1.Controls.Add(CustomerTab);
            tabControl1.Controls.Add(CartsTab);
            tabControl1.Controls.Add(OrdersTab);
            tabControl1.Controls.Add(PriorityOrdersTab);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1058, 820);
            tabControl1.TabIndex = 0;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // ItemTab
            // 
            ItemTab.Controls.Add(itemsTab1);
            ItemTab.Location = new Point(4, 29);
            ItemTab.Name = "ItemTab";
            ItemTab.Padding = new Padding(3, 3, 3, 3);
            ItemTab.Size = new Size(1050, 787);
            ItemTab.TabIndex = 0;
            ItemTab.Text = "Items";
            ItemTab.UseVisualStyleBackColor = true;
            // 
            // itemsTab1
            // 
            itemsTab1.Dock = DockStyle.Fill;
            itemsTab1.Location = new Point(3, 3);
            itemsTab1.MinimumSize = new Size(702, 556);
            itemsTab1.Name = "itemsTab1";
            itemsTab1.Size = new Size(1044, 781);
            itemsTab1.TabIndex = 0;
            // 
            // CustomerTab
            // 
            CustomerTab.Controls.Add(customer1);
            CustomerTab.Location = new Point(4, 29);
            CustomerTab.Name = "CustomerTab";
            CustomerTab.Padding = new Padding(3, 3, 3, 3);
            CustomerTab.Size = new Size(1050, 787);
            CustomerTab.TabIndex = 1;
            CustomerTab.Text = "Customers";
            CustomerTab.UseVisualStyleBackColor = true;
            // 
            // customer1
            // 
            customer1.Dock = DockStyle.Fill;
            customer1.Location = new Point(3, 3);
            customer1.MinimumSize = new Size(818, 583);
            customer1.Name = "customer1";
            customer1.Size = new Size(1044, 781);
            customer1.TabIndex = 0;
            // 
            // CartsTab
            // 
            CartsTab.Controls.Add(cartTab1);
            CartsTab.Location = new Point(4, 29);
            CartsTab.Margin = new Padding(3, 4, 3, 4);
            CartsTab.Name = "CartsTab";
            CartsTab.Size = new Size(1050, 787);
            CartsTab.TabIndex = 2;
            CartsTab.Text = "Carts";
            CartsTab.UseVisualStyleBackColor = true;
            // 
            // cartTab1
            // 
            cartTab1.Customers = null;
            cartTab1.Dock = DockStyle.Fill;
            cartTab1.Items = null;
            cartTab1.Location = new Point(0, 0);
            cartTab1.Margin = new Padding(3, 5, 3, 5);
            cartTab1.MinimumSize = new Size(635, 537);
            cartTab1.Name = "cartTab1";
            cartTab1.Size = new Size(1050, 787);
            cartTab1.TabIndex = 0;
            // 
            // OrdersTab
            // 
            OrdersTab.Controls.Add(ordersTab1);
            OrdersTab.Location = new Point(4, 29);
            OrdersTab.Margin = new Padding(3, 4, 3, 4);
            OrdersTab.Name = "OrdersTab";
            OrdersTab.Size = new Size(1050, 787);
            OrdersTab.TabIndex = 3;
            OrdersTab.Text = "Orders";
            OrdersTab.UseVisualStyleBackColor = true;
            // 
            // ordersTab1
            // 
            ordersTab1.Dock = DockStyle.Fill;
            ordersTab1.Location = new Point(0, 0);
            ordersTab1.Margin = new Padding(3, 5, 3, 5);
            ordersTab1.MinimumSize = new Size(921, 795);
            ordersTab1.Name = "ordersTab1";
            ordersTab1.Size = new Size(1050, 795);
            ordersTab1.TabIndex = 0;
            // 
            // PriorityOrdersTab
            // 
            PriorityOrdersTab.Controls.Add(priorityOrderTab1);
            PriorityOrdersTab.Location = new Point(4, 29);
            PriorityOrdersTab.Margin = new Padding(3, 4, 3, 4);
            PriorityOrdersTab.Name = "PriorityOrdersTab";
            PriorityOrdersTab.Padding = new Padding(3, 4, 3, 4);
            PriorityOrdersTab.Size = new Size(1050, 787);
            PriorityOrdersTab.TabIndex = 4;
            PriorityOrdersTab.Text = "PriorityOrders";
            PriorityOrdersTab.UseVisualStyleBackColor = true;
            // 
            // priorityOrderTab1
            // 
            priorityOrderTab1.Dock = DockStyle.Fill;
            priorityOrderTab1.Location = new Point(3, 4);
            priorityOrderTab1.Margin = new Padding(3, 5, 3, 5);
            priorityOrderTab1.Name = "priorityOrderTab1";
            priorityOrderTab1.Size = new Size(1044, 779);
            priorityOrderTab1.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1058, 820);
            Controls.Add(tabControl1);
            MinimumSize = new Size(928, 856);
            Name = "MainForm";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            ItemTab.ResumeLayout(false);
            CustomerTab.ResumeLayout(false);
            CartsTab.ResumeLayout(false);
            OrdersTab.ResumeLayout(false);
            PriorityOrdersTab.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage ItemTab;
        private TabPage CustomerTab;
        private OOP2.View.Tabs.ItemsTab itemsTab1;
        private OOP2.View.Tabs.CustomerTab customer1;
        private TabPage CartsTab;
        private OOP2.View.Tabs.CartTab cartTab1;
        private TabPage OrdersTab;
        private OOP2.View.Tabs.OrdersTab ordersTab1;
        private TabPage PriorityOrdersTab;
        private OOP2.View.Tabs.PriorityOrderTab priorityOrderTab1;
    }
}
