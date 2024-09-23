using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalPlan.Model.Interfaces
{
    /// <summary>
    /// Интерфейс для репозитория, работающего с титульными листами объектов недвижимости.
    /// </summary>
    interface ITitlePageRepository
    {
        /// <summary>
        /// Добавляет новый титульный лист объекта недвижимости.
        /// </summary>
        /// <param name="titlePage">Информация о титульном листе объекта недвижимости.</param>
        void AddTitlePage(TitlePage titlePage);

        /// <summary>
        /// Получает титульный лист объекта недвижимости по идентификатору.
        /// </summary>
        /// <param name="id">Идентификатор титульного листа.</param>
        /// <returns>Информация о титульном листе объекта недвижимости.</returns>
        TitlePage GetTitlePage(int id);

        /// <summary>
        /// Получает все титульные листы объектов недвижимости.
        /// </summary>
        /// <returns>Список всех титульных листов объектов недвижимости.</returns>
        IEnumerable<TitlePage> GetAllTitlePages();

        /// <summary>
        /// Обновляет информацию о существующем титульном листе объекта недвижимости.
        /// </summary>
        /// <param name="titlePage">Обновленная информация о титульном листе объекта недвижимости.</param>
        void UpdateTitlePage(TitlePage titlePage);

        /// <summary>
        /// Удаляет титульный лист объекта недвижимости по идентификатору.
        /// </summary>
        /// <param name="id">Идентификатор титульного листа.</param>
        void DeleteTitlePage(int id);
    }
}
