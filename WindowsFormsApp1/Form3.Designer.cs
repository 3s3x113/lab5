
namespace WindowsFormsApp1
{
    partial class Form3
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
            this.учетТовараBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._123DataSet = new WindowsFormsApp1._123DataSet();
            this.учет_товараTableAdapter = new WindowsFormsApp1._123DataSetTableAdapters.Учет_товараTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.iDПоставщикDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фамилияПоставщикаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.имяПоставщикаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.отчествоПоставщикаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеОрганизацииDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.телефонПоставщикаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.адресПоставщикаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.поставщикBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.поставщикTableAdapter = new WindowsFormsApp1._123DataSetTableAdapters.ПоставщикTableAdapter();
            this.поставщикBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.товарBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.товарTableAdapter = new WindowsFormsApp1._123DataSetTableAdapters.ТоварTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.учетТовараBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.товарBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.поставщикBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.iDУчетТовараDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаПоступленияТовараDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаПродажиТовараDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.колвоПоступившегоТовараDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.остатокНаСкладеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDТоварDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.iDПоставщикDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.типТовараBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.тип_товараTableAdapter = new WindowsFormsApp1._123DataSetTableAdapters.Тип_товараTableAdapter();
            this.iDТоварDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.брендТовараDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDТипТовараDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.учетТовараBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._123DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.поставщикBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.поставщикBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.товарBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.учетТовараBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.товарBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.поставщикBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.типТовараBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDУчетТовараDataGridViewTextBoxColumn,
            this.датаПоступленияТовараDataGridViewTextBoxColumn,
            this.датаПродажиТовараDataGridViewTextBoxColumn,
            this.колвоПоступившегоТовараDataGridViewTextBoxColumn,
            this.остатокНаСкладеDataGridViewTextBoxColumn,
            this.iDТоварDataGridViewTextBoxColumn,
            this.iDПоставщикDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.учетТовараBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(758, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // учетТовараBindingSource
            // 
            this.учетТовараBindingSource.DataMember = "Учет товара";
            this.учетТовараBindingSource.DataSource = this._123DataSet;
            // 
            // _123DataSet
            // 
            this._123DataSet.DataSetName = "_123DataSet";
            this._123DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // учет_товараTableAdapter
            // 
            this.учет_товараTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1134, 507);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 38);
            this.button1.TabIndex = 1;
            this.button1.Text = "Выход";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(28, 204);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 38);
            this.button2.TabIndex = 2;
            this.button2.Text = "поиск";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(135, 204);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(84, 38);
            this.button3.TabIndex = 3;
            this.button3.Text = "добавить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(234, 204);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(84, 38);
            this.button4.TabIndex = 4;
            this.button4.Text = "сохранить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDПоставщикDataGridViewTextBoxColumn1,
            this.фамилияПоставщикаDataGridViewTextBoxColumn,
            this.имяПоставщикаDataGridViewTextBoxColumn,
            this.отчествоПоставщикаDataGridViewTextBoxColumn,
            this.названиеОрганизацииDataGridViewTextBoxColumn,
            this.телефонПоставщикаDataGridViewTextBoxColumn,
            this.адресПоставщикаDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.поставщикBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(22, 270);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(748, 150);
            this.dataGridView2.TabIndex = 5;
            // 
            // iDПоставщикDataGridViewTextBoxColumn1
            // 
            this.iDПоставщикDataGridViewTextBoxColumn1.DataPropertyName = "ID_Поставщик";
            this.iDПоставщикDataGridViewTextBoxColumn1.HeaderText = "ID_Поставщик";
            this.iDПоставщикDataGridViewTextBoxColumn1.Name = "iDПоставщикDataGridViewTextBoxColumn1";
            // 
            // фамилияПоставщикаDataGridViewTextBoxColumn
            // 
            this.фамилияПоставщикаDataGridViewTextBoxColumn.DataPropertyName = "Фамилия поставщика";
            this.фамилияПоставщикаDataGridViewTextBoxColumn.HeaderText = "Фамилия поставщика";
            this.фамилияПоставщикаDataGridViewTextBoxColumn.Name = "фамилияПоставщикаDataGridViewTextBoxColumn";
            // 
            // имяПоставщикаDataGridViewTextBoxColumn
            // 
            this.имяПоставщикаDataGridViewTextBoxColumn.DataPropertyName = "Имя поставщика";
            this.имяПоставщикаDataGridViewTextBoxColumn.HeaderText = "Имя поставщика";
            this.имяПоставщикаDataGridViewTextBoxColumn.Name = "имяПоставщикаDataGridViewTextBoxColumn";
            // 
            // отчествоПоставщикаDataGridViewTextBoxColumn
            // 
            this.отчествоПоставщикаDataGridViewTextBoxColumn.DataPropertyName = "Отчество поставщика";
            this.отчествоПоставщикаDataGridViewTextBoxColumn.HeaderText = "Отчество поставщика";
            this.отчествоПоставщикаDataGridViewTextBoxColumn.Name = "отчествоПоставщикаDataGridViewTextBoxColumn";
            // 
            // названиеОрганизацииDataGridViewTextBoxColumn
            // 
            this.названиеОрганизацииDataGridViewTextBoxColumn.DataPropertyName = "Название организации";
            this.названиеОрганизацииDataGridViewTextBoxColumn.HeaderText = "Название организации";
            this.названиеОрганизацииDataGridViewTextBoxColumn.Name = "названиеОрганизацииDataGridViewTextBoxColumn";
            // 
            // телефонПоставщикаDataGridViewTextBoxColumn
            // 
            this.телефонПоставщикаDataGridViewTextBoxColumn.DataPropertyName = "Телефон поставщика";
            this.телефонПоставщикаDataGridViewTextBoxColumn.HeaderText = "Телефон поставщика";
            this.телефонПоставщикаDataGridViewTextBoxColumn.Name = "телефонПоставщикаDataGridViewTextBoxColumn";
            // 
            // адресПоставщикаDataGridViewTextBoxColumn
            // 
            this.адресПоставщикаDataGridViewTextBoxColumn.DataPropertyName = "Адрес поставщика";
            this.адресПоставщикаDataGridViewTextBoxColumn.HeaderText = "Адрес поставщика";
            this.адресПоставщикаDataGridViewTextBoxColumn.Name = "адресПоставщикаDataGridViewTextBoxColumn";
            // 
            // поставщикBindingSource
            // 
            this.поставщикBindingSource.DataMember = "Поставщик";
            this.поставщикBindingSource.DataSource = this._123DataSet;
            // 
            // поставщикTableAdapter
            // 
            this.поставщикTableAdapter.ClearBeforeFill = true;
            // 
            // поставщикBindingSource1
            // 
            this.поставщикBindingSource1.DataMember = "Поставщик";
            this.поставщикBindingSource1.DataSource = this._123DataSet;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(830, 251);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(84, 38);
            this.button5.TabIndex = 7;
            this.button5.Text = "Поиск";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(953, 251);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(84, 38);
            this.button6.TabIndex = 8;
            this.button6.Text = "Добавить";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(1079, 251);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(84, 38);
            this.button7.TabIndex = 9;
            this.button7.Text = "Сохранить";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(28, 426);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(84, 38);
            this.button8.TabIndex = 10;
            this.button8.Text = "Поиск";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(135, 426);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(84, 38);
            this.button9.TabIndex = 11;
            this.button9.Text = "Добавить";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(234, 426);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(84, 38);
            this.button10.TabIndex = 12;
            this.button10.Text = "Сохранить";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
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
            this.dataGridView3.Location = new System.Drawing.Point(830, 92);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(358, 150);
            this.dataGridView3.TabIndex = 13;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(564, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Поставщик";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(405, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Учет товара";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(978, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Товар";
            // 
            // учетТовараBindingSource1
            // 
            this.учетТовараBindingSource1.DataMember = "Учет товара";
            this.учетТовараBindingSource1.DataSource = this._123DataSet;
            // 
            // товарBindingSource1
            // 
            this.товарBindingSource1.DataMember = "Товар";
            this.товарBindingSource1.DataSource = this._123DataSet;
            // 
            // поставщикBindingSource2
            // 
            this.поставщикBindingSource2.DataMember = "Поставщик";
            this.поставщикBindingSource2.DataSource = this._123DataSet;
            // 
            // iDУчетТовараDataGridViewTextBoxColumn
            // 
            this.iDУчетТовараDataGridViewTextBoxColumn.DataPropertyName = "ID_Учет товара";
            this.iDУчетТовараDataGridViewTextBoxColumn.HeaderText = "ID_Учет товара";
            this.iDУчетТовараDataGridViewTextBoxColumn.Name = "iDУчетТовараDataGridViewTextBoxColumn";
            // 
            // датаПоступленияТовараDataGridViewTextBoxColumn
            // 
            this.датаПоступленияТовараDataGridViewTextBoxColumn.DataPropertyName = "Дата поступления товара";
            this.датаПоступленияТовараDataGridViewTextBoxColumn.HeaderText = "Дата поступления товара";
            this.датаПоступленияТовараDataGridViewTextBoxColumn.Name = "датаПоступленияТовараDataGridViewTextBoxColumn";
            // 
            // датаПродажиТовараDataGridViewTextBoxColumn
            // 
            this.датаПродажиТовараDataGridViewTextBoxColumn.DataPropertyName = "Дата продажи товара";
            this.датаПродажиТовараDataGridViewTextBoxColumn.HeaderText = "Дата продажи товара";
            this.датаПродажиТовараDataGridViewTextBoxColumn.Name = "датаПродажиТовараDataGridViewTextBoxColumn";
            // 
            // колвоПоступившегоТовараDataGridViewTextBoxColumn
            // 
            this.колвоПоступившегоТовараDataGridViewTextBoxColumn.DataPropertyName = "Кол-во поступившего товара";
            this.колвоПоступившегоТовараDataGridViewTextBoxColumn.HeaderText = "Кол-во поступившего товара";
            this.колвоПоступившегоТовараDataGridViewTextBoxColumn.Name = "колвоПоступившегоТовараDataGridViewTextBoxColumn";
            // 
            // остатокНаСкладеDataGridViewTextBoxColumn
            // 
            this.остатокНаСкладеDataGridViewTextBoxColumn.DataPropertyName = "Остаток на складе";
            this.остатокНаСкладеDataGridViewTextBoxColumn.HeaderText = "Остаток на складе";
            this.остатокНаСкладеDataGridViewTextBoxColumn.Name = "остатокНаСкладеDataGridViewTextBoxColumn";
            // 
            // iDТоварDataGridViewTextBoxColumn
            // 
            this.iDТоварDataGridViewTextBoxColumn.DataPropertyName = "ID_Товар";
            this.iDТоварDataGridViewTextBoxColumn.DataSource = this.товарBindingSource1;
            this.iDТоварDataGridViewTextBoxColumn.DisplayMember = "Бренд товара";
            this.iDТоварDataGridViewTextBoxColumn.HeaderText = "Товар";
            this.iDТоварDataGridViewTextBoxColumn.Name = "iDТоварDataGridViewTextBoxColumn";
            this.iDТоварDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.iDТоварDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.iDТоварDataGridViewTextBoxColumn.ValueMember = "ID_Товар";
            // 
            // iDПоставщикDataGridViewTextBoxColumn
            // 
            this.iDПоставщикDataGridViewTextBoxColumn.DataPropertyName = "ID_Поставщик";
            this.iDПоставщикDataGridViewTextBoxColumn.DataSource = this.поставщикBindingSource2;
            this.iDПоставщикDataGridViewTextBoxColumn.DisplayMember = "Фамилия поставщика";
            this.iDПоставщикDataGridViewTextBoxColumn.HeaderText = "ID_Поставщик";
            this.iDПоставщикDataGridViewTextBoxColumn.Name = "iDПоставщикDataGridViewTextBoxColumn";
            this.iDПоставщикDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.iDПоставщикDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.iDПоставщикDataGridViewTextBoxColumn.ValueMember = "ID_Поставщик";
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
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 584);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.учетТовараBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._123DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.поставщикBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.поставщикBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.товарBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.учетТовараBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.товарBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.поставщикBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.типТовараBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView1;
        public _123DataSet _123DataSet;
        public System.Windows.Forms.BindingSource учетТовараBindingSource;
        public _123DataSetTableAdapters.Учет_товараTableAdapter учет_товараTableAdapter;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button button3;
        public System.Windows.Forms.Button button4;
        public System.Windows.Forms.DataGridView dataGridView2;
        public System.Windows.Forms.BindingSource поставщикBindingSource;
        public _123DataSetTableAdapters.ПоставщикTableAdapter поставщикTableAdapter;
        public System.Windows.Forms.DataGridViewTextBoxColumn iDПоставщикDataGridViewTextBoxColumn1;
        public System.Windows.Forms.DataGridViewTextBoxColumn фамилияПоставщикаDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridViewTextBoxColumn имяПоставщикаDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridViewTextBoxColumn отчествоПоставщикаDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridViewTextBoxColumn названиеОрганизацииDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridViewTextBoxColumn телефонПоставщикаDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridViewTextBoxColumn адресПоставщикаDataGridViewTextBoxColumn;
        public System.Windows.Forms.BindingSource поставщикBindingSource1;
        public System.Windows.Forms.Button button5;
        public System.Windows.Forms.Button button6;
        public System.Windows.Forms.Button button7;
        public System.Windows.Forms.Button button8;
        public System.Windows.Forms.Button button9;
        public System.Windows.Forms.Button button10;
        public System.Windows.Forms.DataGridView dataGridView3;
        public System.Windows.Forms.BindingSource товарBindingSource;
        public _123DataSetTableAdapters.ТоварTableAdapter товарTableAdapter;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.DataGridViewTextBoxColumn iDУчетТовараDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridViewTextBoxColumn датаПоступленияТовараDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridViewTextBoxColumn датаПродажиТовараDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridViewTextBoxColumn колвоПоступившегоТовараDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridViewTextBoxColumn остатокНаСкладеDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridViewComboBoxColumn iDТоварDataGridViewTextBoxColumn;
        public System.Windows.Forms.BindingSource товарBindingSource1;
        public System.Windows.Forms.DataGridViewComboBoxColumn iDПоставщикDataGridViewTextBoxColumn;
        public System.Windows.Forms.BindingSource поставщикBindingSource2;
        public System.Windows.Forms.BindingSource учетТовараBindingSource1;
        public System.Windows.Forms.BindingSource типТовараBindingSource;
        public _123DataSetTableAdapters.Тип_товараTableAdapter тип_товараTableAdapter;
        public System.Windows.Forms.DataGridViewTextBoxColumn iDТоварDataGridViewTextBoxColumn1;
        public System.Windows.Forms.DataGridViewTextBoxColumn брендТовараDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridViewComboBoxColumn iDТипТовараDataGridViewTextBoxColumn;
    }
}