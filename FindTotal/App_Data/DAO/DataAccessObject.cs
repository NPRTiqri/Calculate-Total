using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FindTotal
{
    public class DataAccessObject
    {
        private int _zValue;
        private int _xValue;
        private int _yValue;
        private int _totalOfValueZ;
        
        public int ValueOfZ
        {
            get { return _zValue; }
            set { _zValue = value; }
        }
       
  
        public int ValueOfX
        {
            get { return _xValue; }
            set { _xValue = value; }
        }

        public int ValueOfY
        {
            get { return _yValue; }
            set { _yValue = value; }
        }

        public int TotalOfZ
        {
            get { return _totalOfValueZ; }
            set { _totalOfValueZ = value; }
        }

    }
}