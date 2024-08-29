﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsTestRunner.Utilities;

namespace WinFormsTestRunner.Core
{
    internal class TestSummary
    {
        private static int _errorCount;

        public static void RecordError()
        {
            _errorCount++;
        }

        public static int GetErrorCount()
        {
            return _errorCount;
        }

        public static bool HasErrors()
        {
            return _errorCount > 0;
        }

        public static  void DisplaySummary()
        {
            if (HasErrors())
            {
                Logger.Log($"KONIEC: Test zakończył się z liczbą błędów: {_errorCount}");
                //Logger.Log($"Szczegóły w logu: {Logger.LogFilePath}"); 
            }
            else
            {
                Logger.Log("KONIEC: Test zakończył się bez błędów");
            }
        }

        public static void Reset()
        {
            _errorCount = 0;
        }
    }
}
