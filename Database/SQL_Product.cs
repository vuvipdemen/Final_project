using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StoreManager.StoreStructor.Strutor;
using System.Windows.Forms;
using System.Data.SqlClient;
using StoreManager.StoreStructor.EC;

namespace StoreManager.DataBase
{
	class SQL_Product
	{
		ConnectDB cn = new ConnectDB();
		public bool kiemtrasp(string masp)
		{
			return cn.kiemtra("select count(*) from [db_Product] where IdProduct=N'" + masp + "'");
		}
		public void addsp(EC_Product sp)
		{
			SqlConnection con = cn.getcon();
			try
			{

				con.Open();
				string sql = @"INSERT INTO db_Product
					  (IdProduct, NameProduct, IdSector, IdUnit, Quantity, PriceI, PriceS, Warranty)
							 VALUES (N'" + sp.IDPRODUCT + "',N'" + sp.NAMEPRODUCT + "',N'" + sp.IDSECTOR + "',N'" + sp.IDUNIT + "',N'" + sp.QUANTITY + "',N'" + sp.PRICEI + "',N'" + sp.PRICEs + "',N'" + sp.THOAIGIANBH + "')";
				SqlCommand cmd = new SqlCommand(sql, con);
				cmd.ExecuteNonQuery();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				con.Close();
			}
		}
		public void xoasp(EC_Product sp)
		{
			cn.ExcuteNonQuery("DELETE FROM [db_Product] WHERE  IdProduct=N'" + sp.IDPRODUCT + "'");
		}

		public void suasp(EC_Product sp)
		{
			SqlConnection con = cn.getcon();
			try
			{
				con.Open();
				string sql = @"UPDATE    db_Product
				SET NameProduct =N'" + sp.NAMEPRODUCT + "', IdSector =N'" + sp.IDSECTOR + "', IdUnit =N'" + sp.IDUNIT + "', Quantity =N'" + sp.QUANTITY + "', PriceI =N'" + sp.PRICEI + "', PriceS =N'" + sp.PRICEs + "', Warranty =N'" + sp.THOAIGIANBH + "'";
				SqlCommand cmd = new SqlCommand(sql, con);
				cmd.ExecuteNonQuery();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				con.Close();
			}
		}
		//load loại
		public void loadmal(ComboBox mal)
		{
            cn.LoadLenCombobox(mal, "SELECT     IdSector FROM db_Sector", 0);
		}
		public string LoadNameSector(string tenl, string mal)
		{
            tenl = cn.LoadLable("SELECT [NameSector] From [db_Sector] where IdSector= N'" + mal + "'");
			return tenl;
		}

		//load dvt
		public void loadmadv(ComboBox madv)
		{
            cn.LoadLenCombobox(madv, "SELECT     IdUnit FROM db_Unit", 0);
		}
		public string Loadtendv(string tendv, string madv)
		{
            tendv = cn.LoadLable("SELECT [NameUnit] From [db_Unit] where IdUnit= N'" + madv + "'");
			return tendv;
		}

	}
}
