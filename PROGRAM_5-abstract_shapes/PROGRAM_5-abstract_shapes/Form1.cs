using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheCoolestShapes;

namespace PROGRAM_5_abstract_shapes
{
    public partial class Shape_Generator : Form
    {
        Circle circle;
        TheCoolestShapes.Rectangle rectangle;
        Square square;
        Cube cube;
        Sphere sphere;
        Cylinder cylinder;
        Shape shape;
        Image image;

        public Shape_Generator()
        {
            InitializeComponent();
        }

        void YankData(Shape shape)
        {
            InfoBox.Text = shape.ToString();
            ShapeImage.Image = image;
        }

        void UpdateForm()
        {
            switch (ShapeDropDown.Text)
            {
                case "Circle":
                    circle = circle 
                        ?? new Circle((double)Variable1.Value);
                    shape = circle;
                    Variable1.Enabled = true;
                    Variable2.Enabled = true;
                    Variable3.Enabled = false;
                    image = ShapeImages.circle;
                    break;

                case "Rectangle":
                    rectangle = rectangle
                        ?? new TheCoolestShapes.Rectangle((double)Variable1.Value,
                        (double)Variable2.Value);
                    shape = rectangle;
                    Variable1.Enabled = true;
                    Variable2.Enabled = true;
                    Variable3.Value = 0;
                    Variable3.Enabled = false;
                    image = ShapeImages.rectangle;
                    break;

                case "Square":
                    square = square
                        ?? new Square((double)Variable1.Value);
                    shape = square;
                    Variable1.Enabled = true;
                    Variable2.Value = 0;
                    Variable3.Value = 0;
                    Variable2.Enabled = false;
                    Variable3.Enabled = false;
                    image = ShapeImages.square;
                    break;

                case "Cube":
                    cube  = cube
                        ?? new Cube((double)Variable1.Value);
                    shape = cube;
                    Variable1.Enabled = true;
                    Variable2.Value = 0;
                    Variable3.Value = 0;
                    Variable2.Enabled = false;
                    Variable3.Enabled = false;
                    image = ShapeImages.cube;
                    break;

                case "Sphere":
                    sphere = sphere
                        ?? new TheCoolestShapes.Sphere((double)Variable1.Value);
                    shape = sphere;
                    Variable1.Enabled = true;
                    Variable2.Value = 0;
                    Variable3.Value = 0;
                    Variable2.Enabled = false;
                    Variable3.Enabled = false;
                    image = ShapeImages.sphere;
                    break;

                case "Cylinder":
                    cylinder = cylinder
                       ?? new TheCoolestShapes.Cylinder((double)Variable1.Value,
                        (double)Variable2.Value);
                    shape = cylinder;
                    Variable1.Enabled = true;
                    Variable2.Enabled = true;
                    Variable3.Value = 0;
                    Variable3.Enabled = false;
                    image = ShapeImages.cylinder;
                    break;
            }
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            try
            {
                YankData(shape);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Could Not Process Data");
            }

        }

        private void ShapeDropDown_DropDownClosed(object sender, EventArgs e)
        {
            UpdateForm();
        }
    }
}
