using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MyForm : Form
    {
        public string newName;

        public MyForm()
        {
            InitializeComponent();
            buttonADDNAME.Enabled = false;
            AddedNamesLabel.Text = "";       
        }

        private void cb1_SelectedIndexChanged(object sender, EventArgs e)
        {
            tb.Clear();

            if (cb1.Text == "Suggest")
            {
                tb.AutoCompleteMode = AutoCompleteMode.Suggest;
                panel2.BackColor = Color.FromArgb(186, 225, 255);
                tbdesc.BackColor = Color.FromArgb(186, 225, 255);
                tbdesc.Text = "Suggest - Displays the auxiliary drop-down list associated with the edit control. This drop-down is populated with one or more suggested completion strings.";
            }
            else if (cb1.Text == "Append")
            {
                tb.AutoCompleteMode = AutoCompleteMode.Append;
                panel2.BackColor = Color.FromArgb(255, 223, 186);
                tbdesc.BackColor = Color.FromArgb(255, 223, 186);
                tbdesc.Text = "Append - Appends the remainder of the most likely candidate string to the existing characters, highlighting the appended characters.";
            }
            else if (cb1.Text == "SuggestAppend")
            {
                tb.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                panel2.BackColor = Color.FromArgb(255, 179, 186);
                tbdesc.BackColor = Color.FromArgb(255, 179, 186);
                tbdesc.Text = "SuggestAppend - Appends both Suggest and Append options.";
            }
            else 
            {
                tb.AutoCompleteMode = AutoCompleteMode.None;
                panel2.BackColor = Color.FromArgb(186, 255, 201);
                tbdesc.BackColor = Color.FromArgb(186, 255, 201);
                tbdesc.Text = "None - Disables automatic completion.This is the default";
            }
        }

        private void tbNEW_TextChanged(object sender, EventArgs e)
        {
            char[] c = tbNEW.Text.ToCharArray();

            foreach (char i in c)
            {
                if (char.IsDigit(i))
                {
                    tbNEW.Clear();
                }
            }

            if (tbNEW.Text.Length > 1)
            {
                buttonADDNAME.Enabled = true;
                buttonADDNAME.Font = new Font(buttonADDNAME.Font, FontStyle.Regular);
            }
            else
            {
                buttonADDNAME.Enabled = false;
                buttonADDNAME.Font = new Font(buttonADDNAME.Font, FontStyle.Strikeout);
            }
        }

        private void buttonADDNAME_Click(object sender, EventArgs e)
        {
            newName = tbNEW.Text;

            if (newName.Length > 8)
            {
                newName = newName.Substring(0, 8) + "...";
            }

            AddedNamesLabel.Text = $"Added \"{newName.ToUpper()}\" to custom source data!";
            tb.AutoCompleteCustomSource.Add(newName);
            toolTip1.SetToolTip(AddedNamesLabel, "Top Secret :-)");
            tbNEW.Clear();
        }

        private void AddedNamesLabel_Click(object sender, EventArgs e)
        {
            AddedNamesLabel.Text = "";
        }

        private void tb_TextChanged(object sender, EventArgs e)
        {
            if (tb.Text == "Mike" || tb.Text == "mike")
            {
                MessageBox.Show("Hey Mike!");
                tb.Clear();
            }
            else if (tb.Text == "Brad" || tb.Text == "brad")
            {
                MessageBox.Show("Hey Brad!");
                tb.Clear();
            }
        }
    }
}
