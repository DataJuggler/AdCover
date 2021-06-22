

#region using statements

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

#endregion

namespace AdCover
{

    #region class MainForm
    /// <summary>
    /// This is the main form for this app.
    /// </summary>
    public partial class MainForm : Form
    {
        
        #region Private Variables
        #endregion
        
        #region Constructor
        /// <summary>
        /// Create a new instance of a 'MainForm' object.
        /// </summary>
        public MainForm()
        {
            // Create Controls
            InitializeComponent();
        }
        #endregion
        
        #region Events
            
            #region MainForm_Load(object sender, EventArgs e)
            /// <summary>
            /// event is fired when Main Form _ Load
            /// </summary>
            private void MainForm_Load(object sender, EventArgs e)
            {
                // Position this form.
                this.Left = Screen.PrimaryScreen.Bounds.Width - this.Width + 16;
                this.Top = 0;
                this.Height = Screen.PrimaryScreen.Bounds.Height - 32;
                this.Width = 820;
            }
            #endregion
            
        #endregion
        
    }
    #endregion

}
