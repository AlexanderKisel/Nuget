using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataGrid_Kisel.Models;

namespace DataGrid_Kisel
{
    public partial class Form1 : Form
    {
        private NugetForGrid.NugetKisel<Student> nug;
        private readonly BindingSource bindingSource;

        public Form1()
        {
            InitializeComponent();


            dataGridView1.AutoGenerateColumns = false;
            nug = new NugetForGrid.NugetKisel<Student>();
            bindingSource = new BindingSource();
            bindingSource.DataSource = nug.Get();
            dataGridView1.DataSource = bindingSource;
        }

        private void ToolStripMenuItemExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ToolStripMenuItemProg_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программа, сделанная Кисель А.И. ", "О программе",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void toolStripButtonAdd_Click(object sender, EventArgs e)
        {
            var stdInfoForm = new FormStudentInfo();
            stdInfoForm.Text = "Добавление студента";
            if (stdInfoForm.ShowDialog(this) == DialogResult.OK)
            {
                stdInfoForm.Student.Id = Guid.NewGuid();
                nug.Add(stdInfoForm.Student);
                bindingSource.ResetBindings(false);
                CountStd();
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "sumbal")
            {
                var data = (Student)dataGridView1.Rows[e.RowIndex].DataBoundItem;
                e.Value = data.Russia + data.Math + data.Inform;
            }
            if (dataGridView1.Columns[e.ColumnIndex].Name == "GenderColumn")
            {
                var val = (Gender)e.Value;
                switch (val)
                {
                    case Gender.Male:
                        e.Value = "Мужчина";
                        break;
                    case Gender.Female:
                        e.Value = "Женщина";
                        break;
                }
            }
            if (dataGridView1.Columns[e.ColumnIndex].Name == "FormStudyCollumn")
            {
                var val = (FormStudy)e.Value;
                switch (val)
                {
                    case FormStudy.Och:
                        e.Value = "Очная";
                        break;
                    case FormStudy.Zaoch:
                        e.Value = "Заочная";
                        break;
                    case FormStudy.Och_Zaoch:
                        e.Value = "Очно-заочная";
                        break;
                }
            }
        }

        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 &&
                e.RowIndex >= 0 &&
                dataGridView1.Columns[e.ColumnIndex].Name == "AvgRColumn")
            {
                e.PaintBackground(e.ClipBounds, true);
                var val = decimal.Parse(e.Value.ToString());
                var resultW = (float)(val * e.CellBounds.Width) / 5.0f;
                if (val <= 2)
                {
                    e.Graphics.FillRectangle(Brushes.Red, e.CellBounds.X, e.CellBounds.Y, resultW, e.CellBounds.Height);
                }
                else if (2 < val && val <= 4)
                {
                    e.Graphics.FillRectangle(Brushes.Yellow, e.CellBounds.X, e.CellBounds.Y, resultW, e.CellBounds.Height);
                }
                else if (val > 4)
                {
                    e.Graphics.FillRectangle(Brushes.Green, e.CellBounds.X, e.CellBounds.Y, resultW - 1, e.CellBounds.Height - 1);
                }
                //e.Graphics.DrawRectangle(Pens.Red, e.CellBounds.X, e.CellBounds.Y, resultW, e.CellBounds.Height);
                e.Handled = true;
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            toolStripButtonChange.Enabled =
                toolStripButtonDelete.Enabled =
                ToolStripMenuItemChange.Enabled =
                ToolStripMenuItemDelete.Enabled =
                dataGridView1.SelectedRows.Count > 0;
        }

        private void toolStripButtonDelete_Click(object sender, EventArgs e)
        {
            var data = (Student)dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].DataBoundItem;
            if (MessageBox.Show($"Вы действительно хотите удалить '{data.FullName}'?",
                    "Удаление записи",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                nug.Remove(data);
                bindingSource.ResetBindings(false);
            }
            CountStd();
        }

        private void toolStripButtonChange_Click(object sender, EventArgs e)
        {
            var data = (Student)dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].DataBoundItem;
            var infoForm = new FormStudentInfo(data);
            infoForm.Text = "Редактирование студента";
            if (infoForm.ShowDialog(this) == DialogResult.OK)
            {
                nug.Change(data, infoForm.Student);
                bindingSource.ResetBindings(false);
                CountStd();
            }
        }

        public void CountStd()
        {
            toolStripStatusLabel2.Text = $"Количество абитуриентов: {nug.Get().Count()}";
            toolStripStatusLabel1.Text = $"Кол-во студентов с суммой баллов больше 150: {nug.Get().Where(pE => pE.Math + pE.Russia + pE.Inform > 150).Count()}";
        }

        private void ToolStripMenuItemChange_Click(object sender, EventArgs e)
        {
            var data = (Student)dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].DataBoundItem;
            var infoForm = new FormStudentInfo(data);
            infoForm.Text = "Редактирование студента";
            if (infoForm.ShowDialog(this) == DialogResult.OK)
            {
                nug.Change(data, infoForm.Student);
                bindingSource.ResetBindings(false);
                CountStd();
            }
        }

        private void ToolStripMenuItemDelete_Click(object sender, EventArgs e)
        {
            var data = (Student)dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].DataBoundItem;
            if (MessageBox.Show($"Вы действительно хотите удалить '{data.FullName}'?",
                    "Удаление записи",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                nug.Get().Remove(data);
                bindingSource.ResetBindings(false);
            }
            CountStd();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
