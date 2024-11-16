namespace OOP2.View.AdditionalForms
{
    partial class DiscountModalWindow
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
            DiscountFornPanel = new Panel();
            CancelButton = new Button();
            OkButton = new Button();
            CategoryComboBox = new ComboBox();
            CategoryLabel = new Label();
            PercentDiscountLabel = new Label();
            DiscountFornPanel.SuspendLayout();
            SuspendLayout();
            // 
            // DiscountFornPanel
            // 
            DiscountFornPanel.Controls.Add(CancelButton);
            DiscountFornPanel.Controls.Add(OkButton);
            DiscountFornPanel.Controls.Add(CategoryComboBox);
            DiscountFornPanel.Controls.Add(CategoryLabel);
            DiscountFornPanel.Controls.Add(PercentDiscountLabel);
            DiscountFornPanel.Dock = DockStyle.Fill;
            DiscountFornPanel.Location = new Point(0, 0);
            DiscountFornPanel.Margin = new Padding(3, 4, 3, 4);
            DiscountFornPanel.Name = "DiscountFornPanel";
            DiscountFornPanel.Size = new Size(441, 199);
            DiscountFornPanel.TabIndex = 1;
            // 
            // CancelButton
            // 
            CancelButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CancelButton.BackColor = SystemColors.AppWorkspace;
            CancelButton.Location = new Point(295, 135);
            CancelButton.Margin = new Padding(3, 4, 3, 4);
            CancelButton.MaximumSize = new Size(106, 31);
            CancelButton.MinimumSize = new Size(62, 31);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(104, 31);
            CancelButton.TabIndex = 4;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = false;
            CancelButton.Click += CancelButton_Click;
            // 
            // OkButton
            // 
            OkButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            OkButton.BackColor = SystemColors.AppWorkspace;
            OkButton.Location = new Point(190, 135);
            OkButton.Margin = new Padding(3, 4, 3, 4);
            OkButton.MaximumSize = new Size(106, 31);
            OkButton.MinimumSize = new Size(62, 31);
            OkButton.Name = "OkButton";
            OkButton.Size = new Size(104, 31);
            OkButton.TabIndex = 3;
            OkButton.Text = "Ok";
            OkButton.UseVisualStyleBackColor = false;
            OkButton.Click += OkDiscountsButton_Click;
            // 
            // CategoryComboBox
            // 
            CategoryComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CategoryComboBox.FormattingEnabled = true;
            CategoryComboBox.Location = new Point(113, 61);
            CategoryComboBox.Margin = new Padding(3, 4, 3, 4);
            CategoryComboBox.MaximumSize = new Size(290, 0);
            CategoryComboBox.MaxLength = 242;
            CategoryComboBox.Name = "CategoryComboBox";
            CategoryComboBox.Size = new Size(288, 28);
            CategoryComboBox.TabIndex = 2;
            CategoryComboBox.SelectedIndexChanged += CategoryComboBox_SelectedIndexChanged;
            // 
            // CategoryLabel
            // 
            CategoryLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CategoryLabel.AutoSize = true;
            CategoryLabel.Location = new Point(14, 65);
            CategoryLabel.Name = "CategoryLabel";
            CategoryLabel.Size = new Size(72, 20);
            CategoryLabel.TabIndex = 1;
            CategoryLabel.Text = "Category:";
            // 
            // PercentDiscountLabel
            // 
            PercentDiscountLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            PercentDiscountLabel.AutoSize = true;
            PercentDiscountLabel.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            PercentDiscountLabel.Location = new Point(14, 12);
            PercentDiscountLabel.Name = "PercentDiscountLabel";
            PercentDiscountLabel.Size = new Size(158, 22);
            PercentDiscountLabel.TabIndex = 0;
            PercentDiscountLabel.Text = "Percent Discount:";
            // 
            // DiscountModalWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(441, 199);
            Controls.Add(DiscountFornPanel);
            Margin = new Padding(3, 4, 3, 4);
            MaximumSize = new Size(459, 246);
            MinimumSize = new Size(377, 208);
            Name = "DiscountModalWindow";
            Text = "AddDiscountForm";
            DiscountFornPanel.ResumeLayout(false);
            DiscountFornPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel DiscountFornPanel;
        private Button CancelButton;
        private Button OkButton;
        private ComboBox CategoryComboBox;
        private Label CategoryLabel;
        private Label PercentDiscountLabel;
    }
}