package md5733f4bfad74919cb01bff2b086bf8a9e;


public class ProductView
	extends md5c293e307133ee8f46151deed2480c6a8.MvxActivity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("Droid.View.ProductView, Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", ProductView.class, __md_methods);
	}


	public ProductView () throws java.lang.Throwable
	{
		super ();
		if (getClass () == ProductView.class)
			mono.android.TypeManager.Activate ("Droid.View.ProductView, Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
