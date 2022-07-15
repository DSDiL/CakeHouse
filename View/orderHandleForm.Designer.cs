
namespace CakeHouse.View
{
    partial class orderHandleForm
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
            this.ordersTable = new System.Windows.Forms.DataGridView();
            this.orderItemsTable = new System.Windows.Forms.DataGridView();
            this.orderStatus = new System.Windows.Forms.ComboBox();
            this.orderId = new System.Windows.Forms.Label();
            this.orderIdLabel = new System.Windows.Forms.Label();
            this.orderStatusLabel = new System.Windows.Forms.Label();
            this.update = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ordersTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderItemsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // close
            // 
            this.close.AutoSize = true;
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.Location = new System.Drawing.Point(1141, 5);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(49, 20);
            this.close.TabIndex = 15;
            this.close.Text = "close";
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // ordersTable
            // 
            this.ordersTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.ordersTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordersTable.Location = new System.Drawing.Point(24, 97);
            this.ordersTable.Name = "ordersTable";
            this.ordersTable.RowHeadersWidth = 51;
            this.ordersTable.RowTemplate.Height = 24;
            this.ordersTable.Size = new System.Drawing.Size(557, 321);
            this.ordersTable.TabIndex = 55;
            this.ordersTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ordersTable_CellContentClick);
            // 
            // orderItemsTable
            // 
            this.orderItemsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderItemsTable.Location = new System.Drawing.Point(614, 97);
            this.orderItemsTable.Name = "orderItemsTable";
            this.orderItemsTable.RowHeadersWidth = 51;
            this.orderItemsTable.RowTemplate.Height = 24;
            this.orderItemsTable.Size = new System.Drawing.Size(557, 321);
            this.orderItemsTable.TabIndex = 54;
            // 
            // orderStatus
            // 
            this.orderStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderStatus.FormattingEnabled = true;
            this.orderStatus.Items.AddRange(new object[] {
            "Pending",
            "Completed",
            "Declined"});
            this.orderStatus.Location = new System.Drawing.Point(842, 456);
            this.orderStatus.Name = "orderStatus";
            this.orderStatus.Size = new System.Drawing.Size(260, 37);
            this.orderStatus.TabIndex = 59;
            // 
            // orderId
            // 
            this.orderId.AutoSize = true;
            this.orderId.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderId.Location = new System.Drawing.Point(304, 459);
            this.orderId.Name = "orderId";
            this.orderId.Size = new System.Drawing.Size(21, 29);
            this.orderId.TabIndex = 58;
            this.orderId.Text = "-";
            // 
            // orderIdLabel
            // 
            this.orderIdLabel.AutoSize = true;
            this.orderIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderIdLabel.Location = new System.Drawing.Point(97, 459);
            this.orderIdLabel.Name = "orderIdLabel";
            this.orderIdLabel.Size = new System.Drawing.Size(105, 29);
            this.orderIdLabel.TabIndex = 57;
            this.orderIdLabel.Text = "Order ID";
            // 
            // orderStatusLabel
            // 
            this.orderStatusLabel.AutoSize = true;
            this.orderStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderStatusLabel.Location = new System.Drawing.Point(636, 459);
            this.orderStatusLabel.Name = "orderStatusLabel";
            this.orderStatusLabel.Size = new System.Drawing.Size(148, 29);
            this.orderStatusLabel.TabIndex = 56;
            this.orderStatusLabel.Text = "Order Status";
            // 
            // update
            // 
            this.update.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.Location = new System.Drawing.Point(433, 519);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(310, 71);
            this.update.TabIndex = 60;
            this.update.Text = "UPDATE";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // orderHandleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 615);
            this.Controls.Add(this.update);
            this.Controls.Add(this.orderStatus);
            this.Controls.Add(this.orderId);
            this.Controls.Add(this.orderIdLabel);
            this.Controls.Add(this.orderStatusLabel);
            this.Controls.Add(this.ordersTable);
            this.Controls.Add(this.orderItemsTable);
            this.Controls.Add(this.close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "orderHandleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "orderHandleForm";
            this.Load += new System.EventHandler(this.orderHandleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ordersTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderItemsTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label close;
        private System.Windows.Forms.DataGridView ordersTable;
        private System.Windows.Forms.DataGridView orderItemsTable;
        private System.Windows.Forms.ComboBox orderStatus;
        private System.Windows.Forms.Label orderId;
        private System.Windows.Forms.Label orderIdLabel;
        private System.Windows.Forms.Label orderStatusLabel;
        private System.Windows.Forms.Button update;
    }
}