namespace DataGrid_Shamilova_variant_4
{
    partial class TourForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxDirection = new System.Windows.Forms.ComboBox();
            this.dateTimePickerDepartureDate = new System.Windows.Forms.DateTimePicker();
            this.numericUpDownNumberOfNights = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownCostVacationer = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownNumberOfVacationer = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownSurcharges = new System.Windows.Forms.NumericUpDown();
            this.checkBoxWiFi = new System.Windows.Forms.CheckBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumberOfNights)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCostVacationer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumberOfVacationer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSurcharges)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label1.Location = new System.Drawing.Point(56, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Направление";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label2.Location = new System.Drawing.Point(56, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Дата вылета";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label3.Location = new System.Drawing.Point(56, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Количество ночей";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label4.Location = new System.Drawing.Point(56, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(251, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "Стоимость за отдыхающего";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label5.Location = new System.Drawing.Point(56, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 22);
            this.label5.TabIndex = 0;
            this.label5.Text = "Доплаты";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.buttonCancel);
            this.panel2.Controls.Add(this.buttonOk);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 392);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(636, 58);
            this.panel2.TabIndex = 2;
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Font = new System.Drawing.Font("Algerian", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(334, 13);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(120, 33);
            this.buttonCancel.TabIndex = 0;
            this.buttonCancel.Text = "CANCEl";
            this.buttonCancel.UseVisualStyleBackColor = false;
            // 
            // buttonOk
            // 
            this.buttonOk.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOk.Font = new System.Drawing.Font("Algerian", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOk.Location = new System.Drawing.Point(148, 13);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(120, 33);
            this.buttonOk.TabIndex = 0;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label7.Location = new System.Drawing.Point(56, 232);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(225, 22);
            this.label7.TabIndex = 0;
            this.label7.Text = "Количество отдыхающих";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label8.Location = new System.Drawing.Point(158, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(330, 22);
            this.label8.TabIndex = 0;
            this.label8.Text = "Заполните форму по турам ниже";
            // 
            // comboBoxDirection
            // 
            this.comboBoxDirection.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxDirection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDirection.FormattingEnabled = true;
            this.comboBoxDirection.Location = new System.Drawing.Point(334, 55);
            this.comboBoxDirection.Name = "comboBoxDirection";
            this.comboBoxDirection.Size = new System.Drawing.Size(222, 23);
            this.comboBoxDirection.TabIndex = 3;
            this.comboBoxDirection.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.comboBoxDirection_DrawItem);
            // 
            // dateTimePickerDepartureDate
            // 
            this.dateTimePickerDepartureDate.Location = new System.Drawing.Point(334, 99);
            this.dateTimePickerDepartureDate.Name = "dateTimePickerDepartureDate";
            this.dateTimePickerDepartureDate.Size = new System.Drawing.Size(222, 22);
            this.dateTimePickerDepartureDate.TabIndex = 4;
            // 
            // numericUpDownNumberOfNights
            // 
            this.numericUpDownNumberOfNights.Location = new System.Drawing.Point(334, 144);
            this.numericUpDownNumberOfNights.Name = "numericUpDownNumberOfNights";
            this.numericUpDownNumberOfNights.Size = new System.Drawing.Size(222, 22);
            this.numericUpDownNumberOfNights.TabIndex = 5;
            // 
            // numericUpDownCostVacationer
            // 
            this.numericUpDownCostVacationer.Location = new System.Drawing.Point(334, 188);
            this.numericUpDownCostVacationer.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownCostVacationer.Name = "numericUpDownCostVacationer";
            this.numericUpDownCostVacationer.Size = new System.Drawing.Size(222, 22);
            this.numericUpDownCostVacationer.TabIndex = 5;
            this.numericUpDownCostVacationer.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownNumberOfVacationer
            // 
            this.numericUpDownNumberOfVacationer.Location = new System.Drawing.Point(334, 232);
            this.numericUpDownNumberOfVacationer.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownNumberOfVacationer.Name = "numericUpDownNumberOfVacationer";
            this.numericUpDownNumberOfVacationer.Size = new System.Drawing.Size(222, 22);
            this.numericUpDownNumberOfVacationer.TabIndex = 5;
            this.numericUpDownNumberOfVacationer.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownSurcharges
            // 
            this.numericUpDownSurcharges.Location = new System.Drawing.Point(334, 275);
            this.numericUpDownSurcharges.Name = "numericUpDownSurcharges";
            this.numericUpDownSurcharges.Size = new System.Drawing.Size(222, 22);
            this.numericUpDownSurcharges.TabIndex = 5;
            // 
            // checkBoxWiFi
            // 
            this.checkBoxWiFi.AutoSize = true;
            this.checkBoxWiFi.Font = new System.Drawing.Font("MV Boli", 10.2F);
            this.checkBoxWiFi.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.checkBoxWiFi.Location = new System.Drawing.Point(334, 350);
            this.checkBoxWiFi.Name = "checkBoxWiFi";
            this.checkBoxWiFi.Size = new System.Drawing.Size(154, 26);
            this.checkBoxWiFi.TabIndex = 6;
            this.checkBoxWiFi.Text = "Наличие Wi-Fi";
            this.checkBoxWiFi.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // TourForm
            // 
            this.AcceptButton = this.buttonOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(636, 450);
            this.Controls.Add(this.checkBoxWiFi);
            this.Controls.Add(this.numericUpDownSurcharges);
            this.Controls.Add(this.numericUpDownNumberOfVacationer);
            this.Controls.Add(this.numericUpDownCostVacationer);
            this.Controls.Add(this.numericUpDownNumberOfNights);
            this.Controls.Add(this.dateTimePickerDepartureDate);
            this.Controls.Add(this.comboBoxDirection);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TourForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Параметры туров";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumberOfNights)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCostVacationer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumberOfVacationer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSurcharges)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePickerDepartureDate;
        private System.Windows.Forms.NumericUpDown numericUpDownNumberOfNights;
        private System.Windows.Forms.NumericUpDown numericUpDownCostVacationer;
        private System.Windows.Forms.NumericUpDown numericUpDownNumberOfVacationer;
        private System.Windows.Forms.NumericUpDown numericUpDownSurcharges;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.CheckBox checkBoxWiFi;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        public System.Windows.Forms.ComboBox comboBoxDirection;
    }
}