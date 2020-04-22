using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rachel_SimpleMVVM.Model
{
    public class ProductModel : Framework.ObservableObject
    {
        #region Fields
        private int _productID;
        private string _productName;
        private decimal _unitPrice;
        #endregion // Fields

        #region Properties
        public int ProductId
        {
            get { return _productID; }
            set
            {
                if(value != _productID)
                {
                    _productID = value;
                    OnPropertyChanged("ProductId");
                }
            }
        }

        public string ProductName
        {
            get { return _productName; }
            set
            {
                if(value != _productName)
                {
                    _productName = value;
                    OnPropertyChanged("ProductName");
                }
            }
        }

        public decimal UnitPrice
        {
            get { return _unitPrice; }
            set
            {
                if (value != _unitPrice)
                {
                    _unitPrice = value;
                    OnPropertyChanged("UnitPrice");
                }
            }
        }
        #endregion // Properties
    }
}
