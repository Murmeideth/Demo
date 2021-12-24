
namespace Demo
{
    partial class Material_list
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.table = new System.Windows.Forms.DataGridView();
            this.search_box = new System.Windows.Forms.TextBox();
            this.sort_box = new System.Windows.Forms.ComboBox();
            this.filter_box = new System.Windows.Forms.ComboBox();
            this.add_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.SuspendLayout();
            // 
            // table
            // 
            this.table.AllowUserToAddRows = false;
            this.table.AllowUserToDeleteRows = false;
            this.table.AllowUserToResizeColumns = false;
            this.table.AllowUserToResizeRows = false;
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.table.DefaultCellStyle = dataGridViewCellStyle1;
            this.table.Location = new System.Drawing.Point(12, 62);
            this.table.MultiSelect = false;
            this.table.Name = "table";
            this.table.ReadOnly = true;
            this.table.Size = new System.Drawing.Size(586, 307);
            this.table.TabIndex = 0;
            this.table.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.table_CellClick);
            // 
            // search_box
            // 
            this.search_box.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.search_box.ForeColor = System.Drawing.Color.Gray;
            this.search_box.Location = new System.Drawing.Point(12, 30);
            this.search_box.Name = "search_box";
            this.search_box.Size = new System.Drawing.Size(274, 26);
            this.search_box.TabIndex = 1;
            this.search_box.Text = "Введите для поиска";
            this.search_box.TextChanged += new System.EventHandler(this.search_box_TextChanged);
            this.search_box.Enter += new System.EventHandler(this.search_box_Enter);
            this.search_box.Leave += new System.EventHandler(this.search_box_Leave);
            // 
            // sort_box
            // 
            this.sort_box.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sort_box.FormattingEnabled = true;
            this.sort_box.Items.AddRange(new object[] {
            "Наименование (А-Я)",
            "Наименование (Я-А)",
            "Остаток на складе (мин-макс)",
            "Остаток на складе (макс-мин)",
            "Стоимость (мин-макс)",
            "Стоимость (макс-мин)"});
            this.sort_box.Location = new System.Drawing.Point(292, 30);
            this.sort_box.Name = "sort_box";
            this.sort_box.Size = new System.Drawing.Size(153, 27);
            this.sort_box.TabIndex = 2;
            this.sort_box.Text = "Сортировка";
            this.sort_box.SelectedIndexChanged += new System.EventHandler(this.sort_box_SelectedIndexChanged);
            // 
            // filter_box
            // 
            this.filter_box.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.filter_box.FormattingEnabled = true;
            this.filter_box.Items.AddRange(new object[] {
            "Все типы",
            "Резина",
            "Краска",
            "Силикон"});
            this.filter_box.Location = new System.Drawing.Point(451, 30);
            this.filter_box.Name = "filter_box";
            this.filter_box.Size = new System.Drawing.Size(147, 27);
            this.filter_box.TabIndex = 2;
            this.filter_box.Text = "Фильтрация";
            this.filter_box.SelectedIndexChanged += new System.EventHandler(this.filter_box_SelectedIndexChanged);
            // 
            // add_btn
            // 
            this.add_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add_btn.Location = new System.Drawing.Point(12, 375);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(152, 29);
            this.add_btn.TabIndex = 3;
            this.add_btn.Text = "Добавить материал";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // Material_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 412);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.filter_box);
            this.Controls.Add(this.sort_box);
            this.Controls.Add(this.search_box);
            this.Controls.Add(this.table);
            this.Name = "Material_list";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Список материалов";
            this.Activated += new System.EventHandler(this.Material_list_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView table;
        private System.Windows.Forms.TextBox search_box;
        private System.Windows.Forms.ComboBox sort_box;
        private System.Windows.Forms.ComboBox filter_box;
        private System.Windows.Forms.Button add_btn;
    }
}

