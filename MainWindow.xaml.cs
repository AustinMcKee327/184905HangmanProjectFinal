/* Austin Mckee
 * April 23, 2019
 * this program runs a hangman game, draws a hangman for each wrong answer, shows you all wrong guesses and gives a game over if you lose or you win if you win
 */
using System;
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

namespace _184905HangmanProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string[] easyanswer = new string[10];
        string[] mediumanswer = new string[10];
        string[] hardanswer = new string[10];
        int counter = 0;
        string correctanswer;
        Random random = new Random();
        string discoveredanswer;
        int missedletter = 0;
        int fails;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void StartGame_Click(object sender, RoutedEventArgs e)
        {
            int randomnumber = random.Next(0, 10);
            fails = 0;
            LettersGuessed.Text = "";
            Stickman.Children.RemoveRange(0, 99);
            LetterInput.Opacity = 100;
            counter = 0;
            LetterInput.Text = "";
            OutputWords.Text = "";
            Rectangle Hanger = new Rectangle();
            Hanger.Width = 35;
            Hanger.Height = 350;
            Hanger.Fill = Brushes.Black;
            Stickman.Children.Add(Hanger);
            Canvas.SetRight(Hanger, 275);
            Canvas.SetTop(Hanger, 25);
            Rectangle Hook = new Rectangle();
            Hook.Width = 150;
            Hook.Height = 35;
            Hook.Fill = Brushes.Black;
            Stickman.Children.Add(Hook);
            Canvas.SetTop(Hook, 25);
            Canvas.SetRight(Hook, 150);
            Rectangle Base = new Rectangle();
            Base.Height = 75;
            Base.Width = 150;
            Base.Fill = Brushes.Black;
            Stickman.Children.Add(Base);
            Canvas.SetRight(Base, 220);
            Canvas.SetTop(Base, 300);
            if ((bool)EasyMode.IsChecked)
            {

                System.IO.StreamReader easyread = new System.IO.StreamReader("Easy.txt");
                while (!easyread.EndOfStream)
                {
                    if (counter == randomnumber)
                    {
                        easyanswer[randomnumber] = easyread.ReadLine();

                        counter++;
                    }
                    else
                    {
                        easyread.ReadLine();
                        counter++;
                    }

                    correctanswer = easyanswer[randomnumber];
                    
                }
                easyread.Close();

                for (int i = 0; i < correctanswer.Length; i++)
                {
                    OutputWords.Text += "_";
                    OutputWords.Text += " ";
                }

            }
            if ((bool)MediumMode.IsChecked)
            {
                counter = 0;
                System.IO.StreamReader mediumread = new System.IO.StreamReader("Medium.txt");
                while (!mediumread.EndOfStream)
                {
                    if (counter == randomnumber)
                    {
                        mediumanswer[counter] = mediumread.ReadLine();
                        counter++;
                    }
                    else
                    {
                        mediumread.ReadLine();
                        counter++;
                    }

                    correctanswer = mediumanswer[randomnumber];
                    
                }
                mediumread.Close();
                for (int i = 0; i < correctanswer.Length; i++)
                {
                    OutputWords.Text += "_";
                    OutputWords.Text += " ";
                }
            }
            if ((bool)HardMode.IsChecked)
            {
                counter = 0;
                System.IO.StreamReader hardread = new System.IO.StreamReader("Hard.txt");
                while (!hardread.EndOfStream)
                {
                    if (counter == randomnumber)
                    {
                        hardanswer[counter] = hardread.ReadLine();
                        counter++;
                    }
                    else
                    {
                        hardread.ReadLine();
                        counter++;
                    }

                    correctanswer = hardanswer[randomnumber];
                   

                    
                }
                hardread.Close();
                for (int i = 0; i < correctanswer.Length; i++)
                {
                    OutputWords.Text += "_";
                    OutputWords.Text += " ";
                }
            }

        }


        private void LetterCheck_Click(object sender, RoutedEventArgs e)
        {
            LettersGuessed.Text += LetterInput.Text;
            discoveredanswer = OutputWords.Text;
            LetterInput.Text = LetterInput.Text.ToLower();
            if (LetterInput.Text == "")
            {
                return;
            }
            if (LetterInput.Text == "!")
            {
                return;
            }
            if (LetterInput.Text == "@")
            {
                return;
            }
            if (LetterInput.Text == "#")
            {
                return;
            }
            if (LetterInput.Text == "$")
            {
                return;
            }
            if (LetterInput.Text == "%")
            {
                return;
            }
            if (LetterInput.Text == "^")
            {
                return;
            }
            if (LetterInput.Text == "&")
            {
                return;
            }
            if (LetterInput.Text == "*")
            {
                return;
            }
            if (LetterInput.Text == "(")
            {
                return;
            }
            if (LetterInput.Text == ")")
            {
                
                return;
            }
            if (LetterInput.Text == "_")
            {
                return;
            }
            if (LetterInput.Text == "-")
            {
                return;
            }
            if (LetterInput.Text == "=")
            {
                return;
            }
            if (LetterInput.Text == "+")
            {
                return;
            }
            if (LetterInput.Text == "`")
            {
                return;
            }
            if (LetterInput.Text == "~")
            {
                return;
            }
            if (LetterInput.Text == "1")
            {
                return;
            }
            if (LetterInput.Text == "2")
            {
                return;
            }
            if (LetterInput.Text == "3")
            {
                return;
            }
            if (LetterInput.Text == "4")
            {
                return;
            }
            if (LetterInput.Text == "5")
            {
                return;
            }
            if (LetterInput.Text == "6")
            {
                return;
            }
            if (LetterInput.Text == "7")
            {
                return;
            }
            if (LetterInput.Text == "8")
            {
                return;
            }
            if (LetterInput.Text == "9")
            {
                return;
            }
            if (LetterInput.Text == "0")
            {
                return;
            }


            for (int i = 0; i < correctanswer.Length; i++)
            {
                char lettersingle = correctanswer[i];


                if (lettersingle.ToString() == LetterInput.Text)
                {
                    discoveredanswer = discoveredanswer.Remove(i * 2, 1);



                    discoveredanswer = discoveredanswer.Insert(i * 2, lettersingle.ToString());


                    OutputWords.Text = "";
                    OutputWords.Text += discoveredanswer;
                }
                else if (lettersingle.ToString() != LetterInput.Text)
                {
                    missedletter += 1;
                }
            }
            string OutputWordsNoSpaces = OutputWords.Text.Replace(" ", "");
            if (correctanswer == OutputWordsNoSpaces)
            {
                MessageBox.Show("You Won!");
                LetterInput.Opacity = 0;
            }

            if (missedletter == correctanswer.Length)
            {
                fails++;
                if (fails == 1)
                {
                    Ellipse head = new Ellipse();
                    head.Width = 100;
                    head.Height = 100;
                    head.Fill = Brushes.Aqua;
                    Stickman.Children.Add(head);
                    Canvas.SetRight(head, 100);
                    Canvas.SetTop(head, 50);
                    missedletter = 0;
                }
                if (fails == 2)
                {
                    Rectangle body = new Rectangle();
                    body.Width = 25;
                    body.Height = 150;
                    body.Fill = Brushes.Aqua;
                    Stickman.Children.Add(body);
                    Canvas.SetRight(body, 135);
                    Canvas.SetTop(body, 125);
                    missedletter = 0;
                }
                if (fails == 3)
                {
                    Rectangle legs = new Rectangle();
                    legs.Width = 25;
                    legs.Height = 100;
                    legs.Fill = Brushes.Aqua;
                    Stickman.Children.Add(legs);
                    Canvas.SetRight(legs, 115);
                    Canvas.SetTop(legs, 250);
                    missedletter = 0;
                }
                if (fails == 4)
                {
                    Rectangle legs2 = new Rectangle();
                    legs2.Width = 25;
                    legs2.Height = 100;
                    legs2.Fill = Brushes.Aqua;
                    Stickman.Children.Add(legs2);
                    Canvas.SetRight(legs2, 155);
                    Canvas.SetTop(legs2, 250);
                    missedletter = 0;
                }
                if (fails == 5)
                {
                    Rectangle arms = new Rectangle();
                    arms.Width = 75;
                    arms.Height = 25;
                    arms.Fill = Brushes.Aqua;
                    Stickman.Children.Add(arms);
                    Canvas.SetRight(arms, 155);
                    Canvas.SetTop(arms, 150);
                    missedletter = 0;
                }
                if (fails == 6)
                {
                    Rectangle arms2 = new Rectangle();
                    arms2.Width = 75;
                    arms2.Height = 25;
                    arms2.Fill = Brushes.Aqua;
                    Stickman.Children.Add(arms2);
                    Canvas.SetRight(arms2, 60);
                    Canvas.SetTop(arms2, 150);
                    missedletter = 0;
                }
                if (fails == 7)
                {
                    missedletter = 0;
                    LetterInput.Opacity = 0;
                    MessageBox.Show("Game Over!");
                    GameOverShower.Content = "The Correct Word Was: " + correctanswer;
                }

            }
            else { missedletter = 0; }

        }

       
    }
}
