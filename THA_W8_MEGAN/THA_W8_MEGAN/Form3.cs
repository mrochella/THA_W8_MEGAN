using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.SqlServer.Server;
using MySql.Data.MySqlClient;

namespace THA_W8_MEGAN
{
    public partial class Form3 : Form
    {
        string connectionString = "server = localhost;uid = root;pwd = Meganmegan2009;database=premier_league";
        string sqlQuery;
        MySqlConnection sqlConnect;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        DataTable dtHome = new DataTable();
        DataTable dtAway = new DataTable();
        DataTable dtLainnya = new DataTable();
        DataTable dtTeamlagi = new DataTable();
        DataTable dtPilihLagi = new DataTable();
        public Form3()
        {
            InitializeComponent();
        }

        private void comboBox_teamLagi_SelectedIndexChanged(object sender, EventArgs e)
        {
            //gajadi
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.MintCream;
            sqlConnect = new MySqlConnection(connectionString);

            label_team.Text = "Team:";
            label_matchid.Text = "Match ID:";

            dtTeamlagi.Clear();
            dtPilihLagi.Clear();
            dtAway.Clear();
            dtHome.Clear();

            sqlQuery = "SELECT team_name,team_id from team;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtTeamlagi);

            comboBox_teamLagi.DataSource = dtTeamlagi;
            comboBox_teamLagi.ValueMember = "team_id";
            comboBox_teamLagi.DisplayMember = "team_name";
        }

        private void comboBox_mDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            //gajadi
        }

        private void comboBox_teamLagi_SelectionChangeCommitted(object sender, EventArgs e)
        {
            dtAway.Clear();
            dtHome.Clear();
            dtPilihLagi.Clear();

            sqlQuery = "SELECT d.match_id from dmatch d, `match` m , `match` n WHERE d.match_id = m.match_id AND (m.team_home = d.team_id or m.team_away = d.team_id) AND d.team_id = '" + comboBox_teamLagi.SelectedValue.ToString() + "' group by d.match_id";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtPilihLagi);

            comboBox_mDate.DataSource = dtPilihLagi;
            comboBox_mDate.ValueMember = "match_id";
            comboBox_mDate.DisplayMember = "match_id";
        }

        private void comboBox_mDate_SelectionChangeCommitted(object sender, EventArgs e)
        {
            dtAway.Clear();
            dtHome.Clear();
            dtLainnya.Clear();

            sqlQuery = "SELECT p.player_name,t.team_name,if(p.playing_pos = 'F','Forward',if(p.playing_pos = 'M','Midfielder',if(p.playing_pos = 'D','Defender','Goalkeeper'))) position FROM player p, team t , `match` m WHERE t.team_id = m.team_home AND t.team_id = p.team_id AND m.match_id = '" + comboBox_mDate.SelectedValue.ToString() + "' order by 2 asc";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtHome);
            dataGridView_home.DataSource = dtHome;

            sqlQuery = "SELECT p.player_name,t.team_name,if(p.playing_pos = 'F','Forward',if(p.playing_pos = 'M','Midfielder',if(p.playing_pos = 'D','Defender','Goalkeeper'))) position FROM player p, team t , `match` m WHERE t.team_id = m.team_away AND t.team_id = p.team_id AND m.match_id = '" + comboBox_mDate.SelectedValue.ToString() + "' order by 2 asc";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtAway);
            dataGridView_away.DataSource = dtAway;

            sqlQuery = "SELECT d.`minute`,p.player_name,t.team_name,if(d.`type`='CY','Yellow Card',if(d.`type`='CR','Red Card',if(d.`type`='GO','Goal',if(d.`type`='GW','Own Goal',if(d.`type`='GP','Goal Penalty','Penalty Missed'))))) type FROM player p, team t , `match` m, dmatch d WHERE t.team_id = d.team_id AND d.player_id = p.player_id AND d.match_id = '" + comboBox_mDate.SelectedValue.ToString() + "'";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtLainnya);
            dataGridView_lainnya.DataSource = dtLainnya;
        }
    }
}
