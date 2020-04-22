using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Rachel_SimpleMVVM.Model;
using Rachel_SimpleMVVM.Framework;


namespace Rachel_SimpleMVVM.VM
{
    public class ProductVM : Framework.ObservableObject 
    {
        #region Fields
        private int _productID;
        private Model.ProductModel _currentProduct;
        private ICommand _getProductCommand;
        private ICommand _saveProductCommand;
        #endregion // Fields

        #region Public Properties/Commands

        public ProductModel CurrentProduct
        {
            get { return _currentProduct; }
            set
            {
                if(value != _currentProduct)
                {
                    _currentProduct = value;
                    OnPropertyChanged("CurrentProduct");
                }
            }
        }

        public int ProductID
        {
            get { return _productID; }
            set
            {
                if(value != _productID)
                {
                    _productID = value;
                    OnPropertyChanged("ProductID");
                }
            }
        }
        public ICommand GetProductCommand 
        {
            get
            {
                if(_getProductCommand == null)
                {
                    _getProductCommand = new RelayCommand(
                        param => GetProduct(),
                        param => _productID > 0
                        );
                }
                return _getProductCommand;
            }
        }
        public ICommand SaveProductCommand
        {
            get
            {
                if(_saveProductCommand == null)
                {
                    _saveProductCommand = new RelayCommand(
                        param => SaveProduct(),
                        ParamArrayAttribute =>(CurrentProduct != null)
                        );
                }
                return _saveProductCommand;

            }
        }
        #endregion // Public Properties/Commands

        #region Private Helpers

        private void GetProduct()
        {
            // You should get yteh products from DB. for now hard coded#
            ProductModel p = new ProductModel();
            p.ProductId = _productID;
            p.ProductName = "Test Product";
            p.UnitPrice = 10.00M;
            CurrentProduct = p;
        }
        private void SaveProduct()
        {
        }

        #endregion // Private Helpers
    }
}
