﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DatabaseConnects
    {
        SqlConnection GetConnection;

        private void KetnoiCSDL()

        {

            GetConnection = new SqlConnection("Data Source=DRIXT\\DRIXTSQLSERVER;Initial Catalog=GrabDataBase;Integrated Security=True");

            GetConnection.Open();

        }

        private void NgatKetNoi()

        {

            GetConnection.Close();

            GetConnection.Dispose();

        }


        public DataTable SQL_Laydulieu(string TenSP)

        {

            KetnoiCSDL();

            SqlCommand cmd = new SqlCommand(TenSP, GetConnection);

            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            da.Fill(dt);

            NgatKetNoi();

            return dt;

        }

        public DataTable SQL_LaydulieuDK(string TenSP, string[] name, object[] value, int Npara)

        {

            KetnoiCSDL();

            SqlCommand cmd = new SqlCommand(TenSP, GetConnection);

            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            for (int i = 0; i < Npara; i++)

            {

                cmd.Parameters.AddWithValue(name[i], value[i]);

            }

            DataTable dt = new DataTable();

            da.Fill(dt);

            NgatKetNoi();

            return dt;

        }

        public int SQL_Thuchien(string TenSP, string[] name, object[] value, int Npara)

        {

            KetnoiCSDL();

            SqlCommand cmd = new SqlCommand(TenSP, GetConnection);

            cmd.CommandType = CommandType.StoredProcedure;

            for (int i = 0; i < Npara; i++)

            {

                cmd.Parameters.AddWithValue(name[i], value[i]);

            }

            return cmd.ExecuteNonQuery();

        }
    }
}
