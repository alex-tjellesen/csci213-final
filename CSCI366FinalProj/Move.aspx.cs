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
    public partial class Move : System.Web.UI.Page
    {
        NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=CSCI366FinalProject;User ID=postgres;Password=Bananaslug11");

        protected void Page_Load(object sender, EventArgs e)
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
    }
}