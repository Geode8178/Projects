using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace MatchGame
{
    using System.Windows.Threading;
    
    public partial class MainWindow : Window
    {
        DispatcherTimer timer = new DispatcherTimer();
        int tenthsSecElapsed;
        int matchesFound;

        private void setUpGame()
        {
            List<string> animalEmoji = new List<string>() // Creates a list with 10 pairs of animal emojis.
            {
                "🐶","🐶",
                "🐧","🐧",
                "🦝","🦝",
                "🐷","🐷",
                "🦁","🦁",
                "🐯","🐯",
                "🐼","🐼",
                "🦊","🦊",
            };

            Random random = new Random();  // Creat a new random number generator.

            foreach (TextBlock textBlock in mainGrid.Children.OfType<TextBlock>()) // Repeat the following code for each textblock found.
            {
                if (textBlock.Name != "timeTextBlock")
                {
                    textBlock.Visibility = Visibility.Visible;
                    int index = random.Next(animalEmoji.Count);  // Picks a random number between o and the number of emojis left and assigns it to index.
                    string nextEmoji = animalEmoji[index]; // Uses the random number called "index" to get an emoji from the list.
                    textBlock.Text = nextEmoji;  // Updates the textbloxk with the random emoji.
                    animalEmoji.RemoveAt(index);  // Removes the emoji from the list.
                }

                timer.Start();
                tenthsSecElapsed = 0;
                matchesFound = 0;
            }
        }

        public MainWindow()
        {
            InitializeComponent();

            timer.Interval = TimeSpan.FromSeconds(.1);
            timer.Tick += Timer_Tick;
            setUpGame();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            tenthsSecElapsed++;
            timeTextBlock.Text = (tenthsSecElapsed / 10F).ToString("0.0s");
            if (matchesFound == 8)
            {
                timer.Stop();
                timeTextBlock.Text = timeTextBlock.Text + " - Play Again?";
            }
        }

        TextBlock lastTextBlockClicked;
        bool findMatch;
        private void TextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            TextBlock textBlock = sender as TextBlock;
            if (findMatch == false)
            {
                textBlock.Visibility = Visibility.Hidden;
                lastTextBlockClicked = textBlock;
                findMatch = true;
            }
            else if (textBlock.Text == lastTextBlockClicked.Text)
            {
                matchesFound++;
                textBlock.Visibility = Visibility.Hidden;
                findMatch = false;
            }
            else
            {
                lastTextBlockClicked.Visibility = Visibility.Visible;
                findMatch= false;
            }
        }

        private void timeTextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (matchesFound == 8)
            {
                setUpGame();
            }
        }
    }
}
