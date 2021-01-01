using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FrontEnd
{
    public partial class TournamentForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void tournamentNametxtBox_TextChanged(object sender, EventArgs e)
        {

        }
        protected void sDate_SelectionChanged(object sender, EventArgs e)
        {
            

        }

        protected void eDate_SelectionChanged(object sender, EventArgs e)
        {

        }

        protected void txtBoxVenue_TextChanged(object sender, EventArgs e)
        {

        }

        protected void tTypeDropList_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        protected void pNameTNametxtBox_TextChanged(object sender, EventArgs e)
        {

        }


        protected void pNameTNameTxtArea_TextChanged(object sender, EventArgs e)
        {


        }



        protected void addBtn_Click(object sender, EventArgs e)
        {


        }

        protected void deleteBtn_Click(object sender, EventArgs e)
        {

        }

        


        protected void generateBtn_Click1(object sender, EventArgs e)
        {

        }

        protected void tNametxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        protected void PTDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        public string Validate(string sDate, string eDate, string tournamentType)
        {
            String error = "";
            DateTime tempSDate;
            DateTime tempEDate;
            

            try
            {
                tempSDate = Convert.ToDateTime(sDate);
                if(tempSDate < DateTime.Now.Date)
                {
                    error = error + "Date cannot be in the past";
                }
            }
            catch 
            {
                error = error + "Date is not valid";
            }

            try
            {
                tempEDate = Convert.ToDateTime(eDate);

                if(tempEDate < DateTime.Now.Date)
                {
                    error = error + "Date cannot be in the past";
                }
            }
            catch
            {
                error = error + "Date is not valid";

            }

            

            return error;
        }
    }
}