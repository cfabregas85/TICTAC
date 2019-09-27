using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TICTAC.Services
{
    public class TictacService : ITictacService
    {

        #region Methods

        public string CheckValue( int value) {

            if (this.CheckTicTac(value))
            {
                return "TIC TAC";
            }
            
            if (this.CheckTic(value))
            {
                return "TIC";
            }
               
            if (this.CheckTac(value))
            {
               return "TAC";
            }              
            
            return "This number is not divisible by 3 or 5";
        }

        public bool CheckTicTac(int value)
        {
            if (value % 3 == 0 && value % 5 == 0)
            {
                return true;
            }
            return false;
        }

        public bool CheckTic(int value)
        {
            if (value % 3 == 0)
            {
                return true;
            }
            return false;
        }

        public bool CheckTac(int value)
        {
            if (value % 5 == 0)
            {
                return true;
            }
            return false;
        }

        #endregion

    }
}
