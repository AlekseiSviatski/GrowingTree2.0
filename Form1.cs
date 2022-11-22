using GrowingTree2._0_ADO.NetDB.Concrete;
using GrowingTree2._0_ADO.NetDB.Model;
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
using DBModel = GrowingTree2._0_ADO.NetDB.Model;

namespace GrowingTree2._0
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        #region Properties and fields

        DBWork dBWork;

        #endregion

        #region Events

        private void fMain_Load(object sender, EventArgs e)
        {
            dBWork = new DBWork(Program.ConnectionString);

            cbTreeNameAddToList();
            personWateringSelect();
        }

        private void bAddNewTree_Click(object sender, EventArgs e)
        {
            AddTree();
        }

        private void cbTreeName_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbTreeNameSelect();
        }

        private void bGrow_Click(object sender, EventArgs e)
        {

            try
            {
                if (rbSviatski.Checked)
                {
                    SviatskiWateringTree();
                    cbTreeNameSelect();
                    personWateringSelect();
                }
                else if (rbArtuhov.Checked)
                {
                    ArtuhovWateringTree();
                    cbTreeNameSelect();
                    personWateringSelect();
                }
                else if (rbKoshel.Checked)
                {
                    KoshelWateringTree();
                    cbTreeNameSelect();
                    personWateringSelect();
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
            personWateringSelect();
        }

        #endregion

        #region Methods

        private void AddTree()
        {
            if (tbName.Text == "" || tbAge.Text == "" || tbTrunkLength.Text == "" || tbCrownVolume.Text == "")
            {
                MessageBox.Show(Constants.fieldsWarning, Constants.warning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                EnteredTree newEnteredTree = new EnteredTree
                {
                    Name = tbName.Text,
                    Age = Convert.ToInt32(tbAge.Text),
                    TrunkLength = Convert.ToInt32(tbTrunkLength.Text),
                    CrownVolume = Convert.ToInt32(tbCrownVolume.Text)
                };

                if (!dBWork.AddNewTree(newEnteredTree))
                {
                    MessageBox.Show(Constants.warningMessage, Constants.warning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            cbTreeNameAddToList();
        }

        private void cbTreeNameAddToList()
        {
            List<string> nameList = new List<string>();
            using (SqlConnection connection = new SqlConnection(Constants.connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand($@"select e.Name from EnteredTree e", connection);
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

        private void cbTreeNameSelect()
        {
            List<int> dataList = new List<int>();
            using (SqlConnection connection = new SqlConnection(Constants.connectionString))
            {
                try
                {
                    connection.Open();
                    string commandText = $@"select e.Age, e.TrunkLength, e.CrownVolume from EnteredTree e where e.Name = '{cbTreeName.SelectedItem}'";
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

        private void personWateringSelect()
        {
            List<int> dataList = new List<int>();
            using (SqlConnection connection = new SqlConnection(Constants.connectionString))
            {
                try
                {
                    connection.Open();
                    string commandText = "SELECT WateringCount FROM Persons order by IDPerson";
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

        #endregion
    }
}
