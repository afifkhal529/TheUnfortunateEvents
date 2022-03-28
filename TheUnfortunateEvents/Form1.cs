using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Windows.Forms;
using System.Threading;

namespace TheUnfortunateEvents
{
    public partial class form1 : Form
    {
        // Tracks what page of the story the user is at
        int page = 1;
        Random randGen = new Random();
        int random;

        public form1()
        {
            InitializeComponent();
            DisplayPage();

        }

        private void option1Button_Click(object sender, EventArgs e)
        {
            if (page == 1)
            {
                page = 2;
            }
            else if (page == 2)
            {
                page = 3;
            }

            else if (page == 6)
            {
                random = randGen.Next(1, 5);
                if (random < 2)
                {
                    page = 9;
                }
                else
                {
                    page = 10;
                }
            }
            else if (page == 11)
            {
                page = 13;
            }
            else if (page == 5)
            {
                page = 12;
            }
            else if (page == 15)
            {
                page = 16;
            }
            else if (page == 16)
            {
                page = 18;
            }
            else if (page == 18)
            {
                page = 20;
            }
            else if (page == 20)
            {
                page = 22;
            }


            DisplayPage();
        }
        private void option2Button_Click(object sender, EventArgs e)
        {
            if (page == 1)
            {
                page = 6;
            }
            else if (page == 6)
            {
                page = 7;
            }
            else if (page == 2)
            {
                page = 8;
            }
            else if (page == 11)
            {
                page = 14;
            }
            else if (page == 5)
            {
                page = 15;
            }
            else if (page == 15)
            {
                page = 17;
            }
            else if (page == 16)
            {
                page = 19;
            }
            else if (page == 18)
            {
                page = 21;
            }
            else if (page == 20)
            {
                page = 23;
            }


            DisplayPage();

        }

        private void option3Button_Click(object sender, EventArgs e)
        {
            if (page == 1)
            {
                page = 4;
            }

        }
        public void DisplayPage()
        {
            switch (page)
            {
                case 1:
                    outputLabel.Text = $"You are enjoying your evening stroll in the streets of Toronto. Cool air rushes against your face as you admire the beautiful evening sky, and the luxuries that the earth has given.";
                    outputLabel.Text += $"\n";
                    outputLabel.Text += $"You continue to stroll down the streets that you loose track of time. Soon you come to realize that you have walked to the other side of the city and it's nearly dark!";
                    
                    outputLabel.Text += $"\nAfraid of the night, you want to reach your home as quickly as you can.";
                    outputLabel.Text += $"\n";
                    outputLabel.Text += $"\nYou can either call a taxi, walk, or ask someone for a lift. What do you choose?";

                    option1Label.Text = $"Call a taxi";
                    option2Label.Text = $"Ask someone for a lift";
                    option3Label.Text = $"Walk";
                    break;
                case 2:
                    outputLabel.Text = $"You call a taxi to get home safe and sound. You continuously glance at your phione during the taxi ride, just to make sure that the driver does not take a wrong turn";
                    outputLabel.Text += $"\n";
                    outputLabel.Text += $"\nTHUD! The car violently jerked. You and the driver are alarmed at the sudden incident. The alarmned driver steps out of the car to inspect the cause. After 5 minutes the driver steps back inside the car and informs you that the car hit a pothole, which caused the front right tire to puncture.";
                    //Refresh();
                    //Thread.Sleep(5000);
                    outputLabel.Text += $"\nYou can either wait for a mechanic to come fix the car or walk to your home all by yourself";
                    option1Label.Text = $"Wait for the mechanic";
                    option2Label.Text = $"Walk back home";
                    option3Label.Text = $"";
                    break;
                case 3:
                    outputLabel.Text = $"The mechanic arrives after 30 minutes, fixes the car and you arrive home safely.";
                    outputLabel.Text += $"\n";
                    outputLabel.Text += $"\n Play Again?";

                    option1Label.Text = $"Yes";
                    option2Label.Text = $"No";
                    option3Label.Text = $"";
                    break;
                case 4:
                    outputLabel.Text = $"You choose to walk back home. After what feels like 30 minutes, you are startled by a hight pitched scream. You frantically look around to see where the screen came from. Then, from the corner of your eye, you spot 2 persons across the street.";
                    outputLabel.Text += $"";
                    outputLabel.Text += $"";

                    option1Label.Text = $"";
                    option2Label.Text = $"";
                    option3Label.Text = $"";
                    break;
                case 5:
                    outputLabel.Text = $"";
                    outputLabel.Text += $"";
                    outputLabel.Text += $"";

                    option1Label.Text = $"";
                    option2Label.Text = $"";
                    option3Label.Text = $"";
                    break;
                case 6:
                    outputLabel.Text = $"You wave down the first car you see and ask for a lift. After riding for awhile, they start to slow down. You start to realize that your about to be abducted.";
                    
                    outputLabel.Text += $"\n";
                    outputLabel.Text += $"You can either panic or call the police secretly";

                    option1Label.Text = $"Call police";
                    option2Label.Text = $"Panic";
                    option3Label.Text = $"";
                    break;
                case 7:
                    outputLabel.Text = $"You get taken away never to be seen again. You later die of loneliness.";
                    outputLabel.Text += $"\n";
                    outputLabel.Text += $"\nPlay Again?";

                    option1Label.Text = $"Yes";
                    option2Label.Text = $"No";
                    option3Label.Text = $"";
                    break;
                case 8:
                    outputLabel.Text = $"You get hit by a truck and die";
                    outputLabel.Text += $"\n";
                    outputLabel.Text += $"\nPlay Again";

                    option1Label.Text = $"";
                    option2Label.Text = $"";
                    option3Label.Text = $"";
                    break;
                case 9:
                    outputLabel.Text = $"The police catch the car and arrest the driver, while you safely live your life happily";
                    outputLabel.Text += $"\n";
                    outputLabel.Text += $"Play Again?";

                    option1Label.Text = $"Yes";
                    option2Label.Text = $"No";
                    option3Label.Text = $"";
                    break;
                case 10:
                    outputLabel.Text = $"You are not found ever again.";
                    outputLabel.Text += $"\n";
                    outputLabel.Text += $"Play Again?";

                    option1Label.Text = $"Yes";
                    option2Label.Text = $"No";
                    option3Label.Text = $"";
                    break;
                case 11:
                    break;
                case 12:
                    break;
                case 13:
                    break;
                case 14:
                    break;
                default:
                    break;


            }
        }

    }
}
