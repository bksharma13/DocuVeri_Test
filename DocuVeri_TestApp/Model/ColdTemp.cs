using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DocuVeri_TestApp.Model
{
    /// <summary>
    /// Concrete implementation for Cold temperature type
    /// </summary>
    public class ColdTemp : ITempType
    {
        private bool isAllClothesWorn = false;
        private bool isPantWorn = false;
        private bool isShirtWorn = false;
        private bool isSocksWorn = false;
        private bool isJacketWorn = false;
        private bool isHeadwearWorn = false;

        private const string ColdTempCmd = "C";
        private string[] ValidCommandList = { "1", "2", "3", "4", "5", "6", "7", "8" };

        /// <summary>
        /// Intialize Cold temp object
        /// </summary>
        public ColdTemp()
        {
            isAllClothesWorn = false;
            isPantWorn = false;
            isShirtWorn = false;
            isJacketWorn = false;
            isHeadwearWorn = false;
        }

        public bool IsValidCommand(string command)
        {
            if (!ValidCommandList.Contains(command))
                return false;

            bool isValid = false;
            switch (command)
            {
                // Command to wear shoes
                case "1":
                    if (isPantWorn && isSocksWorn && isJacketWorn && isHeadwearWorn)
                        isAllClothesWorn = isValid = true;
                    else
                        isAllClothesWorn = isValid = false;                    
                    break;

                // Command for headwear
                case "2":
                    if (isShirtWorn)
                    {
                        isHeadwearWorn = isValid = true;
                    }
                    else
                    {
                        isHeadwearWorn = isValid = false;
                    }
                    break;

                // Command to wear Socks
                case "3":
                    isSocksWorn = true;
                    isValid = true;
                    break;

                // Command to wear shirt
                case "4":
                    isShirtWorn = true;
                    isValid = true;
                    break;

                // Command to wear jacket
                case "5":
                    if (isShirtWorn)
                    {
                        isJacketWorn = isValid = true;
                    }
                    else
                    {
                        isJacketWorn = isValid = false;
                    }
                    break;

                // Command to wear pant
                case "6":
                    isPantWorn = true;
                    isValid = true;
                    break;

                // Command to leave house
                case "7":
                    if (isAllClothesWorn)
                        isValid = true;
                    else
                        isValid = false;
                    break;

                // Command to take out PJ's
                case "8":
                    isValid = true;
                    break;

            }

            return isValid;
        }

        public string GetCommandDesc(string command)
        {
            return CommandDesc.GetCommandDec(command + ColdTempCmd);
        }
    }
}
