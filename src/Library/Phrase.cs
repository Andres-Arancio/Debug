//-------------------------------------------------------------------------
// <copyright file="Phrase.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------
using System.Collections;
using System.Text;

namespace WordsPhrases
{
    /// <summary>
    /// Frase compuesta por una o más palabras.
    /// </summary>
    public class Phrase
    {
        // Para uso interno; contiene la lista de palabras de la frase.
        private ArrayList words;

        /// <summary>
        /// Crea una nueva frase.
        /// </summary>
        public Phrase()
        {
            this.words = new ArrayList();
        }

        /// <summary>
        /// Agrega al final de la frase la palabra pasada como argumento.
        /// </summary>
        /// <param name="word">La palabra a agregar.</param>
        public void AddWord(Word word)
        {
            this.words.Add(word);
        }

        /// <summary>
        /// Remueve de la frase la palabra pasada como argumento
        /// </summary>
        /// <param name="word"></param>
        public void RemoveWord(Word word)
        {
            this.words.Remove(word);
        }

        /// <summary>
        /// Concatena las palabras de la frase.
        /// </summary>
        /// <returns>Las palabras de la frase concatenadas separadas por espacios.</returns>
        /// <value>Count hace de auxiliar para asegurarse que no sea la primera iteracion del foreach</value>
        public string GetPhrase()
        {
            StringBuilder phrase = new StringBuilder();
            int count = 0;

            foreach (Word word in this.words)
            {
                if(count!=0)
                {
                    phrase.Append(" ");
                }
                phrase.Append(word.Text);
                count++;
            }

            string result = phrase.ToString();

            // Remueve el primer espacio que se agrega siempre

            return result;
        }
    }
}