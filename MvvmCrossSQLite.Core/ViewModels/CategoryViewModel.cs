using System.Collections.Generic;
using MvvmCross.Core.ViewModels;
using MvvmCrossSQLite.Core.Models;
using MvvmCrossSQLite.Core.Services;
using SQLiteNetExtensions.Extensions;

namespace MvvmCrossSQLite.Core.ViewModels
{
    public class CategoryViewModel : MvxViewModel
    {
        private readonly IDBService _dBService;

        public CategoryViewModel(IDBService dBService)
        {
            _dBService = dBService;

            DoLoad();

            var category = _dBService.Load();

            if (category != null)
            {
                Products = _dBService.GetContext().GetWithChildren<Category>(category.Id, recursive: true).Products;
            }
        }

        private string _value;

        public string Value
        {
            get { return this._value; }
            set { this.RaiseAndSetIfChanged(ref this._value, value); }
        }

        public MvxCommand Save
        {
            get
            {
                return new MvxCommand(DoSave);
            }
        }

        public MvxCommand Load
        {
            get
            {
                return new MvxCommand(DoLoad);
            }
        }

        void DoSave()
        {
            _dBService.Save(new Category { Value = this.Value });
        }

        void DoLoad()
        {
            Value = _dBService.Load()?.Value ?? "no value";
        }

        private List<Product> _products;

        public List<Product> Products
        {
            get { return _products; }
            set { _products = value; RaisePropertyChanged(() => Products); }
        }


        public MvxCommand AddProductCommand => new MvxCommand(() => ShowViewModel<ProductViewModel>(new Parameters() { Key = _dBService.Load().Id.ToString() }));




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
            
        }

        public class Parameters
        {
            public string Key { get; set; }
        }




    }
}
