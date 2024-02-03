using System;
using System.Windows;
using System.Windows.Controls;

namespace WpfApp3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Button[] buttons;
        private int chetGame = 1;
        string user = "X";
        string firstPlayer = "X";
        public bool buttonsEnabled = false;

        public MainWindow()
        {
            InitializeComponent();
            buttons = new Button[9] { _1, _2, _3, _4, _5, _6, _7, _8, _9 };

            foreach (Button button in buttons)
            {
                button.IsEnabled = false;
            }


        }

        private void _1_Click(object sender, RoutedEventArgs? e)
        {

            (sender as Button).Content = user;
            (sender as Button).IsEnabled = false;

            checkWin();

            Random random = new Random();
            int knopka = random.Next(1, 9);

            while (buttons[knopka].IsEnabled == false || buttons[knopka].Content != "")
                knopka = random.Next(1, 9);
            buttons[knopka].Content = user == "X" ? "O" : "X"; ;
            buttons[knopka].IsEnabled = false;
            checkWin();


        }

        private void Start_Click(object sender, RoutedEventArgs e)
        {
            buttonsEnabled = true;
            foreach (Button button in buttons)
            {
                button.IsEnabled = true;
            }
            chetGame++;
            if (chetGame % 2 == 0)
            {
                firstPlayer = "O";
            }
            else
            {
                firstPlayer = "X";
            }

            
            if (firstPlayer == "X")
            {
                Random random = new Random();
                int knopka = random.Next(1, 9);

                while (buttons[knopka].IsEnabled == false || buttons[knopka].Content != "")
                {
                    knopka = random.Next(1, 9);
                }
                buttons[knopka].Content = firstPlayer;
                buttons[knopka].IsEnabled = false;
            }
            zanavo.IsEnabled = true;
        }

        private void zanavo_Click(object sender, RoutedEventArgs e)
        {
            buttonsEnabled = false;
            user = user == "X" ? "O" : "X";


            foreach (Button button in buttons)
            {
                button.Content = "";
                button.IsEnabled = true;
            }
            zanavo.IsEnabled = false;

        }

        private void checkWin()
        {
            int filled = 0;
            bool win = false;

            if (_1.Content == _2.Content && _2.Content == _3.Content && _1.Content != "")
            {
                MessageBox.Show("Победили " + _1.Content);
                foreach (Button button in buttons)
                {
                    button.IsEnabled = false;
                    win = true;
                }
            }
            else if (_4.Content == _5.Content && _5.Content == _6.Content && _4.Content != "")
            {
                MessageBox.Show("Победили " + _4.Content);
                foreach (Button button in buttons)
                {
                    button.IsEnabled = false;
                    win = true;
                }
            }
            else if (_7.Content == _8.Content && _8.Content == _9.Content && _7.Content != "")
            {
                MessageBox.Show("Победили " + _7.Content);
                foreach (Button button in buttons)
                {
                    button.IsEnabled = false;
                    win = true;
                }
            }
            else if (_1.Content == _4.Content && _4.Content == _7.Content && _1.Content != "")
            {
                MessageBox.Show("Победили " + _1.Content);
                foreach (Button button in buttons)
                {
                    button.IsEnabled = false;
                    win = true;
                }
            }
            else if (_2.Content == _5.Content && _5.Content == _8.Content && _2.Content != "")
            {
                MessageBox.Show("Победили " + _2.Content);
                foreach (Button button in buttons)
                {
                    button.IsEnabled = false;
                    win = true;
                }
            }
            else if (_3.Content == _6.Content && _6.Content == _9.Content && _3.Content != "")
            {
                MessageBox.Show("Победили " + _3.Content);
                foreach (Button button in buttons)
                {
                    button.IsEnabled = false;
                    win = true;
                }
            }
            else if (_1.Content == _5.Content && _5.Content == _9.Content && _1.Content != "")
            {
                MessageBox.Show("Победили " + _1.Content);
                foreach (Button button in buttons)
                {
                    button.IsEnabled = false;
                    win = true;
                }
            }
            else if (_3.Content == _5.Content && _5.Content == _7.Content && _3.Content != "")
            {
                MessageBox.Show("Победили " + _3.Content);
                foreach (Button button in buttons)
                {
                    button.IsEnabled = false;
                    win = true;
                }
            }

            if (!win)
                foreach (Button button in buttons)
                {
                    if (button.IsEnabled == false)
                    {
                        filled++;
                    }
                }

            if (filled == 9)
            {
                MessageBox.Show("Ничья");

            }

        }
    }
}
