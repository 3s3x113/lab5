
namespace WindowsFormsApp1
{
    partial class Form4
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.продажаТовараBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._123DataSet = new WindowsFormsApp1._123DataSet();
            this.продажа_товараTableAdapter = new WindowsFormsApp1._123DataSetTableAdapters.Продажа_товараTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.iDКлиентDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фамилияКлиентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.имяКлиентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.отчествоКлиентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.клиентBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.клиентTableAdapter = new WindowsFormsApp1._123DataSetTableAdapters.КлиентTableAdapter();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.товарBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.товарTableAdapter = new WindowsFormsApp1._123DataSetTableAdapters.ТоварTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.клиентBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.товарBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.iDПродажаТовараDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDСотрудникиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ценаТовараDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаПродажиТовараDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDКлиентDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.iDТоварDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.типТовараBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.тип_товараTableAdapter = new WindowsFormsApp1._123DataSetTableAdapters.Тип_товараTableAdapter();
            this.iDТоварDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.брендТовараDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDТипТовараDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.продажаТовараBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._123DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.товарBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.товарBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.типТовараBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDПродажаТовараDataGridViewTextBoxColumn,
            this.iDСотрудникиDataGridViewTextBoxColumn,
            this.ценаТовараDataGridViewTextBoxColumn,
            this.датаПродажиТовараDataGridViewTextBoxColumn,
            this.iDКлиентDataGridViewTextBoxColumn,
            this.iDТоварDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.продажаТовараBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(102, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(652, 137);
            this.dataGridView1.TabIndex = 0;
            // 
            // продажаТовараBindingSource
            // 
            this.продажаТовараBindingSource.DataMember = "Продажа товара";
            this.продажаТовараBindingSource.DataSource = this._123DataSet;
            // 
            // _123DataSet
            // 
            this._123DataSet.DataSetName = "_123DataSet";
            this._123DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // продажа_товараTableAdapter
            // 
            this.продажа_товараTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1060, 488);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 43);
            this.button1.TabIndex = 1;
            this.button1.Text = "Выход";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDКлиентDataGridViewTextBoxColumn1,
            this.фамилияКлиентаDataGridViewTextBoxColumn,
            this.имяКлиентаDataGridViewTextBoxColumn,
            this.отчествоКлиентаDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.клиентBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(23, 246);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(467, 150);
            this.dataGridView2.TabIndex = 2;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // iDКлиентDataGridViewTextBoxColumn1
            // 
            this.iDКлиентDataGridViewTextBoxColumn1.DataPropertyName = "ID_Клиент";
            this.iDКлиентDataGridViewTextBoxColumn1.HeaderText = "ID_Клиент";
            this.iDКлиентDataGridViewTextBoxColumn1.Name = "iDКлиентDataGridViewTextBoxColumn1";
            // 
            // фамилияКлиентаDataGridViewTextBoxColumn
            // 
            this.фамилияКлиентаDataGridViewTextBoxColumn.DataPropertyName = "Фамилия клиента";
            this.фамилияКлиентаDataGridViewTextBoxColumn.HeaderText = "Фамилия клиента";
            this.фамилияКлиентаDataGridViewTextBoxColumn.Name = "фамилияКлиентаDataGridViewTextBoxColumn";
            // 
            // имяКлиентаDataGridViewTextBoxColumn
            // 
            this.имяКлиентаDataGridViewTextBoxColumn.DataPropertyName = "Имя клиента";
            this.имяКлиентаDataGridViewTextBoxColumn.HeaderText = "Имя клиента";
            this.имяКлиентаDataGridViewTextBoxColumn.Name = "имяКлиентаDataGridViewTextBoxColumn";
            // 
            // отчествоКлиентаDataGridViewTextBoxColumn
            // 
            this.отчествоКлиентаDataGridViewTextBoxColumn.DataPropertyName = "Отчество клиента";
            this.отчествоКлиентаDataGridViewTextBoxColumn.HeaderText = "Отчество клиента";
            this.отчествоКлиентаDataGridViewTextBoxColumn.Name = "отчествоКлиентаDataGridViewTextBoxColumn";
            // 
            // клиентBindingSource
            // 
            this.клиентBindingSource.DataMember = "Клиент";
            this.клиентBindingSource.DataSource = this._123DataSet;
            // 
            // клиентTableAdapter
            // 
            this.клиентTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDТоварDataGridViewTextBoxColumn1,
            this.брендТовараDataGridViewTextBoxColumn,
            this.iDТипТовараDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.товарBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(900, 234);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(353, 116);
            this.dataGridView3.TabIndex = 3;
            // 
            // товарBindingSource
            // 
            this.товарBindingSource.DataMember = "Товар";
            this.товарBindingSource.DataSource = this._123DataSet;
            // 
            // товарTableAdapter
            // 
            this.товарTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(462, 188);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Поиск";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(572, 188);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Добавить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(677, 188);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(77, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "Сохранить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(73, 413);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 7;
            this.button5.Text = "Поиск";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(204, 413);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 8;
            this.button6.Text = "Добавить";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(326, 413);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 9;
            this.button7.Text = "Сохранить";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(929, 357);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 10;
            this.button8.Text = "Поиск";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(1043, 356);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 11;
            this.button9.Text = "Добавить";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(1159, 356);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 23);
            this.button10.TabIndex = 12;
            this.button10.Text = "Сохранить";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(200, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Клиент";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(401, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Продажа товара";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(1056, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Товар";
            // 
            // клиентBindingSource1
            // 
            this.клиентBindingSource1.DataMember = "Клиент";
            this.клиентBindingSource1.DataSource = this._123DataSet;
            // 
            // товарBindingSource1
            // 
            this.товарBindingSource1.DataMember = "Товар";
            this.товарBindingSource1.DataSource = this._123DataSet;
            // 
            // iDПродажаТовараDataGridViewTextBoxColumn
            // 
            this.iDПродажаТовараDataGridViewTextBoxColumn.DataPropertyName = "ID_Продажа товара";
            this.iDПродажаТовараDataGridViewTextBoxColumn.HeaderText = "ID_Продажа товара";
            this.iDПродажаТовараDataGridViewTextBoxColumn.Name = "iDПродажаТовараDataGridViewTextBoxColumn";
            // 
            // iDСотрудникиDataGridViewTextBoxColumn
            // 
            this.iDСотрудникиDataGridViewTextBoxColumn.DataPropertyName = "ID_Сотрудники";
            this.iDСотрудникиDataGridViewTextBoxColumn.HeaderText = "ID_Сотрудники";
            this.iDСотрудникиDataGridViewTextBoxColumn.Name = "iDСотрудникиDataGridViewTextBoxColumn";
            // 
            // ценаТовараDataGridViewTextBoxColumn
            // 
            this.ценаТовараDataGridViewTextBoxColumn.DataPropertyName = "Цена товара";
            this.ценаТовараDataGridViewTextBoxColumn.HeaderText = "Цена товара";
            this.ценаТовараDataGridViewTextBoxColumn.Name = "ценаТовараDataGridViewTextBoxColumn";
            // 
            // датаПродажиТовараDataGridViewTextBoxColumn
            // 
            this.датаПродажиТовараDataGridViewTextBoxColumn.DataPropertyName = "Дата продажи товара";
            this.датаПродажиТовараDataGridViewTextBoxColumn.HeaderText = "Дата продажи товара";
            this.датаПродажиТовараDataGridViewTextBoxColumn.Name = "датаПродажиТовараDataGridViewTextBoxColumn";
            // 
            // iDКлиентDataGridViewTextBoxColumn
            // 
            this.iDКлиентDataGridViewTextBoxColumn.DataPropertyName = "ID_Клиент";
            this.iDКлиентDataGridViewTextBoxColumn.DataSource = this.клиентBindingSource1;
            this.iDКлиентDataGridViewTextBoxColumn.DisplayMember = "Фамилия клиента";
            this.iDКлиентDataGridViewTextBoxColumn.HeaderText = "ID_Клиент";
            this.iDКлиентDataGridViewTextBoxColumn.Name = "iDКлиентDataGridViewTextBoxColumn";
            this.iDКлиентDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.iDКлиентDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.iDКлиентDataGridViewTextBoxColumn.ValueMember = "ID_Клиент";
            // 
            // iDТоварDataGridViewTextBoxColumn
            // 
            this.iDТоварDataGridViewTextBoxColumn.DataPropertyName = "ID_Товар";
            this.iDТоварDataGridViewTextBoxColumn.DataSource = this.товарBindingSource1;
            this.iDТоварDataGridViewTextBoxColumn.DisplayMember = "Бренд товара";
            this.iDТоварDataGridViewTextBoxColumn.HeaderText = "ID_Товар";
            this.iDТоварDataGridViewTextBoxColumn.Name = "iDТоварDataGridViewTextBoxColumn";
            this.iDТоварDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.iDТоварDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.iDТоварDataGridViewTextBoxColumn.ValueMember = "ID_Товар";
            // 
            // типТовараBindingSource
            // 
            this.типТовараBindingSource.DataMember = "Тип товара";
            this.типТовараBindingSource.DataSource = this._123DataSet;
            // 
            // тип_товараTableAdapter
            // 
            this.тип_товараTableAdapter.ClearBeforeFill = true;
            // 
            // iDТоварDataGridViewTextBoxColumn1
            // 
            this.iDТоварDataGridViewTextBoxColumn1.DataPropertyName = "ID_Товар";
            this.iDТоварDataGridViewTextBoxColumn1.HeaderText = "ID_Товар";
            this.iDТоварDataGridViewTextBoxColumn1.Name = "iDТоварDataGridViewTextBoxColumn1";
            // 
            // брендТовараDataGridViewTextBoxColumn
            // 
            this.брендТовараDataGridViewTextBoxColumn.DataPropertyName = "Бренд товара";
            this.брендТовараDataGridViewTextBoxColumn.HeaderText = "Бренд товара";
            this.брендТовараDataGridViewTextBoxColumn.Name = "брендТовараDataGridViewTextBoxColumn";
            // 
            // iDТипТовараDataGridViewTextBoxColumn
            // 
            this.iDТипТовараDataGridViewTextBoxColumn.DataPropertyName = "ID_Тип товара";
            this.iDТипТовараDataGridViewTextBoxColumn.DataSource = this.типТовараBindingSource;
            this.iDТипТовараDataGridViewTextBoxColumn.DisplayMember = "Наименование";
            this.iDТипТовараDataGridViewTextBoxColumn.HeaderText = "ID_Тип товара";
            this.iDТипТовараDataGridViewTextBoxColumn.Name = "iDТипТовараDataGridViewTextBoxColumn";
            this.iDТипТовараDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.iDТипТовараDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.iDТипТовараDataGridViewTextBoxColumn.ValueMember = "ID_Тип товара";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 568);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.продажаТовараBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._123DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.товарBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.товарBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.типТовараBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView1;
        public _123DataSet _123DataSet;
        public System.Windows.Forms.BindingSource продажаТовараBindingSource;
        public _123DataSetTableAdapters.Продажа_товараTableAdapter продажа_товараTableAdapter;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.DataGridView dataGridView2;
        public System.Windows.Forms.BindingSource клиентBindingSource;
        public _123DataSetTableAdapters.КлиентTableAdapter клиентTableAdapter;
        public System.Windows.Forms.DataGridViewTextBoxColumn iDКлиентDataGridViewTextBoxColumn1;
        public System.Windows.Forms.DataGridViewTextBoxColumn фамилияКлиентаDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridViewTextBoxColumn имяКлиентаDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridViewTextBoxColumn отчествоКлиентаDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridView dataGridView3;
        public System.Windows.Forms.BindingSource товарBindingSource;
        public _123DataSetTableAdapters.ТоварTableAdapter товарTableAdapter;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button button3;
        public System.Windows.Forms.Button button4;
        public System.Windows.Forms.Button button5;
        public System.Windows.Forms.Button button6;
        public System.Windows.Forms.Button button7;
        public System.Windows.Forms.Button button8;
        public System.Windows.Forms.Button button9;
        public System.Windows.Forms.Button button10;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.DataGridViewTextBoxColumn iDПродажаТовараDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridViewTextBoxColumn iDСотрудникиDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridViewTextBoxColumn ценаТовараDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridViewTextBoxColumn датаПродажиТовараDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridViewComboBoxColumn iDКлиентDataGridViewTextBoxColumn;
        public System.Windows.Forms.BindingSource клиентBindingSource1;
        public System.Windows.Forms.DataGridViewComboBoxColumn iDТоварDataGridViewTextBoxColumn;
        public System.Windows.Forms.BindingSource товарBindingSource1;
        public System.Windows.Forms.BindingSource типТовараBindingSource;
        public _123DataSetTableAdapters.Тип_товараTableAdapter тип_товараTableAdapter;
        public System.Windows.Forms.DataGridViewTextBoxColumn iDТоварDataGridViewTextBoxColumn1;
        public System.Windows.Forms.DataGridViewTextBoxColumn брендТовараDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridViewComboBoxColumn iDТипТовараDataGridViewTextBoxColumn;
    }
}