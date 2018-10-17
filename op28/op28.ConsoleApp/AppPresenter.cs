using op28.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Text;

namespace op28.ConsoleApp {
    public abstract class AppPresenter<T> : IAppPresenter
        where T : IApp {
        public AppPresenter(Phone phone) {
            Phone = phone;
            App = Phone.AppDrawer.Find<T>();
            Name = App.Name;
        }
        public string Name { get; set; }
        public Phone Phone { get; }
        public T App { get; }

        public abstract void Start();
    }
}
