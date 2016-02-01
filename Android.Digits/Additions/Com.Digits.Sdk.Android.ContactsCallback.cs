using System;
using Com.Twitter.Sdk.Android.Core;

namespace Com.Digits.Sdk.Android
{
	public partial class ContactsCallback : Com.Twitter.Sdk.Android.Core.Callback
	{
		public override abstract void Success (Result p0);
		//{
			//_Success(p0);
	//	}

		public override abstract void Failure (TwitterException p0);
		//{
			//_Failure(p0);
		//}
	}
}

