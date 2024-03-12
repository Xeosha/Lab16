using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab16
{
    public partial class AddManuallyForm : Form
    {
        public AddManuallyForm()
        {
            InitializeComponent();
        }
    }

    public class IconButton2 : IconButton
    {
        public Label? Label { get; set; } = null;
    }
}
