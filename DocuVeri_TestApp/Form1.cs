using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DocuVeri_TestApp.Model;

namespace DocuVeri_TestApp
{
    public partial class Form1 : Form
    {
        ITempType TempTypeObj = null;
        StringBuilder OutputTxt = null;
        string[] InputCommands = null;

        public Form1()
        {
            InitializeComponent();            
        }

        private void BtnGetDress_Click(object sender, EventArgs e)
        {
            try
            {
                TempTypeObj = null;
                LblStatusText.Text = String.Empty;
                LblOutput.Text = String.Empty;
                
                TempTypeObj = GetTempType();
                if (TempTypeObj == null)
                {
                    throw new Exception("Select Tempreture Type.");
                }

                // Return if no command entered
                if (String.IsNullOrEmpty(TxtBxCommand.Text))
                {
                    throw new Exception("No valid commands entered.");
                }

                // Load commands
                InputCommands = TxtBxCommand.Text.Replace(" ", "").Split(',');

                // Return if no valid command found
                if (InputCommands.Count() <= 0)
                {
                    throw new Exception("No valid commands found.");
                }

                if (InputCommands.Distinct().Count() != InputCommands.Count())
                {
                    throw new Exception("Commands not valid.");
                }

                // Check if first command is remove pajama and last command is leave house
                if (!InputCommands[0].Equals("8") ||
                    !InputCommands[InputCommands.Length - 1].Equals("7"))
                {
                    LblStatusText.Text = "Failed";
                    OutputTxt = null;
                    return;
                }

                // Process the commands
                OutputTxt = new StringBuilder();                
                foreach (string cmd in InputCommands)
                {                    
                    if (String.IsNullOrEmpty(cmd) || cmd.Trim().Contains(' '))
                    {
                        throw new Exception("Commands not valid.");
                    }

                    if (!TempTypeObj.IsValidCommand(cmd.Trim()))
                    {
                        LblStatusText.Text = "Failed";
                        OutputTxt = null;
                        return;
                    }

                    OutputTxt.Append(TempTypeObj.GetCommandDesc(cmd.Trim()) + ", ");
                }

                LblStatusText.Text = "Success";
                LblOutput.Text = OutputTxt.ToString();
            }
            catch (Exception ex)
            {
                LblStatusText.Text = "Failed";
                LblOutput.Text = "Error - " + ex.Message;
                OutputTxt = null;
            }
        }

        private ITempType GetTempType()
        {
            if (RdioBtnCold.Checked)
                return new ColdTemp();

            if (RdioBtnHot.Checked)
                return new HotTemp();

            return null;
        }
    }
}
