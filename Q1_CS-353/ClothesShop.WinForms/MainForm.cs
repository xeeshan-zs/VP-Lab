using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ClothesShop.BLL.Services;
using ClothesShop.DAL.Models;

namespace ClothesShop.WinForms
{
    public partial class MainForm : Form
    {
        private readonly ClothService _clothService;
        private List<ClothItem> _clothItems;
        private ClothItem _selectedItem;

        public MainForm()
        {
            InitializeComponent();
            _clothService = new ClothService();
            _clothItems = new List<ClothItem>();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LogActivity("Warehouse Operations Console Initialized.", Color.FromArgb(129, 140, 248));
            LoadClothItems();
        }

        private void LoadClothItems(int selectedItemIdToKeep = -1)
        {
            try
            {
                // Fetch latest data from BLL
                _clothItems = _clothService.GetAvailableItems();

                // Clear and bind
                comboItems.DataSource = null;
                comboItems.DataSource = _clothItems;
                comboItems.DisplayMember = "ItemName";
                comboItems.ValueMember = "ItemId";

                // Restore selection if matching item exists
                if (selectedItemIdToKeep != -1 && _clothItems.Any(i => i.ItemId == selectedItemIdToKeep))
                {
                    comboItems.SelectedValue = selectedItemIdToKeep;
                }
                else if (_clothItems.Count > 0)
                {
                    comboItems.SelectedIndex = 0;
                }

                UpdateDetailsDisplay();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading items: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LogActivity($"Database Error: {ex.Message}", Color.FromArgb(244, 63, 94));
            }
        }

        private void UpdateDetailsDisplay()
        {
            _selectedItem = comboItems.SelectedItem as ClothItem;

            if (_selectedItem != null)
            {
                lblPriceValue.Text = $"PKR {_selectedItem.Price:N0}";
                lblPriceValue.ForeColor = Color.FromArgb(5, 150, 105); // Dark Green
                lblStockValue.Text = $"{_selectedItem.StockQuantity} Units";

                // Visual color helper based on stock level
                if (_selectedItem.StockQuantity == 0)
                {
                    lblStockValue.ForeColor = Color.FromArgb(220, 38, 38); // Dark Red
                }
                else if (_selectedItem.StockQuantity < 50)
                {
                    lblStockValue.ForeColor = Color.FromArgb(217, 119, 6); // Dark Orange
                }
                else
                {
                    lblStockValue.ForeColor = Color.FromArgb(17, 24, 39); // Bold Dark Charcoal
                }
            }
            else
            {
                lblPriceValue.Text = "PKR 0";
                lblPriceValue.ForeColor = Color.FromArgb(107, 114, 128);
                lblStockValue.Text = "0 Units";
                lblStockValue.ForeColor = Color.FromArgb(107, 114, 128);
            }
        }

        private void comboItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateDetailsDisplay();
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            if (_selectedItem == null)
            {
                MessageBox.Show("Please select an item first.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int qty = (int)numPurchase.Value;
            try
            {
                _clothService.PurchaseItem(_selectedItem.ItemId, qty);
                
                string successMsg = $"PURCHASE SUCCESS: Received {qty} units of '{_selectedItem.ItemName}' into stock.";
                LogActivity(successMsg, Color.FromArgb(4, 120, 87));
                
                // Refresh data but maintain selected item
                LoadClothItems(_selectedItem.ItemId);
                numPurchase.Value = 1; // Reset NumericUpDown
                
                MessageBox.Show(successMsg, "Purchase Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                string errMsg = $"Purchase Failed: {ex.Message}";
                LogActivity(errMsg, Color.FromArgb(185, 28, 28));
                MessageBox.Show(ex.Message, "Transaction Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            if (_selectedItem == null)
            {
                MessageBox.Show("Please select an item first.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int qty = (int)numSell.Value;
            try
            {
                _clothService.SellItem(_selectedItem.ItemId, qty);
                
                string successMsg = $"SALES DISPATCH SUCCESS: Shipped {qty} units of '{_selectedItem.ItemName}' to customer.";
                LogActivity(successMsg, Color.FromArgb(29, 78, 216));
                
                // Refresh data but maintain selected item
                LoadClothItems(_selectedItem.ItemId);
                numSell.Value = 1; // Reset NumericUpDown

                MessageBox.Show(successMsg, "Sale Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                string errMsg = $"Sales Dispatch Failed: {ex.Message}";
                LogActivity(errMsg, Color.FromArgb(185, 28, 28));
                MessageBox.Show(ex.Message, "Transaction Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LogActivity(string text, Color color)
        {
            string timestamp = DateTime.Now.ToString("[yyyy-MM-dd HH:mm:ss] ");
            
            txtActivityLog.SelectionStart = txtActivityLog.TextLength;
            txtActivityLog.SelectionLength = 0;
            
            txtActivityLog.SelectionColor = Color.FromArgb(107, 114, 128);
            txtActivityLog.AppendText(timestamp);

            txtActivityLog.SelectionStart = txtActivityLog.TextLength;
            txtActivityLog.SelectionLength = 0;
            txtActivityLog.SelectionColor = color;
            txtActivityLog.AppendText(text + Environment.NewLine);

            txtActivityLog.SelectionColor = txtActivityLog.ForeColor;
            txtActivityLog.ScrollToCaret();
        }
    }
}
