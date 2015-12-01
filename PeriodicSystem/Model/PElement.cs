﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Media;
using Figures;

namespace Model
{
    public class PElement : NotifyBase
    {

        public String name { get; set; } = "name";
        public String symbol { get; set; } = "sy";
        public int number { get; set; } = 0;
        public double weight { get; set; } = 0.0;
        public int[] shells { get; set; } = new int[7];

        public PElement()
        {
            name = "name";
            symbol = "sym";
            number = 0;
            weight = 0;
            shells = new int[7];

        }

        public PElement(String name, String symbol, int number, double weight, int[] shells)
        {
            this.name = name;
            this.symbol = symbol;
            this.number = number;
            this.weight = weight;
			for (int i = 0; i < shells.Length; i++)
			{
				this.shells[i] = shells[i];
			}
        }

		public String toString()
		{
			return String.Format("", name, " ", symbol, " ", number, " ", weight, " ", shells);
		}

    }
}
