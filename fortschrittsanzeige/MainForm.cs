using System.Reflection.Metadata.Ecma335;
using System.Windows.Forms;

namespace fortschrittsanzeige
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            foreach (TextBox textBox in Controls.OfType<TextBox>()) 
            {
                textBox.TextChanged += onAnyTextChanged;
                onAnyTextChanged(textBox, EventArgs.Empty); // Initialize
            }
            ActiveControl = Fortschrittsanzeige;
        }

        const int TEXTBOX_COUNT = 6;
        private void onAnyTextChanged(object? sender, EventArgs e)
        {
            if(sender is TextBox textbox)
            {
                bool isValid;
                if(textbox.PlaceholderText == "PLZ")
                {
                    isValid = textbox.TextLength > 3;
                }
                else
                {
                    isValid = !string.IsNullOrWhiteSpace(textbox.Text);
                }
                textbox.BackColor = isValid ? Color.White : Color.LightSalmon;
            }

            // Use System.Linq to count the number of valid
            // textboxes based on the BackColor set;
            float countValid = Controls.OfType<TextBox>().Count(_=>_.BackColor== Color.White);

            var pct = countValid / TEXTBOX_COUNT;
            Fortschrittsanzeige.Value = (int)(pct * Fortschrittsanzeige.Maximum);
            Sendebutton.Enabled = countValid.Equals(TEXTBOX_COUNT);
            Fortschrittsanzeige.Visible = !Sendebutton.Enabled;        
        }
    }
}