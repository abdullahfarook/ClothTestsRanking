using Android.App;
using Android.OS;
using SemesterProject.Fragments;

using Android.Support.Design.Widget;
using Android.Support.V7.App;
using Android.Support.V7.Widget;
using Android.Views;
using FragmentManager = Android.Support.V4.App.FragmentManager;
using FragmentTransaction = Android.Support.V4.App.FragmentTransaction;

namespace SemesterProject
{
    [Activity(Label = "@string/app_name", MainLauncher = true, LaunchMode = Android.Content.PM.LaunchMode.SingleTop, Icon = "@drawable/icon")]
    public class MainActivity : AppCompatActivity
    {

        BottomNavigationView bottomNavigation;
        protected override void OnCreate(Bundle bundle)
        {

            base.OnCreate(bundle);
            // ActionBar.NavigationMode = ActionBarNavigationMode.Tabs;
            SetContentView(Resource.Layout.main);
            var toolbar = FindViewById<Android.Support.V7.Widget.Toolbar>(Resource.Id.toolbar);
            toolbar.Title = "Rating";
            if (toolbar != null)
            {
                SetSupportActionBar(toolbar);
                // SupportActionBar.SetHomeAsUpIndicator(Resource.Drawable.ic_search_white_24dp);
                SupportActionBar.SetDisplayHomeAsUpEnabled(false);
                SupportActionBar.SetHomeButtonEnabled(true);


            }

            //var mToolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            //mToolbar.Title = "Home";

            ////Toolbar will now take on default action bar chacracteritics
            //SetSupportActionBar(mToolbar);
            ////ActionBar.Title = "home";
            //this.ActionBar.SetDisplayShowHomeEnabled(true);


            //Enable suppport action bar to display hamburger
            //ActionBar.SetHomeAsUpIndicator(Resource.Drawable.icon_hambuger);
            //ActionBar.SetDisplayHomeAsUpEnabled (true);

            //Set menu hambuger


            //  ActionBar.SetDisplayHomeAsUpEnabled(true);

            bottomNavigation = FindViewById<BottomNavigationView>(Resource.Id.bottom_navigation);


            bottomNavigation.NavigationItemSelected += BottomNavigation_NavigationItemSelected;

            LoadFragment(Resource.Id.menu_list);
        }

        private void BottomNavigation_NavigationItemSelected(object sender, BottomNavigationView.NavigationItemSelectedEventArgs e)
        {
            LoadFragment(e.Item.ItemId);
        }

        void LoadFragment(int id)
        {
            Android.Support.V4.App.Fragment fragment = null;
            switch (id)
            {
                case Resource.Id.menu_list:
                    fragment = Fragment1.NewInstance();
                    break;
                case Resource.Id.menu_add:
                    fragment = Fragment2.NewInstance();
                    break;
                    //case Resource.Id.menu_video:
                    //    fragment = Fragment3.NewInstance();
                    //    break;
            }
            if (fragment == null)
                return;

            SupportFragmentManager.BeginTransaction()
               .Replace(Resource.Id.content_frame, fragment)
               .Commit();
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {

            return base.OnOptionsItemSelected(item);
        }

        public override void OnBackPressed()
        {
            var frag = new Fragment1();

            FragmentManager fg = this.SupportFragmentManager;
            FragmentTransaction ft = fg.BeginTransaction();
            ft.Replace(Resource.Id.content_frame, frag);
            // ft.SetTransition(FragmentTransaction.TransitFragmentFade);
            ft.Commit();
            // base.OnBackPressed();
        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.action_menu, menu);
            return true;
        }
    }
}

