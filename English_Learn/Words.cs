using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace English_Learn
{
   public class Word
    {
        private string _engl_word;
        private string _ukr_word;
       public Word(string english_word,string ukraine_word)
        {
            _engl_word = english_word;
            _ukr_word = ukraine_word;
        }
        public string English_World
        {
            get => _engl_word;
        }
        public string Ukraine_word
        {
            get => _ukr_word;
        }
        public override string ToString()
        {
            return _engl_word + " | " + _ukr_word;
        }
        public string ForSort()
        {
            return English_World + "/" + Ukraine_word;
        }
        public string ForText()
        {
            return "."+_engl_word + "|" + _ukr_word ;
        }
        static public bool operator ==(Word word1, Word word2)
        {
            return word1.English_World == word2.English_World;
        }
        static public bool operator !=(Word word1, Word word2)
        {
            return word1.English_World != word2.English_World && word1.Ukraine_word != word2.Ukraine_word;
        }
        static public bool operator ==(Word word,string Text)
        {
            return word.English_World == Text || word.Ukraine_word==Text;
        }
        static public bool operator !=(Word word, string English_word)
        {
            return word.English_World != English_word || word.Ukraine_word!=English_word ;
        }

    }
    public class Words
    {
        private List<Word> _words = new List<Word>();
        private Random rnd = new Random();

        public Words(List<Word> _words)
        {
            this._words = _words;

        }
        public Words()
        {
            
        }
        public void Add_Word(Word word)
        {
            _words.Add(word);
        }
        public List<Word> List_Words
        {
            get => _words;
        }
        public Word Random_Word()
        {
            int index = rnd.Next(_words.Count);
            return _words[index];
        }
        public int FindIndexWord(Word find_word) 
        {
            for (int i=0;i<_words.Count;i++)
            {
                if (find_word == _words[i])
                {
                    return i;
                }
                
            }
            return -1;
        }
        public List<Word>  Sort()
        {
            List<Word> Sorted_words = new List<Word>();
           List<string>  Text = new List<string>();

            foreach (var word in _words)
            {
                Text.Add(word.ForSort());
            }
            Text.Sort();
            string ukr = "";
            string eng = "";
            foreach(var txt in Text)
            {
                ukr = "";
                eng = "";
                bool isSlesh = false;
                foreach(var number in txt)
                {
                    if (number != '/')
                    {
                        if (isSlesh)
                        {
                            ukr += number;
                        }
                        else
                        {
                            eng += number;
                        }
                    }
                    else
                    {
                        isSlesh = true;
                    }
                }
                Word word = new Word(eng, ukr);
                Sorted_words.Add(word);
            }
            return Sorted_words;
        }
        public List<Word> Random_Words(int n)
        {
            List<Word> rndwords = new List<Word>();
            for (int i = 0; i < n; i++) {
                Word word = new Word("1","1");
                rndwords.Add(word);
            }
            Word rndword = Random_Word();


            for(int i=0;i<n;i++)
            {

                rndword = Random_Word();
                bool iscancontinue = true;
                while (iscancontinue)
                {
                    foreach (var word in rndwords)
                    {
                        if (rndword == word)
                        {
                            rndword = Random_Word();
                            continue;
                        }
                    }
                    iscancontinue = false;
                }
                rndwords[i]=rndword;
            }
            return rndwords;
        }
        public void Delete_Word(int index_word)
        {
            _words.RemoveAt(index_word);

        }
        public Word this[int index]
        {
            get
            {
                return _words[index];

            }
        }
       

    }
}
