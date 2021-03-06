﻿using System;
using Microsoft.Practices.EnterpriseLibrary.Validation.Validators;

namespace Logistics.Domain.Model.Entities.Log
{
	public class Log
	{
		public virtual int Id { get; protected set; }

		[NotNullValidator]    
		[StringLengthValidator(10, 100)]    
		public virtual String Value { get; set; }

		[NotNullValidator]
		public virtual DateTime CreatedAt { get; set; }

		[NotNullValidator]    
		public virtual User.User User { get; set; }
	}
}

