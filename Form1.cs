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

namespace AnalisidiDatiAmbientali_Sacchiero_Baldo
{

    /*
     in questo progetto andiamo a analizzare i dati ambientali di una città, in particolare andremo a prendere i dati di temperatura, pm2.5, pm10 e indice epa, per poi visualizzarli in un grafico a barre, in modo da poter confrontare i dati tra loro e vedere quali sono i più inquinanti. Per fare questo utilizzeremo l'api di weatherapi.com, che ci permette di prendere i dati ambientali di una città in formato json, per poi deserializzarli e visualizzarli in un grafico a barre.
     facciamo una richiasta ad un'api: http://api.weatherapi.com/v1/current.json?key=12ca28e7f1874769a00142930260604&q=Luogo&aqi=yes
     ci facciamo dare un file json, che contiene i dati ambientali di una città, in questo caso Vicenza, e poi deserializziamo il file json per prendere i dati che ci interessano, in particolare la temperatura, pm2.5, pm10 e indice epa, per poi visualizzarli in un grafico a barre.
     li mettiamo in una lista di classi dato
     si aggiorna ogni volta che si preme un pulsante
     
     poi si crea un file json con i dati raccolti, in modo da poterli salvare e visualizzare in un secondo momento, e si crea un grafico a barre per visualizzare i dati raccolti, in modo da poter confrontare i dati tra loro e vedere quali sono i più inquinanti.
     
     poi si analizzano i dati raccolti per cercare anche se ci sono delle possibili relazioni tra temperatura e inquinamento, ad esempio se la temperatura è più alta, l'inquinamento è più alto, o se la temperatura è più bassa, l'inquinamento è più basso, in modo da poter capire se c'è una relazione tra temperatura e inquinamento, e se c'è una relazione tra pm2.5 e pm10, in modo da poter capire se c'è una relazione tra pm2.5 e pm10, e se c'è una relazione tra indice epa e pm2.5, in modo da poter capire se c'è una relazione tra indice epa e pm2.5, e se c'è una relazione tra indice epa e pm10, in modo da poter capire se c'è una relazione tra indice epa e pm10.
     
     infine rappresentare con dei grafici
     */

    /*
     PARTE 2 – Sviluppo dell’applicazione software
Sviluppare un’applicazione software utilizzando il linguaggio C#.
Obiettivo dell’applicazione
L’applicazione dovrà raccogliere dati dal web relativi a:
• temperatura
• livello di inquinamento atmosferico
e analizzarli per individuare eventuali correlazioni tra le due variabili.

Funzionalità richieste
Raccolta dati
Il programma deve:
• collegarsi a un servizio web tramite API
• recuperare dati meteorologici e ambientali
• estrarre le informazioni utili
I dati minimi da raccogliere sono:
• data e ora
• temperatura
• indice di qualità dell’aria o livello di inquinamento

Memorizzazione dei dati
I dati raccolti dovranno essere salvati in modo strutturato, ad esempio in:
• file CSV
• file JSON
• database

Analisi dei dati
Il programma dovrà permettere di:
• visualizzare i dati raccolti
• confrontare i valori nel tempo
• individuare possibili relazioni tra temperatura e inquinamento

Visualizzazione
I risultati dell’analisi dovranno essere presentati tramite:
• tabelle
• grafici
• riepiloghi statistici*/
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
                return;
            }

            // se il link è valido, mostra un messaggio di conferma
            MessageBox.Show("Link valido, puoi procedere con la raccolta dei dati");

            pnl_luogo.Visible = false;
            pnl_dati.Visible = true;

        }

        private void btn_dati_Click(object sender, EventArgs e)
        {
            // prende i dati dal link e li aggiunge alla lista di dati

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
                    MessageBox.Show($"Dato aggiunto! Temperatura: {dato.Temperatura}°C, PM2.5: {dato.Pm25}");

                }


            }
            catch
            {
                MessageBox.Show("Errore nella raccolta dei dati, controlla il link e riprova");
            }
        }
    }
}
