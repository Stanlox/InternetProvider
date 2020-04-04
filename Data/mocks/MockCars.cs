using InternetProvider.Data.Interfaces;
using InternetProvider.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InternetProvider.Data.mocks
{
    public class MockCars : IAllCars
    {
        private readonly ICarsCategory _categoryCars = new MockCategory();
        public IEnumerable<Car> Cars
        {
            get
            {
                return new List<Car> {
                    new Car {
                        name = "Byfly",
                        shortDesc = "Test length",
                        longDesc = "",
                        img = "",
                        price = 43534,
                        isFavourite = true,
                        available = true,
                        Category = _categoryCars.AllCategories.First()
                    },
                    new Car
                    {
                        name ="Zala",
                        shortDesc ="Телевидение ZALA — это современный способ доступа к различным телеканалам, обеспечивающий высокое качество телевизионного сигнала.",
                        longDesc="Преимущества ZALA:- Телеканалы различной тематики.Вашему вниманию представлены телеканалы на любой вкус и возраст, которые удовлетворят любые, даже самые требовательные запросы! Спорт, музыка, новости, программы о моде и красоте, лучшие фильмы всех жанров, детские передачи – это только часть программ, которые могут увидеть наши абоненты!- Экономичность.Для подключения услуг ZALA не требуется приобретение дорогостоящего оборудования (необходимое оборудование выдается на время действия договора).- Дополнительные возможности.Дополнительные тематические пакеты, дополнительные сервисы - набор сервисов зависит от технологии подключения услуг телевидения.- Техническая поддержка.Абоненты ZALA всегда могут получить квалифицированную техническую помощь наших специалистов по настройке оборудования и другим техническим вопросам, касающимся предоставления услуг ZALA, позвонив по тел.123.- Кабинет пользователя.В личном кабинете пользователя, абоненты ZALA могут управлять услугами (заказывать дополнительные, менять тарифные планы и т.д.), не выходя из дома.",
                        img= "",
                        price = 2344,
                        isFavourite =true,
                        available = true,
                        Category =_categoryCars.AllCategories.Last()
                    },
                    new Car
                    {
                        name ="ЯСНА",
                        shortDesc ="Test length",
                        longDesc="Белтелеком ЯСНА — это бренд, в рамках которого абонентам предложены различные наборы из нескольких услуг, необходимые современному человеку для комфорта и полноценного общения. В рамках бренда физическим лицам оказываются наиболее востребованные услуги на базе сети абонентского доступа по технологии GPON (пассивные оптические сети). С использованием данной технологии абонентам доступно подключение к сети Интернет на скорости до 100 Мбит/с, современные услуги телевидения и другие сервисы, требующие высокой пропускной способности.",
                        img= "",
                        price = 2344,
                        isFavourite =true,
                        available = true,
                        Category =_categoryCars.AllCategories.Last()
                    }
            };
          }
        }
        public IEnumerable<Car> getFavCars { get; set; }

        public Car getobjectCar(int carId)
        {
            throw new NotImplementedException();
        }
    }
}
