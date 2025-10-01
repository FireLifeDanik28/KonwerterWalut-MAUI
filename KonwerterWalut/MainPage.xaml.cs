namespace KonwerterWalut
{
    public partial class MainPage : ContentPage
    {
        double PLN = 0;
        double ValueOut = 0;

        string ChosenCur = "USD";
        
        
        
        double USD = 0.28;
        double EUR = 0.23;
        double RBX = 16.66;
        double UAH = 11.35;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnConvertClicked(object? sender, EventArgs e)
        {
            if (double.TryParse(c1.Text, out double b1))
            {
                // parse success. you can use i here
                if (double.TryParse(c2.Text, out double b2))
                {
                    // parse success. you can use i here
                    if (double.TryParse(c3.Text, out double b3))
                    {
                        // parse success. you can use i here
                        if (double.TryParse(c4.Text, out double b4))
                        {
                            // parse success. you can use i here


                            if (double.TryParse(PlnEntry.Text, out double i)) {
                // parse success. you can use i here
                PLN = i;
                if (i == 2137)
                {
                    BgColor.BackgroundColor = Colors.Yellow;
                }
                else
                {
                    // Reset to default color for other values
                    BgColor.BackgroundColor = Colors.Transparent; // or your default color
                }
                switch (ChosenCur)
                {
                    case "USD":
                        ValueOut = i * b1;
                        break; // Use 'break' instead of 'return'
                    case "EUR":
                        ValueOut = i * b2;
                        break;
                    case "RBX":
                        ValueOut = i * b3;
                        break;
                    case "UAH":
                        ValueOut = i * b4;
                        break;
                }
                OutEntry.Text = $"{ValueOut}";
                            }
                            else
                            {
                                // parse failed. 
                            }
                        }
                        else
                        {
                            // parse failed. 
                        }
                    }
                    else
                    {
                        // parse failed. 
                    }
                }
            else
            {
                // parse failed. 
            }
            }
            else
            {
                // parse failed
            }
            SemanticScreenReader.Announce(PlnEntry.Text);
            SemanticScreenReader.Announce(OutEntry.Text);
        }

        private void USDrad(object sender, CheckedChangedEventArgs e)
        {
            ChosenCur = "USD";
        }

        private void EURrad(object sender, CheckedChangedEventArgs e)
        {
            ChosenCur = "EUR";
        }

        private void RBXrad(object sender, CheckedChangedEventArgs e)
        {
            ChosenCur = "RBX";
        }
        private void UAHrad(object sender, CheckedChangedEventArgs e)
        {
            ChosenCur = "UAH";
        }
    }
}
