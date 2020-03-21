/*
 * Authors: Nathan Bean and William Raymann.
 * Class: Note.
 * Prupose: To store data for a note and update any subscribing code
 *          whenever the stored data is changed.
 */
using System;

namespace ManualDataBinding.Data
{
    /// <summary>
    /// A class representing a note
    /// </summary>
    public class Note
    {
        private string title = DateTime.Now.ToString();
        /// <summary>
        /// The title of the Note
        /// </summary>
        public string Title
        {
            get { return title; }
            set
            {
                if (value == title) return;
                title = value;
                NoteChanged?.Invoke(this, new EventArgs());
            }
        }

        private string body = "";
        /// <summary>
        /// The text of the note
        /// </summary>
        public string Body
        {
            get { return body; }
            set
            {
                if (value == body) return;
                body = value;
                NoteChanged?.Invoke(this, new EventArgs());
            }
        }

        /// <summary>
        /// Event handler fired when the current note changes.
        /// </summary>
        public event EventHandler NoteChanged;
    }
}
