﻿using InternetProvider.Data.Interfaces;
using InternetProvider.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InternetProvider.Data.mocks
{
    public class MockCategory : ICarsCategory
    {
        public IEnumerable<Category> AllCategories {
            get
            {
                return new List<Category>
                {
                    new Category {categoryName = "Элеткромобили", desc = "Современный вид транспорта" },
                    new Category {categoryName= "Классические автомобили", desc= "Машины с двигателем внутреннего сгорания" }
                };
            }
        }
    }
}
