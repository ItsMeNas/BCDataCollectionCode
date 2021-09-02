using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluationofNCinBC.Model
{
    public class BCPatient
    {
        

        public int BCPatientId { get; set; }

        //public string BCPatientName{ get; set; }

        public string BCPatientMRN { get; set; }

        public string Age { get; set; }

        public string Nationality { get; set; }

        public string  Address { get; set; }

        public string  Status { get; set; }

        public DateTime DateofDiagnosis { get; set; }

        public string  NodalStatus  { get; set; }

        public string Grade { get; set; }

        public string Ki67 { get; set; }

        public bool ERPRPositive { get; set; }

        public bool  ERPRNegative { get; set; }

        public bool ERPositivePRNegative { get; set; }

        public bool ERNegativePRPositive { get; set; }

        public bool ERPRHER2NegativeTrippleNegative { get; set; }


        public bool ERPRHER2PositiveTripplePositive { get; set; }

        public bool HarmoneNegativeHER2Positive { get; set; }

        public bool HarmonePositiveHER2Negative { get; set; }

        public string InitialSizeMRIUSGMamo { get; set; }

        public string PostNeoadjuvantChemoSizeMRIUSGMamo { get; set; }

        public string  ChemoType { get; set; }

        public string NumberofChemoCycles { get; set; }

        public string SurgicalProcedure { get; set; }

        public string AnyComments { get; set; }

        public int Revisit { get; set; }

        public int Discard { get; set; }

        public int RecordStatus { get; set; }

        public string CancerStatus { get; set; }

        public string PostgTreatmentStaging { get; set; }

        public string PerChangeInSize { get; set; }
        public DateTime DateofSurgery { get; set; }

    }
}
