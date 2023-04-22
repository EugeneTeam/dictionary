namespace dictionary
{
    partial class MainForm
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
            WordList = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            ReloadList = new Button();
            groupBox1 = new GroupBox();
            ItemPerPageValue = new NumericUpDown();
            label1 = new Label();
            ItemsInList = new Label();
            button2 = new Button();
            SearchValue = new TextBox();
            button1 = new Button();
            WordsList = new ListBox();
            WordList.SuspendLayout();
            tabPage3.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ItemPerPageValue).BeginInit();
            SuspendLayout();
            // 
            // WordList
            // 
            WordList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            WordList.Controls.Add(tabPage1);
            WordList.Controls.Add(tabPage2);
            WordList.Controls.Add(tabPage3);
            WordList.Location = new Point(12, 12);
            WordList.Name = "WordList";
            WordList.SelectedIndex = 0;
            WordList.Size = new Size(776, 624);
            WordList.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(768, 596);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Words list";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(768, 596);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Learn";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(ReloadList);
            tabPage3.Controls.Add(groupBox1);
            tabPage3.Controls.Add(ItemsInList);
            tabPage3.Controls.Add(button2);
            tabPage3.Controls.Add(SearchValue);
            tabPage3.Controls.Add(button1);
            tabPage3.Controls.Add(WordsList);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(768, 596);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Word Management";
            tabPage3.UseVisualStyleBackColor = true;
            tabPage3.Enter += tabPage3_Enter;
            // 
            // ReloadList
            // 
            ReloadList.Location = new Point(233, 80);
            ReloadList.Name = "ReloadList";
            ReloadList.Size = new Size(200, 23);
            ReloadList.TabIndex = 7;
            ReloadList.Text = "Reload list";
            ReloadList.UseVisualStyleBackColor = true;
            ReloadList.Click += ReloadList_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(ItemPerPageValue);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(233, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 71);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Setting";
            // 
            // ItemPerPageValue
            // 
            ItemPerPageValue.Location = new Point(6, 25);
            ItemPerPageValue.Name = "ItemPerPageValue";
            ItemPerPageValue.Size = new Size(51, 23);
            ItemPerPageValue.TabIndex = 2;
            ItemPerPageValue.ValueChanged += ItemPerPageValue_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 29);
            label1.Name = "label1";
            label1.Size = new Size(80, 15);
            label1.TabIndex = 1;
            label1.Text = "Item per page";
            // 
            // ItemsInList
            // 
            ItemsInList.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            ItemsInList.AutoSize = true;
            ItemsInList.Location = new Point(97, 574);
            ItemsInList.Name = "ItemsInList";
            ItemsInList.Size = new Size(38, 15);
            ItemsInList.TabIndex = 5;
            ItemsInList.Text = "label1";
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button2.Location = new Point(152, 571);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 4;
            button2.Text = ">";
            button2.UseVisualStyleBackColor = true;
            // 
            // SearchValue
            // 
            SearchValue.Location = new Point(3, 3);
            SearchValue.Name = "SearchValue";
            SearchValue.Size = new Size(224, 23);
            SearchValue.TabIndex = 3;
            SearchValue.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button1.Location = new Point(3, 570);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "<";
            button1.UseVisualStyleBackColor = true;
            // 
            // WordsList
            // 
            WordsList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            WordsList.FormattingEnabled = true;
            WordsList.ItemHeight = 15;
            WordsList.Location = new Point(3, 32);
            WordsList.Name = "WordsList";
            WordsList.Size = new Size(224, 529);
            WordsList.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 648);
            Controls.Add(WordList);
            Name = "MainForm";
            Text = "Main";
            Load += MainForm_Load;
            WordList.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ItemPerPageValue).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl WordList;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private ListBox WordsList;
        private Button button2;
        private TextBox SearchValue;
        private Button button1;
        private Label ItemsInList;
        private GroupBox groupBox1;
        private NumericUpDown ItemPerPageValue;
        private Label label1;
        private Button ReloadList;
    }
}