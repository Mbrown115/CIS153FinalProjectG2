using System;
using System.Collections.Generic;

namespace CIS153_GitHubFinal
{
    public class line
    {
        private cell a;
        private cell b;
        private bool no_slope = false;
        private float slope;
        private float length;
        private float y_intercept;
        private List<cell> points_on_line = new List<cell>();

        public line(float y1, float x1, float y2, float x2)
        {
            this.a = new cell(x1, y1);
            this.b = new cell(x2, y2);
            setup();
        }

        public line(cell a, cell b)
        {
            this.a = a;
            this.b = b;
            setup();
        }

        public void setup()
        {
            figure_slope();
            figure_length();
            get_y_intercept();
        }

        public bool same(line l)
        {
            bool status = false;
            if ((this.a.same(l.a)) && (this.b.same(l.b)))
            {
                status = true;
            }
            return (status);
        }

        public float get_length()
        {
            return (this.length);
        }

        public bool get_no_slope()
        {
            return (no_slope);
        }

        public List<cell> get_points_on_line()
        {
            return (this.points_on_line);
        }

        public float get_slope()
        {
            return (this.slope);
        }

        public void add_point(cell p)
        {
            this.points_on_line.Add(p);

        }

        public bool point_on_line(cell p)
        {
            bool on_line = false;
            if (this.is_vertical())
            {
                if (p.get_x() == a.get_x())
                {
                    on_line = true;
                }
            }
            else
            {
                if (p.get_y() == this.slope * p.get_x() + this.y_intercept)
                {
                    on_line = true;
                }
            }
            return (on_line);
        }

        public bool is_vertical()
        {
            bool vertical = false;
            if (a.get_x() == b.get_x())
            {
                vertical = true;
            }
            return (vertical);
        }

        public void get_y_intercept()
        {
            float m = this.slope;
            this.y_intercept = (float)this.a.get_y() - m * this.a.get_x();
        }

        public void figure_length()
        {
            this.length = (float)Math.Sqrt(Math.Pow((b.get_x() - a.get_x()), 2) + Math.Pow((b.get_y() - a.get_y()), 2));
        }

        public void figure_slope()
        {
            try
            {
                this.slope = (this.b.get_y() - this.a.get_y()) / (this.b.get_x() - this.a.get_x());
                this.no_slope = false;
            }
#pragma warning disable 0168
            catch (DivideByZeroException e)
#pragma warning restore 0168
            {
                this.no_slope = true;
            }
            if (Double.IsNaN(this.slope) || Double.IsInfinity(this.slope))
            {
                this.no_slope = true;
            }
        }

        public void display()
        {
            string slope = this.slope.ToString();
            if (this.no_slope == true)
            {
                slope = "no_slope";
            }
            Console.WriteLine("ax: {0}, ay: {1}, bx: {2}, by: {3}, slope: {4}, length: {5}", this.a.get_x(), this.a.get_y(), this.b.get_x(), this.b.get_y(), slope.PadLeft(8, ' '), this.length);
        }

    }
}
