using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Net;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;

namespace AnalisidiDatiAmbientali_Sacchiero_Baldo
{

    /*
     in questo progetto andiamo a analizzare i dati ambientali di una città, in particolare andremo a prendere i dati di temperatura, pm2.5, pm10 e indice epa, per poi visualizzarli in un grafico a barre, in modo da poter confrontare i dati tra loro e vedere quali sono i più inquinanti. Per fare questo utilizzeremo l'api di weatherapi.com, che ci permette di prendere i dati ambientali di una città in formato json, per poi deserializzarli e visualizzarli in un grafico a barre.
     facciamo una richiasta ad un'api: http://api.weatherapi.com/v1/current.json?key=12ca28e7f1874769a00142930260604&q=Luogo&aqi=yes
     ci facciamo dare un file json, che contiene i dati ambientali di una città, e poi deserializziamo il file json per prendere i dati che ci interessano, in particolare la temperatura, pm2.5, pm10 e indice epa, per poi visualizzarli in un grafico a barre.
     li mettiamo in una lista di classi dato
     si aggiorna ogni volta che si preme un pulsante
     
     poi si crea un file json con i dati raccolti, in modo da poterli salvare e visualizzare in un secondo momento, e si crea un grafico a barre per visualizzare i dati raccolti, in modo da poter confrontare i dati tra loro e vedere quali sono i più inquinanti.
     
     poi si analizzano i dati raccolti per cercare anche se ci sono delle possibili relazioni tra temperatura e inquinamento, ad esempio se la temperatura è più alta, l'inquinamento è più alto, o se la temperatura è più bassa, l'inquinamento è più basso, in modo da poter capire se c'è una relazione tra temperatura e inquinamento, e se c'è una relazione tra pm2.5 e pm10, in modo da poter capire se c'è una relazione tra pm2.5 e pm10, e se c'è una relazione tra indice epa e pm2.5, in modo da poter capire se c'è una relazione tra indice epa e pm2.5, e se c'è una relazione tra indice epa e pm10, in modo da poter capire se c'è una relazione tra indice epa e pm10.
     
     infine rappresentare con dei grafici
     */
    public partial class Form1 : Form
    {
        string Link;

        List<Cdato> dati = new List<Cdato>();

        public Form1()
        {
            InitializeComponent();

            Link = "";

            pnl_dati.Visible = false;
            pnl_luogo.Visible = true;


            tbc_dati.Selecting += (s, e) =>
            {
                if (e.TabPage == tbp_analisi)
                {
                    analisi();
                } else if(e.TabPage == tbp_grafici)
                {
                    visualGrafici();
                }
            };

            timer1.Enabled = true;
            timer1.Interval = 1000; // 1 secondo
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_luogo_Click(object sender, EventArgs e)
        {

            string luogo = txt_luogo.Text.Trim();

            // controlla che il campo di testo non sia vuoto
            if (luogo == "")
            {
                MessageBox.Show("Inserisci un luogo");
                return;
            }

            // controlla che il link sia valido e che contenga il luogo inserito

            // crea il link per l'api
            Link = $"http://api.weatherapi.com/v1/current.json?key=12ca28e7f1874769a00142930260604&q={luogo}&aqi=yes";

            // prova a pingare o altro per controllare che il link sia valido, se non è valido mostra un messaggio di errore

            try
            {
                System.Net.WebRequest request = System.Net.WebRequest.Create(Link);
                System.Net.WebResponse response = request.GetResponse();
                response.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Link non valido: " + ex.Message);
                txt_luogo.Text = "";
                return;
            }

            // se il link è valido, mostra un messaggio di conferma
            MessageBox.Show("Link valido, puoi procedere con la raccolta dei dati");

            // prende i dati da un possibile file dati.json creato in precenza
            if (File.Exists($"files/{luogo}.json"))
            {
                string json = File.ReadAllText($"files/{luogo}.json");
                dati = JsonConvert.DeserializeObject<List<Cdato>>(json);
            }

            pnl_luogo.Visible = false;
            pnl_dati.Visible = true;

        }

        private void btn_dati_Click(object sender, EventArgs e)
        {
            // prende i dati dal link e li aggiunge alla lista di dati

            try
            {
                ScaricaDato();
                MessageBox.Show("Dati raccolti con successo");
            }
            catch
            {
                MessageBox.Show("Errore nella raccolta dei dati, controlla il link e riprova");
            }
            


        }

        private void ScaricaDato()
        {
            try
            {
                // manda una richiesta al link e prende la risposta in formato json

                using (WebClient client = new WebClient())
                {

                    string risposta = client.DownloadString(Link);

                    JObject json = JObject.Parse(risposta);

                    Cdato dato = new Cdato(
                        json["location"]["name"].ToString(),
                        DateTime.Parse(json["location"]["localtime"].ToString()),
                        (double)json["current"]["temp_c"],
                        (double)json["current"]["air_quality"]["pm2_5"],
                        (double)json["current"]["air_quality"]["pm10"],
                        (int)json["current"]["air_quality"]["us-epa-index"]
                    );

                    dati.Add(dato);

                }


            }
            catch
            {
                MessageBox.Show("Errore nella raccolta dei dati, controlla il link e riprova");
                throw; // rilancia l'eccezione per essere gestita nel chiamante
            }
        }

        private void btn_mem_Click(object sender, EventArgs e)
        {
            // salvare la lista dati in un file json, in modo da poterli visualizzare in un secondo momento

            string json = JsonConvert.SerializeObject(dati, Formatting.Indented);

            string nomeCitta = txt_luogo.Text.Trim().ToLower();

            File.WriteAllText($"files/{nomeCitta}.json", json);

            MessageBox.Show($"Dati salvati in {nomeCitta}.json");
        }

        private string CalcolaStatistiche(List<Cdato> dati)
        {
            if (dati.Count == 0) return "Nessun dato disponibile.";

            string s = "📊 STATISTICHE\n";
            s += "─────────────────────────\n";

            s += $"Temperatura:\n";
            s += $"  Media:  {dati.Average(d => d.Temperatura):F2} °C\n";
            s += $"  Min:    {dati.Min(d => d.Temperatura):F2} °C\n";
            s += $"  Max:    {dati.Max(d => d.Temperatura):F2} °C\n\n";

            s += $"PM2.5:\n";
            s += $"  Media:  {dati.Average(d => d.Pm25):F2}\n";
            s += $"  Min:    {dati.Min(d => d.Pm25):F2}\n";
            s += $"  Max:    {dati.Max(d => d.Pm25):F2}\n\n";

            s += $"PM10:\n";
            s += $"  Media:  {dati.Average(d => d.Pm10):F2}\n";
            s += $"  Min:    {dati.Min(d => d.Pm10):F2}\n";
            s += $"  Max:    {dati.Max(d => d.Pm10):F2}\n\n";

            s += $"Numero rilevazioni: {dati.Count}";

            return s;
        }

        private string CalcolaCorrelazione(List<Cdato> dati)
        {
            if (dati.Count < 2) return "Servono almeno 2 rilevazioni\nper calcolare la correlazione.";

            string s = "🔗 CORRELAZIONE (Pearson)\n";
            s += "─────────────────────────\n";

            double corrTempPm25 = Pearson(
                dati.Select(d => d.Temperatura).ToList(),
                dati.Select(d => d.Pm25).ToList()
            );

            double corrTempPm10 = Pearson(
                dati.Select(d => d.Temperatura).ToList(),
                dati.Select(d => d.Pm10).ToList()
            );

            double corrPm25Pm10 = Pearson(
                dati.Select(d => d.Pm25).ToList(),
                dati.Select(d => d.Pm10).ToList()
            );

            s += $"Temp ↔ PM2.5:  {corrTempPm25:F3}  {Interpreta(corrTempPm25)}\n\n";
            s += $"Temp ↔ PM10:   {corrTempPm10:F3}  {Interpreta(corrTempPm10)}\n\n";
            s += $"PM2.5 ↔ PM10:  {corrPm25Pm10:F3}  {Interpreta(corrPm25Pm10)}\n\n";

            s += "─────────────────────────\n";
            s += "Da -1 a +1:\n";
            s += "+1 = correlazione positiva\n";
            s += " 0 = nessuna correlazione\n";
            s += "-1 = correlazione negativa";

            return s;
        }

        private double Pearson(List<double> x, List<double> y)
        {
            double mediaX = x.Average(); // calcola la media di x
            double mediaY = y.Average(); // calcola la media di y

            double numeratore = x.Zip(y, (xi, yi) => (xi - mediaX) * (yi - mediaY)).Sum(); // calcola il numeratore della formula di Pearson, il sum serve per sommare tutti i prodotti (xi - mediaX) * (yi - mediaY) per ogni coppia di valori xi e yi
            double devX = Math.Sqrt(x.Sum(xi => Math.Pow(xi - mediaX, 2))); // calcola la dispersione dei dati di x
            double devY = Math.Sqrt(y.Sum(yi => Math.Pow(yi - mediaY, 2))); // calcola la dispersione dei dati di y

            if (devX == 0 || devY == 0) // se la dispersione dei dati x o y è zero, significa che tutti i valori sono uguali, quindi non c'è correlazione, restituisci 0 per evitare divisione per zero
            {
                return 0; // nessuna correlazione se una delle due variabili è costante
            }

            return numeratore / (devX * devY); // restituisce il coefficiente di correlazione di Pearson, che va da -1 a +1, dove +1 indica una correlazione positiva perfetta, -1 indica una correlazione negativa perfetta, e 0 indica nessuna correlazione.
        }

        private string Interpreta(double r)
        {
            double abs = Math.Abs(r);
            string direzione = r >= 0 ? "positiva" : "negativa";

            if (abs >= 0.8) return $"(forte {direzione})";
            if (abs >= 0.5) return $"(moderata {direzione})";
            if (abs >= 0.2) return $"(debole {direzione})";
            return "(nessuna correlazione)";
        }

        private void analisi()
        {
            // svuota la griglia esistente
            dtg_analisi.Rows.Clear();
            dtg_analisi.Columns.Clear();

            dtg_analisi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtg_analisi.ReadOnly = true;
            dtg_analisi.AllowUserToAddRows = false;
            dtg_analisi.AllowUserToDeleteRows = false;
            dtg_analisi.AllowUserToResizeRows = false;
            dtg_analisi.AllowUserToResizeColumns = false;
            dtg_analisi.RowHeadersVisible = false;

            // aggiungi le colonne
            dtg_analisi.Columns.Add("Citta", "Città");
            dtg_analisi.Columns.Add("DataOra", "Data e Ora");
            dtg_analisi.Columns.Add("Temperatura", "Temp (°C)");
            dtg_analisi.Columns.Add("Pm25", "PM2.5");
            dtg_analisi.Columns.Add("Pm10", "PM10");
            dtg_analisi.Columns.Add("IndiceEpa", "Indice EPA");

            // riempi con i dati
            foreach (Cdato d in dati)
            {
                dtg_analisi.Rows.Add(
                    d.Citta,
                    d.DataOra.ToString("dd/MM/yyyy HH:mm"),
                    d.Temperatura,
                    d.Pm25,
                    d.Pm10,
                    d.IndiceEpa
                );
            }

            // --- STATISTICHE ---
            lbl_statistiche.Text = CalcolaStatistiche(dati);

            // --- CORRELAZIONE ---
            lbl_correlazione.Text = CalcolaCorrelazione(dati);
        }   

        private void visualGrafici()
        {
            dati = dati.OrderBy(d => d.DataOra).ToList();

            // usa il chart per visualizzare i dati raccolti, in particolare temperatura, pm2.5, pm10 e indice epa, in modo da poter confrontare i dati tra loro e vedere quali sono i più inquinanti.

            chr_grafico.Series.Clear();
            chr_grafico.Titles.Clear();

            if (dati.Count == 0)
            {
                MessageBox.Show("Nessun dato da visualizzare");
                return;
            }

            // --- SERIE ---
            Series sTemp = new Series("Temperatura");
            Series sPm25 = new Series("PM2.5");
            Series sPm10 = new Series("PM10");
            Series sEpa = new Series("Indice EPA");

            // tipo grafico
            sTemp.ChartType = SeriesChartType.Column;
            sPm25.ChartType = SeriesChartType.Column;
            sPm10.ChartType = SeriesChartType.Column;
            sEpa.ChartType = SeriesChartType.Column;

            // --- AGGIUNTA DATI ---
            foreach (Cdato d in dati)
            {
                string x = d.DataOra.ToString("HH:mm"); // oppure d.Citta

                sTemp.Points.AddXY(x, d.Temperatura);
                sPm25.Points.AddXY(x, d.Pm25);
                sPm10.Points.AddXY(x, d.Pm10);
                sEpa.Points.AddXY(x, d.IndiceEpa);
            }

            // --- AGGIUNTA AL CHART ---
            chr_grafico.Series.Add(sTemp);
            chr_grafico.Series.Add(sPm25);
            chr_grafico.Series.Add(sPm10);
            chr_grafico.Series.Add(sEpa);

            // titolo
            chr_grafico.Titles.Add("Analisi Dati Ambientali");

            // migliora leggibilità
            chr_grafico.ChartAreas[0].AxisX.Title = "Ora";
            chr_grafico.ChartAreas[0].AxisY.Title = "Valori";

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            // pulisci il file dati.json, in modo da poter ricominciare da capo con la raccolta dei dati, e pulisci anche la lista dati, in modo da non avere più dati in memoria
            // pulisci anche la lista dati, in modo da non avere più dati in memoria

            dati.Clear();

            string nomeCitta = txt_luogo.Text.Trim().ToLower();

            File.Delete($"files/{nomeCitta}.json");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_orario.Text = DateTime.Now.ToString("HH:mm:ss");

            lbl_dataOdierna.Text = DateTime.Now.ToString("dd/MM/yyyy");

        }

        private void btn_datiAuto_Click(object sender, EventArgs e)
        {
            if (tmr_raccoltaDatiAuto.Enabled)
            {
                tmr_raccoltaDatiAuto.Stop();
                btn_datiAuto.Text = "RACCOGLI DATI AUTO";
            }
            else
            {
                tmr_raccoltaDatiAuto.Interval = 30000;
                tmr_raccoltaDatiAuto.Start();
                btn_datiAuto.Text = "STOP";

                try
                {
                    ScaricaDato();
                }
                catch
                {
                    MessageBox.Show("Errore nella raccolta dei dati, controlla il link e riprova");
                }
            }
        }

        private void tmr_raccoltaDatiAuto_Tick(object sender, EventArgs e)
        {
            try
            {
                ScaricaDato();
            }
            catch
            {
                MessageBox.Show("Errore nella raccolta dei dati, controlla il link e riprova");
            }
        }
    }
}
