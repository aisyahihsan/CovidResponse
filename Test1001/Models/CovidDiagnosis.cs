using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test1001.Models
{
    public class CovidDiagnosis
    {
        public string Name { get; set; }
        public string Phone { get; set; }

        public bool Fever { get; set; }
        public bool Cough { get; set; }
        public bool Breath { get; set; }
        public bool Oversea { get; set; }
        public bool Contact { get; set; }
        public string RiskLevel
        {
            get
            {
                if (Fever && Cough && Breath == true)
                    return "High";
                else if (Fever && Oversea == true)
                    return "High";
                else if (Fever && Contact == true)
                    return "High";
                else if (Cough && Oversea == true)
                    return "High";
                else if (Cough && Contact == true)
                    return "High";
                else if (Breath && Oversea == true)
                    return "High";
                else if (Breath && Contact == true)
                    return "High";
                else if (Fever == true)
                    return "Medium";
                else if (Cough == true)
                    return "Medium";
                else if (Breath == true)
                    return "Medium";
                else if (Fever && Cough == true)
                    return "Medium";
                else if (Fever && Breath == true)
                    return "Medium";
                else if (Cough && Breath == true)
                    return "Medium";
                else
                    return "Low";
            }
        }

        public string Advisory
        {
            get
            {
                if (RiskLevel == "High")
                    return "STEP 1 \n" +
                    "• Do not go to hospital, clinic, pharmacy or social gathering. \n" +
                    "• Avoid perform handshake to anybody.\n" +
                    "• Self - isolate.\n" +
                    "STEP 2 \n" +
                    "• Call KKM COVID - 19 hotline 0388810200 or your nearest District Health Office(DHO).\n" +
                    "• Your details will be passed on to an authorised Public Health Person.\n" +
                    "• Arrangement will be made to get yourself tested for SARS - COV2 that caused COVID - 19.";
                else if (RiskLevel == "Medium")
                    return "• Stay safe. \n" +
                        "• Wash your hands often with soap and water. \n" +
                        "• If necessary, go to the doctor.";
                else
                    return "• Stay safe. You do not have any COVID-19 symptom. \n" +
                        "• Wash your hands often with soap and water.";
            }
        }
    }
}
