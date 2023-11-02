using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PersonalDiary.Utils
{
    public class Validation
    {
        /// <summary>
        /// Validate string from user's input
        /// </summary>
        /// <param name="value">String from user's input</param>
        /// <param name="regex">Pattern of regex to validate</param>
        /// <param name="min">Minimun required length of string</param>
        /// <param name="max">Maximum required length of string</param>
        /// <param name="placeHolder">Name of the place holder</param>
        /// <param name="regexMsg">Error message when string does not match regex</param>
        /// <returns>True if valid, otherwise false</returns>
        public bool ValidateString(string value, string regex, string placeHolder, string regexMsg)
        {
            if (string.IsNullOrEmpty(value))
            {
                MessageBox.Show(
                    "Please enter " + placeHolder
                    , "Error"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Error);
                return false;
            }
            if (!new Regex(regex).IsMatch(value))
            {
                MessageBox.Show(
                    placeHolder + " requires :\n" + regexMsg
                    , "Error"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Error);
                return false;
            }
            //if (value.Trim().Length < min || value.Trim().Length > max)
            //{
            //    MessageBox.Show(
            //        placeHolder
            //        + " is required to have length between "
            //        + min + " and " + max
            //        , "Error"
            //        , MessageBoxButtons.OK
            //        , MessageBoxIcon.Error);
            //    return false;
            //}
            return true;
        }
    }
}
