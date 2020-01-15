﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.IO;

namespace SyZaFi
{
    class DBConnection
    {
        private MySqlConnection connection;
        private string host;
        private string database;
        private string login;
        private string password;

        public DBConnection(string host, string database, string login, string password)
        {
            Initialize(host, database, login, password);
        }

        private void Initialize(string host, string database, string login, string password)
        {
            this.host = host;
            this.database = database;
            this.login = login;
            this.password = password;
            string connectionString;
            connectionString = "SERVER=" + host + ";" + "DATABASE=" + database + ";" + "UID=" + login + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }

        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Nie można połączyć się z bazą danych.");
                        break;

                    case 1042:
                        MessageBox.Show("Zły host.");
                        break;

                    case 1045:
                        MessageBox.Show("Zły login lub hasło.");
                        break;
                }
                return false;
            }
        }

        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public bool ConnectionTest()
        {
            if (OpenConnection() == true)
            {
                connection.Close();
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<string>[] CheckLogin()
        {
            string query = "SELECT * FROM users";

            List<string>[] list = new List<string>[10];
            list[0] = new List<string>(); //login
            list[1] = new List<string>(); //password
            list[2] = new List<string>(); //workgroup
            list[3] = new List<string>(); //firstName
            list[4] = new List<string>(); //lastName
            list[5] = new List<string>(); //emailAddress
            list[6] = new List<string>(); //employmentMonth
            list[7] = new List<string>(); //birthday
            list[8] = new List<string>(); //id
            list[9] = new List<string>(); //pwdhash

            if (OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    list[0].Add(dataReader["login"] + "");
                    list[1].Add(dataReader["password"] + "");
                    list[2].Add(dataReader["workgroup"] + "");
                    list[3].Add(dataReader["firstName"] + "");
                    list[4].Add(dataReader["lastName"] + "");
                    list[5].Add(dataReader["emailAddress"] + "");
                    list[6].Add(dataReader["employmentMonth"] + "");
                    list[7].Add(dataReader["birthday"] + "");
                    list[8].Add(dataReader["id"] + "");
                    list[9].Add(dataReader["pwdhash"] + "");
                }

                dataReader.Close();
                CloseConnection();
                return list;
            }
            else
            {
                return list;
            }
        }

        public void InsertNewAccount(string firstName, string lastName, string birthday, string workgroup, string login, string password, string pwdhash, string employmentMonth, string emailAddress)
        {
            string query = "INSERT INTO users (firstName, lastName, birthday, workgroup, login, password, pwdhash, employmentMonth, emailAddress)" +
                " VALUES('" + firstName + "', '" + lastName + "', '" + birthday + "', '" + workgroup + "', '" + login + "', '" + password + "', '" + pwdhash + "', '" + employmentMonth + "', '" + emailAddress + "')";

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                CloseConnection();
            }
        }

        public void Update(string firstName, string lastName, string birthday, string login, string employmentMonth, string emailAddress, string password, string pwdhash, string id)
        {
            string query = "UPDATE users SET firstName='" + firstName + "', lastName='" + lastName + "', birthday='" + birthday + "', login='" + login + "', employmentMonth='" + employmentMonth + "', emailAddress='" + emailAddress + "', password='" + password + "', pwdhash='" + pwdhash + "' WHERE id='" + id + "'";

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = query;
                cmd.Connection = connection;
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }
        public void Delete(string id)
        {
            string query = "DELETE FROM users WHERE id='" + id + "'";

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        public void CreateTable()
        {
            if (this.OpenConnection() == true)
            {
                MySqlScript script = new MySqlScript(connection, File.ReadAllText("createTable.sql"));
                script.Execute();
                this.CloseConnection();
            }
        }

        public void CreateAdmin()
        {
            if (this.OpenConnection() == true)
            {
                MySqlScript script = new MySqlScript(connection, File.ReadAllText("createAdminAccount.sql"));
                script.Execute();
                this.CloseConnection();
            }
        }

        public string GetPwdHash(string login)
        {
            string query = "SELECT pwdhash FROM users WHERE login='" + login + "'";
            string data = "";
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                data = (string)cmd.ExecuteScalar();
                this.CloseConnection();
                return data;
            }
            return data;
        }
    }
}
