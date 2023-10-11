namespace NotePad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_R_Click(object sender, EventArgs e)
        {
            note_richTextBox.SelectionAlignment = HorizontalAlignment.Right;
        }


        private void note_richTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            foreach (var family in FontFamily.Families)
            {
                font_box.Items.Add(family.Name);
            }

            for (int i = 4; i < 72; i += 4)
            {
                size_box.Items.Add(i);
            }



        }

        private void btn_default_white_Click(object sender, EventArgs e)
        {
            note_richTextBox.ForeColor = Color.White;
        }

        private void btn_black_default_Click(object sender, EventArgs e)
        {
            note_richTextBox.ForeColor = Color.Black;
        }

        private void btn_colorplate_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            DialogResult dResult = cd.ShowDialog();

            if (dResult == DialogResult.OK)
            {
                note_richTextBox.ForeColor = cd.Color;
                btn_colorplate.BackColor = cd.Color;
            }

        }

        private void btn_bold_Click(object sender, EventArgs e)
        {
            if (note_richTextBox.SelectionFont.Bold)
                note_richTextBox.SelectionFont = new Font(note_richTextBox.SelectionFont, FontStyle.Regular);
            else
                note_richTextBox.SelectionFont = new Font(note_richTextBox.SelectionFont, FontStyle.Bold);
        }

        private void btn_underline_Click(object sender, EventArgs e)
        {
            if (note_richTextBox.SelectionFont.Underline)
                note_richTextBox.SelectionFont = new Font(note_richTextBox.SelectionFont, FontStyle.Regular);
            else
                note_richTextBox.SelectionFont = new Font(note_richTextBox.SelectionFont, FontStyle.Underline);
        }

        private void btn_italic_Click(object sender, EventArgs e)
        {
            if (note_richTextBox.SelectionFont.Italic)
                note_richTextBox.SelectionFont = new Font(note_richTextBox.SelectionFont, FontStyle.Regular);
            else
                note_richTextBox.SelectionFont = new Font(note_richTextBox.SelectionFont, FontStyle.Italic);
        }

        private void font_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            note_richTextBox.SelectionFont = new Font(font_box.SelectedItem.ToString(), note_richTextBox.Font.Size);
        }

        private void size_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            float size = Convert.ToSingle(size_box.SelectedItem.ToString());
            note_richTextBox.SelectionFont = new Font(note_richTextBox.SelectionFont.FontFamily, size);

        }

        private void btn_left_Click(object sender, EventArgs e)
        {
            note_richTextBox.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            try
            {
                note_richTextBox.Text += File.ReadAllText(load_textbox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("File Not Found");
            }

        }


        private void loat_box_moveDown(object sender, MouseEventArgs e)
        {
            load_textbox.Text = "";
            load_textbox.ForeColor = Color.Black;
        }


        private void load_box_focus(object sender, EventArgs e)
        {
            if (load_textbox.Text == "")
            {
                load_textbox.Text = "Enter name and load file";
                load_textbox.ForeColor = Color.Gray;
            }

        }

        private void save_box_leave(object sender, EventArgs e)
        {
            if (save_textbox.Text == "")
            {
                save_textbox.Text = "Tap to enter name and save";
                save_textbox.ForeColor = Color.Silver;
            }
        }

        private void save_box_mouseDown(object sender, MouseEventArgs e)
        {

            save_textbox.Text = "";
            save_textbox.ForeColor = Color.Black;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (!File.Exists(save_textbox.Text))
            {
                File.Create(save_textbox.Text).Close();
            }
            File.WriteAllText(save_textbox.Text, note_richTextBox.Text);
        }

        private void btn_M_Click(object sender, EventArgs e)
        {
            note_richTextBox.SelectionAlignment = HorizontalAlignment.Center;
        }
    }
}