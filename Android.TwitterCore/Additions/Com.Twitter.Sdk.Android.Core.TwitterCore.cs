using Android.Runtime;
using System;

namespace Com.Twitter.Sdk.Android.Core
{
	public partial class TwitterCore : global::IO.Fabric.Sdk.Android.Kit
	{
		public override int CompareTo(global::Java.Lang.Object p0)
		{
			return CompareTo ((Com.Twitter.Sdk.Android.Core.TwitterCore) p0);
		}
	}
}

namespace Com.Twitter.Sdk.Android.Core.Services {
/*
	// Metadata.xml XPath interface reference: path="/api/package[@name='com.twitter.sdk.android.core.services']/interface[@name='ConfigurationService']"
	//[Register ("com/twitter/sdk/android/core/services/ConfigurationService", "", "Com.Twitter.Sdk.Android.Core.Services.IConfigurationServiceInvoker")]
	public partial interface IConfigurationService : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.twitter.sdk.android.core.services']/interface[@name='ConfigurationService']/method[@name='configuration' and count(parameter)=1 and parameter[1][@type='com.twitter.sdk.android.core.Callback&lt;com.twitter.sdk.android.core.models.Configuration&gt;']]"
		[Register ("configuration", "(Lcom/twitter/sdk/android/core/Callback;)V", "GetConfiguration_Lcom_twitter_sdk_android_core_Callback_Handler:Com.Twitter.Sdk.Android.Core.Services.IConfigurationServiceInvoker, Android.TwitterCore")]
		void Configuration (global::Com.Twitter.Sdk.Android.Core.Callback p0);

	}

	[global::Android.Runtime.Register ("com/twitter/sdk/android/core/services/ConfigurationService", DoNotGenerateAcw=true)]
	internal partial class IConfigurationServiceInvoker : global::Java.Lang.Object, IConfigurationService {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/twitter/sdk/android/core/services/ConfigurationService");
		IntPtr class_ref;

		public static IConfigurationService GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IConfigurationService> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.twitter.sdk.android.core.services.ConfigurationService"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IConfigurationServiceInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IConfigurationServiceInvoker); }
		}

		static Delegate cb_configuration_Lcom_twitter_sdk_android_core_Callback_;
#pragma warning disable 0169
		static Delegate GetConfiguration_Lcom_twitter_sdk_android_core_Callback_Handler ()
		{
			if (cb_configuration_Lcom_twitter_sdk_android_core_Callback_ == null)
				cb_configuration_Lcom_twitter_sdk_android_core_Callback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Configuration_Lcom_twitter_sdk_android_core_Callback_);
			return cb_configuration_Lcom_twitter_sdk_android_core_Callback_;
		}

		static void n_Configuration_Lcom_twitter_sdk_android_core_Callback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Twitter.Sdk.Android.Core.Services.IConfigurationService __this = global::Java.Lang.Object.GetObject<global::Com.Twitter.Sdk.Android.Core.Services.IConfigurationService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Twitter.Sdk.Android.Core.Callback p0 = global::Java.Lang.Object.GetObject<global::Com.Twitter.Sdk.Android.Core.Callback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Configuration (p0);
		}
#pragma warning restore 0169

		IntPtr id_configuration_Lcom_twitter_sdk_android_core_Callback_;
		public unsafe void Configuration (global::Com.Twitter.Sdk.Android.Core.Callback p0)
		{
			int blah = 5;
			if (id_configuration_Lcom_twitter_sdk_android_core_Callback_ == IntPtr.Zero)
				id_configuration_Lcom_twitter_sdk_android_core_Callback_ = JNIEnv.GetMethodID (java_class_ref, "configuration", "(Lcom/twitter/sdk/android/core/Callback;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (Handle, id_configuration_Lcom_twitter_sdk_android_core_Callback_, __args);
		}

	}
*/
}
/*
namespace Com.Twitter.Sdk.Android.Core.Services
{
	public partial interface IConfigurationService : Android.Runtime.IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.twitter.sdk.android.core.services']/interface[@name='ConfigurationService']/method[@name='configuration' and count(parameter)=1 and parameter[1][@type='com.twitter.sdk.android.core.Callback&lt;com.twitter.sdk.android.core.models.Configuration&gt;']]"
		[Register ("configuration", "(Lcom/twitter/sdk/android/core/Callback;)V", "GetConfiguration_Lcom_twitter_sdk_android_core_Callback_Handler:Com.Twitter.Sdk.Android.Core.Services.IConfigurationServiceInvoker, Android.TwitterCore")]
		public void Configuration (global::Com.Twitter.Sdk.Android.Core.Callback p0)
		{
			if (id_configuration_Lcom_twitter_sdk_android_core_Callback_ == IntPtr.Zero)
				id_configuration_Lcom_twitter_sdk_android_core_Callback_ = JNIEnv.GetMethodID (class_ref, "configuration", "(Lcom/twitter/sdk/android/core/Callback;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (Handle, id_configuration_Lcom_twitter_sdk_android_core_Callback_, __args);
		}
	}

}*/