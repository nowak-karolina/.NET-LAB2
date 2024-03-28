namespace App {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            components = new System.ComponentModel.Container();
            type_input = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            request_button = new Button();
            data_textBox = new TextBox();
            label5 = new Label();
            json_textBox = new TextBox();
            label6 = new Label();
            AddToDB_button = new Button();
            initBindingSource = new BindingSource(components);
            dataGridView1 = new DataGridView();
            clear_button = new Button();
            accessibility_input = new NumericUpDown();
            parti_input = new NumericUpDown();
            price_input = new NumericUpDown();
            a_checbox = new CheckBox();
            t_checkbox = new CheckBox();
            parti_checkbox = new CheckBox();
            price_checkBox = new CheckBox();
            textBox1 = new TextBox();
            sqliteCommand1 = new Microsoft.Data.Sqlite.SqliteCommand();
            sorting_comboBox = new ComboBox();
            label7 = new Label();
            remove_button = new Button();
            info1 = new Label();
            info2 = new Label();
            info3 = new Label();
            info4 = new Label();
            toolTip1 = new ToolTip(components);
            label8 = new Label();
            typeFilter_comboBox = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)initBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)accessibility_input).BeginInit();
            ((System.ComponentModel.ISupportInitialize)parti_input).BeginInit();
            ((System.ComponentModel.ISupportInitialize)price_input).BeginInit();
            SuspendLayout();
            // 
            // type_input
            // 
            type_input.Enabled = false;
            type_input.FormattingEnabled = true;
            type_input.Items.AddRange(new object[] { "education", "recreational", "social", "diy", "charity", "cooking", "relaxation", "music", "busywork" });
            type_input.Location = new Point(142, 99);
            type_input.Margin = new Padding(3, 4, 3, 4);
            type_input.Name = "type_input";
            type_input.Size = new Size(138, 28);
            type_input.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(70, 103);
            label1.Name = "label1";
            label1.Size = new Size(40, 20);
            label1.TabIndex = 2;
            label1.Text = "Type";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 48);
            label2.Name = "label2";
            label2.Size = new Size(90, 20);
            label2.TabIndex = 3;
            label2.Text = "Accessibility";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 157);
            label3.Name = "label3";
            label3.Size = new Size(85, 20);
            label3.TabIndex = 5;
            label3.Text = "Participants";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(67, 212);
            label4.Name = "label4";
            label4.Size = new Size(41, 20);
            label4.TabIndex = 7;
            label4.Text = "Price";
            // 
            // request_button
            // 
            request_button.BackColor = SystemColors.ActiveCaption;
            request_button.Cursor = Cursors.Hand;
            request_button.Location = new Point(142, 260);
            request_button.Margin = new Padding(3, 4, 3, 4);
            request_button.Name = "request_button";
            request_button.Size = new Size(138, 55);
            request_button.TabIndex = 9;
            request_button.Text = "Send Request";
            request_button.UseVisualStyleBackColor = false;
            request_button.Click += getData;
            // 
            // data_textBox
            // 
            data_textBox.BackColor = SystemColors.ControlLightLight;
            data_textBox.Location = new Point(323, 41);
            data_textBox.Margin = new Padding(3, 4, 3, 4);
            data_textBox.Multiline = true;
            data_textBox.Name = "data_textBox";
            data_textBox.ReadOnly = true;
            data_textBox.Size = new Size(233, 199);
            data_textBox.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(320, 17);
            label5.Name = "label5";
            label5.Size = new Size(103, 20);
            label5.TabIndex = 11;
            label5.Text = "Received data";
            // 
            // json_textBox
            // 
            json_textBox.BackColor = SystemColors.ControlLightLight;
            json_textBox.Location = new Point(599, 41);
            json_textBox.Margin = new Padding(3, 4, 3, 4);
            json_textBox.Multiline = true;
            json_textBox.Name = "json_textBox";
            json_textBox.ReadOnly = true;
            json_textBox.Size = new Size(260, 297);
            json_textBox.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(599, 17);
            label6.Name = "label6";
            label6.Size = new Size(123, 20);
            label6.TabIndex = 13;
            label6.Text = "Deserialized Json";
            // 
            // AddToDB_button
            // 
            AddToDB_button.BackColor = SystemColors.ActiveCaption;
            AddToDB_button.Cursor = Cursors.Hand;
            AddToDB_button.Location = new Point(888, 41);
            AddToDB_button.Margin = new Padding(3, 4, 3, 4);
            AddToDB_button.Name = "AddToDB_button";
            AddToDB_button.Size = new Size(138, 55);
            AddToDB_button.TabIndex = 14;
            AddToDB_button.Text = "Add To DB";
            AddToDB_button.UseVisualStyleBackColor = false;
            AddToDB_button.Click += AddToDB_button_Click;
            // 
            // initBindingSource
            // 
            initBindingSource.DataSource = typeof(Lab2_App.Migrations.Init);
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(14, 348);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1134, 452);
            dataGridView1.TabIndex = 17;
            // 
            // clear_button
            // 
            clear_button.BackColor = SystemColors.ActiveCaption;
            clear_button.Cursor = Cursors.Hand;
            clear_button.Location = new Point(888, 104);
            clear_button.Margin = new Padding(3, 4, 3, 4);
            clear_button.Name = "clear_button";
            clear_button.Size = new Size(138, 55);
            clear_button.TabIndex = 18;
            clear_button.Text = "Clear DB";
            clear_button.UseVisualStyleBackColor = false;
            clear_button.Click += clear_button_Click;
            // 
            // accessibility_input
            // 
            accessibility_input.DecimalPlaces = 1;
            accessibility_input.Enabled = false;
            accessibility_input.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            accessibility_input.Location = new Point(143, 45);
            accessibility_input.Margin = new Padding(3, 4, 3, 4);
            accessibility_input.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            accessibility_input.Name = "accessibility_input";
            accessibility_input.Size = new Size(137, 27);
            accessibility_input.TabIndex = 19;
            // 
            // parti_input
            // 
            parti_input.Enabled = false;
            parti_input.Location = new Point(143, 155);
            parti_input.Margin = new Padding(3, 4, 3, 4);
            parti_input.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            parti_input.Name = "parti_input";
            parti_input.Size = new Size(137, 27);
            parti_input.TabIndex = 24;
            // 
            // price_input
            // 
            price_input.BackColor = SystemColors.Window;
            price_input.DecimalPlaces = 1;
            price_input.Enabled = false;
            price_input.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            price_input.Location = new Point(143, 211);
            price_input.Margin = new Padding(3, 4, 3, 4);
            price_input.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            price_input.Name = "price_input";
            price_input.Size = new Size(137, 27);
            price_input.TabIndex = 25;
            // 
            // a_checbox
            // 
            a_checbox.AutoSize = true;
            a_checbox.Cursor = Cursors.Hand;
            a_checbox.Location = new Point(112, 49);
            a_checbox.Margin = new Padding(3, 4, 3, 4);
            a_checbox.Name = "a_checbox";
            a_checbox.Size = new Size(18, 17);
            a_checbox.TabIndex = 26;
            a_checbox.UseVisualStyleBackColor = true;
            a_checbox.CheckedChanged += CheckBoxChecked;
            // 
            // t_checkbox
            // 
            t_checkbox.AutoSize = true;
            t_checkbox.Cursor = Cursors.Hand;
            t_checkbox.Location = new Point(112, 104);
            t_checkbox.Margin = new Padding(3, 4, 3, 4);
            t_checkbox.Name = "t_checkbox";
            t_checkbox.Size = new Size(18, 17);
            t_checkbox.TabIndex = 27;
            t_checkbox.UseVisualStyleBackColor = true;
            t_checkbox.CheckedChanged += CheckBoxChecked;
            // 
            // parti_checkbox
            // 
            parti_checkbox.AutoSize = true;
            parti_checkbox.Cursor = Cursors.Hand;
            parti_checkbox.Location = new Point(112, 159);
            parti_checkbox.Margin = new Padding(3, 4, 3, 4);
            parti_checkbox.Name = "parti_checkbox";
            parti_checkbox.Size = new Size(18, 17);
            parti_checkbox.TabIndex = 28;
            parti_checkbox.UseVisualStyleBackColor = true;
            parti_checkbox.CheckedChanged += CheckBoxChecked;
            // 
            // price_checkBox
            // 
            price_checkBox.AutoSize = true;
            price_checkBox.Cursor = Cursors.Hand;
            price_checkBox.Location = new Point(112, 215);
            price_checkBox.Margin = new Padding(3, 4, 3, 4);
            price_checkBox.Name = "price_checkBox";
            price_checkBox.Size = new Size(18, 17);
            price_checkBox.TabIndex = 29;
            price_checkBox.UseVisualStyleBackColor = true;
            price_checkBox.CheckedChanged += CheckBoxChecked;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ControlLightLight;
            textBox1.Location = new Point(323, 249);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(233, 89);
            textBox1.TabIndex = 30;
            // 
            // sqliteCommand1
            // 
            sqliteCommand1.CommandTimeout = 30;
            sqliteCommand1.Connection = null;
            sqliteCommand1.Transaction = null;
            sqliteCommand1.UpdatedRowSource = System.Data.UpdateRowSource.None;
            // 
            // sorting_comboBox
            // 
            sorting_comboBox.FormattingEnabled = true;
            sorting_comboBox.Items.AddRange(new object[] { "none", "Accesibility", "Participants", "Price", "Key" });
            sorting_comboBox.Location = new Point(1007, 309);
            sorting_comboBox.Margin = new Padding(3, 4, 3, 4);
            sorting_comboBox.Name = "sorting_comboBox";
            sorting_comboBox.Size = new Size(138, 28);
            sorting_comboBox.TabIndex = 31;
            sorting_comboBox.SelectionChangeCommitted += sorting_comboBox_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(945, 312);
            label7.Name = "label7";
            label7.Size = new Size(56, 20);
            label7.TabIndex = 32;
            label7.Text = "Sort by";
            // 
            // remove_button
            // 
            remove_button.BackColor = SystemColors.ActiveCaption;
            remove_button.Cursor = Cursors.Hand;
            remove_button.Location = new Point(888, 167);
            remove_button.Margin = new Padding(3, 4, 3, 4);
            remove_button.Name = "remove_button";
            remove_button.Size = new Size(138, 55);
            remove_button.TabIndex = 33;
            remove_button.Text = "Remove selected from DB";
            remove_button.UseVisualStyleBackColor = false;
            remove_button.Click += remove_button_Click;
            // 
            // info1
            // 
            info1.AutoSize = true;
            info1.Location = new Point(287, 49);
            info1.Name = "info1";
            info1.Size = new Size(16, 20);
            info1.TabIndex = 34;
            info1.Text = "?";
            info1.MouseHover += showAccessibilityInfo;
            // 
            // info2
            // 
            info2.AutoSize = true;
            info2.Location = new Point(287, 104);
            info2.Name = "info2";
            info2.Size = new Size(16, 20);
            info2.TabIndex = 35;
            info2.Text = "?";
            info2.MouseHover += info2_MouseHover;
            // 
            // info3
            // 
            info3.AutoSize = true;
            info3.Location = new Point(287, 157);
            info3.Name = "info3";
            info3.Size = new Size(16, 20);
            info3.TabIndex = 36;
            info3.Text = "?";
            info3.MouseHover += info3_MouseHover;
            // 
            // info4
            // 
            info4.AutoSize = true;
            info4.Location = new Point(287, 215);
            info4.Name = "info4";
            info4.Size = new Size(16, 20);
            info4.TabIndex = 37;
            info4.Text = "?";
            info4.MouseHover += info4_MouseHover;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(926, 277);
            label8.Name = "label8";
            label8.Size = new Size(75, 20);
            label8.TabIndex = 39;
            label8.Text = "Type filter";
            // 
            // typeFilter_comboBox
            // 
            typeFilter_comboBox.FormattingEnabled = true;
            typeFilter_comboBox.Items.AddRange(new object[] { "none", "education", "recreational", "social", "diy", "charity", "cooking", "relaxation", "music", "busywork" });
            typeFilter_comboBox.Location = new Point(1007, 273);
            typeFilter_comboBox.Margin = new Padding(3, 4, 3, 4);
            typeFilter_comboBox.Name = "typeFilter_comboBox";
            typeFilter_comboBox.Size = new Size(138, 28);
            typeFilter_comboBox.TabIndex = 38;
            typeFilter_comboBox.SelectionChangeCommitted += typeFilter_comboBox_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(1159, 813);
            Controls.Add(label8);
            Controls.Add(typeFilter_comboBox);
            Controls.Add(info4);
            Controls.Add(info3);
            Controls.Add(info2);
            Controls.Add(info1);
            Controls.Add(remove_button);
            Controls.Add(label7);
            Controls.Add(sorting_comboBox);
            Controls.Add(textBox1);
            Controls.Add(price_checkBox);
            Controls.Add(parti_checkbox);
            Controls.Add(t_checkbox);
            Controls.Add(a_checbox);
            Controls.Add(price_input);
            Controls.Add(parti_input);
            Controls.Add(accessibility_input);
            Controls.Add(clear_button);
            Controls.Add(dataGridView1);
            Controls.Add(AddToDB_button);
            Controls.Add(label6);
            Controls.Add(json_textBox);
            Controls.Add(label5);
            Controls.Add(data_textBox);
            Controls.Add(request_button);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(type_input);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)initBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)accessibility_input).EndInit();
            ((System.ComponentModel.ISupportInitialize)parti_input).EndInit();
            ((System.ComponentModel.ISupportInitialize)price_input).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox type_input;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button request_button;
        private TextBox data_textBox;
        private Label label5;
        private TextBox json_textBox;
        private Label label6;
        private Button AddToDB_button;
        private BindingSource initBindingSource;
        private DataGridView dataGridView1;
        private Button clear_button;
        private NumericUpDown accessibility_input;
        private RadioButton a_radioButton;
        private RadioButton t_radioButton;
        private RadioButton p_radioButton;
        private RadioButton price_radioButton;
        private NumericUpDown parti_input;
        private NumericUpDown price_input;
        private CheckBox a_checbox;
        private CheckBox t_checkbox;
        private CheckBox parti_checkbox;
        private CheckBox price_checkBox;
        private TextBox textBox1;
        private Microsoft.Data.Sqlite.SqliteCommand sqliteCommand1;
        private ComboBox sorting_comboBox;
        private Label label7;
        private Button remove_button;
        private Label info1;
        private Label info2;
        private Label info3;
        private Label info4;
        private ToolTip toolTip1;
        private Label label8;
        private ComboBox typeFilter_comboBox;
    }
}
