namespace ClothesShop.WinForms
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            pnlHeader = new Panel();
            lblSubtitle = new Label();
            lblTitle = new Label();
            pnlLeft = new Panel();
            lblItemTitle = new Label();
            lblSelectedDetailsTitle = new Label();
            pnlStatsCard = new Panel();
            lblStockValue = new Label();
            lblStockTitle = new Label();
            lblPriceValue = new Label();
            lblPriceTitle = new Label();
            comboItems = new ComboBox();
            lblSelectCloth = new Label();
            pnlRight = new Panel();
            lblTransactionTitle = new Label();
            pnlSellCard = new Panel();
            btnSell = new Button();
            numSell = new NumericUpDown();
            lblSellQty = new Label();
            lblSellHeader = new Label();
            pnlPurchaseCard = new Panel();
            btnPurchase = new Button();
            numPurchase = new NumericUpDown();
            lblPurchaseQty = new Label();
            lblPurchaseHeader = new Label();
            pnlBottom = new Panel();
            txtActivityLog = new RichTextBox();
            lblLogTitle = new Label();
            pnlHeader.SuspendLayout();
            pnlLeft.SuspendLayout();
            pnlStatsCard.SuspendLayout();
            pnlRight.SuspendLayout();
            pnlSellCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numSell).BeginInit();
            pnlPurchaseCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numPurchase).BeginInit();
            pnlBottom.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(243, 244, 246);
            pnlHeader.Controls.Add(lblSubtitle);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(950, 95);
            pnlHeader.TabIndex = 0;
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubtitle.ForeColor = Color.FromArgb(75, 85, 99);
            lblSubtitle.Location = new Point(25, 55);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(365, 17);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Enterprise 3-Tier Inventory Management Solution via ADO.NET";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(17, 24, 39);
            lblTitle.Location = new Point(20, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(418, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "THREADS & TRENDS WAREHOUSE";
            // 
            // pnlLeft
            // 
            pnlLeft.BackColor = Color.White;
            pnlLeft.BorderStyle = BorderStyle.FixedSingle;
            pnlLeft.Controls.Add(lblItemTitle);
            pnlLeft.Controls.Add(lblSelectedDetailsTitle);
            pnlLeft.Controls.Add(pnlStatsCard);
            pnlLeft.Controls.Add(comboItems);
            pnlLeft.Controls.Add(lblSelectCloth);
            pnlLeft.Location = new Point(20, 115);
            pnlLeft.Name = "pnlLeft";
            pnlLeft.Padding = new Padding(20);
            pnlLeft.Size = new Size(440, 360);
            pnlLeft.TabIndex = 1;
            // 
            // lblItemTitle
            // 
            lblItemTitle.AutoSize = true;
            lblItemTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblItemTitle.ForeColor = Color.FromArgb(17, 24, 39);
            lblItemTitle.Location = new Point(20, 12);
            lblItemTitle.Name = "lblItemTitle";
            lblItemTitle.Size = new Size(191, 21);
            lblItemTitle.TabIndex = 5;
            lblItemTitle.Text = "INVENTORY SELECTION";
            // 
            // lblSelectedDetailsTitle
            // 
            lblSelectedDetailsTitle.AutoSize = true;
            lblSelectedDetailsTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSelectedDetailsTitle.ForeColor = Color.FromArgb(55, 65, 81);
            lblSelectedDetailsTitle.Location = new Point(20, 134);
            lblSelectedDetailsTitle.Name = "lblSelectedDetailsTitle";
            lblSelectedDetailsTitle.Size = new Size(138, 19);
            lblSelectedDetailsTitle.TabIndex = 4;
            lblSelectedDetailsTitle.Text = "Selected Item State";
            // 
            // pnlStatsCard
            // 
            pnlStatsCard.BackColor = Color.FromArgb(249, 250, 251);
            pnlStatsCard.BorderStyle = BorderStyle.FixedSingle;
            pnlStatsCard.Controls.Add(lblStockValue);
            pnlStatsCard.Controls.Add(lblStockTitle);
            pnlStatsCard.Controls.Add(lblPriceValue);
            pnlStatsCard.Controls.Add(lblPriceTitle);
            pnlStatsCard.Location = new Point(20, 160);
            pnlStatsCard.Name = "pnlStatsCard";
            pnlStatsCard.Size = new Size(400, 177);
            pnlStatsCard.TabIndex = 3;
            // 
            // lblStockValue
            // 
            lblStockValue.AutoSize = true;
            lblStockValue.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStockValue.ForeColor = Color.FromArgb(17, 24, 39);
            lblStockValue.Location = new Point(20, 115);
            lblStockValue.Name = "lblStockValue";
            lblStockValue.Size = new Size(160, 45);
            lblStockValue.TabIndex = 3;
            lblStockValue.Text = "000 Units";
            // 
            // lblStockTitle
            // 
            lblStockTitle.AutoSize = true;
            lblStockTitle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblStockTitle.ForeColor = Color.FromArgb(75, 85, 99);
            lblStockTitle.Location = new Point(20, 95);
            lblStockTitle.Name = "lblStockTitle";
            lblStockTitle.Size = new Size(122, 17);
            lblStockTitle.TabIndex = 2;
            lblStockTitle.Text = "AVAILABLE STOCK";
            // 
            // lblPriceValue
            // 
            lblPriceValue.AutoSize = true;
            lblPriceValue.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPriceValue.ForeColor = Color.FromArgb(17, 24, 39);
            lblPriceValue.Location = new Point(20, 40);
            lblPriceValue.Name = "lblPriceValue";
            lblPriceValue.Size = new Size(121, 45);
            lblPriceValue.TabIndex = 1;
            lblPriceValue.Text = "PKR 0";
            // 
            // lblPriceTitle
            // 
            lblPriceTitle.AutoSize = true;
            lblPriceTitle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblPriceTitle.ForeColor = Color.FromArgb(75, 85, 99);
            lblPriceTitle.Location = new Point(20, 20);
            lblPriceTitle.Name = "lblPriceTitle";
            lblPriceTitle.Size = new Size(126, 17);
            lblPriceTitle.TabIndex = 0;
            lblPriceTitle.Text = "UNIT RETAIL PRICE";
            // 
            // comboItems
            // 
            comboItems.BackColor = Color.White;
            comboItems.DropDownStyle = ComboBoxStyle.DropDownList;
            comboItems.FlatStyle = FlatStyle.Standard;
            comboItems.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboItems.ForeColor = Color.Black;
            comboItems.FormattingEnabled = true;
            comboItems.Location = new Point(20, 80);
            comboItems.Name = "comboItems";
            comboItems.Size = new Size(400, 28);
            comboItems.TabIndex = 1;
            comboItems.SelectedIndexChanged += comboItems_SelectedIndexChanged;
            // 
            // lblSelectCloth
            // 
            lblSelectCloth.AutoSize = true;
            lblSelectCloth.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSelectCloth.ForeColor = Color.FromArgb(75, 85, 99);
            lblSelectCloth.Location = new Point(20, 55);
            lblSelectCloth.Name = "lblSelectCloth";
            lblSelectCloth.Size = new Size(147, 17);
            lblSelectCloth.TabIndex = 0;
            lblSelectCloth.Text = "Select Garment / Cloth:";
            // 
            // pnlRight
            // 
            pnlRight.BackColor = Color.White;
            pnlRight.BorderStyle = BorderStyle.FixedSingle;
            pnlRight.Controls.Add(lblTransactionTitle);
            pnlRight.Controls.Add(pnlSellCard);
            pnlRight.Controls.Add(pnlPurchaseCard);
            pnlRight.Location = new Point(480, 115);
            pnlRight.Name = "pnlRight";
            pnlRight.Padding = new Padding(20);
            pnlRight.Size = new Size(450, 360);
            pnlRight.TabIndex = 2;
            // 
            // lblTransactionTitle
            // 
            lblTransactionTitle.AutoSize = true;
            lblTransactionTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTransactionTitle.ForeColor = Color.FromArgb(17, 24, 39);
            lblTransactionTitle.Location = new Point(20, 12);
            lblTransactionTitle.Name = "lblTransactionTitle";
            lblTransactionTitle.Size = new Size(218, 21);
            lblTransactionTitle.TabIndex = 6;
            lblTransactionTitle.Text = "STOCK TRANSACTIONS HUB";
            // 
            // pnlSellCard
            // 
            pnlSellCard.BackColor = Color.FromArgb(249, 250, 251);
            pnlSellCard.BorderStyle = BorderStyle.FixedSingle;
            pnlSellCard.Controls.Add(btnSell);
            pnlSellCard.Controls.Add(numSell);
            pnlSellCard.Controls.Add(lblSellQty);
            pnlSellCard.Controls.Add(lblSellHeader);
            pnlSellCard.Location = new Point(20, 203);
            pnlSellCard.Name = "pnlSellCard";
            pnlSellCard.Size = new Size(410, 134);
            pnlSellCard.TabIndex = 1;
            // 
            // btnSell
            // 
            btnSell.BackColor = Color.FromArgb(243, 244, 246);
            btnSell.Cursor = Cursors.Hand;
            btnSell.FlatAppearance.BorderColor = Color.FromArgb(209, 213, 219);
            btnSell.FlatStyle = FlatStyle.Flat;
            btnSell.Font = new Font("Segoe UI", 10.25F, FontStyle.Bold);
            btnSell.ForeColor = Color.Black;
            btnSell.Location = new Point(200, 68);
            btnSell.Name = "btnSell";
            btnSell.Size = new Size(190, 42);
            btnSell.TabIndex = 3;
            btnSell.Text = "Ship/Sell Dispatch";
            btnSell.UseVisualStyleBackColor = false;
            btnSell.Click += btnSell_Click;
            // 
            // numSell
            // 
            numSell.BackColor = Color.White;
            numSell.BorderStyle = BorderStyle.FixedSingle;
            numSell.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            numSell.ForeColor = Color.Black;
            numSell.Location = new Point(20, 75);
            numSell.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numSell.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numSell.Name = "numSell";
            numSell.Size = new Size(150, 29);
            numSell.TabIndex = 2;
            numSell.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblSellQty
            // 
            lblSellQty.AutoSize = true;
            lblSellQty.Font = new Font("Segoe UI", 9F);
            lblSellQty.ForeColor = Color.FromArgb(75, 85, 99);
            lblSellQty.Location = new Point(20, 52);
            lblSellQty.Name = "lblSellQty";
            lblSellQty.Size = new Size(125, 15);
            lblSellQty.TabIndex = 1;
            lblSellQty.Text = "Quantity to Sell / Ship:";
            // 
            // lblSellHeader
            // 
            lblSellHeader.AutoSize = true;
            lblSellHeader.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblSellHeader.ForeColor = Color.FromArgb(17, 24, 39);
            lblSellHeader.Location = new Point(15, 15);
            lblSellHeader.Name = "lblSellHeader";
            lblSellHeader.Size = new Size(159, 19);
            lblSellHeader.TabIndex = 0;
            lblSellHeader.Text = "Sales / Customer Order";
            // 
            // pnlPurchaseCard
            // 
            pnlPurchaseCard.BackColor = Color.FromArgb(249, 250, 251);
            pnlPurchaseCard.BorderStyle = BorderStyle.FixedSingle;
            pnlPurchaseCard.Controls.Add(btnPurchase);
            pnlPurchaseCard.Controls.Add(numPurchase);
            pnlPurchaseCard.Controls.Add(lblPurchaseQty);
            pnlPurchaseCard.Controls.Add(lblPurchaseHeader);
            pnlPurchaseCard.Location = new Point(20, 50);
            pnlPurchaseCard.Name = "pnlPurchaseCard";
            pnlPurchaseCard.Size = new Size(410, 134);
            pnlPurchaseCard.TabIndex = 0;
            // 
            // btnPurchase
            // 
            btnPurchase.BackColor = Color.FromArgb(243, 244, 246);
            btnPurchase.Cursor = Cursors.Hand;
            btnPurchase.FlatAppearance.BorderColor = Color.FromArgb(209, 213, 219);
            btnPurchase.FlatStyle = FlatStyle.Flat;
            btnPurchase.Font = new Font("Segoe UI", 10.25F, FontStyle.Bold);
            btnPurchase.ForeColor = Color.Black;
            btnPurchase.Location = new Point(200, 68);
            btnPurchase.Name = "btnPurchase";
            btnPurchase.Size = new Size(190, 42);
            btnPurchase.TabIndex = 3;
            btnPurchase.Text = "Purchase Stock In";
            btnPurchase.UseVisualStyleBackColor = false;
            btnPurchase.Click += btnPurchase_Click;
            // 
            // numPurchase
            // 
            numPurchase.BackColor = Color.White;
            numPurchase.BorderStyle = BorderStyle.FixedSingle;
            numPurchase.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            numPurchase.ForeColor = Color.Black;
            numPurchase.Location = new Point(20, 75);
            numPurchase.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numPurchase.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numPurchase.Name = "numPurchase";
            numPurchase.Size = new Size(150, 29);
            numPurchase.TabIndex = 2;
            numPurchase.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblPurchaseQty
            // 
            lblPurchaseQty.AutoSize = true;
            lblPurchaseQty.Font = new Font("Segoe UI", 9F);
            lblPurchaseQty.ForeColor = Color.FromArgb(75, 85, 99);
            lblPurchaseQty.Location = new Point(20, 52);
            lblPurchaseQty.Name = "lblPurchaseQty";
            lblPurchaseQty.Size = new Size(149, 15);
            lblPurchaseQty.TabIndex = 1;
            lblPurchaseQty.Text = "Quantity to Restock / Procure:";
            // 
            // lblPurchaseHeader
            // 
            lblPurchaseHeader.AutoSize = true;
            lblPurchaseHeader.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPurchaseHeader.ForeColor = Color.FromArgb(17, 24, 39);
            lblPurchaseHeader.Location = new Point(15, 15);
            lblPurchaseHeader.Name = "lblPurchaseHeader";
            lblPurchaseHeader.Size = new Size(174, 19);
            lblPurchaseHeader.TabIndex = 0;
            lblPurchaseHeader.Text = "Procurement / Purchase";
            // 
            // pnlBottom
            // 
            pnlBottom.BackColor = Color.White;
            pnlBottom.BorderStyle = BorderStyle.FixedSingle;
            pnlBottom.Controls.Add(txtActivityLog);
            pnlBottom.Controls.Add(lblLogTitle);
            pnlBottom.Location = new Point(20, 490);
            pnlBottom.Name = "pnlBottom";
            pnlBottom.Padding = new Padding(20);
            pnlBottom.Size = new Size(910, 150);
            pnlBottom.TabIndex = 3;
            // 
            // txtActivityLog
            // 
            txtActivityLog.BackColor = Color.FromArgb(249, 250, 251);
            txtActivityLog.BorderStyle = BorderStyle.None;
            txtActivityLog.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtActivityLog.ForeColor = Color.Black;
            txtActivityLog.Location = new Point(20, 45);
            txtActivityLog.Name = "txtActivityLog";
            txtActivityLog.ReadOnly = true;
            txtActivityLog.ScrollBars = RichTextBoxScrollBars.Vertical;
            txtActivityLog.Size = new Size(870, 85);
            txtActivityLog.TabIndex = 7;
            txtActivityLog.Text = "";
            // 
            // lblLogTitle
            // 
            lblLogTitle.AutoSize = true;
            lblLogTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblLogTitle.ForeColor = Color.FromArgb(17, 24, 39);
            lblLogTitle.Location = new Point(20, 15);
            lblLogTitle.Name = "lblLogTitle";
            lblLogTitle.Size = new Size(207, 20);
            lblLogTitle.TabIndex = 6;
            lblLogTitle.Text = "REAL-TIME LOGS & AUDIT TRAIL";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 244, 246);
            ClientSize = new Size(950, 660);
            Controls.Add(pnlBottom);
            Controls.Add(pnlRight);
            Controls.Add(pnlLeft);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Q1 Cloth sale app";
            Load += MainForm_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlLeft.ResumeLayout(false);
            pnlLeft.PerformLayout();
            pnlStatsCard.ResumeLayout(false);
            pnlStatsCard.PerformLayout();
            pnlRight.ResumeLayout(false);
            pnlRight.PerformLayout();
            pnlSellCard.ResumeLayout(false);
            pnlSellCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numSell).EndInit();
            pnlPurchaseCard.ResumeLayout(false);
            pnlPurchaseCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numPurchase).EndInit();
            pnlBottom.ResumeLayout(false);
            pnlBottom.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Label lblSubtitle;
        private Label lblTitle;
        private Panel pnlLeft;
        private Label lblSelectedDetailsTitle;
        private Panel pnlStatsCard;
        private Label lblStockValue;
        private Label lblStockTitle;
        private Label lblPriceValue;
        private Label lblPriceTitle;
        private ComboBox comboItems;
        private Label lblSelectCloth;
        private Panel pnlRight;
        private Panel pnlSellCard;
        private Button btnSell;
        private NumericUpDown numSell;
        private Label lblSellQty;
        private Label lblSellHeader;
        private Panel pnlPurchaseCard;
        private Button btnPurchase;
        private NumericUpDown numPurchase;
        private Label lblPurchaseQty;
        private Label lblPurchaseHeader;
        private Panel pnlBottom;
        private RichTextBox txtActivityLog;
        private Label lblLogTitle;
        private Label lblItemTitle;
        private Label lblTransactionTitle;
    }
}
