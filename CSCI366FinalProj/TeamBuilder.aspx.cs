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
        static List<String> pokemonForTeam = new List<string>();
        static List<String> nicknamesForTeam = new List<string>();
        bool initialLoad = false;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                conn.Open();
                NpgsqlCommand comm1 = new NpgsqlCommand();
                comm1.Connection = conn;
                comm1.CommandType = CommandType.Text;
                comm1.CommandText = "select pokemon_name from pokemon";
                Pokemon1Dropdown.DataSource = comm1.ExecuteReader();
                Pokemon1Dropdown.DataTextField = "pokemon_name";
                Pokemon1Dropdown.DataBind();
                comm1.Dispose();
                conn.Close();
                Label6.Text = "";
            }
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            nicknamesForTeam.Add(NicknameBox.Text);
            pokemonForTeam.Add(Pokemon1Dropdown.SelectedValue);
            NicknameBox.Text = "";

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            NpgsqlCommand comm1 = new NpgsqlCommand();
            comm1.Connection = conn;
            comm1.CommandType = CommandType.Text;

            string command = "insert into team values(default"+ ",'" + TrainerNameBox.Text + "','" +
            pokemonForTeam[0] + "','" + nicknamesForTeam[0] + "','" +
            pokemonForTeam[1] + "','" + nicknamesForTeam[1] + "','" +
            pokemonForTeam[2] + "','" + nicknamesForTeam[2] + "','" +
            pokemonForTeam[3] + "','" + nicknamesForTeam[3] + "','" +
            pokemonForTeam[4] + "','" + nicknamesForTeam[4] + "','" +
            pokemonForTeam[5] + "','" + nicknamesForTeam[5] + "')";

            comm1.CommandText = command;
            comm1.ExecuteNonQuery();
            comm1.Dispose();
            conn.Close();

            Label6.Text = "Team created! Click \"View Teams\" to see the list of teams";

        }
    }
}
