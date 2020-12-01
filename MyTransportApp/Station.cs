using SwissTransport;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTransportApp
{
    class Stationssuche
    {
        private ITransport transport = new Transport();

        private string stationname;
        private string stationid;
        private StationBoardRoot ausgehendeverbindungen;
        
        

        public Connections Stationverbindungssuche(string vonStation, string nachstation, DateTime datum, DateTime Zeit)
        {
            string datumstring = datum.Date.ToString("yyyy-MM-dd");           

            string zeitstring = Zeit.ToString("HH:mm");
            Connections vernbindungenrückgabe = transport.GetConnections(vonStation, nachstation, datumstring , zeitstring);
            return vernbindungenrückgabe;
        }

        public Stationssuche Abfahrtsplansuche(string eingabestationsname, Stationssuche neuesuche) 
        {
            try
            {
                var stationsobjekte = transport.GetStations(query: eingabestationsname);

                List<Station> stationen = stationsobjekte.StationList;

                foreach (Station bahnhof in stationen)
                {
                    if (bahnhof.Name.Equals(eingabestationsname))
                    {
                        neuesuche.stationname = bahnhof.Name;
                        neuesuche.stationid = bahnhof.Id;
                    }
                }

                StationBoardRoot stationsboard = transport.GetStationBoard(neuesuche.stationname, neuesuche.stationid);

                neuesuche.ausgehendeverbindungen = stationsboard;

                return neuesuche;
            }
            catch { return neuesuche; }
        }

        public List<Station> Vorschlaege(string texteingabe)
        {
            var stationsobjekte = transport.GetStations(query: texteingabe);

            List<Station> stationenvorschlaege = stationsobjekte.StationList;

            return stationenvorschlaege;
        }

        public Coordinate GetKordinaten(string station) 
        {            
                var stationsobjekte = transport.GetStations(query: station);
            try
            {
                List<Station> stationen = stationsobjekte.StationList;

                foreach (Station bahnhof in stationen.Take(1))
                {
                    return bahnhof.Coordinate;
                }
            }
            catch { return null; }
            return null;
        }

        public StationBoardRoot getausgehendeverbindungen() { return ausgehendeverbindungen; }
    }
}
