using DataGrid_Shamilova_variant_4.CLasses;
using DataGrid_Shamilova_variant_4.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace DataGrid_Shamilova_variant_4
{
    public partial class TourForm : Form
    {
        private Tour tour;

        public TourForm(Tour tour = null)
        {
            InitializeComponent();

            this.tour = tour == null
                ? DateGenerate.CreateTour(x =>
                {
                    x.Direction = Direction.Turkish;
                    x.DepartureDate = DateTime.Now;
                })
                : new Tour
                {
                    Id = tour.Id,
                    Direction = tour.Direction,
                    DepartureDate = tour.DepartureDate,
                    NumberOfNights = tour.NumberOfNights,
                    CostVacationer = tour.CostVacationer,
                    NumberOfVacationer = tour.NumberOfVacationer,
                    WiFi = tour.WiFi,
                    Surcharges = tour.Surcharges,
                    TotalCost = tour.TotalCost,
                };


            foreach (var item in Enum.GetValues(typeof(Direction)))
            {
                comboBoxDirection.Items.Add(item);
            }

            if (comboBoxDirection.Items.Count > 0)
            {
                comboBoxDirection.SelectedIndex = 0;
            }

            comboBoxDirection.AddBinding(x => x.SelectedItem, this.Tour, x => x.Direction, errorProvider1);
            dateTimePickerDepartureDate.AddBinding(x => x.Value, this.Tour, x => x.DepartureDate, errorProvider1);
            numericUpDownNumberOfNights.AddBinding(x => x.Value, this.Tour, x => x.NumberOfNights, errorProvider1);
            numericUpDownCostVacationer.AddBinding(x => x.Value, this.Tour, x => x.CostVacationer, errorProvider1);
            numericUpDownNumberOfVacationer.AddBinding(x => x.Value, this.Tour, x => x.NumberOfVacationer, errorProvider1);
            checkBoxWiFi.AddBinding(x => x.Checked, this.Tour, x => x.WiFi, errorProvider1);
            numericUpDownSurcharges.AddBinding(x => x.Value, this.Tour, x => x.Surcharges, errorProvider1);
            //textBoxTotalCost.AddBinding(x => x.Text, this.Tour, x => x.TotalCost, errorProvider1);
            //textBoxTotalCost.Text = (numericUpDownCostVacationer.Value * numericUpDownNumberOfVacationer.Value + numericUpDownSurcharges.Value).ToString();

        }

        public Tour Tour => tour;

        private void comboBoxDirection_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();

            // Создаем прямоугольник
            using (var path = new GraphicsPath())
            {
                path.AddRectangle(new Rectangle(e.Bounds.X + 2, e.Bounds.Y + 2, e.Bounds.Height - 4, e.Bounds.Height - 4));
                e.Graphics.FillPath(Brushes.Red, path);
            }

            if (e.Index > -1)
            {
                var value = (Direction)(sender as ComboBox).Items[e.Index];
                e.Graphics.DrawString(GetDisplayValue(value),
                    e.Font,
                    new SolidBrush(e.ForeColor),
                    e.Bounds.X + 20,
                    e.Bounds.Y);
            }
        }

        private string GetDisplayValue(Direction value)
        {
            var field = value.GetType().GetField(value.ToString());
            var attributes = field.GetCustomAttributes<DescriptionAttribute>(false);

            return attributes.FirstOrDefault()?.Description;
        }
    }
}
