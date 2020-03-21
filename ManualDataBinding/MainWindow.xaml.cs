/* 
 * Authors: Nathan Bean and William Raymann.
 * Class: MainWindow.xaml.
 * Purpose: To diplay note information and allow user to modify it.
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
using ManualDataBinding.Data;

namespace ManualDataBinding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // The current note being diplayed.
        Note note = new Note();

        public MainWindow()
        {
            InitializeComponent();
            Editor.Note = note;
            
            /* These two lines of code are added by William Raymann
               so that the initial values of the current Note field
               will be visible in the editor. 
            */
            Editor.Title.Text = Editor.Note.Title;
            Editor.Body.Text = Editor.Note.Body;
        }

        /// <summary>
        /// Creates a new note to display and edit 
        /// when the New Note button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnNewNote(object sender, RoutedEventArgs e)
        {
            note = new Note();
            Editor.Note = note;

            /* These two lines of code are added by William Raymann
               so that the initial values of the current Note field
               will be visible in the editor. 
            */
            Editor.Title.Text = Editor.Note.Title;
            Editor.Body.Text = Editor.Note.Body;
        }

        /// <summary>
        /// Clears the text in the body of the current note
        /// when the Clear Note button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnClearNote(object sender, RoutedEventArgs e)
        {
            note.Body = "";
        }

        /// <summary>
        /// Changes the title of the current note to "Master Splinter"
        /// and the body to "There is no monster more dangerous than a 
        /// lack of compassion." when the Mutate Note button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnMutateNote(object sender, RoutedEventArgs e)
        {
            note.Title = "Master Splinter";
            note.Body = "There is no monster more dangerous than a lack of compassion.";
        }
    }
}
