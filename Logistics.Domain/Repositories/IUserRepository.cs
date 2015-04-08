﻿using System;
using Logistics.Domain.Model;
using System.Collections.Generic;

namespace Logistics.Domain.Repositories
{
	public interface IUserRepository
	{
		void Insert(User user);

		void Delete(uint id);

		User Find(uint id);

		IList<User> FindAll();

		IList<User> FindAllWithRole (Role role);
	}
}
