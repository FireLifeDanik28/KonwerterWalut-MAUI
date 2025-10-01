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
                            ValueOut = i * USD;
                            return;
                        case "EUR":
                            ValueOut = i * EUR;
                            return;
                        case "RBX":
                            ValueOut = i * RBX;
                            return;
                        case "UAH":
                            ValueOut = i * UAH;
                            return;
                    }
                OutEntry.Text = $"{ValueOut}";
            }
            else
            {
                // parse failed. 
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
