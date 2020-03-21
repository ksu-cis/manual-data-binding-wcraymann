/*
 * Author: Nathan Bean and William Raymann.
 * Class: NoteEditor.
 * Prupose: To display current note information and to update the current note
 *          and current display whenever the current note information is altered
 *          by the user.
 */
using System;
using System.Collections.Generic;
using System.Text;
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

namespace ManualDataBinding.UI
{
    /// <summary>
    /// Interaction logic for NoteEditor.xaml
    /// </summary>
    public partial class NoteEditor : UserControl
    { 

        private Note note;
        /// <summary>
        /// The current note being displayed.
        /// </summary>
        public Note Note
        {
            get { return note; }
            set
            {
                if (note == value) return;
                if (note != null) note.NoteChanged -= OnNoteChanged;
                note = value;
                if (note != null) note.NoteChanged += OnNoteChanged;
            }
        }

        public NoteEditor()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Event handler for updating the displayed current note content.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnNoteChanged(object sender, EventArgs e)
        {
            if (Note == null) return;
            Title.Text = Note.Title;
            Body.Text = Note.Body;
        }

        /// <summary>
        /// Event handler that updates the title of the current
        /// note with the text in the current editor's title that
        /// fires when the text in the current editor's title changes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnTitleChanged(object sender, EventArgs e)
        {
            Note.Title = Title.Text;
        }

        /// <summary>
        /// Event handler that updates the body of the current
        /// note with the text in the current editor's body that
        /// fires when the text in the current editor's title changes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnBodyChanged(object sender, EventArgs e)
        {
            Note.Body = Body.Text;
        }
    }
}
