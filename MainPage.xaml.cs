namespace Module2LabC
{
    public partial class MainPage : ContentPage
    {

        private string dotsNDashes;
        private string message;
        public MainPage()
        {
            InitializeComponent();
            dotsNDashes = "";
            message = "";
        }
        private void Dash_Clicked(object sender, EventArgs e)
        {
            dotsNDashes += "-";
            DotsAndDashes.Text = dotsNDashes;
        }
        private void Dot_Clicked(object sender, EventArgs e)
        {
            dotsNDashes += ".";
            DotsAndDashes.Text = dotsNDashes;
        }
        private void Space_Clicked(object sender, EventArgs e)
        {
            char letter = Morse.MorseCoder(dotsNDashes);
            message += letter;
            Letters.Text = message;
            dotsNDashes = "";

        }
        private void Clear_Clicked(object sender, EventArgs e)
        {
            message = "";
            dotsNDashes = "";
            DotsAndDashes.Text = dotsNDashes;
            Letters.Text = message;
        }


    }

}
