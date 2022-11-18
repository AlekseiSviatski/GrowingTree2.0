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
    public partial class Form1 : Form
    {

        Person Sviatski;
        Person Artuhov;
        Person Koshel;
        Tree EnteredTree;
        List<string> nameList = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /////qweqwe1122
            /////edsqsdas
            ///5435
            using (SqlConnection connection = new SqlConnection(Constants.connectionString))
            {
                try
                {
                    connection.Open();
                    string commandText = $@"select e.Name from EnteredTree e";
                    SqlCommand command = new SqlCommand(commandText, connection);
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
                cbTreeName.DataSource = nameList;
            }
        }

        private void bAddNewTree_Click(object sender, EventArgs e)
        {
            if (tbName.Text == "" || tbAge.Text == "" || tbTrunkLength.Text == "" || tbCrownVolume.Text == "") MessageBox.Show(Constants.fieldsWarning, Constants.warning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                EnteredTree = new Tree(tbName.Text, Convert.ToInt32(tbAge.Text), Convert.ToInt32(tbTrunkLength.Text), Convert.ToInt32(tbCrownVolume.Text));
                nameList.Add(tbName.Text);
                string procedureText = $"INSERT INTO EnteredTree(Name, Age, TrunkLength, CrownVolume) VALUES ('{tbName.Text}', {tbAge.Text}, {tbTrunkLength.Text}, {tbCrownVolume.Text})";
                using (SqlConnection connect = new SqlConnection(Constants.connectionString))
                {
                    SqlCommand addTree = new SqlCommand(procedureText, connect);
                    //SqlCommand clearWateringCountArtuhov = new SqlCommand(Constants.clearArtuhovWateringCount, connect);
                    //SqlCommand clearWateringCountSviatski = new SqlCommand(Constants.clearSviatskiWateringCount, connect);
                    //SqlCommand clearWateringCountKoshel = new SqlCommand(Constants.clearKoshelWateringCount, connect);

                    try
                    {
                        connect.Open();
                        addTree.ExecuteNonQuery();
                        //clearWateringCountArtuhov.ExecuteNonQuery();
                        //clearWateringCountSviatski.ExecuteNonQuery();
                        //clearWateringCountKoshel.ExecuteNonQuery();
                        MessageBox.Show($"Дерево {tbName.Text} добавлено.") ;
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
                //Sviatski.watering = 0;
                //Artuhov.watering = 0;
            }
        }

        private void cbTreeName_SelectedIndexChanged(object sender, EventArgs e)
        {

            List<int> dataList = new List<int>();
            using (SqlConnection connection = new SqlConnection(Constants.connectionString))
            {
                try
                {
                    connection.Open();
                    string commandText1 = $@"select e.Age, e.TrunkLength, e.CrownVolume from EnteredTree e where e.Name = '{cbTreeName.SelectedItem}'";
                    SqlCommand command1 = new SqlCommand(commandText1, connection);
                    SqlDataReader reader1 = command1.ExecuteReader();
                    if (reader1.HasRows)
                    {
                        while (reader1.Read())
                        {
                            for (int i = 0; i < reader1.FieldCount; i++)
                            {
                                dataList.Add(reader1.GetInt32(i));
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

        private void bGrow_Click(object sender, EventArgs e)
        {

            try
            {
                if (rbSviatski.Checked)
                {
                    Sviatski.AddWateringCount();
                    //SelectedTree.Grow();
                    using (SqlConnection connect = new SqlConnection(Constants.connectionString))
                    {
                        SqlCommand updateTree = new SqlCommand(Constants.updateEnteredTree, connect);
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
                else if (rbArtuhov.Checked)
                {
                    Artuhov.AddWateringCount();
                    //SelectedTree.Grow();
                    using (SqlConnection connect = new SqlConnection(Constants.connectionString))
                    {
                        SqlCommand updateTree = new SqlCommand(Constants.updateEnteredTree, connect);
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
                else if (rbKoshel.Checked)
                {
                    Koshel.AddWateringCount();
                    //SelectedTree.Grow();
                    using (SqlConnection connect = new SqlConnection(Constants.connectionString))
                    {
                        SqlCommand updateTree = new SqlCommand(Constants.updateEnteredTree, connect);
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
            }
            catch
            {
                MessageBox.Show("Nicht Arbaiten!");
            }
            
        }

        private void bRefresh_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(Constants.connectionString))
            {
                try
                {
                    connection.Open();
                    string commandText = $@"select e.Name from EnteredTree e";
                    SqlCommand command = new SqlCommand(commandText, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            nameList.Add(reader.GetString(0));
                        }
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
                cbTreeName.DataSource = nameList;
            }
            MessageBox.Show("Нихт арбаитен");
        }

    }
}
