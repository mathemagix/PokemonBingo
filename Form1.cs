namespace PokemonBingo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Squares.GymBattles = Randomize(Squares.GymBattles);
            Squares.Evolutions = Randomize(Squares.Evolutions);
            Squares.BasicCatches = Randomize(Squares.BasicCatches);
            Squares.RareCatches = Randomize(Squares.RareCatches);
            Squares.Trainers = Randomize(Squares.Trainers);
            Squares.Handicaps = Randomize(Squares.Handicaps);
            Squares.Rivals = Randomize(Squares.Rivals);
            Squares.Other = Randomize(Squares.Other);

            List<string> squares = new List<string>();
            squares.Add(Squares.BasicCatches[0]);
            squares.Add(Squares.BasicCatches[1]);
            squares.Add(Squares.BasicCatches[2]);
            squares.Add(Squares.BasicCatches[3]);
            squares.Add(Squares.BasicCatches[4]);

            squares.Add(Squares.RareCatches[0]);
            squares.Add(Squares.RareCatches[1]);
            squares.Add(Squares.RareCatches[2]);

            squares.Add(Squares.Handicaps[0]);
            squares.Add(Squares.Handicaps[1]);
            squares.Add(Squares.Handicaps[2]);

            squares.Add(Squares.Rivals[0]);
            squares.Add(Squares.Rivals[1]);

            squares.Add(Squares.GymBattles[0]);
            squares.Add(Squares.GymBattles[1]);

            squares.Add(Squares.Evolutions[0]);
            squares.Add(Squares.Evolutions[1]);
            squares.Add(Squares.Evolutions[2]);

            squares.Add(Squares.Trainers[0]);
            squares.Add(Squares.Trainers[1]);
            squares.Add(Squares.Trainers[2]);

            squares.Add(Squares.Other[0]);
            squares.Add(Squares.Other[1]);
            squares.Add(Squares.Other[2]);
            squares.Add(Squares.Other[3]);

            squares = Randomize(squares);
            squares = Randomize(squares);
            squares = Randomize(squares);
            squares = Randomize(squares);
            squares = Randomize(squares);

            button1.Text = squares[0];
            button2.Text = squares[1];
            button3.Text = squares[2];
            button4.Text = squares[3];
            button5.Text = squares[4];
            button6.Text = squares[5];
            button7.Text = squares[6];
            button8.Text = squares[7];
            button9.Text = squares[8];
            button10.Text = squares[9];
            button11.Text = squares[10];
            button12.Text = squares[11];
            button13.Text = squares[12];
            button14.Text = squares[13];
            button15.Text = squares[14];
            button16.Text = squares[15];
            button17.Text = squares[16];
            button18.Text = squares[17];
            button19.Text = squares[18];
            button20.Text = squares[19];
            button21.Text = squares[20];
            button22.Text = squares[21];
            button23.Text = squares[22];
            button24.Text = squares[23];
            button25.Text = squares[24];
        }

        private static readonly Random RandomGenerator = new Random();

        public static List<string> Randomize(List<string> list)
        {
            for (int i = list.Count - 1; i > 0; i--)
            {
                int randomIndex = RandomGenerator.Next(i + 1);
                // Swap elements
                (list[i], list[randomIndex]) = (list[randomIndex], list[i]);
            }
            return list;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button.BackColor == Color.Blue) button.BackColor = Color.Red;
            else button.BackColor = Color.Blue;
        }
    }
}
