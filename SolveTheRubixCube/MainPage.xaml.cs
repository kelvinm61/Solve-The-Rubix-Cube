using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace SolveTheRubixCube
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        List<string> _rubix;   //initialising strings
        public MainPage()
        {
            this.InitializeComponent();
            setupListsOfDescription();

            this.NavigationCacheMode = NavigationCacheMode.Required;
        }//main page
        //text for the app pages
        private void setupListsOfDescription()
        {
            if (_rubix != null)  //if statement
            {
                return;
            }
            _rubix = new List<string>();

            _rubix.Add("Before you use this guide you should experiment with the cube yourself and try solve it on your own, this guide still requires brain power! Some things you might notice is that the center pieces of the cube never move,They will determine the cover of that edge. There are over 43 quintillion ways to solve the rubix cube so just randomly moving parts is literally impossible to solve it. An algorithm is needed and We will walk through it in the 8 simple steps. ");
            _rubix.Add("Each face of the cube is represented by a letter. You might have to come back to this page a few times to remind yourself what side is what, the picture on the left are the graphical views of each side. \n R = Right Face - Right side of the cube.\n L = Left Face - Left side of the cube.\n U = Up Face - Top side of the cube.\n D = Down Face - Bottom side of the cube.\n F = Front Face - Front side of the cube.\n B = Back Face - Back side of the cube");
            _rubix.Add("Were going to start with the white face first, We start by getting the white edges into place first, here is a simple algorithm to help you do that by remembering the names of the sides from the  previous page. \n The algorithm is F'R'D'R'F2 (2 means go at that side a second time) \n The next thing we do is sort the white corners and complete the white face. If your having difficulty with the corners then use this algorithm.\n R'D'R'D.\n Your cube should now look like the photo on the left.  ");
            _rubix.Add("Now that we have finished the white face, turn the cube upside down as we no longer need to see that side.Things get a bit trickier here as there are two very similar algorithms to learn. \n The FIrst algorithm sends the piece from the front Up position to the front Right. The second algorithm send the piece from the frontUP to the Front Left. \n Front Right U'R'U'U'F'U'F \n Front Left U'L'U'L'U'F'U'F");
            _rubix.Add("In step three we want to form a cross on the top of the cube(It should be yellow if you started with the white side).It doesnt matter is the sides are not matching up from the last step as we will correct that in the next step. For now just concentrate on the cross.\n Use this algorithm to get it. F'R'U'R'U'F \n When the cross is complete your ready to move on to the next step! Good Job!  ");
            _rubix.Add("Now we have the cross on top, but the sides do not match up the other colours sides so we must fix this.To sort this out we use this algorithm which swaps the front up and left up edges. \n Algorithm is R'U'R'U'R'U2'R'U");
            _rubix.Add("Were almost there. All thats left is the yellow corners and were going to sort them out in two simple steps The first step is to position them into shape The algorithm cycles through all these pieces and corrects them. \n The algorithm is U'R'U'L'U'R'U'L");
            _rubix.Add("This is the final step, every piece is where its suppose to be, but the left corners are orientated wrong. So we use a simple algorithm to correct this and finish the cube.\n The algorithm is R'D'R'D \n And the rubix cube is complete! Congratulations!");
            _rubix.Add("\nCongratulations!!! \nYou have successfully solved the rubix cube! \n Dont worry if it hasnt worked out this time. Sometimes the cube is sitting in such a way that it doesnt full work out, so if it didnt work then try it again, and again.If after that it still doesnt work throw it out the window yours is obviously broken! Hope this app helped you. Keep opening the app and reading the algorithms and eventually you will learn them and be able to do it without the app. here is the algorym summarised in one. \n R'D'R'D - R'D'R'D - U'R'D \n R'D -R'D'R'D - R'D'R'D - R'D \n R'D - U'R'D'R'D - R'D'R'D \n U'R'D'R'D - R'D'R'D - R'D \n R'D - R'D'R'D -U ");


            int i;
            TextBlock curr;
            for (i = 0; i <= 8; i++)//for loop
            {
                curr = (TextBlock)pvtPad.FindName("tblAbout" + i.ToString());
                if (curr != null)
                {
                    curr.Text = _rubix[i];
                }
            }
        }

        private void pvtPad_SizeChanged(object sender, SizeChangedEventArgs e)
        {

        }
        public Windows.Storage.StorageFolder LocalCacheFolder { get; }
    }//partial class
}//namespace
