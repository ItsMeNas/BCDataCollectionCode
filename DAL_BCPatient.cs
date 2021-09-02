using EvaluationofNCinBC.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvaluationofNCinBC.DAL
{
    public class DAL_BCPatient
    {
        public string strConString = string.Empty;

        public DAL_BCPatient()
        {

            //string temp = System.IO.File.ReadAllText(@"FileName.txt");

            strConString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + Convert.ToString(System.IO.File.ReadAllText("FileName.txt").Trim()) + "';Persist Security Info=False;";

            //strConString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source='|DataDirectory|\BCPatientDatabase.accdb';Persist Security Info=False;";          

        }



        public bool InsertData(BCPatient bcpatient)
        {
            bool isSaveSuccess = true;

            try
            {
                int RowNum = GetRowNumber();

                if (RowNum == 0)
                    RowNum = 1;

                using (OleDbConnection con = new OleDbConnection(strConString))
                {
                    using (OleDbCommand cmd = new OleDbCommand())
                    {
                        cmd.Connection = con;

                        cmd.CommandType = CommandType.Text;

                        cmd.CommandText = "INSERT INTO BCPatientInfo" +
                        "(RecordNumber, BCPatientMRN, Age, Status, " +
                        "DateofDiagnosis, NodalStatus, Grade, Ki67, ERPRPositive, ERPRNegative, " +
                        "ERPositivePRNegative, ERNegativePRPositive, ERPRHER2NegativeTrippleNegative, " +
                        "ERPRHER2PositiveTripplePositive, HarmoneNegativeHER2Positive,  HarmonePositiveHER2Negative, InitialSizeMRIUSGMamo, " +
                        "PostNeoadjuvantChemoSizeMRIUSGMamo, ChemoType, NumberofChemoCycles, SurgicalProcedure, " +
                        "AnyComments, DateofRecordCreation, RecordStatus, CancerStatus, DateofSurgery) " +
                        "Values(@BCPatientName, @RecordNumber, @BCPatientMRN, @Age, @Status, " +
                        "@DateofDiagnosis, @NodalStatus, @Grade, @Ki67, @ERPRPositive, @ERPRNegative, " +
                        "@ERPositivePRNegative, @ERNegativePRPositive, @ERPRHER2NegativeTrippleNegative, " +
                        "@ERPRHER2PositiveTripplePositive, @HarmoneNegativeHER2Positive, @HarmonePositiveHER2Negative, @InitialSizeMRIUSGMamo, " +
                        "@PostNeoadjuvantChemoSizeMRIUSGMamo, @ChemoType, @NumberofChemoCycles, @SurgicalProcedure, " +
                        "@AnyComments, @DateofRecordCreation, @RecordStatus, @CancerStatus, @DateofSurgery)";

                        //md.Parameters.Add("@BCPatientName", OleDbType.VarChar).Value = bcpatient.BCPatientName;

                        cmd.Parameters.Add("@RecordNumber", OleDbType.Integer).Value = RowNum;

                        cmd.Parameters.Add("@BCPatientMRN", OleDbType.VarChar).Value = bcpatient.BCPatientMRN;

                        cmd.Parameters.Add("@Age", OleDbType.VarChar).Value = bcpatient.Age;

                        cmd.Parameters.Add("@Status", OleDbType.VarChar).Value = bcpatient.Status;

                        cmd.Parameters.Add("@DateofDiagnosis", OleDbType.Date).Value = bcpatient.DateofDiagnosis.Date;

                        cmd.Parameters.Add("@NodalStatus", OleDbType.VarChar).Value = bcpatient.NodalStatus;

                        cmd.Parameters.Add("@Grade", OleDbType.VarChar).Value = bcpatient.Grade;

                        cmd.Parameters.Add("@Ki67", OleDbType.VarChar).Value = bcpatient.Ki67;

                        cmd.Parameters.Add("@ERPRPositive", OleDbType.Boolean).Value = bcpatient.ERPRPositive;

                        cmd.Parameters.Add("@ERPRNegative", OleDbType.Boolean).Value = bcpatient.ERPRNegative;

                        cmd.Parameters.Add("@ERPositivePRNegative", OleDbType.Boolean).Value = bcpatient.ERPositivePRNegative;

                        cmd.Parameters.Add("@ERNegativePRPositive", OleDbType.Boolean).Value = bcpatient.ERNegativePRPositive;

                        cmd.Parameters.Add("@ERPRHER2NegativeTrippleNegative", OleDbType.Boolean).Value = bcpatient.ERPRHER2NegativeTrippleNegative;

                        cmd.Parameters.Add("@ERPRHER2PositiveTripplePositive", OleDbType.Boolean).Value = bcpatient.ERPRHER2PositiveTripplePositive;

                        cmd.Parameters.Add("@HarmoneNegativeHER2Positive", OleDbType.Boolean).Value = bcpatient.HarmoneNegativeHER2Positive;

                        cmd.Parameters.Add("@HarmonePositiveHER2Negative", OleDbType.Boolean).Value = bcpatient.HarmonePositiveHER2Negative;

                        cmd.Parameters.Add("@InitialSizeMRIUSGMamo", OleDbType.VarChar).Value = bcpatient.InitialSizeMRIUSGMamo;

                        cmd.Parameters.Add("@PostNeoadjuvantChemoSizeMRIUSGMamo", OleDbType.VarChar).Value = bcpatient.PostNeoadjuvantChemoSizeMRIUSGMamo;

                        cmd.Parameters.Add("@ChemoType", OleDbType.VarChar).Value = bcpatient.ChemoType;

                        cmd.Parameters.Add("@NumberofChemoCycles", OleDbType.VarChar).Value = bcpatient.NumberofChemoCycles;

                        cmd.Parameters.Add("@SurgicalProcedure", OleDbType.VarChar).Value = bcpatient.SurgicalProcedure;

                        cmd.Parameters.Add("@AnyComments", OleDbType.VarChar).Value = bcpatient.AnyComments;

                        //cmd.Parameters.Add("@Revisit", OleDbType.Integer).Value = bcpatient.Revisit;

                        //cmd.Parameters.Add("@Discard", OleDbType.Integer).Value = bcpatient.Discard;

                        cmd.Parameters.Add("@DateofRecordCreation", OleDbType.VarChar).Value = DateTime.Now.Date.ToString("dd/MM/yyyy");

                        cmd.Parameters.Add("@RecordStatus", OleDbType.Integer).Value = bcpatient.RecordStatus;

                        cmd.Parameters.Add("@CancerStatus", OleDbType.VarChar).Value = bcpatient.CancerStatus;

                        cmd.Parameters.Add("@DateofSurgery", OleDbType.Date).Value = bcpatient.DateofSurgery;                        

                        con.Open();

                        cmd.ExecuteNonQuery();
                    }
                }

            }
            catch (OleDbException OEx)
            {
                isSaveSuccess = false;

                throw OEx;
            }
            catch (Exception Ex)
            {
                isSaveSuccess = false;

                throw Ex;
            }
            return isSaveSuccess;

        }

        public bool UpdateData(BCPatient bcpatient)
        {
            bool isSaveSuccess = true;

            try
            {
                using (OleDbConnection con = new OleDbConnection(strConString))
                {
                    using (OleDbCommand cmd = new OleDbCommand())
                    {
                        cmd.Connection = con;

                        cmd.CommandType = CommandType.Text;

                        cmd.CommandText =  "UPDATE BCPatientInfo SET Age = ?, Status = ?, DateofDiagnosis = ?, " +
                            "NodalStatus = ?, Grade = ?, Ki67 = ?, ERPRPositive = ?, ERPRNegative = ?,  " +
                            "ERPositivePRNegative = ?, ERNegativePRPositive = ?, ERPRHER2NegativeTrippleNegative = ?, " +
                            "ERPRHER2PositiveTripplePositive = ?, HarmoneNegativeHER2Positive = ?, HarmonePositiveHER2Negative = ?, " +
                            "InitialSizeMRIUSGMamo = ?, PostNeoadjuvantChemoSizeMRIUSGMamo = ?, ChemoType = ?, " +
                            "NumberofChemoCycles = ?, SurgicalProcedure = ?,  AnyComments = ?, DateofUpdate = ?, " +
                            "RecordStatus = ?, CancerStatus = ?, DateofSurgery = ? " +
                            "WHERE BCPatientMRN = ?";

                        //cmd.Parameters.Add(new OleDbParameter { Value = bcpatient.BCPatientName });

                        cmd.Parameters.Add(new OleDbParameter { Value = bcpatient.Age });

                        cmd.Parameters.Add(new OleDbParameter { Value = bcpatient.Status });

                        cmd.Parameters.Add(new OleDbParameter { Value = bcpatient.DateofDiagnosis.Date.ToString("dd/MM/yyyy") });

                        cmd.Parameters.Add(new OleDbParameter { Value = bcpatient.NodalStatus });

                        cmd.Parameters.Add(new OleDbParameter { Value = bcpatient.Grade });

                        cmd.Parameters.Add(new OleDbParameter { Value = bcpatient.Ki67 });

                        cmd.Parameters.Add(new OleDbParameter { Value = bcpatient.ERPRPositive });

                        cmd.Parameters.Add(new OleDbParameter { Value = bcpatient.ERPRNegative });

                        cmd.Parameters.Add(new OleDbParameter { Value = bcpatient.ERPositivePRNegative });

                        cmd.Parameters.Add(new OleDbParameter { Value = bcpatient.ERNegativePRPositive });

                        cmd.Parameters.Add(new OleDbParameter { Value = bcpatient.ERPRHER2NegativeTrippleNegative });

                        cmd.Parameters.Add(new OleDbParameter { Value = bcpatient.ERPRHER2PositiveTripplePositive });

                        cmd.Parameters.Add(new OleDbParameter { Value = bcpatient.HarmoneNegativeHER2Positive });

                        cmd.Parameters.Add(new OleDbParameter { Value = bcpatient.HarmonePositiveHER2Negative });

                        cmd.Parameters.Add(new OleDbParameter { Value = bcpatient.InitialSizeMRIUSGMamo });

                        cmd.Parameters.Add(new OleDbParameter { Value = bcpatient.PostNeoadjuvantChemoSizeMRIUSGMamo });

                        cmd.Parameters.Add(new OleDbParameter { Value = bcpatient.ChemoType });

                        cmd.Parameters.Add(new OleDbParameter { Value = bcpatient.NumberofChemoCycles });

                        cmd.Parameters.Add(new OleDbParameter { Value = bcpatient.SurgicalProcedure });

                        cmd.Parameters.Add(new OleDbParameter { Value = bcpatient.AnyComments });

                        cmd.Parameters.Add(new OleDbParameter { Value = DateTime.Now.Date.ToString("dd/MM/yyyy") });

                        cmd.Parameters.Add(new OleDbParameter { Value = bcpatient.RecordStatus });

                        //cmd.Parameters.Add(new OleDbParameter { Value = bcpatient.Revisit });

                        //cmd.Parameters.Add(new OleDbParameter { Value = bcpatient.Discard });

                        cmd.Parameters.Add(new OleDbParameter { Value = bcpatient.CancerStatus }); 

                        cmd.Parameters.Add(new OleDbParameter { Value = bcpatient.DateofSurgery });

                        cmd.Parameters.Add(new OleDbParameter { Value = bcpatient.BCPatientMRN });

                        con.Open();

                        cmd.ExecuteNonQuery();
                    }
                }

            }
            catch (OleDbException OEx)
            {
                isSaveSuccess = false;

                throw OEx;
            }
            catch (Exception Ex)
            {
                isSaveSuccess = false;

                throw Ex;
            }
            return isSaveSuccess;
        }


        public DataSet UpdateDataAndReturnDataset(BCPatient bcpatient)
        {
            bool isSaveSuccess = true;

            try
            { 
            
                using (OleDbConnection con = new OleDbConnection(strConString))
                {
                    using (OleDbCommand cmd = new OleDbCommand())
                    {
                        cmd.Connection = con;

                        cmd.CommandType = CommandType.Text;

                        cmd.CommandText = "UPDATE BCPatientInfo SET Age = ?, Status = ?, DateofDiagnosis = ?, " +
                            "NodalStatus = ?, Grade = ?, Ki67 = ?, ERPRPositive = ?, ERPRNegative = ?,  " +
                            "ERPositivePRNegative = ?, ERNegativePRPositive = ?, ERPRHER2NegativeTrippleNegative = ?, " +
                            "ERPRHER2PositiveTripplePositive = ?, HarmoneNegativeHER2Positive = ?, HarmonePositiveHER2Negative = ?, " +
                            "InitialSizeMRIUSGMamo = ?, PostNeoadjuvantChemoSizeMRIUSGMamo = ?, ChemoType = ?, " +
                            "NumberofChemoCycles = ?, SurgicalProcedure = ?,  AnyComments = ?, DateofUpdate = ?, " +
                            "RecordStatus = ?, CancerStatus = ?, PostgTreatmentStaging = ?, PerChangeInSize = ?, DateofSurgery = ? " +
                            "WHERE BCPatientMRN = ?";



                        //cmd.Parameters.Add(new OleDbParameter { Value = bcpatient.BCPatientName });

                        cmd.Parameters.Add(new OleDbParameter { Value = bcpatient.Age });

                        cmd.Parameters.Add(new OleDbParameter { Value = bcpatient.Status });

                        cmd.Parameters.Add(new OleDbParameter { Value = bcpatient.DateofDiagnosis.Date.ToString("dd/MM/yyyy") });

                        cmd.Parameters.Add(new OleDbParameter { Value = bcpatient.NodalStatus });

                        cmd.Parameters.Add(new OleDbParameter { Value = bcpatient.Grade });

                        cmd.Parameters.Add(new OleDbParameter { Value = bcpatient.Ki67 });

                        cmd.Parameters.Add(new OleDbParameter { Value = bcpatient.ERPRPositive });

                        cmd.Parameters.Add(new OleDbParameter { Value = bcpatient.ERPRNegative });

                        cmd.Parameters.Add(new OleDbParameter { Value = bcpatient.ERPositivePRNegative });

                        cmd.Parameters.Add(new OleDbParameter { Value = bcpatient.ERNegativePRPositive });

                        cmd.Parameters.Add(new OleDbParameter { Value = bcpatient.ERPRHER2NegativeTrippleNegative });

                        cmd.Parameters.Add(new OleDbParameter { Value = bcpatient.ERPRHER2PositiveTripplePositive });

                        cmd.Parameters.Add(new OleDbParameter { Value = bcpatient.HarmoneNegativeHER2Positive });

                        cmd.Parameters.Add(new OleDbParameter { Value = bcpatient.HarmonePositiveHER2Negative });

                        cmd.Parameters.Add(new OleDbParameter { Value = bcpatient.InitialSizeMRIUSGMamo });

                        cmd.Parameters.Add(new OleDbParameter { Value = bcpatient.PostNeoadjuvantChemoSizeMRIUSGMamo });

                        cmd.Parameters.Add(new OleDbParameter { Value = bcpatient.ChemoType });

                        cmd.Parameters.Add(new OleDbParameter { Value = bcpatient.NumberofChemoCycles });

                        cmd.Parameters.Add(new OleDbParameter { Value = bcpatient.SurgicalProcedure });

                        cmd.Parameters.Add(new OleDbParameter { Value = bcpatient.AnyComments });

                        cmd.Parameters.Add(new OleDbParameter { Value = DateTime.Now.Date.ToString("dd/MM/yyyy") });

                        cmd.Parameters.Add(new OleDbParameter { Value = bcpatient.RecordStatus });                      

                        cmd.Parameters.Add(new OleDbParameter { Value = bcpatient.CancerStatus });

                        cmd.Parameters.Add(new OleDbParameter { Value = bcpatient.PostgTreatmentStaging });

                        cmd.Parameters.Add(new OleDbParameter { Value = bcpatient.PerChangeInSize });

                        cmd.Parameters.Add(new OleDbParameter { Value = bcpatient.DateofSurgery });

                        cmd.Parameters.Add(new OleDbParameter { Value = bcpatient.BCPatientMRN });

                        con.Open();

                        cmd.ExecuteNonQuery();

                        DataSet dataSet = new DataSet();

                        cmd.CommandText = "select ID, RecordNumber, " +
                                        "AnyComments, BCPatientMRN, Age, Status, " +
                                        "DateofDiagnosis, NodalStatus, Grade, Ki67, ERPRPositive, ERPRNegative, " +
                                        "ERPositivePRNegative, ERNegativePRPositive, ERPRHER2NegativeTrippleNegative, " +
                                        "ERPRHER2PositiveTripplePositive, HarmoneNegativeHER2Positive, HarmonePositiveHER2Negative,  InitialSizeMRIUSGMamo, " +
                                        "PostNeoadjuvantChemoSizeMRIUSGMamo, ChemoType, NumberofChemoCycles, SurgicalProcedure, " +
                                        "RecordStatus, PostgTreatmentStaging, PerChangeInSize, DateofSurgery from BCPatientInfo";
                        
                        using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmd.CommandText, con))
                        {
                            adapter.Fill(dataSet);
                        }                       

                        return dataSet;

                    }
                }

            }
            catch (OleDbException OEx)
            {
                isSaveSuccess = false;

                throw OEx;
            }
            catch (Exception Ex)
            {
                isSaveSuccess = false;

                throw Ex;
            }           
        }




        private Int32 GetRowNumber()
        {
            try 
            {
                using (OleDbConnection con = new OleDbConnection(strConString))
                {
                    using (OleDbCommand cmd = new OleDbCommand())
                    {
                        cmd.Connection = con;

                        cmd.CommandType = CommandType.Text;

                        cmd.CommandText = "select count(*) + 1 from BCPatientInfo";

                        //cmd.CommandText = "SELECT TOP 1 * FROM BCPatientInfo ORDER BY RecordNumber";

                        con.Open();

                        return (int)cmd.ExecuteScalar();

                        // 
                    }
                }


                        
            }
            catch (OleDbException OEx)
            {
                throw OEx;
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }


        public DataSet FillGridView()
        {
            DataSet dataSet = new DataSet();

            string selectquery = "select ID, RecordNumber, " +
                            "AnyComments, BCPatientMRN, Age, Status, " +
                            "DateofDiagnosis, NodalStatus, Grade, Ki67, ERPRPositive, ERPRNegative, " +
                            "ERPositivePRNegative, ERNegativePRPositive, ERPRHER2NegativeTrippleNegative, " +
                            "ERPRHER2PositiveTripplePositive, HarmoneNegativeHER2Positive, HarmonePositiveHER2Negative,  InitialSizeMRIUSGMamo, " +
                            "PostNeoadjuvantChemoSizeMRIUSGMamo, ChemoType, NumberofChemoCycles, SurgicalProcedure, PostgTreatmentStaging, PerChangeInSize, DateofSurgery, " +
                            "RecordStatus from BCPatientInfo";


            using (OleDbConnection conn = new OleDbConnection(strConString))
            {
                using (OleDbDataAdapter adapter = new OleDbDataAdapter(selectquery, conn))
                {
                    adapter.Fill(dataSet);
                }
            }

            return dataSet;
        }

        public bool DeleteBCCRecord(string ID)
        {

            bool isSaveSuccess = true;

            try
            {
                using (OleDbConnection con = new OleDbConnection(strConString))
                {
                    using (OleDbCommand cmd = new OleDbCommand())
                    {
                        cmd.Connection = con;

                        cmd.CommandType = CommandType.Text;

                        cmd.CommandText = "DELETE FROM BCPatientInfo WHERE ID = " + ID;

                        con.Open();

                        cmd.ExecuteNonQuery();
                    }
                }

            }
            catch (OleDbException OEx)
            {
                isSaveSuccess = false;

                throw OEx;
            }
            catch (Exception Ex)
            {
                isSaveSuccess = false;

                throw Ex;
            }
            return isSaveSuccess;

        }
    }
}
