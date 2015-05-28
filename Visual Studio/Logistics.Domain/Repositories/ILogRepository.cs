﻿using System;
using Logistics.Domain.Model;
using System.Collections.Generic;
using Logistics.Domain.Model.Entities.Log;

namespace Logistics.Domain.Repositories
{
	public interface ILogRepository
	{
		void Insert(Log log);

		void Delete(int id);

		void Update(Log log);

		Log Find(int id);

		IList<Log> FindAll();
	}
}

