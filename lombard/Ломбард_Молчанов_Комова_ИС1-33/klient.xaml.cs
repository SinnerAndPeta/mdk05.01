using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Ломбард_Молчанов_Комова_ИС1_33
{
    /// <summary>
    /// Interaction logic for klient.xaml
    /// </summary>
    public partial class klient : Window
    {
        public klient()
        {
            InitializeComponent();
            LoadGrid();
        }

        SqlConnection con = new SqlConnection("Integrated Security = false;User Id = user131_db;Password = user131;Initial Catalog = user131_db;server = stud-mssql.sttec.yar.ru,38325;");

        CollectionViewSource viewSource;

        private void LoadGrid()
        {
            SqlCommand cmd = new SqlCommand("select * from mdk105_01_klient", con);
            DataTable dt = new DataTable();
            con.Open();
            SqlDataAdapter sdr = new SqlDataAdapter(cmd);
            sdr.Fill(dt);
            dataGrid1.ItemsSource = dt.DefaultView;
            con.Close();
        }

        /// <summary>
        /// Поиск
        /// </summary>
        private void LoadGridSearch()
        {
            SqlCommand cmd = new SqlCommand("SELECT* from mdk105_01_klient WHERE famimaotch like '"+ idklienta_Copy.Text + "%'", con);
            DataTable dt = new DataTable();
            con.Open();
            SqlDataAdapter sdr = new SqlDataAdapter(cmd);
            sdr.Fill(dt);
            dataGrid1.ItemsSource = dt.DefaultView;
            con.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            con.Open();
            string sInsSql = "Insert into mdk105_01_klient(famimaotch,Data_rozhdeniya,Seria_Nomer,gorod_rozhdeniya,Telephone,Email) Values('{0}', '{1}', '{2}', '{3}','{4}','{5}')";
            
            string fam = fio.Text;
            DateTime date = Convert.ToDateTime(datarozh.Text);
            string ser = serianomer.Text;
            string gorod = gorodrozh.Text;
            string teleph = telephone.Text;
            string em = email.Text;
            string sInsSotr = string.Format(sInsSql, fam, date, ser, gorod, teleph, em);

            SqlCommand cmdIns = new SqlCommand(sInsSotr, con);

            cmdIns.ExecuteNonQuery();

            MessageBox.Show(string.Format("Клиент успешно добавлен"), "Сообщение");
            con.Close();
            LoadGrid();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            con.Open();
            string strAll1 = "Delete from mdk105_01_klient where id_Klienta = '" + idklienta.Text + "'";
            SqlCommand com1 = new SqlCommand(strAll1, con);
            com1.ExecuteNonQuery();
            MessageBox.Show(string.Format("Клиент успешно удален"), "Сообщение");
            con.Close();
            LoadGrid();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            this.Hide();
            MainWindow parent = new MainWindow(); //Создается новая родительская форма, содержащая параметр SqlConnection con
            parent.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (novienomer.Text == "")
            {
                con.Open();
                string strAll2 = "update mdk105_01_klient SET  Seria_Nomer = '" + novieserianomer.Text + "' WHERE id_Klienta = '" + Convert.ToInt32(idklienta.Text) + "'";
                SqlCommand com7 = new SqlCommand(strAll2, con);
                com7.ExecuteNonQuery();
                MessageBox.Show(string.Format("Данные успешно изменены"), "Сообщение");
                con.Close();
                LoadGrid();
            }
            else if (novieserianomer.Text == "")
            {
                con.Open();
                string strAll3 = "update mdk105_01_klient SET Telephone = '" + novienomer.Text + "' WHERE id_Klienta = '" + Convert.ToInt32(idklienta.Text) + "'";
                SqlCommand com8 = new SqlCommand(strAll3, con);
                com8.ExecuteNonQuery();
                MessageBox.Show(string.Format("Данные успешно изменены"), "Сообщение");
                con.Close();
                LoadGrid();
            }
            else
            {
                con.Open();
                string strAll1 = "update mdk105_01_klient SET Telephone = '" + novienomer.Text + "', Seria_Nomer = '" + novieserianomer.Text + "' WHERE id_Klienta = '" + Convert.ToInt32(idklienta.Text) + "'";
                SqlCommand com6 = new SqlCommand(strAll1, con);
                com6.ExecuteNonQuery();
                MessageBox.Show(string.Format("Данные успешно изменены"), "Сообщение");
                con.Close();
                LoadGrid();
            }
        }

        private void idklienta_Copy_TextChanged(object sender, TextChangedEventArgs e)
        {
            LoadGridSearch();
        }


    }
}
