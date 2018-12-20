using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwissTransport;

namespace Fahrplan.cs
{
    public partial class Abfahrtstafel : Form
    {
        Transport tafel = new Transport();
        public Abfahrtstafel()
        {
            InitializeComponent();

        }
        //Form schliessen
        private void btnZurück_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnsuchen_Click(object sender, EventArgs e)
        {

            try
            {
                //Stationen Liste abfrage
                List<StationBoard> c = tafel.GetStationBoard(comboStandort.Text).Entries;
                
                c.ForEach(delegate (StationBoard con)
                {

                    dataGridView1.Rows.Add(con.To.ToString(), con.Stop.Departure.Hour.ToString() + ":" + con.Stop.Departure.Minute.ToString());
                });

                string ort;
                ort = comboStandort.Text;
                try
                {
                    // Standort in Google maps anzeigen über  Browser
                    StringBuilder queryaddress = new StringBuilder();
                    queryaddress.Append("https://maps.google.com/maps?q=");

                    if (ort != string.Empty)
                    {
                        queryaddress.Append(ort + "," + "+");
                    }

                    webBrowser1.Navigate(queryaddress.ToString());
                    

                }
                catch(Exception ex)
                {
                    //Fehlermeldung von Googlemap.
                    MessageBox.Show(ex.Message.ToString(), "Error");
                }

            }catch 
            {
                //Fehlermeldung von Standort.
                MessageBox.Show("Bitte geben Sie einen gültigen Wert ein.");
            }
        }
        //DataGridView Inhalt löschen.
        private void btnclear_Click(object sender, EventArgs e)
        {
           

            dataGridView1.Rows.Clear();
        }
        //Endliche Standortsnamen.
        private void comboStandort_DropDown(object sender, EventArgs e)
        {
            ITransport t = new Transport();
            if (!string.IsNullOrEmpty(comboStandort.Text))
            {
                List<Station> station = t.GetStations(comboStandort.Text).StationList;
                if (station.Count > 0)
                {
                    comboStandort.DataSource = null;
                    comboStandort.DataSource = station;
                    comboStandort.DisplayMember = "Name";
                }
            }
        }

    }
}
