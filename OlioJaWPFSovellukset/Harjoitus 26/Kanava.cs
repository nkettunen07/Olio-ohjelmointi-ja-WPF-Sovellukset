using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus_26
{
    internal class Kanava
    {
        public static string Pyyntö(string kanava_id)
        {
            // Tehdään tuleva pyyntö servulle
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create("https://axern.space/api/get?platform=youtube&type=channel&id="+kanava_id);
            httpWebRequest.Method = "GET"; // haetaan dataa niin GET
            HttpWebResponse httpResponse = (HttpWebResponse)httpWebRequest.GetResponse(); // lähetetään pyyntö
            string result; // tyhjä vastaus string
            using (StreamReader streamReader = new StreamReader(httpResponse.GetResponseStream())) // otetaan vastaus
            {
                result = streamReader.ReadToEnd(); // kun valmis niin asetetaan result siihen vastaukseen
            }
            return result; // ja siinä meillä on json vastaus servulta
        }
        public static string OtaJaFormatNumeroResponsesta(string result, bool format=false)
        {
            // 1. result jaetaan 2 osaan estSubCount": jälkeen josta se jälkimmäinen otetaan
            // 2. string jaetaan pilkun kohdalla 2 osaa josta otetaan ensimmäinen osa
            // 3. koska se on numero esim 123456789 mutta string muodossa, tehdään siitä integer (int.Parse)
            // 4. lisätään välejä/pilkkuja siihen numeroon että on helpompaa ymmärtää
            // 5. tadaa!
            return format == true ? result.Split(new[] { "\"estSubCount\":" }, StringSplitOptions.None)[1].Split(new[] { "," }, StringSplitOptions.None)[0] : $"{int.Parse(result.Split(new[] { "\"estSubCount\":" }, StringSplitOptions.None)[1].Split(new[] { "," }, StringSplitOptions.None)[0]):n0}";
        }
    }
}
