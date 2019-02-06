using System;
using System.Collections.Generic;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Support.V4.App;
using Android.Support.V4.Content;
using Android.Support.V7.Widget;
using Android.Views;
using CheeseBind;
using Shopping.DemoApp.Models;

namespace SemesterProject.Fragments
{
    public class Fragment1 : Fragment
    {
        // [BindView(Resource.Id.recyclerGridView)]
        protected RecyclerView recyclerView;
        private List<SaleItem> saleItems = new List<SaleItem>();
        private SaleRecyclerAdapter saleRecyclerAdapter;
        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            var items = new List<SaleItem>()
                   {
                       new SaleItem()
                       {
                           Id = "1",
                           CreatedAt = new DateTimeOffset(DateTime.Now),
                           Name = "Sample",
                           Description ="Theses are results of sample 1",
                           Price=1,
                           ImageUrl= "https://cnet1.cbsistatic.com/img/8A2v6HBrQ8dkYfiHVtL6Vl2tLxY=/770x433/2017/04/18/ca9d345f-d5db-4a89-8735-33174cb91a9b/fls8.jpg"
                       },
                       new SaleItem()
                       {
                           Id = "2",
                           CreatedAt = new DateTimeOffset(DateTime.Now),
                           Name = "Khadder",
                           Description ="Theses are Tests of Khadder",
                           Price=2,
                           ImageUrl= "https://cnet1.cbsistatic.com/img/8A2v6HBrQ8dkYfiHVtL6Vl2tLxY=/770x433/2017/04/18/ca9d345f-d5db-4a89-8735-33174cb91a9b/fls8.jpg"
                       },
                       new SaleItem()
                       {
                           Id = "3",
                           CreatedAt = new DateTimeOffset(DateTime.Now),
                           Name = "Sample",
                           Description ="Results of Sample 3",
                           Price=3,
                           ImageUrl= "https://cnet1.cbsistatic.com/img/8A2v6HBrQ8dkYfiHVtL6Vl2tLxY=/770x433/2017/04/18/ca9d345f-d5db-4a89-8735-33174cb91a9b/fls8.jpg"
                       }
                   };
            this.saleItems.Clear();
            this.saleItems.AddRange(items);
            var dummyItemPosition = this.saleItems.Count == 0 ? 0 : 1;
            this.saleItems.Insert(dummyItemPosition, default(SaleItem));

            // this.saleRecyclerAdapter.NotifyDataSetChanged();

            // Create your fragment here
        }
        private void SetupUiElements()
        {
            this.saleRecyclerAdapter = new SaleRecyclerAdapter(
                 this.Context,
                 this.saleItems,
                 (v, i) =>
                 {
                     //var currentSaleItem = this.saleItems[i];
                     //var itemJson = JsonConvert.SerializeObject(currentSaleItem);

                     //var detailIntent = new Intent(this, typeof(DetailSaleItemActivity));
                     //detailIntent.PutExtra("Item", itemJson);

                     //StartActivity(detailIntent);
                     var frag = new VerticalBarSeriesFragment();

                     FragmentManager fg = this.Activity.SupportFragmentManager;
                     FragmentTransaction ft = fg.BeginTransaction();
                     ft.Replace(Resource.Id.content_frame, frag);
                     ft.SetTransition(FragmentTransaction.TransitFragmentFade);
                     ft.Commit();
                 },
                 async (v, i) =>
                 {
                     // StartActivityForResult(typeof(SellActivity), 0);
                     //await AuthenticationService.Instance.RequestLoginIfNecessary();

                     //if (AuthenticationService.Instance.UserIsAuthenticated)
                     //{

                     //}
                 }
             );

            var sglm = new StaggeredGridLayoutManager(2, StaggeredGridLayoutManager.Vertical);
            this.recyclerView.SetLayoutManager(sglm);
            this.recyclerView.SetItemAnimator(null);
            this.recyclerView.SetAdapter(this.saleRecyclerAdapter);

            var color = new Color(ContextCompat.GetColor(this.Context, Resource.Color.grey));
            this.recyclerView.SetBackgroundColor(color);
        }

        public static Fragment1 NewInstance()
        {
            var frag1 = new Fragment1 { Arguments = new Bundle() };
            return frag1;
        }


        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {

            // recyclerView =<RecyclerView>(Resource.Id.recyclerGridView);
            var view = inflater.Inflate(Resource.Layout.fragment1, null);
            recyclerView = view.FindViewById<RecyclerView>(Resource.Id.recyclerGridView);
            SetupUiElements();
            //base.OnCreateView(inflater, container, savedInstanceState);
            return view;
        }
    }
}