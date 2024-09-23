using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalPlan.ViewModel
{
    /// <summary>
    /// Коллекции для ComboBox.
    /// </summary>
    public class ComboBoxCollections
    {
        /// <summary>
        /// Доступные типы объектов недвижимости.
        /// </summary>
        public ObservableCollection<string> PropertyTypes { get; set; }

        /// <summary>
        /// Доступные субъекты Российской Федерации.
        /// </summary>
        public ObservableCollection<string> FederalSubjects { get; set; }

        /// <summary>
        /// Доступные административные районы.
        /// </summary>
        public ObservableCollection<string> AdministrativeDistricts { get; set; }

        /// <summary>
        /// Доступные города.
        /// </summary>
        public ObservableCollection<string> Cities { get; set; }

        /// <summary>
        /// Доступные районы городов.
        /// </summary>
        public ObservableCollection<string> CityDistricts { get; set; }

        /// <summary>
        /// Конструктор для инициализации коллекций.
        /// </summary>
        public ComboBoxCollections()
        {
            InitializeCollections();
        }

        /// <summary>
        /// Инициализация коллекций с предопределенными значениями.
        /// </summary>
        private void InitializeCollections()
        {
            PropertyTypes = new ObservableCollection<string>
        {
            "Квартира",
            "Дом",
            "Земельный участок",
            "Коммерческая недвижимость"
        };

            FederalSubjects = new ObservableCollection<string>
        {
            "Москва",
            "Санкт-Петербург",
            "Калужская область",
            "Татарстан"
        };

            AdministrativeDistricts = new ObservableCollection<string>
        {
            "Центральный",
            "Северный",
            "Южный",
            "Западный"
        };

            Cities = new ObservableCollection<string>
        {
            "Москва",
            "Санкт-Петербург",
            "Казань",
            "Нижний Новгород"
        };

            CityDistricts = new ObservableCollection<string>
        {
            "Тверской",
            "Арбат",
            "Пресненский",
            "Северное Измайлово"
        };
        }
    }
}
