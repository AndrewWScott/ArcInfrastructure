using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArcInfrastructure
{
    public partial class frmShape : Form
    {
        public frmShape()
        {
            InitializeComponent();
            
            cmbShape.Items.Add(Shapes.Shape.Circle);
            cmbShape.Items.Add(Shapes.Shape.Square);
            cmbShape.Items.Add(Shapes.Shape.Rectangle);
        }

        private void cmbShape_SelectedValueChanged(object sender, EventArgs e)
        {
            cmbShape = (ComboBox)sender;
            var shape = ((Shapes.Shape)cmbShape.SelectedItem);
            var dimensions = 0;
            var text1 = "";
            var text2 = "";

            Shapes.getSettings(shape, ref dimensions, ref text1, ref text2);

          
            lblOne.Text = text1;
            lblTwo.Text = text2;

            lblTwo.Visible = dimensions == 2 ?  true : false;
            txtTwo.Visible = dimensions == 2 ? true : false;
            
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            var dimensions = 0;
            var text1 = "";
            var text2 = "";
            double dOne;
            double dTwo;
            var isOneSuccess = Double.TryParse(txtOne.Text, out dOne);
            var isTwoSuccess = Double.TryParse(txtTwo.Text, out dTwo);

            var ShapeIn = (ComboBox)cmbShape;
            var shape = ((Shapes.Shape)ShapeIn.SelectedItem);

            Shapes.getSettings(shape, ref dimensions, ref text1, ref text2);

            if (isOneSuccess || (isTwoSuccess && dimensions > 1)) { 
                lblArea.Text = "Area: " + Shapes.calculate(shape, dOne, dTwo).ToString();
            }
            else
            {
                lblArea.Text = "Warning the values entered must be numbers.";
            }
        }

    }
}
