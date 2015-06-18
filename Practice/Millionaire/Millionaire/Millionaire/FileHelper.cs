using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.ServiceModel;

namespace GameContract
{
    public class FileHelper
    {
        public string FileName { get; set; }
        List<Question> _questions;
        FileStream _fs;
        StreamReader _sw;
        public FileHelper(string name) { FileName = name; }
        public FileHelper() { FileName = ""; }

        public List<Question> QuestionLoadFromFile()
        {
            _fs = new FileStream(FileName, FileMode.Open, FileAccess.Read);
            _sw = new StreamReader(_fs);
            _questions = new List<Question>();
            List<string> lines = new List<string>();
            string s = _sw.ReadLine();
            while (s != null)
            {
                if (s != "**********") lines.Add(s);
                else
                {
                    List<Answer> options = new List<Answer>();
                    for (int i = 2; i<6; i++)
                    {
                        options.Add(new Answer(i-1,lines[i]));
                    }
                    Question newquestion = new Question(int.Parse(lines[0]), lines[1], lines[6]);
                    
                    foreach (Answer a in options)
                    {
                        newquestion.Options.Add(a);
                    }
                    //newquestion.GameplayCallback = OperationContext.Current.GetCallbackChannel<IGameplayCallback>();
                    _questions.Add(newquestion);
                    lines.Clear();
                }
                s = _sw.ReadLine();
            }
            return _questions;
        }
    }
}
