using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Cluster.Models;

namespace Cluster.Repositories
{
	public partial class PL_CUSTOMER_CLUSTERRepository
	{
		private string connString;
		public string Message { get; set; }

		public PL_CUSTOMER_CLUSTERRepository(string connectionString)
		{
			connString = connectionString;
		}

		public void Add(PL_CUSTOMER_CLUSTER pl_customer_cluster)
		{
			using (var conn = new SqlConnection(connString))
			{
				try
				{
					Message = "";
					conn.Open();
					SqlCommand command = new SqlCommand("INSERT INTO PL_CUSTOMER_CLUSTER ([ID], [DATE_STAMP], [IDREFPELANGGAN], [HOUR_NUM], [CLUSTER_NUM], [FDVC_NORMALIZED]) VALUES(@ID, @DATE_STAMP, @IDREFPELANGGAN, @HOUR_NUM, @CLUSTER_NUM, @FDVC_NORMALIZED)", conn);
					command.CommandType = System.Data.CommandType.Text;
					if (pl_customer_cluster.ID != null) { command.Parameters.AddWithValue("@ID", pl_customer_cluster.ID); } else { command.Parameters.AddWithValue("@ID", DBNull.Value); } 
					if (pl_customer_cluster.DATE_STAMP != null) { command.Parameters.AddWithValue("@DATE_STAMP", pl_customer_cluster.DATE_STAMP); } else { command.Parameters.AddWithValue("@DATE_STAMP", DBNull.Value); } 
					if (pl_customer_cluster.IDREFPELANGGAN != null) { command.Parameters.AddWithValue("@IDREFPELANGGAN", pl_customer_cluster.IDREFPELANGGAN); } else { command.Parameters.AddWithValue("@IDREFPELANGGAN", DBNull.Value); } 
					if (pl_customer_cluster.HOUR_NUM != null) { command.Parameters.AddWithValue("@HOUR_NUM", pl_customer_cluster.HOUR_NUM); } else { command.Parameters.AddWithValue("@HOUR_NUM", DBNull.Value); } 
					if (pl_customer_cluster.CLUSTER_NUM != null) { command.Parameters.AddWithValue("@CLUSTER_NUM", pl_customer_cluster.CLUSTER_NUM); } else { command.Parameters.AddWithValue("@CLUSTER_NUM", DBNull.Value); } 
					if (pl_customer_cluster.FDVC_NORMALIZED != null) { command.Parameters.AddWithValue("@FDVC_NORMALIZED", pl_customer_cluster.FDVC_NORMALIZED); } else { command.Parameters.AddWithValue("@FDVC_NORMALIZED", DBNull.Value); } 
					command.ExecuteNonQuery();
				}
				catch (Exception ex)
				{
					Message = ex.Message;
				}
			}
		}

		public void AddMany(List<PL_CUSTOMER_CLUSTER> pl_customer_cluster)
		{
			using (var conn = new SqlConnection(connString))
			{
				try
				{
					Message = "";
					conn.Open();
					int pos = 0;
					foreach(PL_CUSTOMER_CLUSTER item in pl_customer_cluster)
					{
						SqlCommand command = new SqlCommand("INSERT INTO PL_CUSTOMER_CLUSTER ([ID], [DATE_STAMP], [IDREFPELANGGAN], [HOUR_NUM], [CLUSTER_NUM], [FDVC_NORMALIZED]) VALUES(@ID, @DATE_STAMP, @IDREFPELANGGAN, @HOUR_NUM, @CLUSTER_NUM, @FDVC_NORMALIZED)", conn);
						command.CommandType = System.Data.CommandType.Text;
						if (pl_customer_cluster[pos].ID != null) { command.Parameters.AddWithValue("@ID", pl_customer_cluster[pos].ID); } else { command.Parameters.AddWithValue("@ID", DBNull.Value); } 
						if (pl_customer_cluster[pos].DATE_STAMP != null) { command.Parameters.AddWithValue("@DATE_STAMP", pl_customer_cluster[pos].DATE_STAMP); } else { command.Parameters.AddWithValue("@DATE_STAMP", DBNull.Value); } 
						if (pl_customer_cluster[pos].IDREFPELANGGAN != null) { command.Parameters.AddWithValue("@IDREFPELANGGAN", pl_customer_cluster[pos].IDREFPELANGGAN); } else { command.Parameters.AddWithValue("@IDREFPELANGGAN", DBNull.Value); } 
						if (pl_customer_cluster[pos].HOUR_NUM != null) { command.Parameters.AddWithValue("@HOUR_NUM", pl_customer_cluster[pos].HOUR_NUM); } else { command.Parameters.AddWithValue("@HOUR_NUM", DBNull.Value); } 
						if (pl_customer_cluster[pos].CLUSTER_NUM != null) { command.Parameters.AddWithValue("@CLUSTER_NUM", pl_customer_cluster[pos].CLUSTER_NUM); } else { command.Parameters.AddWithValue("@CLUSTER_NUM", DBNull.Value); } 
						if (pl_customer_cluster[pos].FDVC_NORMALIZED != null) { command.Parameters.AddWithValue("@FDVC_NORMALIZED", pl_customer_cluster[pos].FDVC_NORMALIZED); } else { command.Parameters.AddWithValue("@FDVC_NORMALIZED", DBNull.Value); } 
						command.ExecuteNonQuery();
						pos = pos + 1;
					}
				}
				catch (Exception ex)
				{
					Message = ex.Message;
				}
			}
		}

		public void Update(PL_CUSTOMER_CLUSTER pl_customer_cluster)
		{
			using (var conn = new SqlConnection(connString))
			{
				try
				{
					Message = "";
					conn.Open();
					SqlCommand command = new SqlCommand("UPDATE PL_CUSTOMER_CLUSTER SET DATE_STAMP = @DATE_STAMP, IDREFPELANGGAN = @IDREFPELANGGAN, HOUR_NUM = @HOUR_NUM, CLUSTER_NUM = @CLUSTER_NUM, FDVC_NORMALIZED = @FDVC_NORMALIZED WHERE ID = @ID", conn);
					command.CommandType = System.Data.CommandType.Text;
					if (pl_customer_cluster.ID != null) { command.Parameters.AddWithValue("@ID", pl_customer_cluster.ID); } else { command.Parameters.AddWithValue("@ID", DBNull.Value); } 
					if (pl_customer_cluster.DATE_STAMP != null) { command.Parameters.AddWithValue("@DATE_STAMP", pl_customer_cluster.DATE_STAMP); } else { command.Parameters.AddWithValue("@DATE_STAMP", DBNull.Value); } 
					if (pl_customer_cluster.IDREFPELANGGAN != null) { command.Parameters.AddWithValue("@IDREFPELANGGAN", pl_customer_cluster.IDREFPELANGGAN); } else { command.Parameters.AddWithValue("@IDREFPELANGGAN", DBNull.Value); } 
					if (pl_customer_cluster.HOUR_NUM != null) { command.Parameters.AddWithValue("@HOUR_NUM", pl_customer_cluster.HOUR_NUM); } else { command.Parameters.AddWithValue("@HOUR_NUM", DBNull.Value); } 
					if (pl_customer_cluster.CLUSTER_NUM != null) { command.Parameters.AddWithValue("@CLUSTER_NUM", pl_customer_cluster.CLUSTER_NUM); } else { command.Parameters.AddWithValue("@CLUSTER_NUM", DBNull.Value); } 
					if (pl_customer_cluster.FDVC_NORMALIZED != null) { command.Parameters.AddWithValue("@FDVC_NORMALIZED", pl_customer_cluster.FDVC_NORMALIZED); } else { command.Parameters.AddWithValue("@FDVC_NORMALIZED", DBNull.Value); } 
					command.ExecuteNonQuery();
				}
				catch (Exception ex)
				{
					Message = ex.Message;
				}
			}
		}

		public void UpdateMany(List<PL_CUSTOMER_CLUSTER> pl_customer_clusters)
		{
			using (var conn = new SqlConnection(connString))
			{
				try
				{
					Message = "";
					conn.Open();
					foreach(PL_CUSTOMER_CLUSTER item in pl_customer_clusters)
					{
						SqlCommand command = new SqlCommand("UPDATE PL_CUSTOMER_CLUSTER SET DATE_STAMP = @DATE_STAMP, IDREFPELANGGAN = @IDREFPELANGGAN, HOUR_NUM = @HOUR_NUM, CLUSTER_NUM = @CLUSTER_NUM, FDVC_NORMALIZED = @FDVC_NORMALIZED WHERE ID = @ID", conn);
						command.CommandType = System.Data.CommandType.Text;
						if (item.ID != null) { command.Parameters.AddWithValue("@ID", item.ID); } else { command.Parameters.AddWithValue("@ID", DBNull.Value); } 
						if (item.DATE_STAMP != null) { command.Parameters.AddWithValue("@DATE_STAMP", item.DATE_STAMP); } else { command.Parameters.AddWithValue("@DATE_STAMP", DBNull.Value); } 
						if (item.IDREFPELANGGAN != null) { command.Parameters.AddWithValue("@IDREFPELANGGAN", item.IDREFPELANGGAN); } else { command.Parameters.AddWithValue("@IDREFPELANGGAN", DBNull.Value); } 
						if (item.HOUR_NUM != null) { command.Parameters.AddWithValue("@HOUR_NUM", item.HOUR_NUM); } else { command.Parameters.AddWithValue("@HOUR_NUM", DBNull.Value); } 
						if (item.CLUSTER_NUM != null) { command.Parameters.AddWithValue("@CLUSTER_NUM", item.CLUSTER_NUM); } else { command.Parameters.AddWithValue("@CLUSTER_NUM", DBNull.Value); } 
						if (item.FDVC_NORMALIZED != null) { command.Parameters.AddWithValue("@FDVC_NORMALIZED", item.FDVC_NORMALIZED); } else { command.Parameters.AddWithValue("@FDVC_NORMALIZED", DBNull.Value); } 
						command.ExecuteNonQuery();
					}
				}
				catch (Exception ex)
				{
					Message = ex.Message;
				}
			}
		}

		public void Remove(PL_CUSTOMER_CLUSTER id)
		{
			using (var conn = new SqlConnection(connString))
			{
				try
				{
					Message = "";
					conn.Open();
					SqlCommand command = new SqlCommand("DELETE PL_CUSTOMER_CLUSTER WHERE ID = @ID", conn);
					command.CommandType = System.Data.CommandType.Text;
					if (id.ID != null) { command.Parameters.AddWithValue("@ID", id.ID); } else { command.Parameters.AddWithValue("@ID", DBNull.Value); } 
					command.ExecuteNonQuery();
				}
				catch (Exception ex)
				{
					Message = ex.Message;
				}
			}
		}

		public List<PL_CUSTOMER_CLUSTER> GetData()
		{
			List<PL_CUSTOMER_CLUSTER> items = new List<PL_CUSTOMER_CLUSTER>();
			using (var conn = new SqlConnection(connString))
			{
				Message = "";
				try
				{
					conn.Open();
					SqlCommand command = new SqlCommand("SELECT [ID], [DATE_STAMP], [IDREFPELANGGAN], [HOUR_NUM], [CLUSTER_NUM], [FDVC_NORMALIZED] FROM PL_CUSTOMER_CLUSTER", conn);
					SqlDataReader reader = command.ExecuteReader();
					PL_CUSTOMER_CLUSTER item = new PL_CUSTOMER_CLUSTER();
					while(reader.Read())
					{
						item = new PL_CUSTOMER_CLUSTER();
						if (reader[0] != DBNull.Value) { item.ID = Convert.ToInt32(reader[0]); }
						if (reader[1] != DBNull.Value) { item.DATE_STAMP = Convert.ToDateTime(reader[1]); }
						if (reader[2] != DBNull.Value) { item.IDREFPELANGGAN = Convert.ToString(reader[2]); }
						if (reader[3] != DBNull.Value) { item.HOUR_NUM = Convert.ToInt32(reader[3]); }
						if (reader[4] != DBNull.Value) { item.CLUSTER_NUM = Convert.ToInt32(reader[4]); }
						if (reader[5] != DBNull.Value) { item.FDVC_NORMALIZED = Convert.ToDouble(reader[5]); }
						items.Add(item);
					}
				}
				catch (Exception ex)
				{
					Message = ex.Message;
				}
			}
			return items;
		}

		public List<PL_CUSTOMER_CLUSTER> GetCentroid()
		{
			List<PL_CUSTOMER_CLUSTER> items = new List<PL_CUSTOMER_CLUSTER>();
			using (var conn = new SqlConnection(connString))
			{
				Message = "";
				try
				{
					conn.Open();
					SqlCommand command = new SqlCommand("SELECT * FROM [SIPG].[dbo].[PL_CUSTOMER_CLUSTER] WHERE CLUSTER_NUM LIKE '%0%' AND DATE_STAMP = '2020-11-01' AND IDREFPELANGGAN IN ('CENTROID_ID0', '014577739', '0140019647', '014525646','0140019671' , '014517181') ORDER  BY IDREFPELANGGAN, HOUR_NUM", conn);
					SqlDataReader reader = command.ExecuteReader();
					PL_CUSTOMER_CLUSTER item = new PL_CUSTOMER_CLUSTER();
					while (reader.Read())
					{
						item = new PL_CUSTOMER_CLUSTER();
						if (reader[0] != DBNull.Value) { item.ID = Convert.ToInt32(reader[0]); }
						if (reader[1] != DBNull.Value) { item.DATE_STAMP = Convert.ToDateTime(reader[1]); }
						if (reader[2] != DBNull.Value) { item.IDREFPELANGGAN = Convert.ToString(reader[2]); }
						if (reader[3] != DBNull.Value) { item.HOUR_NUM = Convert.ToInt32(reader[3]); }
						if (reader[4] != DBNull.Value) { item.CLUSTER_NUM = Convert.ToInt32(reader[4]); }
						if (reader[5] != DBNull.Value) { item.FDVC_NORMALIZED = Convert.ToDouble(reader[5]); }
						items.Add(item);
					}
				}
				catch (Exception ex)
				{
					Message = ex.Message;
				}
			}
			return items;
		}

		

		public List<PL_CUSTOMER_CLUSTER3> GetGMSL()
		{
			List<PL_CUSTOMER_CLUSTER3> items = new List<PL_CUSTOMER_CLUSTER3>();
			using (var conn = new SqlConnection(connString))
			{
				Message = "";
				try
				{
					conn.Open();
					SqlCommand command = new SqlCommand("SELECT TOP (100) [ID], [DATE_TIME], [OP], [CL] FROM [SIPG].[dbo].[GMSL] ORDER BY DATE_TIME", conn);
					SqlDataReader reader = command.ExecuteReader();
					PL_CUSTOMER_CLUSTER3 item = new PL_CUSTOMER_CLUSTER3();
					while (reader.Read())
					{
						item = new PL_CUSTOMER_CLUSTER3();
						if (reader[0] != DBNull.Value) { item.ID = Convert.ToInt32(reader[0]); }
						if (reader[1] != DBNull.Value) { item.DATE_TIME = Convert.ToDateTime(reader[1]); }
						if (reader[2] != DBNull.Value) { item.OP = Convert.ToInt32(reader[2]); }
						if (reader[3] != DBNull.Value) { item.CL = Convert.ToInt32(reader[3]); }
						
						items.Add(item);
					}
				}
				catch (Exception ex)
				{
					Message = ex.Message;
				}
			}
			return items;
		}


		public List<PL_CUSTOMER_CLUSTER2> GetPopulation()
		{
			List<PL_CUSTOMER_CLUSTER2> items = new List<PL_CUSTOMER_CLUSTER2>();
			using (var conn = new SqlConnection(connString))
			{
				Message = "";
				try
				{
					conn.Open();
					SqlCommand command = new SqlCommand("SELECT TOP (100) [CityID],[CityName],[Population] FROM[SIPG].[dbo].[CityPopulationTable]", conn);
					SqlDataReader reader = command.ExecuteReader();
					PL_CUSTOMER_CLUSTER2 item = new PL_CUSTOMER_CLUSTER2();
					while (reader.Read())
					{
						item = new PL_CUSTOMER_CLUSTER2();
						if (reader[0] != DBNull.Value) { item.CityID = Convert.ToInt32(reader[0]); }
						if (reader[1] != DBNull.Value) { item.CityName = Convert.ToString(reader[1]); }
						if (reader[2] != DBNull.Value) { item.Population = Convert.ToInt32(reader[2]); }
						
						items.Add(item);
					}
				}
				catch (Exception ex)
				{
					Message = ex.Message;
				}
			}
			return items;
		}


		public List<PL_CUSTOMER_CLUSTER> GetDataByID(int ID)
		{
			List<PL_CUSTOMER_CLUSTER> items = new List<PL_CUSTOMER_CLUSTER>();
			using (var conn = new SqlConnection(connString))
			{
				Message = "";
				try
				{
					conn.Open();
					SqlCommand command = new SqlCommand("SELECT [ID], [DATE_STAMP], [IDREFPELANGGAN], [HOUR_NUM], [CLUSTER_NUM], [FDVC_NORMALIZED] FROM PL_CUSTOMER_CLUSTER WHERE ID = @ID", conn);
					command.Parameters.AddWithValue("@ID", ID);
					SqlDataReader reader = command.ExecuteReader();
					PL_CUSTOMER_CLUSTER item = new PL_CUSTOMER_CLUSTER();
					while(reader.Read())
					{
						item = new PL_CUSTOMER_CLUSTER();
						if (reader[0] != DBNull.Value) { item.ID = Convert.ToInt32(reader[0]); }
						if (reader[1] != DBNull.Value) { item.DATE_STAMP = Convert.ToDateTime(reader[1]); }
						if (reader[2] != DBNull.Value) { item.IDREFPELANGGAN = Convert.ToString(reader[2]); }
						if (reader[3] != DBNull.Value) { item.HOUR_NUM = Convert.ToInt32(reader[3]); }
						if (reader[4] != DBNull.Value) { item.CLUSTER_NUM = Convert.ToInt32(reader[4]); }
						if (reader[5] != DBNull.Value) { item.FDVC_NORMALIZED = Convert.ToDouble(reader[5]); }
						items.Add(item);
					}
				}
				catch (Exception ex)
				{
					Message = ex.Message;
				}
			}
			return items;
		}

		public void RemoveByID(int id)
		{
			using (var conn = new SqlConnection(connString))
			{
				try
				{
					Message = "";
					conn.Open();
					SqlCommand command = new SqlCommand("DELETE PL_CUSTOMER_CLUSTER WHERE ID = @ID", conn);
					command.CommandType = System.Data.CommandType.Text;
					if (id != null) { command.Parameters.AddWithValue("@ID", id); } else { command.Parameters.AddWithValue("@ID", DBNull.Value); } 
					command.ExecuteNonQuery();
				}
				catch (Exception ex)
				{
					Message = ex.Message;
				}
			}
		}

		public DataTable GetDataTable(List<PL_CUSTOMER_CLUSTER> pl_customer_cluster)
		{
			DataTable dt = new DataTable("PL_CUSTOMER_CLUSTER");

			DataColumn c1 = new DataColumn("ID", typeof(int)); 
			dt.Columns.Add(c1);
			DataColumn c2 = new DataColumn("DATE_STAMP", typeof(DateTime)); c2.AllowDBNull = true;
			dt.Columns.Add(c2);
			DataColumn c3 = new DataColumn("IDREFPELANGGAN", typeof(string)); c3.AllowDBNull = true;
			dt.Columns.Add(c3);
			DataColumn c4 = new DataColumn("HOUR_NUM", typeof(int)); c4.AllowDBNull = true;
			dt.Columns.Add(c4);
			DataColumn c5 = new DataColumn("CLUSTER_NUM", typeof(int)); c5.AllowDBNull = true;
			dt.Columns.Add(c5);
			DataColumn c6 = new DataColumn("FDVC_NORMALIZED", typeof(double)); c6.AllowDBNull = true;
			dt.Columns.Add(c6);

			foreach (PL_CUSTOMER_CLUSTER v in pl_customer_cluster)
			{
				DataRow dr = dt.NewRow();
				if (v.ID != null) { dr[0] = v.ID; } else { dr[0] = DBNull.Value; }
				if (v.DATE_STAMP != null) { dr[1] = v.DATE_STAMP; } else { dr[1] = DBNull.Value; }
				if (v.IDREFPELANGGAN != null) { dr[2] = v.IDREFPELANGGAN; } else { dr[2] = DBNull.Value; }
				if (v.HOUR_NUM != null) { dr[3] = v.HOUR_NUM; } else { dr[3] = DBNull.Value; }
				if (v.CLUSTER_NUM != null) { dr[4] = v.CLUSTER_NUM; } else { dr[4] = DBNull.Value; }
				if (v.FDVC_NORMALIZED != null) { dr[5] = v.FDVC_NORMALIZED; } else { dr[5] = DBNull.Value; }
				dt.Rows.Add(dr);
			}
			dt.AcceptChanges();

			return dt;
		}

		public void AddManyBulk(List<PL_CUSTOMER_CLUSTER> pl_customer_cluster)
		{
			using (var conn = new SqlConnection(connString))
			{
				try
				{
					Message = "";
					conn.Open();

					DataTable dt = GetDataTable(pl_customer_cluster);
					using (SqlBulkCopy bulkCopy = new SqlBulkCopy(connString))
					{
						bulkCopy.DestinationTableName = dt.TableName;
						bulkCopy.WriteToServer(dt);
					}
				}
				catch (Exception ex)
				{
					Message = ex.Message;
				}
			}
		}

	}
}