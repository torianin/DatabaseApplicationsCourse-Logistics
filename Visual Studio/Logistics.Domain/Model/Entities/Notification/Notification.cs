﻿using Microsoft.Practices.EnterpriseLibrary.Validation.Validators;

namespace Logistics.Domain.Model.Entities.Notification
{
	[HasSelfValidation]
	public class Notification
	{
		public virtual int Id { get; protected set; }
		public virtual string ShortValue { 
			set { ; }
			get { return FullValue.Substring(0, FullValue.IndexOf(".")); }
		}

		[NotNullValidator]    
		[StringLengthValidator(10, 100)]   
		public virtual string FullValue { get; set; }

		[NotNullValidator]    
		public virtual Order.Order Order { get; set; }

		[NotNullValidator]
		public virtual User.User User { get; set; } 

		[NotNullValidator]
		public virtual NotificationType NotificationType { get; set; }

	}
}
