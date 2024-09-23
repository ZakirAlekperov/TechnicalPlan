using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TechnicalPlan.Contexts;
using TechnicalPlan.Core;
using TechnicalPlan.Model;

namespace TechnicalPlan.ViewModel
{
    /// <summary>
    /// ViewModel для управления данными о титульных листах объектов недвижимости.
    /// </summary>
    public class MainViewModel : BaseViewModel // BaseViewModel реализует INotifyPropertyChanged
    {
        private readonly TitlePageRepository _repository; // Репозиторий для работы с титульными листами


        // Свойства для данных формы

        /// <summary>
        /// Тип объекта недвижимости.
        /// </summary>
        private string _propertyType;
        public string PropertyType
        {
            get => _propertyType;
            set => SetProperty(ref _propertyType, value);
        }

        /// <summary>
        /// Наименование объекта.
        /// </summary>
        private string _name;
        public string Name
        {
            get => _name;
            set => SetProperty(ref _name, value);
        }

        /// <summary>
        /// Адрес (местоположение) объекта.
        /// </summary>
        private string _address;
        public string Address
        {
            get => _address;
            set => SetProperty(ref _address, value);
        }

        /// <summary>
        /// Субъект Российской Федерации.
        /// </summary>
        private string _federalSubject;
        public string FederalSubject
        {
            get => _federalSubject;
            set => SetProperty(ref _federalSubject, value);
        }

        /// <summary>
        /// Административный район (округ).
        /// </summary>
        private string _administrativeDistrict;
        public string AdministrativeDistrict
        {
            get => _administrativeDistrict;
            set => SetProperty(ref _administrativeDistrict, value);
        }

        /// <summary>
        /// Город (пос.).
        /// </summary>
        private string _city;
        public string City
        {
            get => _city;
            set => SetProperty(ref _city, value);
        }

        /// <summary>
        /// Район города.
        /// </summary>
        private string _cityDistrict;
        public string CityDistrict
        {
            get => _cityDistrict;
            set => SetProperty(ref _cityDistrict, value);
        }

        /// <summary>
        /// Улица (пер.).
        /// </summary>
        private string _street;
        public string Street
        {
            get => _street;
            set => SetProperty(ref _street, value);
        }

        /// <summary>
        /// Дом №.
        /// </summary>
        private string _houseNumber;
        public string HouseNumber
        {
            get => _houseNumber;
            set => SetProperty(ref _houseNumber, value);
        }

        /// <summary>
        /// Строение (корпус).
        /// </summary>
        private string _building;
        public string Building
        {
            get => _building;
            set => SetProperty(ref _building, value);
        }

        /// <summary>
        /// Наименование учетного органа.
        /// </summary>
        private string _registrationAuthority;
        public string RegistrationAuthority
        {
            get => _registrationAuthority;
            set => SetProperty(ref _registrationAuthority, value);
        }

        /// <summary>
        /// Инвентарный номер.
        /// </summary>
        private string _inventoryNumber;
        public string InventoryNumber
        {
            get => _inventoryNumber;
            set => SetProperty(ref _inventoryNumber, value);
        }

        /// <summary>
        /// Кадастровый номер.
        /// </summary>
        private string _cadastralNumber;
        public string CadastralNumber
        {
            get => _cadastralNumber;
            set => SetProperty(ref _cadastralNumber, value);
        }

        /// <summary>
        /// Дата внесения сведений в реестр.
        /// </summary>
        private string _registrationDate;
        public string RegistrationDate
        {
            get => _registrationDate;
            set => SetProperty(ref _registrationDate, value);
        }

        /// <summary>
        /// Список титульных листов объектов недвижимости.
        /// </summary>
        public ObservableCollection<TitlePage> TitlePages { get; set; }

        /// <summary>
        /// Команда для добавления нового титульного листа.
        /// </summary>
        public ICommand AddTitlePageCommand { get; }

        /// <summary>
        /// Команда для загрузки всех титульных листов.
        /// </summary>
        public ICommand LoadTitlePagesCommand { get; }

        public MainViewModel(TitlePageRepository repository)
        {
            _repository = repository;
            TitlePages = new ObservableCollection<TitlePage>();
            LoadTitlePagesCommand = new RelayCommand(LoadTitlePages);
            AddTitlePageCommand = new RelayCommand(AddTitlePage);
        }

        /// <summary>
        /// Загружает все титульные листы из репозитория.
        /// </summary>
        private void LoadTitlePages()
        {
            var titlePages = _repository.GetAllTitlePages();
            TitlePages.Clear();
            foreach (var titlePage in titlePages)
            {
                TitlePages.Add(titlePage);
            }
        }
        /// <summary>
        /// Метод для сохранения нового титульного листа в базе данных
        /// </summary>
        private void SaveTitlePage()
        {
            var newTitlePage = new TitlePage
            {
                PropertyType = PropertyType,
                Name = Name,
                Address = Address,
                FederalSubject = FederalSubject,
                AdministrativeDistrict = AdministrativeDistrict,
                City = City,
                CityDistrict = CityDistrict,
                Street = Street,
                HouseNumber = HouseNumber,
                Building = Building,
                RegistrationAuthority = RegistrationAuthority,
                InventoryNumber = InventoryNumber,
                CadastralNumber = CadastralNumber,
                RegistrationDate = RegistrationDate
            };

            // Сохранение в базе данных
            _repository.AddTitlePage(newTitlePage);

            // Очистка полей после сохранения (если необходимо)
            PropertyType = string.Empty;
            Name = string.Empty;
            Address = string.Empty;
            FederalSubject = string.Empty;
            AdministrativeDistrict = string.Empty;
            City = string.Empty;
            CityDistrict = string.Empty;
            Street = string.Empty;
            HouseNumber = string.Empty;
            Building = string.Empty;
            RegistrationAuthority = string.Empty;
            InventoryNumber = string.Empty;
            CadastralNumber = string.Empty;
            RegistrationDate = string.Empty;

            LoadTitlePages(); // Перезагрузка списка после добавления нового титульного листа
        }

        /// <summary>
        /// Добавляет новый титульный лист.
        /// </summary>
        private void AddTitlePage()
        {
            // Логика для добавления нового титульного листа
            // Например, можно открыть диалоговое окно для ввода данных
            var newTitlePage = new TitlePage
            {
                PropertyType = "Квартира", // Пример данных
                Name = "Новая квартира",
                Address = "Улица Примерная, 1",
                FederalSubject = "Москва",
                AdministrativeDistrict = "Центральный",
                City = "Москва",
                CityDistrict = "Тверской",
                Street = "Примерная",
                HouseNumber = "1",
                Building = "",
                RegistrationAuthority = "Управление Росреестра",
                InventoryNumber = "123456",
                CadastralNumber = "77:01:0000001",
                RegistrationDate = "01.01.2023"
            };

            _repository.AddTitlePage(newTitlePage);
            LoadTitlePages(); // Перезагрузка списка после добавления
        }
    }
}
