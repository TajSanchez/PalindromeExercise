using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeExercise
{
    public class WordSmith
    {

        public bool IsAPalindrome(string word)
        { 
            //reverse the word to see if it is the same after reversed
            var reversed = word.Reverse();
          if (reversed != word) 
            {   
                 
                return word.SequenceEqual(word.Reverse());
               //when I return false, it does not pass 4 out of the 7 tests I am going to look more into this
            }

            return true;
                
                //bool.Parse(word);
            

            //compare with the original
            //return whether true/false
           
            
        }
    }
}
