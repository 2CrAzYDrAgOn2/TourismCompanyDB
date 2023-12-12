using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace test_DataBase
{
    public partial class AddFormBookings : Form
    {
        private readonly DataBase dataBase = new DataBase();

        public AddFormBookings()
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
                if (int.TryParse(textBoxClientIDBookings.Text, out int clientID) && int.TryParse(textBoxTourIDBookings.Text, out int tourID) && int.TryParse(textBoxNumberOfPersons.Text, out int numberOfPersons))
                {
                    dataBase.OpenConnection();
                    var bookingDate = textBoxBookingDate.Value;
                    var totalAmount = textBoxTotalAmount.Text;
                    var addQuery = $"insert into Bookings (ClientID, TourID, BookingDate, NumberOfPersons, TotalAmount) values ('{clientID}', '{tourID}', '{bookingDate}', '{numberOfPersons}', '{totalAmount}')";
                    var sqlCommand = new SqlCommand(addQuery, dataBase.GetConnection());
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Запись успешно создана!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Цена должна иметь числовой формат!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
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