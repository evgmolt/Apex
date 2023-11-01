using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApexCardio
{
    public struct SingleData
    {
        public double[] MainData;
        public double[] FirstDerivData;
        public double[] SecDerivData;
        public double[] FirstDerivNorm;
        public double[] SecDerivNorm;
        public string Name;
    }


    public partial class FormEditMarkers : Form
    {
        public string[] ReoVisirsName = { "0", "1", "2", "3", "4", "0" };
        public string[] SphigmoVisirsName = { "0", "1", "2", "3", "4", "5", "6", "7", "0" };
        public string[] ApexVisirsName = { "T0", "T1", "T2", "T3", "T4", "T5", "T6", "T7", "T8", "T0" };
        public string[] StringNames = { "Length", "1d aver", "1d max", "1d min", "2d aver", "2d max", "2d min" };

        private struct FieldInfo
        {
            public BufferedPanel BufPanel;
            public string Name;
        }

        List<List<int>> VisirsList;
        List<FieldInfo> FInfoList;
        List<SingleData> Data;
        List<List<double>> ResultListFirst;
        List<List<double>> ResultListSec;
        public List<List<double>> ResultList;
        public List<List<double>> ApexResultResultList; /*Здесь живут списки:
        - длительность фаз
        - первая производная среднее за каждую фазу
        - первая производная мин за каждую фазу
        - первая производная макс за каждую фазу
        - вторая производная среднее за каждую фазу
        - вторая производная мин за каждую фазу
        - вторая производная макс за каждую фазу
                                                         */
        public List<string> NameList;
        private bool MoveVisirNow;
        private int NumOfVisir;
        private bool FocusVisir;
        private int VisirX;
        private int DerivNum; //0 - no, 1 - first, 2 - second
        int ScaleX = 4;
        int Shift;
        int Size;

        public FormEditMarkers(List<SingleData> data, int shift, int size)
        {
            InitializeComponent();
            Data = data;
            Shift = shift;
            Size = size;
/**            foreach (SingleData s in Data)
            {
                DataProcessing.Norm(s.FirstDerivData);
                DataProcessing.Norm(s.SecDerivData);
            }**/
            FInfoList = new List<FieldInfo>();
            VisirsList = new List<List<int>>();
            NameList = new List<string>();
            for (int i = 0; i < Data.Count(); i++)
            {
                VisirsList.Add(new List<int>());
                NameList.Add(Data[i].Name);
            }
            ResultListFirst = new List<List<double>>();
            ResultListSec = new List<List<double>>();
            ResultList = new List<List<double>>();
            ApexResultResultList = new List<List<double>>();
            CreateVisirs();
            DerivNum = 2;
            UpdateGr();
            Calc();
        }

        private void CreateVisirs()
        {
            int NumOfReoVisirs = 6;
            int NumOfSphigmoVisirs = 9;
            int NumOfApexVisirs = 10;
            int Step = 20;
            for (int i = 0; i < Data.Count(); i++)
            {
                if ((NameList[i] == ApexConstants.Reo1name) | (NameList[i] == ApexConstants.Reo2name))
                {
                    for (int k = 0; k < NumOfReoVisirs; k++)
                    {
                        VisirsList[i].Add(Step * (k + 1));
                    }
                }
                if ((NameList[i] == ApexConstants.Sphigmo1name) | (NameList[i] == ApexConstants.Sphigmo2name))
                {
                    for (int k = 0; k < NumOfSphigmoVisirs; k++)
                    {
                        VisirsList[i].Add(Step * (k + 1));
                    }
                }
                if (NameList[i] == ApexConstants.Apexname)
                {
/**                    for (int k = 0; k < NumOfApexVisirs; k++)
                    {
                        VisirsList[i].Add(Step * (k + 1));
                    }**/
                    VisirsList[i] = DataProcessing.FindPoints(Data[i].SecDerivData, Size, Shift);
                }
            }
        }

        private double GetAver(double[] data, int start, int stop)
        {
            double sum = 0;
            for (int i = start; i < stop; i++)
            {
                sum = sum + Math.Abs(data[i]);
            }
            return sum / (stop - start);
        }

        private double GetMin(double[] data, int start, int stop)
        {
            double min = 1000000;
            for (int i = start; i < stop; i++)
            {
                min = Math.Min(data[i], min);
            }
            return min;
        }

        private double GetMax(double[] data, int start, int stop)
        {
            double max = -1000000;
            for (int i = start; i < stop; i++)
            {
                max = Math.Max(data[i], max);
            }
            return max;
        }

        private List<double> CountMaxList(List<int> points, double[] data)
        {
            var res = new List<double>();
            for (int i = 0; i < points.Count() - 1; i++)
            {
                res.Add(GetMax(data, points[i], points[i + 1]));
            }
            return res;
        }

        private List<double> CountMinList(List<int> points, double[] data)
        {
            var res = new List<double>();
            for (int i = 0; i < points.Count() - 1; i++)
            {
                res.Add(GetMin(data, points[i], points[i + 1]));
            }
            return res;
        }

        private List<double> CountAverList(List<int> points, double[] data)
        {
            var res = new List<double>();
            for (int i = 0; i < points.Count() - 1; i++)
            {
                res.Add(GetAver(data, points[i], points[i + 1]));
            }
            return res;
        }

        private List<double> CountTimeList(List<int> points)
        {
            var res = new List<double>();
            double l;
            for (int i = 0; i < points.Count() - 1; i++)
            {
                l = points[i + 1] - points[i];
                l = l / 125;
                res.Add(l);
//                res.Add((points[i+1] - points[i]) / 125);
            }
            return res;
        }

        private List<double> CountResult(List<int> points, double[] data1, double[] data2)
        {
            var res = new List<double>();
            double First;
            double Second;
            for (int i = 0; i < points.Count() - 1; i++)
            {
                First = GetAver(data1, points[i], points[i + 1]);
                Second = GetAver(data2, points[i], points[i + 1]);
                res.Add(First * Second * (points[i + 1] - points[i]));
            }
            return res;
        }

        private void UpdateGr()
        {
            foreach (FieldInfo fi in FInfoList)
            {
                if (fi.BufPanel != null) fi.BufPanel.Dispose();
                panelGraph.Controls.Remove(fi.BufPanel);
            }
            int NumOfFields = Data.Count();
            int space = 1;
            int Y = 0;
            int singleHeight = panelGraph.Height / NumOfFields - space;

            for (int i = 0; i < NumOfFields; i++)
            {
                FieldInfo fi;
                fi.BufPanel = null;
                fi.BufPanel = new BufferedPanel(i);
                fi.BufPanel.Paint += bufPanelEditMarkers_Paint;
                fi.BufPanel.MouseMove += bufpanelMouseMove;
                fi.BufPanel.MouseDown += bufpanelMouseDown;
                fi.BufPanel.MouseUp += bufpanelMouseUp;
                fi.BufPanel.MouseDoubleClick += bufpanelMouseDoubleClick;
                fi.BufPanel.Location = new Point(space, Y + space);
                Y = Y + singleHeight + space;
//                fi.BufPanel.Size = new Size(panelGraph.Width - space, singleHeight);
                fi.BufPanel.Size = new Size( ScaleX * (Size), singleHeight);
                panelGraph.Controls.Add(fi.BufPanel);
                fi.Name = Data[i].Name;
                FInfoList.Add(fi);
                fi.BufPanel.Refresh();
            }
        }

        private void PaintCurve(Control panel, double[] data, Color color, PaintEventArgs e)
        {
            double Max = -1000000;
            double Min = 1000000;
            for (int i = 0; i < data.Length; i++)
            {
                Max = Math.Max(Max, data[i]);
                Min = Math.Min(Min, data[i]);
            }
            Max = Max - Min;
            Max = (int)Math.Round(Max * 2);
//            Max = Max + Max / 2;
            float tension = 0.1F;
            Point[] PaintArray = ViewArrayMaker.MakeArrayForView(panel, data, 0, Max, 1, ScaleX);

            var pen = new Pen(color, 1);
            e.Graphics.DrawCurve(pen, PaintArray, tension);
            pen.Dispose();
        }
        
        private void bufPanelEditMarkers_Paint(object sender, PaintEventArgs e)
        {
            int num = ((BufferedPanel)sender).Number;
            var R0 = e.ClipRectangle;
            var pen0 = new Pen(Color.Black, 1);
            e.Graphics.Clear(Color.White);
            e.Graphics.DrawRectangle(pen0, R0);
            Font f = new Font("Arial", 16);
            SolidBrush b = new SolidBrush(Color.Black);
            e.Graphics.DrawString(Data[num].Name, f, b, new PointF(5,5)); 
            f.Dispose();
            b.Dispose();
                            
            double[] DataArr = Data[num].MainData;
            double[] DerivArr1 = null;
            double[] DerivArr2 = null;
            switch (DerivNum)
            {
                case 0 : 
                    DerivArr1 = null;
                    DerivArr2 = null;
                    break;
                case 1 : 
                    DerivArr1 = Data[num].FirstDerivData;
                    break;
                case 2 : 
//                    DerivArr1 = Data[num].FirstDerivData;
                    DerivArr2 = Data[num].SecDerivData;
                    break;
            }
            PaintCurve((BufferedPanel)sender, DataArr, Color.Black, e);
            if (DerivArr1 != null)
            {
                PaintCurve((BufferedPanel)sender, DerivArr1, Color.Blue, e);
            }
            if (DerivArr2 != null)
            {
                PaintCurve((BufferedPanel)sender, DerivArr2, Color.Green, e);
            }
            var pen = new Pen(Color.Red, 1);
            int Y = R0.Height / 2;
            e.Graphics.DrawLine(pen, 0, Y, R0.Width, Y);

            var pen1 = new Pen(Color.Green, 1);
            e.Graphics.DrawLine(pen1, Shift * ScaleX, 0, Shift * ScaleX, R0.Height);
            e.Graphics.DrawLine(pen1, ScaleX * (Size - Shift), 0, ScaleX * (Size - Shift), R0.Height);

            Font ff = new Font("Arial", 8);
            SolidBrush bb = new SolidBrush(Color.Red);


            if (Data[num].Name != ApexConstants.ECG1name & Data[num].Name != ApexConstants.ECG2name)
            {
                for (int i = 0; i < VisirsList[num].Count(); i++)
                {
                    e.Graphics.DrawLine(pen, VisirsList[num][i] * ScaleX, 0, VisirsList[num][i] * ScaleX, R0.Height);
                    if ((NameList[num] == ApexConstants.Reo1name) | (NameList[num] == ApexConstants.Reo2name))
                    {
                        e.Graphics.DrawString(ReoVisirsName[i], ff, bb, new PointF(VisirsList[num][i] * ScaleX, 0));
                    }
                    if ((NameList[num] == ApexConstants.Sphigmo1name) | (NameList[num] == ApexConstants.Sphigmo2name))
                    {
                        e.Graphics.DrawString(SphigmoVisirsName[i], ff, bb, new PointF(VisirsList[num][i] * ScaleX, 0));
                    }
                    if (NameList[num] == ApexConstants.Apexname)
                    {
                        e.Graphics.DrawString(ApexVisirsName[i], ff, bb, new PointF(VisirsList[num][i] * ScaleX, 0));
                    }
                }
            }
            pen.Dispose();
            ff.Dispose();
            bb.Dispose();
        }

        private void bufpanelMouseDown(object sender, MouseEventArgs e)
        {
            int num = ((BufferedPanel)sender).Number;
            if (FocusVisir)
            {
                MoveVisirNow = true;
                int i1 = VisirsList[num].BinarySearch(e.X / ScaleX);
/*                int i2 = VisirsList[num].BinarySearch(e.X - 1);
                int i3 = VisirsList[num].BinarySearch(e.X + 1);
                if (i1 >= 0)
                {
                    NumOfVisir = i1;
                }
                else
                {
                    if (i2 >= 0)
                    {
                        NumOfVisir = i2;
                    }
                    else
                    {
                        NumOfVisir = i3;
                    }
                }*/
                NumOfVisir = i1;
                if (e.Button == MouseButtons.Left)
                {
                    VisirX = e.X / ScaleX;
                }
                if (e.Button == MouseButtons.Right)
                {
                    VisirsList[num].RemoveAt(NumOfVisir);
                    ((BufferedPanel)sender).Refresh();
                    MoveVisirNow = false;
                    NumOfVisir = -1;
                }
            }
        }

        private void bufpanelMouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                MoveVisirNow = false;
            }
        }

        private void bufpanelMouseDoubleClick(object sender, MouseEventArgs e)
        {
            int num = ((BufferedPanel)sender).Number;
            if (e.Button == MouseButtons.Left)
            {
                VisirsList[num].Add(e.X / 2);
                VisirsList[num].Sort();
                ((BufferedPanel)sender).Refresh();
            }
        }

        private void bufpanelMouseMove(object sender, MouseEventArgs e)
        {
            int num = ((BufferedPanel)sender).Number;
            if (MoveVisirNow)
            {
                VisirsList[num][NumOfVisir] = e.X / ScaleX;
                VisirsList[num].Sort();
                ((BufferedPanel)sender).Refresh();
            }
            if (VisirsList[num].Contains(e.X / ScaleX)) //| VisirsList[num].Contains(e.X - 1) | VisirsList[num].Contains(e.X + 1))
            
            {
                this.Cursor = Cursors.VSplit;
                FocusVisir = true;
            }
            else
            {
                this.Cursor = Cursors.Default;
                FocusVisir = false;
            }
        }


        private void FormEditMarkers_Resize(object sender, EventArgs e)
        {
            UpdateGr();
        }



        private void Calc()
        {
            double[] data = null;
            List<List<double>> reslist = null;
            int n = 0;
            for (int i = 0; i < Data.Count(); i++)
            {
                if (Data[i].Name == ApexConstants.Apexname)
                {
                    n = i;
                    break;
                }
            }
//            ResultList.Clear();
//            ResultList.Add(CountResult(VisirsList[n], Data[n].FirstDerivNorm, Data[n].SecDerivNorm));
            ApexResultResultList.Clear();
            ApexResultResultList.Add(CountTimeList(VisirsList[n]));
            ApexResultResultList.Add(CountAverList(VisirsList[n], Data[n].FirstDerivNorm));
            ApexResultResultList.Add(CountMaxList(VisirsList[n], Data[n].FirstDerivNorm));
            ApexResultResultList.Add(CountMinList(VisirsList[n], Data[n].FirstDerivNorm));
            ApexResultResultList.Add(CountAverList(VisirsList[n], Data[n].SecDerivNorm));
            ApexResultResultList.Add(CountMaxList(VisirsList[n], Data[n].SecDerivNorm));
            ApexResultResultList.Add(CountMinList(VisirsList[n], Data[n].SecDerivNorm));

            //NameList.Add(Data[n].Name);
/**
            for (int i = 0; i < VisirsList.Count(); i++)
            {
                switch (DerivNum)
                {
                    case 0:
                        data = null;
                        break;
                    case 1:
                        reslist = ResultListFirst;
                        data = Data[i].FirstDerivNorm;
                        break;
                    case 2:
                        reslist = ResultListSec;
                        data = Data[i].SecDerivNorm;
                        break;
                }
                if (Data[i].Name != ApexConstants.ECG1name & Data[i].Name != ApexConstants.ECG2name)
                {
                    reslist.Add(CountResult(VisirsList[i], data));
                    NameList.Add(Data[i].Name);
                }
                else
                {
                    reslist.Add(null);
                    NameList.Add(null);
                }
            }**/
            AppendDataFromList(ApexResultResultList);
            Refresh();
        }


        private void AppendDataFromList(List<List<double>> reslist)
        {
            tbResult.Clear();

            Char tab = Convert.ToChar(9);
            string ApexHeader = "Phase:" + tab + "T0-T1" + tab + "T1-T2" + tab + "T2-T3" + tab + "T3-T4" + tab + "T4-T5" + tab + "T5-T6" + tab + "T6-T7" + tab + "T7-T8" + tab + "T8-T0";
//            string SphigmoHeader = "0-1" + tab + "1-2" + tab + "2-3" + tab + "3-4" + tab + "4-5" + tab + "5-6" + tab + "6-7" + tab + "7-0";
//            string ReoHeader = "0-1" + tab + "1-2" + tab + "2-3" + tab + "3-4" + tab + "4-0";
            tbResult.AppendText(ApexHeader + Environment.NewLine);
            for (int k = 0; k < reslist.Count(); k++)
            {
                string s = StringNames[k] + tab;
//                string s = "";
                for (int i = 0; i < reslist[k].Count(); i++)
                {
                   s += String.Format("{0:0.000}", Convert.ToDouble(reslist[k][i])) + tab;
                }
                tbResult.AppendText(s + Environment.NewLine);
            }
            return;

/**
            for (int k = 0; k < reslist.Count(); k++)
            {
                string s = "";
                if ((names[k] != ApexConstants.ECG1name) | (names[k] != ApexConstants.ECG2name))
                {
                    tbResult.AppendText(names[k] + Environment.NewLine);
                }
                if (reslist[k] != null)
                {
                    for (int i = 0; i < reslist[k].Count(); i++)
                    {
                        s += String.Format("{0:0.00}", Convert.ToDouble(reslist[k][i])) + Convert.ToChar(9);
                    }
                    if (names[k] == ApexConstants.Apexname)
                    {
                        tbResult.AppendText(ApexHeader + Environment.NewLine);
                    }
                    if ((names[k] == ApexConstants.Sphigmo1name) | (names[k] == ApexConstants.Sphigmo2name))
                    {
                        tbResult.AppendText(SphigmoHeader + Environment.NewLine);
                    }
                    if ((names[k] == ApexConstants.Reo1name) | (names[k] == ApexConstants.Reo2name))
                    {
                        tbResult.AppendText(ReoHeader + Environment.NewLine);
                    }
                    tbResult.AppendText(s + Environment.NewLine);
                    tbResult.AppendText(Environment.NewLine);
                }
            }**/
        }

        private void butOk_Click(object sender, EventArgs e)
        {
            Calc();

        }

    }
}
