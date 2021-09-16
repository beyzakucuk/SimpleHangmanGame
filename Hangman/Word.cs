using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    class Word
    {
        public string[] _sWordsArray = File.ReadAllLines("Kelimeler.txt", Encoding.GetEncoding(1254)); // for words
        public string _sWord; // control for property 
        Random _rnd; // for random word
        /// <summary>
        /// Default constructor method to parametres are diffusiveness for some object 
        /// </summary>
        public Word()
        {

        }
        /// <summary>
        /// Constructor method with parametres to parametres are necessary for some object 
        /// </summary>
        /// <param name="bReferencesControl"> control for references object
        /// <param name="iCountOfLetter"> hiding place for count of letter if specified
        public Word(bool bReferencesControl,int iCountOfLetter)
        {
           retry:
                _rnd = new Random();
                int iRandomIndex = _rnd.Next(0, _sWordsArray.Length);
                if (bReferencesControl == false)
                {
                //Random word of specified length for ask to user
                    for (int i = 0; i < _sWordsArray.Length; i++)
                    {
                        if (_sWordsArray[iRandomIndex].Length == iCountOfLetter)
                        {
                            _sWord = _sWordsArray[iRandomIndex];
                            break;
                        }
                        else
                            iRandomIndex = _rnd.Next(0, _sWordsArray.Length);

                    }
                }
                else
                {
                //Random word for ask to user
                    _sWord = _sWordsArray[iRandomIndex];
                }

                // Ban for ask to empty word
           if (String.IsNullOrEmpty(_sWord))
                goto retry;
            
        }
        //Property for storage asked word 
        public string AskedWord
        {
            get
            {
                return _sWord ;
            }
            
        }
        /// <summary>
        /// Method, add word to file
        /// </summary>
        /// <param name="sWord"> storage for will add word
        public void Add(string sWord)
        {
            FileStream fs = new FileStream("Kelimeler.txt", FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(sWord);
            sw.Flush();
            sw.Close();
            fs.Close();
        }
        /// <summary>
        /// Method, remove word to file
        /// </summary>
        /// <param name="sWord"> storage for will remove word
        public void Remove(string sWord)
        {
            //Remove file content
            FileStream fs = new FileStream("Kelimeler.txt", FileMode.Truncate, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            //Again write to file but except wanted to remove word 
            for (int i = 0; i < _sWordsArray.Length; i++)
            {
                if (_sWordsArray[i] == sWord)
                {

                }
                else
                    sw.WriteLine(_sWordsArray[i]);
            }
            sw.Flush();
            sw.Close();
            fs.Close();
        }

    }
}
