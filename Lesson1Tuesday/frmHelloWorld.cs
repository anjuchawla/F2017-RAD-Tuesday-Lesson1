/*
 * Name: Anju Chawla
 * Date: September 19, 2017
 * Purpose: This application pribts a message In English and Spanish,
 * depending on user input. The output can be cleared. The form can be printed.
 */
 

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson1Tuesday
{
    public partial class frmHelloWorld : Form
    {
        public frmHelloWorld()
        {
            InitializeComponent();
        }
        /// <summary>
        /// The message is displayed in English when the button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEnglish_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "Hello World";
        }
        /// <summary>
        /// The message is displayed in Spanish when the button is clicked
        /// </summary>
        /// <param name="sender">The Spanish button</param>
        /// <param name="e">The event arguments</param>
        private void btnSpanish_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "Hola Mundo";
        }
        /// <summary>
        /// Clear the message
        /// 
        /// </summary>
        /// <param name="sender">The Clear button</param>
        /// <param name="e">The event arguments</param>

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblMessage.Text = String.Empty;
        }
        /// <summary>
        /// Close the application
        /// </summary>
        /// <param name="sender">The Exit button</param>
        /// <param name="e">The event arguments</param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            //Application.Exit();


        }
        /// <summary>
        /// The form is displayed in preview mode
        /// </summary>
        /// <param name="sender">The Print Form button</param>
        /// <param name="e">The event arguments</param>
        private void btnPrint_Click(object sender, EventArgs e)
        {
            printForm1.Print(); 
        }

      
    }
}
