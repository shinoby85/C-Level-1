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




        public BelieveOrNotBelieve()
        {
            InitializeComponent();
        }

        private void BelieveOrNotBelieve_Load(object sender, EventArgs e)
        {

        }
    }
}
