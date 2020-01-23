using System;
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

        public void InsertNewEmployee(string firstName, string lastName, string fathersName, string mothersName, string birthday, string placeOfResidence, string correspondenceAddress, string education, string historyOfEmployment, int pesel, string childrensNames, string childrensBirthdays)
        {
            string query = "INSERT INTO employees (firstName, lastName, fathersName, mothersName, birthday, placeOfResidence, correspondenceAddress, education, historyOfEmployment, pesel, childrensNames, childrensBirthdays)" +
                " VALUES('" + firstName + "', '" + lastName + "', '" + fathersName + "', '" + mothersName + "', '" + birthday + "', '" + placeOfResidence + "', '" + correspondenceAddress + "', '" + education + "', '" + historyOfEmployment + "', '" + pesel + "', '" + childrensNames + "', '" + childrensBirthdays + "')";

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                CloseConnection();
            }
        }

        public void UpdateEmployee(string firstName, string lastName, string fathersName, string mothersName, string birthday, string placeOfResidence, string correspondenceAddress, string education, string historyOfEmployment, int pesel, string childrensNames, string childrensBirthdays, int id)
        {
            string query = "UPDATE employees SET firstName='" + firstName + "', lastName='" + lastName + "', fathersName='" + fathersName + "', mothersName='" + mothersName + "', birthday='" + birthday + "', placeOfResidence='" + placeOfResidence + "', correspondenceAddress='" + correspondenceAddress + "', education='" + education + "', historyOfEmployment='" + historyOfEmployment + "', pesel='" + pesel + "', childrensNames='" + childrensNames + "', childrensBirthdays='" + childrensBirthdays + "' WHERE id='" + id + "'";

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                CloseConnection();
            }
        }

        public List<string>[] EmployeesList()
        {
            string query = "SELECT * FROM employees";

            List<string>[] list = new List<string>[13];
            list[0] = new List<string>(); //firstName
            list[1] = new List<string>(); //lastName
            list[2] = new List<string>(); //fathersName
            list[3] = new List<string>(); //mothersName
            list[4] = new List<string>(); //birthday
            list[5] = new List<string>(); //placeOfResidence
            list[6] = new List<string>(); //correspondenceAddress
            list[7] = new List<string>(); //education
            list[8] = new List<string>(); //historyOfEmployment
            list[9] = new List<string>(); //pesel
            list[10] = new List<string>(); //childrensNames
            list[11] = new List<string>(); //childrensBirthdays
            list[12] = new List<string>(); //id

            if (OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    list[0].Add(dataReader["firstName"] + "");
                    list[1].Add(dataReader["lastName"] + "");
                    list[2].Add(dataReader["fathersName"] + "");
                    list[3].Add(dataReader["mothersName"] + "");
                    list[4].Add(dataReader["birthday"] + "");
                    list[5].Add(dataReader["placeOfResidence"] + "");
                    list[6].Add(dataReader["correspondenceAddress"] + "");
                    list[7].Add(dataReader["education"] + "");
                    list[8].Add(dataReader["historyOfEmployment"] + "");
                    list[9].Add(dataReader["pesel"] + "");
                    list[10].Add(dataReader["childrensNames"] + "");
                    list[11].Add(dataReader["childrensBirthdays"] + "");
                    list[12].Add(dataReader["id"] + "");
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

        public List<string>[] DeletedEmployeesList()
        {
            string query = "SELECT * FROM deletedemployees";

            List<string>[] list = new List<string>[13];
            list[0] = new List<string>(); //firstName
            list[1] = new List<string>(); //lastName
            list[2] = new List<string>(); //fathersName
            list[3] = new List<string>(); //mothersName
            list[4] = new List<string>(); //birthday
            list[5] = new List<string>(); //placeOfResidence
            list[6] = new List<string>(); //correspondenceAddress
            list[7] = new List<string>(); //education
            list[8] = new List<string>(); //historyOfEmployment
            list[9] = new List<string>(); //pesel
            list[10] = new List<string>(); //childrensNames
            list[11] = new List<string>(); //childrensBirthdays
            list[12] = new List<string>(); //id

            if (OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    list[0].Add(dataReader["firstName"] + "");
                    list[1].Add(dataReader["lastName"] + "");
                    list[2].Add(dataReader["fathersName"] + "");
                    list[3].Add(dataReader["mothersName"] + "");
                    list[4].Add(dataReader["birthday"] + "");
                    list[5].Add(dataReader["placeOfResidence"] + "");
                    list[6].Add(dataReader["correspondenceAddress"] + "");
                    list[7].Add(dataReader["education"] + "");
                    list[8].Add(dataReader["historyOfEmployment"] + "");
                    list[9].Add(dataReader["pesel"] + "");
                    list[10].Add(dataReader["childrensNames"] + "");
                    list[11].Add(dataReader["childrensBirthdays"] + "");
                    list[12].Add(dataReader["id"] + "");
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

        public List<string>[] CheckFinancialOperations()
        {
            string query = "SELECT * FROM financialoperations";

            List<string>[] list = new List<string>[4];
            list[0] = new List<string>(); //receiver
            list[1] = new List<string>(); //amount
            list[2] = new List<string>(); //category
            list[3] = new List<string>(); // id

            if (OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    list[0].Add(dataReader["receiver"] + "");
                    list[1].Add(dataReader["amount"] + "");
                    list[2].Add(dataReader["category"] + "");
                    list[3].Add(dataReader["id"] + "");
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

        public void DeleteFinancialOperation(string id)
        {
            string query = "DELETE FROM financialoperations WHERE id='" + id + "'";

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        public void InsertNewFinancialOperation(string receiver, string amount, string category)
        {
            string query = "INSERT INTO financialoperations (receiver, amount, category)" +
                " VALUES('" + receiver + "', '" + amount + "', '" + category + "')";

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                CloseConnection();
            }
        }

        public List<string>[] CheckInventory()
        {
            string query = "SELECT * FROM inventory";

            List<string>[] list = new List<string>[4];
            list[0] = new List<string>(); //id
            list[1] = new List<string>(); //inventorycode - also known as index
            list[2] = new List<string>(); //name
            list[3] = new List<string>(); //amount

            if (OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    list[0].Add(dataReader["id"] + "");
                    list[1].Add(dataReader["inventorycode"] + "");
                    list[2].Add(dataReader["name"] + "");
                    list[3].Add(dataReader["amount"] + "");
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

        public void DeleteInventoryPosition(int id)
        {
            string query = "DELETE FROM inventory WHERE id='" + id + "'";

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        public void InsertNewInventoryPosition(string inventorycode, string name, int amount)
        {
            string query = "INSERT INTO inventory (inventorycode, name, amount)" +
                " VALUES('" + inventorycode + "', '" + name + "', '" + amount + "')";

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                CloseConnection();
            }
        }

        public void UpdateInventory(int id, string inventorycode, string name, int amount)
        {
            string query = "UPDATE inventory SET inventorycode='" + inventorycode + "', name='" + name + "', amount='" + amount + "' WHERE id='" + id + "'";

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = query;
                cmd.Connection = connection;
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        public List<string>[] CheckOrders()
        {
            string query = "SELECT * FROM orders";

            List<string>[] list = new List<string>[5];
            list[0] = new List<string>(); //id
            list[1] = new List<string>(); //client
            list[2] = new List<string>(); //itemname
            list[3] = new List<string>(); //amount
            list[4] = new List<string>(); //date

            if (OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    list[0].Add(dataReader["id"] + "");
                    list[1].Add(dataReader["client"] + "");
                    list[2].Add(dataReader["itemname"] + "");
                    list[3].Add(dataReader["amount"] + "");
                    list[4].Add(dataReader["date"] + "");
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

        public void DeleteOrder(int id)
        {
            string query = "DELETE FROM orders WHERE id='" + id + "'";

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        public void InsertNewOrder(string client, string itemname, int amount, string date)
        {
            string query = "INSERT INTO orders (client, itemname, amount, date)" +
                " VALUES('" + client + "', '" + itemname + "', '" + amount + "', '" + date + "')";

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                CloseConnection();
            }
        }

        public void UpdateOrders(int id, string client, string itemname, int amount, string date)
        {
            string query = "UPDATE orders SET client='" + client + "', itemname='" + itemname + "', amount='" + amount + "', date='" + date + "' WHERE id='" + id + "'";

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = query;
                cmd.Connection = connection;
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        public List<string>[] CheckProductionPlan()
        {
            string query = "SELECT * FROM productionplan";

            List<string>[] list = new List<string>[5];
            list[0] = new List<string>(); //id
            list[1] = new List<string>(); //item
            list[2] = new List<string>(); //amount
            list[3] = new List<string>(); //position
            list[4] = new List<string>(); //date

            if (OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    list[0].Add(dataReader["id"] + "");
                    list[1].Add(dataReader["item"] + "");
                    list[2].Add(dataReader["amount"] + "");
                    list[3].Add(dataReader["position"] + "");
                    list[4].Add(dataReader["date"] + "");
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

        public void DeleteProduction(int id)
        {
            string query = "DELETE FROM productionplan WHERE id='" + id + "'";

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        public void InsertNewProduction(string item, int amount, string position, string date)
        {
            string query = "INSERT INTO productionplan (item, amount, position, date)" +
                " VALUES('" + item + "', '" + amount + "', '" + position + "', '" + date + "')";

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                CloseConnection();
            }
        }

        public void UpdateProductionPlan(int id, string item, int amount, string position, string date)
        {
            string query = "UPDATE productionplan SET item='" + item + "', amount='" + amount + "', position='" + position + "', date='" + date + "' WHERE id='" + id + "'";

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = query;
                cmd.Connection = connection;
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        public void MoveEmployeeToRemovedEmployees(string firstName, string lastName, string fathersName, string mothersName, string birthday, string placeOfResidence, string correspondenceAddress, string education, string historyOfEmployment, int pesel, string childrensNames, string childrensBirthdays)
        {
            string query = "INSERT INTO deletedemployees (firstName, lastName, fathersName, mothersName, birthday, placeOfResidence, correspondenceAddress, education, historyOfEmployment, pesel, childrensNames, childrensBirthdays)" +
                " VALUES('" + firstName + "', '" + lastName + "', '" + fathersName + "', '" + mothersName + "', '" + birthday + "', '" + placeOfResidence + "', '" + correspondenceAddress + "', '" + education + "', '" + historyOfEmployment + "', '" + pesel + "', '" + childrensNames + "', '" + childrensBirthdays + "')";

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                CloseConnection();
            }
        }

        public void DeleteEmployee(int id)
        {
            string query = "DELETE FROM employees WHERE id='" + id + "'";

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        public void DeleteFromDeletedEmployees(int id)
        {
            string query = "DELETE FROM deletedemployees WHERE id='" + id + "'";

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        public List<string>[] CheckCompany()
        {
            string query = "SELECT * FROM companydetails";

            List<string>[] list = new List<string>[5];
            list[0] = new List<string>(); //id
            list[1] = new List<string>(); //companyName
            list[2] = new List<string>(); //companyNIP
            list[3] = new List<string>(); //companyREGON
            list[4] = new List<string>(); //companyKRS

            if (OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    list[0].Add(dataReader["id"] + "");
                    list[1].Add(dataReader["companyName"] + "");
                    list[2].Add(dataReader["companyNIP"] + "");
                    list[3].Add(dataReader["companyREGON"] + "");
                    list[4].Add(dataReader["companyKRS"] + "");
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

        public void InsertNewCompany(string companyName, int companyNIP, int companyREGON, int companyKRS)
        {
            string query = "INSERT INTO companydetails (companyName, companyNIP, companyREGON, companyKRS)" +
                " VALUES('" + companyName + "', '" + companyNIP + "', '" + companyREGON + "', '" + companyKRS + "')";

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                CloseConnection();
            }
        }

        public void UpdateCompanyDetails(int id, string companyName, int companyNIP, int companyREGON, int companyKRS)
        {
            string query = "UPDATE companydetails SET companyName='" + companyName + "', companyNIP='" + companyNIP + "', companyREGON='" + companyREGON + "', companyKRS='" + companyKRS + "' WHERE id='" + id + "'";

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = query;
                cmd.Connection = connection;
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }
    }
}
