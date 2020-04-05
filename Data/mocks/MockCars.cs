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
                        longDesc = "Ключевым в философии byfly стало слово «легко». Однако рождение новой марки было отнюдь не легким. Появлению byfly на свет предшествовали 330 дней и ночей упорного труда, напряженной мысли и горячих споров целой команды ее разработчиков.Идея создать торговую марку возникла осенью 2005 года. Вначале специалисты «Белтелеком» изучили рынок Интернет-услуг Беларуси. Оценили плюсы и минусы конкурентов. Это помогло выявить преимущества наших услуг для клиентов.",
                        img = "https://www.google.com/search?q=byfly+%D1%8D%D1%82%D0%BE&source=lnms&tbm=isch&sa=X&ved=2ahUKEwiE6IbXktLoAhWJuIsKHcRpA9gQ_AUoAXoECBcQAw&biw=1920&bih=937#imgrc=jt_p1OMIXNvZ2M",
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
                        img= "https://www.google.com/search?q=zala&tbm=isch&ved=2ahUKEwiixMLmktLoAhWbfpoKHRafBW0Q2-cCegQIABAA&oq=zala&gs_lcp=CgNpbWcQAzICCAAyAggAMgIIADICCAAyAggAMgIIADICCAAyAggAMgIIADICCAA6BQgAEIMBOgYIABAKEAFQhWBYtGxg0m9oAHAAeACAAU-IAakCkgEBNJgBAKABAaoBC2d3cy13aXotaW1nsAEA&sclient=img&ei=eUKKXuKjF5v96QSWvpboBg&bih=937&biw=1920#imgrc=8GSE-oSdfKyNrM",
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
                        img= "https://www.google.com/search?q=%D1%8F%D1%81%D0%BD%D0%B0&tbm=isch&ved=2ahUKEwjNkpbuktLoAhUVzyoKHWKPBbcQ2-cCegQIABAA&oq=%D1%8F%D1%81%D0%BD%D0%B0&gs_lcp=CgNpbWcQAzICCAAyAggAMgIIADICCAAyAggAMgIIADICCAAyAggAMgIIADICCAA6BQgAEIMBUNeJAVjMlAFgi5YBaABwAHgAgAFGiAGUApIBATSYAQCgAQGqAQtnd3Mtd2l6LWltZ7ABAA&sclient=img&ei=iUKKXo2qGpWeqwHinpa4Cw&bih=937&biw=1920#imgrc=1h3ASrY408ZyqM",
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
