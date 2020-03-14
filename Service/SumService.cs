using Strev.QuickTools.Demo.Core.Service;
using System;

namespace Strev.QuickTools.Demo.Service
{
    public class SumService : ISumService
    {
        private string Error(string message)
        {
            return string.Format("Error : {0}", message);
        }

        private string Error(string message, Exception ex)
        {
            return string.Format("Error : {0}\n{1}\n{2}", message, ex.Message, ex.StackTrace);
        }

        public string Sum(string value1, string value2)
        {
            if (value1 == null)
            {
                return Error("value1 must not be null");
            }

            if (value2 == null)
            {
                return Error("value2 must not be null");
            }

            long valueLong1 = 0;
            long valueLong2 = 0;

            try
            {
                valueLong1 = Convert.ToInt64(value1);
            }
            catch (Exception ex)
            {
                return Error(string.Format("Value1 isn't a correct value ({0})", value1), ex);
            }

            try
            {
                valueLong2 = Convert.ToInt64(value2);
            }
            catch (Exception ex)
            {
                return Error(string.Format("Value2 isn't a correct value ({0})", value2), ex);
            }

            try
            {
                return (valueLong1 + valueLong2).ToString();
            }
            catch (Exception ex)
            {
                return Error("An error occured during the operation", ex);
            }
        }
    }
}