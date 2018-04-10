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

namespace u3WebclientSebastian
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //WebClient to get info
            /*System.Net.WebClient theInterWebs = new System.Net.WebClient();
            theInterWebs.BaseAddress = "http://www.gutenberg.org/cache/epub/1661/pg1661.txt";
            System.IO.StreamReader streamReader = new System.IO.StreamReader(theInterWebs.OpenRead("http://www.gutenberg.org/cache/epub/1661/pg1661.txt"));
            System.IO.StreamWriter streamWriter = new System.IO.StreamWriter("teams.txt");
            try
            {*/
            /*
                //variable
                string substring = "";
                string AllTeams = "";
                int numberOfThings = 0;
                while (!streamReader.EndOfStream)
                {
                    string line = streamReader.ReadLine();
                    if (line.Contains("my dear Watson"))
                    {
                        
                        numberOfThings = numberOfThings + 1;
                        MessageBox.Show("My dear Watson " + numberOfThings.ToString());
                        // MessageBox.Show(line);
                        //add the team to the variable with a new line
                        int StartIndex = 12;
                        int Length = 7;
                        substring = line.Substring(StartIndex, Length);
                        AllTeams = AllTeams + substring + "\r";
                        //MessageBox.Show(substring);
                        streamWriter.WriteLine(line);
                    }

                }
                //message box to show the variable
                streamWriter.Flush();
                streamWriter.Close();
                streamReader.Close();
                MessageBox.Show("\n" + "    Here in my garage, just bought this new Lamborghini here. It’s fun to drive up here in the Hollywood hills. But you know what I like more than materialistic things? Knowledge.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error");
            }*/

        }

        private void FindAndReplace(object sender, RoutedEventArgs e)
        {
            string Link = txtInputLink.Text;
            System.Net.WebClient theInterWebs = new System.Net.WebClient();
            System.IO.StreamReader streamReader = new System.IO.StreamReader(theInterWebs.OpenRead(Link));
            System.IO.StreamWriter streamWriter = new System.IO.StreamWriter("teams.txt");
            try
            {
                //variable
                string Output = "Lines Found with word or phrase: " + "\r";
                string Word = txtInputFind.Text;
                int numberOfThings = 0;
                while (!streamReader.EndOfStream)
                {
                    string line = streamReader.ReadLine();
                    if (line.Contains(Word))
                    {

                        numberOfThings = numberOfThings + 1;
                        MessageBox.Show("Number of Items: " + numberOfThings.ToString());
                        /*// MessageBox.Show(line);
                        //add the team to the variable with a new line
                        int StartIndex = 12;
                        int Length = 7;
                        substring = line.Substring(StartIndex, Length);
                        AllTeams = AllTeams + substring + "\r";
                        //MessageBox.Show(substring);*/
                        streamWriter.WriteLine(line);
                        Output = Output + line + "\r";
                        
                    }

                }
                lblOutput.Content = Output;
                //message box to show the variable
                streamWriter.Flush();
                streamWriter.Close();
                streamReader.Close();
               // MessageBox.Show("\n" + "    Here in my garage, just bought this new Lamborghini here. It’s fun to drive up here in the Hollywood hills. But you know what I like more than materialistic things? Knowledge.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error");
            }

        }

    }
}

