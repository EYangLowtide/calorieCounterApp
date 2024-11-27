
using System;

namespace calorieCounterAppi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            dateTextBox = new TextBox();
            foodItemTextBox = new TextBox();
            caloriesTextBox = new TextBox();
            checkBox1 = new CheckBox();
            addButton = new Button();
            newEntryButton = new Button();
            saveButton = new Button();
            deleteButton = new Button();
            foodItemsListBox = new ListBox();
            entriesListBox = new ListBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            calendarPanel = new TableLayoutPanel();
            dateTimePicker1 = new DateTimePicker();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dateTextBox
            // 
            dateTextBox.Location = new Point(99, 13);
            dateTextBox.Name = "dateTextBox";
            dateTextBox.Size = new Size(265, 27);
            dateTextBox.TabIndex = 0;
            dateTextBox.TextChanged += textBox1_TextChanged;
            // 
            // foodItemTextBox
            // 
            foodItemTextBox.Location = new Point(99, 47);
            foodItemTextBox.Name = "foodItemTextBox";
            foodItemTextBox.Size = new Size(265, 27);
            foodItemTextBox.TabIndex = 1;
            foodItemTextBox.TextChanged += textBox2_TextChanged;
            // 
            // caloriesTextBox
            // 
            caloriesTextBox.Location = new Point(99, 82);
            caloriesTextBox.Name = "caloriesTextBox";
            caloriesTextBox.Size = new Size(265, 27);
            caloriesTextBox.TabIndex = 2;
            caloriesTextBox.TextChanged += textBox3_TextChanged;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(370, 13);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(106, 24);
            checkBox1.TabIndex = 3;
            checkBox1.Text = "Cheat Day?";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // addButton
            // 
            addButton.Location = new Point(12, 115);
            addButton.Name = "addButton";
            addButton.Size = new Size(130, 40);
            addButton.TabIndex = 4;
            addButton.Text = "[Add Food Item]";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += button1_Click;
            // 
            // newEntryButton
            // 
            newEntryButton.Location = new Point(14, 256);
            newEntryButton.Name = "newEntryButton";
            newEntryButton.Size = new Size(94, 40);
            newEntryButton.TabIndex = 5;
            newEntryButton.Text = "[New Entry]";
            newEntryButton.UseVisualStyleBackColor = true;
            newEntryButton.Click += button2_Click;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(114, 256);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(100, 40);
            saveButton.TabIndex = 6;
            saveButton.Text = "[Save Day]";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += button3_Click;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(220, 256);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(125, 40);
            deleteButton.TabIndex = 7;
            deleteButton.Text = "[Delete Entry]";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += button4_Click;
            // 
            // foodItemsListBox
            // 
            foodItemsListBox.FormattingEnabled = true;
            foodItemsListBox.Location = new Point(12, 206);
            foodItemsListBox.Name = "foodItemsListBox";
            foodItemsListBox.Size = new Size(592, 44);
            foodItemsListBox.TabIndex = 8;
            foodItemsListBox.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // entriesListBox
            // 
            entriesListBox.FormattingEnabled = true;
            entriesListBox.Location = new Point(14, 322);
            entriesListBox.Name = "entriesListBox";
            entriesListBox.Size = new Size(592, 44);
            entriesListBox.TabIndex = 9;
            entriesListBox.SelectedIndexChanged += listBox2_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 13);
            label1.Name = "label1";
            label1.Size = new Size(48, 20);
            label1.TabIndex = 10;
            label1.Text = "Date: ";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 47);
            label2.Name = "label2";
            label2.Size = new Size(84, 20);
            label2.TabIndex = 11;
            label2.Text = "Food Item: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 82);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 12;
            label3.Text = "Calories: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 183);
            label4.Name = "label4";
            label4.Size = new Size(150, 20);
            label4.TabIndex = 13;
            label4.Text = "Food Items for Today";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 299);
            label5.Name = "label5";
            label5.Size = new Size(100, 20);
            label5.TabIndex = 14;
            label5.Text = "Saved Entries:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 380);
            label6.Name = "label6";
            label6.Size = new Size(190, 20);
            label6.TabIndex = 15;
            label6.Text = "Week Overview (Sun - Sat): ";
            label6.Click += label6_Click;
            // 
            // calendarPanel
            // 
            calendarPanel.ColumnCount = 7;
            calendarPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            calendarPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            calendarPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            calendarPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            calendarPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            calendarPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            calendarPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            calendarPanel.Location = new Point(12, 414);
            calendarPanel.Name = "calendarPanel";
            calendarPanel.RowCount = 1;
            calendarPanel.RowStyles.Add(new RowStyle());
            calendarPanel.Size = new Size(1005, 152);
            calendarPanel.TabIndex = 16;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(757, 13);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(260, 27);
            dateTimePicker1.TabIndex = 17;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(633, 66);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(380, 315);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 597);
            Controls.Add(pictureBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(calendarPanel);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(entriesListBox);
            Controls.Add(foodItemsListBox);
            Controls.Add(deleteButton);
            Controls.Add(saveButton);
            Controls.Add(newEntryButton);
            Controls.Add(addButton);
            Controls.Add(checkBox1);
            Controls.Add(caloriesTextBox);
            Controls.Add(foodItemTextBox);
            Controls.Add(dateTextBox);
            Name = "Form1";
            Text = "Calorie Counter";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private TextBox dateTextBox;
        private TextBox foodItemTextBox;
        private TextBox caloriesTextBox;
        private CheckBox checkBox1;
        private Button addButton;
        private Button newEntryButton;
        private Button saveButton;
        private Button deleteButton;
        private ListBox foodItemsListBox;
        private ListBox entriesListBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TableLayoutPanel calendarPanel;
        private DateTimePicker dateTimePicker1;
        private PictureBox pictureBox1;
    }
}
