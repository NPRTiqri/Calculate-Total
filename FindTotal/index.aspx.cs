using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FindTotal
{
    public partial class index : System.Web.UI.Page
    {
        BusinessLogicLayer objectBusinessLogicLayer = new BusinessLogicLayer();
        DataAccessObject objectDataAccessObject = new DataAccessObject();

        protected void Page_Load(object sender, EventArgs e)
        {
            objectDataAccessObject.ValueOfX = objectBusinessLogicLayer.GetTotalofX();
            objectDataAccessObject.ValueOfY = objectBusinessLogicLayer.GetTotalOfY();
            objectDataAccessObject.TotalOfZ = objectBusinessLogicLayer.GetTotalOfZ();
            LableForX.Text = objectDataAccessObject.ValueOfX.ToString();
            LableForY.Text = objectDataAccessObject.ValueOfY.ToString();
            LableForZ.Text = objectDataAccessObject.TotalOfZ.ToString();
            LableForTotal.Text = objectBusinessLogicLayer.UpdateTotal(objectDataAccessObject).ToString();
        }

        protected void AddValueTo_Click(object sender, EventArgs e)
        {
            string outputMessage = string.Empty;
            string valueOfZ = ValueOfZ.Text;
            if(String.IsNullOrEmpty(valueOfZ))
            {
                ErrorMessage.Text = "Enter any value";
            }
            else
            {
                int convertedValueOfZ = Int32.Parse(valueOfZ);
                objectDataAccessObject.ValueOfZ = convertedValueOfZ;
                outputMessage = objectBusinessLogicLayer.InsertValue(objectDataAccessObject);

                int updatedValueOfZ = convertedValueOfZ + objectDataAccessObject.TotalOfZ;
                int updatedValueOfTotal = convertedValueOfZ + objectBusinessLogicLayer.UpdateTotal(objectDataAccessObject);
                LableForZ.Text = updatedValueOfZ.ToString();
                LableForTotal.Text = updatedValueOfTotal.ToString();
            }

            SuccessMessage.Text = outputMessage;
            ValueOfZ.Text = "";
        }
    }
}