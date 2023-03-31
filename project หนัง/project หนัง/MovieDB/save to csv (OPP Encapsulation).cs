using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace MovieDB
{
    //ใช้ OOP Encapsulation
    class DataGridViewExporter
    {
        // Properties
        public string FileName { get; set; }
        public string Filter { get; set; }
        public string Title { get; set; }

        // Methods
        public void ExportToCsv(DataGridView dataGridView)
        {
            // Create a new SaveFileDialog object to prompt the user for a filename and location to save the CSV file
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = Filter;
            saveFileDialog.Title = Title;
            saveFileDialog.ShowDialog();

            // Check if the user clicked the "Save" button in the SaveFileDialog
            if (saveFileDialog.FileName != "")
            {
                // Open a new StreamWriter to write to the selected file
                StreamWriter streamWriter = new StreamWriter(saveFileDialog.FileName);

                // Loop through each row in the DataGridView
                for (int i = 0; i < dataGridView.Rows.Count; i++)
                {
                    // Loop through each column in the DataGridView
                    for (int j = 0; j < dataGridView.Columns.Count; j++)
                    {
                        // Write the cell value to the StreamWriter, followed by a comma (except for the last column)
                        streamWriter.Write(dataGridView.Rows[i].Cells[j].Value.ToString());
                        if (j != dataGridView.Columns.Count - 1)
                        {
                            streamWriter.Write(",");
                        }
                    }
                    // Write a new line character after each row
                    streamWriter.WriteLine();
                }

                // Close the StreamWriter
                streamWriter.Close();

                // Display a message box indicating that the export was successful
                MessageBox.Show("Exported successfully!");
            }
        }
    }
}
