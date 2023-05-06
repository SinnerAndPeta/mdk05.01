using System;
using System.Data.Entity.Core.Objects;
using System.Collections.Generic;
using System.Data;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.SqlClient;

namespace Ломбард_Молчанов_Комова_ИС1_33
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            LoadGrid();
        }

        SqlConnection con = new SqlConnection("Integrated Security = false;User Id = user131_db;Password = user131;Initial Catalog = user131_db;server = stud-mssql.sttec.yar.ru,38325;");

        private void LoadGrid()
        {
            SqlCommand cmd = new SqlCommand("Select id_tovara,kl.famimaotch as klient,v.tip as vid,s.nazvanie as status,t.Nazvanie,Ves,data_zaloga,data_vikupa,chena,itog_chena From mdk105_01_tovar as t join mdk105_01_status as s on t.id_statusa = s.id_statusa join mdk105_01_vid as v on t.id_vida = v.id_vida join mdk105_01_klient as kl on t.id_klienta = kl.id_Klienta;", con);
            DataTable dt = new DataTable();
            con.Open();
            SqlDataAdapter sdr = new SqlDataAdapter(cmd);
            sdr.Fill(dt);
            dataGrid1.ItemsSource = dt.DefaultView;
            con.Close();
        }

        private void dataGrid1_CellEditEnding(object sender, DataGridCellEditEndingEventArgs e)
        {
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            int id_vida = 0;
            if (idvida.SelectedIndex == 0)
            {
                id_vida = 1;
            }
            else if (idvida.SelectedIndex == 1)
            {
                id_vida = 2;
            }
            else if (idvida.SelectedIndex == 2)
            {
                id_vida = 3;
            }
            if (id_vida != 0)
            {
                int lomb = 1;
                int sotr = 2;
                int stat = 1;
                con.Open();
                string sInsSql = "Insert into mdk105_01_tovar(id_lombarda,id_klienta,id_sotrudnika,id_vida,id_statusa,Nazvanie,Ves,data_zaloga,data_vikupa,Chena,Itog_chena) Values('{0}', '{1}', '{2}', '{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}')";
                // Считываем данные с формы
                int idkli = Convert.ToInt32(idklienta.Text);
                string Naz = Nazvanie.Text;
                int ves = int.Parse(Ves.Text);
                string datazal = datazaloga.Text;
                string datavik = datavikupa.Text;
                int chen = Convert.ToInt32(chena.Text);
                double komis = 0;
                if (id_vida == 1)
                {
                    komis = 0.40;
                }
                else if (id_vida == 2)
                {
                    komis = 0.60;
                }
                else if (id_vida == 3)
                {
                    komis = 0.80;
                }
                int itogchena = Convert.ToInt32(chen / komis);

                string sInsSotr = string.Format(sInsSql, lomb, idkli, sotr, id_vida, stat, Naz, ves, datazal, datavik, chen, itogchena);

                SqlCommand cmdIns = new SqlCommand(sInsSotr, con);

                cmdIns.ExecuteNonQuery();

                MessageBox.Show(string.Format("Товар успешно добавлен"), "Сообщение");
                con.Close();
                LoadGrid();
            }
            else
            {
                MessageBox.Show(string.Format("status 0"), "Ошибка");
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            int id_statusa = 0;
            if (Status.SelectedIndex == 0) {
                id_statusa = 1;
            } else if (Status.SelectedIndex == 1) {
                id_statusa = 2;
            } else if (Status.SelectedIndex == 2) {
                id_statusa = 3;
            }
            if (id_statusa != 0)
            {
                con.Open();
                string strAll1 = "update mdk105_01_tovar SET id_statusa = '" + id_statusa + "' WHERE id_tovara = '" + Convert.ToInt32(idtovara.Text) + "'";
                SqlCommand com6 = new SqlCommand(strAll1, con);
                com6.ExecuteNonQuery();
                MessageBox.Show(string.Format("Товар успешно изменен"), "Сообщение");
                con.Close();
                LoadGrid();
            }
            else {
                MessageBox.Show(string.Format("status 0"), "Ошибка");
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            con.Open();
            string strAll1 = "Delete from mdk105_01_tovar where id_tovara = '" + Convert.ToInt32(idtovara.Text) + "'";
            SqlCommand com1 = new SqlCommand(strAll1, con);
            com1.ExecuteNonQuery();
            MessageBox.Show(string.Format("Товар успешно удален"), "Сообщение");
            con.Close();
            LoadGrid();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            this.Hide();
            klient parent = new klient(); //Создается новая родительская форма, содержащая параметр SqlConnection con
            parent.Show();
        }
    }
}
