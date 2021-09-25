using System;

namespace CK.DataTable.Extensions
{
    /// <summary>
    ///     DataTable extension methods
    /// </summary>
    public static class ExtensionMethod
    {
        /// <summary>
        ///     Check DataTable contains any rows
        /// </summary>
        /// <param name="dataTable"></param>
        /// <returns></returns>
        public static bool IsEmpty(this System.Data.DataTable dataTable)
        {
            return !(dataTable != null && dataTable.Rows != null && dataTable.Rows.Count > 1);
        }

        /// <summary>
        ///     Get DataTable row count
        /// </summary>
        /// <param name="dataTable"></param>
        /// <returns></returns>
        public static int RowCount(this System.Data.DataTable dataTable)
        {
            return dataTable != null && dataTable.Rows != null ? dataTable.Rows.Count : 0;
        }

        /// <summary>
        ///     Converts the value of the specified cell to a System.String.
        /// </summary>
        /// <param name="dataRow"></param>
        /// <param name="columnName">DataTable column name</param>
        /// <returns></returns>
        public static string ToString(this System.Data.DataRow dataRow, string columnName)
        {
            return Convert.ToString(dataRow[columnName]);
        }

        /// <summary>
        ///     Converts the value of the specified cell to a System.String.
        /// </summary>
        /// <param name="dataRow"></param>
        /// <param name="columnName">DataTable column name</param>
        /// <param name="defaultDate">Default string value if empty</param>
        /// <returns></returns>
        public static string ToString(this System.Data.DataRow dataRow, string columnName, string defaultValue)
        {
            return Convert.ToString(dataRow[columnName]) == null ? defaultValue : Convert.ToString(dataRow[columnName]);
        }

        /// <summary>
        ///     Converts the value of the specified cell to a System.DateTime.
        /// </summary>
        /// <param name="dataRow"></param>
        /// <param name="columnName">DataTable column name</param>
        /// <returns></returns>
        public static DateTime? ToDateTime(this System.Data.DataRow dataRow, string columnName)
        {
            return string.IsNullOrWhiteSpace(Convert.ToString(dataRow[columnName])) ? (DateTime?)null : Convert.ToDateTime(dataRow[columnName]);
        }

        /// <summary>
        ///     Converts the value of the specified cell to a System.DateTime.
        /// </summary>
        /// <param name="dataRow"></param>
        /// <param name="columnName">DataTable column name</param>
        /// <param name="defaultDate">Default date if empty</param>
        /// <returns></returns>
        public static DateTime ToDateTime(this System.Data.DataRow dataRow, string columnName, DateTime defaultDate)
        {
            return string.IsNullOrWhiteSpace(Convert.ToString(dataRow[columnName])) ? defaultDate : Convert.ToDateTime(dataRow[columnName]);
        }

        /// <summary>
        ///     Return DBNull value if object value is NULL
        /// </summary>
        /// <param name="objectValue"></param>
        /// <returns></returns>
        public static object ToDBNull(this Object objectValue)
        {
            return objectValue == null ? DBNull.Value : objectValue;
        }
    }
}
