using DocuVeri_TestApp.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Text;

namespace DocuVeri_UnitTest
{   
    /// <summary>
    ///This is a test class for app
    ///</summary>
    [TestClass()]
    public class TempTest
    {
        /// <summary>
        /// A test for valid Hot temp Command
        ///</summary>
        [TestMethod()]
        public void IsValidHotTempCommandTest()
        {
            ITempType target = new HotTemp(); // Initialize to an appropriate value
            string[] InputCommands = { "8", "6", "4", "2", "1", "7" }; // Initialize to an appropriate value

            string expectedOutput = "Removing PJs, shorts, t-shirt, sun visor, sandals, leaving house,";
            StringBuilder actual  = new StringBuilder();

            foreach (string cmd in InputCommands)
            {
                if (String.IsNullOrEmpty(cmd) || cmd.Trim().Contains(" "))
                {
                    actual = null;
                    break;
                }

                if (!target.IsValidCommand(cmd.Trim()))                {
                    
                    actual = null;
                    break; ;
                }

                actual.Append(target.GetCommandDesc(cmd.Trim()) + ", ");
            }

            Assert.AreEqual(expectedOutput.ToLower().Trim(), actual.ToString().ToLower().Trim());
        }

        /// <summary>
        /// A test for failed hot temp Command
        ///</summary>
        [TestMethod()]
        public void FailedHotTempCommandTest()
        {
            ITempType target = new HotTemp(); // Initialize to an appropriate value
            string[] InputCommands = { "8", "6", "1", "7" }; // Initialize to an appropriate value

            // Incorrect output
            string expectedOutput = "Failed";
            StringBuilder actual = new StringBuilder();
            string actualOutput = "Success";

            foreach (string cmd in InputCommands)
            {
                if (String.IsNullOrEmpty(cmd) || cmd.Trim().Contains(" "))
                {
                    actual = null;
                    actualOutput = "Failed";
                    break;
                }

                if (!target.IsValidCommand(cmd.Trim()))
                {
                    actual = null;
                    actualOutput = "Failed";
                    break; ;
                }

                actual.Append(target.GetCommandDesc(cmd.Trim()) + ", ");
            }

            bool isValid = false;

            if (!String.IsNullOrEmpty(actualOutput) && actualOutput.Equals(expectedOutput))
                isValid = true;

            Assert.IsTrue(isValid);
        }

        /// <summary>
        /// A test for valid Cold temp Command
        ///</summary>
        [TestMethod()]
        public void IsValidColdTempCommandTest()
        {
            ITempType target = new ColdTemp(); // Initialize to an appropriate value
            string[] InputCommands = { "8", "6", "3", "4", "2", "5", "1", "7" }; // Initialize to an appropriate value

            string expectedOutput = "Removing PJs, pants, socks, shirt, hat, jacket, boots, leaving house,";
            StringBuilder actual = new StringBuilder();

            foreach (string cmd in InputCommands)
            {
                if (String.IsNullOrEmpty(cmd) || cmd.Trim().Contains(" "))
                {
                    actual = null;
                    break;
                }

                if (!target.IsValidCommand(cmd.Trim()))
                {

                    actual = null;
                    break; ;
                }

                actual.Append(target.GetCommandDesc(cmd.Trim()) + ", ");
            }

            Assert.AreEqual(expectedOutput.ToLower().Trim(), actual.ToString().ToLower().Trim());
        }

        /// <summary>
        /// A test for failed cold temp Command
        ///</summary>
        [TestMethod()]
        public void FailedColdTempCommandTest()
        {
            ITempType target = new ColdTemp(); // Initialize to an appropriate value
            string[] InputCommands = { "8", "6", "3", "4", "2", "5", "7" }; // Initialize to an appropriate value

            // Incorrect output
            string expectedOutput = "Failed";
            StringBuilder actual = new StringBuilder();
            string actualOutput = "Success";

            foreach (string cmd in InputCommands)
            {
                if (String.IsNullOrEmpty(cmd) || cmd.Trim().Contains(" "))
                {
                    actual = null;
                    actualOutput = "Failed";
                    break;
                }

                if (!target.IsValidCommand(cmd.Trim()))
                {
                    actual = null;
                    actualOutput = "Failed";
                    break; ;
                }

                actual.Append(target.GetCommandDesc(cmd.Trim()) + ", ");
            }

            bool isValid = false;

            if (!String.IsNullOrEmpty(actualOutput) && actualOutput.Equals(expectedOutput))
                isValid = true;

            Assert.IsTrue(isValid);
        }
    }
}
