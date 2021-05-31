/**************************************************************************
 *                                                                        *
 *  File:        MainControl.cs                                           *
 *  Autor:       Ruxandra Simioniuc                                       *         
 *  Functionalitate:    Clasa care realizeaza trecerea de la un panel la  *
 *  altul                                                                 *
 **************************************************************************/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectIP_interfata
{
    class MainControl
    {
        #region Public Methods
        /// <summary>
        /// Metoda schimba continutul panel-ului curent cu cel al urmatorului 
        /// </summary>
        /// <param name="control"></param>
        /// <param name="Content"></param>
        public static void showControl(Control newContent, Control currentContent)
        {
            currentContent.Controls.Clear();

            newContent.Dock = DockStyle.Fill;
            newContent.BringToFront();
            newContent.Focus();

            currentContent.Controls.Add(newContent);
        }
        #endregion
    }
}
