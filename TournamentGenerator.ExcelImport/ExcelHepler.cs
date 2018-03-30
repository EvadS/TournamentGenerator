using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TournametGenerator.ViewModels.Result;

namespace TournamentGenerator.Imports
{
    public static class ExcelHepler
    {
        private static string ExcelConnectionString(string filePath)
        {
            try
            {
                OleDbConnectionStringBuilder sbConnection = new OleDbConnectionStringBuilder();
                String strExtendedProperties = String.Empty;
                sbConnection.DataSource = filePath;

                if (Path.GetExtension(filePath).Equals(".xls"))//for 97-03 Excel file
                {
                    sbConnection.Provider = "Microsoft.Jet.OLEDB.4.0";
                    strExtendedProperties = "Excel 8.0;HDR=Yes;IMEX=1";//HDR=ColumnHeader,IMEX=InterMixed
                }
                else if (Path.GetExtension(filePath).Equals(".xlsx"))  //for 2007 Excel file
                {
                    sbConnection.Provider = "Microsoft.ACE.OLEDB.12.0";
                    strExtendedProperties = "Excel 12.0;HDR=Yes;IMEX=1";
                }

                sbConnection.Add("Extended Properties", strExtendedProperties);

                return sbConnection.ToString();
            }
            catch (Exception)
            {
                throw;
            }
        }


        /// <summary>
        /// создание DataSet из файла excel 
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public static Result<DataSet> ImportFromExcel(string filePath)
        {

            OleDbDataAdapter adapter = null;
            var connectionString = ExcelHepler.ExcelConnectionString(filePath);
            OleDbConnection excelConnection = new OleDbConnection();
            excelConnection.ConnectionString = connectionString;

            Result<DataSet> result = new Result<DataSet>();

            try
            {
                excelConnection.Open();
                DataTable dtTables = new DataTable();

                //to get the schema of the workbook.
                dtTables = excelConnection.GetSchema();

                //get the tables in the workbook
                dtTables = excelConnection.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                String[] excelSheets = null;
                if ((dtTables != null))
                {
                    excelSheets = new String[dtTables.Rows.Count];
                    int i = 0;

                    // Add the sheet name to the string array.
                    foreach (DataRow row in dtTables.Rows)
                    {
                        excelSheets[i] = row["TABLE_NAME"].ToString();
                        i++;
                    }
                }
                DataSet ds = new DataSet();

                foreach (string sheet in excelSheets)
                {
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.Connection = excelConnection;
                    cmd.CommandText = "Select * from [" + sheet + "]";
                    DataTable dtItems = new DataTable();
                    dtItems.TableName = sheet;

                    adapter = new OleDbDataAdapter();
                    adapter.SelectCommand = cmd;

                    // adapter.FillSchema(ds
                    adapter.Fill(dtItems);
                    ds.Tables.Add(dtItems);
                }

                result.Data = ds;
                result.Success = true;
                return result;
            }
            catch (Exception ex)
            {
                result.Data = new DataSet();
                result.Success = false;
                result.Message = ex.Message;
                return result;
            }
            finally
            {
                adapter.Dispose();
                excelConnection.Dispose();
            }
        }

        public static Result<bool> ExistsMinimumColumnsCount(DataTable dataTable, int minColumnsCount)
        {
            Result<bool> result = new Result<bool>();
            result.Success = true;
            var columns = dataTable.Columns;

            if (columns.Count < minColumnsCount)
            {
                result.Success = false;    
            }
        
            return result;
        }


    }
}
