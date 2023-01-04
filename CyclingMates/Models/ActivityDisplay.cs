using System;
using CyclingMates.Areas.Identity.Data;
using Microsoft.Extensions.Options;

namespace CyclingMates.Models
{
	public class ActivityDisplay : Activity
	{
        public CyclingMatesUser Author;

		public ActivityDisplay(Activity activity, CyclingMatesUser auth) : base(activity)
        {
			
			Author = auth;
		}
	}
}

