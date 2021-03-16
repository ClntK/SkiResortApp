
namespace Wk5HandsOn
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label resortIDLabel;
            System.Windows.Forms.Label resortNameLabel;
            System.Windows.Forms.Label verticalRiseLabel;
            System.Windows.Forms.Label trailNumLabel;
            System.Windows.Forms.Label liftNumLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.skiResortDBDataSet1 = new Wk5HandsOn.SkiResortDBDataSet1();
            this.skiResortsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.skiResortsTableAdapter = new Wk5HandsOn.SkiResortDBDataSet1TableAdapters.SkiResortsTableAdapter();
            this.tableAdapterManager = new Wk5HandsOn.SkiResortDBDataSet1TableAdapters.TableAdapterManager();
            this.skiResortsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.skiResortsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.resortIDTextBox = new System.Windows.Forms.TextBox();
            this.resortNameTextBox = new System.Windows.Forms.TextBox();
            this.verticalRiseTextBox = new System.Windows.Forms.TextBox();
            this.trailNumTextBox = new System.Windows.Forms.TextBox();
            this.liftNumTextBox = new System.Windows.Forms.TextBox();
            this.pb_baker = new System.Windows.Forms.PictureBox();
            this.pb_crystal = new System.Windows.Forms.PictureBox();
            this.pb_stevens = new System.Windows.Forms.PictureBox();
            this.pb_alpental = new System.Windows.Forms.PictureBox();
            this.pb_home = new System.Windows.Forms.PictureBox();
            resortIDLabel = new System.Windows.Forms.Label();
            resortNameLabel = new System.Windows.Forms.Label();
            verticalRiseLabel = new System.Windows.Forms.Label();
            trailNumLabel = new System.Windows.Forms.Label();
            liftNumLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.skiResortDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skiResortsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skiResortsBindingNavigator)).BeginInit();
            this.skiResortsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_baker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_crystal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_stevens)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_alpental)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_home)).BeginInit();
            this.SuspendLayout();
            // 
            // resortIDLabel
            // 
            resortIDLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            resortIDLabel.AutoSize = true;
            resortIDLabel.BackColor = System.Drawing.Color.Transparent;
            resortIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            resortIDLabel.ForeColor = System.Drawing.Color.PaleVioletRed;
            resortIDLabel.Location = new System.Drawing.Point(19, 343);
            resortIDLabel.Name = "resortIDLabel";
            resortIDLabel.Size = new System.Drawing.Size(85, 18);
            resortIDLabel.TabIndex = 1;
            resortIDLabel.Text = "Resort ID:";
            // 
            // resortNameLabel
            // 
            resortNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            resortNameLabel.AutoSize = true;
            resortNameLabel.BackColor = System.Drawing.Color.Transparent;
            resortNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            resortNameLabel.ForeColor = System.Drawing.Color.PaleVioletRed;
            resortNameLabel.Location = new System.Drawing.Point(19, 371);
            resortNameLabel.Name = "resortNameLabel";
            resortNameLabel.Size = new System.Drawing.Size(113, 18);
            resortNameLabel.TabIndex = 3;
            resortNameLabel.Text = "Resort Name:";
            // 
            // verticalRiseLabel
            // 
            verticalRiseLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            verticalRiseLabel.AutoSize = true;
            verticalRiseLabel.BackColor = System.Drawing.Color.Transparent;
            verticalRiseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            verticalRiseLabel.ForeColor = System.Drawing.Color.PaleVioletRed;
            verticalRiseLabel.Location = new System.Drawing.Point(19, 399);
            verticalRiseLabel.Name = "verticalRiseLabel";
            verticalRiseLabel.Size = new System.Drawing.Size(108, 18);
            verticalRiseLabel.TabIndex = 5;
            verticalRiseLabel.Text = "Vertical Rise:";
            // 
            // trailNumLabel
            // 
            trailNumLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            trailNumLabel.AutoSize = true;
            trailNumLabel.BackColor = System.Drawing.Color.Transparent;
            trailNumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            trailNumLabel.ForeColor = System.Drawing.Color.PaleVioletRed;
            trailNumLabel.Location = new System.Drawing.Point(19, 427);
            trailNumLabel.Name = "trailNumLabel";
            trailNumLabel.Size = new System.Drawing.Size(86, 18);
            trailNumLabel.TabIndex = 7;
            trailNumLabel.Text = "Trail Num:";
            // 
            // liftNumLabel
            // 
            liftNumLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            liftNumLabel.AutoSize = true;
            liftNumLabel.BackColor = System.Drawing.Color.Transparent;
            liftNumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            liftNumLabel.ForeColor = System.Drawing.Color.PaleVioletRed;
            liftNumLabel.Location = new System.Drawing.Point(19, 455);
            liftNumLabel.Name = "liftNumLabel";
            liftNumLabel.Size = new System.Drawing.Size(76, 18);
            liftNumLabel.TabIndex = 9;
            liftNumLabel.Text = "Lift Num:";
            // 
            // skiResortDBDataSet1
            // 
            this.skiResortDBDataSet1.DataSetName = "SkiResortDBDataSet1";
            this.skiResortDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // skiResortsBindingSource
            // 
            this.skiResortsBindingSource.DataMember = "SkiResorts";
            this.skiResortsBindingSource.DataSource = this.skiResortDBDataSet1;
            // 
            // skiResortsTableAdapter
            // 
            this.skiResortsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.SkiResortsTableAdapter = this.skiResortsTableAdapter;
            this.tableAdapterManager.UpdateOrder = Wk5HandsOn.SkiResortDBDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // skiResortsBindingNavigator
            // 
            this.skiResortsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.skiResortsBindingNavigator.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.skiResortsBindingNavigator.BindingSource = this.skiResortsBindingSource;
            this.skiResortsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.skiResortsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.skiResortsBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.skiResortsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.skiResortsBindingNavigatorSaveItem});
            this.skiResortsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.skiResortsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.skiResortsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.skiResortsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.skiResortsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.skiResortsBindingNavigator.Name = "skiResortsBindingNavigator";
            this.skiResortsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.skiResortsBindingNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.skiResortsBindingNavigator.Size = new System.Drawing.Size(481, 27);
            this.skiResortsBindingNavigator.TabIndex = 0;
            this.skiResortsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            this.bindingNavigatorMoveNextItem.Click += new System.EventHandler(this.BindingNavigatorMoveNextItem_Click);
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // skiResortsBindingNavigatorSaveItem
            // 
            this.skiResortsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.skiResortsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("skiResortsBindingNavigatorSaveItem.Image")));
            this.skiResortsBindingNavigatorSaveItem.Name = "skiResortsBindingNavigatorSaveItem";
            this.skiResortsBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.skiResortsBindingNavigatorSaveItem.Text = "Save Data";
            this.skiResortsBindingNavigatorSaveItem.Click += new System.EventHandler(this.skiResortsBindingNavigatorSaveItem_Click);
            // 
            // resortIDTextBox
            // 
            this.resortIDTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resortIDTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.resortIDTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resortIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.skiResortsBindingSource, "ResortID", true));
            this.resortIDTextBox.Location = new System.Drawing.Point(154, 340);
            this.resortIDTextBox.Name = "resortIDTextBox";
            this.resortIDTextBox.Size = new System.Drawing.Size(301, 15);
            this.resortIDTextBox.TabIndex = 2;
            this.resortIDTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ResortIDTextBox_KeyDown);
            // 
            // resortNameTextBox
            // 
            this.resortNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resortNameTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.resortNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resortNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.skiResortsBindingSource, "ResortName", true));
            this.resortNameTextBox.Location = new System.Drawing.Point(154, 368);
            this.resortNameTextBox.Name = "resortNameTextBox";
            this.resortNameTextBox.Size = new System.Drawing.Size(301, 15);
            this.resortNameTextBox.TabIndex = 4;
            this.resortNameTextBox.TextChanged += new System.EventHandler(this.ResortIDTextBox_TextChanged);
            // 
            // verticalRiseTextBox
            // 
            this.verticalRiseTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.verticalRiseTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.verticalRiseTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.verticalRiseTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.skiResortsBindingSource, "VerticalRise", true));
            this.verticalRiseTextBox.Location = new System.Drawing.Point(154, 396);
            this.verticalRiseTextBox.Name = "verticalRiseTextBox";
            this.verticalRiseTextBox.Size = new System.Drawing.Size(301, 15);
            this.verticalRiseTextBox.TabIndex = 6;
            // 
            // trailNumTextBox
            // 
            this.trailNumTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trailNumTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.trailNumTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.trailNumTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.skiResortsBindingSource, "TrailNum", true));
            this.trailNumTextBox.Location = new System.Drawing.Point(154, 424);
            this.trailNumTextBox.Name = "trailNumTextBox";
            this.trailNumTextBox.Size = new System.Drawing.Size(301, 15);
            this.trailNumTextBox.TabIndex = 8;
            // 
            // liftNumTextBox
            // 
            this.liftNumTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.liftNumTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.liftNumTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.liftNumTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.skiResortsBindingSource, "LiftNum", true));
            this.liftNumTextBox.Location = new System.Drawing.Point(154, 452);
            this.liftNumTextBox.Name = "liftNumTextBox";
            this.liftNumTextBox.Size = new System.Drawing.Size(301, 15);
            this.liftNumTextBox.TabIndex = 10;
            // 
            // pb_baker
            // 
            this.pb_baker.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_baker.Image = ((System.Drawing.Image)(resources.GetObject("pb_baker.Image")));
            this.pb_baker.Location = new System.Drawing.Point(22, 48);
            this.pb_baker.Name = "pb_baker";
            this.pb_baker.Size = new System.Drawing.Size(433, 266);
            this.pb_baker.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_baker.TabIndex = 14;
            this.pb_baker.TabStop = false;
            this.pb_baker.Visible = false;
            // 
            // pb_crystal
            // 
            this.pb_crystal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_crystal.Image = ((System.Drawing.Image)(resources.GetObject("pb_crystal.Image")));
            this.pb_crystal.Location = new System.Drawing.Point(22, 49);
            this.pb_crystal.Name = "pb_crystal";
            this.pb_crystal.Size = new System.Drawing.Size(433, 265);
            this.pb_crystal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_crystal.TabIndex = 15;
            this.pb_crystal.TabStop = false;
            this.pb_crystal.Visible = false;
            // 
            // pb_stevens
            // 
            this.pb_stevens.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_stevens.Image = ((System.Drawing.Image)(resources.GetObject("pb_stevens.Image")));
            this.pb_stevens.Location = new System.Drawing.Point(22, 49);
            this.pb_stevens.Name = "pb_stevens";
            this.pb_stevens.Size = new System.Drawing.Size(433, 265);
            this.pb_stevens.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_stevens.TabIndex = 13;
            this.pb_stevens.TabStop = false;
            this.pb_stevens.Visible = false;
            // 
            // pb_alpental
            // 
            this.pb_alpental.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_alpental.Image = ((System.Drawing.Image)(resources.GetObject("pb_alpental.Image")));
            this.pb_alpental.Location = new System.Drawing.Point(22, 48);
            this.pb_alpental.Name = "pb_alpental";
            this.pb_alpental.Size = new System.Drawing.Size(433, 266);
            this.pb_alpental.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_alpental.TabIndex = 12;
            this.pb_alpental.TabStop = false;
            this.pb_alpental.Visible = false;
            // 
            // pb_home
            // 
            this.pb_home.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_home.Image = ((System.Drawing.Image)(resources.GetObject("pb_home.Image")));
            this.pb_home.Location = new System.Drawing.Point(22, 48);
            this.pb_home.Name = "pb_home";
            this.pb_home.Size = new System.Drawing.Size(433, 265);
            this.pb_home.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_home.TabIndex = 16;
            this.pb_home.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuText;
            this.ClientSize = new System.Drawing.Size(481, 491);
            this.Controls.Add(this.pb_home);
            this.Controls.Add(resortIDLabel);
            this.Controls.Add(this.resortIDTextBox);
            this.Controls.Add(resortNameLabel);
            this.Controls.Add(this.resortNameTextBox);
            this.Controls.Add(verticalRiseLabel);
            this.Controls.Add(this.verticalRiseTextBox);
            this.Controls.Add(trailNumLabel);
            this.Controls.Add(this.trailNumTextBox);
            this.Controls.Add(liftNumLabel);
            this.Controls.Add(this.liftNumTextBox);
            this.Controls.Add(this.skiResortsBindingNavigator);
            this.Controls.Add(this.pb_crystal);
            this.Controls.Add(this.pb_baker);
            this.Controls.Add(this.pb_stevens);
            this.Controls.Add(this.pb_alpental);
            this.Name = "Form1";
            this.Text = "Clint\'s Radical Resort Guide";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.skiResortDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skiResortsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skiResortsBindingNavigator)).EndInit();
            this.skiResortsBindingNavigator.ResumeLayout(false);
            this.skiResortsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_baker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_crystal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_stevens)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_alpental)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_home)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SkiResortDBDataSet1 skiResortDBDataSet1;
        private System.Windows.Forms.BindingSource skiResortsBindingSource;
        private SkiResortDBDataSet1TableAdapters.SkiResortsTableAdapter skiResortsTableAdapter;
        private SkiResortDBDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator skiResortsBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton skiResortsBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox resortIDTextBox;
        private System.Windows.Forms.TextBox resortNameTextBox;
        private System.Windows.Forms.TextBox verticalRiseTextBox;
        private System.Windows.Forms.TextBox trailNumTextBox;
        private System.Windows.Forms.TextBox liftNumTextBox;
        private System.Windows.Forms.PictureBox pb_baker;
        private System.Windows.Forms.PictureBox pb_crystal;
        private System.Windows.Forms.PictureBox pb_stevens;
        private System.Windows.Forms.PictureBox pb_alpental;
        private System.Windows.Forms.PictureBox pb_home;
    }
}

