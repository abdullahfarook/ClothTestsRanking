using Android;
using Android.App;
using Android.OS;
using SemesterProject.Fragments;

using Android.Support.Design.Widget;
using Android.Support.V7.App;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;
using CheeseBind;
//using Com.Lilarcor.Cheeseknife;
using Shopping.DemoApp.Droid.Adapter.ViewHolders;

namespace SemesterProject
{
    public class SaleItemViewHolder : BaseViewHolder
    {
        [BindView(Resource.Id.displayName)]
        public TextView DisplayName { get; set; }

        [BindView(Resource.Id.description)]
        public TextView Description { get; set; }

        [BindView(Resource.Id.price)]
        public TextView Price { get; set; }

        [BindView(Resource.Id.priceCurrency)]
        public TextView PriceCurrency { get; set; }

        [BindView(Resource.Id.imgThumbnail)]
        public ImageView Thumbnail { get; set; }

        public SaleItemViewHolder(View itemView) : base(itemView)
        {
        }
    }
}