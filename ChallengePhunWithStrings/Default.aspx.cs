using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengePhunWithStrings
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            // 1. Reverse your name
            string name = "Yohei Kubo";
            
            // Should be "obuK iehoY"
            for (int i = name.Length - 1; i> -1; i--)
            {
                resultLabel1.Text += name[i].ToString();
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            // Reverse this sequence
            string names = "Luke,Leia,Han,Chewbacca";
            string[] nameArray = names.Split(',');

            for (int i = nameArray.GetUpperBound(0); i > -1; i--)
            {
                resultLabel2.Text += nameArray[i];

                if (i > 0) resultLabel2.Text += ",";
            }
            
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            // 3. Use the sequence to create ascii art:
            // *****luke*****
            // *****leia*****
            // *****han******
            // **Chewbacca***

            string names = "Luke,Leia,Han,Chewbacca";
            string[] nameArray = names.Split(',');

            for (int i = 0; i < nameArray.Length; i++)
            {
                string result = "";
                int nameLength = nameArray[i].Length;
                int padLeft = (14 - nameLength) / 2;  //Determin padleft first
                int padRight = 14 - nameLength - padLeft;  // Padright is defference between padleft and 14

                // Padding Left first
                result = nameArray[i].PadLeft(nameLength + padLeft, '*');

                // Padding Right 
                result = result.PadRight(14, '*');

                resultLabel3.Text += result;
                resultLabel3.Text += "<br />";
            }


        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            // Solve this puzzle

            string puzzle = "NOW IS ZHEremove-me ZIME FOR ALL GOOD MEN ZO COME ZO ZHE AID OF ZHEIR COUNZRY.";

            // Once you fix it with string helper methods, it should read:
            // Now is the time for all good men to come tothe aid of their county.

            // Remove "remove-me"
            puzzle = removeRemoveMe(puzzle);

            // Replace "Z" to "T"
            puzzle = replaceZtoT(puzzle);

            // Get lower a whole sentence
            puzzle = puzzle.ToLower();

            // Get upper a first letter
            puzzle = upperFirstLetter(puzzle);

            // Display result
            resultLabel4.Text = puzzle;
        }

        private string removeRemoveMe(string puzzle)
        {
            string removeMe = "remove-me";
            string sentence = puzzle.Remove(puzzle.IndexOf(removeMe), removeMe.Length);

            return sentence;
        }

        private string replaceZtoT(string puzzle)
        {
            string sentence = puzzle.Replace("Z", "T");

            return sentence;
        }

        private string upperFirstLetter(string puzzle)
        {
            string upperFirstLetter = puzzle[0].ToString().ToUpper();

            string sentence = puzzle;
            sentence = sentence.Remove(0, 1);
            sentence = sentence.Insert(0, upperFirstLetter);

            return sentence;

        }


    }
}