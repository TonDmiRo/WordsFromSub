using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace WordsFromSub
    {
    public static class SubtitleCleaner
        {
        static public List<string> GetCleanList(string addressSub)
            {
            if(File.Exists(addressSub))
                {
                List<string> m_dirtyList = RemoveSymbolsFromFile(addressSub);
                m_dirtyList = RemoveDouble(m_dirtyList);
                m_dirtyList = Order(m_dirtyList);

                //TODO:добавить методы-фильты

                return m_dirtyList;
                }
            else
                {
                return new List<string>();
                }
            }

        #region фильтры
        static private List<string> RemoveSymbolsFromFile(string fileAddress)
            {

            //TODO: три одинаковых символа
            List<string> m_dirtyList = new List<string>();
            string[] allText = File.ReadAllLines(fileAddress);//чтение всех строк файла в массив строк
            Regex regex = new Regex(@"[a-zA-Z-]{3,27}");
            foreach(string s in allText)
                {
                MatchCollection matches = regex.Matches(s);
                if(matches.Count > 0)
                    {
                    foreach(Match match in matches)
                        {
                        //создаем список слов из текста. > 2 символов в нижнем регистре
                        m_dirtyList.Add(match.Value.ToLower());
                        }
                    }
                }
            return m_dirtyList;
            }
        static private List<string> RemoveDouble(List<string> m_dirtyList)
            {
            List<string> list = m_dirtyList.Distinct().ToList();
            return list;
            }
        static private List<string> Order(List<string> m_dirtyList)
            {
            m_dirtyList.Sort();
            //List<string> list = m_dirtyList;

            return m_dirtyList;
            }

        ///TODO: можно добавить фильтры по словообразованию
        ///убрать ing
        ///убрать mant
        ///три одинаковых символа
        #endregion
        }
    }
