﻿namespace AccessDB
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAccessUpdate = new System.Windows.Forms.Button();
            this.txtUpdate_Contact = new System.Windows.Forms.TextBox();
            this.txtUpdate_Name = new System.Windows.Forms.TextBox();
            this.txtUpdate_NO = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.TextBox3 = new System.Windows.Forms.TextBox();
            this.TextBox2 = new System.Windows.Forms.TextBox();
            this.btnAccessInsert = new System.Windows.Forms.Button();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.btnAccessDelete = new System.Windows.Forms.Button();
            this.txtDelete_NO = new System.Windows.Forms.TextBox();
            this.Label9 = new System.Windows.Forms.Label();
            this.GroupBox4 = new System.Windows.Forms.GroupBox();
            this.btnAccessQuery = new System.Windows.Forms.Button();
            this.TextBox5 = new System.Windows.Forms.TextBox();
            this.TextBox4 = new System.Windows.Forms.TextBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.btnAccess = new System.Windows.Forms.Button();
            this.BindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.BindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.BindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.BindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.BindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.BindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.BindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.BindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.BindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.BindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.BindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.BindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.BindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.Label2 = new System.Windows.Forms.Label();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.GroupBox3.SuspendLayout();
            this.GroupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BindingNavigator1)).BeginInit();
            this.BindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.GroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.pictureBox1);
            this.GroupBox1.Controls.Add(this.btnAccessUpdate);
            this.GroupBox1.Controls.Add(this.txtUpdate_Contact);
            this.GroupBox1.Controls.Add(this.txtUpdate_Name);
            this.GroupBox1.Controls.Add(this.txtUpdate_NO);
            this.GroupBox1.Controls.Add(this.Label4);
            this.GroupBox1.Controls.Add(this.Label5);
            this.GroupBox1.Controls.Add(this.Label6);
            this.GroupBox1.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.GroupBox1.Location = new System.Drawing.Point(367, 405);
            this.GroupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GroupBox1.Size = new System.Drawing.Size(332, 204);
            this.GroupBox1.TabIndex = 21;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "修改";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(-51, 201);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 62);
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // btnAccessUpdate
            // 
            this.btnAccessUpdate.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAccessUpdate.Location = new System.Drawing.Point(116, 160);
            this.btnAccessUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAccessUpdate.Name = "btnAccessUpdate";
            this.btnAccessUpdate.Size = new System.Drawing.Size(196, 36);
            this.btnAccessUpdate.TabIndex = 5;
            this.btnAccessUpdate.Text = "修改";
            this.btnAccessUpdate.UseVisualStyleBackColor = true;
            this.btnAccessUpdate.Click += new System.EventHandler(this.btnAccessUpdate_Click);
            // 
            // txtUpdate_Contact
            // 
            this.txtUpdate_Contact.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtUpdate_Contact.Location = new System.Drawing.Point(116, 115);
            this.txtUpdate_Contact.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUpdate_Contact.Name = "txtUpdate_Contact";
            this.txtUpdate_Contact.Size = new System.Drawing.Size(195, 31);
            this.txtUpdate_Contact.TabIndex = 12;
            // 
            // txtUpdate_Name
            // 
            this.txtUpdate_Name.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtUpdate_Name.Location = new System.Drawing.Point(116, 74);
            this.txtUpdate_Name.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUpdate_Name.Name = "txtUpdate_Name";
            this.txtUpdate_Name.Size = new System.Drawing.Size(195, 31);
            this.txtUpdate_Name.TabIndex = 11;
            // 
            // txtUpdate_NO
            // 
            this.txtUpdate_NO.Enabled = false;
            this.txtUpdate_NO.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtUpdate_NO.Location = new System.Drawing.Point(116, 32);
            this.txtUpdate_NO.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUpdate_NO.MaxLength = 5;
            this.txtUpdate_NO.Name = "txtUpdate_NO";
            this.txtUpdate_NO.Size = new System.Drawing.Size(195, 31);
            this.txtUpdate_NO.TabIndex = 10;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Label4.Location = new System.Drawing.Point(8, 115);
            this.Label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(69, 20);
            this.Label4.TabIndex = 8;
            this.Label4.Text = "聯絡人";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Label5.Location = new System.Drawing.Point(8, 78);
            this.Label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(89, 20);
            this.Label5.TabIndex = 7;
            this.Label5.Text = "公司名稱";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Label6.Location = new System.Drawing.Point(8, 36);
            this.Label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(89, 20);
            this.Label6.TabIndex = 6;
            this.Label6.Text = "客戶編號";
            // 
            // TextBox3
            // 
            this.TextBox3.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TextBox3.Location = new System.Drawing.Point(112, 115);
            this.TextBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextBox3.Name = "TextBox3";
            this.TextBox3.Size = new System.Drawing.Size(195, 31);
            this.TextBox3.TabIndex = 12;
            // 
            // TextBox2
            // 
            this.TextBox2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TextBox2.Location = new System.Drawing.Point(112, 74);
            this.TextBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextBox2.Name = "TextBox2";
            this.TextBox2.Size = new System.Drawing.Size(195, 31);
            this.TextBox2.TabIndex = 11;
            // 
            // btnAccessInsert
            // 
            this.btnAccessInsert.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAccessInsert.Location = new System.Drawing.Point(112, 160);
            this.btnAccessInsert.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAccessInsert.Name = "btnAccessInsert";
            this.btnAccessInsert.Size = new System.Drawing.Size(196, 36);
            this.btnAccessInsert.TabIndex = 5;
            this.btnAccessInsert.Text = "新增";
            this.btnAccessInsert.UseVisualStyleBackColor = true;
            this.btnAccessInsert.Click += new System.EventHandler(this.btnAccessInsert_Click);
            // 
            // TextBox1
            // 
            this.TextBox1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TextBox1.Location = new System.Drawing.Point(112, 32);
            this.TextBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextBox1.MaxLength = 5;
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(195, 31);
            this.TextBox1.TabIndex = 10;
            // 
            // GroupBox3
            // 
            this.GroupBox3.Controls.Add(this.btnAccessDelete);
            this.GroupBox3.Controls.Add(this.txtDelete_NO);
            this.GroupBox3.Controls.Add(this.Label9);
            this.GroupBox3.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.GroupBox3.Location = new System.Drawing.Point(709, 405);
            this.GroupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GroupBox3.Size = new System.Drawing.Size(545, 85);
            this.GroupBox3.TabIndex = 22;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "刪除";
            // 
            // btnAccessDelete
            // 
            this.btnAccessDelete.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAccessDelete.Location = new System.Drawing.Point(411, 36);
            this.btnAccessDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAccessDelete.Name = "btnAccessDelete";
            this.btnAccessDelete.Size = new System.Drawing.Size(105, 36);
            this.btnAccessDelete.TabIndex = 5;
            this.btnAccessDelete.Text = "刪除";
            this.btnAccessDelete.UseVisualStyleBackColor = true;
            this.btnAccessDelete.Click += new System.EventHandler(this.btnAccessDelete_Click);
            // 
            // txtDelete_NO
            // 
            this.txtDelete_NO.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtDelete_NO.Location = new System.Drawing.Point(169, 32);
            this.txtDelete_NO.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDelete_NO.MaxLength = 5;
            this.txtDelete_NO.Name = "txtDelete_NO";
            this.txtDelete_NO.Size = new System.Drawing.Size(195, 31);
            this.txtDelete_NO.TabIndex = 10;
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Label9.Location = new System.Drawing.Point(47, 40);
            this.Label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(89, 20);
            this.Label9.TabIndex = 6;
            this.Label9.Text = "客戶編號";
            // 
            // GroupBox4
            // 
            this.GroupBox4.Controls.Add(this.btnAccessQuery);
            this.GroupBox4.Controls.Add(this.TextBox5);
            this.GroupBox4.Controls.Add(this.TextBox4);
            this.GroupBox4.Controls.Add(this.Label8);
            this.GroupBox4.Controls.Add(this.Label7);
            this.GroupBox4.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.GroupBox4.Location = new System.Drawing.Point(709, 516);
            this.GroupBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GroupBox4.Name = "GroupBox4";
            this.GroupBox4.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GroupBox4.Size = new System.Drawing.Size(545, 131);
            this.GroupBox4.TabIndex = 23;
            this.GroupBox4.TabStop = false;
            this.GroupBox4.Text = "查詢";
            // 
            // btnAccessQuery
            // 
            this.btnAccessQuery.Location = new System.Drawing.Point(416, 56);
            this.btnAccessQuery.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAccessQuery.Name = "btnAccessQuery";
            this.btnAccessQuery.Size = new System.Drawing.Size(100, 36);
            this.btnAccessQuery.TabIndex = 11;
            this.btnAccessQuery.Text = "查詢";
            this.btnAccessQuery.UseVisualStyleBackColor = true;
            this.btnAccessQuery.Click += new System.EventHandler(this.btnAccessQuery_Click);
            // 
            // TextBox5
            // 
            this.TextBox5.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TextBox5.Location = new System.Drawing.Point(169, 82);
            this.TextBox5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextBox5.MaxLength = 5;
            this.TextBox5.Name = "TextBox5";
            this.TextBox5.Size = new System.Drawing.Size(195, 31);
            this.TextBox5.TabIndex = 10;
            // 
            // TextBox4
            // 
            this.TextBox4.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TextBox4.Location = new System.Drawing.Point(169, 32);
            this.TextBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextBox4.MaxLength = 5;
            this.TextBox4.Name = "TextBox4";
            this.TextBox4.Size = new System.Drawing.Size(195, 31);
            this.TextBox4.TabIndex = 10;
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Label8.Location = new System.Drawing.Point(47, 90);
            this.Label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(69, 20);
            this.Label8.TabIndex = 6;
            this.Label8.Text = "聯絡人";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Label7.Location = new System.Drawing.Point(47, 40);
            this.Label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(89, 20);
            this.Label7.TabIndex = 6;
            this.Label7.Text = "客戶編號";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Label3.Location = new System.Drawing.Point(8, 115);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(69, 20);
            this.Label3.TabIndex = 8;
            this.Label3.Text = "聯絡人";
            // 
            // btnAccess
            // 
            this.btnAccess.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAccess.Location = new System.Drawing.Point(29, 358);
            this.btnAccess.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAccess.Name = "btnAccess";
            this.btnAccess.Size = new System.Drawing.Size(216, 36);
            this.btnAccess.TabIndex = 18;
            this.btnAccess.Text = "連接 Access 資料庫";
            this.btnAccess.Click += new System.EventHandler(this.btnAccess_Click);
            // 
            // BindingNavigator1
            // 
            this.BindingNavigator1.AddNewItem = this.BindingNavigatorAddNewItem;
            this.BindingNavigator1.CountItem = this.BindingNavigatorCountItem;
            this.BindingNavigator1.DeleteItem = this.BindingNavigatorDeleteItem;
            this.BindingNavigator1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.BindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BindingNavigatorMoveFirstItem,
            this.BindingNavigatorMovePreviousItem,
            this.BindingNavigatorSeparator,
            this.BindingNavigatorPositionItem,
            this.BindingNavigatorCountItem,
            this.BindingNavigatorSeparator1,
            this.BindingNavigatorMoveNextItem,
            this.BindingNavigatorMoveLastItem,
            this.BindingNavigatorSeparator2,
            this.BindingNavigatorAddNewItem,
            this.BindingNavigatorDeleteItem,
            this.BindingNavigatorSaveItem});
            this.BindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.BindingNavigator1.MoveFirstItem = this.BindingNavigatorMoveFirstItem;
            this.BindingNavigator1.MoveLastItem = this.BindingNavigatorMoveLastItem;
            this.BindingNavigator1.MoveNextItem = this.BindingNavigatorMoveNextItem;
            this.BindingNavigator1.MovePreviousItem = this.BindingNavigatorMovePreviousItem;
            this.BindingNavigator1.Name = "BindingNavigator1";
            this.BindingNavigator1.PositionItem = this.BindingNavigatorPositionItem;
            this.BindingNavigator1.Size = new System.Drawing.Size(1281, 27);
            this.BindingNavigator1.TabIndex = 20;
            this.BindingNavigator1.Text = "BindingNavigator1";
            // 
            // BindingNavigatorAddNewItem
            // 
            this.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("BindingNavigatorAddNewItem.Image")));
            this.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem";
            this.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.BindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.BindingNavigatorAddNewItem.Text = "加入新的";
            // 
            // BindingNavigatorCountItem
            // 
            this.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem";
            this.BindingNavigatorCountItem.Size = new System.Drawing.Size(34, 24);
            this.BindingNavigatorCountItem.Text = "/{0}";
            this.BindingNavigatorCountItem.ToolTipText = "項目總數";
            // 
            // BindingNavigatorDeleteItem
            // 
            this.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("BindingNavigatorDeleteItem.Image")));
            this.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem";
            this.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.BindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.BindingNavigatorDeleteItem.Text = "刪除";
            // 
            // BindingNavigatorMoveFirstItem
            // 
            this.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("BindingNavigatorMoveFirstItem.Image")));
            this.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem";
            this.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.BindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.BindingNavigatorMoveFirstItem.Text = "移到最前面";
            // 
            // BindingNavigatorMovePreviousItem
            // 
            this.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("BindingNavigatorMovePreviousItem.Image")));
            this.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem";
            this.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.BindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.BindingNavigatorMovePreviousItem.Text = "移到上一個";
            // 
            // BindingNavigatorSeparator
            // 
            this.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator";
            this.BindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // BindingNavigatorPositionItem
            // 
            this.BindingNavigatorPositionItem.AccessibleName = "位置";
            this.BindingNavigatorPositionItem.AutoSize = false;
            this.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem";
            this.BindingNavigatorPositionItem.Size = new System.Drawing.Size(65, 27);
            this.BindingNavigatorPositionItem.Text = "0";
            this.BindingNavigatorPositionItem.ToolTipText = "目前的位置";
            // 
            // BindingNavigatorSeparator1
            // 
            this.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1";
            this.BindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // BindingNavigatorMoveNextItem
            // 
            this.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("BindingNavigatorMoveNextItem.Image")));
            this.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem";
            this.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.BindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.BindingNavigatorMoveNextItem.Text = "移到下一個";
            // 
            // BindingNavigatorMoveLastItem
            // 
            this.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("BindingNavigatorMoveLastItem.Image")));
            this.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem";
            this.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.BindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.BindingNavigatorMoveLastItem.Text = "移到最後面";
            // 
            // BindingNavigatorSeparator2
            // 
            this.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2";
            this.BindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // BindingNavigatorSaveItem
            // 
            this.BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("BindingNavigatorSaveItem.Image")));
            this.BindingNavigatorSaveItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BindingNavigatorSaveItem.Name = "BindingNavigatorSaveItem";
            this.BindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.BindingNavigatorSaveItem.Text = "儲存資料";
            // 
            // DataGridView1
            // 
            this.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Location = new System.Drawing.Point(15, 34);
            this.DataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.RowTemplate.Height = 27;
            this.DataGridView1.Size = new System.Drawing.Size(1256, 308);
            this.DataGridView1.TabIndex = 19;
            this.DataGridView1.SelectionChanged += new System.EventHandler(this.DataGridView1_SelectionChanged);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Label2.Location = new System.Drawing.Point(8, 78);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(89, 20);
            this.Label2.TabIndex = 7;
            this.Label2.Text = "公司名稱";
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.btnAccessInsert);
            this.GroupBox2.Controls.Add(this.TextBox3);
            this.GroupBox2.Controls.Add(this.TextBox2);
            this.GroupBox2.Controls.Add(this.TextBox1);
            this.GroupBox2.Controls.Add(this.Label3);
            this.GroupBox2.Controls.Add(this.Label2);
            this.GroupBox2.Controls.Add(this.Label1);
            this.GroupBox2.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.GroupBox2.Location = new System.Drawing.Point(29, 405);
            this.GroupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GroupBox2.Size = new System.Drawing.Size(330, 231);
            this.GroupBox2.TabIndex = 24;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "新增";
            this.GroupBox2.Paint += new System.Windows.Forms.PaintEventHandler(this.GroupBox2_Paint);
            this.GroupBox2.Enter += new System.EventHandler(this.GroupBox2_Enter);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Label1.Location = new System.Drawing.Point(8, 36);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(89, 20);
            this.Label1.TabIndex = 6;
            this.Label1.Text = "客戶編號";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1281, 651);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.GroupBox3);
            this.Controls.Add(this.GroupBox4);
            this.Controls.Add(this.btnAccess);
            this.Controls.Add(this.BindingNavigator1);
            this.Controls.Add(this.DataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            this.GroupBox4.ResumeLayout(false);
            this.GroupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BindingNavigator1)).EndInit();
            this.BindingNavigator1.ResumeLayout(false);
            this.BindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Button btnAccessUpdate;
        internal System.Windows.Forms.TextBox txtUpdate_Contact;
        internal System.Windows.Forms.TextBox txtUpdate_Name;
        internal System.Windows.Forms.TextBox txtUpdate_NO;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.TextBox TextBox3;
        internal System.Windows.Forms.TextBox TextBox2;
        internal System.Windows.Forms.Button btnAccessInsert;
        internal System.Windows.Forms.TextBox TextBox1;
        internal System.Windows.Forms.GroupBox GroupBox3;
        internal System.Windows.Forms.Button btnAccessDelete;
        internal System.Windows.Forms.TextBox txtDelete_NO;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.GroupBox GroupBox4;
        internal System.Windows.Forms.Button btnAccessQuery;
        internal System.Windows.Forms.TextBox TextBox5;
        internal System.Windows.Forms.TextBox TextBox4;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Button btnAccess;
        internal System.Windows.Forms.BindingNavigator BindingNavigator1;
        internal System.Windows.Forms.ToolStripButton BindingNavigatorAddNewItem;
        internal System.Windows.Forms.ToolStripLabel BindingNavigatorCountItem;
        internal System.Windows.Forms.ToolStripButton BindingNavigatorDeleteItem;
        internal System.Windows.Forms.ToolStripButton BindingNavigatorMoveFirstItem;
        internal System.Windows.Forms.ToolStripButton BindingNavigatorMovePreviousItem;
        internal System.Windows.Forms.ToolStripSeparator BindingNavigatorSeparator;
        internal System.Windows.Forms.ToolStripTextBox BindingNavigatorPositionItem;
        internal System.Windows.Forms.ToolStripSeparator BindingNavigatorSeparator1;
        internal System.Windows.Forms.ToolStripButton BindingNavigatorMoveNextItem;
        internal System.Windows.Forms.ToolStripButton BindingNavigatorMoveLastItem;
        internal System.Windows.Forms.ToolStripSeparator BindingNavigatorSeparator2;
        internal System.Windows.Forms.DataGridView DataGridView1;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.ToolStripButton BindingNavigatorSaveItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

