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
            WordList.SuspendLayout();
            SuspendLayout();
            // 
            // WordList
            // 
            WordList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            WordList.Controls.Add(tabPage1);
            WordList.Controls.Add(tabPage2);
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
            // 
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 648);
            Controls.Add(WordList);
            Name = "MainForm";
            Text = "Main";
            WordList.ResumeLayout(false);
        }

        #endregion

        private TabControl WordList;
        private TabPage tabPage1;
        private TabPage tabPage2;
    }
}