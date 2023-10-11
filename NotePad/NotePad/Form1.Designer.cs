namespace NotePad
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
            font_label = new Label();
            size_label = new Label();
            font_box = new ComboBox();
            size_box = new ComboBox();
            fontStyle_label = new Label();
            btn_bold = new Button();
            btn_underline = new Button();
            btn_italic = new Button();
            Alignment_label = new Label();
            btn_left = new Button();
            btn_M = new Button();
            btn_R = new Button();
            color_label = new Label();
            load_textbox = new TextBox();
            save_textbox = new TextBox();
            btn_load = new Button();
            btn_save = new Button();
            note_richTextBox = new RichTextBox();
            btn_colorplate = new Button();
            btn_black_default = new Button();
            btn_default_white = new Button();
            SuspendLayout();
            // 
            // font_label
            // 
            font_label.AutoSize = true;
            font_label.Font = new Font("Comic Sans MS", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            font_label.Location = new Point(69, 32);
            font_label.Name = "font_label";
            font_label.Size = new Size(47, 24);
            font_label.TabIndex = 0;
            font_label.Text = "Font";
            // 
            // size_label
            // 
            size_label.AutoSize = true;
            size_label.Font = new Font("Comic Sans MS", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            size_label.Location = new Point(205, 32);
            size_label.Name = "size_label";
            size_label.Size = new Size(46, 24);
            size_label.TabIndex = 1;
            size_label.Text = "Size";
            // 
            // font_box
            // 
            font_box.BackColor = Color.Gainsboro;
            font_box.FlatStyle = FlatStyle.System;
            font_box.FormattingEnabled = true;
            font_box.Location = new Point(12, 68);
            font_box.Name = "font_box";
            font_box.Size = new Size(160, 28);
            font_box.TabIndex = 22;
            font_box.SelectedIndexChanged += font_box_SelectedIndexChanged;
            // 
            // size_box
            // 
            size_box.BackColor = Color.Gainsboro;
            size_box.FlatStyle = FlatStyle.System;
            size_box.FormattingEnabled = true;
            size_box.Location = new Point(188, 68);
            size_box.Name = "size_box";
            size_box.Size = new Size(79, 28);
            size_box.TabIndex = 3;
            size_box.SelectedIndexChanged += size_box_SelectedIndexChanged;
            // 
            // fontStyle_label
            // 
            fontStyle_label.AutoSize = true;
            fontStyle_label.Font = new Font("Comic Sans MS", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            fontStyle_label.Location = new Point(303, 32);
            fontStyle_label.Name = "fontStyle_label";
            fontStyle_label.Size = new Size(96, 24);
            fontStyle_label.TabIndex = 4;
            fontStyle_label.Text = "Font Style";
            // 
            // btn_bold
            // 
            btn_bold.BackColor = Color.Gainsboro;
            btn_bold.FlatAppearance.BorderColor = Color.DarkGray;
            btn_bold.FlatStyle = FlatStyle.Flat;
            btn_bold.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btn_bold.Location = new Point(288, 68);
            btn_bold.Name = "btn_bold";
            btn_bold.Size = new Size(32, 31);
            btn_bold.TabIndex = 5;
            btn_bold.Text = "B";
            btn_bold.UseVisualStyleBackColor = false;
            btn_bold.Click += btn_bold_Click;
            // 
            // btn_underline
            // 
            btn_underline.BackColor = Color.Gainsboro;
            btn_underline.FlatAppearance.BorderColor = Color.DarkGray;
            btn_underline.FlatStyle = FlatStyle.Flat;
            btn_underline.Font = new Font("Segoe UI Semilight", 9F, FontStyle.Underline, GraphicsUnit.Point);
            btn_underline.Location = new Point(334, 68);
            btn_underline.Name = "btn_underline";
            btn_underline.Size = new Size(32, 31);
            btn_underline.TabIndex = 6;
            btn_underline.Text = "U";
            btn_underline.UseVisualStyleBackColor = false;
            btn_underline.Click += btn_underline_Click;
            // 
            // btn_italic
            // 
            btn_italic.BackColor = Color.Gainsboro;
            btn_italic.FlatAppearance.BorderColor = Color.DarkGray;
            btn_italic.FlatStyle = FlatStyle.Flat;
            btn_italic.Font = new Font("Segoe UI", 10.8F, FontStyle.Italic, GraphicsUnit.Point);
            btn_italic.Location = new Point(381, 68);
            btn_italic.Name = "btn_italic";
            btn_italic.Size = new Size(32, 31);
            btn_italic.TabIndex = 7;
            btn_italic.Text = "I";
            btn_italic.UseVisualStyleBackColor = false;
            btn_italic.Click += btn_italic_Click;
            // 
            // Alignment_label
            // 
            Alignment_label.AutoSize = true;
            Alignment_label.Font = new Font("Comic Sans MS", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            Alignment_label.Location = new Point(470, 32);
            Alignment_label.Name = "Alignment_label";
            Alignment_label.Size = new Size(92, 24);
            Alignment_label.TabIndex = 8;
            Alignment_label.Text = "Alignment";
            // 
            // btn_left
            // 
            btn_left.BackColor = Color.Gainsboro;
            btn_left.FlatAppearance.BorderColor = Color.DarkGray;
            btn_left.FlatStyle = FlatStyle.Flat;
            btn_left.Font = new Font("Segoe UI Emoji", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btn_left.Location = new Point(452, 68);
            btn_left.Name = "btn_left";
            btn_left.Size = new Size(32, 32);
            btn_left.TabIndex = 9;
            btn_left.Text = "L";
            btn_left.UseVisualStyleBackColor = false;
            btn_left.Click += btn_left_Click;
            // 
            // btn_M
            // 
            btn_M.BackColor = Color.Gainsboro;
            btn_M.FlatAppearance.BorderColor = Color.DarkGray;
            btn_M.FlatStyle = FlatStyle.Flat;
            btn_M.Font = new Font("Segoe UI Emoji", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btn_M.Location = new Point(501, 68);
            btn_M.Name = "btn_M";
            btn_M.Size = new Size(32, 32);
            btn_M.TabIndex = 10;
            btn_M.Text = "M";
            btn_M.UseVisualStyleBackColor = false;
            btn_M.Click += btn_M_Click;
            // 
            // btn_R
            // 
            btn_R.BackColor = Color.Gainsboro;
            btn_R.FlatAppearance.BorderColor = Color.DarkGray;
            btn_R.FlatStyle = FlatStyle.Flat;
            btn_R.Font = new Font("Segoe UI Emoji", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btn_R.Location = new Point(550, 68);
            btn_R.Name = "btn_R";
            btn_R.Size = new Size(32, 32);
            btn_R.TabIndex = 11;
            btn_R.Text = "R";
            btn_R.UseVisualStyleBackColor = false;
            btn_R.Click += btn_R_Click;
            // 
            // color_label
            // 
            color_label.AutoSize = true;
            color_label.Font = new Font("Comic Sans MS", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            color_label.Location = new Point(671, 32);
            color_label.Name = "color_label";
            color_label.Size = new Size(53, 24);
            color_label.TabIndex = 13;
            color_label.Text = "Color";
            // 
            // load_textbox
            // 
            load_textbox.BorderStyle = BorderStyle.FixedSingle;
            load_textbox.ForeColor = Color.Gray;
            load_textbox.Location = new Point(817, 33);
            load_textbox.Name = "load_textbox";
            load_textbox.Size = new Size(289, 27);
            load_textbox.TabIndex = 14;
            load_textbox.Text = "Enter name and load file";
            load_textbox.Leave += load_box_focus;
            load_textbox.MouseDown += loat_box_moveDown;
            // 
            // save_textbox
            // 
            save_textbox.BorderStyle = BorderStyle.FixedSingle;
            save_textbox.ForeColor = Color.Silver;
            save_textbox.Location = new Point(817, 75);
            save_textbox.Name = "save_textbox";
            save_textbox.Size = new Size(289, 27);
            save_textbox.TabIndex = 15;
            save_textbox.Text = "Tap to enter name and save";
            save_textbox.Leave += save_box_leave;
            save_textbox.MouseDown += save_box_mouseDown;
            // 
            // btn_load
            // 
            btn_load.BackColor = Color.Gainsboro;
            btn_load.FlatAppearance.BorderColor = Color.DarkGray;
            btn_load.FlatStyle = FlatStyle.Flat;
            btn_load.Location = new Point(1112, 28);
            btn_load.Name = "btn_load";
            btn_load.Size = new Size(118, 32);
            btn_load.TabIndex = 16;
            btn_load.Text = "Load";
            btn_load.UseVisualStyleBackColor = false;
            btn_load.Click += btn_load_Click;
            // 
            // btn_save
            // 
            btn_save.BackColor = Color.Gainsboro;
            btn_save.FlatAppearance.BorderColor = Color.DarkGray;
            btn_save.FlatStyle = FlatStyle.Flat;
            btn_save.Location = new Point(1112, 71);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(118, 32);
            btn_save.TabIndex = 17;
            btn_save.Text = "Save";
            btn_save.UseVisualStyleBackColor = false;
            btn_save.Click += btn_save_Click;
            // 
            // note_richTextBox
            // 
            note_richTextBox.Location = new Point(2, 113);
            note_richTextBox.Name = "note_richTextBox";
            note_richTextBox.Size = new Size(1228, 414);
            note_richTextBox.TabIndex = 18;
            note_richTextBox.Text = "";
            note_richTextBox.TextChanged += note_richTextBox_TextChanged;
            // 
            // btn_colorplate
            // 
            btn_colorplate.BackColor = Color.Transparent;
            btn_colorplate.FlatAppearance.BorderColor = Color.Gainsboro;
            btn_colorplate.FlatAppearance.BorderSize = 5;
            btn_colorplate.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn_colorplate.FlatStyle = FlatStyle.Flat;
            btn_colorplate.Location = new Point(628, 68);
            btn_colorplate.Name = "btn_colorplate";
            btn_colorplate.Size = new Size(45, 32);
            btn_colorplate.TabIndex = 19;
            btn_colorplate.UseVisualStyleBackColor = false;
            btn_colorplate.Click += btn_colorplate_Click;
            // 
            // btn_black_default
            // 
            btn_black_default.BackColor = Color.Black;
            btn_black_default.BackgroundImageLayout = ImageLayout.Center;
            btn_black_default.FlatAppearance.BorderColor = Color.Gainsboro;
            btn_black_default.FlatAppearance.BorderSize = 5;
            btn_black_default.FlatStyle = FlatStyle.Flat;
            btn_black_default.Location = new Point(679, 69);
            btn_black_default.Name = "btn_black_default";
            btn_black_default.Size = new Size(45, 32);
            btn_black_default.TabIndex = 20;
            btn_black_default.UseVisualStyleBackColor = false;
            btn_black_default.Click += btn_black_default_Click;
            // 
            // btn_default_white
            // 
            btn_default_white.BackColor = Color.White;
            btn_default_white.FlatAppearance.BorderColor = Color.Gainsboro;
            btn_default_white.FlatAppearance.BorderSize = 5;
            btn_default_white.FlatStyle = FlatStyle.Flat;
            btn_default_white.Location = new Point(730, 69);
            btn_default_white.Name = "btn_default_white";
            btn_default_white.Size = new Size(45, 32);
            btn_default_white.TabIndex = 21;
            btn_default_white.UseVisualStyleBackColor = false;
            btn_default_white.Click += btn_default_white_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1237, 530);
            Controls.Add(btn_default_white);
            Controls.Add(btn_black_default);
            Controls.Add(btn_colorplate);
            Controls.Add(note_richTextBox);
            Controls.Add(btn_save);
            Controls.Add(btn_load);
            Controls.Add(save_textbox);
            Controls.Add(load_textbox);
            Controls.Add(color_label);
            Controls.Add(btn_R);
            Controls.Add(btn_M);
            Controls.Add(btn_left);
            Controls.Add(Alignment_label);
            Controls.Add(btn_italic);
            Controls.Add(btn_underline);
            Controls.Add(btn_bold);
            Controls.Add(fontStyle_label);
            Controls.Add(size_box);
            Controls.Add(font_box);
            Controls.Add(size_label);
            Controls.Add(font_label);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label font_label;
        private Label size_label;
        private ComboBox font_box;
        private ComboBox size_box;
        private Label fontStyle_label;
        private Button btn_bold;
        private Button btn_underline;
        private Button btn_italic;
        private Label Alignment_label;
        private Button btn_left;
        private Button btn_M;
        private Button btn_R;
        private Label color_label;
        private TextBox load_textbox;
        private TextBox save_textbox;
        private Button btn_load;
        private Button btn_save;
        private RichTextBox note_richTextBox;
        private Button btn_colorplate;
        private Button btn_black_default;
        private Button btn_default_white;
    }
}