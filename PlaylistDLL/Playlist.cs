/******************************************************************************
 *                                                                            *
 *  Fisier:      Playlist.cs                                                  *
 *  Autor(i):    Lemny Erich, Popescu Vlad                                    *
 *                                                                            *
 *     Descriere: Fișier ce implementează clasa statică Playlist pentru       *
 * încărcarea și salvarea playlist-urilor din program.                        *
 ******************************************************************************/


using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaylistDLL
{
    /// <summary>
    /// Clasă statică pentru citirea și salvarea playlist-urilor din aplicație
    /// </summary>
    public static class Playlist
    {
        /// <summary>
        /// Metodă statică pentru salvarea unui playlist în memoria externă
        /// </summary>
        /// <param name="playlistPath">Calea pentru salvarea playlist-ului</param>
        /// <param name="songsLocations">Conținutul playlist-ului sub formă de List<string></param>
        public static void Save(string playlistPath, List<string> songsLocations)
        {
            try
            {
                string content = "";
                for (int i = 0; i < songsLocations.Count; i++)
                {
                    content += songsLocations[i] + "\r\n";
                }

                File.WriteAllText(playlistPath, content);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Metodă statică pentru citirea unui playlist din memoria externă
        /// </summary>
        /// <param name="playlistPath">Calea spre playlist</param>
        /// <returns>Conținutul playlist-ului sub forma unui array de string-uri, fiecare string fiind un rând</returns>
        public static string[] Open(string playlistPath)
        {
            try
            {
                string[] songsLocations = File.ReadAllLines(playlistPath);

                return songsLocations;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
