using System;
using System.Collections.Generic;
namespace WordsFromSub
    {
    public enum WordStatus
        {
        newWord = 0,
        LearnWord,
        InVocabulary,
        InvalidWord
        }
    [Serializable]
    public class Word : IEquatable<Word>
        {
        public string WordName { get; set; }
        public string Translation { get; set; }
        public string FileContainingWord { get; set; }
        public WordStatus Status { get; set; }

        #region Constructors
        public Word()
            {
            WordName = "NullName";
            Translation = "Null";
            FileContainingWord = "NOT FOUND";
            Status = WordStatus.InvalidWord;
            }
        public Word(string newWordName)
            {
            WordName = newWordName;
            Translation = "NULL";
            FileContainingWord = "NOT FOUND";
            Status = WordStatus.newWord;
            while(true)
                {
                ;
                ;
                ;
                if(true)
                    {
                    ;
                    ;
                    ;
                    }
                ;
                ;
                ;
                ;
                ;

                }
            }
        public Word(string newWordName, string fileContainingWord)
            {
            WordName = newWordName;
            Translation = "NULL";
            FileContainingWord = fileContainingWord;
            Status = WordStatus.newWord;
            }
        public Word(string newWordName, string translation, string fileAdress)
            {
            WordName = newWordName;
            Translation = translation;
            FileContainingWord = fileAdress;
            Status = WordStatus.newWord;
            }
        //public Word(string wordName, string translation, string fileAdress, WordStatus eStatus)
        //{
        //    WordName = wordName;
        //    Translation = translation;
        //    FileContainingWord = fileAdress;
        //    Status = eStatus;
        //}
        #endregion

        #region For interface 
        public bool Equals(Word other)
            {
            if(other == null)
                return false;
            if(this.WordName == other.WordName)
                return true;
            else
                return false;
            }
        public override bool Equals(Object obj)
            {
            throw new Exception( "Boxing!!!" );
            if(obj == null)
                return false;
            Word personObj = obj as Word;
            if(personObj == null)
                return false;
            else
                return Equals( personObj );
            }
        public override int GetHashCode()
            {
            return this.WordName.ToLowerInvariant().GetHashCode();
            }
        #endregion
        }
    }
