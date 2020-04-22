﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rachel_SimpleMVVM.Framework
{
    /// <summary>
    /// This is the parent class which implements INotifyPropertyChanged event handler
    /// </summary>
    public abstract class ObservableObject : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// Raises the object's property changed event
        /// </summary>
        /// <param name="propertyName"></param>
        protected virtual void OnPropertyChanged(string propertyName)
        {
            this.VerifyPropertyName(propertyName);

            if(this.PropertyChanged !=null)
            {
                var e = new PropertyChangedEventArgs(propertyName);
                this.PropertyChanged(this, e);
            }
        }

        #region Debugging Aides
        /// <summary>
        ///  Warns the developer if this object does not have a public property with 
        ///  the specified name. This method does not exist in a Release Build
        /// </summary>
        /// <param name="propertyName"></param>
        [Conditional("DEBUG")]
        [DebuggerStepThrough]
        public virtual void VerifyPropertyName(string propertyName)
        {
            if(TypeDescriptor.GetProperties(this)[propertyName] == null)
            {
                string msg = "Invalid property name:" + propertyName;
                if (this.ThrowOnInvalidPropertyName)
                    throw new Exception(msg);
                else
                    Debug.Fail(msg);
            }
        }
        /// <summary>
        /// Returns whether an exception is thrown , or if Debug.Fail() is used when an
        /// invalid property name is passed  to the VerifyPropertyName() method.
        /// Default value is FALSE, but subclasses used by unit tests might override
        /// this property's getter to return true
        /// </summary>
        protected virtual bool ThrowOnInvalidPropertyName { get; private set; }
        
        #endregion // Debugging aides
    }
}