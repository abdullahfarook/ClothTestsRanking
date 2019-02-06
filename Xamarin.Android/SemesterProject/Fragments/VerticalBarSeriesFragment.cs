
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V4.App;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;
using Com.Telerik.Widget.Chart.Visualization.CartesianChart;
using Com.Telerik.Widget.Chart.Visualization.CartesianChart.Series.Categorical;
using Com.Telerik.Widget.Chart.Visualization.CartesianChart.Axes;
using Java.Util;
using Com.Telerik.Widget.Chart.Engine.Databinding;
using Kohsaar.Model.DTO.Catalog;
using SemesterProject.Fragments;
using ServiceStack;
using ActionBar = Android.App.ActionBar;

namespace SemesterProject
{
    public class VerticalBarSeriesFragment : Android.Support.V4.App.Fragment, ExampleFragment
    {
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            ViewGroup rootView = (ViewGroup)inflater.Inflate(Resource.Layout.VerticalBarFragment, container, false);
            rootView.AddView(this.createChart());
            var appCompat = ((AppCompatActivity)Activity);

            // appCompat.SupportActionBar.SetHomeAsUpIndicator(Resource.Drawable.ic_search_white_24dp);
            appCompat.SupportActionBar.SetDisplayHomeAsUpEnabled(true);
            appCompat.SupportActionBar.SetHomeButtonEnabled(true);

            return rootView;


        }

        //public override bool OnOptionsItemSelected(IMenuItem item)
        //{
        //    var id = item.ItemId;
        //    if (id == Resource.Id.home)
        //    {

        //        var frag = new Fragment1();

        //        FragmentManager fg = this.Activity.SupportFragmentManager;
        //        FragmentTransaction ft = fg.BeginTransaction();
        //        ft.Replace(Resource.Id.content_frame, frag);
        //        ft.SetTransition(FragmentTransaction.TransitFragmentFade);
        //        ft.Commit();
        //    }
        //    return base.OnOptionsItemSelected(item);
        //}


        private RadCartesianChartView createChart()
        {
            //var client =  ServiceStack.JsonServiceClient("http://localhost:52303");
            // var client=  JsonServiceClient("http://localhost:52303");
            //var client = new JsonServiceClient("http://localhost:52303");
            //var res = client.Get(new GetTextileSample());
            //var d = res.Samples;


            //Create the Chart View
            RadCartesianChartView chart = new RadCartesianChartView(this.Activity);

            //Create the bar series and attach axes and value bindings.
            BarSeries barSeries = new BarSeries();

            barSeries.ValueBinding = new ValueBinding();
            barSeries.CategoryBinding = new CategoryBinding();

            LinearAxis verticalAxis = new LinearAxis();
            //The values in the linear axis will not have values after the decimal point.
            CategoricalAxis horizontalAxis = new CategoricalAxis();
            horizontalAxis.LabelFormat = "%.0f";
            barSeries.VerticalAxis = verticalAxis;
            barSeries.HorizontalAxis = horizontalAxis;

            //Bind series to data
            barSeries.Data = this.getData();

            //Add series to chart
            chart.Series.Add(barSeries);
            return chart;
        }

        private ArrayList getData()
        {
            //var client =  ServiceStack.JsonServiceClient("http://localhost:52303");
            // var client=  JsonServiceClient("http://localhost:52303");
            ArrayList result = new ArrayList();
            try
            {
                var client = new JsonServiceClient("http://192.168.0.100:52302");
                var res = client.Get(new GetTextileSample());
                var d = res.Samples;
                d.ForEach(item =>
                {
                    result.Add(new DataEntity()
                    {
                        category = item.Name,
                        value = (int)item.Value
                    });
                });
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Toast.MakeText(Context, "Connection Error", ToastLength.Short);
            }

            // Java.Util.Random numberGenerator = new Java.Util.Random();

            //result.Add(new DataEntity()
            //{
            //    category = "Single Goli",
            //    value = 9,
            //});
            //result.Add(new DataEntity()
            //{
            //    category = "Laraunce",
            //    value = 10,
            //});
            //result.Add(new DataEntity()
            //{
            //    category = "Double Goli",
            //    value = 7,
            //});
            //result.Add(new DataEntity()
            //{
            //    category = "Cone Die",
            //    value = 5,
            //});
            //result.Add(new DataEntity()
            //{
            //    category = "Hand Made",
            //    value = 5,
            //});
            //result.Add(new DataEntity()
            //{
            //    category = "Karandi",
            //    value = 3,
            //});
            //result.Add(new DataEntity()
            //{
            //    category = "Karandi",
            //    value = 3,
            //});
            //result.Add(new DataEntity()
            //{
            //    category = "Machine Hand",
            //    value = 1,
            //});



            //for (int i = 0; i < 8; i++)
            //{
            //    DataEntity entity = new DataEntity();
            //    entity.value = 7;
            //    entity.category = "Item " + i;
            //    result.Add(entity);
            //}

            return result;
        }

        public class CategoryBinding : DataPointBinding
        {
            public override Java.Lang.Object GetValue(Java.Lang.Object p0)
            {
                DataEntity entity = (DataEntity)p0;
                return entity.category;
            }

        }

        public class ValueBinding : DataPointBinding
        {
            public override Java.Lang.Object GetValue(Java.Lang.Object p0)
            {
                DataEntity entity = (DataEntity)p0;
                return entity.value;
            }

        }

        public String Title()
        {
            return "Vertical bar series";
        }

        public class DataEntity : Java.Lang.Object
        {
            public String category;
            public int value;
        }
    }
}

