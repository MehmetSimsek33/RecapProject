﻿using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
        List<Car> GetAllByBrand(int brandId);
        List<Car> GetAllColor(int colorId);
        Car GetById(int id);
        void add(Car car);
        void delete(Car car);
        void update(Car car);
    }
}