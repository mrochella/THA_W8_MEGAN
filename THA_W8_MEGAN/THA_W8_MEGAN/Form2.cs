using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace THA_W8_MEGAN
{
    public partial class Form2 : Form
    {
        string connectionString = "server = localhost;uid = root;pwd = Meganmegan2009;database=premier_league";
        string sqlQuery;
        MySqlConnection sqlConnect;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        DataTable dtPlayer = new DataTable();
        DataTable dtTeam = new DataTable();
        DataTable dtPilih = new DataTable();
        DataTable dtLagi = new DataTable();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Linen;
            sqlConnect = new MySqlConnection(connectionString);

            dtPlayer.Clear();
            dtTeam.Clear();
            dtPilih.Clear();

            sqlQuery = "SELECT team_name,team_id from team;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtTeam);

            comboBox_team.DataSource = dtTeam;
            comboBox_team.ValueMember = "team_id";
            comboBox_team.DisplayMember = "team_name";
        }

        private void comboBox_team_SelectedIndexChanged(object sender, EventArgs e)
        {
            //gajadi pake ini
        }

        private void comboBox_player_SelectedIndexChanged(object sender, EventArgs e)
        {
           //gajadi pake ini
        }

        private void comboBox_team_SelectionChangeCommitted(object sender, EventArgs e)
        {
            dtPlayer.Clear();
            dtPilih.Clear();

            sqlQuery = "SELECT p.player_name FROM player p INNER JOIN team t ON p.team_id = t.team_id AND t.team_id = '" + comboBox_team.SelectedValue.ToString() + "'";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtPilih);

            comboBox_player.DataSource = dtPilih;
            comboBox_player.ValueMember = "player_name";
            comboBox_player.DisplayMember = "player_name";
        }

        private void comboBox_player_SelectionChangeCommitted(object sender, EventArgs e)
        {
            dtPlayer.Clear();
            dtLagi.Clear();

            sqlQuery = "SELECT p.player_name,t.team_name,n.nation,if(p.playing_pos = 'F','Forward',if(p.playing_pos = 'M','Midfielder',if (p.playing_pos = 'D','Defender','Goalkeeper'))),p.team_number FROM player p, team t , nationality n WHERE p.team_id = t.team_id AND n.nationality_id = p.nationality_id AND p.player_name = '" + comboBox_player.SelectedValue.ToString() + "'";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtPlayer);

            label12.Text = dtPlayer.Rows[0][0].ToString(); //player name
            label13.Text = dtPlayer.Rows[0][1].ToString(); //team name
            label14.Text = dtPlayer.Rows[0][2].ToString(); //nationality
            label15.Text = dtPlayer.Rows[0][3].ToString(); //position
            label16.Text = dtPlayer.Rows[0][4].ToString(); //squad number

            sqlQuery = "SELECT ifnull(sum(case when d.`type`='CY'then 1 else 0 end),0),ifnull(sum(case when d.`type`='CR'then 1 else 0 end),0),ifnull(sum(case when d.`type`='GO'then 1 else 0 end),0),ifnull(sum(case when d.`type`='GW'then 1 else 0 end),0),ifnull(sum(case when d.`type`='GP'then 1 else 0 end),0),ifnull(sum(case when d.`type`='PM'then 1 else 0 end),0) FROM dmatch d , player p WHERE d.player_id = p.player_id AND p.player_name = '" + comboBox_player.SelectedValue.ToString() + "'";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtLagi);

            label17.Text = dtLagi.Rows[0][0].ToString(); //yellow card
            label18.Text = dtLagi.Rows[0][1].ToString(); //red card
            label19.Text = dtLagi.Rows[0][2].ToString(); //goal
            label20.Text = dtLagi.Rows[0][3].ToString(); //own goal
            label21.Text = dtLagi.Rows[0][4].ToString(); //goal penalty
            label22.Text = dtLagi.Rows[0][5].ToString(); //penalty missed
        }
    }
}
