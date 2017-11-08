﻿using System;

using GalaSoft.MvvmLight;

using eShop.UWP.Data;

namespace eShop.UWP.Models
{
    public class CatalogBrandModel : ObservableObject
    {
        public CatalogBrandModel()
        {
            Id = 0;
            Name = "";
        }
        public CatalogBrandModel(CatalogBrand source)
        {
            Id = source.Id;
            Name = source.Brand;
        }

        public int Id { get; set; }

        private string _name;
        public string Name
        {
            get { return _name; }
            set { Set(ref _name, value); }
        }
    }
}
