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
    public partial class TeamBuilder : System.Web.UI.Page
    {
        NpgsqlConnection conn = new NpgsqlConnection(Connection.ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {
            conn.Open();
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = "select pokemon_name from pokemon";
            NpgsqlDataAdapter nda = new NpgsqlDataAdapter(comm);
            DataTable dt = new DataTable();
            nda.Fill(dt);
            DropDownList1.DataSource = comm.ExecuteReader();
            DropDownList1.DataTextField = "pokemon_name";
            DropDownList1.DataBind();
            comm.Dispose();
            conn.Close();

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}