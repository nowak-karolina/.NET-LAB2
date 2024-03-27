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
            type_comboBox = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            accessibility_textbox = new TextBox();
            participants_textBox = new TextBox();
            label3 = new Label();
            price_textBox = new TextBox();
            label4 = new Label();
            request_button = new Button();
            data_textBox = new TextBox();
            label5 = new Label();
            json_textBox = new TextBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // type_comboBox
            // 
            type_comboBox.FormattingEnabled = true;
            type_comboBox.Items.AddRange(new object[] { "education", "recreational", "social", "diy", "charity", "cooking", "relaxation", "music", "busywork" });
            type_comboBox.Location = new Point(98, 74);
            type_comboBox.Name = "type_comboBox";
            type_comboBox.Size = new Size(121, 23);
            type_comboBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 77);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 2;
            label1.Text = "Type";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 36);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 3;
            label2.Text = "Accessibility";
            // 
            // accessibility_textbox
            // 
            accessibility_textbox.Location = new Point(98, 33);
            accessibility_textbox.MaxLength = 3;
            accessibility_textbox.Name = "accessibility_textbox";
            accessibility_textbox.PlaceholderText = "0.0-1.0";
            accessibility_textbox.Size = new Size(121, 23);
            accessibility_textbox.TabIndex = 4;
            // 
            // participants_textBox
            // 
            participants_textBox.Location = new Point(98, 115);
            participants_textBox.Name = "participants_textBox";
            participants_textBox.PlaceholderText = "0-n";
            participants_textBox.Size = new Size(121, 23);
            participants_textBox.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 118);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 5;
            label3.Text = "Participants";
            // 
            // price_textBox
            // 
            price_textBox.Location = new Point(98, 156);
            price_textBox.Name = "price_textBox";
            price_textBox.PlaceholderText = "0-1";
            price_textBox.Size = new Size(121, 23);
            price_textBox.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(59, 159);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 7;
            label4.Text = "Price";
            // 
            // request_button
            // 
            request_button.Location = new Point(98, 214);
            request_button.Name = "request_button";
            request_button.Size = new Size(121, 41);
            request_button.TabIndex = 9;
            request_button.Text = "Send Request";
            request_button.UseVisualStyleBackColor = true;
            request_button.Click += getData;
            // 
            // data_textBox
            // 
            data_textBox.Location = new Point(283, 31);
            data_textBox.Multiline = true;
            data_textBox.Name = "data_textBox";
            data_textBox.Size = new Size(204, 224);
            data_textBox.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(280, 13);
            label5.Name = "label5";
            label5.Size = new Size(80, 15);
            label5.TabIndex = 11;
            label5.Text = "Received data";
            // 
            // json_textBox
            // 
            json_textBox.Location = new Point(524, 31);
            json_textBox.Multiline = true;
            json_textBox.Name = "json_textBox";
            json_textBox.Size = new Size(228, 224);
            json_textBox.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(524, 13);
            label6.Name = "label6";
            label6.Size = new Size(95, 15);
            label6.TabIndex = 13;
            label6.Text = "Deserialized Json";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(783, 473);
            Controls.Add(label6);
            Controls.Add(json_textBox);
            Controls.Add(label5);
            Controls.Add(data_textBox);
            Controls.Add(request_button);
            Controls.Add(price_textBox);
            Controls.Add(label4);
            Controls.Add(participants_textBox);
            Controls.Add(label3);
            Controls.Add(accessibility_textbox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(type_comboBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox type_comboBox;
        private Label label1;
        private Label label2;
        private TextBox accessibility_textbox;
        private TextBox participants_textBox;
        private Label label3;
        private TextBox price_textBox;
        private Label label4;
        private Button request_button;
        private TextBox data_textBox;
        private Label label5;
        private TextBox json_textBox;
        private Label label6;
    }
}
