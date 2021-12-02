namespace PizzaPalace
{
    partial class frmPizzaPalace
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPizzaPalace));
            this.grpDeliveryZone = new System.Windows.Forms.GroupBox();
            this.cboZones = new System.Windows.Forms.ComboBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.grpOrderItems = new System.Windows.Forms.GroupBox();
            this.lblNumItems = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lstOrderItems = new System.Windows.Forms.ListBox();
            this.btnAddToOrder = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.btnAddTopping = new System.Windows.Forms.Button();
            this.btnRemoveTopping = new System.Windows.Forms.Button();
            this.grpToppings = new System.Windows.Forms.GroupBox();
            this.lstToppings = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNewTopping = new System.Windows.Forms.TextBox();
            this.lstAvailToppings = new System.Windows.Forms.ListBox();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpCrust = new System.Windows.Forms.GroupBox();
            this.cboCrusts = new System.Windows.Forms.ComboBox();
            this.grpExtras = new System.Windows.Forms.GroupBox();
            this.chkExtraCheese = new System.Windows.Forms.CheckBox();
            this.chkExtraSauce = new System.Windows.Forms.CheckBox();
            this.grpSize = new System.Windows.Forms.GroupBox();
            this.rdoXL = new System.Windows.Forms.RadioButton();
            this.rdoL = new System.Windows.Forms.RadioButton();
            this.rdoM = new System.Windows.Forms.RadioButton();
            this.rdoS = new System.Windows.Forms.RadioButton();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.grpDeliveryZone.SuspendLayout();
            this.grpOrderItems.SuspendLayout();
            this.grpToppings.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpCrust.SuspendLayout();
            this.grpExtras.SuspendLayout();
            this.grpSize.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDeliveryZone
            // 
            this.grpDeliveryZone.Controls.Add(this.cboZones);
            this.grpDeliveryZone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDeliveryZone.Location = new System.Drawing.Point(932, 166);
            this.grpDeliveryZone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpDeliveryZone.Name = "grpDeliveryZone";
            this.grpDeliveryZone.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpDeliveryZone.Size = new System.Drawing.Size(248, 107);
            this.grpDeliveryZone.TabIndex = 22;
            this.grpDeliveryZone.TabStop = false;
            this.grpDeliveryZone.Text = "Delivery Zone";
            // 
            // cboZones
            // 
            this.cboZones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboZones.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboZones.FormattingEnabled = true;
            this.cboZones.Location = new System.Drawing.Point(8, 49);
            this.cboZones.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboZones.Name = "cboZones";
            this.cboZones.Size = new System.Drawing.Size(212, 24);
            this.cboZones.TabIndex = 6;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(739, 571);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 64);
            this.btnExit.TabIndex = 33;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.BackColor = System.Drawing.Color.Green;
            this.btnPlaceOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlaceOrder.ForeColor = System.Drawing.Color.White;
            this.btnPlaceOrder.Location = new System.Drawing.Point(955, 571);
            this.btnPlaceOrder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(225, 64);
            this.btnPlaceOrder.TabIndex = 32;
            this.btnPlaceOrder.Text = "Place Order";
            this.btnPlaceOrder.UseVisualStyleBackColor = false;
            // 
            // grpOrderItems
            // 
            this.grpOrderItems.Controls.Add(this.lblTotal);
            this.grpOrderItems.Controls.Add(this.label5);
            this.grpOrderItems.Controls.Add(this.lblNumItems);
            this.grpOrderItems.Controls.Add(this.label3);
            this.grpOrderItems.Controls.Add(this.lstOrderItems);
            this.grpOrderItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpOrderItems.Location = new System.Drawing.Point(739, 281);
            this.grpOrderItems.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpOrderItems.Name = "grpOrderItems";
            this.grpOrderItems.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpOrderItems.Size = new System.Drawing.Size(441, 283);
            this.grpOrderItems.TabIndex = 27;
            this.grpOrderItems.TabStop = false;
            this.grpOrderItems.Text = "Order Items (double click to remove)";
            // 
            // lblNumItems
            // 
            this.lblNumItems.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNumItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumItems.Location = new System.Drawing.Point(108, 238);
            this.lblNumItems.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumItems.Name = "lblNumItems";
            this.lblNumItems.Size = new System.Drawing.Size(67, 36);
            this.lblNumItems.TabIndex = 12;
            this.lblNumItems.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 245);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "# Items";
            // 
            // lstOrderItems
            // 
            this.lstOrderItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstOrderItems.FormattingEnabled = true;
            this.lstOrderItems.ItemHeight = 16;
            this.lstOrderItems.Location = new System.Drawing.Point(8, 34);
            this.lstOrderItems.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstOrderItems.Name = "lstOrderItems";
            this.lstOrderItems.Size = new System.Drawing.Size(421, 196);
            this.lstOrderItems.TabIndex = 10;
            // 
            // btnAddToOrder
            // 
            this.btnAddToOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToOrder.Location = new System.Drawing.Point(619, 415);
            this.btnAddToOrder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddToOrder.Name = "btnAddToOrder";
            this.btnAddToOrder.Size = new System.Drawing.Size(100, 68);
            this.btnAddToOrder.TabIndex = 31;
            this.btnAddToOrder.Text = "Add To Order";
            this.btnAddToOrder.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(644, 338);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 20);
            this.label2.TabIndex = 30;
            this.label2.Text = "Qty";
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(619, 368);
            this.txtQty.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(99, 22);
            this.txtQty.TabIndex = 29;
            // 
            // btnAddTopping
            // 
            this.btnAddTopping.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTopping.Location = new System.Drawing.Point(281, 377);
            this.btnAddTopping.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddTopping.Name = "btnAddTopping";
            this.btnAddTopping.Size = new System.Drawing.Size(45, 28);
            this.btnAddTopping.TabIndex = 28;
            this.btnAddTopping.Text = ">>";
            this.btnAddTopping.UseVisualStyleBackColor = true;
            // 
            // btnRemoveTopping
            // 
            this.btnRemoveTopping.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveTopping.Location = new System.Drawing.Point(281, 415);
            this.btnRemoveTopping.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRemoveTopping.Name = "btnRemoveTopping";
            this.btnRemoveTopping.Size = new System.Drawing.Size(45, 28);
            this.btnRemoveTopping.TabIndex = 25;
            this.btnRemoveTopping.Text = "<<";
            this.btnRemoveTopping.UseVisualStyleBackColor = true;
            // 
            // grpToppings
            // 
            this.grpToppings.Controls.Add(this.lstToppings);
            this.grpToppings.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpToppings.Location = new System.Drawing.Point(327, 281);
            this.grpToppings.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpToppings.Name = "grpToppings";
            this.grpToppings.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpToppings.Size = new System.Drawing.Size(267, 283);
            this.grpToppings.TabIndex = 26;
            this.grpToppings.TabStop = false;
            this.grpToppings.Text = "Toppings";
            // 
            // lstToppings
            // 
            this.lstToppings.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstToppings.FormattingEnabled = true;
            this.lstToppings.ItemHeight = 16;
            this.lstToppings.Location = new System.Drawing.Point(8, 34);
            this.lstToppings.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstToppings.Name = "lstToppings";
            this.lstToppings.Size = new System.Drawing.Size(249, 196);
            this.lstToppings.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNewTopping);
            this.groupBox1.Controls.Add(this.lstAvailToppings);
            this.groupBox1.Controls.Add(this.btnAddNew);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(15, 281);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(267, 316);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Available Toppings";
            // 
            // txtNewTopping
            // 
            this.txtNewTopping.Location = new System.Drawing.Point(8, 279);
            this.txtNewTopping.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNewTopping.Name = "txtNewTopping";
            this.txtNewTopping.Size = new System.Drawing.Size(249, 26);
            this.txtNewTopping.TabIndex = 11;
            // 
            // lstAvailToppings
            // 
            this.lstAvailToppings.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstAvailToppings.FormattingEnabled = true;
            this.lstAvailToppings.ItemHeight = 16;
            this.lstAvailToppings.Location = new System.Drawing.Point(8, 34);
            this.lstAvailToppings.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstAvailToppings.Name = "lstAvailToppings";
            this.lstAvailToppings.Size = new System.Drawing.Size(249, 196);
            this.lstAvailToppings.TabIndex = 10;
            // 
            // btnAddNew
            // 
            this.btnAddNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNew.Location = new System.Drawing.Point(8, 245);
            this.btnAddNew.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(251, 27);
            this.btnAddNew.TabIndex = 9;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(399, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(548, 54);
            this.label1.TabIndex = 23;
            this.label1.Text = "Pizza Palace Order Form";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(31, 14);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(217, 130);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // grpCrust
            // 
            this.grpCrust.Controls.Add(this.cboCrusts);
            this.grpCrust.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCrust.Location = new System.Drawing.Point(676, 166);
            this.grpCrust.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpCrust.Name = "grpCrust";
            this.grpCrust.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpCrust.Size = new System.Drawing.Size(248, 107);
            this.grpCrust.TabIndex = 20;
            this.grpCrust.TabStop = false;
            this.grpCrust.Text = "Crust";
            // 
            // cboCrusts
            // 
            this.cboCrusts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCrusts.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCrusts.FormattingEnabled = true;
            this.cboCrusts.Location = new System.Drawing.Point(8, 49);
            this.cboCrusts.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboCrusts.Name = "cboCrusts";
            this.cboCrusts.Size = new System.Drawing.Size(213, 24);
            this.cboCrusts.TabIndex = 6;
            // 
            // grpExtras
            // 
            this.grpExtras.Controls.Add(this.chkExtraCheese);
            this.grpExtras.Controls.Add(this.chkExtraSauce);
            this.grpExtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpExtras.Location = new System.Drawing.Point(307, 166);
            this.grpExtras.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpExtras.Name = "grpExtras";
            this.grpExtras.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpExtras.Size = new System.Drawing.Size(349, 107);
            this.grpExtras.TabIndex = 19;
            this.grpExtras.TabStop = false;
            this.grpExtras.Text = "Extras";
            // 
            // chkExtraCheese
            // 
            this.chkExtraCheese.AutoSize = true;
            this.chkExtraCheese.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkExtraCheese.Location = new System.Drawing.Point(8, 70);
            this.chkExtraCheese.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkExtraCheese.Name = "chkExtraCheese";
            this.chkExtraCheese.Size = new System.Drawing.Size(126, 21);
            this.chkExtraCheese.TabIndex = 1;
            this.chkExtraCheese.Text = "Extra Cheese";
            this.chkExtraCheese.UseVisualStyleBackColor = true;
            // 
            // chkExtraSauce
            // 
            this.chkExtraSauce.AutoSize = true;
            this.chkExtraSauce.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkExtraSauce.Location = new System.Drawing.Point(8, 37);
            this.chkExtraSauce.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkExtraSauce.Name = "chkExtraSauce";
            this.chkExtraSauce.Size = new System.Drawing.Size(117, 21);
            this.chkExtraSauce.TabIndex = 0;
            this.chkExtraSauce.Text = "Extra Sauce";
            this.chkExtraSauce.UseVisualStyleBackColor = true;
            // 
            // grpSize
            // 
            this.grpSize.Controls.Add(this.rdoXL);
            this.grpSize.Controls.Add(this.rdoL);
            this.grpSize.Controls.Add(this.rdoM);
            this.grpSize.Controls.Add(this.rdoS);
            this.grpSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSize.Location = new System.Drawing.Point(15, 166);
            this.grpSize.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpSize.Name = "grpSize";
            this.grpSize.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpSize.Size = new System.Drawing.Size(267, 107);
            this.grpSize.TabIndex = 18;
            this.grpSize.TabStop = false;
            this.grpSize.Text = "Size";
            // 
            // rdoXL
            // 
            this.rdoXL.AutoSize = true;
            this.rdoXL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoXL.Location = new System.Drawing.Point(120, 65);
            this.rdoXL.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdoXL.Name = "rdoXL";
            this.rdoXL.Size = new System.Drawing.Size(87, 21);
            this.rdoXL.TabIndex = 3;
            this.rdoXL.TabStop = true;
            this.rdoXL.Text = "X-Large";
            this.rdoXL.UseVisualStyleBackColor = true;
            // 
            // rdoL
            // 
            this.rdoL.AutoSize = true;
            this.rdoL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoL.Location = new System.Drawing.Point(120, 37);
            this.rdoL.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdoL.Name = "rdoL";
            this.rdoL.Size = new System.Drawing.Size(71, 21);
            this.rdoL.TabIndex = 2;
            this.rdoL.TabStop = true;
            this.rdoL.Text = "Large";
            this.rdoL.UseVisualStyleBackColor = true;
            // 
            // rdoM
            // 
            this.rdoM.AutoSize = true;
            this.rdoM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoM.Location = new System.Drawing.Point(16, 65);
            this.rdoM.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdoM.Name = "rdoM";
            this.rdoM.Size = new System.Drawing.Size(84, 21);
            this.rdoM.TabIndex = 1;
            this.rdoM.TabStop = true;
            this.rdoM.Text = "Medium";
            this.rdoM.UseVisualStyleBackColor = true;
            // 
            // rdoS
            // 
            this.rdoS.AutoSize = true;
            this.rdoS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoS.Location = new System.Drawing.Point(16, 37);
            this.rdoS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdoS.Name = "rdoS";
            this.rdoS.Size = new System.Drawing.Size(68, 21);
            this.rdoS.TabIndex = 0;
            this.rdoS.TabStop = true;
            this.rdoS.Text = "Small";
            this.rdoS.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(847, 571);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 64);
            this.btnClear.TabIndex = 34;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // lblTotal
            // 
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(300, 238);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(129, 36);
            this.lblTotal.TabIndex = 14;
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(235, 247);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Total:";
            // 
            // frmPizzaPalace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 684);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.grpDeliveryZone);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPlaceOrder);
            this.Controls.Add(this.grpOrderItems);
            this.Controls.Add(this.btnAddToOrder);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.btnAddTopping);
            this.Controls.Add(this.btnRemoveTopping);
            this.Controls.Add(this.grpToppings);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grpCrust);
            this.Controls.Add(this.grpExtras);
            this.Controls.Add(this.grpSize);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmPizzaPalace";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pizza!";
            this.grpDeliveryZone.ResumeLayout(false);
            this.grpOrderItems.ResumeLayout(false);
            this.grpOrderItems.PerformLayout();
            this.grpToppings.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpCrust.ResumeLayout(false);
            this.grpExtras.ResumeLayout(false);
            this.grpExtras.PerformLayout();
            this.grpSize.ResumeLayout(false);
            this.grpSize.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDeliveryZone;
        private System.Windows.Forms.ComboBox cboZones;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.GroupBox grpOrderItems;
        private System.Windows.Forms.Label lblNumItems;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstOrderItems;
        private System.Windows.Forms.Button btnAddToOrder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Button btnAddTopping;
        private System.Windows.Forms.Button btnRemoveTopping;
        private System.Windows.Forms.GroupBox grpToppings;
        private System.Windows.Forms.ListBox lstToppings;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNewTopping;
        private System.Windows.Forms.ListBox lstAvailToppings;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox grpCrust;
        private System.Windows.Forms.ComboBox cboCrusts;
        private System.Windows.Forms.GroupBox grpExtras;
        private System.Windows.Forms.CheckBox chkExtraCheese;
        private System.Windows.Forms.CheckBox chkExtraSauce;
        private System.Windows.Forms.GroupBox grpSize;
        private System.Windows.Forms.RadioButton rdoXL;
        private System.Windows.Forms.RadioButton rdoL;
        private System.Windows.Forms.RadioButton rdoM;
        private System.Windows.Forms.RadioButton rdoS;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label5;
    }
}

