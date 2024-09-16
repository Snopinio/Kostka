namespace Kostka
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            //cos dodaje okok
            Random r = new Random();
            int diceRoll = 6;
            if (K4.IsChecked)
            {
                diceRoll = r.Next(1, 5);
            }
            if (K6.IsChecked)
            {
                diceRoll = r.Next(1, 7);
            }
            if (K10.IsChecked)
            {
                diceRoll = r.Next(1, 11);
            }
            if (K12.IsChecked)
            {
                diceRoll = r.Next(1, 13);
            }

            RollLabel.Text = "Wynik rzutu: " + diceRoll.ToString();
        }
    }

}
