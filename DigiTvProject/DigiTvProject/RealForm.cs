﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace DigiTvProject
{
    public partial class RealForm : Form
    {
        public RealForm()
        {
            InitializeComponent();
        }

        private void RealForm_Load(object sender, EventArgs e)
        {
            label_timer_device.Text = "00:04:10";
            label_month_device.Text = "2,738,386";

            label_week_device.Text = "1,149,080";

            label_no_device.Text = "0";
            label_al_device.Text = "25,004,607";

            initChartNewDevice();
            initChartStartCountDevice(); initMonthChart();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void initChartNewDevice() {
            List<string> xData = new List<string>() { "00:00", "01:00", "02:00", "03:00", "04:00", "05:00", "06:00", "07:00", "08:00", "09:00", "10:00", "11:00", "12:00", "13:00", "14:00", "15:00", "16:00", "17:00", "18:00", "19:00", "20:00", "21:00", "22:00", "23:00" };
            List<int> y1Data = new List<int>() { 256, 187, 35, 54, 15, 18, 5, 40, 89, 156, 215, 236, 257, 246, 268, 238, 298, 305, 359, 446, 406, 398, 456,400 };
            List<int> y2Data = new List<int>() { 240, 165, 40, 68, 19, 22, 3, 20, 79, 186, 226, 247, 257, 246, 268, 238, 298, 305, 359, 446, 406, 398, 456, 400 };

            Series s1 = new Series();
            Series s2 = new Series();

            chart_new_device.Series.Add(s1);
            chart_new_device.Series.Add(s2);

            chart_new_device.Series[0].ChartType = SeriesChartType.Line;
            chart_new_device.Series[0].LegendText = "今日新增";
            //线条颜色
            chart_new_device.Series[0].Color = Color.Green;
            //线条粗细
            chart_new_device.Series[0].BorderWidth = 1;
            //标记点边框颜色      
            chart_new_device.Series[0].MarkerBorderColor = Color.Black;
            //标记点边框大小
            chart_new_device.Series[0].MarkerBorderWidth = 3;
            //标记点中心颜色
            chart_new_device.Series[0].MarkerColor = Color.Red;
            //标记点大小
            chart_new_device.Series[0].MarkerSize = 8;
            chart_new_device.Series[0].MarkerStyle = MarkerStyle.Circle; 
            chart_new_device.Series[0].Points.DataBindXY(xData, y1Data);


            //线条颜色
            chart_new_device.Series[1].ChartType = SeriesChartType.Line; 
            chart_new_device.Series[1].Color = Color.Green;
            chart_new_device.Series[1].LegendText = "昨日新增";
            //线条粗细
            chart_new_device.Series[1].BorderWidth = 1;
            //标记点边框颜色      
            chart_new_device.Series[1].MarkerBorderColor = Color.Black;
            //标记点边框大小
            chart_new_device.Series[1].MarkerBorderWidth = 3;
            //标记点中心颜色
            chart_new_device.Series[1].MarkerColor = Color.Red;
            //标记点大小
            chart_new_device.Series[1].MarkerSize = 8;
            chart_new_device.Series[1].Points.DataBindXY(xData, y2Data);


        }
        private void initChartStartCountDevice() {
            List<string> xData = new List<string>() { "00:00", "01:00", "02:00", "03:00", "04:00", "05:00", "06:00", "07:00", "08:00", "09:00", "10:00", "11:00", "12:00", "13:00", "14:00", "15:00", "16:00", "17:00", "18:00", "19:00", "20:00", "21:00", "22:00", "23:00" };
            List<int> y1Data = new List<int>() { 256, 187, 35, 54, 15, 18, 5, 40, 89, 156, 215, 236, 257, 246, 268, 238, 298, 305, 359, 446, 406, 398, 456, 400 };
            List<int> y2Data = new List<int>() { 240, 165, 40, 68, 19, 22, 3, 20, 79, 186, 226, 247, 257, 246, 268, 238, 298, 305, 359, 446, 406, 398, 456, 400 };

            Series s1 = new Series();
            Series s2 = new Series();

            chart_start_count.Series.Add(s1);
            chart_start_count.Series.Add(s2);

            chart_start_count.Series[0].ChartType = SeriesChartType.Line;
            //线条颜色
            chart_start_count.Series[0].Color = Color.Green;
            //线条粗细
            chart_start_count.Series[0].BorderWidth = 1;
            chart_start_count.Series[0].LegendText = "今日启动";

            //标记点边框颜色      
            chart_start_count.Series[0].MarkerBorderColor = Color.Black;
            //标记点边框大小
            chart_start_count.Series[0].MarkerBorderWidth = 3;
            //标记点中心颜色
            chart_start_count.Series[0].MarkerColor = Color.Red;
            //标记点大小
            chart_start_count.Series[0].MarkerSize = 8;
            chart_start_count.Series[0].MarkerStyle = MarkerStyle.Circle;
            chart_start_count.Series[0].Points.DataBindXY(xData, y1Data);


            //线条颜色
            chart_start_count.Series[1].ChartType = SeriesChartType.Line;
            chart_start_count.Series[1].Color = Color.Green;
            chart_start_count.Series[1].LegendText = "昨日启动";

            //线条粗细
            chart_start_count.Series[1].BorderWidth = 1;
            //标记点边框颜色      
            chart_start_count.Series[1].MarkerBorderColor = Color.Black;
            //标记点边框大小
            chart_start_count.Series[1].MarkerBorderWidth = 3;
            //标记点中心颜色
            chart_start_count.Series[1].MarkerColor = Color.Red;
            //标记点大小
            chart_start_count.Series[1].MarkerSize = 8;
            chart_start_count.Series[1].Points.DataBindXY(xData, y2Data);
        }

        private void initMonthChart()
        {

            List<string> xData = new List<string>();
            List<int> y1Data = new List<int>();
            List<int> y2Data = new List<int>();
            List<int> y3Data = new List<int>();
            List<int> y4Data = new List<int>();


            DateTime dt = DateTime.Now;  //当前时间  
            DateTime startMonth = dt.AddDays(1 - dt.Day);  //本月月初  
            DateTime endMonth = startMonth.AddMonths(1).AddDays(-1);  //本月月末  
            int i = 1;
            for (DateTime d = startMonth; d <= endMonth; d = d.AddDays(1)) {
                i++;
                String dateStr = d.ToString("yyyy-MM-dd");
                xData.Add(dateStr);
                int y1 = getRandomValue( 150, 200);
                int y2 = getRandomValue( 30, 60);
                int y3 = getRandomValue(1000, 1200);
                int y4 = getRandomValue(100, 300);

                y1Data.Add(y1);
                y2Data.Add(y2);
                y3Data.Add(y3);
                y4Data.Add(y4);
            }

            Series s1 = new Series();
            Series s2 = new Series();

            chart30_new.Series.Add(s1);
            chart30_new.Series.Add(s2);

            chart30_new.Series[0].ChartType = SeriesChartType.Line;
            chart30_new.Series[0].LegendText = "新增设备";
            //线条颜色
            chart30_new.Series[0].Color = Color.Green;
            //线条粗细
            chart30_new.Series[0].BorderWidth = 1;
            //标记点边框颜色      
            chart30_new.Series[0].MarkerBorderColor = Color.Black;
            //标记点边框大小
            chart30_new.Series[0].MarkerBorderWidth = 3;
            //标记点中心颜色
            chart30_new.Series[0].MarkerColor = Color.Red;
            //标记点大小
            chart30_new.Series[0].MarkerSize = 8;
            chart30_new.Series[0].MarkerStyle = MarkerStyle.Circle;
            chart30_new.Series[0].Points.DataBindXY(xData, y1Data);


            //线条颜色
            chart30_new.Series[1].ChartType = SeriesChartType.Line;
            chart30_new.Series[1].Color = Color.Green;
            chart30_new.Series[1].LegendText = "新增观看用户";
            //线条粗细
            chart30_new.Series[1].BorderWidth = 1;
            //标记点边框颜色      
            chart30_new.Series[1].MarkerBorderColor = Color.Black;
            //标记点边框大小
            chart30_new.Series[1].MarkerBorderWidth = 3;
            //标记点中心颜色
            chart30_new.Series[1].MarkerColor = Color.Red;
            //标记点大小
            chart30_new.Series[1].MarkerSize = 8;
            chart30_new.Series[1].Points.DataBindXY(xData, y2Data);


            Series s3 = new Series();
            chart30_start.Series.Add(s3);

            chart30_start.Series[0].ChartType = SeriesChartType.Line;
            chart30_start.Series[0].Color = Color.Green;
            chart30_start.Series[0].LegendText = "启动次数";
            //线条粗细
            chart30_start.Series[0].BorderWidth = 1;
            //标记点边框颜色      
            chart30_start.Series[0].MarkerBorderColor = Color.Black;
            //标记点边框大小
            chart30_start.Series[0].MarkerBorderWidth = 3;
            //标记点中心颜色
            chart30_start.Series[0].MarkerColor = Color.Red;
            chart30_start.Series[0].MarkerStyle = MarkerStyle.Circle;

            //标记点大小
            chart30_start.Series[0].MarkerSize = 8;
            chart30_start.Series[0].Points.DataBindXY(xData, y3Data);


            Series s4 = new Series();
            chart30_time.Series.Add(s4);

            chart30_time.Series[0].ChartType = SeriesChartType.Line;
            chart30_time.Series[0].Color = Color.Green;
            chart30_time.Series[0].LegendText = "单次观看时长";
            //线条粗细
            chart30_time.Series[0].BorderWidth = 1;
            //标记点边框颜色      
            chart30_time.Series[0].MarkerBorderColor = Color.Black;
            //标记点边框大小
            chart30_time.Series[0].MarkerBorderWidth = 3;
            //标记点中心颜色
            chart30_time.Series[0].MarkerColor = Color.Red;
            chart30_time.Series[0].MarkerStyle = MarkerStyle.Circle;
            //标记点大小
            chart30_time.Series[0].MarkerSize = 8;
            chart30_time.Series[0].Points.DataBindXY(xData, y4Data);
        }

        private int getRandomValue(int start, int end) {
            byte[] bytes = new byte[4];
            System.Security.Cryptography.RNGCryptoServiceProvider rng = new System.Security.Cryptography.RNGCryptoServiceProvider();
            rng.GetBytes(bytes);
            int seed =  BitConverter.ToInt32(bytes, 0);
            Random random = new Random(seed);
            return random.Next(start, end);
        }

    }

}
