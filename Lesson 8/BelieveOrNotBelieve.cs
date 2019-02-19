using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Lesson_8
{
    public partial class BelieveOrNotBelieve : Form
    {
        // Класс для вопроса    
        [Serializable]
        public class Question
        {
            public string text;       // Текст вопроса
            public bool trueFalse;// Правда или нет
                                  // Здесь мы нарушаем правила инкапсуляции и эти поля нужно было бы реализовать через открытые свойства, но для упрощения примера оставим так
                                  // Вам же предлагается сделать поля закрытыми и реализовать открытые свойства Text и TrueFalse
                                  // Для сериализации должен быть пустой конструктор.
            public Question()
            {
            }
            public Question(string text, bool trueFalse)
            {
                this.text = text;
                this.trueFalse = trueFalse;
            }
        }
        // Класс для хранения списка вопросов. А также для сериализации в XML и десериализации из XML
        class TrueFalse
        {
            string fileName;
            List<Question> list;
            public string FileName
            {
                set { fileName = value; }
            }
            public TrueFalse(string fileName)
            {
                this.fileName = fileName;
                list = new List<Question>();
            }
            public void Add(string text, bool trueFalse)
            {
                list.Add(new Question(text, trueFalse));
            }
            public void Remove(int index)
            {
                if (list != null && index < list.Count && index >= 0) list.RemoveAt(index);
            }
            // Индексатор - свойство для доступа к закрытому объекту
            public Question this[int index]
            {
                get { return list[index]; }
            }
            public void Save()
            {
                XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Question>));
                Stream fStream = new FileStream(fileName, FileMode.Create, FileAccess.Write);
                xmlFormat.Serialize(fStream, list);
                fStream.Close();
            }
            public void Load()
            {
                XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Question>));
                Stream fStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                list = (List<Question>)xmlFormat.Deserialize(fStream);
                fStream.Close();
            }
            public int Count
            {
                get { return list.Count; }
            }
        }


        // База данных с вопросами
        TrueFalse database;
        public BelieveOrNotBelieve()
        {
            InitializeComponent();
        }

        
        
        // Обработчик пункта меню Exit
        private void miExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // Обработчик пункта меню New
        private void miNew_Click(object sender, EventArgs e)
        {
            //SaveFileDialog sfd = new SaveFileDialog();
            //if (sfd.ShowDialog() == DialogResult.OK)
            //{
            //    database = new TrueFalse(sfd.FileName);
            //    database.Add("123", true);
            //    database.Save();
            //    nudNumber.Minimum = 1;
            //    nudNumber.Maximum = 1;
            //    nudNumber.Value = 1;
            //};
        }
        // Обработчик события изменения значения numericUpDown
        private void nudNumber_ValueChanged(object sender, EventArgs e)
        {
            tboxQuestion.Text = database[(int)nudNumber.Value - 1].text;
            cboxTrue.Checked = database[(int)nudNumber.Value - 1].trueFalse;
        }
        // Обработчик кнопки Добавить
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (database == null)
            {
                MessageBox.Show("Создайте новую базу данных", "Сообщение");
                return;
            }
            database.Add((database.Count + 1).ToString(), true);
            nudNumber.Maximum = database.Count;
            nudNumber.Value = database.Count;
        }
        // Обработчик кнопки Удалить
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (nudNumber.Maximum == 1 || database == null) return;
            database.Remove((int)nudNumber.Value);
            nudNumber.Maximum--;
            if (nudNumber.Value > 1) nudNumber.Value = nudNumber.Value;
        }
        // Обработчик пункта меню Save
        private void miSave_Click(object sender, EventArgs e)
        {
            if (database != null) database.Save();
            else MessageBox.Show("База данных не создана");
        }
        // Обработчик пункта меню Open
        private void miOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                database = new TrueFalse(ofd.FileName);
                database.Load();
                nudNumber.Minimum = 1;
                nudNumber.Maximum = database.Count;
                nudNumber.Value = 1;
            }
        }
        // Обработчик кнопки Сохранить (вопрос)
        private void btnSaveQuest_Click(object sender, EventArgs e)
        {
            database[(int)nudNumber.Value - 1].text = tboxQuestion.Text;
            database[(int)nudNumber.Value - 1].trueFalse = cboxTrue.Checked;
        }

        private void miOpen_Click_1(object sender, EventArgs e)
        {

        }

        
    }
}
