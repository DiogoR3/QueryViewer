using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace QueryViewer.Services
{
    public class DatabaseQuery
    {
        private readonly Query[] Queries;

        public DatabaseQuery(IOptions<Configuration> configuration)
        {
            Queries = configuration.Value.Queries;
        }

        public Query GetQuery(int queryId)
        {
            return Queries.Length >= queryId && queryId > 0 ? Queries[queryId - 1] : null;
        }

        public Query[] GetQueries()
        {
            return Queries;
        }

        public string[] GetQueriesNames()
        {
            return Queries.Select(query => query.Name).ToArray();
        }

        public async Task<(string[], IEnumerable<object>)> GetQueryResult(int queryId)
        {
            Query query = GetQuery(queryId);

            if (query is null)
                return (null, null);

            DataTable dataTable = await GetDataTable(query);

            string[] columns = GetColumns(dataTable.Columns);
            IEnumerable<object> rows = GetRows(dataTable.Rows);

            return (columns, rows);
        }

        private static async Task<DataTable> GetDataTable(Query query)
        {
            DataTable dataTable = new();
            using SqlConnection conn = new(query.ConnectionString);

            SqlCommand sqlCmd = new(query.Value, conn);
            SqlDataAdapter sqlAdapter = new(sqlCmd);

            await conn.OpenAsync();
            sqlAdapter.Fill(dataTable);

            return dataTable;
        }

        private static string[] GetColumns(DataColumnCollection dataColumnCollection)
        {
            List<string> columns = new();
            
            foreach (DataColumn column in dataColumnCollection)
                columns.Add(column.ColumnName);

            return columns.ToArray();
        }

        private static IEnumerable<object> GetRows(DataRowCollection dataRowCollection)
        {
            List<object> rowsList = new();
            List<object> rowsItem;

            foreach (DataRow dataRow in dataRowCollection)
            {
                rowsItem = new();

                foreach (object obj in dataRow.ItemArray)
                    rowsItem.Add(obj?.ToString());

                rowsList.Add(rowsItem);
            }

            return rowsList;
        }
    }
}
