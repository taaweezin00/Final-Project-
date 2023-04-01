# Final-Project-
อธิบายการทำงานของโปรแกรมลงบนไฟล์ readme.md ที่อยู่ใน repository ของโปรเจค (5 คะแนน)



aความเป็นมาของโปรแกรม
มาจากตัวเองที่ชอบดูหนัง แล้วคิดว่า เฮ้ยลองเขาโปรแกรมหนังหน่อยซิ
ก็เลยออกมาเป็นอิท่านี้ครับ



bวัตถุประสงค์ของโปรแกรม
ใช้ในการเพิ่มรายการภาพยนต์ ลงไปใน DataBase อาจใช้ในการ List ภาพยนต์ ที่ต้องการดู หรือ ใช้เป็น สุ่มประเถทหนังที่ต้องการจะดู 


cใช้ในการเพิ่มข้อมูลภาพยนต์ Title(ชื่อเรื่อง) Publisher(ค่ายที่สร้างภาพยนต์ เช่น marvel) Year(ปีที่ผลิต) 



fโครงสร้างของโปรแกรม (Class diagram) ของโปรแกรม ใช้ Mermaid ในการเขียน ตัวอย่าง การเขียน Classdiagram ใน Markdown

---
title: MovieDB (Movie DataBase)
---

classDiagram
    class Form1 {
        - dataGridView1 : DataGridView
        - InfoTextBox : TextBox
        - _wordGenerator : RandomWordGenerator
        + button6_Click(sender: object, e: EventArgs)
        + loadDataGrid(queryString: string)
        + button6_KeyDown(sender: object, e: KeyEventArgs)
        + tabControl1_SelectedIndexChanged(sender: object, e: EventArgs)
        + button10_Click(sender: object, e: EventArgs)
        + button7_Click(sender: object, e: EventArgs)
        + button8_Click(sender: object, e: EventArgs)
    }
    class Exporter {
        + Export(dataGridView: DataGridView)
    }
    class TxtExporter {
        + Export(dataGridView: DataGridView)
    }
    class DataGridViewExporter {
        - _fileName : string
        - _filter : string
        - _title : string
        + FileName : string
        + Filter : string
        + Title : string
        + ExportToCsv(dataGridView: DataGridView)
    }
    class RandomWordGenerator {
        + Generate() : string
    }
    class movie {
        - movieID : int
        - Title : string
        - Publisher : string
        - Previewed : bool
        - MovieYear : int
        - typeID : int
    }
    class movieType {
        - typeID : int
        - Type : string
    }
    Form1 --> DataGridView
    Form1 --> TextBox
    Form1 --> RandomWordGenerator
    Form1 --> Exporter
    Exporter <|-- TxtExporter
    Exporter <|-- DataGridViewExporter
    movie --> movieType


class Form2 {
    - string year
    - string publisher
    - string title
    - string previewed
    - string type
    - int movieID
    + Form2()
    + void Form2_Load(object sender, EventArgs e)
    + void button6_Click(object sender, EventArgs e)
    + void button6_KeyDown(object sender, KeyEventArgs e)
}




classDiagram1
    class RandomWordGenerator{
        - _words: string[]
        - _random: Random
        + RandomWordGenerator(words: string[])
        + Generate(): string
    }

classDiagram2
    class Exporter{
        {abstract} + Export(dataGridView: DataGridView): void
    }

    class TxtExporter{
        + Export(dataGridView: DataGridView): void
    }

    class SaveFileDialog{
        - FileName: string
        - Filter: string
        - Title: string
        + ShowDialog(): DialogResult
    }

    class StreamWriter{
        + StreamWriter(path: string): void
        + Write(value: string): void
        + WriteLine(): void
        + Close(): void
    }

    class DataGridView{
        + ColumnCount: int
        + RowCount: int
        + Columns: DataGridViewColumnCollection
        + Rows: DataGridViewRowCollection
    }

    class DataGridViewColumnCollection{
        + Item(index: int): DataGridViewColumn
    }

    class DataGridViewRowCollection{
        + Item(index: int): DataGridViewRow
    }

    class DataGridViewColumn{
        + HeaderText: string
    }

    class DataGridViewRow{
        + Cells: DataGridViewCellCollection
    }

    class DataGridViewCellCollection{
        + Item(index: int): DataGridViewCell
    }

    class DataGridViewCell{
        + Value: object
    }

    class MessageBox{
        + Show(message: string): DialogResult
    }
    
    
    
    classDiagram3
    class DataGridViewExporter{
        -FileName: string
        -Filter: string
        -Title: string
        +ExportToCsv(DataGridView dataGridView): void
    }

    DataGridViewExporter --|> SaveFileDialog
    SaveFileDialog --> StreamWriter
    DataGridViewExporter "1" --> "n" DataGridView
    StreamWriter --> "Exported successfully!" : Show message box






dชื่อของผู้พัฒนาโปรแกรม
ทวีศิลป์ ใจดี 653450509-5
