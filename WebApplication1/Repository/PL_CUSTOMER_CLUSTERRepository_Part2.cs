using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Cluster.Models;

namespace Cluster.Repositories
{
	public partial class PL_CUSTOMER_CLUSTERRepository
	{
		public List<PL_CUSTOMER_CLUSTER> GetCustomer_byCluster(DateTime date, int cluster)
		{
			List<PL_CUSTOMER_CLUSTER> items = new List<PL_CUSTOMER_CLUSTER>();
			using (var conn = new SqlConnection(connString))
			{
				Message = "";
				try
				{
					conn.Open();
					SqlCommand command = new SqlCommand(" SELECT * FROM [SIPG].[dbo].[PL_CUSTOMER_CLUSTER] WHERE CLUSTER_NUM = "+ Convert.ToString(cluster) + " AND DATE_STAMP = '" + date.ToString("yyyy-MM-dd") + "' ORDER BY IDREFPELANGGAN ASC", conn);
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

		public List<PL_CUSTOMER_CLUSTER> GetDataPelanggan()
		{
			List<PL_CUSTOMER_CLUSTER> items = new List<PL_CUSTOMER_CLUSTER>();
			using (var conn = new SqlConnection(connString))
			{
				Message = "";
				try
				{
					conn.Open();
					SqlCommand command = new SqlCommand("SELECT [DATE_STAMP],[IDREFPELANGGAN],[NAMA],[HOUR_NUM],[CLUSTER_NUM],[FDVC_NORMALIZED]FROM [SIPG].[dbo].[VW_AA_DATAPELANGGAN_V1] WHERE CLUSTER_NUM = 0 ORDER BY DATE_STAMP, IDREFPELANGGAN, CLUSTER_NUM, HOUR_NUM", conn);
					SqlDataReader reader = command.ExecuteReader();
					PL_CUSTOMER_CLUSTER item = new PL_CUSTOMER_CLUSTER();
					while (reader.Read())
					{
						item = new PL_CUSTOMER_CLUSTER();
						if (reader[0] != DBNull.Value) { item.DATE_STAMP = Convert.ToDateTime(reader[0]); }
						if (reader[1] != DBNull.Value) { item.IDREFPELANGGAN = Convert.ToString(reader[1]); }
						if (reader[2] != DBNull.Value) { item.NAMA = Convert.ToString(reader[2]); }
						if (reader[3] != DBNull.Value) { item.HOUR_NUM = Convert.ToInt32(reader[3]); }
						if (reader[4] != DBNull.Value) { item.CLUSTER_NUM = Convert.ToInt32(reader[4]); }
						if (reader[5] != DBNull.Value) { item.FDVC_NORMALIZED = Convert.ToInt32(reader[5]); }
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

		public List<PL_CUSTOMER_CLUSTER4> GetDataPelanggan2()
		{
			List<PL_CUSTOMER_CLUSTER4> items = new List<PL_CUSTOMER_CLUSTER4>();
			using (var conn = new SqlConnection(connString))
			{
				Message = "";
				try
				{
					conn.Open();
					SqlCommand command = new SqlCommand("SELECT [DATE_STAMP],[MONTH],[YEAR],[IDREFPELANGGAN],[NAMA],[CLUSTER_NUM]FROM [SIPG].[dbo].[VW_AA_DATAPELANGGAN] ORDER BY CLUSTER_NUM ASC", conn);
					SqlDataReader reader = command.ExecuteReader();
					PL_CUSTOMER_CLUSTER4 item = new PL_CUSTOMER_CLUSTER4();
					while (reader.Read())
					{
						item = new PL_CUSTOMER_CLUSTER4();
						if (reader[0] != DBNull.Value) { item.DATE_STAMP = Convert.ToDateTime(reader[0]); }
						if (reader[1] != DBNull.Value) { item.MONTH = Convert.ToString(reader[1]); }
						if (reader[2] != DBNull.Value) { item.YEAR = Convert.ToInt32(reader[2]); }
						if (reader[3] != DBNull.Value) { item.IDREFPELANGGAN = Convert.ToString(reader[3]); }
						if (reader[4] != DBNull.Value) { item.NAMA = Convert.ToString(reader[4]); }
						if (reader[5] != DBNull.Value) { item.CLUSTER_NUM = Convert.ToInt32(reader[5]); }
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

		public List<PL_CUSTOMER_CLUSTER> GetCustomer(int ID, string MONTH, int YEAR)
		{
			List<PL_CUSTOMER_CLUSTER> items = new List<PL_CUSTOMER_CLUSTER>();
			using (var conn = new SqlConnection(connString))
			{
				Message = "";
				try
				{
					conn.Open();
					SqlCommand command = new SqlCommand("SELECT DISTINCT [DATE_STAMP],[MONTH],[YEAR],[IDREFPELANGGAN],[NAMA],[CLUSTER_NUM] FROM [SIPG].[dbo].[VW_AA_DATAPELANGGAN_V1]  where CLUSTER_NUM = @ID and MONTH = @MONTH and YEAR = @YEAR AND NAMA NOT LIKE '%CENTROID%' ORDER BY NAMA DESC", conn);
					command.Parameters.AddWithValue("@ID", ID);
					command.Parameters.AddWithValue("@MONTH", MONTH);
					command.Parameters.AddWithValue("@YEAR", YEAR);
					SqlDataReader reader = command.ExecuteReader();
					PL_CUSTOMER_CLUSTER item = new PL_CUSTOMER_CLUSTER();
					while (reader.Read())
					{
						item = new PL_CUSTOMER_CLUSTER();
						if (reader[0] != DBNull.Value) { item.DATE_STAMP = Convert.ToDateTime(reader[0]); }
						if (reader[1] != DBNull.Value) { item.MONTH = Convert.ToString(reader[1]); }
						if (reader[2] != DBNull.Value) { item.YEAR = Convert.ToInt32(reader[2]); }
						if (reader[3] != DBNull.Value) { item.IDREFPELANGGAN = Convert.ToString(reader[3]); }
						if (reader[4] != DBNull.Value) { item.NAMA = Convert.ToString(reader[4]); }
						if (reader[5] != DBNull.Value) { item.CLUSTER_NUM = Convert.ToInt32(reader[5]); }
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
		
		public List<PL_CUSTOMER_CLUSTER> GetCustomerData(int ID, string MONTH, int YEAR)
		{
			List<PL_CUSTOMER_CLUSTER> items = new List<PL_CUSTOMER_CLUSTER>();
			using (var conn = new SqlConnection(connString))
			{
				Message = "";
				try
				{
					conn.Open();
					SqlCommand command = new SqlCommand("SELECT [DATE_STAMP],[MONTH],[YEAR],[IDREFPELANGGAN],COALESCE(NAMA, [IDREFPELANGGAN]) As NAMA,[CLUSTER_NUM], [HOUR_NUM], [FDVC_NORMALIZED] FROM [SIPG].[dbo].[VW_AA_DATAPELANGGAN_V1]  where CLUSTER_NUM = @ID and MONTH = @MONTH and YEAR = @YEAR ORDER BY DATE_STAMP, IDREFPELANGGAN, CLUSTER_NUM, HOUR_NUM", conn);
					command.Parameters.AddWithValue("@ID", ID);
					command.Parameters.AddWithValue("@MONTH", MONTH);
					command.Parameters.AddWithValue("@YEAR", YEAR);
					SqlDataReader reader = command.ExecuteReader();
					PL_CUSTOMER_CLUSTER item = new PL_CUSTOMER_CLUSTER();
					while (reader.Read())
					{
						item = new PL_CUSTOMER_CLUSTER();
						if (reader[0] != DBNull.Value) { item.DATE_STAMP = Convert.ToDateTime(reader[0]); }
						if (reader[1] != DBNull.Value) { item.MONTH = Convert.ToString(reader[1]); }
						if (reader[2] != DBNull.Value) { item.YEAR = Convert.ToInt32(reader[2]); }
						if (reader[3] != DBNull.Value) { item.IDREFPELANGGAN = Convert.ToString(reader[3]); }
						if (reader[4] != DBNull.Value) { item.NAMA = Convert.ToString(reader[4]); }
						if (reader[5] != DBNull.Value) { item.CLUSTER_NUM = Convert.ToInt32(reader[5]); }
						if (reader[6] != DBNull.Value) { item.HOUR_NUM = Convert.ToInt32(reader[6]); }
						if (reader[7] != DBNull.Value) { item.FDVC_NORMALIZED = Convert.ToDouble(reader[7]); }

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

		public List<PL_CUSTOMER_CLUSTER> GetCentroid2()
		{
			List<PL_CUSTOMER_CLUSTER> items = new List<PL_CUSTOMER_CLUSTER>();
			using (var conn = new SqlConnection(connString))
			{
				Message = "";
				try
				{
					conn.Open();
					SqlCommand command = new SqlCommand("SELECT[ID],[DATE_STAMP],COALESCE(NAMA, [IDREFPELANGGAN]) As NAMA,[IDREFPELANGGAN],[HOUR_NUM],[CLUSTER_NUM],[FDVC_NORMALIZED] FROM[SIPG].[dbo].[VW_AA_DATAPELANGGAN_V1] WHERE CLUSTER_NUM LIKE '%0%' AND DATE_STAMP = '2020-11-01' AND IDREFPELANGGAN IN('CENTROID_ID0', '014577739', '0140019647', '014525646', '0140019671', '014517181') ORDER  BY IDREFPELANGGAN, HOUR_NUM", conn);
					SqlDataReader reader = command.ExecuteReader();
					PL_CUSTOMER_CLUSTER item = new PL_CUSTOMER_CLUSTER();
					while (reader.Read())
					{
						item = new PL_CUSTOMER_CLUSTER();
						if (reader[0] != DBNull.Value) { item.ID = Convert.ToInt32(reader[0]); }
						if (reader[1] != DBNull.Value) { item.DATE_STAMP = Convert.ToDateTime(reader[1]); }
						if (reader[2] != DBNull.Value) { item.NAMA = Convert.ToString(reader[2]); }
						if (reader[2] != DBNull.Value) { item.IDREFPELANGGAN = Convert.ToString(reader[3]); }
						if (reader[3] != DBNull.Value) { item.HOUR_NUM = Convert.ToInt32(reader[4]); }
						if (reader[4] != DBNull.Value) { item.CLUSTER_NUM = Convert.ToInt32(reader[5]); }
						if (reader[5] != DBNull.Value) { item.FDVC_NORMALIZED = Convert.ToDouble(reader[6]); }
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
		public List<PL_CUSTOMER_CLUSTER> GetCentroid3()
		{
			List<PL_CUSTOMER_CLUSTER> items = new List<PL_CUSTOMER_CLUSTER>();
			using (var conn = new SqlConnection(connString))
			{
				Message = "";
				try
				{
					conn.Open();
					SqlCommand command = new SqlCommand("SELECT[ID],[DATE_STAMP],COALESCE(NAMA, [IDREFPELANGGAN]) As NAMA,[IDREFPELANGGAN],[HOUR_NUM],[CLUSTER_NUM],[FDVC_NORMALIZED] FROM[SIPG].[dbo].[VW_AA_DATAPELANGGAN_V1] WHERE CLUSTER_NUM IN (0,1)  AND DATE_STAMP = '2020-11-01' AND IDREFPELANGGAN IN('CENTROID_ID0', 'CENTROID_ID1', '0140019647', '014525646', '0140019671', '014517181')ORDER  BY IDREFPELANGGAN, HOUR_NUM", conn);
					SqlDataReader reader = command.ExecuteReader();
					PL_CUSTOMER_CLUSTER item = new PL_CUSTOMER_CLUSTER();
					while (reader.Read())
					{
						item = new PL_CUSTOMER_CLUSTER();
						if (reader[0] != DBNull.Value) { item.ID = Convert.ToInt32(reader[0]); }
						if (reader[1] != DBNull.Value) { item.DATE_STAMP = Convert.ToDateTime(reader[1]); }
						if (reader[2] != DBNull.Value) { item.NAMA = Convert.ToString(reader[2]); }
						if (reader[2] != DBNull.Value) { item.IDREFPELANGGAN = Convert.ToString(reader[3]); }
						if (reader[3] != DBNull.Value) { item.HOUR_NUM = Convert.ToInt32(reader[4]); }
						if (reader[4] != DBNull.Value) { item.CLUSTER_NUM = Convert.ToInt32(reader[5]); }
						if (reader[5] != DBNull.Value) { item.FDVC_NORMALIZED = Convert.ToDouble(reader[6]); }
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


		public List<PL_CUSTOMER_CLUSTER> GetClusterByID(int ID)
		{
		List<PL_CUSTOMER_CLUSTER> items = new List<PL_CUSTOMER_CLUSTER>();
			using (var conn = new SqlConnection(connString))
			{
				Message = "";
				try
				{
					conn.Open();
					SqlCommand command = new SqlCommand("SELECT [ID], [DATE_STAMP], COALESCE(NAMA, [IDREFPELANGGAN]) As NAMA, [IDREFPELANGGAN], [HOUR_NUM], [CLUSTER_NUM], [FDVC_NORMALIZED] FROM [SIPG].[dbo].[VW_AA_DATAPELANGGAN_V1] WHERE CLUSTER_NUM = @ID  AND DATE_STAMP = '2020-11-01' AND IDREFPELANGGAN IN('CENTROID_ID0', 'CENTROID_ID1', '0140019647', '014525646', '0140019671', '014517181') ORDER  BY IDREFPELANGGAN, HOUR_NUM", conn);
					command.Parameters.AddWithValue("@ID", ID);
					SqlDataReader reader = command.ExecuteReader();
					PL_CUSTOMER_CLUSTER item = new PL_CUSTOMER_CLUSTER();
					while (reader.Read())
					{
						item = new PL_CUSTOMER_CLUSTER();
						if (reader[0] != DBNull.Value) { item.ID = Convert.ToInt32(reader[0]); }
						if (reader[1] != DBNull.Value) { item.DATE_STAMP = Convert.ToDateTime(reader[1]); }
						if (reader[2] != DBNull.Value) { item.NAMA = Convert.ToString(reader[2]); }
						if (reader[3] != DBNull.Value) { item.IDREFPELANGGAN = Convert.ToString(reader[3]); }
						if (reader[4] != DBNull.Value) { item.HOUR_NUM = Convert.ToInt32(reader[4]); }
						if (reader[5] != DBNull.Value) { item.CLUSTER_NUM = Convert.ToInt32(reader[5]); }
						if (reader[6] != DBNull.Value) { item.FDVC_NORMALIZED = Convert.ToDouble(reader[6]); }
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
		
		public List<PL_CUSTOMER_CLUSTER> GetDateByID(DateTime date)
		{
		List<PL_CUSTOMER_CLUSTER> items = new List<PL_CUSTOMER_CLUSTER>();
			using (var conn = new SqlConnection(connString))
			{
				Message = "";
				//DATETIME = "'" + DATETIME + "'";
				try
				{
					conn.Open();
					
					SqlCommand command = new SqlCommand("SELECT [ID], [DATE_STAMP], COALESCE(NAMA, [IDREFPELANGGAN]) As NAMA, [IDREFPELANGGAN], [HOUR_NUM], [CLUSTER_NUM], [FDVC_NORMALIZED] FROM[SIPG].[dbo].[VW_AA_DATAPELANGGAN_V1] WHERE CLUSTER_NUM in (0,1)  AND DATE_STAMP =  '" + date.ToString("yyyy-MM-dd") + "'  AND IDREFPELANGGAN IN('CENTROID_ID0', 'CENTROID_ID1', '0140019647', '014525646', '0140019671', '014517181') ORDER  BY DATE_STAMP,IDREFPELANGGAN, HOUR_NUM", conn);
					//command.Parameters.AddWithValue("@ID", ID);
					command.Parameters.AddWithValue("@DATE", date);
					SqlDataReader reader = command.ExecuteReader();
					PL_CUSTOMER_CLUSTER item = new PL_CUSTOMER_CLUSTER();
					while (reader.Read())
					{
						item = new PL_CUSTOMER_CLUSTER();
						if (reader[0] != DBNull.Value) { item.ID = Convert.ToInt32(reader[0]); }
						if (reader[1] != DBNull.Value) { item.DATE_STAMP = Convert.ToDateTime(reader[1]); }
						if (reader[2] != DBNull.Value) { item.NAMA = Convert.ToString(reader[2]); }
						if (reader[3] != DBNull.Value) { item.IDREFPELANGGAN = Convert.ToString(reader[3]); }
						if (reader[4] != DBNull.Value) { item.HOUR_NUM = Convert.ToInt32(reader[4]); }
						if (reader[5] != DBNull.Value) { item.CLUSTER_NUM = Convert.ToInt32(reader[5]); }
						if (reader[6] != DBNull.Value) { item.FDVC_NORMALIZED = Convert.ToDouble(reader[6]); }
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

	}


}