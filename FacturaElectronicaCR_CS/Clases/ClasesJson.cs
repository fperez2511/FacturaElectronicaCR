using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace FacturaElectronicaCR_CS
{
    public class ClasesJson
    {
    }

    public class RespuestaHaciendaWrapper
    {
        [JsonProperty("clave")]
        public string clave { get; set; }

        [JsonProperty("fecha")]
        public string fecha { get; set; }

        [JsonProperty("ind-estado")]
        public string ind_estado { get; set; }

        [JsonProperty("respuesta-xml")]
        public string respuesta_xml { get; set; }
    }

    public class TokenWrapper
    {
        [JsonProperty("access_token")]
        public string access_token { get; set; }

        [JsonProperty("refresh_token")]
        public string refresh_token { get; set; }
    }

    public class RecepcionWrapper
    {
        [JsonProperty("clave")]
        public string clave { get; set; }

        [JsonProperty("fecha")]
        public string fecha { get; set; }

        [JsonProperty("emisor")]
        public EmisorWrapper emisor { get; set; }

        [JsonProperty("receptor")]
        public ReceptorWrapper receptor { get; set; }

        [JsonProperty("comprobanteXml")]
        public string comprobanteXml { get; set; }
    }

    public class EmisorWrapper
    {
        [JsonProperty("TipoIdentificacion")]
        public string TipoIdentificacion { get; set; }

        [JsonProperty("numeroIdentificacion")]
        public string numeroIdentificacion { get; set; }
    }

    public class ReceptorWrapper {
        [JsonProperty("TipoIdentificacion")]
        public string TipoIdentificacion { get; set; }

        [JsonProperty("numeroIdentificacion")]
        public string numeroIdentificacion { get; set; }

        public Boolean sinReceptor { get; set; }
    }
}

