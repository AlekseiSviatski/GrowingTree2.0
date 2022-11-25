using GrowingTree2._0_ADO.NetDB.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GrowingTree2._0_ADO.NetDB.Concrete
{

    /// <summary>
    /// Class of DB logic
    /// </summary>
    public class DBWork
    {
        /// <summary>
        /// DB class constructor
        /// </summary>
        /// <param name="connectionString">Connection string</param>
        public DBWork(string connectionString) 
        {
            this.connectionString = connectionString;
        }

        /// <summary>
        /// Connection string
        /// </summary>
        private string connectionString { get; set; }

        /// <summary>
        /// Add new tree in DB
        /// </summary>
        /// <param name="tree">Instance of inserted tree</param>
        /// <returns>Result of query</returns>
        public bool AddNewTree(EnteredTree tree)
        {
            if (tree != null)
            {
                string sql = $@"INSERT INTO EnteredTree(Name, Age, TrunkLength, CrownVolume)
                            VALUES ('{tree.Name}', {tree.Age}, {tree.TrunkLength}, {tree.CrownVolume})";

                using (SqlConnection connect = new SqlConnection(connectionString))
                {
                    SqlCommand addTree = new SqlCommand(sql, connect);

                    try
                    {
                        connect.Open();
                        addTree.ExecuteNonQuery();

                        return true;
                    }
                    catch (Exception ex)
                    {
                        //тут можно добавить вские ништяки по типу своих кодов ошибок или тип того, лога например
                        return false;
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }

            return false;
        }

        public List<EnteredTree> GetAllEnteredTrees()
        {
            List<EnteredTree> nameList = new List<EnteredTree>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string sql = $@"SELECT e.* 
                                    FROM EnteredTree e
                                    ORDER BY e.Name ASC";

                    SqlCommand command = new SqlCommand(sql, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            nameList.Add(new EnteredTree
                            {
                                ID = Convert.ToInt32(reader["ID"]),
                                Name = reader["Name"].ToString(),
                                Age = Convert.ToInt32(reader["Age"]),
                                TrunkLength = Convert.ToInt32(reader["TrunkLength"]),
                                CrownVolume = Convert.ToInt32(reader["CrownVolume"])
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    //тут можно добавить вские ништяки по типу своих кодов ошибок или тип того, лога например
                    throw;
                }
                finally
                {
                    connection.Close();
                }
            }

            return nameList;
        }

        public EnteredTree GetEnteredTreeByName(string name)
        {
            EnteredTree enteredTree = null;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string sql = $@"SELECT TOP 1 e.* 
                                    FROM EnteredTree e
                                    WHERE e.Name = {name}";

                    SqlCommand command = new SqlCommand(sql, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            enteredTree = new EnteredTree 
                            {
                                ID = Convert.ToInt32(reader["ID"]),
                                Name = reader["Name"].ToString(),
                                Age = Convert.ToInt32(reader["Age"]),
                                TrunkLength = Convert.ToInt32(reader["TrunkLength"]),
                                CrownVolume = Convert.ToInt32(reader["CrownVolume"])
                            };
                        }
                    }
                }
                catch (Exception ex)
                {
                    //тут можно добавить вские ништяки по типу своих кодов ошибок или тип того, лога например
                    throw;
                }
                finally
                {
                    connection.Close();
                }
            }

            return enteredTree;
        }

        public bool UpdateWateringTree(EnteredTree enteredTree, People people)
        {
            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                string sql = $"UPDATE EnteredTree " +
                            $"SET Age = Age + 1, TrunkLength = TrunkLength + 2, CrownVolume = CrownVolume + 5 " +
                            $"WHERE EnteredTree.ID = '{enteredTree.ID}'" +
                            $"" +
                            $"UPDATE Persons " +
                            $"SET WateringCount = WateringCount + 1 " +
                            $"WHERE IDPerson = {people.ID}";

                SqlCommand updateTree = new SqlCommand(sql, connect);

                try
                {
                    connect.Open();
                    updateTree.ExecuteNonQuery();

                    return true;
                }
                catch (Exception ex)
                {
                    //тут можно добавить вские ништяки по типу своих кодов ошибок или тип того, лога например
                    return false;
                    //MessageBox.Show(Constants.warningMessage, Constants.warning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                finally
                {
                    connect.Close();
                }
            }
        }

        public List<People> GetAllPeople()
        {
            List<People> peopleList = new List<People>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string sql = $@"SELECT e.* 
                                    FROM Persons e
                                    ORDER BY IDPerson ASC";

                    SqlCommand command = new SqlCommand(sql, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            peopleList.Add(new People
                            {
                                ID = Convert.ToInt32(reader["ID"]),
                                Name = reader["Name"].ToString(),
                                WateringCount = Convert.ToInt32(reader["WateringCount"])
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    //тут можно добавить вские ништяки по типу своих кодов ошибок или тип того, лога например
                    throw;
                }
                finally
                {
                    connection.Close();
                }
            }

            return peopleList;
        } 

        public bool ClearWateringCount()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("ClearWateringCount", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.ExecuteNonQuery();

                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                    //MessageBox.Show("Error!");
                }
                finally
                {
                    connection.Close();
                }
            }
        }
    }
}
