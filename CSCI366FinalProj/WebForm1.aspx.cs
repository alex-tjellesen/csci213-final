using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Npgsql;
using System.Data;

namespace CSCI366FinalProj
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        NpgsqlConnection conn = new NpgsqlConnection(Connection.ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {
            
                
                //conn.Open();
                //NpgsqlCommand comm = new NpgsqlCommand();
                //comm.Connection = conn;
                //comm.CommandType = CommandType.Text;
                //comm.CommandText = "select * from move";
                //NpgsqlDataAdapter nda = new NpgsqlDataAdapter(comm);
                //DataTable dt = new DataTable();
                //nda.Fill(dt);
                //comm.Dispose();
                //conn.Close();
                //GridView1.DataSource = dt;
                //GridView1.DataBind();
            
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = "select * from move";
            NpgsqlDataAdapter nda = new NpgsqlDataAdapter(comm);
            DataTable dt = new DataTable();
            nda.Fill(dt);
            comm.Dispose();
            conn.Close();
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = "select * from pokemon";
            NpgsqlDataAdapter nda = new NpgsqlDataAdapter(comm);
            DataTable dt = new DataTable();
            nda.Fill(dt);
            comm.Dispose();
            conn.Close();
            GridView2.DataSource = dt;
            GridView2.DataBind();
        }
    }
}