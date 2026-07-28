namespace FileNameHelper
{
    public class NazevSouboru
    {
        /// <summary>
        /// Odstraní z textu znaky nepovolené v názvech souborů/složek
        /// (Windows), aby se dal bezpečně použít jako součást cesty.
        /// </summary>
        public static string OcistiProNazevSouboru(string text)
        {
            foreach (char neplatny in Path.GetInvalidFileNameChars())
                text = text.Replace(neplatny, '_');
        
            return text.Replace(' ', '_');
        }
    }
}
