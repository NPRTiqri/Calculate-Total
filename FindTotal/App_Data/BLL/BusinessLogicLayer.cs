using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FindTotal
{
    public class BusinessLogicLayer
    {
        DataAccessLayer dataAccessLayer = new DataAccessLayer();

        //public BusinessLogicLayer()
        //{
        //    dataAccessLayer = new DataAccessLayer();
        //}

        public string InsertValue(DataAccessObject objectDataAccesss)
        {

            try
            {
                return dataAccessLayer.ToInsertValue(objectDataAccesss);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dataAccessLayer = null;
            }
        }

        public int GetTotalofX()
        {
            try
            {
                return dataAccessLayer.GetXTotal();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int GetTotalOfY()
        {
            try
            {
                return dataAccessLayer.GetYTotal();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int GetTotalOfZ()
        {
            try
            {
                return dataAccessLayer.GetZTotal();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int UpdateTotal(DataAccessObject objectDataAccesss)
        {
            int totalValues = objectDataAccesss.ValueOfX + objectDataAccesss.ValueOfY + objectDataAccesss.TotalOfZ;
            return totalValues;
        }
    }
}