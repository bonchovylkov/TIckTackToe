using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TickTackToe.Models
{
    public class GameOptions
    {
        public int[,] Field { get; set; }
        public bool IsEndGame { get; set; }

        public int  WinnerNumber { get; set; }
    }
}