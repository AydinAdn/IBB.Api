using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using IBB.Api.Models;

namespace IBB.Api
{
    public interface IIbbClient
    {
        /// <summary>
        ///     Tüm Garaj Listesi.
        /// </summary>
        /// <returns>Garaj Listesi</returns>
        Task<IEnumerable<GarajResponse>> GetGarajAsync();

        /// <summary>
        ///     Tüm Durak Listesi.
        /// </summary>
        /// <returns>Durak Listesi</returns>
        Task<IEnumerable<DurakResponse>> GetDurakAsync();

        /// <summary>
        ///     Durak kodu
        /// </summary>
        /// <param name="durakKodu">Aranan durak</param>
        /// <returns>Durak</returns>
        Task<IEnumerable<DurakResponse>> GetDurakAsync(int durakKodu);

        /// <summary>
        ///     Araclarin guncel konum bilgileri.
        /// </summary>
        /// <returns>Anlık araç konum bilgileri</returns>
        Task<IEnumerable<AracKonumuResponse>> GetAracKonumlariAsync();

        /// <summary>
        ///     Yapılan Kazaların X, Y koordinatlarını içermektedir.
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        Task<IEnumerable<KazaLokasyonResponse>> GetKazaLokasyonAsync(DateTime date);

        /// <summary>
        ///     Tum otobus hatlarin tum duraklari
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<DurakDetayResponse>> GetDurakDetayAsync();

        /// <summary>
        ///     Bir otobus hattinin duraklari. 
        /// </summary>
        /// <param name="hatKodu">Otobus hat kodu</param>
        /// <returns></returns>
        Task<IEnumerable<DurakDetayResponse>> GetDurakDetayAsync(string hatKodu);

        /// <summary>
        ///     Tum otobus hatlarin servis detaylari
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<HatServisResponse>> GetHatServisAsync();

        /// <summary>
        ///     Bir otobus hattinin servis detaylari
        /// </summary>
        /// <param name="hatKodu">Otobus hat kodu</param>
        /// <returns>Hat servis detaylari</returns>
        Task<IEnumerable<HatServisResponse>> GetHatServisAsync(string hatKodu);
    }
}