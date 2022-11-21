using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrowingTree2._0
{
    public partial class fMain : Form
    {

        public fMain()
        {
            InitializeComponent();
        }

        private void fMain_Load(object sender, EventArgs e)
        {
            CbTreeNameAddToList();
            PersonWateringSelect();
        }

        private void bAddNewTree_Click(object sender, EventArgs e)
        {
            AddTree();
        }

        private void cbTreeName_SelectedIndexChanged(object sender, EventArgs e)
        {
            CbTreeNameSelect();
        }

        private void bGrow_Click(object sender, EventArgs e)
        {

            try
            {
                if (rbSviatski.Checked)
                {
                    SviatskiWateringTree();
                    CbTreeNameSelect();
                    PersonWateringSelect();
                }
                else if (rbArtuhov.Checked)
                {
                    ArtuhovWateringTree();
                    CbTreeNameSelect();
                    PersonWateringSelect();
                }
                else if (rbKoshel.Checked)
                {
                    KoshelWateringTree();
                    CbTreeNameSelect();
                    PersonWateringSelect();
                }
            }
            catch
            {
                MessageBox.Show("Nicht Arbaiten!");
            }

        }

        private void bWateringClear_Click(object sender, EventArgs e)
        {
            ClearWateringCount();
            PersonWateringSelect();
        }

        // Methods
        private void AddTree()
        {
            if (tbName.Text == "" || tbAge.Text == "" || tbTrunkLength.Text == "" || tbCrownVolume.Text == "")
            { 
                MessageBox.Show(Constants.fieldsWarning, Constants.warning, MessageBoxButtons.OK, MessageBoxIcon.Warning); 
            }
            else
            {
                string procedureText = $"INSERT INTO EnteredTree(Name, Age, TrunkLength, CrownVolume) VALUES ('{tbName.Text}', {tbAge.Text}, {tbTrunkLength.Text}, {tbCrownVolume.Text})";
                using (SqlConnection connect = new SqlConnection(Constants.connectionString))
                {
                    SqlCommand addTree = new SqlCommand(procedureText, connect);

                    try
                    {
                        connect.Open();
                        addTree.ExecuteNonQuery();
                        MessageBox.Show($"Дерево {tbName.Text} добавлено.");
                    }
                    catch
                    {
                        MessageBox.Show(Constants.warningMessage, Constants.warning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
            CbTreeNameAddToList();
        }

        private void CbTreeNameAddToList()
        {
            List<string> nameList = new List<string>();
            using (SqlConnection connection = new SqlConnection(Constants.connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand($@"SELECT e.Name FROM EnteredTree e", connection);
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            nameList.Add(reader.GetString(0));
                        }
                        nameList.Sort();
                    }
                }
                catch (Exception)
                {

                    throw;
                }
                finally
                {
                    connection.Close();
                }
                //cbTreeName.DataSource = null;
                cbTreeName.DataSource = nameList;
            }
        }

        private void CbTreeNameSelect()
        {
            List<int> dataList = new List<int>();
            using (SqlConnection connection = new SqlConnection(Constants.connectionString))
            {
                try
                {
                    connection.Open();
                    string commandText = $@"SELECT e.Age, e.TrunkLength, e.CrownVolume FROM EnteredTree e WHERE e.Name = '{cbTreeName.SelectedItem}'";
                    SqlCommand command = new SqlCommand(commandText, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                dataList.Add(reader.GetInt32(i));
                            }
                        }
                    }
                }
                catch (Exception)
                {

                    MessageBox.Show("Error!");
                }
                finally
                {
                    connection.Close();
                }
                dgvTreeInfo.Rows[0].Cells[0].Value = cbTreeName.SelectedItem;
                for (int j = 0; j < dataList.Count; j++)
                {
                    dgvTreeInfo.Rows[0].Cells[j + 1].Value = dataList[j];
                }
            }
        }

        private void ArtuhovWateringTree()
        {
            using (SqlConnection connect = new SqlConnection(Constants.connectionString))
            {
                string updateEnteredTree = $"UPDATE EnteredTree SET Age = Age + 1, TrunkLength = TrunkLength + 2, CrownVolume = CrownVolume + 5 WHERE EnteredTree.Name = '{cbTreeName.Text}'";
                SqlCommand updateTree = new SqlCommand(updateEnteredTree, connect);
                SqlCommand updatePersonWateringCount = new SqlCommand(Constants.updateArtuhovWateringCount, connect);

                try
                {
                    connect.Open();
                    updateTree.ExecuteNonQuery();
                    updatePersonWateringCount.ExecuteNonQuery();
                }
                catch
                {
                    MessageBox.Show(Constants.warningMessage, Constants.warning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                finally
                {
                    connect.Close();
                }
            }
        }

        private void KoshelWateringTree()
        {
            using (SqlConnection connect = new SqlConnection(Constants.connectionString))
            {
                string updateEnteredTree = $"UPDATE EnteredTree SET Age = Age + 1, TrunkLength = TrunkLength + 2, CrownVolume = CrownVolume + 5 WHERE EnteredTree.Name = '{cbTreeName.Text}'";
                SqlCommand updateTree = new SqlCommand(updateEnteredTree, connect);
                SqlCommand updatePersonWateringCount = new SqlCommand(Constants.updateKoshelWateringCount, connect);

                try
                {
                    connect.Open();
                    updateTree.ExecuteNonQuery();
                    updatePersonWateringCount.ExecuteNonQuery();
                }
                catch
                {
                    MessageBox.Show(Constants.warningMessage, Constants.warning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                finally
                {
                    connect.Close();
                }
            }
        }

        private void SviatskiWateringTree()
        {
            using (SqlConnection connect = new SqlConnection(Constants.connectionString))
            {
                string updateEnteredTree = $"UPDATE EnteredTree SET Age = Age + 1, TrunkLength = TrunkLength + 2, CrownVolume = CrownVolume + 5 WHERE EnteredTree.Name = '{cbTreeName.Text}'";
                SqlCommand updateTree = new SqlCommand(updateEnteredTree, connect);
                SqlCommand updatePersonWateringCount = new SqlCommand(Constants.updateSviatskiWateringCount, connect);

                try
                {
                    connect.Open();
                    updateTree.ExecuteNonQuery();
                    updatePersonWateringCount.ExecuteNonQuery();
                }
                catch
                {
                    MessageBox.Show(Constants.warningMessage, Constants.warning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                finally
                {
                    connect.Close();
                }
            }
        }

        private void PersonWateringSelect()
        {
            List<int> dataList = new List<int>();
            using (SqlConnection connection = new SqlConnection(Constants.connectionString))
            {
                try
                {
                    connection.Open();
                    string commandText = "SELECT WateringCount FROM Persons ORDER BY IDPerson";
                    SqlCommand command = new SqlCommand(commandText, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                dataList.Add(reader.GetInt32(i));
                            }
                        }
                    }
                }
                catch (Exception)
                {

                    MessageBox.Show("Error!");
                }
                finally
                {
                    connection.Close();
                }
                dgvPersonsInfo.Rows[0].Cells[0].Value = dataList[0];
                dgvPersonsInfo.Rows[0].Cells[1].Value = dataList[2];
                dgvPersonsInfo.Rows[0].Cells[2].Value = dataList[1];
            }
        }

        private void ClearWateringCount()
        {
            using (SqlConnection connection = new SqlConnection(Constants.connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("ClearWateringCount", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.ExecuteNonQuery();
                }
                catch (Exception)
                {

                    MessageBox.Show("Error!");
                }
                finally
                {
                    connection.Close();
                }
            }
        }
    }
}
