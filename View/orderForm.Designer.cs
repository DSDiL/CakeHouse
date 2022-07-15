
namespace CakeHouse.View
{
    partial class orderForm
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
            this.close = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.orderIdLabel = new System.Windows.Forms.Label();
            this.orderLabel = new System.Windows.Forms.Label();
            this.qtyLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.cusNameLabel = new System.Windows.Forms.Label();
            this.qty = new System.Windows.Forms.TextBox();
            this.cusName = new System.Windows.Forms.TextBox();
            this.orderItemsTable = new System.Windows.Forms.DataGridView();
            this.addItemBtn = new System.Windows.Forms.Button();
            this.orderBtn = new System.Windows.Forms.Button();
            this.delOrderBtn = new System.Windows.Forms.Button();
            this.orderId = new System.Windows.Forms.Label();
            this.orderItems = new System.Windows.Forms.ComboBox();
            this.price = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.Label();
            this.ordersTable = new System.Windows.Forms.DataGridView();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.dateLabel = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.orderItemsTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersTable)).BeginInit();
            this.SuspendLayout();
            // 
            // close
            // 
            this.close.AutoSize = true;
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.Location = new System.Drawing.Point(1128, 5);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(49, 20);
            this.close.TabIndex = 15;
            this.close.Text = "close";
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(40, 458);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(130, 29);
            this.totalLabel.TabIndex = 35;
            this.totalLabel.Text = "Total Price";
            // 
            // orderIdLabel
            // 
            this.orderIdLabel.AutoSize = true;
            this.orderIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderIdLabel.Location = new System.Drawing.Point(40, 80);
            this.orderIdLabel.Name = "orderIdLabel";
            this.orderIdLabel.Size = new System.Drawing.Size(105, 29);
            this.orderIdLabel.TabIndex = 34;
            this.orderIdLabel.Text = "Order ID";
            // 
            // orderLabel
            // 
            this.orderLabel.AutoSize = true;
            this.orderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderLabel.Location = new System.Drawing.Point(40, 286);
            this.orderLabel.Name = "orderLabel";
            this.orderLabel.Size = new System.Drawing.Size(140, 29);
            this.orderLabel.TabIndex = 33;
            this.orderLabel.Text = "Order Items";
            // 
            // qtyLabel
            // 
            this.qtyLabel.AutoSize = true;
            this.qtyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qtyLabel.Location = new System.Drawing.Point(40, 347);
            this.qtyLabel.Name = "qtyLabel";
            this.qtyLabel.Size = new System.Drawing.Size(100, 29);
            this.qtyLabel.TabIndex = 32;
            this.qtyLabel.Text = "Quantity";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel.Location = new System.Drawing.Point(40, 403);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(69, 29);
            this.priceLabel.TabIndex = 31;
            this.priceLabel.Text = "Price";
            // 
            // cusNameLabel
            // 
            this.cusNameLabel.AutoSize = true;
            this.cusNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cusNameLabel.Location = new System.Drawing.Point(40, 150);
            this.cusNameLabel.Name = "cusNameLabel";
            this.cusNameLabel.Size = new System.Drawing.Size(188, 29);
            this.cusNameLabel.TabIndex = 30;
            this.cusNameLabel.Text = "Customer Name";
            // 
            // qty
            // 
            this.qty.BackColor = System.Drawing.SystemColors.ControlLight;
            this.qty.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.qty.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qty.Location = new System.Drawing.Point(249, 347);
            this.qty.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.qty.Name = "qty";
            this.qty.Size = new System.Drawing.Size(260, 27);
            this.qty.TabIndex = 39;
            this.qty.TextChanged += new System.EventHandler(this.qty_TextChanged);
            // 
            // cusName
            // 
            this.cusName.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cusName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cusName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cusName.Location = new System.Drawing.Point(249, 150);
            this.cusName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cusName.Name = "cusName";
            this.cusName.Size = new System.Drawing.Size(260, 27);
            this.cusName.TabIndex = 41;
            // 
            // orderItemsTable
            // 
            this.orderItemsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderItemsTable.Location = new System.Drawing.Point(572, 80);
            this.orderItemsTable.Name = "orderItemsTable";
            this.orderItemsTable.RowHeadersWidth = 51;
            this.orderItemsTable.RowTemplate.Height = 24;
            this.orderItemsTable.Size = new System.Drawing.Size(557, 184);
            this.orderItemsTable.TabIndex = 42;
            this.orderItemsTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.orderItemsTable_CellContentClick);
            // 
            // addItemBtn
            // 
            this.addItemBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addItemBtn.Location = new System.Drawing.Point(45, 500);
            this.addItemBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addItemBtn.Name = "addItemBtn";
            this.addItemBtn.Size = new System.Drawing.Size(140, 45);
            this.addItemBtn.TabIndex = 44;
            this.addItemBtn.Text = "ADD ITEM";
            this.addItemBtn.UseVisualStyleBackColor = true;
            this.addItemBtn.Click += new System.EventHandler(this.addItemBtn_Click);
            // 
            // orderBtn
            // 
            this.orderBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderBtn.Location = new System.Drawing.Point(226, 500);
            this.orderBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.orderBtn.Name = "orderBtn";
            this.orderBtn.Size = new System.Drawing.Size(168, 45);
            this.orderBtn.TabIndex = 45;
            this.orderBtn.Text = "ADD ORDER";
            this.orderBtn.UseVisualStyleBackColor = true;
            this.orderBtn.Click += new System.EventHandler(this.orderBtn_Click);
            // 
            // delOrderBtn
            // 
            this.delOrderBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delOrderBtn.Location = new System.Drawing.Point(438, 500);
            this.delOrderBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.delOrderBtn.Name = "delOrderBtn";
            this.delOrderBtn.Size = new System.Drawing.Size(207, 45);
            this.delOrderBtn.TabIndex = 46;
            this.delOrderBtn.Text = "DELETE ORDER";
            this.delOrderBtn.UseVisualStyleBackColor = true;
            this.delOrderBtn.Click += new System.EventHandler(this.delOrderBtn_Click);
            // 
            // orderId
            // 
            this.orderId.AutoSize = true;
            this.orderId.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderId.Location = new System.Drawing.Point(244, 80);
            this.orderId.Name = "orderId";
            this.orderId.Size = new System.Drawing.Size(21, 29);
            this.orderId.TabIndex = 49;
            this.orderId.Text = "-";
            // 
            // orderItems
            // 
            this.orderItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderItems.FormattingEnabled = true;
            this.orderItems.Location = new System.Drawing.Point(249, 278);
            this.orderItems.Name = "orderItems";
            this.orderItems.Size = new System.Drawing.Size(260, 37);
            this.orderItems.TabIndex = 50;
            this.orderItems.SelectedIndexChanged += new System.EventHandler(this.orderItems_SelectedIndexChanged);
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price.Location = new System.Drawing.Point(244, 403);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(21, 29);
            this.price.TabIndex = 51;
            this.price.Text = "-";
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total.Location = new System.Drawing.Point(244, 458);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(26, 29);
            this.total.TabIndex = 52;
            this.total.Text = "0";
            // 
            // ordersTable
            // 
            this.ordersTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.ordersTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordersTable.Location = new System.Drawing.Point(572, 293);
            this.ordersTable.Name = "ordersTable";
            this.ordersTable.RowHeadersWidth = 51;
            this.ordersTable.RowTemplate.Height = 24;
            this.ordersTable.Size = new System.Drawing.Size(557, 184);
            this.ordersTable.TabIndex = 53;
            this.ordersTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ordersTable_CellContentClick);
            // 
            // refreshBtn
            // 
            this.refreshBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshBtn.Location = new System.Drawing.Point(688, 500);
            this.refreshBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(195, 45);
            this.refreshBtn.TabIndex = 54;
            this.refreshBtn.Text = "REFRESH";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.Location = new System.Drawing.Point(40, 221);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(113, 29);
            this.dateLabel.TabIndex = 55;
            this.dateLabel.Text = "Due Date";
            // 
            // date
            // 
            this.date.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.Location = new System.Drawing.Point(249, 216);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(260, 34);
            this.date.TabIndex = 56;
            this.date.Value = new System.DateTime(2022, 7, 13, 23, 29, 12, 0);
            // 
            // orderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 568);
            this.Controls.Add(this.date);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.ordersTable);
            this.Controls.Add(this.total);
            this.Controls.Add(this.price);
            this.Controls.Add(this.orderItems);
            this.Controls.Add(this.orderId);
            this.Controls.Add(this.delOrderBtn);
            this.Controls.Add(this.orderBtn);
            this.Controls.Add(this.addItemBtn);
            this.Controls.Add(this.orderItemsTable);
            this.Controls.Add(this.cusName);
            this.Controls.Add(this.qty);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.orderIdLabel);
            this.Controls.Add(this.orderLabel);
            this.Controls.Add(this.qtyLabel);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.cusNameLabel);
            this.Controls.Add(this.close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "orderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "orderForm";
            this.Load += new System.EventHandler(this.orderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.orderItemsTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label close;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label orderIdLabel;
        private System.Windows.Forms.Label orderLabel;
        private System.Windows.Forms.Label qtyLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label cusNameLabel;
        private System.Windows.Forms.TextBox qty;
        private System.Windows.Forms.TextBox cusName;
        private System.Windows.Forms.DataGridView orderItemsTable;
        private System.Windows.Forms.Button addItemBtn;
        private System.Windows.Forms.Button orderBtn;
        private System.Windows.Forms.Button delOrderBtn;
        private System.Windows.Forms.Label orderId;
        private System.Windows.Forms.ComboBox orderItems;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.Label total;
        private System.Windows.Forms.DataGridView ordersTable;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.DateTimePicker date;
    }
}