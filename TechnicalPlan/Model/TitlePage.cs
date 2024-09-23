using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalPlan.Model
{
    /// <summary>
    /// Модель для хранения информации о недвижимости.
    /// </summary>
    public class TitlePage
    {
        /// <summary>
        /// Первичный ключ для таблицы титульного листа техплана
        /// </summary>
        [Key]
        public int Id { get; set; }
        /// <summary>
        /// Тип объекта недвижимости.
        /// </summary>
        public string PropertyType { get; set; }

        /// <summary>
        /// Наименование объекта.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Адрес (местоположение) объекта.
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Субъект Российской федерации.
        /// </summary>
        public string FederalSubject { get; set; }

        /// <summary>
        /// Административный район (округ).
        /// </summary>
        public string AdministrativeDistrict { get; set; }

        /// <summary>
        /// Город (пос.).
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// Район города.
        /// </summary>
        public string CityDistrict { get; set; }

        /// <summary>
        /// Улица (пер.).
        /// </summary>
        public string Street { get; set; }

        /// <summary>
        /// Дом №.
        /// </summary>
        public string HouseNumber { get; set; }

        /// <summary>
        /// Строение (корпус).
        /// </summary>
        public string Building { get; set; }

        /// <summary>
        /// Наименование учетного органа.
        /// </summary>
        public string RegistrationAuthority { get; set; }

        /// <summary>
        /// Инвентарный номер.
        /// </summary>
        public string InventoryNumber { get; set; }

        /// <summary>
        /// Кадастровый номер.
        /// </summary>
        public string CadastralNumber { get; set; }

        /// <summary>
        /// Дата внесения сведений в реестр.
        /// </summary>
        public string RegistrationDate { get; set; }

    }
}
