using DataGrid_Shamilova_variant_4.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGrid_Shamilova_variant_4
{
    /// <summary>
    /// Главная форма
    /// </summary>
    public partial class Form1 : Form
    {
        private List<Tour> tours;
        private BindingSource bindingSource; //UI

        /// <summary>
        /// Инициаkизирует новый экземпляр <see cref="Form1" />
        /// </summary>
        public Form1()
        {
            bindingSource = new BindingSource();
            tours = new List<Tour>();

            bindingSource.DataSource = tours;
            InitializeComponent();
            dataGridViewTours.AutoGenerateColumns = false;
            dataGridViewTours.DataSource = bindingSource;
            SetStats();
        }

        //private void dataGridViewTours_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        //{
        //    //if (dataGridViewTours.Columns[e.ColumnIndex].Name == "WiFiColumn")
        //    //{
        //    //    var data = (Tour)dataGridViewTours.Rows[e.RowIndex].DataBoundItem;
        //    //    e.Value = data.WiFi ? "Да" : "Нет";
        //    //}
        //    if (dataGridViewTours.Columns[e.ColumnIndex].Name == "WiFiColumn")
        //    {
        //        if (e.RowIndex >= 0 && e.RowIndex < dataGridViewTours.Rows.Count)
        //        {
        //            var data = dataGridViewTours.Rows[e.RowIndex].DataBoundItem;
        //            if (data != null)
        //            {
        //                var tour = data as Tour;
        //                if (tour != null)
        //                {
        //                    e.Value = tour.WiFi ? "Да" : "Нет";
        //                }
        //                else
        //                {
        //                    e.Value = string.Empty; // или другое значение по умолчанию
        //                }
        //            }
        //        }
        //    }
        //}

        private void toolStripButtonAdd_Click(object sender, EventArgs e)
        {
            var tourForm = new TourForm();

            if (tourForm.ShowDialog(this) == DialogResult.OK)
            {
                tours.Add(tourForm.Tour);
                bindingSource.ResetBindings(false);
                SetStats();
            }
        }

        private void toolStripButtonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewTours.SelectedRows.Count != 0)
            {
                var data = (Tour)dataGridViewTours.Rows[dataGridViewTours.SelectedRows[0].Index].DataBoundItem;
                var tourForm = new TourForm(data);
                if (tourForm.ShowDialog(this) == DialogResult.OK)
                {
                    data.Direction = tourForm.Tour.Direction;
                    data.DepartureDate = tourForm.Tour.DepartureDate;
                    data.NumberOfNights = tourForm.Tour.NumberOfNights;
                    data.CostVacationer = tourForm.Tour.CostVacationer;
                    data.NumberOfVacationer = tourForm.Tour.NumberOfVacationer;
                    data.WiFi = tourForm.Tour.WiFi;
                    data.Surcharges = tourForm.Tour.Surcharges;
                    data.TotalCost = tourForm.Tour.CostVacationer * tourForm.Tour.NumberOfVacationer + tourForm.Tour.Surcharges;

                    bindingSource.ResetBindings(false);
                    SetStats();
                }
            }
        }

        private void toolStripButtonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewTours.SelectedRows.Count != 0)
            {
                var data = (Tour)dataGridViewTours.Rows[dataGridViewTours.SelectedRows[0].Index].DataBoundItem;
                if (MessageBox.Show($"Вы действительно хотите удалить {data.Direction}?", "Удаление записи") == DialogResult.OK)
                {
                    tours.Remove(data);
                    bindingSource.ResetBindings(false);
                    SetStats();
                }
            }
        }

        public void SetStats()
        {
            toolStripLabel1.Text = $"Общее количество туров: {tours.Count}";
            toolStripLabel2.Text = $"Общая сумма: {tours.DefaultIfEmpty(new Tour()).Sum(x => x.TotalCost)}";
            toolStripLabel3.Text = $"Количество туров с доплатами: {tours.Where(x => x.Surcharges > 0).Count()}";
            toolStripLabel4.Text = $"Общая сумма доплат: {tours.DefaultIfEmpty(new Tour()).Sum(x => x.Surcharges)}";
        }

        private void dataGridViewTours_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridViewTours.Columns[e.ColumnIndex].Name == "WiFiColumn")
            {
                var data = (Tour)dataGridViewTours.Rows[e.RowIndex].DataBoundItem;
                e.Value = data.WiFi ? "Да" : "Нет";
            }
            //if (dataGridViewTours.Columns[e.ColumnIndex].Name == "WiFiColumn")
            //{
            //    if (e.RowIndex >= 0 && e.RowIndex < dataGridViewTours.Rows.Count)
            //    {
            //        var data = dataGridViewTours.Rows[e.RowIndex].DataBoundItem;
            //        if (data != null)
            //        {
            //            var tour = data as Tour;
            //            if (tour != null)
            //            {
            //                e.Value = tour.WiFi ? "Да" : "Нет";
            //            }
            //            else
            //            {
            //                e.Value = string.Empty;
            //            }
            //        }
            //    }
            //}
        }
    }
}
