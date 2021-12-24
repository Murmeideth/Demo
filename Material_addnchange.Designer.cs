
namespace Demo
{
    partial class Material_addnchange
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.name_box = new System.Windows.Forms.TextBox();
            this.material_type = new System.Windows.Forms.ComboBox();
            this.unit_box = new System.Windows.Forms.TextBox();
            this.pack_box = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.stock_box = new System.Windows.Forms.TextBox();
            this.min_box = new System.Windows.Forms.TextBox();
            this.cost_box = new System.Windows.Forms.TextBox();
            this.description_box = new System.Windows.Forms.TextBox();
            this.del_btn = new System.Windows.Forms.Button();
            this.add_chng_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Наименование";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Тип материала";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Единица измерения";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Количество в упаковке";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Минимальное количество";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 296);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "Стоимость за единицу";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 341);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 19);
            this.label7.TabIndex = 0;
            this.label7.Text = "Описание";
            // 
            // name_box
            // 
            this.name_box.Location = new System.Drawing.Point(258, 34);
            this.name_box.Name = "name_box";
            this.name_box.Size = new System.Drawing.Size(213, 26);
            this.name_box.TabIndex = 1;
            // 
            // material_type
            // 
            this.material_type.FormattingEnabled = true;
            this.material_type.Items.AddRange(new object[] {
            "Резина",
            "Краска",
            "Силикон"});
            this.material_type.Location = new System.Drawing.Point(258, 74);
            this.material_type.Name = "material_type";
            this.material_type.Size = new System.Drawing.Size(213, 27);
            this.material_type.TabIndex = 2;
            this.material_type.Text = "Тип материала";
            // 
            // unit_box
            // 
            this.unit_box.Location = new System.Drawing.Point(258, 149);
            this.unit_box.Name = "unit_box";
            this.unit_box.Size = new System.Drawing.Size(213, 26);
            this.unit_box.TabIndex = 3;
            // 
            // pack_box
            // 
            this.pack_box.Location = new System.Drawing.Point(258, 197);
            this.pack_box.Name = "pack_box";
            this.pack_box.Size = new System.Drawing.Size(213, 26);
            this.pack_box.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(157, 19);
            this.label8.TabIndex = 5;
            this.label8.Text = "Количество на складе";
            // 
            // stock_box
            // 
            this.stock_box.Location = new System.Drawing.Point(258, 110);
            this.stock_box.Name = "stock_box";
            this.stock_box.Size = new System.Drawing.Size(213, 26);
            this.stock_box.TabIndex = 6;
            // 
            // min_box
            // 
            this.min_box.Location = new System.Drawing.Point(258, 245);
            this.min_box.Name = "min_box";
            this.min_box.Size = new System.Drawing.Size(213, 26);
            this.min_box.TabIndex = 7;
            // 
            // cost_box
            // 
            this.cost_box.Location = new System.Drawing.Point(258, 293);
            this.cost_box.Name = "cost_box";
            this.cost_box.Size = new System.Drawing.Size(213, 26);
            this.cost_box.TabIndex = 8;
            // 
            // description_box
            // 
            this.description_box.Location = new System.Drawing.Point(258, 338);
            this.description_box.Multiline = true;
            this.description_box.Name = "description_box";
            this.description_box.Size = new System.Drawing.Size(213, 105);
            this.description_box.TabIndex = 9;
            // 
            // del_btn
            // 
            this.del_btn.Location = new System.Drawing.Point(16, 463);
            this.del_btn.Name = "del_btn";
            this.del_btn.Size = new System.Drawing.Size(87, 27);
            this.del_btn.TabIndex = 10;
            this.del_btn.Text = "Удалить";
            this.del_btn.UseVisualStyleBackColor = true;
            this.del_btn.Click += new System.EventHandler(this.del_btn_Click);
            // 
            // add_chng_btn
            // 
            this.add_chng_btn.Location = new System.Drawing.Point(385, 463);
            this.add_chng_btn.Name = "add_chng_btn";
            this.add_chng_btn.Size = new System.Drawing.Size(86, 27);
            this.add_chng_btn.TabIndex = 11;
            this.add_chng_btn.Text = "Изменить";
            this.add_chng_btn.UseVisualStyleBackColor = true;
            this.add_chng_btn.Click += new System.EventHandler(this.add_chng_btn_Click);
            // 
            // Material_addnchange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 502);
            this.Controls.Add(this.add_chng_btn);
            this.Controls.Add(this.del_btn);
            this.Controls.Add(this.description_box);
            this.Controls.Add(this.cost_box);
            this.Controls.Add(this.min_box);
            this.Controls.Add(this.stock_box);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pack_box);
            this.Controls.Add(this.unit_box);
            this.Controls.Add(this.material_type);
            this.Controls.Add(this.name_box);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Material_addnchange";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox name_box;
        private System.Windows.Forms.ComboBox material_type;
        private System.Windows.Forms.TextBox unit_box;
        private System.Windows.Forms.TextBox pack_box;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox stock_box;
        private System.Windows.Forms.TextBox min_box;
        private System.Windows.Forms.TextBox cost_box;
        private System.Windows.Forms.TextBox description_box;
        private System.Windows.Forms.Button del_btn;
        private System.Windows.Forms.Button add_chng_btn;
    }
}