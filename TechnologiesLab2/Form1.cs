﻿using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace TechnologiesLab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            GetCountThreadAndCountOfIntervals(out long countOfInterval, out int countThreads,out int maxCountThread);
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            double result = new IntegralCalculator().Calculate(1, 4, countOfInterval, new Function(), countThreads,maxCountThread);
            stopwatch.Stop();
            PrintResultAndTime(result, stopwatch);
        }

        private void GetCountThreadAndCountOfIntervals(out long countOfIntervals, out int countThreads,out int maxCountThread)
        {
            countOfIntervals = long.Parse(textBoxCountOfIntervals.Text);
            countThreads = int.Parse(textBoxThreads.Text);
            maxCountThread = int.Parse((textBoxMaxCountThreads.Text));
        }

        private void PrintResultAndTime(double result, Stopwatch stopwatch)
        {
            labelResult.Text = $"Результат: {result:F6}";
            labelTime.Text = $"Час виконання: {stopwatch.ElapsedMilliseconds} мс";
        }
    }
}
