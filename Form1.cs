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

        Person Sviatski;
        Person Artuhov;
        Person Koshel;
        Tree EnteredTree;

        public fMain()
        {
            InitializeComponent();
        }

        private void fMain_Load(object sender, EventArgs e)
        {
            cbTreeNameAddToList();
        }

        private void bAddNewTree_Click(object sender, EventArgs e)
        {
            AddTree();
        }

        private void cbTreeName_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelecvtIndexInfo();
        }

        private void bGrow_Click(object sender, EventArgs e)
        {

            //try
            //{
            //    if (rbSviatski.Checked)
            //    {
            //        Sviatski.AddWateringCount();

            //        using (SqlConnection connect = new SqlConnection(Constants.connectionString))
            //        {
            //            SqlCommand updateTree = new SqlCommand(Constants.updateEnteredTree, connect);
            //            SqlCommand updatePersonWateringCount = new SqlCommand(Constants.updateSviatskiWateringCount, connect);

            //            try
            //            {
            //                connect.Open();
            //                updateTree.ExecuteNonQuery();
            //                updatePersonWateringCount.ExecuteNonQuery();
            //            }
            //            catch
            //            {
            //                MessageBox.Show(Constants.warningMessage, Constants.warning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //            }
            //            finally
            //            {
            //                connect.Close();
            //            }
            //        }
            //    }
            //    else if (rbArtuhov.Checked)
            //    {
            //        Artuhov.AddWateringCount();

            //        using (SqlConnection connect = new SqlConnection(Constants.connectionString))
            //        {
            //            SqlCommand updateTree = new SqlCommand(Constants.updateEnteredTree, connect);
            //            SqlCommand updatePersonWateringCount = new SqlCommand(Constants.updateArtuhovWateringCount, connect);

            //            try
            //            {
            //                connect.Open();
            //                updateTree.ExecuteNonQuery();
            //                updatePersonWateringCount.ExecuteNonQuery();
            //            }
            //            catch
            //            {
            //                MessageBox.Show(Constants.warningMessage, Constants.warning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //            }
            //            finally
            //            {
            //                connect.Close();
            //            }
            //        }
            //    }
            //    else if (rbKoshel.Checked)
            //    {
            //        Koshel.AddWateringCount();

            //        using (SqlConnection connect = new SqlConnection(Constants.connectionString))
            //        {
            //            SqlCommand updateTree = new SqlCommand(Constants.updateEnteredTree, connect);
            //            SqlCommand updatePersonWateringCount = new SqlCommand(Constants.updateKoshelWateringCount, connect);

            //            try
            //            {
            //                connect.Open();
            //                updateTree.ExecuteNonQuery();
            //                updatePersonWateringCount.ExecuteNonQuery();
            //            }
            //            catch
            //            {
            //                MessageBox.Show(Constants.warningMessage, Constants.warning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //            }
            //            finally
            //            {
            //                connect.Close();
            //            }
            //        }
            //    }
            //}
            //catch
            //{
            //    MessageBox.Show("Nicht Arbaiten!");
            //}
            
        }

        private void bRefresh_Click(object sender, EventArgs e)
        {
            cbTreeNameAddToList();
        }



        // Methods
        public void AddTree()
        {
            if (tbName.Text == "" || tbAge.Text == "" || tbTrunkLength.Text == "" || tbCrownVolume.Text == "") MessageBox.Show(Constants.fieldsWarning, Constants.warning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            cbTreeNameAddToList();
        }

        public void cbTreeNameAddToList()
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
                cbTreeName.DataSource = null;
                cbTreeName.DataSource = nameList;
            }
        }


        public void SelecvtIndexInfo()
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
    }
}
