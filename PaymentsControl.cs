using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MiniWhatsApp
{
    public partial class PaymentsControl : UserControl
    {

        public bool IsAdmin = false;
        public PaymentsControl()
        {
            InitializeComponent();
            btnDeletePayment.Visible = false;

        }

        public void SetAdminMode()
        {
            IsAdmin = true;
            btnDeletePayment.Visible = true;
            LoadPayments();
        }

        public void LoadUserPayments()
        {
            IsAdmin = false;

            LoadPayments();
        }
        private void LoadPayments()
        {
            MySqlConnection conn = DBConnection.GetConnection();

            try
            {
                conn.Open();

                string query;

                if (IsAdmin)
                {
                    query =
"SELECT Id, Username, RoomNumber, " +
"PaymentMethod, Amount, PaymentDate " +
"FROM Payments";
                }
                else
                {
                    query =
                    "SELECT RoomNumber, PaymentMethod, " +
                    "Amount, PaymentDate " +
                    "FROM Payments " +
                    "WHERE Username=@Username";
                }

                MySqlDataAdapter adapter =
                    new MySqlDataAdapter(query, conn);

                if (!IsAdmin)
                {
                    adapter.SelectCommand.Parameters.AddWithValue(
                        "@Username",
                        CurrentUser.Username
                    );
                }

                DataTable dt = new DataTable();

                adapter.Fill(dt);

                dgvPayments.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnDeletePayment_Click(
    object sender,
    EventArgs e)
        {
            if (dgvPayments.SelectedRows.Count > 0)
            {
                int paymentId =
                    Convert.ToInt32(
                        dgvPayments.SelectedRows[0]
                        .Cells["Id"]
                        .Value
                    );

                MySqlConnection conn =
                    DBConnection.GetConnection();

                try
                {
                    conn.Open();

                    string query =
                        "DELETE FROM Payments " +
                        "WHERE Id=@Id";

                    MySqlCommand cmd =
                        new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue(
                        "@Id",
                        paymentId
                    );

                    cmd.ExecuteNonQuery();

                    MessageBox.Show(
                        "Payment Deleted Successfully"
                    );

                    LoadPayments();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }


    }
}
