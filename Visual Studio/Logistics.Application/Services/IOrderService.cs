﻿using System;
using Logistics.Domain.Model;
using System.Collections.Generic;
using Logistics.Domain.Model.Entities.Order;

namespace Logistics.Application.Services
{
	public interface IOrderService
	{
		Order CreateOrder(Address adress, Payment payment, int Priority);
		void DeleteOrder(Order order);
		Order GetOrder(int id);
		IList<Order> GetAllOrders();
	}
}

