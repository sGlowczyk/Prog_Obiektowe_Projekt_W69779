namespace proj
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
            Delete = new Button();
            Search = new Button();
            MediaList = new ListBox();
            ComboBox = new ComboBox();
            tytuł = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            Add = new Button();
            TitleInput = new TextBox();
            AuthorInput = new TextBox();
            YearInput = new TextBox();
            SearchInput = new TextBox();
            label1 = new Label();
            button1 = new Button();
            Edit1 = new Button();
            SuspendLayout();
            // 
            // Delete
            // 
            Delete.Location = new Point(52, 108);
            Delete.Name = "Delete";
            Delete.Size = new Size(94, 46);
            Delete.TabIndex = 1;
            Delete.Text = "Delete";
            Delete.UseVisualStyleBackColor = true;
            Delete.Click += Delete_Click;
            // 
            // Search
            // 
            Search.Location = new Point(52, 372);
            Search.Name = "Search";
            Search.Size = new Size(94, 29);
            Search.TabIndex = 2;
            Search.Text = "Search";
            Search.UseVisualStyleBackColor = true;
            Search.Click += Search_Click;
            // 
            // MediaList
            // 
            MediaList.FormattingEnabled = true;
            MediaList.Location = new Point(390, 59);
            MediaList.Name = "MediaList";
            MediaList.Size = new Size(291, 204);
            MediaList.TabIndex = 3;
            MediaList.SelectedIndexChanged += MediaList_SelectedIndexChanged;
            // 
            // ComboBox
            // 
            ComboBox.FormattingEnabled = true;
            ComboBox.Location = new Point(174, 278);
            ComboBox.Name = "ComboBox";
            ComboBox.Size = new Size(125, 28);
            ComboBox.TabIndex = 8;
            ComboBox.SelectedIndexChanged += ComboBox_SelectedIndexChanged;
            // 
            // tytuł
            // 
            tytuł.AutoSize = true;
            tytuł.Location = new Point(174, 36);
            tytuł.Name = "tytuł";
            tytuł.Size = new Size(38, 20);
            tytuł.TabIndex = 9;
            tytuł.Text = "Title";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(174, 98);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 10;
            label2.Text = "Author";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(174, 246);
            label3.Name = "label3";
            label3.Size = new Size(40, 20);
            label3.TabIndex = 11;
            label3.Text = "Type";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(174, 169);
            label4.Name = "label4";
            label4.Size = new Size(37, 20);
            label4.TabIndex = 12;
            label4.Text = "Year";
            // 
            // Add
            // 
            Add.Location = new Point(52, 59);
            Add.Name = "Add";
            Add.Size = new Size(94, 46);
            Add.TabIndex = 13;
            Add.Text = "Add";
            Add.UseVisualStyleBackColor = true;
            Add.Click += Add_Click;
            // 
            // TitleInput
            // 
            TitleInput.Location = new Point(174, 59);
            TitleInput.Name = "TitleInput";
            TitleInput.Size = new Size(125, 27);
            TitleInput.TabIndex = 16;
            TitleInput.TextChanged += TitleInput_TextChanged;
            // 
            // AuthorInput
            // 
            AuthorInput.Location = new Point(174, 127);
            AuthorInput.Name = "AuthorInput";
            AuthorInput.Size = new Size(125, 27);
            AuthorInput.TabIndex = 17;
            AuthorInput.TextChanged += AuthorInput_TextChanged;
            // 
            // YearInput
            // 
            YearInput.Location = new Point(174, 207);
            YearInput.Name = "YearInput";
            YearInput.Size = new Size(125, 27);
            YearInput.TabIndex = 18;
            YearInput.TextChanged += YearInput_TextChanged;
            // 
            // SearchInput
            // 
            SearchInput.Location = new Point(174, 374);
            SearchInput.Name = "SearchInput";
            SearchInput.Size = new Size(125, 27);
            SearchInput.TabIndex = 19;
            SearchInput.TextChanged += SearchInput_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(176, 343);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 20;
            label1.Text = "Search";
            // 
            // button1
            // 
            button1.Location = new Point(422, 375);
            button1.Name = "button1";
            button1.Size = new Size(8, 8);
            button1.TabIndex = 22;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // Edit1
            // 
            Edit1.Location = new Point(52, 197);
            Edit1.Name = "Edit1";
            Edit1.Size = new Size(94, 46);
            Edit1.TabIndex = 23;
            Edit1.Text = "Edit";
            Edit1.UseVisualStyleBackColor = true;
            Edit1.Click += Edit1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Edit1);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(SearchInput);
            Controls.Add(YearInput);
            Controls.Add(AuthorInput);
            Controls.Add(TitleInput);
            Controls.Add(Add);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(tytuł);
            Controls.Add(ComboBox);
            Controls.Add(MediaList);
            Controls.Add(Search);
            Controls.Add(Delete);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button Delete;
        private Button Search;
        private ListBox MediaList;
        private ComboBox ComboBox;
        private Label tytuł;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button Add;
        private TextBox TypeInput;
        private TextBox TitleInput;
        private TextBox AuthorInput;
        private TextBox YearInput;
        private TextBox SearchInput;
        private Label label1;
        private Button button1;
        private Button Edit;
        private Button Edit1;
    }
}
