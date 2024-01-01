using System;
using System.Data.SQLite;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ToDoSharp
{
    public partial class Home : Form
    {
        //GLOBAL VERIABLES
        //Data Source = C:\Users\burak\source\repos\ToDoSharp\ToDoSharp\bin\Debug\database\todo_db.db
        //Data Source=c:\mydb.db;Version=3;
        public static string conn_string = "Data Source="+Application.StartupPath+"\\database\\todo_db.db;Version=3;";
        public static SQLiteConnection conn = new SQLiteConnection(conn_string);

        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            try
            {
                //INSERT ALL TASKS TO DATAVIEW FROM DATABASE
                GetTasks("WHERE status= \"not done\" ");
                label1.Text = "TO DO";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
        }

        private void GetTasks(string command)
        {
            try
            {
                conn.Open();
                SQLiteCommand cmd = new SQLiteCommand();
                cmd.Connection = conn;

                //CLEAR ALL ROWS OF DATAVIEW OBJECT
                task_data.Rows.Clear();

                string command_Text = "SELECT id,task_name,date,status FROM tasks " + command;
                cmd.CommandText = command_Text;
                cmd.ExecuteNonQuery();
                SQLiteDataReader reader = cmd.ExecuteReader();


                if (reader != null)
                {
                    while (reader.Read())
                    {
                        task_data.Rows.Add(reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetInt32(0).ToString());
                    }
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
        }

        private bool UpdateTasks(int id, string command, string value)
        {
            conn.Open();
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.Connection = conn;

            string command_Text;
            if (command == "task_name")
                command_Text = "UPDATE tasks SET task_name = @value WHERE id=@id ";
            else if (command == "date")
                command_Text = "UPDATE tasks SET date = @value WHERE id=@id ";
            else
                command_Text = "UPDATE tasks SET status = @value WHERE id=@id ";

            cmd.CommandText = command_Text;                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             
            cmd.Parameters.AddWithValue("@value", value);
            cmd.Parameters.AddWithValue("@id", id);

            if (cmd.ExecuteNonQuery() == -1)
            {
                return false;
            }
            conn.Close();
            return true;
        }

        private bool SetTask()
        {
            conn.Open();
            
            
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.Connection = conn;
            

            string command_text = "INSERT INTO tasks(task_name,date) values(@task_name,@date)";
            cmd.CommandText = command_text;
            cmd.Parameters.AddWithValue("@task_name", task_textbox.Text);
            cmd.Parameters.AddWithValue("@date", task_date.Value.ToShortDateString());

            if (cmd.ExecuteNonQuery() == -1)
            {
                conn.Close();
                return false;
            }
            conn.Close();
            return true;
        }

        private void PlayMusic(string name)
        {
            string path = Application.StartupPath + @"\songs\" + name + ".wav";
            SoundPlayer soundPlayer = new SoundPlayer(path);
            try
            {

                soundPlayer.Play();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error", ex.ToString());
                conn.Close();
                throw;
            }
        }

        

        private void button3_Click(object sender, EventArgs e)
        {
            GetTasks(" WHERE status=\"not done\" ");
            label1.Text = "TO DO";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GetTasks(" WHERE status=\"done\" ");
            label1.Text = "DONE";
        }

        

        private void task_button_Click_1(object sender, EventArgs e)
        {
            if (task_textbox.Text == "")
            {
                MessageBox.Show("Please enter a task on the textbox!");
                return;
            }
            if (SetTask())
            {
                //REFRESH THE DATAVIEW OBJECT
                GetTasks("WHERE status=\"not done\"");
                task_textbox.Text = "";
                label1.Text = "TO DO";
                PlayMusic("click");

            }
            else
            {
                MessageBox.Show("There is an error, Please try again !");
            }
        }

        private void task_data_CellValueChanged_1(object sender, DataGridViewCellEventArgs e)
        {
            //TODO
            if (task_data.SelectedCells.Count > 0)
            {
                int rowIndex = task_data.SelectedCells[0].RowIndex;
                int cellIndex = task_data.SelectedCells[0].ColumnIndex;
                string value = task_data.SelectedCells[0].Value.ToString();

                object id = task_data.Rows[rowIndex].Cells[3].Value;
                string name = task_data.Columns[cellIndex].Name;

                UpdateTasks(Convert.ToInt32(id), name, value);
                if (label1.Text == "TO DO")
                {
                    GetTasks("WHERE status=\"not done\"");
                }
                else if(label1.Text == "DONE")
                {
                    GetTasks("WHERE status=\"done\"");
                }
                
            }
        }
    }
}
