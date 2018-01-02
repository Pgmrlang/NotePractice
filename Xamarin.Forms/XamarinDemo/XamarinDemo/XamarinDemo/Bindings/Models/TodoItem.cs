﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace XamarinDemo.Bindings.Models
{
    public class TodoItem : INotifyPropertyChanged
    {
        private string name;
        public string Name
        {
            get { return name; }
            set
            {
                if (value.Equals(name, StringComparison.Ordinal))
                {
                    // Nothing to do - the value hasn't changed;
                    return;
                }
                name = value;
                OnPropertyChanged();

            }
        }

        public int Count { get; set; }
        public string Item { get; set; }
        public bool Done { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
