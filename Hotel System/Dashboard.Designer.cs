using System;
using System.Drawing;
using System.Windows.Forms;

namespace Hotel_System
{
    partial class Dashboard
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

        private void InitializeComponent()
        {
            Color navy = Color.FromArgb(26, 43, 60);
            Color page = Color.FromArgb(245, 247, 250);
            Font regular = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular);
            Font bold = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);

            this.SuspendLayout();

            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = page;
            this.ClientSize = new Size(1280, 800);
            this.MinimumSize = new Size(1280, 800);
            this.Name = "Dashboard";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.FormClosed += new FormClosedEventHandler(this.Dashboard_FormClosed);

            this.mainContainer = new Panel { BackColor = page, Dock = DockStyle.Fill };

            // Left sidebar
            this.leftSidebar = new Panel { BackColor = Color.White, Dock = DockStyle.Left, Width = 180 };
            this.sidebarTop = new Panel { BackColor = Color.White, Dock = DockStyle.Top, Height = 120 };

            this.btnWithdrawal = CreateNavButton("btnWithdrawal", "Withdrawal");
            this.btnMenuOrder = CreateNavButton("btnMenuOrder", "Menu Order");
            this.btnMenuOrder.BackColor = navy;
            this.btnMenuOrder.ForeColor = Color.White;
            this.btnMenuOrder.Font = bold;
            this.btnDashboard = CreateNavButton("btnDashboard", "Dashboard");

            this.sidebarTop.Controls.Add(this.btnWithdrawal);
            this.sidebarTop.Controls.Add(this.btnMenuOrder);
            this.sidebarTop.Controls.Add(this.btnDashboard);

            this.tableManagementGroup = new Panel { BackColor = Color.White, Dock = DockStyle.Top, Height = 155 };
            this.lblManageTable = new Label
            {
                AutoSize = true,
                Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold),
                ForeColor = Color.FromArgb(110, 118, 128),
                Location = new Point(15, 10),
                Text = "Manage Table"
            };

            this.btnBooked = CreateSubNavButton("btnBooked", "Booked", 38, false);
            this.btnActived = CreateSubNavButton("btnActived", "✓  Actived", 70, true);
            this.btnRunningOrder = CreateSubNavButton("btnRunningOrder", "Running Order", 102, false);

            this.tableManagementGroup.Controls.Add(this.lblManageTable);
            this.tableManagementGroup.Controls.Add(this.btnBooked);
            this.tableManagementGroup.Controls.Add(this.btnActived);
            this.tableManagementGroup.Controls.Add(this.btnRunningOrder);

            this.sidebarBottom = new Panel { BackColor = Color.White, Dock = DockStyle.Bottom, Height = 90 };
            this.btnSettings = new Button
            {
                BackColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = regular,
                ForeColor = navy,
                Location = new Point(15, 8),
                Size = new Size(150, 35),
                Text = "Settings",
                TextAlign = ContentAlignment.MiddleLeft,
                UseVisualStyleBackColor = false
            };
            this.btnSettings.FlatAppearance.BorderSize = 0;

            this.btnLogout = new Button
            {
                BackColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = regular,
                ForeColor = navy,
                Location = new Point(15, 48),
                Size = new Size(150, 35),
                Text = "Logout",
                TextAlign = ContentAlignment.MiddleLeft,
                UseVisualStyleBackColor = false
            };
            this.btnLogout.FlatAppearance.BorderSize = 0;

            this.sidebarBottom.Controls.Add(this.btnSettings);
            this.sidebarBottom.Controls.Add(this.btnLogout);

            // Add bottom first so the top blocks stack in the intended order.
            this.leftSidebar.Controls.Add(this.sidebarBottom);
            this.leftSidebar.Controls.Add(this.tableManagementGroup);
            this.leftSidebar.Controls.Add(this.sidebarTop);

            // Top header
            this.topHeader = new Panel { BackColor = Color.White, Dock = DockStyle.Top, Height = 50 };

            this.headerLeft = new FlowLayoutPanel
            {
                BackColor = Color.White,
                Dock = DockStyle.Left,
                FlowDirection = FlowDirection.LeftToRight,
                Padding = new Padding(15, 12, 0, 0),
                WrapContents = false,
                Width = 250
            };

            this.lblShopName = new Label
            {
                AutoSize = true,
                Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold),
                ForeColor = navy,
                Margin = new Padding(0, 2, 15, 0),
                Text = "Hadid's Food"
            };

            this.cmbStatus = new ComboBox
            {
                DropDownStyle = ComboBoxStyle.DropDownList,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Microsoft Sans Serif", 8.5F, FontStyle.Regular),
                Margin = new Padding(0, 1, 0, 0),
                Text = "Open",
                Width = 80
            };
            this.cmbStatus.Items.AddRange(new object[] { "Open", "Closed" });
            this.cmbStatus.SelectedIndex = 0;

            this.headerLeft.Controls.Add(this.lblShopName);
            this.headerLeft.Controls.Add(this.cmbStatus);

            this.headerRight = new FlowLayoutPanel
            {
                BackColor = Color.White,
                Dock = DockStyle.Right,
                FlowDirection = FlowDirection.LeftToRight,
                Padding = new Padding(0, 12, 15, 0),
                WrapContents = false,
                Width = 500
            };

            this.lblDateTime = new Label
            {
                AutoSize = true,
                Font = new Font("Microsoft Sans Serif", 8.5F, FontStyle.Regular),
                ForeColor = Color.FromArgb(90, 98, 108),
                Margin = new Padding(0, 3, 20, 0),
                Text = "Wednesday, 27 Mar 2024 at 9:48 AM"
            };

            this.cmbUser = new ComboBox
            {
                DropDownStyle = ComboBoxStyle.DropDownList,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Microsoft Sans Serif", 8.5F, FontStyle.Regular),
                Text = "Michael Olise",
                Width = 145
            };
            this.cmbUser.Items.AddRange(new object[] { "Michael Olise", "Sarah Johnson" });
            this.cmbUser.SelectedIndex = 0;

            this.headerRight.Controls.Add(this.lblDateTime);
            this.headerRight.Controls.Add(this.cmbUser);

            this.topHeader.Controls.Add(this.headerLeft);
            this.topHeader.Controls.Add(this.headerRight);

            // Right sidebar
            this.rightSidebar = new Panel
            {
                BackColor = Color.White,
                Dock = DockStyle.Right,
                Padding = new Padding(15),
                Width = 300
            };

            this.orderSummaryLayout = new TableLayoutPanel
            {
                BackColor = Color.White,
                ColumnCount = 1,
                Dock = DockStyle.Fill,
                RowCount = 6
            };
            this.orderSummaryLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            this.orderSummaryLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            this.orderSummaryLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 320F));
            this.orderSummaryLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 110F));
            this.orderSummaryLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            this.orderSummaryLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 150F));
            this.orderSummaryLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));

            this.headerPanel = new Panel { BackColor = Color.White, Dock = DockStyle.Fill, Margin = new Padding(0) };
            this.lblOrderSummary = new Label
            {
                Dock = DockStyle.Left,
                Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Bold),
                ForeColor = navy,
                Text = "Order Summary",
                TextAlign = ContentAlignment.MiddleLeft,
                Width = 180
            };
            this.lblOrderNumber = new Label
            {
                Dock = DockStyle.Right,
                Font = new Font("Microsoft Sans Serif", 8.5F, FontStyle.Regular),
                ForeColor = Color.Gray,
                Text = "#B12309",
                TextAlign = ContentAlignment.MiddleRight,
                Width = 80
            };
            this.headerPanel.Controls.Add(this.lblOrderSummary);
            this.headerPanel.Controls.Add(this.lblOrderNumber);

            this.cartItemsFlow = new FlowLayoutPanel
            {
                AutoScroll = true,
                BackColor = Color.White,
                Dock = DockStyle.Fill,
                FlowDirection = FlowDirection.TopDown,
                Margin = new Padding(0),
                WrapContents = false
            };

            this.itemPanel1 = CreateCartItem("French Fries (1)", "Notes: None • Size: Large", "Rs. 7.50",
                out this.itemPic1, out this.itemTitle1, out this.itemSubtext1, out this.itemPrice1, out this.btnEdit1, out this.btnDelete1);
            this.itemPanel2 = CreateCartItem("Wagyu Steak (1)", "Notes: Well Med • Size: Small", "Rs. 31.17",
                out this.itemPic2, out this.itemTitle2, out this.itemSubtext2, out this.itemPrice2, out this.btnEdit2, out this.btnDelete2);
            this.itemPanel3 = CreateCartItem("Chicken Ramen (1)", "Spicy: Normal • Size: Medium", "Rs. 17.70",
                out this.itemPic3, out this.itemTitle3, out this.itemSubtext3, out this.itemPrice3, out this.btnEdit3, out this.btnDelete3);

            this.cartItemsFlow.Controls.Add(this.itemPanel1);
            this.cartItemsFlow.Controls.Add(this.itemPanel2);
            this.cartItemsFlow.Controls.Add(this.itemPanel3);

            this.totalsPanel = new TableLayoutPanel
            {
                ColumnCount = 2,
                Dock = DockStyle.Fill,
                Margin = new Padding(0),
                RowCount = 4
            };
            this.totalsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55F));
            this.totalsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            for (int i = 0; i < 4; i++)
            {
                this.totalsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            }

            this.lblSubtotal = CreateTotalLabel("Subtotal", false, false);
            this.lblSubtotalValue = CreateTotalLabel("Rs. 56.37", false, true);
            this.lblTaxes = CreateTotalLabel("Taxes", false, false);
            this.lblTaxesValue = CreateTotalLabel("Rs. 5.63", false, true);
            this.lblDiscount = CreateTotalLabel("Discount", false, false);
            this.lblDiscountValue = CreateTotalLabel("-Rs. 5.63", true, true);
            this.lblTotalLabel = CreateTotalLabel("Total Payment", false, false);
            this.lblTotalValue = CreateTotalLabel("Rs. 56.37", false, true);
            this.lblTotalLabel.Font = bold;
            this.lblTotalValue.Font = bold;

            this.totalsPanel.Controls.Add(this.lblSubtotal, 0, 0);
            this.totalsPanel.Controls.Add(this.lblSubtotalValue, 1, 0);
            this.totalsPanel.Controls.Add(this.lblTaxes, 0, 1);
            this.totalsPanel.Controls.Add(this.lblTaxesValue, 1, 1);
            this.totalsPanel.Controls.Add(this.lblDiscount, 0, 2);
            this.totalsPanel.Controls.Add(this.lblDiscountValue, 1, 2);
            this.totalsPanel.Controls.Add(this.lblTotalLabel, 0, 3);
            this.totalsPanel.Controls.Add(this.lblTotalValue, 1, 3);

            this.orderOptionsPanel = new Panel { BackColor = Color.White, Dock = DockStyle.Fill, Margin = new Padding(0) };

            this.lblOrderType = new Label
            {
                AutoSize = true,
                Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular),
                ForeColor = Color.FromArgb(90, 98, 108),
                Location = new Point(0, 4),
                Text = "Order Type"
            };
            this.cmbOrderType = new ComboBox
            {
                DropDownStyle = ComboBoxStyle.DropDownList,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Microsoft Sans Serif", 8.5F, FontStyle.Regular),
                Location = new Point(0, 23),
                Text = "Dine-in",
                Width = 255
            };
            this.cmbOrderType.Items.AddRange(new object[] { "Dine-in", "Takeaway", "Delivery" });
            this.cmbOrderType.SelectedIndex = 0;

            this.lblSelectTable = new Label
            {
                AutoSize = true,
                Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular),
                ForeColor = Color.FromArgb(90, 98, 108),
                Location = new Point(0, 55),
                Text = "Select Table"
            };
            this.cmbSelectTable = new ComboBox
            {
                DropDownStyle = ComboBoxStyle.DropDownList,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Microsoft Sans Serif", 8.5F, FontStyle.Regular),
                Location = new Point(0, 74),
                Text = "A-12B",
                Width = 255
            };
            this.cmbSelectTable.Items.AddRange(new object[] { "A-12B", "A-15C", "B-08A" });
            this.cmbSelectTable.SelectedIndex = 0;

            this.btnDiscount = new Button
            {
                BackColor = Color.WhiteSmoke,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular),
                ForeColor = navy,
                Location = new Point(0, 104),
                Size = new Size(255, 40),
                Text = "10% Discount (Minimum Buy Rs. 50.00)",
                UseVisualStyleBackColor = false
            };
            this.btnDiscount.FlatAppearance.BorderColor = Color.LightGray;

            this.orderOptionsPanel.Controls.Add(this.lblOrderType);
            this.orderOptionsPanel.Controls.Add(this.cmbOrderType);
            this.orderOptionsPanel.Controls.Add(this.lblSelectTable);
            this.orderOptionsPanel.Controls.Add(this.cmbSelectTable);
            this.orderOptionsPanel.Controls.Add(this.btnDiscount);

            this.bottomPanel = new Panel { BackColor = Color.White, Dock = DockStyle.Fill, Margin = new Padding(0) };
            this.btnConfirmPayment = new Button
            {
                BackColor = navy,
                Dock = DockStyle.Fill,
                FlatStyle = FlatStyle.Flat,
                Font = bold,
                ForeColor = Color.White,
                Text = "Confirm Payment",
                UseVisualStyleBackColor = false
            };
            this.btnConfirmPayment.FlatAppearance.BorderSize = 0;
            this.bottomPanel.Controls.Add(this.btnConfirmPayment);

            this.orderSummaryLayout.Controls.Add(this.headerPanel, 0, 0);
            this.orderSummaryLayout.Controls.Add(this.cartItemsFlow, 0, 1);
            this.orderSummaryLayout.Controls.Add(this.totalsPanel, 0, 2);
            this.orderSummaryLayout.Controls.Add(this.orderOptionsPanel, 0, 4);
            this.orderSummaryLayout.Controls.Add(this.bottomPanel, 0, 5);
            this.rightSidebar.Controls.Add(this.orderSummaryLayout);

            // Center content
            this.centerContent = new Panel
            {
                BackColor = page,
                Dock = DockStyle.Fill,
                Padding = new Padding(15)
            };

            this.filterBar = new Panel { BackColor = page, Dock = DockStyle.Top, Height = 50 };
            this.filterLeft = new FlowLayoutPanel
            {
                BackColor = page,
                Dock = DockStyle.Fill,
                FlowDirection = FlowDirection.LeftToRight,
                Padding = new Padding(0, 6, 0, 0),
                WrapContents = false
            };

            this.btnDishMenu = CreateFilterButton("btnDishMenu", "Dish Menu", 65, false);
            this.btnAll42 = CreateFilterButton("btnAll42", "All 42", 50, false);
            this.btnBeverages12 = CreateFilterButton("btnBeverages12", "Beverages 12", 85, false);
            this.btnMainCourse18 = CreateFilterButton("btnMainCourse18", "Main Course 18", 100, true);
            this.btnDessert8 = CreateFilterButton("btnDessert8", "Dessert 8", 65, false);
            this.btnAppetizer6 = CreateFilterButton("btnAppetizer6", "Appetizer 6", 75, false);

            this.filterLeft.Controls.Add(this.btnDishMenu);
            this.filterLeft.Controls.Add(this.btnAll42);
            this.filterLeft.Controls.Add(this.btnBeverages12);
            this.filterLeft.Controls.Add(this.btnMainCourse18);
            this.filterLeft.Controls.Add(this.btnDessert8);
            this.filterLeft.Controls.Add(this.btnAppetizer6);

            this.filterRight = new Panel { BackColor = page, Dock = DockStyle.Right, Width = 250 };
            this.btnRefresh = new Button
            {
                BackColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular),
                ForeColor = navy,
                Location = new Point(0, 8),
                Size = new Size(80, 32),
                Text = "Refresh",
                UseVisualStyleBackColor = false
            };
            this.btnRefresh.FlatAppearance.BorderColor = Color.LightGray;

            // PlaceholderText is not available on .NET Framework 4.7.2, so the cue text is simulated.
            this.txtSearch = new TextBox
            {
                Font = new Font("Microsoft Sans Serif", 8.5F, FontStyle.Regular),
                ForeColor = Color.Gray,
                Location = new Point(90, 11),
                Size = new Size(150, 20),
                Text = "Search Menu"
            };
            this.txtSearch.Width = 150;

            this.filterRight.Controls.Add(this.btnRefresh);
            this.filterRight.Controls.Add(this.txtSearch);
            this.filterBar.Controls.Add(this.filterLeft);
            this.filterBar.Controls.Add(this.filterRight);

            this.menuGrid = new TableLayoutPanel
            {
                AutoScroll = true,
                BackColor = page,
                ColumnCount = 4,
                Dock = DockStyle.Fill,
                GrowStyle = TableLayoutPanelGrowStyle.FixedSize,
                RowCount = 3
            };
            for (int i = 0; i < 4; i++)
            {
                this.menuGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            }
            for (int i = 0; i < 3; i++)
            {
                this.menuGrid.RowStyles.Add(new RowStyle(SizeType.Absolute, 240F));
            }

            this.menuItemPanel1 = CreateMenuCard("Butter Chicken", "Rs. 12.64", true, "+ Add to Cart", true, false, out this.menuPic1, out this.menuStatus1, out this.menuName1, out this.menuPrice1, out this.btnAddToCart1);
            this.menuItemPanel2 = CreateMenuCard("French Fries", "Rs. 7.50", true, "Add More (1)", false, false, out this.menuPic2, out this.menuStatus2, out this.menuName2, out this.menuPrice2, out this.btnAddToCart2);
            this.menuItemPanel3 = CreateMenuCard("Roast Beef", "Rs. 29.00", true, "+ Add to Cart", true, false, out this.menuPic3, out this.menuStatus3, out this.menuName3, out this.menuPrice3, out this.btnAddToCart3);
            this.menuItemPanel4 = CreateMenuCard("Sauerkraut", "Rs. 11.55", true, "+ Add to Cart", true, false, out this.menuPic4, out this.menuStatus4, out this.menuName4, out this.menuPrice4, out this.btnAddToCart4);
            this.menuItemPanel5 = CreateMenuCard("Beef Kebab", "Rs. 14.95", false, "x Not Available", false, true, out this.menuPic5, out this.menuStatus5, out this.menuName5, out this.menuPrice5, out this.btnAddToCart5);
            this.menuItemPanel6 = CreateMenuCard("Fish and Chips", "Rs. 23.05", true, "+ Add to Cart", true, false, out this.menuPic6, out this.menuStatus6, out this.menuName6, out this.menuPrice6, out this.btnAddToCart6);
            this.menuItemPanel7 = CreateMenuCard("Wagyu Steak", "Rs. 31.17", true, "Add More (1)", false, false, out this.menuPic7, out this.menuStatus7, out this.menuName7, out this.menuPrice7, out this.btnAddToCart7);
            this.menuItemPanel8 = CreateMenuCard("Chicken Ramen", "Rs. 17.70", true, "Add More (1)", false, false, out this.menuPic8, out this.menuStatus8, out this.menuName8, out this.menuPrice8, out this.btnAddToCart8);
            this.menuItemPanel9 = CreateMenuCard("Pasta Bolognese", "Rs. 23.50", true, "+ Add to Cart", true, false, out this.menuPic9, out this.menuStatus9, out this.menuName9, out this.menuPrice9, out this.btnAddToCart9);
            this.menuItemPanel10 = CreateMenuCard("Vegetable Salad", "Rs. 15.41", true, "+ Add to Cart", true, false, out this.menuPic10, out this.menuStatus10, out this.menuName10, out this.menuPrice10, out this.btnAddToCart10);
            this.menuItemPanel11 = CreateMenuCard("Grilled Skewers", "Rs. 17.25", false, "x Not Available", false, true, out this.menuPic11, out this.menuStatus11, out this.menuName11, out this.menuPrice11, out this.btnAddToCart11);
            this.menuItemPanel12 = CreateMenuCard("Fried Rice", "Rs. 19.50", true, "+ Add to Cart", true, false, out this.menuPic12, out this.menuStatus12, out this.menuName12, out this.menuPrice12, out this.btnAddToCart12);

            this.menuGrid.Controls.Add(this.menuItemPanel1, 0, 0);
            this.menuGrid.Controls.Add(this.menuItemPanel2, 1, 0);
            this.menuGrid.Controls.Add(this.menuItemPanel3, 2, 0);
            this.menuGrid.Controls.Add(this.menuItemPanel4, 3, 0);
            this.menuGrid.Controls.Add(this.menuItemPanel5, 0, 1);
            this.menuGrid.Controls.Add(this.menuItemPanel6, 1, 1);
            this.menuGrid.Controls.Add(this.menuItemPanel7, 2, 1);
            this.menuGrid.Controls.Add(this.menuItemPanel8, 3, 1);
            this.menuGrid.Controls.Add(this.menuItemPanel9, 0, 2);
            this.menuGrid.Controls.Add(this.menuItemPanel10, 1, 2);
            this.menuGrid.Controls.Add(this.menuItemPanel11, 2, 2);
            this.menuGrid.Controls.Add(this.menuItemPanel12, 3, 2);

            this.centerContent.Controls.Add(this.menuGrid);
            this.centerContent.Controls.Add(this.filterBar);

            this.mainContainer.Controls.Add(this.centerContent);
            this.mainContainer.Controls.Add(this.topHeader);
            this.mainContainer.Controls.Add(this.leftSidebar);
            this.mainContainer.Controls.Add(this.rightSidebar);
            this.Controls.Add(this.mainContainer);

            this.ResumeLayout(false);
        }

        private Button CreateNavButton(string name, string text)
        {
            Color navy = Color.FromArgb(26, 43, 60);
            Button button = new Button
            {
                BackColor = Color.White,
                Dock = DockStyle.Top,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular),
                ForeColor = navy,
                Height = 40,
                Name = name,
                Padding = new Padding(15, 0, 0, 0),
                Text = text,
                TextAlign = ContentAlignment.MiddleLeft,
                UseVisualStyleBackColor = false
            };
            button.FlatAppearance.BorderSize = 0;
            return button;
        }

        private Button CreateSubNavButton(string name, string text, int y, bool isBold)
        {
            Color navy = Color.FromArgb(26, 43, 60);
            Button button = new Button
            {
                BackColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Microsoft Sans Serif", 8.5F, isBold ? FontStyle.Bold : FontStyle.Regular),
                ForeColor = navy,
                Location = new Point(25, y),
                Name = name,
                Size = new Size(135, 30),
                Text = text,
                TextAlign = ContentAlignment.MiddleLeft,
                UseVisualStyleBackColor = false
            };
            button.FlatAppearance.BorderSize = 0;
            return button;
        }

        private Button CreateFilterButton(string name, string text, int width, bool isPrimary)
        {
            Color navy = Color.FromArgb(26, 43, 60);
            Button button = new Button
            {
                BackColor = isPrimary ? navy : Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Microsoft Sans Serif", 8F, isPrimary ? FontStyle.Bold : FontStyle.Regular),
                ForeColor = isPrimary ? Color.White : navy,
                Margin = new Padding(0, 0, 8, 0),
                Name = name,
                Size = new Size(width, 35),
                Text = text,
                UseVisualStyleBackColor = false
            };
            if (isPrimary)
            {
                button.FlatAppearance.BorderSize = 0;
            }
            else
            {
                button.FlatAppearance.BorderColor = Color.LightGray;
            }
            return button;
        }

        private Label CreateTotalLabel(string text, bool isGreen, bool alignRight)
        {
            Color navy = Color.FromArgb(26, 43, 60);
            return new Label
            {
                Dock = DockStyle.Fill,
                Font = new Font("Microsoft Sans Serif", 8.5F, FontStyle.Regular),
                ForeColor = isGreen ? Color.Green : navy,
                Text = text,
                TextAlign = alignRight ? ContentAlignment.MiddleRight : ContentAlignment.MiddleLeft
            };
        }

        private Panel CreateCartItem(string title, string subtext, string price, out PictureBox picture, out Label titleLabel,
            out Label subtextLabel, out Label priceLabel, out Button editButton, out Button deleteButton)
        {
            Color navy = Color.FromArgb(26, 43, 60);

            Panel item = new Panel
            {
                BackColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle,
                Margin = new Padding(0, 0, 0, 8),
                Size = new Size(250, 80)
            };

            picture = new PictureBox
            {
                BackColor = Color.LightGray,
                Location = new Point(6, 14),
                Size = new Size(50, 50),
                TabStop = false
            };

            titleLabel = new Label
            {
                AutoSize = true,
                Font = new Font("Microsoft Sans Serif", 8.5F, FontStyle.Bold),
                ForeColor = navy,
                Location = new Point(64, 8),
                Text = title
            };

            subtextLabel = new Label
            {
                AutoSize = false,
                Font = new Font("Microsoft Sans Serif", 7F, FontStyle.Regular),
                ForeColor = Color.Gray,
                Location = new Point(64, 29),
                Size = new Size(132, 18),
                Text = subtext
            };

            priceLabel = new Label
            {
                AutoSize = true,
                Font = new Font("Microsoft Sans Serif", 8.5F, FontStyle.Bold),
                ForeColor = navy,
                Location = new Point(64, 51),
                Text = price
            };

            editButton = new Button
            {
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Microsoft Sans Serif", 7F, FontStyle.Regular),
                Location = new Point(199, 12),
                Size = new Size(45, 22),
                Text = "Edit"
            };

            deleteButton = new Button
            {
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Microsoft Sans Serif", 7F, FontStyle.Regular),
                Location = new Point(199, 42),
                Size = new Size(45, 22),
                Text = "Delete"
            };

            item.Controls.Add(picture);
            item.Controls.Add(titleLabel);
            item.Controls.Add(subtextLabel);
            item.Controls.Add(priceLabel);
            item.Controls.Add(editButton);
            item.Controls.Add(deleteButton);
            return item;
        }

        private Panel CreateMenuCard(string itemName, string itemPrice, bool available, string actionText, bool primary, bool disabled,
            out PictureBox picture, out Label statusLabel, out Label nameLabel, out Label priceLabel, out Button actionButton)
        {
            Color navy = Color.FromArgb(26, 43, 60);

            Panel card = new Panel
            {
                BackColor = Color.White,
                Dock = DockStyle.Fill,
                Margin = new Padding(8),
                Size = new Size(180, 220)
            };

            picture = new PictureBox
            {
                BackColor = Color.LightGray,
                Dock = DockStyle.Top,
                Height = 120,
                Size = new Size(180, 120),
                SizeMode = PictureBoxSizeMode.StretchImage,
                TabStop = false
            };

            statusLabel = new Label
            {
                Anchor = AnchorStyles.Top | AnchorStyles.Right,
                AutoSize = false,
                BackColor = Color.LightGray,
                Font = new Font("Microsoft Sans Serif", 7.5F, FontStyle.Bold),
                ForeColor = available ? Color.SeaGreen : Color.IndianRed,
                Location = new Point(70, 5),
                Size = new Size(100, 20),
                Text = available ? "• Available" : "• Not Available",
                TextAlign = ContentAlignment.MiddleRight
            };
            picture.Controls.Add(statusLabel);
            statusLabel.BringToFront();

            nameLabel = new Label
            {
                AutoSize = true,
                Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold),
                ForeColor = navy,
                Location = new Point(10, 130),
                Text = itemName
            };

            priceLabel = new Label
            {
                Anchor = AnchorStyles.Top | AnchorStyles.Right,
                AutoSize = true,
                Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold),
                ForeColor = navy,
                Location = new Point(118, 155),
                Text = itemPrice
            };

            actionButton = new Button
            {
                Dock = DockStyle.Bottom,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Bold),
                Height = 35,
                Text = actionText,
                UseVisualStyleBackColor = false
            };

            if (disabled)
            {
                actionButton.BackColor = Color.LightGray;
                actionButton.ForeColor = Color.Gray;
                actionButton.Enabled = false;
            }
            else if (primary)
            {
                actionButton.BackColor = navy;
                actionButton.FlatAppearance.BorderSize = 0;
                actionButton.ForeColor = Color.White;
            }
            else
            {
                actionButton.BackColor = Color.White;
                actionButton.FlatAppearance.BorderColor = Color.LightGray;
                actionButton.ForeColor = navy;
            }

            card.Controls.Add(picture);
            card.Controls.Add(nameLabel);
            card.Controls.Add(priceLabel);
            card.Controls.Add(actionButton);
            return card;
        }

        private Panel mainContainer, leftSidebar, sidebarTop, tableManagementGroup, sidebarBottom;
        private Button btnDashboard, btnMenuOrder, btnWithdrawal, btnBooked, btnActived, btnRunningOrder, btnSettings, btnLogout;
        private Label lblManageTable;

        private Panel topHeader;
        private FlowLayoutPanel headerLeft, headerRight;
        private Label lblShopName, lblDateTime;
        private ComboBox cmbStatus, cmbUser;

        private Panel rightSidebar, headerPanel, orderOptionsPanel, bottomPanel;
        private TableLayoutPanel orderSummaryLayout, totalsPanel;
        private Label lblOrderSummary, lblOrderNumber;
        private FlowLayoutPanel cartItemsFlow;
        private Label lblSubtotal, lblSubtotalValue, lblTaxes, lblTaxesValue, lblDiscount, lblDiscountValue, lblTotalLabel, lblTotalValue;
        private Label lblOrderType, lblSelectTable;
        private ComboBox cmbOrderType, cmbSelectTable;
        private Button btnDiscount, btnConfirmPayment;

        private Panel centerContent, filterBar, filterRight;
        private FlowLayoutPanel filterLeft;
        private Button btnDishMenu, btnAll42, btnBeverages12, btnMainCourse18, btnDessert8, btnAppetizer6, btnRefresh;
        private TextBox txtSearch;
        private TableLayoutPanel menuGrid;

        private Panel itemPanel1, itemPanel2, itemPanel3;
        private PictureBox itemPic1, itemPic2, itemPic3;
        private Label itemTitle1, itemTitle2, itemTitle3;
        private Label itemSubtext1, itemSubtext2, itemSubtext3;
        private Label itemPrice1, itemPrice2, itemPrice3;
        private Button btnEdit1, btnEdit2, btnEdit3, btnDelete1, btnDelete2, btnDelete3;

        private Panel menuItemPanel1, menuItemPanel2, menuItemPanel3, menuItemPanel4, menuItemPanel5, menuItemPanel6;
        private Panel menuItemPanel7, menuItemPanel8, menuItemPanel9, menuItemPanel10, menuItemPanel11, menuItemPanel12;
        private PictureBox menuPic1, menuPic2, menuPic3, menuPic4, menuPic5, menuPic6;
        private PictureBox menuPic7, menuPic8, menuPic9, menuPic10, menuPic11, menuPic12;
        private Label menuStatus1, menuStatus2, menuStatus3, menuStatus4, menuStatus5, menuStatus6;
        private Label menuStatus7, menuStatus8, menuStatus9, menuStatus10, menuStatus11, menuStatus12;
        private Label menuName1, menuName2, menuName3, menuName4, menuName5, menuName6;
        private Label menuName7, menuName8, menuName9, menuName10, menuName11, menuName12;
        private Label menuPrice1, menuPrice2, menuPrice3, menuPrice4, menuPrice5, menuPrice6;
        private Label menuPrice7, menuPrice8, menuPrice9, menuPrice10, menuPrice11, menuPrice12;
        private Button btnAddToCart1, btnAddToCart2, btnAddToCart3, btnAddToCart4, btnAddToCart5, btnAddToCart6;
        private Button btnAddToCart7, btnAddToCart8, btnAddToCart9, btnAddToCart10, btnAddToCart11, btnAddToCart12;
    }
}
