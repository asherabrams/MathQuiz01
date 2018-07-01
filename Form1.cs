// MathQuizTutorial01, Asher Abrams, 2018-06-28.
// Tutorial from MS Docs.  Creates a timed math quiz.
// Step 1:  I am modifying the size of the form from the specifications in the tutorial
// because my machine has an unusually high pixel resolution and it won't display properly.
// Step 1.2.1.  Label timeLabel is set to AutoSize=False because we need to leave the text empty
// without the box borders shrinking to nothing (step 1.2.6).
// Step 1.3.7.  We create the label plusLeftLabel, which will serve as a template.
// Step 1.3.16.  After setting the properties for all four labels, we add a NumericUpDown and call it sum.
// First row of controls is now done.


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathQuizTutorial01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
    }
}
