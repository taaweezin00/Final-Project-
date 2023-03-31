using System;
using System.IO;
using System.Windows.Forms;

namespace ExportGridView
{
    public abstract class Exporter
    {
        public abstract void Export(DataGridView dataGridView);
    }

    public class TxtExporter : Exporter
    {
        public override void Export(DataGridView dataGridView)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt";
            saveFileDialog.Title = "Export to Text File";
            saveFileDialog.ShowDialog();

            if (saveFileDialog.FileName != "")
            {
                StreamWriter streamWriter = new StreamWriter(saveFileDialog.FileName);

                for (int i = 0; i < dataGridView.ColumnCount; i++)
                {
                    streamWriter.Write(dataGridView.Columns[i].HeaderText + "\t");
                }

                streamWriter.WriteLine();

                for (int i = 0; i < dataGridView.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView.Columns.Count; j++)
                    {
                        streamWriter.Write(dataGridView.Rows[i].Cells[j].Value.ToString() + "\t");
                    }

                    streamWriter.WriteLine();
                }

                streamWriter.Close();

                MessageBox.Show("Exported Successfully!");
            }
        }
    }
}
