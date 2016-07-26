using System;
using System.Collections.Generic;
using Microsoft.VisualBasic.CompilerServices;
using MvvmCross.Core.ViewModels;
using MvvmCrossSQLite.Core.Models;
using MvvmCrossSQLite.Core.Services;
using SQLiteNetExtensions.Extensions;

namespace MvvmCrossSQLite.Core.ViewModels
{
    public class ProductViewModel : MvxViewModel
    {
        private readonly IDBService _dBService;

        public ProductViewModel(IDBService dBService)
        {
            this._dBService = dBService;
        }


        private Product _newProduct;

        public Product NewProduct
        {
            get { return _newProduct; }
            set { _newProduct = value; RaisePropertyChanged(() => NewProduct); }
        }


        private string _title;

        public string Title
        {
            get { return _title; }
            set { _title = value; RaisePropertyChanged(() => Title); }
        }


        public MvxCommand AddNewProductCommand => new MvxCommand(AddNewProduct);

        private void AddNewProduct()
        {
            var fafas = Key;
            var category = _dBService.GetContext().GetWithChildren<Category>(int.Parse(Key),recursive:true);//_dBService.GetContext().Get<Category>(int.Parse(Key));
            NewProduct = new Product();
            NewProduct.Name = Title;
            NewProduct.Category = category;
            NewProduct.CategoryId = int.Parse(Key);
            _dBService.GetContext().Insert(NewProduct);
            
            if (category.Products == null)
            {
                category.Products = new List<Product> { NewProduct };
            }
            else
            {
                category.Products.Add(NewProduct);
            }
            
            //_dBService.GetContext().InsertWithChildren(category);
            _dBService.GetContext().Update(category);
            var storecategory = _dBService.GetContext().GetWithChildren<Category>(int.Parse(Key), recursive: true);

            ShowViewModel<CategoryViewModel>();
        }


        public string _key;

        public string Key
        {
            get { return _key; }
            set
            {
                _key = value;
                RaisePropertyChanged(() => Key);
            }
        }

        public void Init(Parameters parameters)
        {
            Key = parameters.Key;
        }

        public class Parameters
        {
            public string Key { get; set; }
        }
    }
}
