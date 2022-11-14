
namespace DataGrid_Kisel
{
    partial class FormStudentInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStudentInfo));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblInfo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblFIO = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblDayB = new System.Windows.Forms.Label();
            this.lblAvg = new System.Windows.Forms.Label();
            this.textBoxFio = new System.Windows.Forms.TextBox();
            this.dateTimePickerDayB = new System.Windows.Forms.DateTimePicker();
            this.comboBoxGender = new System.Windows.Forms.ComboBox();
            this.numericUpDownMath = new System.Windows.Forms.NumericUpDown();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownRussia = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownInform = new System.Windows.Forms.NumericUpDown();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMath)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRussia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownInform)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.lblInfo);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(491, 143);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblInfo.Location = new System.Drawing.Point(138, 52);
            this.lblInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(297, 29);
            this.lblInfo.TabIndex = 1;
            this.lblInfo.Text = "Информация о студенте";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(14, 14);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(117, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblFIO
            // 
            this.lblFIO.AutoSize = true;
            this.lblFIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFIO.Location = new System.Drawing.Point(15, 173);
            this.lblFIO.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFIO.Name = "lblFIO";
            this.lblFIO.Size = new System.Drawing.Size(102, 16);
            this.lblFIO.TabIndex = 1;
            this.lblFIO.Text = "ФИО студента";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGender.Location = new System.Drawing.Point(15, 219);
            this.lblGender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(33, 16);
            this.lblGender.TabIndex = 2;
            this.lblGender.Text = "Пол";
            // 
            // lblDayB
            // 
            this.lblDayB.AutoSize = true;
            this.lblDayB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDayB.Location = new System.Drawing.Point(15, 265);
            this.lblDayB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDayB.Name = "lblDayB";
            this.lblDayB.Size = new System.Drawing.Size(107, 16);
            this.lblDayB.TabIndex = 3;
            this.lblDayB.Text = "Дата Рождения";
            // 
            // lblAvg
            // 
            this.lblAvg.AutoSize = true;
            this.lblAvg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAvg.Location = new System.Drawing.Point(15, 312);
            this.lblAvg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAvg.Name = "lblAvg";
            this.lblAvg.Size = new System.Drawing.Size(117, 16);
            this.lblAvg.TabIndex = 4;
            this.lblAvg.Text = "Форма обучения";
            // 
            // textBoxFio
            // 
            this.textBoxFio.Location = new System.Drawing.Point(196, 168);
            this.textBoxFio.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxFio.Name = "textBoxFio";
            this.textBoxFio.Size = new System.Drawing.Size(250, 23);
            this.textBoxFio.TabIndex = 7;
            this.textBoxFio.TextChanged += new System.EventHandler(this.textBoxFio_TextChanged);
            // 
            // dateTimePickerDayB
            // 
            this.dateTimePickerDayB.Location = new System.Drawing.Point(196, 261);
            this.dateTimePickerDayB.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dateTimePickerDayB.Name = "dateTimePickerDayB";
            this.dateTimePickerDayB.Size = new System.Drawing.Size(250, 23);
            this.dateTimePickerDayB.TabIndex = 9;
            this.dateTimePickerDayB.Value = new System.DateTime(2022, 11, 12, 0, 0, 0, 0);
            this.dateTimePickerDayB.ValueChanged += new System.EventHandler(this.dateTimePickerDayB_ValueChanged);
            // 
            // comboBoxGender
            // 
            this.comboBoxGender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGender.FormattingEnabled = true;
            this.comboBoxGender.Location = new System.Drawing.Point(196, 212);
            this.comboBoxGender.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBoxGender.Name = "comboBoxGender";
            this.comboBoxGender.Size = new System.Drawing.Size(250, 24);
            this.comboBoxGender.TabIndex = 10;
            this.comboBoxGender.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.comboBoxDayB_DrawItem);
            this.comboBoxGender.SelectedIndexChanged += new System.EventHandler(this.comboBoxGender_SelectedIndexChanged);
            // 
            // numericUpDownMath
            // 
            this.numericUpDownMath.DecimalPlaces = 2;
            this.numericUpDownMath.Location = new System.Drawing.Point(196, 350);
            this.numericUpDownMath.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.numericUpDownMath.Name = "numericUpDownMath";
            this.numericUpDownMath.Size = new System.Drawing.Size(251, 23);
            this.numericUpDownMath.TabIndex = 11;
            this.numericUpDownMath.ValueChanged += new System.EventHandler(this.numericUpDownAvg_ValueChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.buttonCancel);
            this.panel2.Controls.Add(this.buttonSave);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 515);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(491, 115);
            this.panel2.TabIndex = 14;
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(359, 45);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(88, 27);
            this.buttonCancel.TabIndex = 16;
            this.buttonCancel.Text = "Закрыть";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            this.buttonSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonSave.Enabled = false;
            this.buttonSave.Location = new System.Drawing.Point(265, 45);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(88, 27);
            this.buttonSave.TabIndex = 15;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(15, 354);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "ЕГЭ математика";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(15, 396);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "ЕГЭ русский";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(15, 437);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "ЕГЭ информатика";
            // 
            // numericUpDownRussia
            // 
            this.numericUpDownRussia.DecimalPlaces = 2;
            this.numericUpDownRussia.Location = new System.Drawing.Point(196, 391);
            this.numericUpDownRussia.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.numericUpDownRussia.Name = "numericUpDownRussia";
            this.numericUpDownRussia.Size = new System.Drawing.Size(251, 23);
            this.numericUpDownRussia.TabIndex = 18;
            this.numericUpDownRussia.ValueChanged += new System.EventHandler(this.numericUpDownRussia_ValueChanged);
            // 
            // numericUpDownInform
            // 
            this.numericUpDownInform.DecimalPlaces = 2;
            this.numericUpDownInform.Location = new System.Drawing.Point(196, 433);
            this.numericUpDownInform.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.numericUpDownInform.Name = "numericUpDownInform";
            this.numericUpDownInform.Size = new System.Drawing.Size(251, 23);
            this.numericUpDownInform.TabIndex = 19;
            this.numericUpDownInform.ValueChanged += new System.EventHandler(this.numericUpDownInform_ValueChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(196, 312);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(250, 24);
            this.comboBox1.TabIndex = 20;
            this.comboBox1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.comboBox1_DrawItem);
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // FormStudentInfo
            // 
            this.AcceptButton = this.buttonSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(491, 630);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.numericUpDownInform);
            this.Controls.Add(this.numericUpDownRussia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.numericUpDownMath);
            this.Controls.Add(this.comboBoxGender);
            this.Controls.Add(this.dateTimePickerDayB);
            this.Controls.Add(this.textBoxFio);
            this.Controls.Add(this.lblAvg);
            this.Controls.Add(this.lblDayB);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblFIO);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormStudentInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Информация о студенте";
            this.Load += new System.EventHandler(this.FormStudentInfo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMath)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRussia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownInform)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblFIO;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblDayB;
        private System.Windows.Forms.Label lblAvg;
        private System.Windows.Forms.TextBox textBoxFio;
        private System.Windows.Forms.DateTimePicker dateTimePickerDayB;
        private System.Windows.Forms.ComboBox comboBoxGender;
        private System.Windows.Forms.NumericUpDown numericUpDownMath;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownRussia;
        private System.Windows.Forms.NumericUpDown numericUpDownInform;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}
