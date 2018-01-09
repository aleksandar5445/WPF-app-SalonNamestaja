using rs12_2011.model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rs12_2011.UI.ViewModel
{
    class Vezbe
    {
        #region CRUD
        public static ObservableCollection<TipNamestaja> GetAll()
        {
            var TipoviNamestaja = new ObservableCollection<TipNamestaja>();

            using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["POP"].ConnectionString))
            {
                SqlCommand cmd = con.CreateCommand();
                SqlDataAdapter da = new SqlDataAdapter();
                DataSet ds = new DataSet();

                cmd.CommandText = "SELECT * from TipNamestaja WHERE Obrisan=0;";
                da.SelectCommand = cmd;
                da.Fill(ds, "TipNamestaja");

                foreach (DataRow row in ds.Tables["TipNamestaja"].Rows)
                {
                    var tn = new TipNamestaja();
                    tn.Id = Convert.ToInt32(row["Id"]);
                    tn.Naziv = row["Naziv"].ToString();
                    tn.Obrisan = bool.Parse(row["Obrisan"].ToString());

                    TipoviNamestaja.Add(tn);
                }
            }
        }
        #endregion

        public static TipNamestaja Create(TipNamestaja tn)
        {
            var TipoviNamestaja = new ObservableCollection<TipNamestaja>();

            using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["POP"].ConnectionString))
            {
                SqlCommand cmd = con.CreateCommand();
                SqlDataAdapter da = new SqlDataAdapter();
                DataSet ds = new DataSet();

                cmd.CommandText = "INSERT INTO TipNamestaja(Naziv,Obrisan) VALUES(@Naziv,@Obrisan)";
                cmd.CommandText += "SELECT SCOPE_IDENTITY();";
                cmd.Parameters.AddWithValue("Naziv", tn.Naziv);
                cmd.Parameters.AddWithValue("Obrisan", tn.Obrisan);

                tn.Id = int.Parse(cmd.ExecuteScalar().ToString());

            }
            //Projekat.instance.TipoviNamestaja.add(tn); 
        }
        //azuriranje modela;
        foreach(var TipNamestaja in Projekat.instance.TipoviNamestaja){
            TipNamestaja.Naziv=tn.naziv;
            TipNamestaja.Obrisan=tin.Obrisan;


    }
}
