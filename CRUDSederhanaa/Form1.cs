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

namespace CRUDSederhanaa
{
    public partial class Form1 : Form
    {
        // Connection String untuk menghubungkan ke database SQL Server
        private string connectionString = "Data Source=LAPTOP-NIHBFT5J\\RAFTHA;" +
                                         "Initial Catalog=OrganisasiMahasiswa;Integrated Security=True";


       