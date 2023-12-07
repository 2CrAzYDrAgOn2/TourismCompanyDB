using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace test_DataBase
{
    public partial class AddFormTours : Form
    {
        private readonly DataBase dataBase = new DataBase();

        public AddFormTours()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        /// <summary>
        /// ButtonSave_Click вызывается при нажатии на кнопку "Сохранить"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                dataBase.OpenConnection();
                var tourName = textBoxTourName.Text;
                var destination = textBoxDestination.Text;
                var startDate = textBoxStartDate.Text;
                var endDate = textBoxEndDate.Text;
                var price = textBoxPrice.Text;
                var addQuery = $"insert into Tours (TourName, Destination, StartDate, EndDate, Price) values ('{tourName}', '{destination}', '{startDate}', '{endDate}', '{price}')";
                var sqlCommand = new SqlCommand(addQuery, dataBase.GetConnection());
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Запись успешно создана!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dataBase.CloseConnection();
            }
        }
    }
}