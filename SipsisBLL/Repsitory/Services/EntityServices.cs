using SipsisBLL.Repsitory.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SipsisBLL.Repsitory.Services
{
    public class EntityServices
    {
        public EntityServices()
        {
            _userServices = new UserRepository();
            _orderServices = new OrderRepository();
            _marketServices = new MarketRepository();
            _orderstatusServices = new OrderStatusRepository();
            _customerServices = new CustomerRepository();
            _cargoServices = new CargoRepository(); 
        }

        private UserRepository _userServices;

        public UserRepository UserServices
        {
            get { return _userServices; }
            set { _userServices = value; }
        }

        private OrderRepository _orderServices;

        public UserRepository OrderServices
        {
            get { return _userServices; }
            set { _userServices = value; }
        }

        private MarketRepository _marketServices;

        public MarketRepository MarketServices
        {
            get { return _marketServices; }
            set { _marketServices = value; }
        }

        private OrderStatusRepository _orderstatusServices;

        public OrderStatusRepository OrderstatusServices
        {
            get { return _orderstatusServices; }
            set { _orderstatusServices = value; }
        }

        private CustomerRepository _customerServices;

        public CustomerRepository CustomerServices
        {
            get { return _customerServices; }
            set { _customerServices = value; }
        }

        private CargoRepository _cargoServices;

        public CargoRepository CargoServices
        {
            get { return _cargoServices; }
            set { _cargoServices = value; }
        }



    }
}
