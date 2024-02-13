namespace ParticipationMO4
{
  partial class LocalPhoneListForm
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LocalPhoneListForm));
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.TxtBoxFNSearch = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.BtnSearch = new System.Windows.Forms.Button();
      this.BtnSortLN = new System.Windows.Forms.Button();
      this.BtnAge30 = new System.Windows.Forms.Button();
      this.BtnAvgAge = new System.Windows.Forms.Button();
      this.BtnClear = new System.Windows.Forms.Button();
      this.localPhoneDbDataSet = new ParticipationMO4.LocalPhoneDbDataSet();
      this.localPhoneTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.localPhoneTableTableAdapter = new ParticipationMO4.LocalPhoneDbDataSetTableAdapters.LocalPhoneTableTableAdapter();
      this.tableAdapterManager = new ParticipationMO4.LocalPhoneDbDataSetTableAdapters.TableAdapterManager();
      this.localPhoneTableBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
      this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
      this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
      this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
      this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
      this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
      this.localPhoneTableBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
      this.localPhoneTableDataGridView = new System.Windows.Forms.DataGridView();
      this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.groupBox1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.localPhoneDbDataSet)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.localPhoneTableBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.localPhoneTableBindingNavigator)).BeginInit();
      this.localPhoneTableBindingNavigator.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.localPhoneTableDataGridView)).BeginInit();
      this.SuspendLayout();
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.TxtBoxFNSearch);
      this.groupBox1.Controls.Add(this.label1);
      this.groupBox1.Controls.Add(this.BtnSearch);
      this.groupBox1.Location = new System.Drawing.Point(26, 240);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(363, 123);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Search";
      // 
      // TxtBoxFNSearch
      // 
      this.TxtBoxFNSearch.Location = new System.Drawing.Point(99, 37);
      this.TxtBoxFNSearch.Name = "TxtBoxFNSearch";
      this.TxtBoxFNSearch.Size = new System.Drawing.Size(246, 20);
      this.TxtBoxFNSearch.TabIndex = 2;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(36, 40);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(57, 13);
      this.label1.TabIndex = 1;
      this.label1.Text = "First Name";
      // 
      // BtnSearch
      // 
      this.BtnSearch.Location = new System.Drawing.Point(17, 63);
      this.BtnSearch.Name = "BtnSearch";
      this.BtnSearch.Size = new System.Drawing.Size(328, 42);
      this.BtnSearch.TabIndex = 0;
      this.BtnSearch.Text = "Search";
      this.BtnSearch.UseVisualStyleBackColor = true;
      this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
      // 
      // BtnSortLN
      // 
      this.BtnSortLN.Location = new System.Drawing.Point(421, 252);
      this.BtnSortLN.Name = "BtnSortLN";
      this.BtnSortLN.Size = new System.Drawing.Size(138, 41);
      this.BtnSortLN.TabIndex = 1;
      this.BtnSortLN.Text = "Sort by Last Name";
      this.BtnSortLN.UseVisualStyleBackColor = true;
      // 
      // BtnAge30
      // 
      this.BtnAge30.Location = new System.Drawing.Point(585, 252);
      this.BtnAge30.Name = "BtnAge30";
      this.BtnAge30.Size = new System.Drawing.Size(138, 41);
      this.BtnAge30.TabIndex = 1;
      this.BtnAge30.Text = "Age > 30";
      this.BtnAge30.UseVisualStyleBackColor = true;
      // 
      // BtnAvgAge
      // 
      this.BtnAvgAge.Location = new System.Drawing.Point(421, 304);
      this.BtnAvgAge.Name = "BtnAvgAge";
      this.BtnAvgAge.Size = new System.Drawing.Size(138, 41);
      this.BtnAvgAge.TabIndex = 1;
      this.BtnAvgAge.Text = "Average Age";
      this.BtnAvgAge.UseVisualStyleBackColor = true;
      // 
      // BtnClear
      // 
      this.BtnClear.Location = new System.Drawing.Point(585, 303);
      this.BtnClear.Name = "BtnClear";
      this.BtnClear.Size = new System.Drawing.Size(138, 41);
      this.BtnClear.TabIndex = 1;
      this.BtnClear.Text = "Clear";
      this.BtnClear.UseVisualStyleBackColor = true;
      // 
      // localPhoneDbDataSet
      // 
      this.localPhoneDbDataSet.DataSetName = "LocalPhoneDbDataSet";
      this.localPhoneDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // localPhoneTableBindingSource
      // 
      this.localPhoneTableBindingSource.DataMember = "LocalPhoneTable";
      this.localPhoneTableBindingSource.DataSource = this.localPhoneDbDataSet;
      // 
      // localPhoneTableTableAdapter
      // 
      this.localPhoneTableTableAdapter.ClearBeforeFill = true;
      // 
      // tableAdapterManager
      // 
      this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
      this.tableAdapterManager.LocalPhoneTableTableAdapter = this.localPhoneTableTableAdapter;
      this.tableAdapterManager.UpdateOrder = ParticipationMO4.LocalPhoneDbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
      // 
      // localPhoneTableBindingNavigator
      // 
      this.localPhoneTableBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
      this.localPhoneTableBindingNavigator.BindingSource = this.localPhoneTableBindingSource;
      this.localPhoneTableBindingNavigator.CountItem = this.bindingNavigatorCountItem;
      this.localPhoneTableBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
      this.localPhoneTableBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.localPhoneTableBindingNavigatorSaveItem});
      this.localPhoneTableBindingNavigator.Location = new System.Drawing.Point(0, 0);
      this.localPhoneTableBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
      this.localPhoneTableBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
      this.localPhoneTableBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
      this.localPhoneTableBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
      this.localPhoneTableBindingNavigator.Name = "localPhoneTableBindingNavigator";
      this.localPhoneTableBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
      this.localPhoneTableBindingNavigator.Size = new System.Drawing.Size(759, 25);
      this.localPhoneTableBindingNavigator.TabIndex = 2;
      this.localPhoneTableBindingNavigator.Text = "bindingNavigator1";
      // 
      // bindingNavigatorMoveFirstItem
      // 
      this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
      this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
      this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
      this.bindingNavigatorMoveFirstItem.Text = "Move first";
      // 
      // bindingNavigatorMovePreviousItem
      // 
      this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
      this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
      this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
      this.bindingNavigatorMovePreviousItem.Text = "Move previous";
      // 
      // bindingNavigatorSeparator
      // 
      this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
      this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
      // 
      // bindingNavigatorPositionItem
      // 
      this.bindingNavigatorPositionItem.AccessibleName = "Position";
      this.bindingNavigatorPositionItem.AutoSize = false;
      this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
      this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
      this.bindingNavigatorPositionItem.Text = "0";
      this.bindingNavigatorPositionItem.ToolTipText = "Current position";
      // 
      // bindingNavigatorCountItem
      // 
      this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
      this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
      this.bindingNavigatorCountItem.Text = "of {0}";
      this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
      // 
      // bindingNavigatorSeparator1
      // 
      this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
      this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
      // 
      // bindingNavigatorMoveNextItem
      // 
      this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
      this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
      this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
      this.bindingNavigatorMoveNextItem.Text = "Move next";
      // 
      // bindingNavigatorMoveLastItem
      // 
      this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
      this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
      this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
      this.bindingNavigatorMoveLastItem.Text = "Move last";
      // 
      // bindingNavigatorSeparator2
      // 
      this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
      this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
      // 
      // bindingNavigatorAddNewItem
      // 
      this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
      this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
      this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
      this.bindingNavigatorAddNewItem.Text = "Add new";
      // 
      // bindingNavigatorDeleteItem
      // 
      this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
      this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
      this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
      this.bindingNavigatorDeleteItem.Text = "Delete";
      // 
      // localPhoneTableBindingNavigatorSaveItem
      // 
      this.localPhoneTableBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.localPhoneTableBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("localPhoneTableBindingNavigatorSaveItem.Image")));
      this.localPhoneTableBindingNavigatorSaveItem.Name = "localPhoneTableBindingNavigatorSaveItem";
      this.localPhoneTableBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
      this.localPhoneTableBindingNavigatorSaveItem.Text = "Save Data";
      this.localPhoneTableBindingNavigatorSaveItem.Click += new System.EventHandler(this.localPhoneTableBindingNavigatorSaveItem_Click);
      // 
      // localPhoneTableDataGridView
      // 
      this.localPhoneTableDataGridView.AutoGenerateColumns = false;
      this.localPhoneTableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.localPhoneTableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
      this.localPhoneTableDataGridView.DataSource = this.localPhoneTableBindingSource;
      this.localPhoneTableDataGridView.Location = new System.Drawing.Point(12, 28);
      this.localPhoneTableDataGridView.Name = "localPhoneTableDataGridView";
      this.localPhoneTableDataGridView.Size = new System.Drawing.Size(711, 206);
      this.localPhoneTableDataGridView.TabIndex = 6;
      // 
      // dataGridViewTextBoxColumn1
      // 
      this.dataGridViewTextBoxColumn1.DataPropertyName = "PersonId";
      this.dataGridViewTextBoxColumn1.HeaderText = "PersonId";
      this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
      this.dataGridViewTextBoxColumn1.ReadOnly = true;
      // 
      // dataGridViewTextBoxColumn2
      // 
      this.dataGridViewTextBoxColumn2.DataPropertyName = "FirstName";
      this.dataGridViewTextBoxColumn2.HeaderText = "FirstName";
      this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
      // 
      // dataGridViewTextBoxColumn3
      // 
      this.dataGridViewTextBoxColumn3.DataPropertyName = "LastName";
      this.dataGridViewTextBoxColumn3.HeaderText = "LastName";
      this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
      // 
      // dataGridViewTextBoxColumn4
      // 
      this.dataGridViewTextBoxColumn4.DataPropertyName = "PhoneNumber";
      this.dataGridViewTextBoxColumn4.HeaderText = "PhoneNumber";
      this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
      // 
      // dataGridViewTextBoxColumn5
      // 
      this.dataGridViewTextBoxColumn5.DataPropertyName = "Age";
      this.dataGridViewTextBoxColumn5.HeaderText = "Age";
      this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
      // 
      // LocalPhoneListForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(759, 383);
      this.Controls.Add(this.localPhoneTableDataGridView);
      this.Controls.Add(this.localPhoneTableBindingNavigator);
      this.Controls.Add(this.BtnClear);
      this.Controls.Add(this.BtnAvgAge);
      this.Controls.Add(this.BtnAge30);
      this.Controls.Add(this.BtnSortLN);
      this.Controls.Add(this.groupBox1);
      this.Name = "LocalPhoneListForm";
      this.Text = "LocalPhoneListForm";
      this.Load += new System.EventHandler(this.LocalPhoneListForm_Load);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.localPhoneDbDataSet)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.localPhoneTableBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.localPhoneTableBindingNavigator)).EndInit();
      this.localPhoneTableBindingNavigator.ResumeLayout(false);
      this.localPhoneTableBindingNavigator.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.localPhoneTableDataGridView)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.TextBox TxtBoxFNSearch;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button BtnSearch;
    private System.Windows.Forms.Button BtnSortLN;
    private System.Windows.Forms.Button BtnAge30;
    private System.Windows.Forms.Button BtnAvgAge;
    private System.Windows.Forms.Button BtnClear;
    private LocalPhoneDbDataSet localPhoneDbDataSet;
    private System.Windows.Forms.BindingSource localPhoneTableBindingSource;
    private LocalPhoneDbDataSetTableAdapters.LocalPhoneTableTableAdapter localPhoneTableTableAdapter;
    private LocalPhoneDbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    private System.Windows.Forms.BindingNavigator localPhoneTableBindingNavigator;
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
    private System.Windows.Forms.ToolStripButton localPhoneTableBindingNavigatorSaveItem;
    private System.Windows.Forms.DataGridView localPhoneTableDataGridView;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
  }
}