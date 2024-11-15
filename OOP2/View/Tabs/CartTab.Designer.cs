namespace OOP2.View.Tabs
{
    partial class CartTab
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            CustomerGroupBox = new GroupBox();
            CustomerGroupBox2 = new GroupBox();
            CreateOrderButton = new Button();
            AmountLabel = new Label();
            TotalCostLabel = new Label();
            ClearCartButton = new Button();
            RemoveItemButtton = new Button();
            CartListBox = new ListBox();
            CartLabel = new Label();
            CustomerLabel = new Label();
            CustomerComboBox = new ComboBox();
            ItemsGroupBox = new GroupBox();
            AddToCartButton = new Button();
            ItemsListBox = new ListBox();
            CustomerGroupBox.SuspendLayout();
            CustomerGroupBox2.SuspendLayout();
            ItemsGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // CustomerGroupBox
            // 
            CustomerGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CustomerGroupBox.BackgroundImageLayout = ImageLayout.None;
            CustomerGroupBox.Controls.Add(CustomerGroupBox2);
            CustomerGroupBox.Controls.Add(CartListBox);
            CustomerGroupBox.Controls.Add(CartLabel);
            CustomerGroupBox.Controls.Add(CustomerLabel);
            CustomerGroupBox.Controls.Add(CustomerComboBox);
            CustomerGroupBox.Location = new Point(229, 4);
            CustomerGroupBox.Margin = new Padding(3, 4, 3, 4);
            CustomerGroupBox.MinimumSize = new Size(349, 333);
            CustomerGroupBox.Name = "CustomerGroupBox";
            CustomerGroupBox.Padding = new Padding(3, 4, 3, 4);
            CustomerGroupBox.Size = new Size(409, 566);
            CustomerGroupBox.TabIndex = 12;
            CustomerGroupBox.TabStop = false;
            // 
            // CustomerGroupBox2
            // 
            CustomerGroupBox2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CustomerGroupBox2.Controls.Add(CreateOrderButton);
            CustomerGroupBox2.Controls.Add(AmountLabel);
            CustomerGroupBox2.Controls.Add(TotalCostLabel);
            CustomerGroupBox2.Controls.Add(ClearCartButton);
            CustomerGroupBox2.Controls.Add(RemoveItemButtton);
            CustomerGroupBox2.Location = new Point(7, 369);
            CustomerGroupBox2.Margin = new Padding(3, 4, 3, 4);
            CustomerGroupBox2.MinimumSize = new Size(343, 140);
            CustomerGroupBox2.Name = "CustomerGroupBox2";
            CustomerGroupBox2.Padding = new Padding(3, 4, 3, 4);
            CustomerGroupBox2.Size = new Size(397, 168);
            CustomerGroupBox2.TabIndex = 13;
            CustomerGroupBox2.TabStop = false;
            // 
            // CreateOrderButton
            // 
            CreateOrderButton.Location = new Point(7, 95);
            CreateOrderButton.Margin = new Padding(3, 4, 3, 4);
            CreateOrderButton.Name = "CreateOrderButton";
            CreateOrderButton.Size = new Size(127, 31);
            CreateOrderButton.TabIndex = 8;
            CreateOrderButton.Text = "Create Order";
            CreateOrderButton.UseVisualStyleBackColor = true;
            CreateOrderButton.Click += CreateOrderButton_Click;
            // 
            // AmountLabel
            // 
            AmountLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            AmountLabel.AutoSize = true;
            AmountLabel.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            AmountLabel.ForeColor = SystemColors.ControlText;
            AmountLabel.Location = new Point(313, 13);
            AmountLabel.Name = "AmountLabel";
            AmountLabel.Size = new Size(73, 20);
            AmountLabel.TabIndex = 6;
            AmountLabel.Text = "Amount:";
            // 
            // TotalCostLabel
            // 
            TotalCostLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            TotalCostLabel.AutoSize = true;
            TotalCostLabel.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            TotalCostLabel.Location = new Point(313, 49);
            TotalCostLabel.Name = "TotalCostLabel";
            TotalCostLabel.Size = new Size(72, 28);
            TotalCostLabel.TabIndex = 7;
            TotalCostLabel.Text = "44777";
            // 
            // ClearCartButton
            // 
            ClearCartButton.Location = new Point(273, 95);
            ClearCartButton.Margin = new Padding(3, 4, 3, 4);
            ClearCartButton.Name = "ClearCartButton";
            ClearCartButton.Size = new Size(113, 31);
            ClearCartButton.TabIndex = 10;
            ClearCartButton.Text = "Clear Cart";
            ClearCartButton.UseVisualStyleBackColor = true;
            ClearCartButton.Click += ClearCartButton_Click;
            // 
            // RemoveItemButtton
            // 
            RemoveItemButtton.Location = new Point(159, 95);
            RemoveItemButtton.Margin = new Padding(3, 4, 3, 4);
            RemoveItemButtton.Name = "RemoveItemButtton";
            RemoveItemButtton.Size = new Size(107, 31);
            RemoveItemButtton.TabIndex = 9;
            RemoveItemButtton.Text = "Remove Item";
            RemoveItemButtton.UseVisualStyleBackColor = true;
            RemoveItemButtton.Click += RemoveItemButtton_Click;
            // 
            // CartListBox
            // 
            CartListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CartListBox.FormattingEnabled = true;
            CartListBox.Location = new Point(16, 97);
            CartListBox.Margin = new Padding(3, 4, 3, 4);
            CartListBox.MinimumSize = new Size(307, 224);
            CartListBox.Name = "CartListBox";
            CartListBox.Size = new Size(348, 264);
            CartListBox.TabIndex = 11;
            // 
            // CartLabel
            // 
            CartLabel.AutoSize = true;
            CartLabel.Location = new Point(16, 60);
            CartLabel.Name = "CartLabel";
            CartLabel.Size = new Size(39, 20);
            CartLabel.TabIndex = 4;
            CartLabel.Text = "Cart:";
            // 
            // CustomerLabel
            // 
            CustomerLabel.AutoSize = true;
            CustomerLabel.Location = new Point(16, 25);
            CustomerLabel.Name = "CustomerLabel";
            CustomerLabel.Size = new Size(79, 20);
            CustomerLabel.TabIndex = 2;
            CustomerLabel.Text = "Customer: ";
            // 
            // CustomerComboBox
            // 
            CustomerComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CustomerComboBox.FormattingEnabled = true;
            CustomerComboBox.Location = new Point(105, 21);
            CustomerComboBox.Margin = new Padding(3, 4, 3, 4);
            CustomerComboBox.Name = "CustomerComboBox";
            CustomerComboBox.Size = new Size(259, 28);
            CustomerComboBox.TabIndex = 3;
            CustomerComboBox.SelectedIndexChanged += CustomerComboBox_SelectedIndexChanged;
            // 
            // ItemsGroupBox
            // 
            ItemsGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            ItemsGroupBox.Controls.Add(AddToCartButton);
            ItemsGroupBox.Controls.Add(ItemsListBox);
            ItemsGroupBox.Location = new Point(0, 0);
            ItemsGroupBox.Margin = new Padding(3, 4, 3, 4);
            ItemsGroupBox.MinimumSize = new Size(229, 533);
            ItemsGroupBox.Name = "ItemsGroupBox";
            ItemsGroupBox.Padding = new Padding(3, 4, 3, 4);
            ItemsGroupBox.Size = new Size(229, 574);
            ItemsGroupBox.TabIndex = 0;
            ItemsGroupBox.TabStop = false;
            ItemsGroupBox.Text = "Items";
            // 
            // AddToCartButton
            // 
            AddToCartButton.Dock = DockStyle.Bottom;
            AddToCartButton.Location = new Point(3, 530);
            AddToCartButton.Margin = new Padding(3, 4, 3, 4);
            AddToCartButton.MinimumSize = new Size(91, 40);
            AddToCartButton.Name = "AddToCartButton";
            AddToCartButton.Size = new Size(223, 40);
            AddToCartButton.TabIndex = 1;
            AddToCartButton.Text = "Add To Cart";
            AddToCartButton.UseVisualStyleBackColor = true;
            AddToCartButton.Click += AddToCartButton_Click;
            // 
            // ItemsListBox
            // 
            ItemsListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ItemsListBox.FormattingEnabled = true;
            ItemsListBox.Location = new Point(3, 25);
            ItemsListBox.Margin = new Padding(3, 4, 3, 4);
            ItemsListBox.Name = "ItemsListBox";
            ItemsListBox.Size = new Size(218, 464);
            ItemsListBox.TabIndex = 11;
            // 
            // CartTab
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ItemsGroupBox);
            Controls.Add(CustomerGroupBox);
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(635, 537);
            Name = "CartTab";
            Size = new Size(728, 578);
            CustomerGroupBox.ResumeLayout(false);
            CustomerGroupBox.PerformLayout();
            CustomerGroupBox2.ResumeLayout(false);
            CustomerGroupBox2.PerformLayout();
            ItemsGroupBox.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox CustomerGroupBox;
        private ListBox CartListBox;
        private Label CartLabel;
        private Label CustomerLabel;
        private ComboBox CustomerComboBox;
        private GroupBox ItemsGroupBox;
        private ListBox ItemsListBox;
        private Button AddToCartButton;
        private GroupBox CustomerGroupBox2;
        private Button CreateOrderButton;
        private Label AmountLabel;
        private Label TotalCostLabel;
        private Button ClearCartButton;
        private Button RemoveItemButtton;
    }
}
