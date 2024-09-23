using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechnicalPlan.Model;
using TechnicalPlan.Model.Interfaces;

namespace TechnicalPlan.Contexts
{
    /// <summary>
    /// Репозиторий для работы с данными о недвижимости.
    /// Нужен, чтобы все делалось через него, а не напрямую через БД.
    /// Позволяет поменять СУБД, не меняя код
    /// </summary>
    public class TitlePageRepository:ITitlePageRepository
    {
        private readonly TechPlanDBContext _context;

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="TitlePageRepository"/>.
        /// </summary>
        /// <param name="context">Контекст базы данных.</param>
        public TitlePageRepository(TechPlanDBContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Добавляет новый титульный лист объекта недвижимости.
        /// </summary>
        /// <param name="titlePage">Информация о титульном листе объекта недвижимости.</param>
        public void AddTitlePage(TitlePage titlePage)
        {
            _context.TitlePages.Add(titlePage);
            _context.SaveChanges();
        }

        /// <summary>
        /// Получает титульный лист объекта недвижимости по идентификатору.
        /// </summary>
        /// <param name="id">Идентификатор титульного листа.</param>
        /// <returns>Информация о титульном листе объекта недвижимости.</returns>
        public TitlePage GetTitlePage(int id)
        {
            return _context.TitlePages.Find(id);
        }
        /// <summary>
        /// Получает все титульные листы объектов недвижимости.
        /// </summary>
        /// <returns>Список всех титульных листов объектов недвижимости.</returns>
        public IEnumerable<TitlePage> GetAllTitlePages()
        {
            return _context.TitlePages.ToList();
        }

        /// <summary>
        /// Обновляет информацию о существующем титульном листе объекта недвижимости.
        /// </summary>
        /// <param name="titlePage">Обновленная информация о титульном листе объекта недвижимости.</param>
        public void UpdateTitlePage(TitlePage titlePage)
        {
            _context.TitlePages.Update(titlePage);
            _context.SaveChanges();
        }

        /// <summary>
        /// Удаляет титульный лист объекта недвижимости по идентификатору.
        /// </summary>
        /// <param name="id">Идентификатор титульного листа.</param>
        public void DeleteTitlePage(int id)
        {
            var titlePage = _context.TitlePages.Find(id);
            if (titlePage != null)
            {
                _context.TitlePages.Remove(titlePage);
                _context.SaveChanges();
            }
        }
    }
}
