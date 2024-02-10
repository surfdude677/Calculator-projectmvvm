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
using System.Windows.Shapes;
using לומדתמחשבון.utilities;

namespace לומדתמחשבון
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        private int score = 0;
        private int min_number = 1;
        private int max_number = 12;
        private int max_rounds = 6;
        private string firstName;
        private string lastName;
        private string fullName;
        private Random rnd = new Random();
        Game_logic gaming = new Game_logic();
        int[] nums;
        private int correct_answer;
        private int rounds = -1;

        public Window2(string firstName, string lastName)
        {
            InitializeComponent();
            this.firstName = firstName;
            this.lastName = lastName;
            this.fullName = firstName + " " + lastName;
            TextBlock nameBlock = FindName("FullName") as TextBlock;
            nameBlock.Text = this.fullName;
            music.Play();
                
            

            Run();
              
        }

        private void end_game()
        {
            MessageBoxImage end = MessageBoxImage.Warning;
            MessageBoxButton button = MessageBoxButton.OK;
            MessageBoxImage icon = MessageBoxImage.Warning;
            string messageBoxText_end = correct_answer.ToString();
            string caption = "message!";
            messageBoxText_end =  this.fullName + " your score is " + score.ToString();
            if (this.score < 1)
                messageBoxText_end += "\n thou shaln't survive the night of the hunt";
            else if (this.score < 3)
                messageBoxText_end += "\n thou art of passing skill";
            else if (this.score <= 6)
                messageBoxText_end += "\n even in this darkest of night you still see... the moonlight!!!";
         


            MessageBox.Show(messageBoxText_end, caption, button);

            Environment.Exit(0);
            

        }

        public void Run()
        {
           
            this.rounds++;
            if (this.rounds == this.max_rounds)
            {
                end_game();
                   
            }

                TextBlock signTextBlock = FindName("SignBlock") as TextBlock;
                TextBlock Num1Text = FindName("num1") as TextBlock;
                TextBlock Num2Text = FindName("num2") as TextBlock;
            TextBlock Scoreblock = FindName("scoreBlock") as TextBlock;
            Scoreblock.Text = "Round: " + this.rounds.ToString() + " out of " + this.max_rounds +
                "\nYour score is: " + this.score.ToString(); 
            int num0 = this.rnd.Next(this.min_number, this.max_number);
            int num1 = this.rnd.Next(this.min_number, this.max_number);
           
                int question_i = rnd.Next(0, 4);
                switch (question_i)
                {
                    case 0:     
                        signTextBlock.Text = "+";
                    this.correct_answer = num0 + num1;
                        break;
                    case 1:
                        signTextBlock.Text = "-";
                    this.correct_answer = num0 - num1;
                    break;
                    case 2:
                        signTextBlock.Text = "/";
                        while (num1 == 0)
                            num1 = this.rnd.Next(this.min_number, this.max_number);
                        num0 = num0 * num1;
                        this.correct_answer = num0 / num1;
                    break;
                    case 3:
                        signTextBlock.Text = "*";
                    this.correct_answer = num0 * num1;
                    break;

                }
            Num1Text.Text = num0.ToString();
            Num2Text.Text = num1.ToString();


        }
        
        private void checkAns(object sender, RoutedEventArgs e)
        {
            TextBox user_answer = FindName("Ans") as TextBox;

            TextBlock signTextBlock = FindName("SignBlock") as TextBlock;
            TextBlock Num1Text = FindName("num1") as TextBlock;
            TextBlock Num2Text = FindName("num2") as TextBlock;
            int num0 = int.Parse(Num1Text.Text);
            int num1 = int.Parse(Num2Text.Text);

            int user_numeric_answer;
            int state = -1;
            bool isDecimal = int.TryParse(user_answer.Text, out user_numeric_answer);

            if (isDecimal)
            {
                state = Convert.ToInt32(correct_answer == int.Parse(user_answer.Text));
            }
            string messageBoxText = correct_answer.ToString();
            string caption = "Word Processor";

            MessageBoxButton button = MessageBoxButton.OK;
            MessageBoxImage icon = MessageBoxImage.Warning;
            MessageBoxResult result;
            switch (state)
            {
                // error input
                case -1:
                    messageBoxText = "Invalid input";
                    icon = MessageBoxImage.Warning;
                    result = MessageBox.Show(messageBoxText, caption, button, icon, MessageBoxResult.Yes);
                    break;
                case 0:
                    messageBoxText = "Wrong";
                    icon = MessageBoxImage.Exclamation;
                    result = MessageBox.Show(messageBoxText, caption, button, icon, MessageBoxResult.Yes);
                    Run();
                    break;
                case 1:
                    messageBoxText = "Correct, you reccieve one point!";
                    icon = MessageBoxImage.Exclamation;
                    result = MessageBox.Show(messageBoxText, caption, button, icon, MessageBoxResult.Yes);
                    this.score++;
                    Run();
                    break;


            }
            
             
        }
    }
}
