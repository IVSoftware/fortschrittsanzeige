Here are a few tips to get you started with WinForms and make it easier to **connect multiple TextBoxes with a ProgressBar**. 

***
- The textboxes (and other controls) that are on a `Form` can be found in the `Controls` collection of the form.
- All of the textboxes on the form can be obtained with a simple query.

For example, in the form Constructor you could go though all the textboxes and attach a `TextChanged` handler to each.

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

***
- Multiple text boxes can all point to a common event handler.
- `System.Linq` reduces the amount of code needed for things like matching and sorting. 

What we're able to do is perform a validation based on _all_ the textboxes whenever _any_ textbox changes. 

[![progress][1]][1]

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

        // Use System.Linq to count the number of valid textboxes (based on BackColor).
        float countValid = 
            Controls
            .OfType<TextBox>()
            .Count(_=>_.BackColor== Color.White);

        var pct = countValid / TEXTBOX_COUNT;
        Fortschrittsanzeige.Value = (int)(pct * Fortschrittsanzeige.Maximum);
        Sendebutton.Enabled = countValid.Equals(TEXTBOX_COUNT);
        Fortschrittsanzeige.Visible = !Sendebutton.Enabled;        
    }

***
The handler allows for "special cases" and will make the `Fortschrittsanzeige` go backwards if the changed value is no longer valid.

[![retrograde][2]][2]

***
When all textboxes are valid hide `Fortschrittsanzeige` and enable `Sendebutton`.

[![komplett][3]][3]


  [1]: https://i.stack.imgur.com/Yoym5.png
  [2]: https://i.stack.imgur.com/6W61r.png
  [3]: https://i.stack.imgur.com/fNTeI.png