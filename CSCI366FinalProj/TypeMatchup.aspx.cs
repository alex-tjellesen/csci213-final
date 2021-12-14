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
    public partial class TypeMatchup : System.Web.UI.Page
    {
        NpgsqlConnection conn = new NpgsqlConnection(Connection.ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = "select multiplier from type_matchup where offensive_type like '" + TextBox1.Text + "' and defensive_type like '" + TextBox2.Text + "'";
            Label1.Text = "Damage Multiplier: " + comm.ExecuteScalar();
            comm.Dispose();
            conn.Close();
        }
    }
}