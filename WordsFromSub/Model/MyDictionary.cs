using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace WordsFromSub
    {
    //   my dictionary
    static class MyDictionary
        {
        public static int Count { get { return _wordBase.Count; } }// TODO: нужен?
        static public List<Word> GetAllWords()
            {
            /// рушим инкапсуляцию ?!
            ///   if (_wordBase.Count > 0)
            ///   {
            /// List < Word > CloneWordBase = new List<Word>(_wordBase.Count);
            ///       foreach (var item in _wordBase)
            ///       {
            /// Word instance = item.Clone() as Word;
            /// CloneWordBase.Add(instance);
            ///       }
            ///       return CloneWordBase;
            ///   }
            ///   else
            ///   {
            /// List < Word > CloneWordBase = new List<Word>();
            ///       return CloneWordBase;
            ///   }
            ///
            return _wordBase;
            ///раньше было так
            ///  /*bool baseIntact = _wordBase.SequenceEqual(updatedWordsFromBase);
            ///  if (baseIntact)
            ///  {
            ///      _wordBase = updatedWordsFromBase;
            ///  }*/
            }
        static public void AddWordsFromFile(string filePath)
            {
            if(File.Exists(filePath) == true)
                {
                List<string> wordFromFile = SubtitleCleaner.GetCleanList(filePath);
                int addedWords = AddWordsToBase(wordFromFile, filePath);
                if(addedWords > 0)
                    {
                    SortBase();
                    }
                }
            }
        static public List<Word> GetFilteredWords(WordStatus Status)
            {
            var result = from wB in _wordBase
                         where (int)wB.Status == (int)Status
                         select wB;
            List<Word> Words = result.ToList();
            return Words;
            }
        static public List<Word> GetFilteredWords(string filePath)
            {
            List<string> filePaths = GetPathsToFilesContainingWords();
            if(filePaths.Exists(x => x == filePath))
                {
                var result = from wB in _wordBase
                             where wB.FileContainingWord == filePath
                             select wB;
                List<Word> Words = result.ToList();
                return Words;
                }
            else
                {
                //нет слов полученных из этого файла
                List<Word> Words = new List<Word>();
                return Words;
                }

            }
        static public List<Word> GetFilteredWords(string addressFile, WordStatus Status)
            {
            List<string> addressesFile = GetPathsToFilesContainingWords();
            if(addressesFile.Exists(x => x == addressFile))
                {
                var result = from wB in _wordBase
                             where (int)wB.Status == (int)Status
                             && wB.FileContainingWord == addressFile
                             select wB;
                List<Word> Words = result.ToList();
                return Words;
                }
            else
                {
                //нет слов полученных из этого файла
                List<Word> Words = new List<Word>();
                return Words;
                }
            }
        static public List<string> GetPathsToFilesContainingWords()
            {
            List<string> addressesFile = _wordBase.GroupBy(x => x.FileContainingWord)
                .Select(g => g.Key)
                .ToList();
            return addressesFile;
            }
        static public void SaveBase()
            {
            /// читаем из файла в новый список проверяем новую базу
            /// необходима проверка всех слов из файла на присутствие если удалены
            /// объединяем два списка
            /// как удалить? -> добавить слово в архив для избежания повторного появления
            /// 
            //  SubtitleCleaner.GetCleanList(_wordBase);
            SerializeAndSave("xmlFile", _wordBase);
            }

        #region private
        private static List<Word> _wordBase;
        private const int capacityWordBase = 2048; // из первых субтитров получаем 1000-1500 слов это меньше 2^11. Дальше Capacity будет 4096
        static MyDictionary()
            {
            _wordBase = new List<Word>(capacityWordBase);
            _wordBase = ReadAndDeserialize("xmlFile");
            //_filePath = null;
            }

        static private int AddWordsToBase(List<string> words, string filePath)
            {
            List<Word> list = new List<Word>(); //проверить базу, а после добавить новые
            foreach(string word in words)
                {
                if(!_wordBase.Exists(x => x.WordName == word))
                    {
                    list.Add(new Word(word, filePath));
                    ///проверка(в ) на хорошое слово и возврат true or false
                    }
                }
            if(list.Count > 0)
                { _wordBase.AddRange(list); }
            return list.Count;
            }

        static private void SortBase()
            {
            ///v.1 
            _wordBase.Sort((x, y) => string.Compare(x.WordName, y.WordName));
            ///v.2
            ///получаем новый лист
            ///var newList = _wordBase.OrderBy(x => x.WordName).ToList(); // ToList optional
            }

        #endregion
        #region Сериализация/Десериализация
        static private void SerializeAndSave(string path, List<Word> data)
            {
            var serializer = new XmlSerializer(typeof(List<Word>));
            if(File.Exists(path) != true)
                {
                using(var writer = new StreamWriter(new FileStream(path, FileMode.Create, FileAccess.Write)))
                    {
                    serializer.Serialize(writer, data);
                    }
                }
            else
                {
                using(var writer = new StreamWriter(path))
                    {
                    serializer.Serialize(writer, data);
                    }
                }
            }

        static private List<Word> ReadAndDeserialize(string path)
            {
            var serializer = new XmlSerializer(typeof(List<Word>));
            if(File.Exists(path) != true)
                {
                using(var writer = new StreamWriter(new FileStream(path, FileMode.Create, FileAccess.Write)))
                    {
                    serializer.Serialize(writer, _wordBase);
                    }

                using(var reader = new StreamReader(path))
                    {
                    List<Word> list = (List<Word>)serializer.Deserialize(reader);
                    return list;
                    }
                }
            else
                {
                using(var reader = new StreamReader(path))
                    {
                    List<Word> list = (List<Word>)serializer.Deserialize(reader);
                    return list;
                    }
                }
            }
        #endregion
        }

    }
