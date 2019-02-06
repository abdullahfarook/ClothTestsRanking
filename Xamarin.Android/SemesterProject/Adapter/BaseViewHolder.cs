using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Support.V7.Widget;
using CheeseBind;


namespace Shopping.DemoApp.Droid.Adapter.ViewHolders
{
    public class BaseViewHolder : RecyclerView.ViewHolder
    {
        public BaseViewHolder(View itemView) : base(itemView)
        {
            Cheeseknife.Bind(this, itemView);
        }
    }
}