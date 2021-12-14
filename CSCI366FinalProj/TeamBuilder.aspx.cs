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
        List<String> pokemonForTeam = new List<string>();
        List<String> nicknamesForTeam = new List<string>();
        String test1 = "";
        String test2= "";
        String test3 = "";
        String test4 = "";
        String test5 = "";
        String test6 = "";



        protected void Page_Load(object sender, EventArgs e)
        {
            conn.Open();
            NpgsqlCommand comm1= new NpgsqlCommand();
            comm1.Connection = conn;
            comm1.CommandType = CommandType.Text;
            comm1.CommandText = "select pokemon_name from pokemon";
            Pokemon1Dropdown.DataSource = comm1.ExecuteReader();
            Pokemon1Dropdown.DataTextField = "pokemon_name";
            Pokemon1Dropdown.DataBind();
            comm1.Dispose();
            conn.Close();




            pokemonForTeam.Add("Onix");
            pokemonForTeam.Add("Onix");
            pokemonForTeam.Add("Onix");
            pokemonForTeam.Add("Onix");
            pokemonForTeam.Add("Onix");
            pokemonForTeam.Add("Onix");
            nicknamesForTeam.Add("nickname1");
            nicknamesForTeam.Add("nickname2");
            nicknamesForTeam.Add("nickname3");
            nicknamesForTeam.Add("nickname4");
            nicknamesForTeam.Add("nickname5");
            nicknamesForTeam.Add("nickname6");
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Label3.Text = Pokemon1Dropdown.SelectedValue;
            //Label3.Text = "test";
            //pokemonForTeam.Add(Pokemon1Dropdown.SelectedValue);
            //Label3.Text = Pokemon1Dropdown.SelectedItem.Value;

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            //int count = 0;
            //pokemonForTeam[count] = Pokemon1Dropdown.SelectedValue;
            //Label3.Text = Pokemon1Dropdown.SelectedItem.Value;
            //test1 = Pokemon1Dropdown.SelectedValue;

            //nicknamesForTeam[count] = NicknameBox.Text;
            nicknamesForTeam.Add(NicknameBox.Text);
            //count++;

            pokemonForTeam.Add(Pokemon1Dropdown.SelectedValue);
            nicknamesForTeam.Add(NicknameBox.Text);
            NicknameBox.Text = "";

            //Label3.Text = pokemonForTeam[0];

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            NpgsqlCommand comm1 = new NpgsqlCommand();
            comm1.Connection = conn;
            comm1.CommandType = CommandType.Text;
            // comm1.CommandText = "INSERT INTO team VALUES(3, 'ash', 'Onix', 'hi', 'Onix', 'hi', 'Onix', 'hi', 'Onix', 'hi', 'Onix', 'hi', 'Onix', 'hi'); ";

            /*comm1.CommandText = "insert into team values(" + trainerIDBox.Text + ",'" + TrainerNameBox.Text + "','" +
            pokemonForTeam[0] + "','" + nicknamesForTeam[0] + "','" +
            pokemonForTeam[1] + "','" + nicknamesForTeam[1] + "','" +
            pokemonForTeam[2] + "','" + nicknamesForTeam[2] + "','" +
            pokemonForTeam[3] + "','" + nicknamesForTeam[3] + "','" +
            pokemonForTeam[4] + "','" + nicknamesForTeam[4] + "','" +
            pokemonForTeam[5] + "','" + nicknamesForTeam[5] + "')";*/

            comm1.CommandText = "insert into team values(" + trainerIDBox.Text + ",'" + TrainerNameBox.Text + "','" + 
                pokemonForTeam[0] + "','" + nicknamesForTeam[0] + "','" + 
                pokemonForTeam[1] + "','" + nicknamesForTeam[1] + "','" + 
                pokemonForTeam[2] + "','" + nicknamesForTeam[2] + "','" + 
                pokemonForTeam[3] + "','" + nicknamesForTeam[3] + "','" + 
                pokemonForTeam[4] + "','" + nicknamesForTeam[4] + "','" + 
                pokemonForTeam[5] + "','" + nicknamesForTeam[5] + "')";
            comm1.ExecuteNonQuery();
            comm1.Dispose();
            conn.Close();

        }
    }
}