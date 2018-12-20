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
using System.Net.Mail;

namespace Fahrplan.cs
{
    public partial class Fahrplan : Form
    {
        
        public Fahrplan()
        {
            InitializeComponent();
        }
        Transport transport = new Transport();
        
        //Datum übergeben
        private string Get_Date(string date1)
        {
            string date2 = date1.Remove(10);
            DateTime date3 = Convert.ToDateTime(date2);
            return date3.ToString("dd.MM.yyyy");
        }
        //Zeit übergeben
        private string Get_Time(string time1)
        {
            string time2 = time1.Remove(0, 11);
            time2 = time2.Remove(5);
            return time2;
        }

        private void btnSuchen_Click(object sender, EventArgs e)
        {
            try
            {
                //Abfrage daten sammeln
                List<Connection> c = transport.GetConnections(comboVon.Text, comboNach.Text, dtDatum.Value.ToString("yyyy-MM-dd"), dtZeit.Text).ConnectionList;
                c.ForEach(delegate (Connection con)
                {
                   

                    if (con.To.Platform == null)
                    {
                        con.To.Platform = "Bus";
                    }
                    //Antworten in DataGridView geben.
                    dataGridView1.Rows.Add(Get_Date(con.From.Departure),Get_Time(con.From.Departure),Get_Time(con.To.Arrival), con.To.Platform.ToString());
                    

                });

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Es ist ein fehler aufgetreten");
            }
        }


        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Abfahrtstafel form2ToolStripMenuItem_Click = new Abfahrtstafel();
            form2ToolStripMenuItem_Click.Show();
        }
        //Endliche Stations namen werden angezeigt (Methode)
        public void Autocomplete(string source, ComboBox cbx)
        {
            ITransport t = new Transport();
            if (!string.IsNullOrEmpty(source))
            {
                List<Station> station = t.GetStations(source).StationList;
                if (station.Count > 0)
                {
                    cbx.DataSource = null;
                    cbx.DataSource = station;
                    cbx.DisplayMember = "Name";
                }
            }
        }



        private void comboVon_DropDown(object sender, EventArgs e)
        {
            Autocomplete(comboVon.Text, comboVon);
        }

        

        private void comboNach_DropDown(object sender, EventArgs e)
        {
            Autocomplete(comboNach.Text, comboNach);
        }
        //Tausch von Standort und Ziel.
        private void btntausch_Click(object sender, EventArgs e)
        {
            string von;
            string nach;

            von = comboVon.Text;
            nach = comboNach.Text;
            comboVon.Text = nach;
            comboNach.Text = von;
        }
        //Inhalt aus DataGridView löschen
        private void btnClear_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }

        //Form schliessen
         private void btnschliessen_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Inhalt aus DataGridView wird weitergegeben.
        private void btnWeiterleiten_Click(object sender, EventArgs e)
        {
            E_mail Email = new E_mail(dataGridView1);
            Email.Show();
                
            
        }
        //Zeit anzeige Format definieren.
        private void dtZeit_ValueChanged(object sender, EventArgs e)
        {
            dtZeit.Format = DateTimePickerFormat.Time;
            dtZeit.ShowUpDown = true;
        }
        //Aktuelle Zeit eintragen.
        private void Fahrplan_Load(object sender, EventArgs e)
        {
            dtZeit.Text = DateTime.Now.TimeOfDay.ToString();

        }
    }
}
