using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace EntityFramework
{
    public partial class Form1 : Form
    {
        private SqlConnection sqlConnection = null;
        private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\home\\source\\repos\\EntityFramework\\EntityFramework\\Database1.mdf;Integrated Security=True";

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void Connect_Click(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(connectionString);

            try
            {
                sqlConnection.Open();

                MessageBox.Show("Подключение прошло успешно!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Disconnect_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnection.Close();

                sqlConnection = null;

                MessageBox.Show("Отключение прошло успешно!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void ShowAuthors_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(
                    "SELECT * FROM Author",
                    sqlConnection
                );

                DataSet dataSet = new DataSet();

                dataAdapter.Fill(dataSet);

                dataGridView1.DataSource = dataSet.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ShowBooks_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(
                    "SELECT * FROM Book",
                    sqlConnection
                );

                DataSet dataSet = new DataSet();

                dataAdapter.Fill(dataSet);

                dataGridView1.DataSource = dataSet.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ShowPublishers_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(
                    "SELECT * FROM Publisher",
                    sqlConnection
                );

                DataSet dataSet = new DataSet();

                dataAdapter.Fill(dataSet);

                dataGridView1.DataSource = dataSet.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void AddAuthor_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(
                    $"INSERT INTO Author(FirstName, LastName) VALUES ('{FirstNameBox.Text}', '{LastNameBox.Text}')",
                    sqlConnection
                );

                DataSet dataSet = new DataSet();

                dataAdapter.Fill(dataSet);

                MessageBox.Show("Автор успешно добавлен!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void AddBook_Click(object sender, EventArgs e)
        {
            try
            {
                string request = null;
                if (PagesBox.Text == "" && PriceBox.Text == "")
                    request = $"INSERT INTO Book(Title, IdAuthor, IdPublisher) VALUES ('{TitleBox.Text}', {IdAuthorBox.Text}, {IdPublisherBox.Text})";
                else if (PagesBox.Text == "")
                    request = $"INSERT INTO Book(Title, IdAuthor, Price, IdPublisher) VALUES ('{TitleBox.Text}', {IdAuthorBox.Text}, {PriceBox.Text}, {IdPublisherBox.Text})";
                else if (PriceBox.Text == "")
                    request = $"INSERT INTO Book(Title, IdAuthor, Pages, IdPublisher) VALUES ('{TitleBox.Text}', {IdAuthorBox.Text}, {PagesBox.Text}, {IdPublisherBox.Text})";
                else
                    request = $"INSERT INTO Book(Title, IdAuthor, Pages, Price, IdPublisher) VALUES ('{TitleBox.Text}', {IdAuthorBox.Text}, {PagesBox.Text}, {PriceBox.Text}, {IdPublisherBox.Text})";

                SqlDataAdapter dataAdapter = new SqlDataAdapter(
                    request,
                    sqlConnection
                );

                DataSet dataSet = new DataSet();

                dataAdapter.Fill(dataSet);

                MessageBox.Show("Книга успешно добавлена!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void AddPublisher_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(
                    $"INSERT INTO Publisher(PublisherName, Adres) VALUES ('{PublisherNameBox.Text}', '{AdresBox.Text}')",
                    sqlConnection
                );

                DataSet dataSet = new DataSet();

                dataAdapter.Fill(dataSet);

                MessageBox.Show("Издательство успешно добавлено!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                string request = null;
                if (TableForDeleteComboBox.SelectedItem == TableForDeleteComboBox.Items[0])
                    request = $"DELETE FROM Book WHERE IdAuthor={IdForDeleteBox.Text};" +
                              $"DELETE FROM Author WHERE Id={IdForDeleteBox.Text};";
                else if (TableForDeleteComboBox.SelectedItem == TableForDeleteComboBox.Items[1])
                    request = $"DELETE FROM Book WHERE Id={IdForDeleteBox.Text};";
                else if (TableForDeleteComboBox.SelectedItem == TableForDeleteComboBox.Items[2])
                    request = $"DELETE FROM Book WHERE IdPublisher={IdForDeleteBox.Text};" +
                              $"DELETE FROM Publisher WHERE Id={IdForDeleteBox.Text};";
                else return;

                SqlDataAdapter dataAdapter = new SqlDataAdapter(
                    request,
                    sqlConnection
                );

                DataSet dataSet = new DataSet();

                dataAdapter.Fill(dataSet);

                MessageBox.Show("Запись(и) успешно удалена(ы)!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void Edit_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(
                    $"UPDATE {TableForEditComboBox.Text} " +
                    $"SET {ColumnForEditComboBox.Text}='{NewValueBox.Text}' " +
                    $"WHERE id={IdForEditBox.Text}",
                    sqlConnection
                );

                DataSet dataSet = new DataSet();

                dataAdapter.Fill(dataSet);

                MessageBox.Show("Запись(и) успешно изменена(ы)!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void TableForEditComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ColumnForEditComboBox.Items.Clear();
            ColumnForEditComboBox.Text = null;

            if (TableForEditComboBox.SelectedItem == TableForEditComboBox.Items[0])
                ColumnForEditComboBox.Items.AddRange(new object[] {
                    "FirstName",
                    "LastName"
                });
            else if (TableForEditComboBox.SelectedItem == TableForEditComboBox.Items[1])
                ColumnForEditComboBox.Items.AddRange(new object[] {
                    "Title",
                    "IdAuthor",
                    "Pages",
                    "Price",
                    "IdPublisher"
                });
            else if (TableForEditComboBox.SelectedItem == TableForEditComboBox.Items[2])
                ColumnForEditComboBox.Items.AddRange(new object[] {
                    "PublisherName",
                    "Adres"
                });
        }


        private void Surch_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(
                    $"SELECT * FROM Book WHERE {FilterComboBox.Text}={FilterValue.Text}",
                    sqlConnection
                );

                DataSet dataSet = new DataSet();

                dataAdapter.Fill(dataSet);

                dataGridView1.DataSource = dataSet.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void FloppaStyle_Click(object sender, EventArgs e)
        {
            try
            {
                System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
                System.IO.Stream resourceStram = assembly.GetManifestResourceStream(@"EntityFramework.pelmeni.wav");
                SoundPlayer soundPlayer = new SoundPlayer(resourceStram);
                soundPlayer.Play();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }   
}       
        
        